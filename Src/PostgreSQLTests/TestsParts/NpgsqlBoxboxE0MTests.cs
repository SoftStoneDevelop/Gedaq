

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

        private readonly NpgsqlBoxboxE0M[] _testData = new NpgsqlBoxboxE0M[]
        {
            new NpgsqlBoxboxE0M
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6236842293185662d,right: 0.34736653062011513d,bottom: 0.054123632778563135d,left: 0.034992399577605804d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6880183004725714d,right: 0.702254761542333d,bottom: 0.6016589648843242d,left: 0.2574791948360349d),
},
            new NpgsqlBoxboxE0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5315367072280407d,right: 0.4992454182907019d,bottom: 0.3079250219945595d,left: 0.4952520403754598d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5599685665310447d,right: 0.7972017366480993d,bottom: 0.25696020609985326d,left: 0.36578720501107065d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.900187667591866d,right: 0.3654218591525016d,bottom: 0.25269846454885303d,left: 0.1015586777263825d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9973800042676326d,right: 0.6897831853484735d,bottom: 0.24021282422390522d,left: 0.09575479589405911d),
},
            new NpgsqlBoxboxE0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4163766547148646d,right: 0.2989160393476462d,bottom: 0.38040207030092366d,left: 0.08740881001683021d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.660612310313667d,right: 0.8036098110812299d,bottom: 0.14706073753308968d,left: 0.4527347261075184d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.27128161602007805d,right: 0.8681973130484093d,bottom: 0.03920885507680172d,left: 0.806462471526049d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6593989784109943d,right: 0.678537239459265d,bottom: 0.24659769543735444d,left: 0.40933676103715455d),
},
            new NpgsqlBoxboxE0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9672504003016268d,right: 0.6564495207229158d,bottom: 0.8676206384122429d,left: 0.6107656995372766d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8916124020972358d,right: 0.49323651049606065d,bottom: 0.21197006270072172d,left: 0.3346392900905425d),
},
            new NpgsqlBoxboxE0M
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8832990389279886d,right: 0.35673273707276976d,bottom: 0.2435944022044363d,left: 0.21318625380540313d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9457251508753745d,right: 0.6814354834819458d,bottom: 0.27220110685312837d,left: 0.41141199898387704d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.19386219912249736d,right: 0.9003914602651037d,bottom: 0.18384005233796663d,left: 0.7557181007461679d),
},
            new NpgsqlBoxboxE0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.1928624365127669d,right: 0.8986373590112369d,bottom: 0.1213547425310223d,left: 0.8313167441654813d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.46349040047609935d,right: 0.9554358496457913d,bottom: 0.16779713905654614d,left: 0.90181237713697d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.26710270908821787d,right: 0.6415831582773869d,bottom: 0.25261474699253494d,left: 0.3761395483830997d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4089531766428267d,right: 0.45466325780907924d,bottom: 0.19899283068992524d,left: 0.3285041868463867d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9048266945614339d,right: 0.951278275828103d,bottom: 0.17855154912967397d,left: 0.16727534612358175d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6652612506083949d,right: 0.7977421667035356d,bottom: 0.2426443324105504d,left: 0.41772269210296764d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7642483028374221d,right: 0.7394051934990932d,bottom: 0.43238801826965756d,left: 0.45995619251708875d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9775077844929997d,right: 0.712841867169857d,bottom: 0.5986541277694265d,left: 0.0045971292793711704d),
},
            new NpgsqlBoxboxE0M
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9200181413560083d,right: 0.6066304485133572d,bottom: 0.051820881631910676d,left: 0.41887425745044005d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.790177062073689d,right: 0.8660343021241246d,bottom: 0.5998502230181794d,left: 0.7847049484105156d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8850562681997101d,right: 0.8825343208596745d,bottom: 0.3445833868012542d,left: 0.31382813159323286d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9358473091110188d,right: 0.5622401510929051d,bottom: 0.18146319640297526d,left: 0.3306964285749686d),
},
            new NpgsqlBoxboxE0M
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3385900093237084d,right: 0.9506879075996791d,bottom: 0.30850149997647935d,left: 0.1772744398451812d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9415160457729085d,right: 0.7721241411286327d,bottom: 0.8587874062993793d,left: 0.1361277973828332d),
},
            new NpgsqlBoxboxE0M
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6978813328453497d,right: 0.6948847417780412d,bottom: 0.2809777426251572d,left: 0.47038235352987334d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5242928473228946d,right: 0.8521983582085415d,bottom: 0.34386635214776884d,left: 0.1293437502995195d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.28113234714252466d,right: 0.7702876591110218d,bottom: 0.27002295670297594d,left: 0.6661485156964414d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5736662185388408d,right: 0.7621943170710571d,bottom: 0.10384427446397448d,left: 0.6148201255621852d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8969010574718962d,right: 0.5334567356155978d,bottom: 0.47580019408942176d,left: 0.20281424484429267d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 104,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6845243392374579d,right: 0.5014293328378214d,bottom: 0.05487127784475421d,left: 0.19112159997783695d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.4255289239586708d,right: 0.4800149330768617d,bottom: 0.07096628650537351d,left: 0.1626035357767972d),
},
            new NpgsqlBoxboxE0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9157019884955913d,right: 0.7086658148401258d,bottom: 0.018839565906229705d,left: 0.3698053336951749d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5010761920348517d,right: 0.9187970781304815d,bottom: 0.3116655779857782d,left: 0.3093788768341885d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.17591227633725404d,right: 0.3567404627873092d,bottom: 0.05243933304086834d,left: 0.34354242018208236d),
},
            new NpgsqlBoxboxE0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7360259314467944d,right: 0.8651148040433168d,bottom: 0.44621962181515673d,left: 0.237168800071354d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9230224665915261d,right: 0.626964998170823d,bottom: 0.14980781341343352d,left: 0.3169947375112925d),
},
            new NpgsqlBoxboxE0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.18421394102920408d,right: 0.9495618355580817d,bottom: 0.007048636866983982d,left: 0.11352187541527348d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5624172791539783d,right: 0.6677701616908684d,bottom: 0.1487755789396541d,left: 0.3863848268889917d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 127,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7238856432197699d,right: 0.6475706119823919d,bottom: 0.38181377377852066d,left: 0.5436577825043303d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8628157760750862d,right: 0.8340828135074265d,bottom: 0.8608624813444685d,left: 0.4316883479567031d),
},
            new NpgsqlBoxboxE0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.654855678108935d,right: 0.8944043289054435d,bottom: 0.024129231573868037d,left: 0.7374626573085719d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7297625508108185d,right: 0.5192171830202196d,bottom: 0.35921951556625265d,left: 0.4522933584750003d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8190018184723604d,right: 0.4322964258212537d,bottom: 0.5869455220959392d,left: 0.4209408036182827d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.35203054477885565d,right: 0.9888728880510812d,bottom: 0.15073531495753345d,left: 0.4557910975252921d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7939163676949735d,right: 0.8793840715183658d,bottom: 0.6731248414732361d,left: 0.07807373593526212d),
},
            new NpgsqlBoxboxE0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.27429297011290044d,right: 0.8717494409732132d,bottom: 0.011682631072521654d,left: 0.4364954872796811d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.25858088093801523d,right: 0.7640895437658347d,bottom: 0.04382294345369253d,left: 0.015681252649711763d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5777207735434048d,right: 0.41017938976082435d,bottom: 0.08195053818444764d,left: 0.0986466075794532d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9917660091853349d,right: 0.6933820504765245d,bottom: 0.1744542200386502d,left: 0.4100916475914499d),
},
            new NpgsqlBoxboxE0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7172487468493964d,right: 0.9775556829089356d,bottom: 0.15584457934642504d,left: 0.5641245875753242d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 151,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.31189454343545076d,right: 0.488896849727278d,bottom: 0.002410675189991718d,left: 0.45991221629988555d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9528277336062795d,right: 0.4098017106770796d,bottom: 0.5712911073505117d,left: 0.03349214914693144d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 155,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8801324710622714d,right: 0.9077384278668783d,bottom: 0.4773430966261579d,left: 0.7658712711797192d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 163,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9998719585865031d,right: 0.7141336758172128d,bottom: 0.5531868731241135d,left: 0.6047875876144285d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.956150426549847d,right: 0.7769394037412686d,bottom: 0.4330500703575555d,left: 0.5057579116532438d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3676985429252936d,right: 0.5190611370226818d,bottom: 0.12158934277559885d,left: 0.3626957066614026d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.31958482773074537d,right: 0.7547469047695415d,bottom: 0.1568219026502553d,left: 0.1506617572804132d),
},
            new NpgsqlBoxboxE0M
{
    Id = 168,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8499487476338415d,right: 0.9162907065976257d,bottom: 0.05570001791342705d,left: 0.08160319641901115d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 173,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9172534403562964d,right: 0.6775393333620034d,bottom: 0.7068265084009482d,left: 0.4392137782182801d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8883256807454634d,right: 0.8773646915644717d,bottom: 0.6992185559450438d,left: 0.5466448490189685d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.989637813253231d,right: 0.58008847227245d,bottom: 0.9513909408511787d,left: 0.2194957706624887d),
},
            new NpgsqlBoxboxE0M
{
    Id = 174,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.45736133636461485d,right: 0.3756793167110538d,bottom: 0.08576049372269323d,left: 0.3141682307235507d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 179,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5656275527495607d,right: 0.9753532791732166d,bottom: 0.5104288849948369d,left: 0.587571757365607d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9752131580712318d,right: 0.9604270616241964d,bottom: 0.7402511791707161d,left: 0.04995242793692167d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7368963732485242d,right: 0.5130426881074738d,bottom: 0.17273182795574293d,left: 0.2414642913086843d),
},
            new NpgsqlBoxboxE0M
{
    Id = 182,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7839364178523295d,right: 0.809244568176279d,bottom: 0.7713366086592509d,left: 0.04053974202548616d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 186,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8225488348731103d,right: 0.4015963525577564d,bottom: 0.1343815952949381d,left: 0.12450516365031872d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8636573753461954d,right: 0.757591864104653d,bottom: 0.35257127458953097d,left: 0.35871861430888785d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 190,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8911942849516381d,right: 0.8149087174859749d,bottom: 0.639734113392274d,left: 0.45293437076276577d),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0mi(
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
INSERT INTO public.npgsqlboxboxe0mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxE0MI)],
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
INSERT INTO public.npgsqlboxboxe0mi(
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
INSERT INTO public.npgsqlboxboxe0m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxe0mi_id
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
                methodParametrName: "npgsqlboxboxe0mi_id", 
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
INSERT INTO public.npgsqlboxboxe0m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxe0mi_id
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
    npgsqlboxboxe0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.8916124020972358d,right: 0.49323651049606065d,bottom: 0.21197006270072172d,left: 0.3346392900905425d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.19386219912249736d,right: 0.9003914602651037d,bottom: 0.18384005233796663d,left: 0.7557181007461679d)));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxe0mi_id
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
    npgsqlboxboxe0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
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
                methodParametrName: "npgsqlboxboxe0mi_id", 
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.9775077844929997d,right: 0.712841867169857d,bottom: 0.5986541277694265d,left: 0.0045971292793711704d)));
                nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.9358473091110188d,right: 0.5622401510929051d,bottom: 0.18146319640297526d,left: 0.3306964285749686d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxE0M> models = null;

                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxE0M> models = null;

                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxe0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlboxboxe0mi_id
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
                parametrName: "npgsqlboxboxe0mi_id", 
                methodParametrName: "npgsqlboxboxe0mi_id", 
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
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M), typeof(FlatNpgsqlBoxboxE0M)],
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M)],
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
FROM public.npgsqlboxboxe0m m
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
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
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
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
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
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M), typeof(FlatNpgsqlBoxboxE0M)],
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M)],
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
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
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M), typeof(FlatNpgsqlBoxboxE0M)],
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 173;
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M)],
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
FROM public.npgsqlboxboxe0m m
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
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 168;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
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
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 57;
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
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
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[32],_testData[34], false);
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
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
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
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 182;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[34], false);
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
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M), typeof(FlatNpgsqlBoxboxE0M)],
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 179, query1, 108, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 108, query1, 75, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 108, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatch(connection, 75, query1, 83, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M)],
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 33, query1, 132, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 9, query1, 42, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatch(connection, 86, query1, 16, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[31],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatch(connection, 57, query1, 168, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
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
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatchAsync(connection, 42, 25))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[7], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[8], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[9], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[10], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[11], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[12], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[22],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[23],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[24],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[25],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[26],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[5], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[6], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[7], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[8], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[9], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[10], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[11], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[12], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[22],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[23],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[24],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[25],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[26],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[27],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[28],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[29],_testData[34], false);
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
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatch(connection, 151, 95))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[34], false);
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
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 127);
                var models = await ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(14));

                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[21], false);
                NpgsqlBoxboxE0M.AssertModel(models[1],_testData[22], false);
                NpgsqlBoxboxE0M.AssertModel(models[2],_testData[23], false);
                NpgsqlBoxboxE0M.AssertModel(models[3],_testData[24], false);
                NpgsqlBoxboxE0M.AssertModel(models[4],_testData[25], false);
                NpgsqlBoxboxE0M.AssertModel(models[5],_testData[26], false);
                NpgsqlBoxboxE0M.AssertModel(models[6],_testData[27], false);
                NpgsqlBoxboxE0M.AssertModel(models[7],_testData[28], false);
                NpgsqlBoxboxE0M.AssertModel(models[8],_testData[29], false);
                NpgsqlBoxboxE0M.AssertModel(models[9],_testData[30], false);
                NpgsqlBoxboxE0M.AssertModel(models[10],_testData[31], false);
                NpgsqlBoxboxE0M.AssertModel(models[11],_testData[32], false);
                NpgsqlBoxboxE0M.AssertModel(models[12],_testData[33], false);
                NpgsqlBoxboxE0M.AssertModel(models[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 182);
                var models =  ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[33], false);
                NpgsqlBoxboxE0M.AssertModel(models[1],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6236842293185662d,right: 0.34736653062011513d,bottom: 0.054123632778563135d,left: 0.034992399577605804d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6880183004725714d,right: 0.702254761542333d,bottom: 0.6016589648843242d,left: 0.2574791948360349d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5315367072280407d,right: 0.4992454182907019d,bottom: 0.3079250219945595d,left: 0.4952520403754598d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5599685665310447d,right: 0.7972017366480993d,bottom: 0.25696020609985326d,left: 0.36578720501107065d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.900187667591866d,right: 0.3654218591525016d,bottom: 0.25269846454885303d,left: 0.1015586777263825d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9973800042676326d,right: 0.6897831853484735d,bottom: 0.24021282422390522d,left: 0.09575479589405911d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4163766547148646d,right: 0.2989160393476462d,bottom: 0.38040207030092366d,left: 0.08740881001683021d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.660612310313667d,right: 0.8036098110812299d,bottom: 0.14706073753308968d,left: 0.4527347261075184d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.27128161602007805d,right: 0.8681973130484093d,bottom: 0.03920885507680172d,left: 0.806462471526049d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6593989784109943d,right: 0.678537239459265d,bottom: 0.24659769543735444d,left: 0.40933676103715455d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9672504003016268d,right: 0.6564495207229158d,bottom: 0.8676206384122429d,left: 0.6107656995372766d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8916124020972358d,right: 0.49323651049606065d,bottom: 0.21197006270072172d,left: 0.3346392900905425d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8832990389279886d,right: 0.35673273707276976d,bottom: 0.2435944022044363d,left: 0.21318625380540313d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9457251508753745d,right: 0.6814354834819458d,bottom: 0.27220110685312837d,left: 0.41141199898387704d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.19386219912249736d,right: 0.9003914602651037d,bottom: 0.18384005233796663d,left: 0.7557181007461679d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1928624365127669d,right: 0.8986373590112369d,bottom: 0.1213547425310223d,left: 0.8313167441654813d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46349040047609935d,right: 0.9554358496457913d,bottom: 0.16779713905654614d,left: 0.90181237713697d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.26710270908821787d,right: 0.6415831582773869d,bottom: 0.25261474699253494d,left: 0.3761395483830997d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4089531766428267d,right: 0.45466325780907924d,bottom: 0.19899283068992524d,left: 0.3285041868463867d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9048266945614339d,right: 0.951278275828103d,bottom: 0.17855154912967397d,left: 0.16727534612358175d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6652612506083949d,right: 0.7977421667035356d,bottom: 0.2426443324105504d,left: 0.41772269210296764d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7642483028374221d,right: 0.7394051934990932d,bottom: 0.43238801826965756d,left: 0.45995619251708875d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9775077844929997d,right: 0.712841867169857d,bottom: 0.5986541277694265d,left: 0.0045971292793711704d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9200181413560083d,right: 0.6066304485133572d,bottom: 0.051820881631910676d,left: 0.41887425745044005d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.790177062073689d,right: 0.8660343021241246d,bottom: 0.5998502230181794d,left: 0.7847049484105156d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8850562681997101d,right: 0.8825343208596745d,bottom: 0.3445833868012542d,left: 0.31382813159323286d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9358473091110188d,right: 0.5622401510929051d,bottom: 0.18146319640297526d,left: 0.3306964285749686d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3385900093237084d,right: 0.9506879075996791d,bottom: 0.30850149997647935d,left: 0.1772744398451812d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9415160457729085d,right: 0.7721241411286327d,bottom: 0.8587874062993793d,left: 0.1361277973828332d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6978813328453497d,right: 0.6948847417780412d,bottom: 0.2809777426251572d,left: 0.47038235352987334d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5242928473228946d,right: 0.8521983582085415d,bottom: 0.34386635214776884d,left: 0.1293437502995195d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.28113234714252466d,right: 0.7702876591110218d,bottom: 0.27002295670297594d,left: 0.6661485156964414d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5736662185388408d,right: 0.7621943170710571d,bottom: 0.10384427446397448d,left: 0.6148201255621852d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8969010574718962d,right: 0.5334567356155978d,bottom: 0.47580019408942176d,left: 0.20281424484429267d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6845243392374579d,right: 0.5014293328378214d,bottom: 0.05487127784475421d,left: 0.19112159997783695d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4255289239586708d,right: 0.4800149330768617d,bottom: 0.07096628650537351d,left: 0.1626035357767972d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9157019884955913d,right: 0.7086658148401258d,bottom: 0.018839565906229705d,left: 0.3698053336951749d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5010761920348517d,right: 0.9187970781304815d,bottom: 0.3116655779857782d,left: 0.3093788768341885d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.17591227633725404d,right: 0.3567404627873092d,bottom: 0.05243933304086834d,left: 0.34354242018208236d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7360259314467944d,right: 0.8651148040433168d,bottom: 0.44621962181515673d,left: 0.237168800071354d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9230224665915261d,right: 0.626964998170823d,bottom: 0.14980781341343352d,left: 0.3169947375112925d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.18421394102920408d,right: 0.9495618355580817d,bottom: 0.007048636866983982d,left: 0.11352187541527348d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5624172791539783d,right: 0.6677701616908684d,bottom: 0.1487755789396541d,left: 0.3863848268889917d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7238856432197699d,right: 0.6475706119823919d,bottom: 0.38181377377852066d,left: 0.5436577825043303d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8628157760750862d,right: 0.8340828135074265d,bottom: 0.8608624813444685d,left: 0.4316883479567031d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.654855678108935d,right: 0.8944043289054435d,bottom: 0.024129231573868037d,left: 0.7374626573085719d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7297625508108185d,right: 0.5192171830202196d,bottom: 0.35921951556625265d,left: 0.4522933584750003d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8190018184723604d,right: 0.4322964258212537d,bottom: 0.5869455220959392d,left: 0.4209408036182827d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.35203054477885565d,right: 0.9888728880510812d,bottom: 0.15073531495753345d,left: 0.4557910975252921d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7939163676949735d,right: 0.8793840715183658d,bottom: 0.6731248414732361d,left: 0.07807373593526212d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.27429297011290044d,right: 0.8717494409732132d,bottom: 0.011682631072521654d,left: 0.4364954872796811d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.25858088093801523d,right: 0.7640895437658347d,bottom: 0.04382294345369253d,left: 0.015681252649711763d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5777207735434048d,right: 0.41017938976082435d,bottom: 0.08195053818444764d,left: 0.0986466075794532d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9917660091853349d,right: 0.6933820504765245d,bottom: 0.1744542200386502d,left: 0.4100916475914499d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7172487468493964d,right: 0.9775556829089356d,bottom: 0.15584457934642504d,left: 0.5641245875753242d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.31189454343545076d,right: 0.488896849727278d,bottom: 0.002410675189991718d,left: 0.45991221629988555d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9528277336062795d,right: 0.4098017106770796d,bottom: 0.5712911073505117d,left: 0.03349214914693144d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8801324710622714d,right: 0.9077384278668783d,bottom: 0.4773430966261579d,left: 0.7658712711797192d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9998719585865031d,right: 0.7141336758172128d,bottom: 0.5531868731241135d,left: 0.6047875876144285d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.956150426549847d,right: 0.7769394037412686d,bottom: 0.4330500703575555d,left: 0.5057579116532438d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3676985429252936d,right: 0.5190611370226818d,bottom: 0.12158934277559885d,left: 0.3626957066614026d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.31958482773074537d,right: 0.7547469047695415d,bottom: 0.1568219026502553d,left: 0.1506617572804132d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8499487476338415d,right: 0.9162907065976257d,bottom: 0.05570001791342705d,left: 0.08160319641901115d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9172534403562964d,right: 0.6775393333620034d,bottom: 0.7068265084009482d,left: 0.4392137782182801d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8883256807454634d,right: 0.8773646915644717d,bottom: 0.6992185559450438d,left: 0.5466448490189685d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.989637813253231d,right: 0.58008847227245d,bottom: 0.9513909408511787d,left: 0.2194957706624887d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.45736133636461485d,right: 0.3756793167110538d,bottom: 0.08576049372269323d,left: 0.3141682307235507d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5656275527495607d,right: 0.9753532791732166d,bottom: 0.5104288849948369d,left: 0.587571757365607d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9752131580712318d,right: 0.9604270616241964d,bottom: 0.7402511791707161d,left: 0.04995242793692167d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7368963732485242d,right: 0.5130426881074738d,bottom: 0.17273182795574293d,left: 0.2414642913086843d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((182)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7839364178523295d,right: 0.809244568176279d,bottom: 0.7713366086592509d,left: 0.04053974202548616d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((186)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8225488348731103d,right: 0.4015963525577564d,bottom: 0.1343815952949381d,left: 0.12450516365031872d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8636573753461954d,right: 0.757591864104653d,bottom: 0.35257127458953097d,left: 0.35871861430888785d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((190)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8911942849516381d,right: 0.8149087174859749d,bottom: 0.639734113392274d,left: 0.45293437076276577d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6236842293185662d,right: 0.34736653062011513d,bottom: 0.054123632778563135d,left: 0.034992399577605804d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6880183004725714d,right: 0.702254761542333d,bottom: 0.6016589648843242d,left: 0.2574791948360349d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5315367072280407d,right: 0.4992454182907019d,bottom: 0.3079250219945595d,left: 0.4952520403754598d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5599685665310447d,right: 0.7972017366480993d,bottom: 0.25696020609985326d,left: 0.36578720501107065d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.900187667591866d,right: 0.3654218591525016d,bottom: 0.25269846454885303d,left: 0.1015586777263825d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9973800042676326d,right: 0.6897831853484735d,bottom: 0.24021282422390522d,left: 0.09575479589405911d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4163766547148646d,right: 0.2989160393476462d,bottom: 0.38040207030092366d,left: 0.08740881001683021d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.660612310313667d,right: 0.8036098110812299d,bottom: 0.14706073753308968d,left: 0.4527347261075184d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.27128161602007805d,right: 0.8681973130484093d,bottom: 0.03920885507680172d,left: 0.806462471526049d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6593989784109943d,right: 0.678537239459265d,bottom: 0.24659769543735444d,left: 0.40933676103715455d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9672504003016268d,right: 0.6564495207229158d,bottom: 0.8676206384122429d,left: 0.6107656995372766d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8916124020972358d,right: 0.49323651049606065d,bottom: 0.21197006270072172d,left: 0.3346392900905425d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8832990389279886d,right: 0.35673273707276976d,bottom: 0.2435944022044363d,left: 0.21318625380540313d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9457251508753745d,right: 0.6814354834819458d,bottom: 0.27220110685312837d,left: 0.41141199898387704d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.19386219912249736d,right: 0.9003914602651037d,bottom: 0.18384005233796663d,left: 0.7557181007461679d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1928624365127669d,right: 0.8986373590112369d,bottom: 0.1213547425310223d,left: 0.8313167441654813d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46349040047609935d,right: 0.9554358496457913d,bottom: 0.16779713905654614d,left: 0.90181237713697d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.26710270908821787d,right: 0.6415831582773869d,bottom: 0.25261474699253494d,left: 0.3761395483830997d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4089531766428267d,right: 0.45466325780907924d,bottom: 0.19899283068992524d,left: 0.3285041868463867d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9048266945614339d,right: 0.951278275828103d,bottom: 0.17855154912967397d,left: 0.16727534612358175d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6652612506083949d,right: 0.7977421667035356d,bottom: 0.2426443324105504d,left: 0.41772269210296764d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7642483028374221d,right: 0.7394051934990932d,bottom: 0.43238801826965756d,left: 0.45995619251708875d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9775077844929997d,right: 0.712841867169857d,bottom: 0.5986541277694265d,left: 0.0045971292793711704d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9200181413560083d,right: 0.6066304485133572d,bottom: 0.051820881631910676d,left: 0.41887425745044005d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.790177062073689d,right: 0.8660343021241246d,bottom: 0.5998502230181794d,left: 0.7847049484105156d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8850562681997101d,right: 0.8825343208596745d,bottom: 0.3445833868012542d,left: 0.31382813159323286d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9358473091110188d,right: 0.5622401510929051d,bottom: 0.18146319640297526d,left: 0.3306964285749686d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3385900093237084d,right: 0.9506879075996791d,bottom: 0.30850149997647935d,left: 0.1772744398451812d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9415160457729085d,right: 0.7721241411286327d,bottom: 0.8587874062993793d,left: 0.1361277973828332d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6978813328453497d,right: 0.6948847417780412d,bottom: 0.2809777426251572d,left: 0.47038235352987334d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5242928473228946d,right: 0.8521983582085415d,bottom: 0.34386635214776884d,left: 0.1293437502995195d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.28113234714252466d,right: 0.7702876591110218d,bottom: 0.27002295670297594d,left: 0.6661485156964414d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5736662185388408d,right: 0.7621943170710571d,bottom: 0.10384427446397448d,left: 0.6148201255621852d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8969010574718962d,right: 0.5334567356155978d,bottom: 0.47580019408942176d,left: 0.20281424484429267d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6845243392374579d,right: 0.5014293328378214d,bottom: 0.05487127784475421d,left: 0.19112159997783695d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4255289239586708d,right: 0.4800149330768617d,bottom: 0.07096628650537351d,left: 0.1626035357767972d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9157019884955913d,right: 0.7086658148401258d,bottom: 0.018839565906229705d,left: 0.3698053336951749d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5010761920348517d,right: 0.9187970781304815d,bottom: 0.3116655779857782d,left: 0.3093788768341885d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.17591227633725404d,right: 0.3567404627873092d,bottom: 0.05243933304086834d,left: 0.34354242018208236d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7360259314467944d,right: 0.8651148040433168d,bottom: 0.44621962181515673d,left: 0.237168800071354d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9230224665915261d,right: 0.626964998170823d,bottom: 0.14980781341343352d,left: 0.3169947375112925d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.18421394102920408d,right: 0.9495618355580817d,bottom: 0.007048636866983982d,left: 0.11352187541527348d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5624172791539783d,right: 0.6677701616908684d,bottom: 0.1487755789396541d,left: 0.3863848268889917d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7238856432197699d,right: 0.6475706119823919d,bottom: 0.38181377377852066d,left: 0.5436577825043303d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8628157760750862d,right: 0.8340828135074265d,bottom: 0.8608624813444685d,left: 0.4316883479567031d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.654855678108935d,right: 0.8944043289054435d,bottom: 0.024129231573868037d,left: 0.7374626573085719d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7297625508108185d,right: 0.5192171830202196d,bottom: 0.35921951556625265d,left: 0.4522933584750003d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8190018184723604d,right: 0.4322964258212537d,bottom: 0.5869455220959392d,left: 0.4209408036182827d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.35203054477885565d,right: 0.9888728880510812d,bottom: 0.15073531495753345d,left: 0.4557910975252921d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7939163676949735d,right: 0.8793840715183658d,bottom: 0.6731248414732361d,left: 0.07807373593526212d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.27429297011290044d,right: 0.8717494409732132d,bottom: 0.011682631072521654d,left: 0.4364954872796811d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.25858088093801523d,right: 0.7640895437658347d,bottom: 0.04382294345369253d,left: 0.015681252649711763d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5777207735434048d,right: 0.41017938976082435d,bottom: 0.08195053818444764d,left: 0.0986466075794532d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9917660091853349d,right: 0.6933820504765245d,bottom: 0.1744542200386502d,left: 0.4100916475914499d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7172487468493964d,right: 0.9775556829089356d,bottom: 0.15584457934642504d,left: 0.5641245875753242d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.31189454343545076d,right: 0.488896849727278d,bottom: 0.002410675189991718d,left: 0.45991221629988555d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9528277336062795d,right: 0.4098017106770796d,bottom: 0.5712911073505117d,left: 0.03349214914693144d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8801324710622714d,right: 0.9077384278668783d,bottom: 0.4773430966261579d,left: 0.7658712711797192d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9998719585865031d,right: 0.7141336758172128d,bottom: 0.5531868731241135d,left: 0.6047875876144285d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.956150426549847d,right: 0.7769394037412686d,bottom: 0.4330500703575555d,left: 0.5057579116532438d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3676985429252936d,right: 0.5190611370226818d,bottom: 0.12158934277559885d,left: 0.3626957066614026d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.31958482773074537d,right: 0.7547469047695415d,bottom: 0.1568219026502553d,left: 0.1506617572804132d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8499487476338415d,right: 0.9162907065976257d,bottom: 0.05570001791342705d,left: 0.08160319641901115d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9172534403562964d,right: 0.6775393333620034d,bottom: 0.7068265084009482d,left: 0.4392137782182801d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8883256807454634d,right: 0.8773646915644717d,bottom: 0.6992185559450438d,left: 0.5466448490189685d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.989637813253231d,right: 0.58008847227245d,bottom: 0.9513909408511787d,left: 0.2194957706624887d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.45736133636461485d,right: 0.3756793167110538d,bottom: 0.08576049372269323d,left: 0.3141682307235507d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5656275527495607d,right: 0.9753532791732166d,bottom: 0.5104288849948369d,left: 0.587571757365607d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9752131580712318d,right: 0.9604270616241964d,bottom: 0.7402511791707161d,left: 0.04995242793692167d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7368963732485242d,right: 0.5130426881074738d,bottom: 0.17273182795574293d,left: 0.2414642913086843d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((182)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7839364178523295d,right: 0.809244568176279d,bottom: 0.7713366086592509d,left: 0.04053974202548616d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((186)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8225488348731103d,right: 0.4015963525577564d,bottom: 0.1343815952949381d,left: 0.12450516365031872d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8636573753461954d,right: 0.757591864104653d,bottom: 0.35257127458953097d,left: 0.35871861430888785d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((190)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8911942849516381d,right: 0.8149087174859749d,bottom: 0.639734113392274d,left: 0.45293437076276577d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_npgsqlboxboxe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
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
            queryMapType: typeof(NpgsqlBoxboxE0MIWA),
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
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
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
            queryMapType: typeof(NpgsqlBoxboxE0MIWA),
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
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MI)],
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
COPY public.binary_npgsqlboxboxe0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxE0MI),
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
                var importCollection = new List<NpgsqlBoxboxE0MI>(2);
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
                    NpgsqlBoxboxE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0MI>(2);
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
                    NpgsqlBoxboxE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
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
COPY public.binary_npgsqlboxboxe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxE0MIWA),
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
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
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
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
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
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxe0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxe0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxE0M),
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
FROM public.binary_npgsqlboxboxe0m m
LEFT JOIN public.binary_npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
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
                var importCollection = new List<NpgsqlBoxboxE0M>();
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
                    NpgsqlBoxboxE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0M>();
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
                    NpgsqlBoxboxE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxe0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxe0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
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
                    NpgsqlBoxboxE0M.AssertModel(model, expectedModel, true);
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
                    NpgsqlBoxboxE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA), typeof(NpgsqlBoxboxE0MIWA)],
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
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
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
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
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
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
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA), typeof(NpgsqlBoxboxE0MIWA)],
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
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
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
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
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
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
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MI), typeof(NpgsqlBoxboxE0MI)],
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
                var models1 = new List<NpgsqlBoxboxE0MI>();
                var models2 = new List<NpgsqlBoxboxE0MI>();
                await ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxE0MI>();
                var models2 = new List<NpgsqlBoxboxE0MI>();
                ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxe0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MI)],
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
                    NpgsqlBoxboxE0MI.AssertModel(model, expectedModel, false);
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
                    NpgsqlBoxboxE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA), typeof(NpgsqlBoxboxE0MIWA)],
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxe0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
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
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
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
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

