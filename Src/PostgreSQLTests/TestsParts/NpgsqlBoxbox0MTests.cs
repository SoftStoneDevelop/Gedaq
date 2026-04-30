

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
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8260156442289961d,right: 0.6638201052771755d,bottom: 0.2175061162434756d,left: 0.4045572031878881d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9313008924783396d,right: 0.9429761114815911d,bottom: 0.020320905251194232d,left: 0.7856771337556336d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7759873985527833d,right: 0.9302744236837578d,bottom: 0.43874030311570233d,left: 0.5040549687277095d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9883573067003862d,right: 0.23589930958130456d,bottom: 0.0948269690292386d,left: 0.04852843959490083d),
},
            new NpgsqlBoxbox0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.25228158837991277d,right: 0.8898833534913694d,bottom: 0.16851707119658366d,left: 0.5144908190002543d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8259442140928219d,right: 0.9082926998593606d,bottom: 0.569677971534984d,left: 0.7957496064640015d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.38369471406610567d,right: 0.2798252872294684d,bottom: 0.013481933136042068d,left: 0.18133790925771665d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9525619751415031d,right: 0.7699679386376009d,bottom: 0.6296484103054768d,left: 0.25890977242921065d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5410711609930932d,right: 0.7499026515653003d,bottom: 0.2451862969362799d,left: 0.2776134308229513d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7400656003070235d,right: 0.6674784753147327d,bottom: 0.16375170550103424d,left: 0.057663412769149436d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.4652800231474059d,right: 0.5446188186770304d,bottom: 0.08115450939189472d,left: 0.30026109469659323d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8240375176167929d,right: 0.7123381598971154d,bottom: 0.13178579284425318d,left: 0.010463396161633054d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3724958398647412d,right: 0.9153265912628027d,bottom: 0.15193406000807574d,left: 0.35947304593639273d),
},
            new NpgsqlBoxbox0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4754718633827486d,right: 0.7032190639822545d,bottom: 0.2732989839853267d,left: 0.4955447126933096d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5243587916128226d,right: 0.32730114566139723d,bottom: 0.42320851376949953d,left: 0.2352284287354185d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.49943312016532393d,right: 0.8948055146120057d,bottom: 0.12740691450177444d,left: 0.4654440943620026d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3916973235674811d,right: 0.3498328340230874d,bottom: 0.3711837353898326d,left: 0.13706962255801525d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6882721595967312d,right: 0.49167140533688536d,bottom: 0.03915822917407774d,left: 0.20044559367078107d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8797059839102734d,right: 0.7654312997714272d,bottom: 0.3661896299072307d,left: 0.654802215374508d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6938478485466048d,right: 0.9557859810974698d,bottom: 0.6147549087221028d,left: 0.2656068318196113d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.19369995060205492d,right: 0.6687953980960253d,bottom: 0.03524272007435614d,left: 0.2413241020816198d),
},
            new NpgsqlBoxbox0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8058166052543466d,right: 0.13669629178625387d,bottom: 0.5981713049732045d,left: 0.0072191124390723616d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.21148123886414227d,right: 0.8577533622880521d,bottom: 0.166071620446551d,left: 0.4238469740886561d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5959495888092323d,right: 0.5262856785069876d,bottom: 0.5822746742110531d,left: 0.460314103933667d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9319963990226421d,right: 0.34119761320998965d,bottom: 0.537436916558108d,left: 0.10722942125151735d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5591291804973452d,right: 0.8870978333270669d,bottom: 0.14904518625745344d,left: 0.758879529101957d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8521678136740063d,right: 0.9386744120187684d,bottom: 0.224253300020416d,left: 0.13874026404212825d),
},
            new NpgsqlBoxbox0M
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.34075651123401496d,right: 0.9302158415828184d,bottom: 0.07932130344725674d,left: 0.5569670785427472d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6828001071716024d,right: 0.9853770976803025d,bottom: 0.09066593296633763d,left: 0.8460158672703024d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9031161636961258d,right: 0.9647569895911017d,bottom: 0.44019493812387855d,left: 0.646082878096639d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.4886120697890467d,right: 0.7358251568019697d,bottom: 0.3539626882561562d,left: 0.2588019629608024d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.910780656905107d,right: 0.9205831588558979d,bottom: 0.7076905276303781d,left: 0.5579809159163465d),
},
            new NpgsqlBoxbox0M
{
    Id = 97,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6414248817314788d,right: 0.9112358210936006d,bottom: 0.09577721811119877d,left: 0.6830887054158233d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.4519599902172965d,right: 0.7709155580723119d,bottom: 0.10300187478749645d,left: 0.008233409883951825d),
},
            new NpgsqlBoxbox0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9407302233873093d,right: 0.8118741969352243d,bottom: 0.058110066418673556d,left: 0.10971515448669666d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9410649533585878d,right: 0.8886011278160969d,bottom: 0.620515837014587d,left: 0.027476616217733674d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9154884619503753d,right: 0.8064140259848415d,bottom: 0.6817974067649325d,left: 0.280087123282851d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.1434090988275839d,right: 0.4144903713842921d,bottom: 0.04065299373286668d,left: 0.40130789487607266d),
},
            new NpgsqlBoxbox0M
{
    Id = 106,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.18411987432728127d,right: 0.7139551438330849d,bottom: 0.13990528663481316d,left: 0.3502771584667629d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7956828820020679d,right: 0.8563892338128016d,bottom: 0.35167326895478435d,left: 0.540508322646028d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.34408742529673064d,right: 0.1470235956360748d,bottom: 0.07162154772211604d,left: 0.09768211135420402d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8180719438012426d,right: 0.6683624430956123d,bottom: 0.6122924842223708d,left: 0.41492918006851076d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.31015793551664805d,right: 0.22210790660566848d,bottom: 0.03923359991107955d,left: 0.07809935667801671d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6465515464429382d,right: 0.9090402428976232d,bottom: 0.06381588094518331d,left: 0.5244657414116778d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5050784312726871d,right: 0.9425368672926531d,bottom: 0.1641981169670751d,left: 0.9404222461215398d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8485290982807308d,right: 0.5970051740284635d,bottom: 0.027713984849295437d,left: 0.26822534751045624d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.48925695710030803d,right: 0.25127679056781504d,bottom: 0.07805327100228654d,left: 0.09533070528966925d),
},
            new NpgsqlBoxbox0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.44018422454227923d,right: 0.6098771255749742d,bottom: 0.0886984821953537d,left: 0.4629014259880001d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 116,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.43141292488375726d,right: 0.21112567554684591d,bottom: 0.21686039150428682d,left: 0.008248790098095649d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.15480390576260872d,right: 0.7386332317355705d,bottom: 0.11008744878129073d,left: 0.5003918907769729d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.35806642621711904d,right: 0.7588361346979441d,bottom: 0.34956330573845784d,left: 0.6854441196012687d),
},
            new NpgsqlBoxbox0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.847795898755595d,right: 0.8725758334143965d,bottom: 0.5960140153725635d,left: 0.29807979105872673d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7443902057913703d,right: 0.5056604806709228d,bottom: 0.09009015747653115d,left: 0.397026652225978d),
},
            new NpgsqlBoxbox0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.29224465701136837d,right: 0.9553738962925662d,bottom: 0.282873866251087d,left: 0.46832117575240806d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.46866065478596586d,right: 0.867535944844262d,bottom: 0.4270226352534535d,left: 0.5282033853319491d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4809132221247615d,right: 0.32861675029899096d,bottom: 0.2971655597033094d,left: 0.31352341793361305d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.38674548134434794d,right: 0.19380084953109944d,bottom: 0.3843356712250241d,left: 0.005656489396313136d),
},
            new NpgsqlBoxbox0M
{
    Id = 129,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3655131499841908d,right: 0.5611486035145099d,bottom: 0.34354927592139717d,left: 0.22280427357340227d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9625597045535438d,right: 0.5969554099016733d,bottom: 0.8539979917750046d,left: 0.1909591329624326d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6843189791816869d,right: 0.24635178259092416d,bottom: 0.2973789642641157d,left: 0.1552508460548898d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6097509528684056d,right: 0.6829488499401956d,bottom: 0.5387034808115727d,left: 0.16355948968468526d),
},
            new NpgsqlBoxbox0M
{
    Id = 139,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8025884553645423d,right: 0.6263806426737002d,bottom: 0.7094820394728366d,left: 0.14201121424412722d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9208732738595511d,right: 0.7816911909723121d,bottom: 0.5171929037616909d,left: 0.24359288361360298d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7803063671655323d,right: 0.9169511660515042d,bottom: 0.108472339014409d,left: 0.17670272716596125d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.25771953057854313d,right: 0.7041146454302546d,bottom: 0.022570783659226157d,left: 0.2464031819212278d),
},
            new NpgsqlBoxbox0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6941087261053702d,right: 0.6882906619157129d,bottom: 0.13588244521348092d,left: 0.4723645656981247d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4657704456491588d,right: 0.9325350534535052d,bottom: 0.3857479638849578d,left: 0.5551281454460018d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8380046006546973d,right: 0.7758221818417d,bottom: 0.25364274582550317d,left: 0.028293618898457495d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6165049057504911d,right: 0.4634131627986733d,bottom: 0.13412540241053983d,left: 0.4174791892402301d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 162,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6362382210676039d,right: 0.38135864207461745d,bottom: 0.40956055709262107d,left: 0.20528643300561877d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 168,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6616350673694746d,right: 0.6050783330764957d,bottom: 0.4536968608032421d,left: 0.26956893085948375d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8886956495244315d,right: 0.6234454919346375d,bottom: 0.8107560459867127d,left: 0.19856550003091433d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5970089552199271d,right: 0.8387574974321641d,bottom: 0.018095650989890077d,left: 0.5804011084733594d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6270124287302841d,right: 0.7333570696594455d,bottom: 0.4857936769046889d,left: 0.09658421581260024d),
},
            new NpgsqlBoxbox0M
{
    Id = 174,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5824533764196562d,right: 0.40808753278828724d,bottom: 0.3735470595106538d,left: 0.16920479091688678d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7601612616586043d,right: 0.3090962519951602d,bottom: 0.6690401827388736d,left: 0.06737051072569777d),
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.3724958398647412d,right: 0.9153265912628027d,bottom: 0.15193406000807574d,left: 0.35947304593639273d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.19369995060205492d,right: 0.6687953980960253d,bottom: 0.03524272007435614d,left: 0.2413241020816198d)));
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
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
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[34], false);
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
                parametr1.Value = 72;
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
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[34], false);
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
                parametr1.Value = 129;
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr2.Value = 115;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[34], false);
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
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 76, query1, 64, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
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
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[34], false);
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 113, query1, 97, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
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
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 84, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[34], false);
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatch(connection, 60, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 114, query1, 95, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 97, query1, 76, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
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
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatch(connection, 119, query1, 114, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[34], false);
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatch(connection, 76, query1, 119, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
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
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatchAsync(connection, 95, 129))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatch(connection, 115, 47))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[8], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[9], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[24],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[25],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[26],_testData[34], false);
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
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 119);
                var models = await ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
