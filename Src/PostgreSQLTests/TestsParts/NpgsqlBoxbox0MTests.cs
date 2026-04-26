

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
    internal partial interface INpgsqlBoxSingleTypebox
    {
    }
    
    internal partial class NpgsqlBoxSingleTypebox : INpgsqlBoxSingleTypebox
    {


#region TestData

        private readonly NpgsqlBoxbox0M[] _testData = new NpgsqlBoxbox0M[]
        {
            new NpgsqlBoxbox0M
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8886511533461394d,right: 0.6038969727605712d,bottom: 0.016739458904384996d,left: 0.2133716821246895d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6605210464203772d,right: 0.6083422683380039d,bottom: 0.2561898378973917d,left: 0.5103850705650066d),
},
            new NpgsqlBoxbox0M
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.13989229831257888d,right: 0.9393878800918589d,bottom: 0.07983478954752043d,left: 0.5624122986735918d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 1,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7868570248374647d,right: 0.2774520520824867d,bottom: 0.7159861153547953d,left: 0.09916905197935666d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.44206413638530595d,right: 0.5331981259378893d,bottom: 0.08035771860538099d,left: 0.011222367959218493d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5086366628372757d,right: 0.7796078167239561d,bottom: 0.3242805701422651d,left: 0.6554082348450134d),
},
            new NpgsqlBoxbox0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8369002578646827d,right: 0.479624020774273d,bottom: 0.7149847573668071d,left: 0.27133979423995536d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5957485080932979d,right: 0.9980748467444098d,bottom: 0.30005389973040775d,left: 0.24555951087893524d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8945377678984683d,right: 0.5712993737667121d,bottom: 0.06614731260987983d,left: 0.4272092061648062d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.22793686679953784d,right: 0.9377635599931585d,bottom: 0.1422120559919674d,left: 0.12370072991824321d),
},
            new NpgsqlBoxbox0M
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5520145591256015d,right: 0.9636947584960339d,bottom: 0.007069144667258609d,left: 0.2842340755726659d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6147738240115939d,right: 0.5844282935777169d,bottom: 0.08307471863999283d,left: 0.3557012163108315d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7739870347758719d,right: 0.6256706364316044d,bottom: 0.6854795797350224d,left: 0.2685001307561883d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3243345604454607d,right: 0.8969220882580793d,bottom: 0.22823471517349447d,left: 0.6706601887182089d),
},
            new NpgsqlBoxbox0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6364010945534928d,right: 0.35067193025060706d,bottom: 0.4851345076738057d,left: 0.10447609475785491d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3886961929663252d,right: 0.879198258498098d,bottom: 0.3250316185260236d,left: 0.5305077324826852d),
},
            new NpgsqlBoxbox0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6102424294139179d,right: 0.6611885802704471d,bottom: 0.3549958448160261d,left: 0.4586898623704285d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9689557452586987d,right: 0.5235680664788807d,bottom: 0.7336825599890239d,left: 0.41525759587652666d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7214870926076749d,right: 0.4324758012468265d,bottom: 0.41958168206087754d,left: 0.19680718602146574d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9493599031587767d,right: 0.5975258604684595d,bottom: 0.08137080154349163d,left: 0.24691828282907424d),
},
            new NpgsqlBoxbox0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3981797509579825d,right: 0.7634574175257204d,bottom: 0.25404688169495915d,left: 0.5367907310603575d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5355772451228596d,right: 0.7540246707157937d,bottom: 0.24082241981503305d,left: 0.2523734808471694d),
},
            new NpgsqlBoxbox0M
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9217745476449908d,right: 0.901184789459243d,bottom: 0.4922655963832008d,left: 0.026155945915335432d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5674403300417823d,right: 0.7792947555618396d,bottom: 0.15264997116862322d,left: 0.519528357282283d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.18934552269137928d,right: 0.545514864725038d,bottom: 0.12772969362817976d,left: 0.402454080774967d),
},
            new NpgsqlBoxbox0M
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9176864108474426d,right: 0.8685329164813074d,bottom: 0.6735533734192357d,left: 0.8513108800056828d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7300553826289592d,right: 0.7744628902789986d,bottom: 0.25109586096389436d,left: 0.5760806299373233d),
},
            new NpgsqlBoxbox0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.967016341146637d,right: 0.8210883469569314d,bottom: 0.5859279432514883d,left: 0.01272506758766978d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.17975556309398433d,right: 0.1981718000483963d,bottom: 0.13731464795120163d,left: 0.1797871590029967d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3832065201546455d,right: 0.9094726455624959d,bottom: 0.289569581678509d,left: 0.8470604856296838d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8373211279681009d,right: 0.900012647446454d,bottom: 0.20975914874242452d,left: 0.698043728998808d),
},
            new NpgsqlBoxbox0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.47823950205286425d,right: 0.37708806582625d,bottom: 0.3869420101583524d,left: 0.04362248897974563d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9711942592892591d,right: 0.9439546239226718d,bottom: 0.7545490711440082d,left: 0.5542433595770935d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.937443090565462d,right: 0.8614345056448988d,bottom: 0.8602405783370504d,left: 0.3610701236233881d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7645252948110705d,right: 0.8681556500392784d,bottom: 0.3137264007280578d,left: 0.19200166354892056d),
},
            new NpgsqlBoxbox0M
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4400378352139498d,right: 0.688754753346785d,bottom: 0.2561174401107691d,left: 0.3597116783872244d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9021327817954494d,right: 0.8102918526262376d,bottom: 0.10823596047460138d,left: 0.4398068462088368d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.16346557300944653d,right: 0.7512958475470033d,bottom: 0.07474127064275271d,left: 0.4588083113959953d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.870511691275885d,right: 0.87000943069815d,bottom: 0.756645669754718d,left: 0.8047680869422803d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5337934703357503d,right: 0.7575963836871642d,bottom: 0.0655320537245867d,left: 0.5053718460506373d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3063396285265729d,right: 0.6222053908592953d,bottom: 0.15203433895920893d,left: 0.37514464111775525d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.748752111760357d,right: 0.25114069386965876d,bottom: 0.2604248200245386d,left: 0.2114643956391391d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5752855536178746d,right: 0.10979040345077351d,bottom: 0.04189822224609785d,left: 0.08077779614151659d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7725297784971799d,right: 0.8706446171143101d,bottom: 0.5368874200325542d,left: 0.3544054392464555d),
},
            new NpgsqlBoxbox0M
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.47643427396736027d,right: 0.5878583491828602d,bottom: 0.014393703028059757d,left: 0.45974797959301617d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8836678450127122d,right: 0.9351682744639765d,bottom: 0.04120793674090795d,left: 0.4109467308636968d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7049346014836368d,right: 0.6566153928680756d,bottom: 0.3875310640712062d,left: 0.20635481972917014d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5761808630687157d,right: 0.4397199374807208d,bottom: 0.43665813910299656d,left: 0.3921899720547901d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 92,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.16769593225674595d,right: 0.8888864646297824d,bottom: 0.0005586883138984922d,left: 0.7617476502739005d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8915688181737378d,right: 0.5627011502743295d,bottom: 0.5406442138044605d,left: 0.3439956693088183d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9243835051396566d,right: 0.7261893700112154d,bottom: 0.13783449975519912d,left: 0.30811154450947187d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.4270808932591946d,right: 0.7236149265007276d,bottom: 0.22280814963418083d,left: 0.5098659160588832d),
},
            new NpgsqlBoxbox0M
{
    Id = 97,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9882863601486392d,right: 0.8216390728734094d,bottom: 0.6425551973291863d,left: 0.8002830371048537d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7481854670895028d,right: 0.5603738402904841d,bottom: 0.10103632100176485d,left: 0.42837641040325114d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.38892518690509437d,right: 0.46506413360606524d,bottom: 0.16443365264055432d,left: 0.13742803275738757d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.24579318224071323d,right: 0.5729470650588594d,bottom: 0.038283284751897906d,left: 0.008898789481457059d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7468618299668195d,right: 0.4146153621735448d,bottom: 0.04278631103476482d,left: 0.3775874471966856d),
},
            new NpgsqlBoxbox0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7475905429623092d,right: 0.5410483191966091d,bottom: 0.5052379609044708d,left: 0.12051808272565379d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8627886230713091d,right: 0.5471904838389622d,bottom: 0.4579210743468798d,left: 0.08439430842416484d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6586026154321265d,right: 0.629382986361833d,bottom: 0.13754578381412863d,left: 0.1445739740726456d),
},
            new NpgsqlBoxbox0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6305340071992599d,right: 0.2841489747343905d,bottom: 0.05431446324060352d,left: 0.007306665244720345d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9277249213898188d,right: 0.7321362478902055d,bottom: 0.6195590822045699d,left: 0.06684052727533518d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9541192291043228d,right: 0.4016178810585991d,bottom: 0.1957476736413971d,left: 0.027086486733537307d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6392415985607198d,right: 0.41454572494878417d,bottom: 0.3931874544990347d,left: 0.037904785333851d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.890823451733744d,right: 0.7638913649018884d,bottom: 0.25489057189227315d,left: 0.03335182260269587d),
},
            new NpgsqlBoxbox0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6750602282627559d,right: 0.5464690177922742d,bottom: 0.5517803660688613d,left: 0.17582739027880512d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9208005208362501d,right: 0.8596037446735268d,bottom: 0.7202312116620538d,left: 0.07276539246304758d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8863194580216429d,right: 0.22289802938133196d,bottom: 0.14745385697525504d,left: 0.011834955762972665d),
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0mi(
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0mi(
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
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3))]
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

                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxbox0mi_id", 
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
                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
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
    npgsqlboxbox0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                NpgsqlTypes.NpgsqlBox? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.3243345604454607d,right: 0.8969220882580793d,bottom: 0.22823471517349447d,left: 0.6706601887182089d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.3886961929663252d,right: 0.879198258498098d,bottom: 0.3250316185260236d,left: 0.5305077324826852d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.9493599031587767d,right: 0.5975258604684595d,bottom: 0.08137080154349163d,left: 0.24691828282907424d)));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
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
    npgsqlboxbox0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxbox0mi_id", 
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
                NpgsqlTypes.NpgsqlBox? nullable = null;
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.5355772451228596d,right: 0.7540246707157937d,bottom: 0.24082241981503305d,left: 0.2523734808471694d)));
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.18934552269137928d,right: 0.545514864725038d,bottom: 0.12772969362817976d,left: 0.402454080774967d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox? nullable = null;
                nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.7300553826289592d,right: 0.7744628902789986d,bottom: 0.25109586096389436d,left: 0.5760806299373233d)));
                nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxbox0M> models = null;

                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxbox0M> models = null;

                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlboxbox0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlBox), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlboxbox0mi_id", 
                methodParametrName: "npgsqlboxbox0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxSingleTypebox)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[29], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[28],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[30], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[30], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[9], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[27],_testData[29], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 69, query1, 89, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 42, query1, 99, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[29], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 60, query1, 88, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatch(connection, 89, query1, 60, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 42, query1, 18, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[25],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 3, query1, 3, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[28],_testData[30], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatch(connection, 3, query1, 115, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatch(connection, 35, query1, 3, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[28],_testData[30], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatchAsync(connection, 5, 121))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[29], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatch(connection, 35, 88))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[7], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[8], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[9], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[29], false);
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
                await using var cmd = await ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 35);
                var models = await ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
