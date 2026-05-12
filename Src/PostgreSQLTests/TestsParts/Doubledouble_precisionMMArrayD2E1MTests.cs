

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
    internal partial interface IDoubleMArraydouble_precisionMMArrayD2
    {
    }
    
    internal partial class DoubleMArraydouble_precisionMMArrayD2 : IDoubleMArraydouble_precisionMMArrayD2
    {


#region TestData

        private readonly Doubledouble_precisionMMArrayD2E1M[] _testData = new Doubledouble_precisionMMArrayD2E1M[]
        {
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 9,
    Value = 
new System.Double[,] { { 0.10666141011444652d, 0.4886142751479392d, }, { 0.2108880039358887d, 0.7716483518895543d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.10244046344686708d, 0.5726797839448398d, }, { 0.972614184035337d, 0.5124759309442503d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 12,
    Value = 
new System.Double[,] { { 0.38417941839676906d, 0.41358109118239206d, }, { 0.13232144646970956d, 0.05357076779891545d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 2,
    Value = 
new System.Double[,] { { 0.8944038780580976d, 0.10879190299046015d, }, { 0.15776957906158318d, 0.02466062088287324d, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 21,
    Value = 
new System.Double[,] { { 0.05772031262583832d, 0.2707845811383327d, }, { 0.9860545179024196d, 0.8643056554996656d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.7191742414649198d, 0.4853495251078862d, }, { 0.7511919951846798d, 0.28823635909028567d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 24,
    Value = 
new System.Double[,] { { 0.861449662475898d, 0.7130070150146365d, }, { 0.8381080343565019d, 0.9695499417195244d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 10,
    Value = 
new System.Double[,] { { 0.16179823244969183d, 0.5980244985072056d, }, { 0.990797996324588d, 0.64587034662159d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.8567918890494505d, 0.6846922154449839d, }, { 0.4149414370615979d, 0.05611568345189888d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 31,
    Value = 
new System.Double[,] { { 0.6678009088616575d, 0.09214456775077717d, }, { 0.9022467223440784d, 0.57622445265277d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.014119872437106551d, 0.18626015068928636d, }, { 0.1620857206579076d, 0.1792260758010421d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 34,
    Value = 
new System.Double[,] { { 0.9286401776618874d, 0.40590039267823796d, }, { 0.7545982024210587d, 0.436064499171829d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 19,
    Value = 
new System.Double[,] { { 0.8390960423453505d, 0.1443093149312935d, }, { 0.06882819674236829d, 0.5708635610602014d, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 43,
    Value = 
new System.Double[,] { { 0.6558197818411613d, 0.8731251589200968d, }, { 0.05795320386561009d, 0.4702672678380184d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.7956809636714004d, 0.9563971712894431d, }, { 0.8463425321372869d, 0.8301977857663246d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 48,
    Value = 
new System.Double[,] { { 0.39112799457265546d, 0.326610381554137d, }, { 0.4720192986364984d, 0.6214770231447541d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 26,
    Value = 
new System.Double[,] { { 0.5355036643873268d, 0.6027459013268371d, }, { 0.6892131976073476d, 0.9137207159952182d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.8853230019663392d, 0.12422761627462064d, }, { 0.15928899055044798d, 0.029854712741996692d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 51,
    Value = 
new System.Double[,] { { 0.38686307458354163d, 0.9165079943310928d, }, { 0.6506610498142613d, 0.12608252378159235d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 60,
    Value = 
new System.Double[,] { { 0.4863027728878685d, 0.7722368827140995d, }, { 0.38197507176421286d, 0.030901216974341783d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 31,
    Value = 
new System.Double[,] { { 0.32012201415713526d, 0.195901771231212d, }, { 0.9875336683561005d, 0.7772115160070289d, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 69,
    Value = 
new System.Double[,] { { 0.5499129790023126d, 0.8504250487324114d, }, { 0.1321781310839052d, 0.6809596268235647d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 72,
    Value = 
new System.Double[,] { { 0.24551383454014108d, 0.29971269061527595d, }, { 0.47019498937044d, 0.7757869146838157d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 37,
    Value = 
new System.Double[,] { { 0.7642246243001571d, 0.6432285622157536d, }, { 0.9531108435856392d, 0.77618605485043d, }, },
    NullableValue = 
new System.Double[,] { { 0.557103073873888d, 0.6663347883487587d, }, { 0.9974715648153515d, 0.3952784499506945d, }, },
},
    NullableValue = 
new System.Double[,] { { 0.14855293744491704d, 0.792674719620649d, }, { 0.7775367706543089d, 0.2124676167869246d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 73,
    Value = 
new System.Double[,] { { 0.5668768385102224d, 0.7557397928471897d, }, { 0.2844174462198803d, 0.8023983830739079d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 77,
    Value = 
new System.Double[,] { { 0.26164610372599983d, 0.30115074660507324d, }, { 0.25168693235570716d, 0.525660895593144d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 43,
    Value = 
new System.Double[,] { { 0.8164301415537384d, 0.23259067660327748d, }, { 0.9042239048117784d, 0.09463736260975786d, }, },
    NullableValue = 
new System.Double[,] { { 0.17482433055001345d, 0.49159787358301177d, }, { 0.4371322757996161d, 0.5988776186278121d, }, },
},
    NullableValue = 
new System.Double[,] { { 0.3913003545679463d, 0.470149485278581d, }, { 0.10029651692080488d, 0.38939880496042234d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 86,
    Value = 
new System.Double[,] { { 0.6128873334181978d, 0.412208432470199d, }, { 0.11494019639150554d, 0.9514329694541142d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 95,
    Value = 
new System.Double[,] { { 0.5317453812838634d, 0.7758282293601504d, }, { 0.6292371424492981d, 0.6600585604949039d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 50,
    Value = 
new System.Double[,] { { 0.057688803411128475d, 0.16958337450608318d, }, { 0.8298824703877332d, 0.375694365161351d, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 99,
    Value = 
new System.Double[,] { { 0.391725953684261d, 0.46649805677870526d, }, { 0.4546940548070859d, 0.5647764305407541d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 102,
    Value = 
new System.Double[,] { { 0.7481912740669587d, 0.9824583913617304d, }, { 0.3830564712478154d, 0.23486564697480328d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 59,
    Value = 
new System.Double[,] { { 0.3129528602380037d, 0.3086099531683738d, }, { 0.30006355418618713d, 0.5822961855899479d, }, },
    NullableValue = 
new System.Double[,] { { 0.34584253038585366d, 0.15180294574412168d, }, { 0.307303982854357d, 0.929991894001784d, }, },
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 104,
    Value = 
new System.Double[,] { { 0.5775980876449364d, 0.8202381019251074d, }, { 0.7388406321885767d, 0.7152765475943298d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 107,
    Value = 
new System.Double[,] { { 0.8733585156941571d, 0.08542027507550376d, }, { 0.064758255583933d, 0.28808699122642933d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 63,
    Value = 
new System.Double[,] { { 0.4205802419483047d, 0.2305280181248377d, }, { 0.5233859238794228d, 0.24426421054781955d, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 113,
    Value = 
new System.Double[,] { { 0.07832512300648808d, 0.06751260400508008d, }, { 0.8044324369151129d, 0.357384996130065d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.44555251197990786d, 0.6488468664524001d, }, { 0.7983444962759044d, 0.9531721766907886d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 122,
    Value = 
new System.Double[,] { { 0.8032374952210759d, 0.376509324175774d, }, { 0.8318115522830216d, 0.14283885999307455d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 68,
    Value = 
new System.Double[,] { { 0.7554827667095408d, 0.20360969936193996d, }, { 0.567617535652062d, 0.012865399956185408d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.5791729825643526d, 0.4061676934794163d, }, { 0.28325627265481546d, 0.8508662600445601d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 129,
    Value = 
new System.Double[,] { { 0.44392328642046575d, 0.8187745020220089d, }, { 0.00453984008000774d, 0.7893931942457724d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.48458231425629394d, 0.45925072834866154d, }, { 0.13657608819444667d, 0.07070575485337849d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 134,
    Value = 
new System.Double[,] { { 0.8156264595025577d, 0.5320764081208538d, }, { 0.4770753213046476d, 0.9600723273220381d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 73,
    Value = 
new System.Double[,] { { 0.06759456791434304d, 0.05372330779290013d, }, { 0.12977537255908445d, 0.8066815827396399d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.18721899249624785d, 0.23159249208714727d, }, { 0.24621133768657266d, 0.12883108544184063d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 141,
    Value = 
new System.Double[,] { { 0.9812014556633204d, 0.5138912078279195d, }, { 0.7342327127988371d, 0.6746917860461843d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 143,
    Value = 
new System.Double[,] { { 0.5506313896164333d, 0.4389002247761279d, }, { 0.9248200532304748d, 0.43450894478223256d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 82,
    Value = 
new System.Double[,] { { 0.1412408450580328d, 0.9634950486670741d, }, { 0.7936242299115736d, 0.2525011343672994d, }, },
    NullableValue = 
new System.Double[,] { { 0.1216382880706599d, 0.0846552381455783d, }, { 0.8266130878100587d, 0.17054812545801912d, }, },
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 145,
    Value = 
new System.Double[,] { { 0.6711057447069496d, 0.5585487873960906d, }, { 0.6192682422886154d, 0.7240932443348882d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.39760037726595165d, 0.06931691643899307d, }, { 0.8959014291920521d, 0.5149864970356578d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 153,
    Value = 
new System.Double[,] { { 0.8565173799178402d, 0.2011244453993315d, }, { 0.30020293874712667d, 0.3761058931772523d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 87,
    Value = 
new System.Double[,] { { 0.4205511118729618d, 0.8091548828149308d, }, { 0.7808764630250317d, 0.8427363188352993d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.15997052259225808d, 0.7861098593070232d, }, { 0.45276920146484634d, 0.05385504826343934d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 156,
    Value = 
new System.Double[,] { { 0.045202775496638314d, 0.9027064680030393d, }, { 0.5156367443726101d, 0.24077384305942728d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.33225954733824714d, 0.32088734182550394d, }, { 0.39767003652473365d, 0.8043392402255252d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 165,
    Value = 
new System.Double[,] { { 0.3222807927723733d, 0.016326244335150175d, }, { 0.7997246865115505d, 0.38629851955802397d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 88,
    Value = 
new System.Double[,] { { 0.44522289249000124d, 0.5065334244923742d, }, { 0.9353813580905378d, 0.7807327413141184d, }, },
    NullableValue = 
new System.Double[,] { { 0.37880599427026784d, 0.9507475555633667d, }, { 0.4652661914280922d, 0.7345965928893654d, }, },
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 168,
    Value = 
new System.Double[,] { { 0.4387810704240218d, 0.23930769370680827d, }, { 0.023167222814702404d, 0.5178618252843218d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.7134243230411135d, 0.0308728920119814d, }, { 0.8164282381827037d, 0.16495354322074907d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 169,
    Value = 
new System.Double[,] { { 0.2655023718178229d, 0.3733191676720219d, }, { 0.7970606011877497d, 0.2313877213368397d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 91,
    Value = 
new System.Double[,] { { 0.2975395869706281d, 0.028739074854458813d, }, { 0.6951351908042258d, 0.7983211110218156d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.5145762387789655d, 0.5279883089847416d, }, { 0.015022302704125967d, 0.8144323734119432d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 175,
    Value = 
new System.Double[,] { { 0.8722241257060237d, 0.9507375165934355d, }, { 0.38657303881095206d, 0.8248042807280114d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 182,
    Value = 
new System.Double[,] { { 0.13522544485731314d, 0.5990192227565836d, }, { 0.02692410969593184d, 0.7725321172971817d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 92,
    Value = 
new System.Double[,] { { 0.6313301759482514d, 0.014272481492138667d, }, { 0.9287863861556634d, 0.16985990323485156d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.6866839448258134d, 0.4921849038507723d, }, { 0.20816975542461158d, 0.7037733769594474d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 184,
    Value = 
new System.Double[,] { { 0.584857901181574d, 0.493802101169069d, }, { 0.442188858552123d, 0.6345982545507548d, }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd2e1mi(
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd2e1mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]), 
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

                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmmarrayd2e1mi_id
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionmmarrayd2e1mi_id", 
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
                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmmarrayd2e1mi_id
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
    doubledouble_precisionmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                System.Double[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[,]>();
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable =  ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[,] { { 0.014119872437106551d, 0.18626015068928636d, }, { 0.1620857206579076d, 0.1792260758010421d, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[,]>();
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable =  ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Double[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[,]>();
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[,] { { 0.7956809636714004d, 0.9563971712894431d, }, { 0.8463425321372869d, 0.8301977857663246d, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[,]>();
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[,] { { 0.8853230019663392d, 0.12422761627462064d, }, { 0.15928899055044798d, 0.029854712741996692d, }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmmarrayd2e1mi_id
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
    doubledouble_precisionmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionmmarrayd2e1mi_id", 
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
                System.Double[,] nullable = null;
                nullable =  ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Double[,] nullable = null;
                nullable = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[,] { { 0.14855293744491704d, 0.792674719620649d, }, { 0.7775367706543089d, 0.2124676167869246d, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionMMArrayD2E1M> models = null;

                models =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionMMArrayD2E1M> models = null;

                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M), typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd2e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M), typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd2e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M), typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 175;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 169;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 175;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 34;
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd2e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                var models = await((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 168;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M), typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 141, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 48, query1, 129, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 143, query1, 169, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 156, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 175, query1, 175, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 104, query1, 143, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 104, query1, 51, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 104, query1, 175, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd2e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                var models = await((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 34, 175))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 60, 12))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
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
                await using var cmd = await ((IDoubleMArraydouble_precisionMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleMArraydouble_precisionMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 21);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleMArraydouble_precisionMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleMArraydouble_precisionMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 165);
                var models =  ((IDoubleMArraydouble_precisionMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
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
FROM public.binary_doubledouble_precisionmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD2E1MIWA),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD2E1MI),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleMArraydouble_precisionMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleMArraydouble_precisionMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precisionMMArrayD2E1M),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
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
FROM public.binary_doubledouble_precisionmmarrayd2e1m m
LEFT JOIN public.binary_doubledouble_precisionmmarrayd2e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleMArraydouble_precisionMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleMArraydouble_precisionMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models =  ((IDoubleMArraydouble_precisionMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA), typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
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
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
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
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA), typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
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
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
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
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MI), typeof(Doubledouble_precisionMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MI>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MI>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MI>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MI>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA), typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