NpgsqlBoxbox0M.AssertModel(models[0],_testData[26], false);NpgsqlBoxbox0M.AssertModel(models[1],_testData[27], false);NpgsqlBoxbox0M.AssertModel(models[2],_testData[28], false);NpgsqlBoxbox0M.AssertModel(models[3],_testData[29], false);NpgsqlBoxbox0M.AssertModel(models[4],_testData[30], false);NpgsqlBoxbox0M.AssertModel(models[5],_testData[31], false);NpgsqlBoxbox0M.AssertModel(models[6],_testData[32], false);NpgsqlBoxbox0M.AssertModel(models[7],_testData[33], false);NpgsqlBoxbox0M.AssertModel(models[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 133);
                var models =  ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
NpgsqlBoxbox0M.AssertModel(models[0],_testData[29], false);NpgsqlBoxbox0M.AssertModel(models[1],_testData[30], false);NpgsqlBoxbox0M.AssertModel(models[2],_testData[31], false);NpgsqlBoxbox0M.AssertModel(models[3],_testData[32], false);NpgsqlBoxbox0M.AssertModel(models[4],_testData[33], false);NpgsqlBoxbox0M.AssertModel(models[5],_testData[34], false);
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
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8260156442289961d,right: 0.6638201052771755d,bottom: 0.2175061162434756d,left: 0.4045572031878881d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9313008924783396d,right: 0.9429761114815911d,bottom: 0.020320905251194232d,left: 0.7856771337556336d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7759873985527833d,right: 0.9302744236837578d,bottom: 0.43874030311570233d,left: 0.5040549687277095d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9883573067003862d,right: 0.23589930958130456d,bottom: 0.0948269690292386d,left: 0.04852843959490083d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.25228158837991277d,right: 0.8898833534913694d,bottom: 0.16851707119658366d,left: 0.5144908190002543d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8259442140928219d,right: 0.9082926998593606d,bottom: 0.569677971534984d,left: 0.7957496064640015d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.38369471406610567d,right: 0.2798252872294684d,bottom: 0.013481933136042068d,left: 0.18133790925771665d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9525619751415031d,right: 0.7699679386376009d,bottom: 0.6296484103054768d,left: 0.25890977242921065d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5410711609930932d,right: 0.7499026515653003d,bottom: 0.2451862969362799d,left: 0.2776134308229513d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7400656003070235d,right: 0.6674784753147327d,bottom: 0.16375170550103424d,left: 0.057663412769149436d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4652800231474059d,right: 0.5446188186770304d,bottom: 0.08115450939189472d,left: 0.30026109469659323d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8240375176167929d,right: 0.7123381598971154d,bottom: 0.13178579284425318d,left: 0.010463396161633054d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3724958398647412d,right: 0.9153265912628027d,bottom: 0.15193406000807574d,left: 0.35947304593639273d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4754718633827486d,right: 0.7032190639822545d,bottom: 0.2732989839853267d,left: 0.4955447126933096d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5243587916128226d,right: 0.32730114566139723d,bottom: 0.42320851376949953d,left: 0.2352284287354185d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49943312016532393d,right: 0.8948055146120057d,bottom: 0.12740691450177444d,left: 0.4654440943620026d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3916973235674811d,right: 0.3498328340230874d,bottom: 0.3711837353898326d,left: 0.13706962255801525d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6882721595967312d,right: 0.49167140533688536d,bottom: 0.03915822917407774d,left: 0.20044559367078107d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8797059839102734d,right: 0.7654312997714272d,bottom: 0.3661896299072307d,left: 0.654802215374508d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6938478485466048d,right: 0.9557859810974698d,bottom: 0.6147549087221028d,left: 0.2656068318196113d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.19369995060205492d,right: 0.6687953980960253d,bottom: 0.03524272007435614d,left: 0.2413241020816198d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8058166052543466d,right: 0.13669629178625387d,bottom: 0.5981713049732045d,left: 0.0072191124390723616d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.21148123886414227d,right: 0.8577533622880521d,bottom: 0.166071620446551d,left: 0.4238469740886561d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5959495888092323d,right: 0.5262856785069876d,bottom: 0.5822746742110531d,left: 0.460314103933667d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9319963990226421d,right: 0.34119761320998965d,bottom: 0.537436916558108d,left: 0.10722942125151735d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5591291804973452d,right: 0.8870978333270669d,bottom: 0.14904518625745344d,left: 0.758879529101957d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8521678136740063d,right: 0.9386744120187684d,bottom: 0.224253300020416d,left: 0.13874026404212825d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.34075651123401496d,right: 0.9302158415828184d,bottom: 0.07932130344725674d,left: 0.5569670785427472d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6828001071716024d,right: 0.9853770976803025d,bottom: 0.09066593296633763d,left: 0.8460158672703024d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9031161636961258d,right: 0.9647569895911017d,bottom: 0.44019493812387855d,left: 0.646082878096639d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4886120697890467d,right: 0.7358251568019697d,bottom: 0.3539626882561562d,left: 0.2588019629608024d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.910780656905107d,right: 0.9205831588558979d,bottom: 0.7076905276303781d,left: 0.5579809159163465d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6414248817314788d,right: 0.9112358210936006d,bottom: 0.09577721811119877d,left: 0.6830887054158233d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4519599902172965d,right: 0.7709155580723119d,bottom: 0.10300187478749645d,left: 0.008233409883951825d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9407302233873093d,right: 0.8118741969352243d,bottom: 0.058110066418673556d,left: 0.10971515448669666d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9410649533585878d,right: 0.8886011278160969d,bottom: 0.620515837014587d,left: 0.027476616217733674d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9154884619503753d,right: 0.8064140259848415d,bottom: 0.6817974067649325d,left: 0.280087123282851d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1434090988275839d,right: 0.4144903713842921d,bottom: 0.04065299373286668d,left: 0.40130789487607266d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.18411987432728127d,right: 0.7139551438330849d,bottom: 0.13990528663481316d,left: 0.3502771584667629d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7956828820020679d,right: 0.8563892338128016d,bottom: 0.35167326895478435d,left: 0.540508322646028d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.34408742529673064d,right: 0.1470235956360748d,bottom: 0.07162154772211604d,left: 0.09768211135420402d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8180719438012426d,right: 0.6683624430956123d,bottom: 0.6122924842223708d,left: 0.41492918006851076d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.31015793551664805d,right: 0.22210790660566848d,bottom: 0.03923359991107955d,left: 0.07809935667801671d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6465515464429382d,right: 0.9090402428976232d,bottom: 0.06381588094518331d,left: 0.5244657414116778d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5050784312726871d,right: 0.9425368672926531d,bottom: 0.1641981169670751d,left: 0.9404222461215398d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8485290982807308d,right: 0.5970051740284635d,bottom: 0.027713984849295437d,left: 0.26822534751045624d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.48925695710030803d,right: 0.25127679056781504d,bottom: 0.07805327100228654d,left: 0.09533070528966925d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.44018422454227923d,right: 0.6098771255749742d,bottom: 0.0886984821953537d,left: 0.4629014259880001d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.43141292488375726d,right: 0.21112567554684591d,bottom: 0.21686039150428682d,left: 0.008248790098095649d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.15480390576260872d,right: 0.7386332317355705d,bottom: 0.11008744878129073d,left: 0.5003918907769729d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.35806642621711904d,right: 0.7588361346979441d,bottom: 0.34956330573845784d,left: 0.6854441196012687d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.847795898755595d,right: 0.8725758334143965d,bottom: 0.5960140153725635d,left: 0.29807979105872673d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7443902057913703d,right: 0.5056604806709228d,bottom: 0.09009015747653115d,left: 0.397026652225978d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.29224465701136837d,right: 0.9553738962925662d,bottom: 0.282873866251087d,left: 0.46832117575240806d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46866065478596586d,right: 0.867535944844262d,bottom: 0.4270226352534535d,left: 0.5282033853319491d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4809132221247615d,right: 0.32861675029899096d,bottom: 0.2971655597033094d,left: 0.31352341793361305d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.38674548134434794d,right: 0.19380084953109944d,bottom: 0.3843356712250241d,left: 0.005656489396313136d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3655131499841908d,right: 0.5611486035145099d,bottom: 0.34354927592139717d,left: 0.22280427357340227d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9625597045535438d,right: 0.5969554099016733d,bottom: 0.8539979917750046d,left: 0.1909591329624326d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6843189791816869d,right: 0.24635178259092416d,bottom: 0.2973789642641157d,left: 0.1552508460548898d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6097509528684056d,right: 0.6829488499401956d,bottom: 0.5387034808115727d,left: 0.16355948968468526d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8025884553645423d,right: 0.6263806426737002d,bottom: 0.7094820394728366d,left: 0.14201121424412722d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9208732738595511d,right: 0.7816911909723121d,bottom: 0.5171929037616909d,left: 0.24359288361360298d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7803063671655323d,right: 0.9169511660515042d,bottom: 0.108472339014409d,left: 0.17670272716596125d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.25771953057854313d,right: 0.7041146454302546d,bottom: 0.022570783659226157d,left: 0.2464031819212278d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6941087261053702d,right: 0.6882906619157129d,bottom: 0.13588244521348092d,left: 0.4723645656981247d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4657704456491588d,right: 0.9325350534535052d,bottom: 0.3857479638849578d,left: 0.5551281454460018d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8380046006546973d,right: 0.7758221818417d,bottom: 0.25364274582550317d,left: 0.028293618898457495d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6165049057504911d,right: 0.4634131627986733d,bottom: 0.13412540241053983d,left: 0.4174791892402301d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6362382210676039d,right: 0.38135864207461745d,bottom: 0.40956055709262107d,left: 0.20528643300561877d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6616350673694746d,right: 0.6050783330764957d,bottom: 0.4536968608032421d,left: 0.26956893085948375d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8886956495244315d,right: 0.6234454919346375d,bottom: 0.8107560459867127d,left: 0.19856550003091433d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5970089552199271d,right: 0.8387574974321641d,bottom: 0.018095650989890077d,left: 0.5804011084733594d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6270124287302841d,right: 0.7333570696594455d,bottom: 0.4857936769046889d,left: 0.09658421581260024d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5824533764196562d,right: 0.40808753278828724d,bottom: 0.3735470595106538d,left: 0.16920479091688678d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7601612616586043d,right: 0.3090962519951602d,bottom: 0.6690401827388736d,left: 0.06737051072569777d))));

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
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8260156442289961d,right: 0.6638201052771755d,bottom: 0.2175061162434756d,left: 0.4045572031878881d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9313008924783396d,right: 0.9429761114815911d,bottom: 0.020320905251194232d,left: 0.7856771337556336d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7759873985527833d,right: 0.9302744236837578d,bottom: 0.43874030311570233d,left: 0.5040549687277095d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9883573067003862d,right: 0.23589930958130456d,bottom: 0.0948269690292386d,left: 0.04852843959490083d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.25228158837991277d,right: 0.8898833534913694d,bottom: 0.16851707119658366d,left: 0.5144908190002543d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8259442140928219d,right: 0.9082926998593606d,bottom: 0.569677971534984d,left: 0.7957496064640015d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.38369471406610567d,right: 0.2798252872294684d,bottom: 0.013481933136042068d,left: 0.18133790925771665d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9525619751415031d,right: 0.7699679386376009d,bottom: 0.6296484103054768d,left: 0.25890977242921065d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5410711609930932d,right: 0.7499026515653003d,bottom: 0.2451862969362799d,left: 0.2776134308229513d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7400656003070235d,right: 0.6674784753147327d,bottom: 0.16375170550103424d,left: 0.057663412769149436d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4652800231474059d,right: 0.5446188186770304d,bottom: 0.08115450939189472d,left: 0.30026109469659323d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8240375176167929d,right: 0.7123381598971154d,bottom: 0.13178579284425318d,left: 0.010463396161633054d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3724958398647412d,right: 0.9153265912628027d,bottom: 0.15193406000807574d,left: 0.35947304593639273d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4754718633827486d,right: 0.7032190639822545d,bottom: 0.2732989839853267d,left: 0.4955447126933096d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5243587916128226d,right: 0.32730114566139723d,bottom: 0.42320851376949953d,left: 0.2352284287354185d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49943312016532393d,right: 0.8948055146120057d,bottom: 0.12740691450177444d,left: 0.4654440943620026d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3916973235674811d,right: 0.3498328340230874d,bottom: 0.3711837353898326d,left: 0.13706962255801525d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6882721595967312d,right: 0.49167140533688536d,bottom: 0.03915822917407774d,left: 0.20044559367078107d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8797059839102734d,right: 0.7654312997714272d,bottom: 0.3661896299072307d,left: 0.654802215374508d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6938478485466048d,right: 0.9557859810974698d,bottom: 0.6147549087221028d,left: 0.2656068318196113d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.19369995060205492d,right: 0.6687953980960253d,bottom: 0.03524272007435614d,left: 0.2413241020816198d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8058166052543466d,right: 0.13669629178625387d,bottom: 0.5981713049732045d,left: 0.0072191124390723616d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.21148123886414227d,right: 0.8577533622880521d,bottom: 0.166071620446551d,left: 0.4238469740886561d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5959495888092323d,right: 0.5262856785069876d,bottom: 0.5822746742110531d,left: 0.460314103933667d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9319963990226421d,right: 0.34119761320998965d,bottom: 0.537436916558108d,left: 0.10722942125151735d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5591291804973452d,right: 0.8870978333270669d,bottom: 0.14904518625745344d,left: 0.758879529101957d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8521678136740063d,right: 0.9386744120187684d,bottom: 0.224253300020416d,left: 0.13874026404212825d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.34075651123401496d,right: 0.9302158415828184d,bottom: 0.07932130344725674d,left: 0.5569670785427472d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6828001071716024d,right: 0.9853770976803025d,bottom: 0.09066593296633763d,left: 0.8460158672703024d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9031161636961258d,right: 0.9647569895911017d,bottom: 0.44019493812387855d,left: 0.646082878096639d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4886120697890467d,right: 0.7358251568019697d,bottom: 0.3539626882561562d,left: 0.2588019629608024d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.910780656905107d,right: 0.9205831588558979d,bottom: 0.7076905276303781d,left: 0.5579809159163465d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6414248817314788d,right: 0.9112358210936006d,bottom: 0.09577721811119877d,left: 0.6830887054158233d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4519599902172965d,right: 0.7709155580723119d,bottom: 0.10300187478749645d,left: 0.008233409883951825d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9407302233873093d,right: 0.8118741969352243d,bottom: 0.058110066418673556d,left: 0.10971515448669666d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9410649533585878d,right: 0.8886011278160969d,bottom: 0.620515837014587d,left: 0.027476616217733674d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9154884619503753d,right: 0.8064140259848415d,bottom: 0.6817974067649325d,left: 0.280087123282851d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1434090988275839d,right: 0.4144903713842921d,bottom: 0.04065299373286668d,left: 0.40130789487607266d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.18411987432728127d,right: 0.7139551438330849d,bottom: 0.13990528663481316d,left: 0.3502771584667629d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7956828820020679d,right: 0.8563892338128016d,bottom: 0.35167326895478435d,left: 0.540508322646028d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.34408742529673064d,right: 0.1470235956360748d,bottom: 0.07162154772211604d,left: 0.09768211135420402d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8180719438012426d,right: 0.6683624430956123d,bottom: 0.6122924842223708d,left: 0.41492918006851076d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.31015793551664805d,right: 0.22210790660566848d,bottom: 0.03923359991107955d,left: 0.07809935667801671d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6465515464429382d,right: 0.9090402428976232d,bottom: 0.06381588094518331d,left: 0.5244657414116778d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5050784312726871d,right: 0.9425368672926531d,bottom: 0.1641981169670751d,left: 0.9404222461215398d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8485290982807308d,right: 0.5970051740284635d,bottom: 0.027713984849295437d,left: 0.26822534751045624d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.48925695710030803d,right: 0.25127679056781504d,bottom: 0.07805327100228654d,left: 0.09533070528966925d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.44018422454227923d,right: 0.6098771255749742d,bottom: 0.0886984821953537d,left: 0.4629014259880001d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.43141292488375726d,right: 0.21112567554684591d,bottom: 0.21686039150428682d,left: 0.008248790098095649d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.15480390576260872d,right: 0.7386332317355705d,bottom: 0.11008744878129073d,left: 0.5003918907769729d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.35806642621711904d,right: 0.7588361346979441d,bottom: 0.34956330573845784d,left: 0.6854441196012687d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.847795898755595d,right: 0.8725758334143965d,bottom: 0.5960140153725635d,left: 0.29807979105872673d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7443902057913703d,right: 0.5056604806709228d,bottom: 0.09009015747653115d,left: 0.397026652225978d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.29224465701136837d,right: 0.9553738962925662d,bottom: 0.282873866251087d,left: 0.46832117575240806d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46866065478596586d,right: 0.867535944844262d,bottom: 0.4270226352534535d,left: 0.5282033853319491d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4809132221247615d,right: 0.32861675029899096d,bottom: 0.2971655597033094d,left: 0.31352341793361305d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.38674548134434794d,right: 0.19380084953109944d,bottom: 0.3843356712250241d,left: 0.005656489396313136d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3655131499841908d,right: 0.5611486035145099d,bottom: 0.34354927592139717d,left: 0.22280427357340227d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9625597045535438d,right: 0.5969554099016733d,bottom: 0.8539979917750046d,left: 0.1909591329624326d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6843189791816869d,right: 0.24635178259092416d,bottom: 0.2973789642641157d,left: 0.1552508460548898d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6097509528684056d,right: 0.6829488499401956d,bottom: 0.5387034808115727d,left: 0.16355948968468526d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8025884553645423d,right: 0.6263806426737002d,bottom: 0.7094820394728366d,left: 0.14201121424412722d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9208732738595511d,right: 0.7816911909723121d,bottom: 0.5171929037616909d,left: 0.24359288361360298d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7803063671655323d,right: 0.9169511660515042d,bottom: 0.108472339014409d,left: 0.17670272716596125d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.25771953057854313d,right: 0.7041146454302546d,bottom: 0.022570783659226157d,left: 0.2464031819212278d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6941087261053702d,right: 0.6882906619157129d,bottom: 0.13588244521348092d,left: 0.4723645656981247d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4657704456491588d,right: 0.9325350534535052d,bottom: 0.3857479638849578d,left: 0.5551281454460018d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8380046006546973d,right: 0.7758221818417d,bottom: 0.25364274582550317d,left: 0.028293618898457495d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6165049057504911d,right: 0.4634131627986733d,bottom: 0.13412540241053983d,left: 0.4174791892402301d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6362382210676039d,right: 0.38135864207461745d,bottom: 0.40956055709262107d,left: 0.20528643300561877d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6616350673694746d,right: 0.6050783330764957d,bottom: 0.4536968608032421d,left: 0.26956893085948375d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8886956495244315d,right: 0.6234454919346375d,bottom: 0.8107560459867127d,left: 0.19856550003091433d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5970089552199271d,right: 0.8387574974321641d,bottom: 0.018095650989890077d,left: 0.5804011084733594d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6270124287302841d,right: 0.7333570696594455d,bottom: 0.4857936769046889d,left: 0.09658421581260024d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5824533764196562d,right: 0.40808753278828724d,bottom: 0.3735470595106538d,left: 0.16920479091688678d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7601612616586043d,right: 0.3090962519951602d,bottom: 0.6690401827388736d,left: 0.06737051072569777d))));

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
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxbox0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxbox0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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

        [Test, Order(13)]
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

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlBoxSingleTypebox)this).ExportModelInner(connection).ToList();
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