NpgsqlBoxbox0M.AssertModel(models[0],_testData[7], false);NpgsqlBoxbox0M.AssertModel(models[1],_testData[8], false);NpgsqlBoxbox0M.AssertModel(models[2],_testData[9], false);NpgsqlBoxbox0M.AssertModel(models[3],_testData[10], false);NpgsqlBoxbox0M.AssertModel(models[4],_testData[11], false);NpgsqlBoxbox0M.AssertModel(models[5],_testData[12], false);NpgsqlBoxbox0M.AssertModel(models[6],_testData[13], false);NpgsqlBoxbox0M.AssertModel(models[7],_testData[14], false);NpgsqlBoxbox0M.AssertModel(models[8],_testData[15], false);NpgsqlBoxbox0M.AssertModel(models[9],_testData[16], false);NpgsqlBoxbox0M.AssertModel(models[10],_testData[17], false);NpgsqlBoxbox0M.AssertModel(models[11],_testData[18], false);NpgsqlBoxbox0M.AssertModel(models[12],_testData[19], false);NpgsqlBoxbox0M.AssertModel(models[13],_testData[20], false);NpgsqlBoxbox0M.AssertModel(models[14],_testData[21], false);NpgsqlBoxbox0M.AssertModel(models[15],_testData[22], false);NpgsqlBoxbox0M.AssertModel(models[16],_testData[23], false);NpgsqlBoxbox0M.AssertModel(models[17],_testData[24], false);NpgsqlBoxbox0M.AssertModel(models[18],_testData[25], false);NpgsqlBoxbox0M.AssertModel(models[19],_testData[26], false);NpgsqlBoxbox0M.AssertModel(models[20],_testData[27], false);NpgsqlBoxbox0M.AssertModel(models[21],_testData[28], false);NpgsqlBoxbox0M.AssertModel(models[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 53);
                var models =  ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
NpgsqlBoxbox0M.AssertModel(models[0],_testData[11], false);NpgsqlBoxbox0M.AssertModel(models[1],_testData[12], false);NpgsqlBoxbox0M.AssertModel(models[2],_testData[13], false);NpgsqlBoxbox0M.AssertModel(models[3],_testData[14], false);NpgsqlBoxbox0M.AssertModel(models[4],_testData[15], false);NpgsqlBoxbox0M.AssertModel(models[5],_testData[16], false);NpgsqlBoxbox0M.AssertModel(models[6],_testData[17], false);NpgsqlBoxbox0M.AssertModel(models[7],_testData[18], false);NpgsqlBoxbox0M.AssertModel(models[8],_testData[19], false);NpgsqlBoxbox0M.AssertModel(models[9],_testData[20], false);NpgsqlBoxbox0M.AssertModel(models[10],_testData[21], false);NpgsqlBoxbox0M.AssertModel(models[11],_testData[22], false);NpgsqlBoxbox0M.AssertModel(models[12],_testData[23], false);NpgsqlBoxbox0M.AssertModel(models[13],_testData[24], false);NpgsqlBoxbox0M.AssertModel(models[14],_testData[25], false);NpgsqlBoxbox0M.AssertModel(models[15],_testData[26], false);NpgsqlBoxbox0M.AssertModel(models[16],_testData[27], false);NpgsqlBoxbox0M.AssertModel(models[17],_testData[28], false);NpgsqlBoxbox0M.AssertModel(models[18],_testData[29], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8886511533461394d,right: 0.6038969727605712d,bottom: 0.016739458904384996d,left: 0.2133716821246895d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6605210464203772d,right: 0.6083422683380039d,bottom: 0.2561898378973917d,left: 0.5103850705650066d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.13989229831257888d,right: 0.9393878800918589d,bottom: 0.07983478954752043d,left: 0.5624122986735918d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7868570248374647d,right: 0.2774520520824867d,bottom: 0.7159861153547953d,left: 0.09916905197935666d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.44206413638530595d,right: 0.5331981259378893d,bottom: 0.08035771860538099d,left: 0.011222367959218493d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5086366628372757d,right: 0.7796078167239561d,bottom: 0.3242805701422651d,left: 0.6554082348450134d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8369002578646827d,right: 0.479624020774273d,bottom: 0.7149847573668071d,left: 0.27133979423995536d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5957485080932979d,right: 0.9980748467444098d,bottom: 0.30005389973040775d,left: 0.24555951087893524d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8945377678984683d,right: 0.5712993737667121d,bottom: 0.06614731260987983d,left: 0.4272092061648062d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.22793686679953784d,right: 0.9377635599931585d,bottom: 0.1422120559919674d,left: 0.12370072991824321d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5520145591256015d,right: 0.9636947584960339d,bottom: 0.007069144667258609d,left: 0.2842340755726659d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6147738240115939d,right: 0.5844282935777169d,bottom: 0.08307471863999283d,left: 0.3557012163108315d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7739870347758719d,right: 0.6256706364316044d,bottom: 0.6854795797350224d,left: 0.2685001307561883d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3243345604454607d,right: 0.8969220882580793d,bottom: 0.22823471517349447d,left: 0.6706601887182089d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6364010945534928d,right: 0.35067193025060706d,bottom: 0.4851345076738057d,left: 0.10447609475785491d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3886961929663252d,right: 0.879198258498098d,bottom: 0.3250316185260236d,left: 0.5305077324826852d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6102424294139179d,right: 0.6611885802704471d,bottom: 0.3549958448160261d,left: 0.4586898623704285d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9689557452586987d,right: 0.5235680664788807d,bottom: 0.7336825599890239d,left: 0.41525759587652666d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7214870926076749d,right: 0.4324758012468265d,bottom: 0.41958168206087754d,left: 0.19680718602146574d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9493599031587767d,right: 0.5975258604684595d,bottom: 0.08137080154349163d,left: 0.24691828282907424d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3981797509579825d,right: 0.7634574175257204d,bottom: 0.25404688169495915d,left: 0.5367907310603575d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5355772451228596d,right: 0.7540246707157937d,bottom: 0.24082241981503305d,left: 0.2523734808471694d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9217745476449908d,right: 0.901184789459243d,bottom: 0.4922655963832008d,left: 0.026155945915335432d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5674403300417823d,right: 0.7792947555618396d,bottom: 0.15264997116862322d,left: 0.519528357282283d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.18934552269137928d,right: 0.545514864725038d,bottom: 0.12772969362817976d,left: 0.402454080774967d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9176864108474426d,right: 0.8685329164813074d,bottom: 0.6735533734192357d,left: 0.8513108800056828d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7300553826289592d,right: 0.7744628902789986d,bottom: 0.25109586096389436d,left: 0.5760806299373233d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.967016341146637d,right: 0.8210883469569314d,bottom: 0.5859279432514883d,left: 0.01272506758766978d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.17975556309398433d,right: 0.1981718000483963d,bottom: 0.13731464795120163d,left: 0.1797871590029967d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3832065201546455d,right: 0.9094726455624959d,bottom: 0.289569581678509d,left: 0.8470604856296838d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8373211279681009d,right: 0.900012647446454d,bottom: 0.20975914874242452d,left: 0.698043728998808d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.47823950205286425d,right: 0.37708806582625d,bottom: 0.3869420101583524d,left: 0.04362248897974563d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9711942592892591d,right: 0.9439546239226718d,bottom: 0.7545490711440082d,left: 0.5542433595770935d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.937443090565462d,right: 0.8614345056448988d,bottom: 0.8602405783370504d,left: 0.3610701236233881d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7645252948110705d,right: 0.8681556500392784d,bottom: 0.3137264007280578d,left: 0.19200166354892056d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4400378352139498d,right: 0.688754753346785d,bottom: 0.2561174401107691d,left: 0.3597116783872244d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9021327817954494d,right: 0.8102918526262376d,bottom: 0.10823596047460138d,left: 0.4398068462088368d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.16346557300944653d,right: 0.7512958475470033d,bottom: 0.07474127064275271d,left: 0.4588083113959953d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.870511691275885d,right: 0.87000943069815d,bottom: 0.756645669754718d,left: 0.8047680869422803d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5337934703357503d,right: 0.7575963836871642d,bottom: 0.0655320537245867d,left: 0.5053718460506373d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3063396285265729d,right: 0.6222053908592953d,bottom: 0.15203433895920893d,left: 0.37514464111775525d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.748752111760357d,right: 0.25114069386965876d,bottom: 0.2604248200245386d,left: 0.2114643956391391d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5752855536178746d,right: 0.10979040345077351d,bottom: 0.04189822224609785d,left: 0.08077779614151659d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7725297784971799d,right: 0.8706446171143101d,bottom: 0.5368874200325542d,left: 0.3544054392464555d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.47643427396736027d,right: 0.5878583491828602d,bottom: 0.014393703028059757d,left: 0.45974797959301617d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8836678450127122d,right: 0.9351682744639765d,bottom: 0.04120793674090795d,left: 0.4109467308636968d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7049346014836368d,right: 0.6566153928680756d,bottom: 0.3875310640712062d,left: 0.20635481972917014d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5761808630687157d,right: 0.4397199374807208d,bottom: 0.43665813910299656d,left: 0.3921899720547901d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.16769593225674595d,right: 0.8888864646297824d,bottom: 0.0005586883138984922d,left: 0.7617476502739005d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8915688181737378d,right: 0.5627011502743295d,bottom: 0.5406442138044605d,left: 0.3439956693088183d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9243835051396566d,right: 0.7261893700112154d,bottom: 0.13783449975519912d,left: 0.30811154450947187d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4270808932591946d,right: 0.7236149265007276d,bottom: 0.22280814963418083d,left: 0.5098659160588832d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9882863601486392d,right: 0.8216390728734094d,bottom: 0.6425551973291863d,left: 0.8002830371048537d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7481854670895028d,right: 0.5603738402904841d,bottom: 0.10103632100176485d,left: 0.42837641040325114d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.38892518690509437d,right: 0.46506413360606524d,bottom: 0.16443365264055432d,left: 0.13742803275738757d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.24579318224071323d,right: 0.5729470650588594d,bottom: 0.038283284751897906d,left: 0.008898789481457059d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7468618299668195d,right: 0.4146153621735448d,bottom: 0.04278631103476482d,left: 0.3775874471966856d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7475905429623092d,right: 0.5410483191966091d,bottom: 0.5052379609044708d,left: 0.12051808272565379d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8627886230713091d,right: 0.5471904838389622d,bottom: 0.4579210743468798d,left: 0.08439430842416484d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6586026154321265d,right: 0.629382986361833d,bottom: 0.13754578381412863d,left: 0.1445739740726456d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6305340071992599d,right: 0.2841489747343905d,bottom: 0.05431446324060352d,left: 0.007306665244720345d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9277249213898188d,right: 0.7321362478902055d,bottom: 0.6195590822045699d,left: 0.06684052727533518d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9541192291043228d,right: 0.4016178810585991d,bottom: 0.1957476736413971d,left: 0.027086486733537307d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6392415985607198d,right: 0.41454572494878417d,bottom: 0.3931874544990347d,left: 0.037904785333851d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.890823451733744d,right: 0.7638913649018884d,bottom: 0.25489057189227315d,left: 0.03335182260269587d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6750602282627559d,right: 0.5464690177922742d,bottom: 0.5517803660688613d,left: 0.17582739027880512d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9208005208362501d,right: 0.8596037446735268d,bottom: 0.7202312116620538d,left: 0.07276539246304758d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8863194580216429d,right: 0.22289802938133196d,bottom: 0.14745385697525504d,left: 0.011834955762972665d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8886511533461394d,right: 0.6038969727605712d,bottom: 0.016739458904384996d,left: 0.2133716821246895d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6605210464203772d,right: 0.6083422683380039d,bottom: 0.2561898378973917d,left: 0.5103850705650066d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.13989229831257888d,right: 0.9393878800918589d,bottom: 0.07983478954752043d,left: 0.5624122986735918d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7868570248374647d,right: 0.2774520520824867d,bottom: 0.7159861153547953d,left: 0.09916905197935666d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.44206413638530595d,right: 0.5331981259378893d,bottom: 0.08035771860538099d,left: 0.011222367959218493d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5086366628372757d,right: 0.7796078167239561d,bottom: 0.3242805701422651d,left: 0.6554082348450134d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8369002578646827d,right: 0.479624020774273d,bottom: 0.7149847573668071d,left: 0.27133979423995536d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5957485080932979d,right: 0.9980748467444098d,bottom: 0.30005389973040775d,left: 0.24555951087893524d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8945377678984683d,right: 0.5712993737667121d,bottom: 0.06614731260987983d,left: 0.4272092061648062d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.22793686679953784d,right: 0.9377635599931585d,bottom: 0.1422120559919674d,left: 0.12370072991824321d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5520145591256015d,right: 0.9636947584960339d,bottom: 0.007069144667258609d,left: 0.2842340755726659d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6147738240115939d,right: 0.5844282935777169d,bottom: 0.08307471863999283d,left: 0.3557012163108315d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7739870347758719d,right: 0.6256706364316044d,bottom: 0.6854795797350224d,left: 0.2685001307561883d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3243345604454607d,right: 0.8969220882580793d,bottom: 0.22823471517349447d,left: 0.6706601887182089d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6364010945534928d,right: 0.35067193025060706d,bottom: 0.4851345076738057d,left: 0.10447609475785491d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3886961929663252d,right: 0.879198258498098d,bottom: 0.3250316185260236d,left: 0.5305077324826852d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6102424294139179d,right: 0.6611885802704471d,bottom: 0.3549958448160261d,left: 0.4586898623704285d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9689557452586987d,right: 0.5235680664788807d,bottom: 0.7336825599890239d,left: 0.41525759587652666d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7214870926076749d,right: 0.4324758012468265d,bottom: 0.41958168206087754d,left: 0.19680718602146574d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9493599031587767d,right: 0.5975258604684595d,bottom: 0.08137080154349163d,left: 0.24691828282907424d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3981797509579825d,right: 0.7634574175257204d,bottom: 0.25404688169495915d,left: 0.5367907310603575d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5355772451228596d,right: 0.7540246707157937d,bottom: 0.24082241981503305d,left: 0.2523734808471694d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9217745476449908d,right: 0.901184789459243d,bottom: 0.4922655963832008d,left: 0.026155945915335432d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5674403300417823d,right: 0.7792947555618396d,bottom: 0.15264997116862322d,left: 0.519528357282283d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.18934552269137928d,right: 0.545514864725038d,bottom: 0.12772969362817976d,left: 0.402454080774967d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9176864108474426d,right: 0.8685329164813074d,bottom: 0.6735533734192357d,left: 0.8513108800056828d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7300553826289592d,right: 0.7744628902789986d,bottom: 0.25109586096389436d,left: 0.5760806299373233d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.967016341146637d,right: 0.8210883469569314d,bottom: 0.5859279432514883d,left: 0.01272506758766978d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.17975556309398433d,right: 0.1981718000483963d,bottom: 0.13731464795120163d,left: 0.1797871590029967d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3832065201546455d,right: 0.9094726455624959d,bottom: 0.289569581678509d,left: 0.8470604856296838d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8373211279681009d,right: 0.900012647446454d,bottom: 0.20975914874242452d,left: 0.698043728998808d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.47823950205286425d,right: 0.37708806582625d,bottom: 0.3869420101583524d,left: 0.04362248897974563d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9711942592892591d,right: 0.9439546239226718d,bottom: 0.7545490711440082d,left: 0.5542433595770935d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.937443090565462d,right: 0.8614345056448988d,bottom: 0.8602405783370504d,left: 0.3610701236233881d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7645252948110705d,right: 0.8681556500392784d,bottom: 0.3137264007280578d,left: 0.19200166354892056d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4400378352139498d,right: 0.688754753346785d,bottom: 0.2561174401107691d,left: 0.3597116783872244d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9021327817954494d,right: 0.8102918526262376d,bottom: 0.10823596047460138d,left: 0.4398068462088368d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.16346557300944653d,right: 0.7512958475470033d,bottom: 0.07474127064275271d,left: 0.4588083113959953d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.870511691275885d,right: 0.87000943069815d,bottom: 0.756645669754718d,left: 0.8047680869422803d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5337934703357503d,right: 0.7575963836871642d,bottom: 0.0655320537245867d,left: 0.5053718460506373d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3063396285265729d,right: 0.6222053908592953d,bottom: 0.15203433895920893d,left: 0.37514464111775525d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.748752111760357d,right: 0.25114069386965876d,bottom: 0.2604248200245386d,left: 0.2114643956391391d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5752855536178746d,right: 0.10979040345077351d,bottom: 0.04189822224609785d,left: 0.08077779614151659d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7725297784971799d,right: 0.8706446171143101d,bottom: 0.5368874200325542d,left: 0.3544054392464555d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.47643427396736027d,right: 0.5878583491828602d,bottom: 0.014393703028059757d,left: 0.45974797959301617d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8836678450127122d,right: 0.9351682744639765d,bottom: 0.04120793674090795d,left: 0.4109467308636968d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7049346014836368d,right: 0.6566153928680756d,bottom: 0.3875310640712062d,left: 0.20635481972917014d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5761808630687157d,right: 0.4397199374807208d,bottom: 0.43665813910299656d,left: 0.3921899720547901d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.16769593225674595d,right: 0.8888864646297824d,bottom: 0.0005586883138984922d,left: 0.7617476502739005d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8915688181737378d,right: 0.5627011502743295d,bottom: 0.5406442138044605d,left: 0.3439956693088183d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9243835051396566d,right: 0.7261893700112154d,bottom: 0.13783449975519912d,left: 0.30811154450947187d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4270808932591946d,right: 0.7236149265007276d,bottom: 0.22280814963418083d,left: 0.5098659160588832d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9882863601486392d,right: 0.8216390728734094d,bottom: 0.6425551973291863d,left: 0.8002830371048537d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7481854670895028d,right: 0.5603738402904841d,bottom: 0.10103632100176485d,left: 0.42837641040325114d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.38892518690509437d,right: 0.46506413360606524d,bottom: 0.16443365264055432d,left: 0.13742803275738757d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.24579318224071323d,right: 0.5729470650588594d,bottom: 0.038283284751897906d,left: 0.008898789481457059d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7468618299668195d,right: 0.4146153621735448d,bottom: 0.04278631103476482d,left: 0.3775874471966856d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7475905429623092d,right: 0.5410483191966091d,bottom: 0.5052379609044708d,left: 0.12051808272565379d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8627886230713091d,right: 0.5471904838389622d,bottom: 0.4579210743468798d,left: 0.08439430842416484d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6586026154321265d,right: 0.629382986361833d,bottom: 0.13754578381412863d,left: 0.1445739740726456d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6305340071992599d,right: 0.2841489747343905d,bottom: 0.05431446324060352d,left: 0.007306665244720345d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9277249213898188d,right: 0.7321362478902055d,bottom: 0.6195590822045699d,left: 0.06684052727533518d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9541192291043228d,right: 0.4016178810585991d,bottom: 0.1957476736413971d,left: 0.027086486733537307d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6392415985607198d,right: 0.41454572494878417d,bottom: 0.3931874544990347d,left: 0.037904785333851d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.890823451733744d,right: 0.7638913649018884d,bottom: 0.25489057189227315d,left: 0.03335182260269587d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6750602282627559d,right: 0.5464690177922742d,bottom: 0.5517803660688613d,left: 0.17582739027880512d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9208005208362501d,right: 0.8596037446735268d,bottom: 0.7202312116620538d,left: 0.07276539246304758d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8863194580216429d,right: 0.22289802938133196d,bottom: 0.14745385697525504d,left: 0.011834955762972665d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxbox0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlBoxSingleTypebox)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlBoxSingleTypebox)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxbox0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxbox0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
FROM public.binary_npgsqlboxbox0m m
LEFT JOIN public.binary_npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxbox0M>(15);

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
                ((INpgsqlBoxSingleTypebox)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxbox0M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxbox0M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxbox0M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxbox0M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxbox0M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxbox0M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxbox0M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxbox0M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxbox0M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxbox0M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxbox0M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxbox0M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxbox0M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxbox0M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxbox0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlBoxSingleTypebox)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlBoxbox0M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxbox0M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxbox0M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxbox0M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxbox0M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxbox0M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxbox0M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxbox0M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxbox0M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxbox0M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxbox0M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxbox0M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxbox0M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxbox0M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxbox0M.AssertModel(models[14],_testData[14], false);
                NpgsqlBoxbox0M.AssertModel(models[15],_testData[15], false);
                NpgsqlBoxbox0M.AssertModel(models[16],_testData[16], false);
                NpgsqlBoxbox0M.AssertModel(models[17],_testData[17], false);
                NpgsqlBoxbox0M.AssertModel(models[18],_testData[18], false);
                NpgsqlBoxbox0M.AssertModel(models[19],_testData[19], false);
                NpgsqlBoxbox0M.AssertModel(models[20],_testData[20], false);
                NpgsqlBoxbox0M.AssertModel(models[21],_testData[21], false);
                NpgsqlBoxbox0M.AssertModel(models[22],_testData[22], false);
                NpgsqlBoxbox0M.AssertModel(models[23],_testData[23], false);
                NpgsqlBoxbox0M.AssertModel(models[24],_testData[24], false);
                NpgsqlBoxbox0M.AssertModel(models[25],_testData[25], false);
                NpgsqlBoxbox0M.AssertModel(models[26],_testData[26], false);
                NpgsqlBoxbox0M.AssertModel(models[27],_testData[27], false);
                NpgsqlBoxbox0M.AssertModel(models[28],_testData[28], false);
                NpgsqlBoxbox0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxbox0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxSingleTypebox)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxbox0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxbox0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxSingleTypebox)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

