

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
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.288861105251182d,right: 0.9353292978388037d,bottom: 0.21941051979516368d,left: 0.817547655936897d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7544097514701886d,right: 0.7460074211772839d,bottom: 0.2630872954764958d,left: 0.3663376966549021d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3055824334434116d,right: 0.7435329127302254d,bottom: 0.0922088913105149d,left: 0.5288588689357839d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9926359067775221d,right: 0.49785894743127823d,bottom: 0.31424231743134456d,left: 0.495336671067082d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8203300222283477d,right: 0.8523797859843786d,bottom: 0.6974057088755796d,left: 0.45752756423734964d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9663476749114236d,right: 0.6162794269878704d,bottom: 0.7639104339270439d,left: 0.13095102325936203d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8667045760020642d,right: 0.5979565075105231d,bottom: 0.7811863198696095d,left: 0.21446463420623862d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.623052475276252d,right: 0.666501727709438d,bottom: 0.11633730424162059d,left: 0.5079261505996892d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.49401460904215355d,right: 0.9022675171981069d,bottom: 0.3718299944087814d,left: 0.48792108815711144d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.18294184488779253d,right: 0.7792320547787885d,bottom: 0.007906724654538233d,left: 0.7128851349906139d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.990735504280649d,right: 0.9606254331022588d,bottom: 0.8059281753875992d,left: 0.06915138776992558d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9101398221069296d,right: 0.6741516575051938d,bottom: 0.9059137741667884d,left: 0.16165624784777033d),
},
            new NpgsqlBoxbox0M
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5750823635327003d,right: 0.651104394172774d,bottom: 0.5002720520104602d,left: 0.2500225719129122d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7474052357442439d,right: 0.04440988867082796d,bottom: 0.05763899885419832d,left: 0.03732057596779359d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.754125319606663d,right: 0.5939186844305918d,bottom: 0.04248027177668634d,left: 0.253320188458355d),
},
            new NpgsqlBoxbox0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.47697728184706156d,right: 0.5239253677495042d,bottom: 0.30779088271678756d,left: 0.002878338436429262d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5783036877754598d,right: 0.13002181247637334d,bottom: 0.39607390523807606d,left: 0.03920473209649089d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5085405212494275d,right: 0.25480035368178644d,bottom: 0.12068331760436912d,left: 0.01420954095191973d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.20416219458766727d,right: 0.8021645284855284d,bottom: 0.06238139740101212d,left: 0.752588764834867d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9083352316440884d,right: 0.31750118649607995d,bottom: 0.7942532526831146d,left: 0.11741917806737401d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7344823934831168d,right: 0.5509925146782585d,bottom: 0.7014426970187695d,left: 0.1771799654268239d),
},
            new NpgsqlBoxbox0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6141583100411782d,right: 0.8376817927924857d,bottom: 0.36607033997905136d,left: 0.5810055954855774d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8286332237997246d,right: 0.36906448895995647d,bottom: 0.7222905960166393d,left: 0.15167144091601692d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.2287938507027657d,right: 0.6463544326097757d,bottom: 0.22577451484774658d,left: 0.3360880099134782d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.786936003416376d,right: 0.2882359994366136d,bottom: 0.48068250823184666d,left: 0.23520322486148493d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5710744304555492d,right: 0.412896978636779d,bottom: 0.07612661784506602d,left: 0.18339195492983618d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.46405059175848096d,right: 0.9325824129943661d,bottom: 0.13864422934731024d,left: 0.41934125487400176d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.48672279559523113d,right: 0.5317040137760025d,bottom: 0.35564951767665665d,left: 0.3619669497210809d),
},
            new NpgsqlBoxbox0M
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.759471953046121d,right: 0.17981230200311582d,bottom: 0.1839116733603493d,left: 0.15543071743116899d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5317284056278737d,right: 0.8186802858070079d,bottom: 0.17549291324257388d,left: 0.19622616787917668d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4905854860293035d,right: 0.8088075365296921d,bottom: 0.04504095702351396d,left: 0.4706813029961606d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6794913311985215d,right: 0.5899923290661271d,bottom: 0.21880442289848d,left: 0.41585334796658124d),
},
            new NpgsqlBoxbox0M
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8946246804789734d,right: 0.906007793226034d,bottom: 0.4755674429948882d,left: 0.43572470624031d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.08599684422575582d,right: 0.484178747316784d,bottom: 0.008918440967852104d,left: 0.1429756648914341d),
},
            new NpgsqlBoxbox0M
{
    Id = 97,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7867863752266139d,right: 0.4243876859549749d,bottom: 0.27501710966563553d,left: 0.22086247997414232d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5300276138956636d,right: 0.2463751316056566d,bottom: 0.31891237380042126d,left: 0.0876963992326566d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 106,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5329734984105916d,right: 0.31320181758419485d,bottom: 0.3972259259219877d,left: 0.07520603120558766d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.21645455946493064d,right: 0.6436595631164127d,bottom: 0.010674328471124261d,left: 0.10629926260329003d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7171718627922066d,right: 0.5591941407229858d,bottom: 0.1992467653087816d,left: 0.23879144152215448d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9614248551053537d,right: 0.8479939366114749d,bottom: 0.7012219925280503d,left: 0.7309402588944637d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7448592368330441d,right: 0.5311651458763358d,bottom: 0.6798362478932188d,left: 0.2586532839493235d),
},
            new NpgsqlBoxbox0M
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9666734979327873d,right: 0.62946608986814d,bottom: 0.15170347055639277d,left: 0.04410527325656621d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7198992831235284d,right: 0.9935909160935542d,bottom: 0.17263196368613964d,left: 0.6799212362025362d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6058920917280448d,right: 0.9622143511161694d,bottom: 0.04523369311192971d,left: 0.29698099322134386d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 122,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7714847253272811d,right: 0.8549667354063192d,bottom: 0.40978531817222463d,left: 0.4882194515215138d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3676833603482845d,right: 0.610895754842349d,bottom: 0.006108893728451581d,left: 0.346050178716899d),
},
            new NpgsqlBoxbox0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.46288260359175626d,right: 0.6965840488222833d,bottom: 0.013859193292408256d,left: 0.5564434347173123d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.33031615336664644d,right: 0.8954835463134071d,bottom: 0.2433648286813055d,left: 0.7310441686010856d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7977643886731715d,right: 0.9783994879608964d,bottom: 0.625645171158687d,left: 0.7952181052100005d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8300923952186485d,right: 0.46953774927107517d,bottom: 0.4798788861340463d,left: 0.09567433537563286d),
},
            new NpgsqlBoxbox0M
{
    Id = 139,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8484068255621134d,right: 0.6370105870074031d,bottom: 0.7526229806144616d,left: 0.10632648648962295d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 143,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5073499506155026d,right: 0.5338114546625136d,bottom: 0.41187750625794695d,left: 0.5208059311814282d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8739791268637629d,right: 0.5347554721079851d,bottom: 0.4173704542126807d,left: 0.4601088982653361d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 152,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4682522478847103d,right: 0.44670356133617717d,bottom: 0.40355522646031816d,left: 0.27878076192148504d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9615886931544944d,right: 0.9978928120065836d,bottom: 0.4078279780346681d,left: 0.4702442865044212d),
},
            new NpgsqlBoxbox0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4775529734252778d,right: 0.7004771167448809d,bottom: 0.10163357910426551d,left: 0.027203473656676858d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6533038957181686d,right: 0.9963458996295642d,bottom: 0.027449247238492847d,left: 0.7100124428190727d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 157,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9344654053023409d,right: 0.67151453861439d,bottom: 0.061232925265282234d,left: 0.48100117227559147d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.21588493461818903d,right: 0.31153145327301957d,bottom: 0.10105907843795403d,left: 0.23459689008624018d),
},
            new NpgsqlBoxbox0M
{
    Id = 163,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5267675291862725d,right: 0.2776643740198492d,bottom: 0.47437094970363514d,left: 0.2134441056234716d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5105227454332589d,right: 0.06559841818628487d,bottom: 0.4117675783779894d,left: 0.03636376474949232d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 166,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6174540694562487d,right: 0.2146499838296846d,bottom: 0.11692743857573218d,left: 0.18873447310423264d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 171,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8528360481983269d,right: 0.8207666020774841d,bottom: 0.18858061595867837d,left: 0.010783471104802156d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8698075234576987d,right: 0.8574788527352409d,bottom: 0.029302929641559783d,left: 0.36283265381108476d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9666351397424888d,right: 0.4949748381933964d,bottom: 0.6197908915789695d,left: 0.4167863419159117d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8847014087640934d,right: 0.8136713869401772d,bottom: 0.1978714619832892d,left: 0.5372415764707292d),
},
            new NpgsqlBoxbox0M
{
    Id = 173,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8769838741703548d,right: 0.621151933102224d,bottom: 0.7800406172331364d,left: 0.4538173683923813d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.4152513324519568d,right: 0.2729482053758031d,bottom: 0.23311102087335045d,left: 0.2699244489666264d),
},
            new NpgsqlBoxbox0M
{
    Id = 180,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.67686822215819d,right: 0.6836239430443091d,bottom: 0.2589904834747797d,left: 0.464151692495675d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7930656311930517d,right: 0.2974728460417494d,bottom: 0.5997225478259892d,left: 0.1657315610132264d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8926681314949987d,right: 0.36698201739141456d,bottom: 0.5536049137160638d,left: 0.3525352442449491d),
},
            new NpgsqlBoxbox0M
{
    Id = 183,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.2778736777451353d,right: 0.4864177630605566d,bottom: 0.0653601991550018d,left: 0.3950337174551096d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.624804252616108d,right: 0.9665257725334989d,bottom: 0.352227236535575d,left: 0.28436276818132333d),
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

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.9101398221069296d,right: 0.6741516575051938d,bottom: 0.9059137741667884d,left: 0.16165624784777033d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.754125319606663d,right: 0.5939186844305918d,bottom: 0.04248027177668634d,left: 0.253320188458355d)));
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
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.7344823934831168d,right: 0.5509925146782585d,bottom: 0.7014426970187695d,left: 0.1771799654268239d)));
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

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 166;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 166;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 173;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 6;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[27],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

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
                        NpgsqlBoxbox0M.AssertModel(models[27],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[28],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[29],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[30],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[31],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 166;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 88, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[32],_testData[34], false);
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 110, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 16, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[34], false);
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatch(connection, 15, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 157, query1, 88, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[34], false);
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 38, query1, 122, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
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
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatch(connection, 79, query1, 143, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[34], false);
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatch(connection, 54, query1, 16, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[30],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatchAsync(connection, 16, 71))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[4], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[5], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[6], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[7], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[8], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[9], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[24],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[25],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[26],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[27],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[28],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[29],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatch(connection, 38, 143))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

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
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[24],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[25],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[26],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[34], false);
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
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 88);
                var models = await ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                NpgsqlBoxbox0M.AssertModel(models[0],_testData[17], false);
                NpgsqlBoxbox0M.AssertModel(models[1],_testData[18], false);
                NpgsqlBoxbox0M.AssertModel(models[2],_testData[19], false);
                NpgsqlBoxbox0M.AssertModel(models[3],_testData[20], false);
                NpgsqlBoxbox0M.AssertModel(models[4],_testData[21], false);
                NpgsqlBoxbox0M.AssertModel(models[5],_testData[22], false);
                NpgsqlBoxbox0M.AssertModel(models[6],_testData[23], false);
                NpgsqlBoxbox0M.AssertModel(models[7],_testData[24], false);
                NpgsqlBoxbox0M.AssertModel(models[8],_testData[25], false);
                NpgsqlBoxbox0M.AssertModel(models[9],_testData[26], false);
                NpgsqlBoxbox0M.AssertModel(models[10],_testData[27], false);
                NpgsqlBoxbox0M.AssertModel(models[11],_testData[28], false);
                NpgsqlBoxbox0M.AssertModel(models[12],_testData[29], false);
                NpgsqlBoxbox0M.AssertModel(models[13],_testData[30], false);
                NpgsqlBoxbox0M.AssertModel(models[14],_testData[31], false);
                NpgsqlBoxbox0M.AssertModel(models[15],_testData[32], false);
                NpgsqlBoxbox0M.AssertModel(models[16],_testData[33], false);
                NpgsqlBoxbox0M.AssertModel(models[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 106);
                var models =  ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                NpgsqlBoxbox0M.AssertModel(models[0],_testData[19], false);
                NpgsqlBoxbox0M.AssertModel(models[1],_testData[20], false);
                NpgsqlBoxbox0M.AssertModel(models[2],_testData[21], false);
                NpgsqlBoxbox0M.AssertModel(models[3],_testData[22], false);
                NpgsqlBoxbox0M.AssertModel(models[4],_testData[23], false);
                NpgsqlBoxbox0M.AssertModel(models[5],_testData[24], false);
                NpgsqlBoxbox0M.AssertModel(models[6],_testData[25], false);
                NpgsqlBoxbox0M.AssertModel(models[7],_testData[26], false);
                NpgsqlBoxbox0M.AssertModel(models[8],_testData[27], false);
                NpgsqlBoxbox0M.AssertModel(models[9],_testData[28], false);
                NpgsqlBoxbox0M.AssertModel(models[10],_testData[29], false);
                NpgsqlBoxbox0M.AssertModel(models[11],_testData[30], false);
                NpgsqlBoxbox0M.AssertModel(models[12],_testData[31], false);
                NpgsqlBoxbox0M.AssertModel(models[13],_testData[32], false);
                NpgsqlBoxbox0M.AssertModel(models[14],_testData[33], false);
                NpgsqlBoxbox0M.AssertModel(models[15],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.288861105251182d,right: 0.9353292978388037d,bottom: 0.21941051979516368d,left: 0.817547655936897d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7544097514701886d,right: 0.7460074211772839d,bottom: 0.2630872954764958d,left: 0.3663376966549021d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3055824334434116d,right: 0.7435329127302254d,bottom: 0.0922088913105149d,left: 0.5288588689357839d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9926359067775221d,right: 0.49785894743127823d,bottom: 0.31424231743134456d,left: 0.495336671067082d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8203300222283477d,right: 0.8523797859843786d,bottom: 0.6974057088755796d,left: 0.45752756423734964d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9663476749114236d,right: 0.6162794269878704d,bottom: 0.7639104339270439d,left: 0.13095102325936203d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8667045760020642d,right: 0.5979565075105231d,bottom: 0.7811863198696095d,left: 0.21446463420623862d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.623052475276252d,right: 0.666501727709438d,bottom: 0.11633730424162059d,left: 0.5079261505996892d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49401460904215355d,right: 0.9022675171981069d,bottom: 0.3718299944087814d,left: 0.48792108815711144d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.18294184488779253d,right: 0.7792320547787885d,bottom: 0.007906724654538233d,left: 0.7128851349906139d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.990735504280649d,right: 0.9606254331022588d,bottom: 0.8059281753875992d,left: 0.06915138776992558d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9101398221069296d,right: 0.6741516575051938d,bottom: 0.9059137741667884d,left: 0.16165624784777033d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5750823635327003d,right: 0.651104394172774d,bottom: 0.5002720520104602d,left: 0.2500225719129122d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7474052357442439d,right: 0.04440988867082796d,bottom: 0.05763899885419832d,left: 0.03732057596779359d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.754125319606663d,right: 0.5939186844305918d,bottom: 0.04248027177668634d,left: 0.253320188458355d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.47697728184706156d,right: 0.5239253677495042d,bottom: 0.30779088271678756d,left: 0.002878338436429262d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5783036877754598d,right: 0.13002181247637334d,bottom: 0.39607390523807606d,left: 0.03920473209649089d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5085405212494275d,right: 0.25480035368178644d,bottom: 0.12068331760436912d,left: 0.01420954095191973d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.20416219458766727d,right: 0.8021645284855284d,bottom: 0.06238139740101212d,left: 0.752588764834867d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9083352316440884d,right: 0.31750118649607995d,bottom: 0.7942532526831146d,left: 0.11741917806737401d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7344823934831168d,right: 0.5509925146782585d,bottom: 0.7014426970187695d,left: 0.1771799654268239d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6141583100411782d,right: 0.8376817927924857d,bottom: 0.36607033997905136d,left: 0.5810055954855774d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8286332237997246d,right: 0.36906448895995647d,bottom: 0.7222905960166393d,left: 0.15167144091601692d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2287938507027657d,right: 0.6463544326097757d,bottom: 0.22577451484774658d,left: 0.3360880099134782d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.786936003416376d,right: 0.2882359994366136d,bottom: 0.48068250823184666d,left: 0.23520322486148493d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5710744304555492d,right: 0.412896978636779d,bottom: 0.07612661784506602d,left: 0.18339195492983618d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46405059175848096d,right: 0.9325824129943661d,bottom: 0.13864422934731024d,left: 0.41934125487400176d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.48672279559523113d,right: 0.5317040137760025d,bottom: 0.35564951767665665d,left: 0.3619669497210809d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.759471953046121d,right: 0.17981230200311582d,bottom: 0.1839116733603493d,left: 0.15543071743116899d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5317284056278737d,right: 0.8186802858070079d,bottom: 0.17549291324257388d,left: 0.19622616787917668d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4905854860293035d,right: 0.8088075365296921d,bottom: 0.04504095702351396d,left: 0.4706813029961606d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6794913311985215d,right: 0.5899923290661271d,bottom: 0.21880442289848d,left: 0.41585334796658124d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8946246804789734d,right: 0.906007793226034d,bottom: 0.4755674429948882d,left: 0.43572470624031d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.08599684422575582d,right: 0.484178747316784d,bottom: 0.008918440967852104d,left: 0.1429756648914341d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7867863752266139d,right: 0.4243876859549749d,bottom: 0.27501710966563553d,left: 0.22086247997414232d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5300276138956636d,right: 0.2463751316056566d,bottom: 0.31891237380042126d,left: 0.0876963992326566d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5329734984105916d,right: 0.31320181758419485d,bottom: 0.3972259259219877d,left: 0.07520603120558766d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.21645455946493064d,right: 0.6436595631164127d,bottom: 0.010674328471124261d,left: 0.10629926260329003d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7171718627922066d,right: 0.5591941407229858d,bottom: 0.1992467653087816d,left: 0.23879144152215448d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9614248551053537d,right: 0.8479939366114749d,bottom: 0.7012219925280503d,left: 0.7309402588944637d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7448592368330441d,right: 0.5311651458763358d,bottom: 0.6798362478932188d,left: 0.2586532839493235d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9666734979327873d,right: 0.62946608986814d,bottom: 0.15170347055639277d,left: 0.04410527325656621d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7198992831235284d,right: 0.9935909160935542d,bottom: 0.17263196368613964d,left: 0.6799212362025362d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6058920917280448d,right: 0.9622143511161694d,bottom: 0.04523369311192971d,left: 0.29698099322134386d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7714847253272811d,right: 0.8549667354063192d,bottom: 0.40978531817222463d,left: 0.4882194515215138d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3676833603482845d,right: 0.610895754842349d,bottom: 0.006108893728451581d,left: 0.346050178716899d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46288260359175626d,right: 0.6965840488222833d,bottom: 0.013859193292408256d,left: 0.5564434347173123d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.33031615336664644d,right: 0.8954835463134071d,bottom: 0.2433648286813055d,left: 0.7310441686010856d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7977643886731715d,right: 0.9783994879608964d,bottom: 0.625645171158687d,left: 0.7952181052100005d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8300923952186485d,right: 0.46953774927107517d,bottom: 0.4798788861340463d,left: 0.09567433537563286d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8484068255621134d,right: 0.6370105870074031d,bottom: 0.7526229806144616d,left: 0.10632648648962295d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5073499506155026d,right: 0.5338114546625136d,bottom: 0.41187750625794695d,left: 0.5208059311814282d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8739791268637629d,right: 0.5347554721079851d,bottom: 0.4173704542126807d,left: 0.4601088982653361d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4682522478847103d,right: 0.44670356133617717d,bottom: 0.40355522646031816d,left: 0.27878076192148504d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9615886931544944d,right: 0.9978928120065836d,bottom: 0.4078279780346681d,left: 0.4702442865044212d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4775529734252778d,right: 0.7004771167448809d,bottom: 0.10163357910426551d,left: 0.027203473656676858d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6533038957181686d,right: 0.9963458996295642d,bottom: 0.027449247238492847d,left: 0.7100124428190727d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9344654053023409d,right: 0.67151453861439d,bottom: 0.061232925265282234d,left: 0.48100117227559147d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.21588493461818903d,right: 0.31153145327301957d,bottom: 0.10105907843795403d,left: 0.23459689008624018d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5267675291862725d,right: 0.2776643740198492d,bottom: 0.47437094970363514d,left: 0.2134441056234716d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5105227454332589d,right: 0.06559841818628487d,bottom: 0.4117675783779894d,left: 0.03636376474949232d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6174540694562487d,right: 0.2146499838296846d,bottom: 0.11692743857573218d,left: 0.18873447310423264d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8528360481983269d,right: 0.8207666020774841d,bottom: 0.18858061595867837d,left: 0.010783471104802156d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8698075234576987d,right: 0.8574788527352409d,bottom: 0.029302929641559783d,left: 0.36283265381108476d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9666351397424888d,right: 0.4949748381933964d,bottom: 0.6197908915789695d,left: 0.4167863419159117d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8847014087640934d,right: 0.8136713869401772d,bottom: 0.1978714619832892d,left: 0.5372415764707292d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8769838741703548d,right: 0.621151933102224d,bottom: 0.7800406172331364d,left: 0.4538173683923813d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4152513324519568d,right: 0.2729482053758031d,bottom: 0.23311102087335045d,left: 0.2699244489666264d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.67686822215819d,right: 0.6836239430443091d,bottom: 0.2589904834747797d,left: 0.464151692495675d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7930656311930517d,right: 0.2974728460417494d,bottom: 0.5997225478259892d,left: 0.1657315610132264d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8926681314949987d,right: 0.36698201739141456d,bottom: 0.5536049137160638d,left: 0.3525352442449491d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2778736777451353d,right: 0.4864177630605566d,bottom: 0.0653601991550018d,left: 0.3950337174551096d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.624804252616108d,right: 0.9665257725334989d,bottom: 0.352227236535575d,left: 0.28436276818132333d))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.288861105251182d,right: 0.9353292978388037d,bottom: 0.21941051979516368d,left: 0.817547655936897d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7544097514701886d,right: 0.7460074211772839d,bottom: 0.2630872954764958d,left: 0.3663376966549021d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3055824334434116d,right: 0.7435329127302254d,bottom: 0.0922088913105149d,left: 0.5288588689357839d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9926359067775221d,right: 0.49785894743127823d,bottom: 0.31424231743134456d,left: 0.495336671067082d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8203300222283477d,right: 0.8523797859843786d,bottom: 0.6974057088755796d,left: 0.45752756423734964d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9663476749114236d,right: 0.6162794269878704d,bottom: 0.7639104339270439d,left: 0.13095102325936203d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8667045760020642d,right: 0.5979565075105231d,bottom: 0.7811863198696095d,left: 0.21446463420623862d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.623052475276252d,right: 0.666501727709438d,bottom: 0.11633730424162059d,left: 0.5079261505996892d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49401460904215355d,right: 0.9022675171981069d,bottom: 0.3718299944087814d,left: 0.48792108815711144d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.18294184488779253d,right: 0.7792320547787885d,bottom: 0.007906724654538233d,left: 0.7128851349906139d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.990735504280649d,right: 0.9606254331022588d,bottom: 0.8059281753875992d,left: 0.06915138776992558d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9101398221069296d,right: 0.6741516575051938d,bottom: 0.9059137741667884d,left: 0.16165624784777033d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5750823635327003d,right: 0.651104394172774d,bottom: 0.5002720520104602d,left: 0.2500225719129122d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7474052357442439d,right: 0.04440988867082796d,bottom: 0.05763899885419832d,left: 0.03732057596779359d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.754125319606663d,right: 0.5939186844305918d,bottom: 0.04248027177668634d,left: 0.253320188458355d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.47697728184706156d,right: 0.5239253677495042d,bottom: 0.30779088271678756d,left: 0.002878338436429262d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5783036877754598d,right: 0.13002181247637334d,bottom: 0.39607390523807606d,left: 0.03920473209649089d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5085405212494275d,right: 0.25480035368178644d,bottom: 0.12068331760436912d,left: 0.01420954095191973d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.20416219458766727d,right: 0.8021645284855284d,bottom: 0.06238139740101212d,left: 0.752588764834867d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9083352316440884d,right: 0.31750118649607995d,bottom: 0.7942532526831146d,left: 0.11741917806737401d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7344823934831168d,right: 0.5509925146782585d,bottom: 0.7014426970187695d,left: 0.1771799654268239d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6141583100411782d,right: 0.8376817927924857d,bottom: 0.36607033997905136d,left: 0.5810055954855774d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8286332237997246d,right: 0.36906448895995647d,bottom: 0.7222905960166393d,left: 0.15167144091601692d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2287938507027657d,right: 0.6463544326097757d,bottom: 0.22577451484774658d,left: 0.3360880099134782d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.786936003416376d,right: 0.2882359994366136d,bottom: 0.48068250823184666d,left: 0.23520322486148493d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5710744304555492d,right: 0.412896978636779d,bottom: 0.07612661784506602d,left: 0.18339195492983618d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46405059175848096d,right: 0.9325824129943661d,bottom: 0.13864422934731024d,left: 0.41934125487400176d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.48672279559523113d,right: 0.5317040137760025d,bottom: 0.35564951767665665d,left: 0.3619669497210809d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.759471953046121d,right: 0.17981230200311582d,bottom: 0.1839116733603493d,left: 0.15543071743116899d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5317284056278737d,right: 0.8186802858070079d,bottom: 0.17549291324257388d,left: 0.19622616787917668d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4905854860293035d,right: 0.8088075365296921d,bottom: 0.04504095702351396d,left: 0.4706813029961606d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6794913311985215d,right: 0.5899923290661271d,bottom: 0.21880442289848d,left: 0.41585334796658124d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8946246804789734d,right: 0.906007793226034d,bottom: 0.4755674429948882d,left: 0.43572470624031d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.08599684422575582d,right: 0.484178747316784d,bottom: 0.008918440967852104d,left: 0.1429756648914341d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7867863752266139d,right: 0.4243876859549749d,bottom: 0.27501710966563553d,left: 0.22086247997414232d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5300276138956636d,right: 0.2463751316056566d,bottom: 0.31891237380042126d,left: 0.0876963992326566d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5329734984105916d,right: 0.31320181758419485d,bottom: 0.3972259259219877d,left: 0.07520603120558766d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.21645455946493064d,right: 0.6436595631164127d,bottom: 0.010674328471124261d,left: 0.10629926260329003d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7171718627922066d,right: 0.5591941407229858d,bottom: 0.1992467653087816d,left: 0.23879144152215448d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9614248551053537d,right: 0.8479939366114749d,bottom: 0.7012219925280503d,left: 0.7309402588944637d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7448592368330441d,right: 0.5311651458763358d,bottom: 0.6798362478932188d,left: 0.2586532839493235d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9666734979327873d,right: 0.62946608986814d,bottom: 0.15170347055639277d,left: 0.04410527325656621d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7198992831235284d,right: 0.9935909160935542d,bottom: 0.17263196368613964d,left: 0.6799212362025362d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6058920917280448d,right: 0.9622143511161694d,bottom: 0.04523369311192971d,left: 0.29698099322134386d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7714847253272811d,right: 0.8549667354063192d,bottom: 0.40978531817222463d,left: 0.4882194515215138d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3676833603482845d,right: 0.610895754842349d,bottom: 0.006108893728451581d,left: 0.346050178716899d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46288260359175626d,right: 0.6965840488222833d,bottom: 0.013859193292408256d,left: 0.5564434347173123d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.33031615336664644d,right: 0.8954835463134071d,bottom: 0.2433648286813055d,left: 0.7310441686010856d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7977643886731715d,right: 0.9783994879608964d,bottom: 0.625645171158687d,left: 0.7952181052100005d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8300923952186485d,right: 0.46953774927107517d,bottom: 0.4798788861340463d,left: 0.09567433537563286d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8484068255621134d,right: 0.6370105870074031d,bottom: 0.7526229806144616d,left: 0.10632648648962295d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5073499506155026d,right: 0.5338114546625136d,bottom: 0.41187750625794695d,left: 0.5208059311814282d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8739791268637629d,right: 0.5347554721079851d,bottom: 0.4173704542126807d,left: 0.4601088982653361d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4682522478847103d,right: 0.44670356133617717d,bottom: 0.40355522646031816d,left: 0.27878076192148504d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9615886931544944d,right: 0.9978928120065836d,bottom: 0.4078279780346681d,left: 0.4702442865044212d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4775529734252778d,right: 0.7004771167448809d,bottom: 0.10163357910426551d,left: 0.027203473656676858d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6533038957181686d,right: 0.9963458996295642d,bottom: 0.027449247238492847d,left: 0.7100124428190727d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9344654053023409d,right: 0.67151453861439d,bottom: 0.061232925265282234d,left: 0.48100117227559147d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.21588493461818903d,right: 0.31153145327301957d,bottom: 0.10105907843795403d,left: 0.23459689008624018d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5267675291862725d,right: 0.2776643740198492d,bottom: 0.47437094970363514d,left: 0.2134441056234716d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5105227454332589d,right: 0.06559841818628487d,bottom: 0.4117675783779894d,left: 0.03636376474949232d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6174540694562487d,right: 0.2146499838296846d,bottom: 0.11692743857573218d,left: 0.18873447310423264d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8528360481983269d,right: 0.8207666020774841d,bottom: 0.18858061595867837d,left: 0.010783471104802156d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8698075234576987d,right: 0.8574788527352409d,bottom: 0.029302929641559783d,left: 0.36283265381108476d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9666351397424888d,right: 0.4949748381933964d,bottom: 0.6197908915789695d,left: 0.4167863419159117d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8847014087640934d,right: 0.8136713869401772d,bottom: 0.1978714619832892d,left: 0.5372415764707292d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8769838741703548d,right: 0.621151933102224d,bottom: 0.7800406172331364d,left: 0.4538173683923813d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4152513324519568d,right: 0.2729482053758031d,bottom: 0.23311102087335045d,left: 0.2699244489666264d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.67686822215819d,right: 0.6836239430443091d,bottom: 0.2589904834747797d,left: 0.464151692495675d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7930656311930517d,right: 0.2974728460417494d,bottom: 0.5997225478259892d,left: 0.1657315610132264d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8926681314949987d,right: 0.36698201739141456d,bottom: 0.5536049137160638d,left: 0.3525352442449491d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2778736777451353d,right: 0.4864177630605566d,bottom: 0.0653601991550018d,left: 0.3950337174551096d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.624804252616108d,right: 0.9665257725334989d,bottom: 0.352227236535575d,left: 0.28436276818132333d))));

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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxSingleTypebox)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxSingleTypebox)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(NpgsqlBoxbox0M),
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxSingleTypebox)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxbox0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxSingleTypebox)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxbox0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3)
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA), typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA), typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI), typeof(NpgsqlBoxbox0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models1 = new List<NpgsqlBoxbox0MI>();
                var models2 = new List<NpgsqlBoxbox0MI>();
                await ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MI>();
                var models2 = new List<NpgsqlBoxbox0MI>();
                ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models = await ((INpgsqlBoxSingleTypebox)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA), typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models = await ((INpgsqlBoxSingleTypebox)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

