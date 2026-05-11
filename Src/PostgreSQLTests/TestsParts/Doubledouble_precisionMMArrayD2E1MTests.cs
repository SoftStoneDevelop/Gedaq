

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
    Id = 6,
    Value = 
new System.Double[,] { { 0.904763213458523d, 0.38174837313136767d, }, { 0.046194390552214415d, 0.8386744446107903d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.3261742853632965d, 0.17890084665824002d, }, { 0.44682128711539315d, 0.12621642152489732d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 10,
    Value = 
new System.Double[,] { { 0.7103206491820473d, 0.1876900435123533d, }, { 0.3728313744628804d, 0.7142547447615298d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 2,
    Value = 
new System.Double[,] { { 0.15122914033233392d, 0.07318096644774585d, }, { 0.7291327797433109d, 0.5535158784320677d, }, },
    NullableValue = 
new System.Double[,] { { 0.5853252337221934d, 0.9096293514866569d, }, { 0.4184324613776559d, 0.23236791758532038d, }, },
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 19,
    Value = 
new System.Double[,] { { 0.4373671380888191d, 0.9750778051293744d, }, { 0.9445706583070134d, 0.27434786676038747d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 26,
    Value = 
new System.Double[,] { { 0.2612207395249678d, 0.7654285906991909d, }, { 0.7567278246572885d, 0.44957590059559505d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 7,
    Value = 
new System.Double[,] { { 0.9148793013425514d, 0.7544810903130351d, }, { 0.6715949295207256d, 0.28869871481807463d, }, },
    NullableValue = 
new System.Double[,] { { 0.24121745302245257d, 0.28739980653757635d, }, { 0.3702083503847473d, 0.662356152873569d, }, },
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 33,
    Value = 
new System.Double[,] { { 0.769470897343268d, 0.20594302038902967d, }, { 0.46976213403051614d, 0.6694515908710769d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 38,
    Value = 
new System.Double[,] { { 0.03166594802279321d, 0.8343903890914162d, }, { 0.0520686758129284d, 0.0633854306991769d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 14,
    Value = 
new System.Double[,] { { 0.31240045462131005d, 0.2585721756948075d, }, { 0.23051287613536164d, 0.1693867130608896d, }, },
    NullableValue = 
new System.Double[,] { { 0.5972635335866984d, 0.08670155067494412d, }, { 0.631713968956461d, 0.35836000310501537d, }, },
},
    NullableValue = 
new System.Double[,] { { 0.6174404840226752d, 0.8325955698354277d, }, { 0.9844124132802663d, 0.6340173135639469d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 42,
    Value = 
new System.Double[,] { { 0.10929827324014452d, 0.2580758711179021d, }, { 0.29603300228241614d, 0.46529055684972886d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 50,
    Value = 
new System.Double[,] { { 0.021901502214968893d, 0.8983922948735326d, }, { 0.4313909392530354d, 0.21036859634155747d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 15,
    Value = 
new System.Double[,] { { 0.6027399232103097d, 0.9326589468294652d, }, { 0.8952606426315325d, 0.011561584628569044d, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 54,
    Value = 
new System.Double[,] { { 0.9592443404971466d, 0.7848928292095227d, }, { 0.02837717661216088d, 0.4633508316553512d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 56,
    Value = 
new System.Double[,] { { 0.2622710772226007d, 0.08366621048956924d, }, { 0.8874629197304047d, 0.5661419709365936d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 23,
    Value = 
new System.Double[,] { { 0.1277491630861569d, 0.05820639103062275d, }, { 0.723837702698421d, 0.6999309959646064d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.5303230022434846d, 0.693903100107051d, }, { 0.25623831725297386d, 0.3429466474550332d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 65,
    Value = 
new System.Double[,] { { 0.007043585824265786d, 0.8042387931319814d, }, { 0.21285101906501036d, 0.3998631716777419d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.1931795501980852d, 0.04925979250954993d, }, { 0.17196413651997056d, 0.528882299536786d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 71,
    Value = 
new System.Double[,] { { 0.5954580916482166d, 0.19788397513167133d, }, { 0.3216846567824536d, 0.7999623878491368d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 32,
    Value = 
new System.Double[,] { { 0.29309708809589896d, 0.04765857022660569d, }, { 0.11341363325351317d, 0.8523800914317937d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.7892765936074252d, 0.5221976908947822d, }, { 0.6601486846527402d, 0.08263521065513757d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 72,
    Value = 
new System.Double[,] { { 0.17276290516330617d, 0.3000697188805326d, }, { 0.3695338793517856d, 0.2917172800653315d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 73,
    Value = 
new System.Double[,] { { 0.2109740791391459d, 0.22154194765243418d, }, { 0.3239098689569835d, 0.33054606515301543d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 41,
    Value = 
new System.Double[,] { { 0.5707981405520635d, 0.22185031445511016d, }, { 0.23764310345787198d, 0.9887933741650782d, }, },
    NullableValue = 
new System.Double[,] { { 0.3189567969881444d, 0.5331479194112066d, }, { 0.1473402746515743d, 0.29342012545184615d, }, },
},
    NullableValue = 
new System.Double[,] { { 0.9609778487120479d, 0.29981164810126226d, }, { 0.5139696571798585d, 0.24721807032637233d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 82,
    Value = 
new System.Double[,] { { 0.6069380081420078d, 0.23130500099752338d, }, { 0.6187488705319801d, 0.4752604798833404d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.44292624035907413d, 0.9212813727540119d, }, { 0.894599634165266d, 0.15045997833522562d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 83,
    Value = 
new System.Double[,] { { 0.21621259363706535d, 0.6713922625699041d, }, { 0.36193127075871623d, 0.6254998644149224d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 43,
    Value = 
new System.Double[,] { { 0.6699565807737705d, 0.8728799048515921d, }, { 0.41246007869931445d, 0.7093382053555632d, }, },
    NullableValue = 
new System.Double[,] { { 0.8509237049234941d, 0.4196238444860585d, }, { 0.19686263999077258d, 0.9283981297473629d, }, },
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 90,
    Value = 
new System.Double[,] { { 0.2820050520204699d, 0.829558033300822d, }, { 0.00920229776955439d, 0.8584999434078876d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 95,
    Value = 
new System.Double[,] { { 0.8592708031102775d, 0.8597795897436834d, }, { 0.9288472553940894d, 0.4557452525163963d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 47,
    Value = 
new System.Double[,] { { 0.6969961451463323d, 0.7359228671810146d, }, { 0.8157099884760665d, 0.6825303960520246d, }, },
    NullableValue = 
new System.Double[,] { { 0.9268018174143093d, 0.20884280261621269d, }, { 0.49144127436755236d, 0.5678861917808015d, }, },
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 104,
    Value = 
new System.Double[,] { { 0.4596264120281065d, 0.6874758812200732d, }, { 0.02215508723340731d, 0.8503132777260894d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.4024565568244979d, 0.8514187640514042d, }, { 0.3622433312579385d, 0.7871579774583051d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 109,
    Value = 
new System.Double[,] { { 0.8361901592498626d, 0.891553287055637d, }, { 0.7070512410273648d, 0.9831174068462861d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 55,
    Value = 
new System.Double[,] { { 0.27814515486520874d, 0.9150735390529636d, }, { 0.12213529636349396d, 0.6124955936876494d, }, },
    NullableValue = 
new System.Double[,] { { 0.5399006199798636d, 0.5072408551783881d, }, { 0.295349598028826d, 0.9589924673446467d, }, },
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 115,
    Value = 
new System.Double[,] { { 0.9581449478764237d, 0.30878157713543586d, }, { 0.673868555678372d, 0.974278223133896d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 123,
    Value = 
new System.Double[,] { { 0.48292458524697324d, 0.05383875839232355d, }, { 0.441433532185736d, 0.9834622350594029d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 62,
    Value = 
new System.Double[,] { { 0.7857653319448058d, 0.15248295089593777d, }, { 0.8053050167147608d, 0.07012968769531425d, }, },
    NullableValue = 
new System.Double[,] { { 0.8937258602389591d, 0.9889233359538461d, }, { 0.6668919646888729d, 0.9092050897422477d, }, },
},
    NullableValue = 
new System.Double[,] { { 0.573385269787151d, 0.6453304299574854d, }, { 0.9926742628408215d, 0.6952495472845641d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 131,
    Value = 
new System.Double[,] { { 0.2721564062122742d, 0.45521966393216307d, }, { 0.4229171394307354d, 0.45149825263993215d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 137,
    Value = 
new System.Double[,] { { 0.4777527495409386d, 0.8350598838872305d, }, { 0.75621703341994d, 0.7994222519729625d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 68,
    Value = 
new System.Double[,] { { 0.17555234820894117d, 0.011437836229019616d, }, { 0.008867451800565251d, 0.17194765238925636d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.3749063217111456d, 0.14245798607923954d, }, { 0.00107047007304939d, 0.11332241204689564d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 142,
    Value = 
new System.Double[,] { { 0.6190685491109204d, 0.9531757562858556d, }, { 0.9980747391358296d, 0.26090495269526015d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 148,
    Value = 
new System.Double[,] { { 0.8277430774400913d, 0.1592901126185272d, }, { 0.09945705647401548d, 0.03691575873008601d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 69,
    Value = 
new System.Double[,] { { 0.3767416857426681d, 0.5846435326716743d, }, { 0.8836699550158604d, 0.04689331429458876d, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 152,
    Value = 
new System.Double[,] { { 0.8205406402363788d, 0.931217087846886d, }, { 0.4812164909595421d, 0.5735998220949285d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.2906817486333265d, 0.15593135372510947d, }, { 0.32200376624311444d, 0.20536553851059713d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 158,
    Value = 
new System.Double[,] { { 0.46594409407484916d, 0.14075417164283632d, }, { 0.9328580026075097d, 0.19883304659547874d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 76,
    Value = 
new System.Double[,] { { 0.04301838110605449d, 0.7836879929027708d, }, { 0.4618008421434603d, 0.5851495126338052d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.6521766406472396d, 0.23438888909079802d, }, { 0.7144951207592367d, 0.2657837443518577d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 162,
    Value = 
new System.Double[,] { { 0.08187368681626761d, 0.9051604434466182d, }, { 0.7737928899019338d, 0.010783054577336415d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.6721582395844017d, 0.32240139111383825d, }, { 0.7937887713827865d, 0.4826121734282288d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 164,
    Value = 
new System.Double[,] { { 0.8833425794064216d, 0.9196169887964323d, }, { 0.8835563838062207d, 0.40272110540641903d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 85,
    Value = 
new System.Double[,] { { 0.0381637245385803d, 0.9716182853677289d, }, { 0.9603024660740993d, 0.2144550600816152d, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 167,
    Value = 
new System.Double[,] { { 0.7633338578214491d, 0.4939454743528702d, }, { 0.8388011893408756d, 0.4620450332749638d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.6781891113536855d, 0.4883657398436876d, }, { 0.5036320832397395d, 0.35428313125757427d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 169,
    Value = 
new System.Double[,] { { 0.3220060528694274d, 0.019657518136973806d, }, { 0.24285508006135892d, 0.49210092233498526d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 93,
    Value = 
new System.Double[,] { { 0.03234540455026813d, 0.8753777935847026d, }, { 0.7952063209753201d, 0.23362345018803676d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.7963833285116676d, 0.8037969025303704d, }, { 0.21587838609299415d, 0.7228400512386567d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 175,
    Value = 
new System.Double[,] { { 0.5736209333690155d, 0.8265052019359406d, }, { 0.3701343243946227d, 0.3051753344090953d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.10235987167397131d, 0.03233793820647046d, }, { 0.7750287099305433d, 0.05932319935652264d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 178,
    Value = 
new System.Double[,] { { 0.34858757046826694d, 0.9542470562534858d, }, { 0.20997698144580035d, 0.9625620446576165d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 94,
    Value = 
new System.Double[,] { { 0.7050073214466219d, 0.21776263018782194d, }, { 0.6339389969142196d, 0.6587481842806645d, }, },
    NullableValue = 
new System.Double[,] { { 0.26370578439009407d, 0.6064856075471974d, }, { 0.9102222339608053d, 0.9039446401114298d, }, },
},
    NullableValue = 
new System.Double[,] { { 0.4318857179142692d, 0.5585588103752626d, }, { 0.8788970900157146d, 0.86440386836325d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 184,
    Value = 
new System.Double[,] { { 0.38968962680381725d, 0.7750687197961755d, }, { 0.17909885739301878d, 0.38339392203740896d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.8795577757592369d, 0.998968805415645d, }, { 0.06608104745747045d, 0.7914400301653952d, }, },
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[,] { { 0.6174404840226752d, 0.8325955698354277d, }, { 0.9844124132802663d, 0.6340173135639469d, }, }));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[,] { { 0.5303230022434846d, 0.693903100107051d, }, { 0.25623831725297386d, 0.3429466474550332d, }, }));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[,] { { 0.1931795501980852d, 0.04925979250954993d, }, { 0.17196413651997056d, 0.528882299536786d, }, }));
                nullable = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[,] { { 0.7892765936074252d, 0.5221976908947822d, }, { 0.6601486846527402d, 0.08263521065513757d, }, }));
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
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
                parametr1.Value = 54;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
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
                parametr1.Value = 169;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 72;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[25],_testData[34], false);
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
                parametr1.Value = 175;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 175;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
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
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 162, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[28],_testData[34], false);
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
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 71, query1, 148, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
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
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 115, query1, 82, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[19],_testData[34], false);
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
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 90, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 83, query1, 131, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
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
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 82, query1, 90, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[17],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 167, query1, 104, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 6, query1, 137, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 6, 158))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 142, 158))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
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
                ((IDoubleMArraydouble_precisionMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 26);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleMArraydouble_precisionMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleMArraydouble_precisionMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 164);
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

