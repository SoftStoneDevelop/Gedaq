

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
    internal partial interface IDoubleMArraydouble_precisionMMArrayD1
    {
    }
    
    internal partial class DoubleMArraydouble_precisionMMArrayD1 : IDoubleMArraydouble_precisionMMArrayD1
    {


#region TestData

        private readonly Doubledouble_precisionMMArrayD1E1M[] _testData = new Doubledouble_precisionMMArrayD1E1M[]
        {
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 1,
    Value = 
new System.Double[4]
{
0.7750768593461395d,
0.665679840949725d,
0.17435490162261202d,
0.9955334763038269d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.7492593380911113d,
0.16353083106475852d,
0.06110458574670985d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 7,
    Value = 
new System.Double[4]
{
0.3198805906991459d,
0.5583447140988247d,
0.06319028081681133d,
0.655665430191497d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Double[4]
{
0.9838760704854187d,
0.2873464774889394d,
0.2739629973168266d,
0.33613201693170736d,
},
    NullableValue = 
new System.Double[3]
{
0.7703301169518096d,
0.6933465475461862d,
0.7251195131009258d,
},
},
    NullableValue = 
new System.Double[3]
{
0.27480759396547516d,
0.2526225489197802d,
0.05969490704281022d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 14,
    Value = 
new System.Double[4]
{
0.3476164451797761d,
0.29528701904675236d,
0.8457720009333543d,
0.6331682383773898d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.022611297867327407d,
0.03870247745417699d,
0.5259068640541501d,
0.8762329697616049d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 15,
    Value = 
new System.Double[4]
{
0.5628399083026205d,
0.1172459316582386d,
0.9080021044437155d,
0.42431496180627537d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 15,
    Value = 
new System.Double[4]
{
0.34070063160617503d,
0.08411332336763855d,
0.6272997248068022d,
0.17297752026352076d,
},
    NullableValue = 
new System.Double[3]
{
0.6320615210047965d,
0.31388911186311275d,
0.7586446343744218d,
},
},
    NullableValue = 
new System.Double[3]
{
0.22479799426816327d,
0.20108169142877386d,
0.5956722043073537d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 17,
    Value = 
new System.Double[4]
{
0.3015952743213022d,
0.7341720746057351d,
0.17706090293935917d,
0.6995803554025826d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 24,
    Value = 
new System.Double[4]
{
0.32612700660780647d,
0.8252439567464565d,
0.02191238108210425d,
0.5989002371987076d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 21,
    Value = 
new System.Double[3]
{
0.8750233337092959d,
0.8269372731333452d,
0.524135802873509d,
},
    NullableValue = 
new System.Double[3]
{
0.8813153274872267d,
0.4334699818434924d,
0.13944071020579762d,
},
},
    NullableValue = 
new System.Double[4]
{
0.27385281733093714d,
0.5348751337082684d,
0.6696908766085438d,
0.6922126479785916d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 31,
    Value = 
new System.Double[3]
{
0.47242500097940066d,
0.7804345878150768d,
0.6085287616546987d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.02482219598899449d,
0.8646553752787669d,
0.004188424899333909d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 39,
    Value = 
new System.Double[4]
{
0.6804188332999409d,
0.34704000765804865d,
0.9072835035011201d,
0.05640812990770738d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 23,
    Value = 
new System.Double[4]
{
0.01861054134462703d,
0.28560266666206047d,
0.733595787981744d,
0.994860593575981d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 42,
    Value = 
new System.Double[3]
{
0.7032054367880635d,
0.7548998973284655d,
0.1871349691545824d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.629979471863129d,
0.3146319326617336d,
0.509503618356818d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 47,
    Value = 
new System.Double[3]
{
0.6321474798427286d,
0.34426907442977006d,
0.45408167582116d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Double[3]
{
0.06654005142295161d,
0.43820778359435786d,
0.8739159948224282d,
},
    NullableValue = 
new System.Double[3]
{
0.02692126861752997d,
0.6199699523436569d,
0.13873974205707418d,
},
},
    NullableValue = 
new System.Double[3]
{
0.7324364061577346d,
0.7960882166613308d,
0.7269094313580827d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 56,
    Value = 
new System.Double[3]
{
0.4510889708826936d,
0.17618283735340623d,
0.6557427883828268d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.7327794274863207d,
0.525377244365316d,
0.943587737140219d,
0.6287100158130987d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 61,
    Value = 
new System.Double[4]
{
0.33223019958411737d,
0.43015921410072644d,
0.4226844272059669d,
0.14228294694232158d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 31,
    Value = 
new System.Double[3]
{
0.11354014502041587d,
0.5378840108024193d,
0.16830851784456713d,
},
    NullableValue = 
new System.Double[3]
{
0.10587756562367046d,
0.8851818161497981d,
0.8045418760113311d,
},
},
    NullableValue = 
new System.Double[3]
{
0.994010052975927d,
0.20818258086140806d,
0.41796914437931d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 70,
    Value = 
new System.Double[3]
{
0.5163253860471698d,
0.7061196779099798d,
0.9471983503325865d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.3320375017283217d,
0.2296054674165744d,
0.19103461559119295d,
0.2666401148798305d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 73,
    Value = 
new System.Double[3]
{
0.8085194632254338d,
0.5706621950121551d,
0.7520008422658051d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Double[3]
{
0.17954995180245303d,
0.530538794894926d,
0.22775154990956303d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 77,
    Value = 
new System.Double[3]
{
0.2838670588286174d,
0.6077274485052235d,
0.5291865844328284d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.7251128257110618d,
0.020798914710626004d,
0.9443677460962049d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 80,
    Value = 
new System.Double[4]
{
0.02500574779475151d,
0.571297926225063d,
0.9518002754830026d,
0.961232749283955d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 33,
    Value = 
new System.Double[3]
{
0.2671293773949689d,
0.6270368380252179d,
0.25556146570913174d,
},
    NullableValue = 
new System.Double[4]
{
0.38318505868004793d,
0.9356464409283988d,
0.8680351169422819d,
0.5629851813107448d,
},
},
    NullableValue = 
new System.Double[3]
{
0.6768680801292494d,
0.751210333362082d,
0.8924421496885413d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 87,
    Value = 
new System.Double[3]
{
0.8551599925592925d,
0.09134214747875213d,
0.30277217523748245d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 90,
    Value = 
new System.Double[4]
{
0.8897200299785015d,
0.859011488134141d,
0.9386077425914967d,
0.08592685876364692d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 40,
    Value = 
new System.Double[3]
{
0.6585609899814d,
0.6035713268290075d,
0.7056612853677157d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 92,
    Value = 
new System.Double[3]
{
0.6294376473011105d,
0.9011180867720444d,
0.14786606329894048d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.3033484953851716d,
0.9749990855318513d,
0.46214614564897893d,
0.7616863838176382d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 94,
    Value = 
new System.Double[4]
{
0.7405437080212469d,
0.573924893127142d,
0.6570711747123172d,
0.6090199866955571d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 48,
    Value = 
new System.Double[3]
{
0.9278833257491322d,
0.6729833896731051d,
0.8128827486119659d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 97,
    Value = 
new System.Double[4]
{
0.5663430207096142d,
0.5092650265664201d,
0.28249668513527837d,
0.15871849813589578d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.1214541459017573d,
0.1725240862785734d,
0.7344842499056892d,
0.4650049663522624d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 105,
    Value = 
new System.Double[4]
{
0.9450709885347992d,
0.6339613246657126d,
0.8625453614398156d,
0.16421644119342693d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Double[4]
{
0.307466721206771d,
0.7371711361319069d,
0.6358832716516009d,
0.10246211961161689d,
},
    NullableValue = 
new System.Double[4]
{
0.7277837023262611d,
0.0967545960435251d,
0.6978317026242843d,
0.5305050802146649d,
},
},
    NullableValue = 
new System.Double[4]
{
0.010038179862780328d,
0.31292442397567954d,
0.4541759065682248d,
0.9871639678769307d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 108,
    Value = 
new System.Double[3]
{
0.6535601455277283d,
0.8119241807958205d,
0.6363276667093656d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.4528652230656707d,
0.9007861419523093d,
0.6143909706212934d,
0.5115446724582956d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 115,
    Value = 
new System.Double[3]
{
0.9091378364034387d,
0.3617824575332226d,
0.9521569583044396d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 55,
    Value = 
new System.Double[3]
{
0.6664245499181659d,
0.01909679579761836d,
0.4778026016655864d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.4899579791473109d,
0.5627566936672124d,
0.9615308397366622d,
0.2632469812384214d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 122,
    Value = 
new System.Double[4]
{
0.3926733607843115d,
0.7662532091087004d,
0.2294252194148868d,
0.4610391848536207d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.3014869094464573d,
0.18341718397463136d,
0.25635782483421676d,
0.30386076536822215d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 123,
    Value = 
new System.Double[4]
{
0.19329349289363373d,
0.46615468143652405d,
0.6689831538129872d,
0.7750306925926912d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 61,
    Value = 
new System.Double[4]
{
0.13671634145118594d,
0.32929228613465344d,
0.1742798093356661d,
0.7796224345991631d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.47435972019817096d,
0.9367922610522424d,
0.30349506266741866d,
0.15398254594923066d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 132,
    Value = 
new System.Double[3]
{
0.3618687321502453d,
0.6552728321658217d,
0.3007546997235544d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 133,
    Value = 
new System.Double[3]
{
0.9291754651969729d,
0.6080938951032828d,
0.34677695094101935d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 64,
    Value = 
new System.Double[4]
{
0.7682130698163296d,
0.8345536516378808d,
0.5786078423129521d,
0.5604323840008459d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.9526775063710051d,
0.18121055857947788d,
0.8806049036508717d,
0.8556717290367889d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 139,
    Value = 
new System.Double[4]
{
0.3245073716951883d,
0.16232313211493843d,
0.6658046442942905d,
0.4199643446777581d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 140,
    Value = 
new System.Double[4]
{
0.9704950616291041d,
0.800827881342301d,
0.8962408664120087d,
0.013572739900912234d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 73,
    Value = 
new System.Double[3]
{
0.4365930765779614d,
0.2396575696757992d,
0.023749706448830343d,
},
    NullableValue = 
new System.Double[3]
{
0.5243319300813338d,
0.7878198769302437d,
0.18815499155428128d,
},
},
    NullableValue = 
new System.Double[3]
{
0.5744879501705307d,
0.31038721395458524d,
0.9435547552863898d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 146,
    Value = 
new System.Double[4]
{
0.03527196372331853d,
0.03830375791307172d,
0.8337318213852322d,
0.585161316542532d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.4667694648639785d,
0.9392066113707511d,
0.5206400647679297d,
0.9241455622230946d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 147,
    Value = 
new System.Double[4]
{
0.35718463881019824d,
0.07219417494301239d,
0.6288799915090028d,
0.8180729372995612d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 78,
    Value = 
new System.Double[3]
{
0.8758785865864038d,
0.0643983322277053d,
0.20571908827795882d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 149,
    Value = 
new System.Double[4]
{
0.28121263031787747d,
0.5076695173105378d,
0.44490662077369036d,
0.04063723027586541d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 153,
    Value = 
new System.Double[3]
{
0.7214982741165462d,
0.05738090036694121d,
0.9006193272448468d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 81,
    Value = 
new System.Double[4]
{
0.9586059844200754d,
0.8359821731650735d,
0.7567738018894811d,
0.13201117034238186d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.008668962347781917d,
0.08788867650798315d,
0.9889412904229536d,
0.24461676779272268d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 160,
    Value = 
new System.Double[3]
{
0.5552787983815504d,
0.5592592160409025d,
0.9355390947523808d,
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd1e1mi(
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd1e1mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
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

                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmmarrayd1e1mi_id
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionmmarrayd1e1mi_id", 
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
                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmmarrayd1e1mi_id
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
    doubledouble_precisionmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                System.Double[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.27385281733093714d,
0.5348751337082684d,
0.6696908766085438d,
0.6922126479785916d,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Double[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.02482219598899449d,
0.8646553752787669d,
0.004188424899333909d,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmmarrayd1e1mi_id
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
    doubledouble_precisionmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionmmarrayd1e1mi_id", 
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
                System.Double[] nullable = null;
                nullable =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.629979471863129d,
0.3146319326617336d,
0.509503618356818d,
}));
                nullable =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.7324364061577346d,
0.7960882166613308d,
0.7269094313580827d,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Double[] nullable = null;
                nullable = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.7327794274863207d,
0.525377244365316d,
0.943587737140219d,
0.6287100158130987d,
}));
                nullable = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.994010052975927d,
0.20818258086140806d,
0.41796914437931d,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionMMArrayD1E1M> models = null;

                models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionMMArrayD1E1M> models = null;

                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M), typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd1e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M), typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd1e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M), typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 87;
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
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
                parametr2.Value = 147;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd1e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models = await((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M), typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 97, query1, 24, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 1, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 7, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 147, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 146, query1, 90, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 61, query1, 108, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 132, query1, 115, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 108, query1, 47, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd1e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models = await((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 123, 94))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 147, 149))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
                await using var cmd = await ((IDoubleMArraydouble_precisionMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleMArraydouble_precisionMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 15);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleMArraydouble_precisionMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleMArraydouble_precisionMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 24);
                var models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
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
FROM public.binary_doubledouble_precisionmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD1E1MIWA),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD1E1MI),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleMArraydouble_precisionMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleMArraydouble_precisionMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precisionMMArrayD1E1M),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
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
FROM public.binary_doubledouble_precisionmmarrayd1e1m m
LEFT JOIN public.binary_doubledouble_precisionmmarrayd1e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleMArraydouble_precisionMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleMArraydouble_precisionMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA), typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
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
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
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
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA), typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
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
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
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
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MI), typeof(Doubledouble_precisionMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MI>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MI>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MI>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MI>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA), typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

