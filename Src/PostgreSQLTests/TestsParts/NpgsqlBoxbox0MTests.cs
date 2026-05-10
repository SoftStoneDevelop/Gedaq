

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
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.71960425837827d,right: 0.06058795744990886d,bottom: 0.48521533237200476d,left: 0.007649914445769901d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6804016878707739d,right: 0.433091632744231d,bottom: 0.05614477571316456d,left: 0.27515811322197004d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4718359679244749d,right: 0.9262211664588157d,bottom: 0.432960198098603d,left: 0.9259768465060622d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6201920621630935d,right: 0.8174118005222932d,bottom: 0.23935715602784557d,left: 0.7857712331524712d),
},
            new NpgsqlBoxbox0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7817360461589103d,right: 0.3593731850811891d,bottom: 0.6577833882368692d,left: 0.1744782351283437d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.389145212148463d,right: 0.42217218863205974d,bottom: 0.18439249673725422d,left: 0.38474668360908504d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.753569937397706d,right: 0.4411343171816473d,bottom: 0.5761928682358035d,left: 0.13205839265664887d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5074799550894837d,right: 0.3431608787263195d,bottom: 0.38243644977158986d,left: 0.23175847449763032d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8915632998179134d,right: 0.8130846815367144d,bottom: 0.1448104516047931d,left: 0.6146269591223181d),
},
            new NpgsqlBoxbox0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7765772779246278d,right: 0.9441873348102875d,bottom: 0.538892965144713d,left: 0.6223678427133458d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.41344403285301523d,right: 0.911805856180756d,bottom: 0.1812376556245342d,left: 0.3337945547745791d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5537279565626203d,right: 0.1571019859501237d,bottom: 0.3290564264018594d,left: 0.08687630552075931d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.4680907180117645d,right: 0.5248701360788034d,bottom: 0.41170275595121053d,left: 0.2723813875808556d),
},
            new NpgsqlBoxbox0M
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9817605446463097d,right: 0.22811597105417947d,bottom: 0.2301415518865476d,left: 0.07708119639621813d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7067912219846945d,right: 0.8883990419021321d,bottom: 0.58396483361048d,left: 0.009010962813020829d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5518568076931051d,right: 0.8531253077401008d,bottom: 0.33264480321641665d,left: 0.8199500025070654d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.13087393311193574d,right: 0.5834645402295168d,bottom: 0.11034068051491197d,left: 0.2051221017109054d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8297563497645511d,right: 0.6871576533644473d,bottom: 0.46204799797383334d,left: 0.6037422400726467d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6687738249324277d,right: 0.9755711500879183d,bottom: 0.1887966426755724d,left: 0.00690464448453687d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9160241954533777d,right: 0.4169951982609641d,bottom: 0.5896548234538168d,left: 0.06629325921351059d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5935278018600849d,right: 0.8973363544390407d,bottom: 0.09473639993231808d,left: 0.10344524590152215d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8616923717696424d,right: 0.6595578814872489d,bottom: 0.27592860439364963d,left: 0.09751303287884638d),
},
            new NpgsqlBoxbox0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.10439862760631191d,right: 0.5346353960838988d,bottom: 0.02525565732726498d,left: 0.19045575745081522d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.842767647485821d,right: 0.7786449805310278d,bottom: 0.1756952447691722d,left: 0.2730417888825031d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6412048859224725d,right: 0.8016815376034128d,bottom: 0.6212323388719873d,left: 0.29103456860627797d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7052425856703876d,right: 0.7442330835323966d,bottom: 0.188555036814802d,left: 0.6750950568112868d),
},
            new NpgsqlBoxbox0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.2086857746616857d,right: 0.6263845672925415d,bottom: 0.1667203117024454d,left: 0.3016411431685144d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.2588049376057905d,right: 0.864374857639874d,bottom: 0.2280742165890729d,left: 0.5364327972486845d),
},
            new NpgsqlBoxbox0M
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7351665316203374d,right: 0.9977167898696688d,bottom: 0.5480686150750426d,left: 0.13322899614885308d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.980548650367006d,right: 0.8298053359555474d,bottom: 0.2869970443408002d,left: 0.5002259909573221d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8363338082561937d,right: 0.5607159434418826d,bottom: 0.24526502303912556d,left: 0.4712532675528921d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7122300424384934d,right: 0.7385328791343282d,bottom: 0.5448699350805356d,left: 0.3402880284992075d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9490252171945047d,right: 0.8225934629492906d,bottom: 0.6788621283176602d,left: 0.592764650084147d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7777425017772229d,right: 0.8666097962882907d,bottom: 0.5645889928920955d,left: 0.84902838849713d),
},
            new NpgsqlBoxbox0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3796194727467421d,right: 0.6465129355934855d,bottom: 0.2887769335236414d,left: 0.5476741350511384d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8877567694676102d,right: 0.7656496266711886d,bottom: 0.7296233669764215d,left: 0.1571942450884969d),
},
            new NpgsqlBoxbox0M
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5470713784761592d,right: 0.27933911416329404d,bottom: 0.01251931756277691d,left: 0.16741703660797647d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9932706933640797d,right: 0.8331548837261731d,bottom: 0.923111597281644d,left: 0.6789277595018764d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7141258336097456d,right: 0.6262913988895883d,bottom: 0.1515635517759737d,left: 0.6254091475219893d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6217875436920579d,right: 0.9757365265770761d,bottom: 0.3922414838457542d,left: 0.3530868047297874d),
},
            new NpgsqlBoxbox0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7008776340592823d,right: 0.8412036859536833d,bottom: 0.08934287062473811d,left: 0.7208419585218855d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.27439560423477116d,right: 0.6850030102694898d,bottom: 0.26823810099780787d,left: 0.6365981175438743d),
},
            new NpgsqlBoxbox0M
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6781917459815846d,right: 0.32022388473503627d,bottom: 0.27854208293100813d,left: 0.032710241753283964d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.686118575243645d,right: 0.7314875528027852d,bottom: 0.08216126926116618d,left: 0.3317286186964854d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.953264492780127d,right: 0.7342865100176145d,bottom: 0.02921475427796938d,left: 0.6747489222852869d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.16094443898301158d,right: 0.6441000402608396d,bottom: 0.11699412464800063d,left: 0.3252064695784125d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.16046008944338963d,right: 0.3633102928272258d,bottom: 0.08497956772539472d,left: 0.35421720941214463d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9818244767014058d,right: 0.9921823429655773d,bottom: 0.5813298154245558d,left: 0.21926302049006274d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.923659350329688d,right: 0.9002489352611529d,bottom: 0.5292093845670369d,left: 0.8228881514882567d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8904927176574987d,right: 0.6481236464033251d,bottom: 0.7720704925013352d,left: 0.1951694422228053d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8029772504848876d,right: 0.4589647413799546d,bottom: 0.467636202284608d,left: 0.06018707489869568d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8467124722656834d,right: 0.34069378184378796d,bottom: 0.19395945320493835d,left: 0.30811235489169997d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.31503931895246895d,right: 0.944043146000717d,bottom: 0.29671222203736014d,left: 0.12743948247466208d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 98,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.451793256592418d,right: 0.23164759190220974d,bottom: 0.007418724652606623d,left: 0.014384081146429417d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6879410221261664d,right: 0.9435354308186766d,bottom: 0.11410471590586224d,left: 0.3981930821853561d),
},
            new NpgsqlBoxbox0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7157865424067934d,right: 0.7462561580603227d,bottom: 0.6365916282088879d,left: 0.22225274596876354d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9429765295465217d,right: 0.662534819456284d,bottom: 0.13785934542955658d,left: 0.15131471017485532d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7719903127705815d,right: 0.9101684611816513d,bottom: 0.7135885689126604d,left: 0.8836912096153948d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5756621248396707d,right: 0.564066042954357d,bottom: 0.34954003229993247d,left: 0.39629136437254275d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.4996024049630253d,right: 0.3790370940657334d,bottom: 0.4311739962614519d,left: 0.1734064636169853d),
},
            new NpgsqlBoxbox0M
{
    Id = 109,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8378975594597784d,right: 0.8140401661014847d,bottom: 0.20661180600599638d,left: 0.3566325260858132d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5168225627934043d,right: 0.6785919582534419d,bottom: 0.03749843229685712d,left: 0.35555068920352084d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9700042964572075d,right: 0.5237878982383313d,bottom: 0.9286334615322018d,left: 0.17963407206638493d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.585893959563815d,right: 0.5250831424320943d,bottom: 0.0600027667049251d,left: 0.02569603161292633d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5497443711151578d,right: 0.8428028413956311d,bottom: 0.05771710936666574d,left: 0.6113110049706778d),
},
            new NpgsqlBoxbox0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8766009894576257d,right: 0.7066469759490245d,bottom: 0.8181912547368486d,left: 0.09676835878489454d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.983820968629333d,right: 0.744693804844019d,bottom: 0.26609695734320304d,left: 0.0996201242585284d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.22670298622257823d,right: 0.9790021671427485d,bottom: 0.11924904741585862d,left: 0.3998803103037386d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6557474478631994d,right: 0.8662948542781557d,bottom: 0.023461007345273455d,left: 0.05979502073861798d),
},
            new NpgsqlBoxbox0M
{
    Id = 129,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.1200829532705826d,right: 0.511226536806566d,bottom: 0.04159793536433287d,left: 0.01370127377133079d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9131409976390302d,right: 0.645057955860774d,bottom: 0.797399817587524d,left: 0.15834772356888793d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.49238473156949136d,right: 0.9299061856544216d,bottom: 0.07690823598971708d,left: 0.016653974691110074d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8552272145181316d,right: 0.6390925034429109d,bottom: 0.511748648612956d,left: 0.5774790530803638d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9378773679598085d,right: 0.8893404972911908d,bottom: 0.44647855504079903d,left: 0.6556336162901847d),
},
            new NpgsqlBoxbox0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8956287090909212d,right: 0.5043088712994335d,bottom: 0.05105565908028098d,left: 0.4893073583059242d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5002990674631982d,right: 0.7508629738889756d,bottom: 0.18461037478901765d,left: 0.31784174657717246d),
},
            new NpgsqlBoxbox0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.14663935729450805d,right: 0.31365947117760673d,bottom: 0.046530439527514456d,left: 0.12767560505387276d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5705876278224044d,right: 0.436148233348725d,bottom: 0.06290794263288702d,left: 0.30015002688417713d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 160,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9010596975482659d,right: 0.8850457178904965d,bottom: 0.8093509722333301d,left: 0.5013071052710892d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5068586848218537d,right: 0.2239170611599841d,bottom: 0.19795676276602903d,left: 0.03679879348379089d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.4680907180117645d,right: 0.5248701360788034d,bottom: 0.41170275595121053d,left: 0.2723813875808556d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.8616923717696424d,right: 0.6595578814872489d,bottom: 0.27592860439364963d,left: 0.09751303287884638d)));
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
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.7052425856703876d,right: 0.7442330835323966d,bottom: 0.188555036814802d,left: 0.6750950568112868d)));
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
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
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[34], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[34], false);
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
                parametr1.Value = 85;
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[34], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(15));

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
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(33));

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
                        NpgsqlBoxbox0M.AssertModel(models[28],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[29],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[30],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[31],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[32],_testData[34], false);
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 117, query1, 27, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[34], false);
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 3, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
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
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[34], false);
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 83, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[34], false);
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatch(connection, 3, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[32],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 117, query1, 137, query2))
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[34], false);
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 3, query1, 36, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[25],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatch(connection, 67, query1, 88, query2))
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[34], false);
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatch(connection, 137, query1, 98, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatchAsync(connection, 85, 36))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

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
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[24],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[25],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatch(connection, 2, 109))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[28],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[29],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[30],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[31],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[32],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[34], false);
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
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 37);
                var models = await ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                NpgsqlBoxbox0M.AssertModel(models[0],_testData[10], false);
                NpgsqlBoxbox0M.AssertModel(models[1],_testData[11], false);
                NpgsqlBoxbox0M.AssertModel(models[2],_testData[12], false);
                NpgsqlBoxbox0M.AssertModel(models[3],_testData[13], false);
                NpgsqlBoxbox0M.AssertModel(models[4],_testData[14], false);
                NpgsqlBoxbox0M.AssertModel(models[5],_testData[15], false);
                NpgsqlBoxbox0M.AssertModel(models[6],_testData[16], false);
                NpgsqlBoxbox0M.AssertModel(models[7],_testData[17], false);
                NpgsqlBoxbox0M.AssertModel(models[8],_testData[18], false);
                NpgsqlBoxbox0M.AssertModel(models[9],_testData[19], false);
                NpgsqlBoxbox0M.AssertModel(models[10],_testData[20], false);
                NpgsqlBoxbox0M.AssertModel(models[11],_testData[21], false);
                NpgsqlBoxbox0M.AssertModel(models[12],_testData[22], false);
                NpgsqlBoxbox0M.AssertModel(models[13],_testData[23], false);
                NpgsqlBoxbox0M.AssertModel(models[14],_testData[24], false);
                NpgsqlBoxbox0M.AssertModel(models[15],_testData[25], false);
                NpgsqlBoxbox0M.AssertModel(models[16],_testData[26], false);
                NpgsqlBoxbox0M.AssertModel(models[17],_testData[27], false);
                NpgsqlBoxbox0M.AssertModel(models[18],_testData[28], false);
                NpgsqlBoxbox0M.AssertModel(models[19],_testData[29], false);
                NpgsqlBoxbox0M.AssertModel(models[20],_testData[30], false);
                NpgsqlBoxbox0M.AssertModel(models[21],_testData[31], false);
                NpgsqlBoxbox0M.AssertModel(models[22],_testData[32], false);
                NpgsqlBoxbox0M.AssertModel(models[23],_testData[33], false);
                NpgsqlBoxbox0M.AssertModel(models[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 3);
                var models =  ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(33));

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
                NpgsqlBoxbox0M.AssertModel(models[28],_testData[30], false);
                NpgsqlBoxbox0M.AssertModel(models[29],_testData[31], false);
                NpgsqlBoxbox0M.AssertModel(models[30],_testData[32], false);
                NpgsqlBoxbox0M.AssertModel(models[31],_testData[33], false);
                NpgsqlBoxbox0M.AssertModel(models[32],_testData[34], false);
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
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.71960425837827d,right: 0.06058795744990886d,bottom: 0.48521533237200476d,left: 0.007649914445769901d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6804016878707739d,right: 0.433091632744231d,bottom: 0.05614477571316456d,left: 0.27515811322197004d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4718359679244749d,right: 0.9262211664588157d,bottom: 0.432960198098603d,left: 0.9259768465060622d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6201920621630935d,right: 0.8174118005222932d,bottom: 0.23935715602784557d,left: 0.7857712331524712d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7817360461589103d,right: 0.3593731850811891d,bottom: 0.6577833882368692d,left: 0.1744782351283437d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.389145212148463d,right: 0.42217218863205974d,bottom: 0.18439249673725422d,left: 0.38474668360908504d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.753569937397706d,right: 0.4411343171816473d,bottom: 0.5761928682358035d,left: 0.13205839265664887d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5074799550894837d,right: 0.3431608787263195d,bottom: 0.38243644977158986d,left: 0.23175847449763032d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8915632998179134d,right: 0.8130846815367144d,bottom: 0.1448104516047931d,left: 0.6146269591223181d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7765772779246278d,right: 0.9441873348102875d,bottom: 0.538892965144713d,left: 0.6223678427133458d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.41344403285301523d,right: 0.911805856180756d,bottom: 0.1812376556245342d,left: 0.3337945547745791d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5537279565626203d,right: 0.1571019859501237d,bottom: 0.3290564264018594d,left: 0.08687630552075931d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4680907180117645d,right: 0.5248701360788034d,bottom: 0.41170275595121053d,left: 0.2723813875808556d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9817605446463097d,right: 0.22811597105417947d,bottom: 0.2301415518865476d,left: 0.07708119639621813d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7067912219846945d,right: 0.8883990419021321d,bottom: 0.58396483361048d,left: 0.009010962813020829d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5518568076931051d,right: 0.8531253077401008d,bottom: 0.33264480321641665d,left: 0.8199500025070654d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.13087393311193574d,right: 0.5834645402295168d,bottom: 0.11034068051491197d,left: 0.2051221017109054d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8297563497645511d,right: 0.6871576533644473d,bottom: 0.46204799797383334d,left: 0.6037422400726467d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6687738249324277d,right: 0.9755711500879183d,bottom: 0.1887966426755724d,left: 0.00690464448453687d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9160241954533777d,right: 0.4169951982609641d,bottom: 0.5896548234538168d,left: 0.06629325921351059d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5935278018600849d,right: 0.8973363544390407d,bottom: 0.09473639993231808d,left: 0.10344524590152215d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8616923717696424d,right: 0.6595578814872489d,bottom: 0.27592860439364963d,left: 0.09751303287884638d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.10439862760631191d,right: 0.5346353960838988d,bottom: 0.02525565732726498d,left: 0.19045575745081522d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.842767647485821d,right: 0.7786449805310278d,bottom: 0.1756952447691722d,left: 0.2730417888825031d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6412048859224725d,right: 0.8016815376034128d,bottom: 0.6212323388719873d,left: 0.29103456860627797d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7052425856703876d,right: 0.7442330835323966d,bottom: 0.188555036814802d,left: 0.6750950568112868d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2086857746616857d,right: 0.6263845672925415d,bottom: 0.1667203117024454d,left: 0.3016411431685144d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2588049376057905d,right: 0.864374857639874d,bottom: 0.2280742165890729d,left: 0.5364327972486845d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7351665316203374d,right: 0.9977167898696688d,bottom: 0.5480686150750426d,left: 0.13322899614885308d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.980548650367006d,right: 0.8298053359555474d,bottom: 0.2869970443408002d,left: 0.5002259909573221d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8363338082561937d,right: 0.5607159434418826d,bottom: 0.24526502303912556d,left: 0.4712532675528921d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7122300424384934d,right: 0.7385328791343282d,bottom: 0.5448699350805356d,left: 0.3402880284992075d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9490252171945047d,right: 0.8225934629492906d,bottom: 0.6788621283176602d,left: 0.592764650084147d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7777425017772229d,right: 0.8666097962882907d,bottom: 0.5645889928920955d,left: 0.84902838849713d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3796194727467421d,right: 0.6465129355934855d,bottom: 0.2887769335236414d,left: 0.5476741350511384d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8877567694676102d,right: 0.7656496266711886d,bottom: 0.7296233669764215d,left: 0.1571942450884969d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5470713784761592d,right: 0.27933911416329404d,bottom: 0.01251931756277691d,left: 0.16741703660797647d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9932706933640797d,right: 0.8331548837261731d,bottom: 0.923111597281644d,left: 0.6789277595018764d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7141258336097456d,right: 0.6262913988895883d,bottom: 0.1515635517759737d,left: 0.6254091475219893d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6217875436920579d,right: 0.9757365265770761d,bottom: 0.3922414838457542d,left: 0.3530868047297874d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7008776340592823d,right: 0.8412036859536833d,bottom: 0.08934287062473811d,left: 0.7208419585218855d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.27439560423477116d,right: 0.6850030102694898d,bottom: 0.26823810099780787d,left: 0.6365981175438743d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6781917459815846d,right: 0.32022388473503627d,bottom: 0.27854208293100813d,left: 0.032710241753283964d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.686118575243645d,right: 0.7314875528027852d,bottom: 0.08216126926116618d,left: 0.3317286186964854d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.953264492780127d,right: 0.7342865100176145d,bottom: 0.02921475427796938d,left: 0.6747489222852869d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.16094443898301158d,right: 0.6441000402608396d,bottom: 0.11699412464800063d,left: 0.3252064695784125d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.16046008944338963d,right: 0.3633102928272258d,bottom: 0.08497956772539472d,left: 0.35421720941214463d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9818244767014058d,right: 0.9921823429655773d,bottom: 0.5813298154245558d,left: 0.21926302049006274d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.923659350329688d,right: 0.9002489352611529d,bottom: 0.5292093845670369d,left: 0.8228881514882567d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8904927176574987d,right: 0.6481236464033251d,bottom: 0.7720704925013352d,left: 0.1951694422228053d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8029772504848876d,right: 0.4589647413799546d,bottom: 0.467636202284608d,left: 0.06018707489869568d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8467124722656834d,right: 0.34069378184378796d,bottom: 0.19395945320493835d,left: 0.30811235489169997d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.31503931895246895d,right: 0.944043146000717d,bottom: 0.29671222203736014d,left: 0.12743948247466208d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.451793256592418d,right: 0.23164759190220974d,bottom: 0.007418724652606623d,left: 0.014384081146429417d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6879410221261664d,right: 0.9435354308186766d,bottom: 0.11410471590586224d,left: 0.3981930821853561d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7157865424067934d,right: 0.7462561580603227d,bottom: 0.6365916282088879d,left: 0.22225274596876354d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9429765295465217d,right: 0.662534819456284d,bottom: 0.13785934542955658d,left: 0.15131471017485532d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7719903127705815d,right: 0.9101684611816513d,bottom: 0.7135885689126604d,left: 0.8836912096153948d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5756621248396707d,right: 0.564066042954357d,bottom: 0.34954003229993247d,left: 0.39629136437254275d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4996024049630253d,right: 0.3790370940657334d,bottom: 0.4311739962614519d,left: 0.1734064636169853d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8378975594597784d,right: 0.8140401661014847d,bottom: 0.20661180600599638d,left: 0.3566325260858132d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5168225627934043d,right: 0.6785919582534419d,bottom: 0.03749843229685712d,left: 0.35555068920352084d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9700042964572075d,right: 0.5237878982383313d,bottom: 0.9286334615322018d,left: 0.17963407206638493d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.585893959563815d,right: 0.5250831424320943d,bottom: 0.0600027667049251d,left: 0.02569603161292633d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5497443711151578d,right: 0.8428028413956311d,bottom: 0.05771710936666574d,left: 0.6113110049706778d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8766009894576257d,right: 0.7066469759490245d,bottom: 0.8181912547368486d,left: 0.09676835878489454d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.983820968629333d,right: 0.744693804844019d,bottom: 0.26609695734320304d,left: 0.0996201242585284d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.22670298622257823d,right: 0.9790021671427485d,bottom: 0.11924904741585862d,left: 0.3998803103037386d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6557474478631994d,right: 0.8662948542781557d,bottom: 0.023461007345273455d,left: 0.05979502073861798d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1200829532705826d,right: 0.511226536806566d,bottom: 0.04159793536433287d,left: 0.01370127377133079d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9131409976390302d,right: 0.645057955860774d,bottom: 0.797399817587524d,left: 0.15834772356888793d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49238473156949136d,right: 0.9299061856544216d,bottom: 0.07690823598971708d,left: 0.016653974691110074d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8552272145181316d,right: 0.6390925034429109d,bottom: 0.511748648612956d,left: 0.5774790530803638d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9378773679598085d,right: 0.8893404972911908d,bottom: 0.44647855504079903d,left: 0.6556336162901847d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8956287090909212d,right: 0.5043088712994335d,bottom: 0.05105565908028098d,left: 0.4893073583059242d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5002990674631982d,right: 0.7508629738889756d,bottom: 0.18461037478901765d,left: 0.31784174657717246d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.14663935729450805d,right: 0.31365947117760673d,bottom: 0.046530439527514456d,left: 0.12767560505387276d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5705876278224044d,right: 0.436148233348725d,bottom: 0.06290794263288702d,left: 0.30015002688417713d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9010596975482659d,right: 0.8850457178904965d,bottom: 0.8093509722333301d,left: 0.5013071052710892d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5068586848218537d,right: 0.2239170611599841d,bottom: 0.19795676276602903d,left: 0.03679879348379089d))));

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
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.71960425837827d,right: 0.06058795744990886d,bottom: 0.48521533237200476d,left: 0.007649914445769901d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6804016878707739d,right: 0.433091632744231d,bottom: 0.05614477571316456d,left: 0.27515811322197004d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4718359679244749d,right: 0.9262211664588157d,bottom: 0.432960198098603d,left: 0.9259768465060622d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6201920621630935d,right: 0.8174118005222932d,bottom: 0.23935715602784557d,left: 0.7857712331524712d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7817360461589103d,right: 0.3593731850811891d,bottom: 0.6577833882368692d,left: 0.1744782351283437d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.389145212148463d,right: 0.42217218863205974d,bottom: 0.18439249673725422d,left: 0.38474668360908504d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.753569937397706d,right: 0.4411343171816473d,bottom: 0.5761928682358035d,left: 0.13205839265664887d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5074799550894837d,right: 0.3431608787263195d,bottom: 0.38243644977158986d,left: 0.23175847449763032d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8915632998179134d,right: 0.8130846815367144d,bottom: 0.1448104516047931d,left: 0.6146269591223181d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7765772779246278d,right: 0.9441873348102875d,bottom: 0.538892965144713d,left: 0.6223678427133458d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.41344403285301523d,right: 0.911805856180756d,bottom: 0.1812376556245342d,left: 0.3337945547745791d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5537279565626203d,right: 0.1571019859501237d,bottom: 0.3290564264018594d,left: 0.08687630552075931d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4680907180117645d,right: 0.5248701360788034d,bottom: 0.41170275595121053d,left: 0.2723813875808556d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9817605446463097d,right: 0.22811597105417947d,bottom: 0.2301415518865476d,left: 0.07708119639621813d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7067912219846945d,right: 0.8883990419021321d,bottom: 0.58396483361048d,left: 0.009010962813020829d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5518568076931051d,right: 0.8531253077401008d,bottom: 0.33264480321641665d,left: 0.8199500025070654d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.13087393311193574d,right: 0.5834645402295168d,bottom: 0.11034068051491197d,left: 0.2051221017109054d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8297563497645511d,right: 0.6871576533644473d,bottom: 0.46204799797383334d,left: 0.6037422400726467d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6687738249324277d,right: 0.9755711500879183d,bottom: 0.1887966426755724d,left: 0.00690464448453687d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9160241954533777d,right: 0.4169951982609641d,bottom: 0.5896548234538168d,left: 0.06629325921351059d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5935278018600849d,right: 0.8973363544390407d,bottom: 0.09473639993231808d,left: 0.10344524590152215d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8616923717696424d,right: 0.6595578814872489d,bottom: 0.27592860439364963d,left: 0.09751303287884638d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.10439862760631191d,right: 0.5346353960838988d,bottom: 0.02525565732726498d,left: 0.19045575745081522d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.842767647485821d,right: 0.7786449805310278d,bottom: 0.1756952447691722d,left: 0.2730417888825031d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6412048859224725d,right: 0.8016815376034128d,bottom: 0.6212323388719873d,left: 0.29103456860627797d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7052425856703876d,right: 0.7442330835323966d,bottom: 0.188555036814802d,left: 0.6750950568112868d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2086857746616857d,right: 0.6263845672925415d,bottom: 0.1667203117024454d,left: 0.3016411431685144d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2588049376057905d,right: 0.864374857639874d,bottom: 0.2280742165890729d,left: 0.5364327972486845d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7351665316203374d,right: 0.9977167898696688d,bottom: 0.5480686150750426d,left: 0.13322899614885308d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.980548650367006d,right: 0.8298053359555474d,bottom: 0.2869970443408002d,left: 0.5002259909573221d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8363338082561937d,right: 0.5607159434418826d,bottom: 0.24526502303912556d,left: 0.4712532675528921d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7122300424384934d,right: 0.7385328791343282d,bottom: 0.5448699350805356d,left: 0.3402880284992075d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9490252171945047d,right: 0.8225934629492906d,bottom: 0.6788621283176602d,left: 0.592764650084147d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7777425017772229d,right: 0.8666097962882907d,bottom: 0.5645889928920955d,left: 0.84902838849713d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3796194727467421d,right: 0.6465129355934855d,bottom: 0.2887769335236414d,left: 0.5476741350511384d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8877567694676102d,right: 0.7656496266711886d,bottom: 0.7296233669764215d,left: 0.1571942450884969d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5470713784761592d,right: 0.27933911416329404d,bottom: 0.01251931756277691d,left: 0.16741703660797647d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9932706933640797d,right: 0.8331548837261731d,bottom: 0.923111597281644d,left: 0.6789277595018764d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7141258336097456d,right: 0.6262913988895883d,bottom: 0.1515635517759737d,left: 0.6254091475219893d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6217875436920579d,right: 0.9757365265770761d,bottom: 0.3922414838457542d,left: 0.3530868047297874d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7008776340592823d,right: 0.8412036859536833d,bottom: 0.08934287062473811d,left: 0.7208419585218855d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.27439560423477116d,right: 0.6850030102694898d,bottom: 0.26823810099780787d,left: 0.6365981175438743d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6781917459815846d,right: 0.32022388473503627d,bottom: 0.27854208293100813d,left: 0.032710241753283964d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.686118575243645d,right: 0.7314875528027852d,bottom: 0.08216126926116618d,left: 0.3317286186964854d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.953264492780127d,right: 0.7342865100176145d,bottom: 0.02921475427796938d,left: 0.6747489222852869d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.16094443898301158d,right: 0.6441000402608396d,bottom: 0.11699412464800063d,left: 0.3252064695784125d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.16046008944338963d,right: 0.3633102928272258d,bottom: 0.08497956772539472d,left: 0.35421720941214463d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9818244767014058d,right: 0.9921823429655773d,bottom: 0.5813298154245558d,left: 0.21926302049006274d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.923659350329688d,right: 0.9002489352611529d,bottom: 0.5292093845670369d,left: 0.8228881514882567d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8904927176574987d,right: 0.6481236464033251d,bottom: 0.7720704925013352d,left: 0.1951694422228053d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8029772504848876d,right: 0.4589647413799546d,bottom: 0.467636202284608d,left: 0.06018707489869568d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8467124722656834d,right: 0.34069378184378796d,bottom: 0.19395945320493835d,left: 0.30811235489169997d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.31503931895246895d,right: 0.944043146000717d,bottom: 0.29671222203736014d,left: 0.12743948247466208d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.451793256592418d,right: 0.23164759190220974d,bottom: 0.007418724652606623d,left: 0.014384081146429417d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6879410221261664d,right: 0.9435354308186766d,bottom: 0.11410471590586224d,left: 0.3981930821853561d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7157865424067934d,right: 0.7462561580603227d,bottom: 0.6365916282088879d,left: 0.22225274596876354d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9429765295465217d,right: 0.662534819456284d,bottom: 0.13785934542955658d,left: 0.15131471017485532d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7719903127705815d,right: 0.9101684611816513d,bottom: 0.7135885689126604d,left: 0.8836912096153948d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5756621248396707d,right: 0.564066042954357d,bottom: 0.34954003229993247d,left: 0.39629136437254275d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4996024049630253d,right: 0.3790370940657334d,bottom: 0.4311739962614519d,left: 0.1734064636169853d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8378975594597784d,right: 0.8140401661014847d,bottom: 0.20661180600599638d,left: 0.3566325260858132d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5168225627934043d,right: 0.6785919582534419d,bottom: 0.03749843229685712d,left: 0.35555068920352084d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9700042964572075d,right: 0.5237878982383313d,bottom: 0.9286334615322018d,left: 0.17963407206638493d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.585893959563815d,right: 0.5250831424320943d,bottom: 0.0600027667049251d,left: 0.02569603161292633d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5497443711151578d,right: 0.8428028413956311d,bottom: 0.05771710936666574d,left: 0.6113110049706778d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8766009894576257d,right: 0.7066469759490245d,bottom: 0.8181912547368486d,left: 0.09676835878489454d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.983820968629333d,right: 0.744693804844019d,bottom: 0.26609695734320304d,left: 0.0996201242585284d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.22670298622257823d,right: 0.9790021671427485d,bottom: 0.11924904741585862d,left: 0.3998803103037386d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6557474478631994d,right: 0.8662948542781557d,bottom: 0.023461007345273455d,left: 0.05979502073861798d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1200829532705826d,right: 0.511226536806566d,bottom: 0.04159793536433287d,left: 0.01370127377133079d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9131409976390302d,right: 0.645057955860774d,bottom: 0.797399817587524d,left: 0.15834772356888793d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49238473156949136d,right: 0.9299061856544216d,bottom: 0.07690823598971708d,left: 0.016653974691110074d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8552272145181316d,right: 0.6390925034429109d,bottom: 0.511748648612956d,left: 0.5774790530803638d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9378773679598085d,right: 0.8893404972911908d,bottom: 0.44647855504079903d,left: 0.6556336162901847d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8956287090909212d,right: 0.5043088712994335d,bottom: 0.05105565908028098d,left: 0.4893073583059242d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5002990674631982d,right: 0.7508629738889756d,bottom: 0.18461037478901765d,left: 0.31784174657717246d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.14663935729450805d,right: 0.31365947117760673d,bottom: 0.046530439527514456d,left: 0.12767560505387276d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5705876278224044d,right: 0.436148233348725d,bottom: 0.06290794263288702d,left: 0.30015002688417713d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9010596975482659d,right: 0.8850457178904965d,bottom: 0.8093509722333301d,left: 0.5013071052710892d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5068586848218537d,right: 0.2239170611599841d,bottom: 0.19795676276602903d,left: 0.03679879348379089d))));

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

