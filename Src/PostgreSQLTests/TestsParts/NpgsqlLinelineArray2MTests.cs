

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
    internal partial interface INpgsqlLineListlineArray
    {
    }
    
    internal partial class NpgsqlLineListlineArray : INpgsqlLineListlineArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2mi(
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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2mi(
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
            queryMapType: typeof(NpgsqlLinelineArray2MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)
                )
            ]
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

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModelInner(connection, 1120533763, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7797869567083358d, b: 0.2361739464389747d, c: 0.48164557546500963d),

new NpgsqlTypes.NpgsqlLine(a: 0.9480048066554808d, b: 0.8035492224666504d, c: 0.9832497213764478d),

new NpgsqlTypes.NpgsqlLine(a: 0.9772596541640088d, b: 0.6093516798517065d, c: 0.6052760903401032d),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModelInner(connection, 196308953, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28578713252269017d, b: 0.8474368218362299d, c: 0.05146566977408318d),

new NpgsqlTypes.NpgsqlLine(a: 0.9109299616024349d, b: 0.5870141058904383d, c: 0.7452912896149598d),

new NpgsqlTypes.NpgsqlLine(a: 0.09671303857190205d, b: 0.22234046410281205d, c: 0.2889776640209598d),

new NpgsqlTypes.NpgsqlLine(a: 0.3594930797393622d, b: 0.1261117062789614d, c: 0.4836691385976134d),

}, null);
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

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelInnerAsync(connection, 1190383178, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12466334172066618d, b: 0.11152073168077081d, c: 0.491230984381532d),

new NpgsqlTypes.NpgsqlLine(a: 0.5547266175262346d, b: 0.13792449594977796d, c: 0.7570674004021489d),

new NpgsqlTypes.NpgsqlLine(a: 0.2085058544453703d, b: 0.08290359377194412d, c: 0.77495272781113d),

new NpgsqlTypes.NpgsqlLine(a: 0.49111506712078934d, b: 0.641116986925848d, c: 0.29516341556351666d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07914996961984966d, b: 0.4871418257809952d, c: 0.7513322508300865d),

new NpgsqlTypes.NpgsqlLine(a: 0.9239635289951339d, b: 0.38794777551433746d, c: 0.676783160212782d),

new NpgsqlTypes.NpgsqlLine(a: 0.0955538255878925d, b: 0.01055236041931451d, c: 0.2842563281409253d),

new NpgsqlTypes.NpgsqlLine(a: 0.02927332855673237d, b: 0.6165842674891228d, c: 0.8012173905302888d),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelInnerAsync(connection, 1413412459, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42503376733197573d, b: 0.763237079678654d, c: 0.09688502535476584d),

new NpgsqlTypes.NpgsqlLine(a: 0.23240822962655505d, b: 0.8459480271218152d, c: 0.08432931494869422d),

new NpgsqlTypes.NpgsqlLine(a: 0.18886663761414113d, b: 0.5079561486308892d, c: 0.9843388801596968d),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturning()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((INpgsqlLineListlineArray)this).InsertModelInnerReturning(connection, 322154126, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17316937563192347d, b: 0.7977878569807266d, c: 0.5061623155222499d),

new NpgsqlTypes.NpgsqlLine(a: 0.39020299771548206d, b: 0.46872469438895703d, c: 0.1947250961658502d),

new NpgsqlTypes.NpgsqlLine(a: 0.9460666899443665d, b: 0.40873002207057996d, c: 0.5383135596603867d),

}, null);
                Assert.That(id, Is.EqualTo(322154126));

                id =  ((INpgsqlLineListlineArray)this).InsertModelInnerReturning(connection, 111191550, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10079392481388938d, b: 0.47419284524344363d, c: 0.46999813598135487d),

new NpgsqlTypes.NpgsqlLine(a: 0.4512330545433114d, b: 0.7685777654216315d, c: 0.761484461621478d),

new NpgsqlTypes.NpgsqlLine(a: 0.7069502335832981d, b: 0.10867536284292001d, c: 0.803973548621565d),

new NpgsqlTypes.NpgsqlLine(a: 0.6710482193897285d, b: 0.3246300803211939d, c: 0.007931088387647223d),

}, null);
                Assert.That(id, Is.EqualTo(111191550));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, 1272632761, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8378269016529278d, b: 0.6733240332238696d, c: 0.8919506779863193d),

new NpgsqlTypes.NpgsqlLine(a: 0.48570634731194795d, b: 0.1596671151368555d, c: 0.20750860994967846d),

new NpgsqlTypes.NpgsqlLine(a: 0.779653513645174d, b: 0.8586337096501773d, c: 0.1738735269722934d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2675334980310755d, b: 0.5860654638502302d, c: 0.5223481489931099d),

new NpgsqlTypes.NpgsqlLine(a: 0.2908190505712529d, b: 0.027311571062217044d, c: 0.38897855152716554d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590347289639254d, b: 0.6110078502040162d, c: 0.9773066927065011d),

});
                Assert.That(id, Is.EqualTo(1272632761));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, 632564420, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9871612756422758d, b: 0.7040000628939183d, c: 0.5741990515908977d),

new NpgsqlTypes.NpgsqlLine(a: 0.8939251170158339d, b: 0.591802460616856d, c: 0.8710953712464558d),

new NpgsqlTypes.NpgsqlLine(a: 0.925765879252592d, b: 0.020003653879282934d, c: 0.27174016206463947d),

new NpgsqlTypes.NpgsqlLine(a: 0.40821497810499396d, b: 0.18426353989680566d, c: 0.35762480728827095d),

}, null);
                Assert.That(id, Is.EqualTo(632564420));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, 116492752, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8534388679989421d, b: 0.17051639981163313d, c: 0.11184373953100968d),

new NpgsqlTypes.NpgsqlLine(a: 0.5545649696933802d, b: 0.6495249060333349d, c: 0.14480165352840013d),

new NpgsqlTypes.NpgsqlLine(a: 0.7068689700072772d, b: 0.10325704725403717d, c: 0.1383403540154834d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.565937691937727d, b: 0.8643068916219007d, c: 0.7899347881580714d),

new NpgsqlTypes.NpgsqlLine(a: 0.5461437063589625d, b: 0.8396992488239946d, c: 0.4549808859483121d),

new NpgsqlTypes.NpgsqlLine(a: 0.11142572920429805d, b: 0.7092154686109046d, c: 0.04531658445440445d),

new NpgsqlTypes.NpgsqlLine(a: 0.8590566964589479d, b: 0.07365357454587718d, c: 0.01783865983951749d),

});
                Assert.That(id, Is.EqualTo(116492752));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, 723640790, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8545769023218451d, b: 0.24286566112974062d, c: 0.24373271509232275d),

new NpgsqlTypes.NpgsqlLine(a: 0.8731571462637403d, b: 0.9993617334238951d, c: 0.1725755360195571d),

new NpgsqlTypes.NpgsqlLine(a: 0.2467482163165423d, b: 0.7309207508122816d, c: 0.574326589073651d),

new NpgsqlTypes.NpgsqlLine(a: 0.39429370255535745d, b: 0.12918013405283635d, c: 0.37279548432778786d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8697103680615146d, b: 0.4868697197066526d, c: 0.008300202872866591d),

new NpgsqlTypes.NpgsqlLine(a: 0.9268152455195247d, b: 0.9945415027788427d, c: 0.33225561051564245d),

new NpgsqlTypes.NpgsqlLine(a: 0.06541514412119742d, b: 0.29832372565206444d, c: 0.34837671529944225d),

new NpgsqlTypes.NpgsqlLine(a: 0.7703107306167513d, b: 0.39150187650435253d, c: 0.17912768771478083d),

});
                Assert.That(id, Is.EqualTo(723640790));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, 2140414751, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5666355568463651d, b: 0.5532657932652175d, c: 0.043303548850170626d),

new NpgsqlTypes.NpgsqlLine(a: 0.4900959494886681d, b: 0.9349750472343457d, c: 0.4121355471301291d),

new NpgsqlTypes.NpgsqlLine(a: 0.06398838318692368d, b: 0.028285739863693204d, c: 0.8052480125394759d),

new NpgsqlTypes.NpgsqlLine(a: 0.31673961185856914d, b: 0.4141587759463713d, c: 0.1893488396111126d),

}, null);
                Assert.That(id, Is.EqualTo(2140414751));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, 1525343338, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5334739519154116d, b: 0.14533927203574382d, c: 0.9972375896646379d),

new NpgsqlTypes.NpgsqlLine(a: 0.5376404385911305d, b: 0.3967355325520928d, c: 0.2690585850054501d),

new NpgsqlTypes.NpgsqlLine(a: 0.7930288640515465d, b: 0.4034090749439643d, c: 0.19977351395319798d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22585130451050572d, b: 0.054454055462575424d, c: 0.3670135684186787d),

new NpgsqlTypes.NpgsqlLine(a: 0.8573417118252535d, b: 0.7290365889192361d, c: 0.15771025911629288d),

new NpgsqlTypes.NpgsqlLine(a: 0.8294206137900973d, b: 0.778292553399524d, c: 0.5844131999897239d),

new NpgsqlTypes.NpgsqlLine(a: 0.8795242286168519d, b: 0.43336364459496624d, c: 0.07939237473054006d),

});
                Assert.That(id, Is.EqualTo(1525343338));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, 2023967945, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7526118185907706d, b: 0.7217192659741516d, c: 0.10725515353553927d),

new NpgsqlTypes.NpgsqlLine(a: 0.4123399872860949d, b: 0.9887632111198967d, c: 0.3407478138648996d),

new NpgsqlTypes.NpgsqlLine(a: 0.1972888611598902d, b: 0.21209298014251077d, c: 0.998100482656704d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32204440669620105d, b: 0.40425092983702615d, c: 0.6281187397686202d),

new NpgsqlTypes.NpgsqlLine(a: 0.8736370792109995d, b: 0.8257156419424208d, c: 0.24574228768788875d),

new NpgsqlTypes.NpgsqlLine(a: 0.1777372581271598d, b: 0.02795031420098848d, c: 0.6085263716794568d),

new NpgsqlTypes.NpgsqlLine(a: 0.3937718955623397d, b: 0.3857998777014512d, c: 0.16490107858931902d),

});
                Assert.That(id, Is.EqualTo(2023967945));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, 1264360862, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3150738269575506d, b: 0.25723902915678687d, c: 0.7085220942560913d),

new NpgsqlTypes.NpgsqlLine(a: 0.10217399526832571d, b: 0.23606907248025677d, c: 0.14832581681823231d),

new NpgsqlTypes.NpgsqlLine(a: 0.38475783269574504d, b: 0.261674953378639d, c: 0.8414017715374641d),

new NpgsqlTypes.NpgsqlLine(a: 0.060969244577031345d, b: 0.7001282741779633d, c: 0.8180532031964253d),

}, null);
                Assert.That(id, Is.EqualTo(1264360862));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, 117280179, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3605977641294892d, b: 0.17811158147680461d, c: 0.9658058071756186d),

new NpgsqlTypes.NpgsqlLine(a: 0.6970256025820155d, b: 0.5444046414962291d, c: 0.46720686007108925d),

new NpgsqlTypes.NpgsqlLine(a: 0.8561050660597573d, b: 0.11353237597432853d, c: 0.56669941414895d),

new NpgsqlTypes.NpgsqlLine(a: 0.7984600619309864d, b: 0.8109151931011057d, c: 0.769305377302455d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0947306689172811d, b: 0.8302577671800684d, c: 0.8970532400118938d),

new NpgsqlTypes.NpgsqlLine(a: 0.2407748752003226d, b: 0.4567310255560061d, c: 0.4526792803927874d),

new NpgsqlTypes.NpgsqlLine(a: 0.04496104252758981d, b: 0.7589917027634498d, c: 0.6770421060059869d),

});
                Assert.That(id, Is.EqualTo(117280179));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
",
            methodName:"InsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                )
            ]
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

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModel(connection, 1943853869, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5132420668035784d, b: 0.9613252483783701d, c: 0.9242449431625296d),

new NpgsqlTypes.NpgsqlLine(a: 0.36653456446188004d, b: 0.7359631901409467d, c: 0.27792441954855884d),

new NpgsqlTypes.NpgsqlLine(a: 0.4636783251093567d, b: 0.1186591604974756d, c: 0.39388519565520497d),

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModel(connection, 569222828, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3541781533895836d, b: 0.8806877333215982d, c: 0.3434395351862555d),

new NpgsqlTypes.NpgsqlLine(a: 0.904182291889472d, b: 0.2725232832902962d, c: 0.11922376175569749d),

new NpgsqlTypes.NpgsqlLine(a: 0.2973949214938665d, b: 0.551548200515303d, c: 0.11510798755200236d),

new NpgsqlTypes.NpgsqlLine(a: 0.6236383027800103d, b: 0.7132402356425214d, c: 0.7946866828405127d),

}, null, 1120533763);
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

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelAsync(connection, 1411554384, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.43292849531653743d, b: 0.10139772092942057d, c: 0.19581477698464556d),

new NpgsqlTypes.NpgsqlLine(a: 0.7747830082073887d, b: 0.7612727046736724d, c: 0.49585407932443326d),

new NpgsqlTypes.NpgsqlLine(a: 0.7534769161594925d, b: 0.21640631521439513d, c: 0.9417215429915208d),

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelAsync(connection, 1370558129, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9082169806472872d, b: 0.9235120225757552d, c: 0.8994934710072177d),

new NpgsqlTypes.NpgsqlLine(a: 0.12419478532476513d, b: 0.805126203795883d, c: 0.21123699569220133d),

new NpgsqlTypes.NpgsqlLine(a: 0.5518835410640954d, b: 0.3470463651950829d, c: 0.4121461426388031d),

}, null, 196308953);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(NpgsqlLinelineArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                )
            ]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray2M> models = null;
                NpgsqlLinelineArray2M model = null;

                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, 627974170, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15147399565049113d, b: 0.7627100647125816d, c: 0.16010235385722305d),

new NpgsqlTypes.NpgsqlLine(a: 0.9001358065765852d, b: 0.4721890907147458d, c: 0.15927787372271784d),

new NpgsqlTypes.NpgsqlLine(a: 0.7813049144298684d, b: 0.4136335409837938d, c: 0.12660196714031435d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.004236560392559818d, b: 0.39606208609499893d, c: 0.19741769434420997d),

new NpgsqlTypes.NpgsqlLine(a: 0.5953646586031078d, b: 0.6151314480582013d, c: 0.6556527973910132d),

new NpgsqlTypes.NpgsqlLine(a: 0.5407811339876436d, b: 0.9334248245144674d, c: 0.8365874899469636d),

new NpgsqlTypes.NpgsqlLine(a: 0.4764002070454937d, b: 0.16718217080509323d, c: 0.17236129187105342d),

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(627974170));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15147399565049113d, b: 0.7627100647125816d, c: 0.16010235385722305d),

new NpgsqlTypes.NpgsqlLine(a: 0.9001358065765852d, b: 0.4721890907147458d, c: 0.15927787372271784d),

new NpgsqlTypes.NpgsqlLine(a: 0.7813049144298684d, b: 0.4136335409837938d, c: 0.12660196714031435d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.004236560392559818d, b: 0.39606208609499893d, c: 0.19741769434420997d),

new NpgsqlTypes.NpgsqlLine(a: 0.5953646586031078d, b: 0.6151314480582013d, c: 0.6556527973910132d),

new NpgsqlTypes.NpgsqlLine(a: 0.5407811339876436d, b: 0.9334248245144674d, c: 0.8365874899469636d),

new NpgsqlTypes.NpgsqlLine(a: 0.4764002070454937d, b: 0.16718217080509323d, c: 0.17236129187105342d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, 791579102, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3341739254022562d, b: 0.718465753134697d, c: 0.5771634629019262d),

new NpgsqlTypes.NpgsqlLine(a: 0.6322200521292398d, b: 0.8246392866857581d, c: 0.5696079494467468d),

new NpgsqlTypes.NpgsqlLine(a: 0.6545382710133834d, b: 0.4365654599867256d, c: 0.8153585418393168d),

new NpgsqlTypes.NpgsqlLine(a: 0.0910019439659393d, b: 0.7174745892954046d, c: 0.1511089208473413d),

}, null, 1190383178).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(791579102));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3341739254022562d, b: 0.718465753134697d, c: 0.5771634629019262d),

new NpgsqlTypes.NpgsqlLine(a: 0.6322200521292398d, b: 0.8246392866857581d, c: 0.5696079494467468d),

new NpgsqlTypes.NpgsqlLine(a: 0.6545382710133834d, b: 0.4365654599867256d, c: 0.8153585418393168d),

new NpgsqlTypes.NpgsqlLine(a: 0.0910019439659393d, b: 0.7174745892954046d, c: 0.1511089208473413d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1190383178));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, 1423267657, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7028157888188539d, b: 0.4434497177574276d, c: 0.1878584904244096d),

new NpgsqlTypes.NpgsqlLine(a: 0.12779644786129707d, b: 0.6547737034235738d, c: 0.7340324477099678d),

new NpgsqlTypes.NpgsqlLine(a: 0.13473852180731738d, b: 0.7900921279332365d, c: 0.7695417103969711d),

new NpgsqlTypes.NpgsqlLine(a: 0.2618677281295215d, b: 0.24821010444457137d, c: 0.2711393719015588d),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1423267657));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7028157888188539d, b: 0.4434497177574276d, c: 0.1878584904244096d),

new NpgsqlTypes.NpgsqlLine(a: 0.12779644786129707d, b: 0.6547737034235738d, c: 0.7340324477099678d),

new NpgsqlTypes.NpgsqlLine(a: 0.13473852180731738d, b: 0.7900921279332365d, c: 0.7695417103969711d),

new NpgsqlTypes.NpgsqlLine(a: 0.2618677281295215d, b: 0.24821010444457137d, c: 0.2711393719015588d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, 617125650, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35787275736319957d, b: 0.702047825867143d, c: 0.965415572167533d),

new NpgsqlTypes.NpgsqlLine(a: 0.31090623461505584d, b: 0.5647177423851781d, c: 0.4846654296503867d),

new NpgsqlTypes.NpgsqlLine(a: 0.3183862992195977d, b: 0.6261458826331173d, c: 0.6907068588712774d),

new NpgsqlTypes.NpgsqlLine(a: 0.6487979418902344d, b: 0.4615179308283234d, c: 0.642127574912425d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9197027266355764d, b: 0.39215058098740485d, c: 0.17261332753094694d),

new NpgsqlTypes.NpgsqlLine(a: 0.11391459246246716d, b: 0.8528811542175645d, c: 0.20274869752530522d),

new NpgsqlTypes.NpgsqlLine(a: 0.36907637605105814d, b: 0.6376511000289307d, c: 0.12998307736849357d),

new NpgsqlTypes.NpgsqlLine(a: 0.9580086581171673d, b: 0.03050170247729178d, c: 0.38029624192446d),

}, 1413412459).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(617125650));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35787275736319957d, b: 0.702047825867143d, c: 0.965415572167533d),

new NpgsqlTypes.NpgsqlLine(a: 0.31090623461505584d, b: 0.5647177423851781d, c: 0.4846654296503867d),

new NpgsqlTypes.NpgsqlLine(a: 0.3183862992195977d, b: 0.6261458826331173d, c: 0.6907068588712774d),

new NpgsqlTypes.NpgsqlLine(a: 0.6487979418902344d, b: 0.4615179308283234d, c: 0.642127574912425d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9197027266355764d, b: 0.39215058098740485d, c: 0.17261332753094694d),

new NpgsqlTypes.NpgsqlLine(a: 0.11391459246246716d, b: 0.8528811542175645d, c: 0.20274869752530522d),

new NpgsqlTypes.NpgsqlLine(a: 0.36907637605105814d, b: 0.6376511000289307d, c: 0.12998307736849357d),

new NpgsqlTypes.NpgsqlLine(a: 0.9580086581171673d, b: 0.03050170247729178d, c: 0.38029624192446d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1413412459));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray2M> models = null;
                NpgsqlLinelineArray2M model = null;

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, 1951774404, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4334255210533513d, b: 0.5785255926410576d, c: 0.9661508534687067d),

new NpgsqlTypes.NpgsqlLine(a: 0.19775236418153797d, b: 0.9365672085879589d, c: 0.1494826860380959d),

new NpgsqlTypes.NpgsqlLine(a: 0.176207462329397d, b: 0.2629253672101627d, c: 0.07007543599573873d),

new NpgsqlTypes.NpgsqlLine(a: 0.12818842182277845d, b: 0.1863366614728862d, c: 0.7134229928630377d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6151166351904711d, b: 0.2498835420322547d, c: 0.9733560033126378d),

new NpgsqlTypes.NpgsqlLine(a: 0.7516653963992566d, b: 0.8871254006140514d, c: 0.9688544000775576d),

new NpgsqlTypes.NpgsqlLine(a: 0.5920030979667459d, b: 0.19764908877922582d, c: 0.5631519149614208d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1951774404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4334255210533513d, b: 0.5785255926410576d, c: 0.9661508534687067d),

new NpgsqlTypes.NpgsqlLine(a: 0.19775236418153797d, b: 0.9365672085879589d, c: 0.1494826860380959d),

new NpgsqlTypes.NpgsqlLine(a: 0.176207462329397d, b: 0.2629253672101627d, c: 0.07007543599573873d),

new NpgsqlTypes.NpgsqlLine(a: 0.12818842182277845d, b: 0.1863366614728862d, c: 0.7134229928630377d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6151166351904711d, b: 0.2498835420322547d, c: 0.9733560033126378d),

new NpgsqlTypes.NpgsqlLine(a: 0.7516653963992566d, b: 0.8871254006140514d, c: 0.9688544000775576d),

new NpgsqlTypes.NpgsqlLine(a: 0.5920030979667459d, b: 0.19764908877922582d, c: 0.5631519149614208d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, 1921152006, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3706659351474607d, b: 0.20392121211971403d, c: 0.09026673921559647d),

new NpgsqlTypes.NpgsqlLine(a: 0.3426907809834573d, b: 0.11597889224231583d, c: 0.37580383029156417d),

new NpgsqlTypes.NpgsqlLine(a: 0.9569454063294334d, b: 0.5352074925592666d, c: 0.1505041653825815d),

}, null, 322154126).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1921152006));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3706659351474607d, b: 0.20392121211971403d, c: 0.09026673921559647d),

new NpgsqlTypes.NpgsqlLine(a: 0.3426907809834573d, b: 0.11597889224231583d, c: 0.37580383029156417d),

new NpgsqlTypes.NpgsqlLine(a: 0.9569454063294334d, b: 0.5352074925592666d, c: 0.1505041653825815d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(322154126));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, 1651600176, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16882852097245493d, b: 0.6320810387310721d, c: 0.4943119337666173d),

new NpgsqlTypes.NpgsqlLine(a: 0.1864608664190791d, b: 0.3923939341785333d, c: 0.40778672849944797d),

new NpgsqlTypes.NpgsqlLine(a: 0.21658079009283382d, b: 0.9735580473103661d, c: 0.5313780798893142d),

new NpgsqlTypes.NpgsqlLine(a: 0.608447080933292d, b: 0.9095061095638245d, c: 0.664417030599092d),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1651600176));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16882852097245493d, b: 0.6320810387310721d, c: 0.4943119337666173d),

new NpgsqlTypes.NpgsqlLine(a: 0.1864608664190791d, b: 0.3923939341785333d, c: 0.40778672849944797d),

new NpgsqlTypes.NpgsqlLine(a: 0.21658079009283382d, b: 0.9735580473103661d, c: 0.5313780798893142d),

new NpgsqlTypes.NpgsqlLine(a: 0.608447080933292d, b: 0.9095061095638245d, c: 0.664417030599092d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, 1618779845, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588222459861263d, b: 0.8314528851615401d, c: 0.4091425195520225d),

new NpgsqlTypes.NpgsqlLine(a: 0.15497545879234587d, b: 0.42501177297812087d, c: 0.3930386900482442d),

new NpgsqlTypes.NpgsqlLine(a: 0.49932759733861587d, b: 0.27860846401633954d, c: 0.22371479209453393d),

new NpgsqlTypes.NpgsqlLine(a: 0.6744750487770321d, b: 0.5185555306309229d, c: 0.48333909912156325d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6846715107366038d, b: 0.7822398219668835d, c: 0.6995656002724597d),

new NpgsqlTypes.NpgsqlLine(a: 0.34191163697506577d, b: 0.251427920689659d, c: 0.6372400180339429d),

new NpgsqlTypes.NpgsqlLine(a: 0.7615638356664386d, b: 0.38275705185682163d, c: 0.9430695395246483d),

new NpgsqlTypes.NpgsqlLine(a: 0.25861736938688795d, b: 0.2236086093911689d, c: 0.43081968027669826d),

}, 111191550).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1618779845));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588222459861263d, b: 0.8314528851615401d, c: 0.4091425195520225d),

new NpgsqlTypes.NpgsqlLine(a: 0.15497545879234587d, b: 0.42501177297812087d, c: 0.3930386900482442d),

new NpgsqlTypes.NpgsqlLine(a: 0.49932759733861587d, b: 0.27860846401633954d, c: 0.22371479209453393d),

new NpgsqlTypes.NpgsqlLine(a: 0.6744750487770321d, b: 0.5185555306309229d, c: 0.48333909912156325d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6846715107366038d, b: 0.7822398219668835d, c: 0.6995656002724597d),

new NpgsqlTypes.NpgsqlLine(a: 0.34191163697506577d, b: 0.251427920689659d, c: 0.6372400180339429d),

new NpgsqlTypes.NpgsqlLine(a: 0.7615638356664386d, b: 0.38275705185682163d, c: 0.9430695395246483d),

new NpgsqlTypes.NpgsqlLine(a: 0.25861736938688795d, b: 0.2236086093911689d, c: 0.43081968027669826d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(111191550));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, 1858289195, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25032438445726d, b: 0.0917391846373673d, c: 0.34066051809002806d),

new NpgsqlTypes.NpgsqlLine(a: 0.07831144663304057d, b: 0.77591037387439d, c: 0.19759580235224372d),

new NpgsqlTypes.NpgsqlLine(a: 0.3752205191956137d, b: 0.9100313386910368d, c: 0.6525871812195568d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47106408656007914d, b: 0.14257658261320605d, c: 0.47373760961489964d),

new NpgsqlTypes.NpgsqlLine(a: 0.4366806562773925d, b: 0.20146202051894901d, c: 0.3244113712884158d),

new NpgsqlTypes.NpgsqlLine(a: 0.41468311552317627d, b: 0.27557991533085235d, c: 0.7788691278257713d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858289195));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25032438445726d, b: 0.0917391846373673d, c: 0.34066051809002806d),

new NpgsqlTypes.NpgsqlLine(a: 0.07831144663304057d, b: 0.77591037387439d, c: 0.19759580235224372d),

new NpgsqlTypes.NpgsqlLine(a: 0.3752205191956137d, b: 0.9100313386910368d, c: 0.6525871812195568d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47106408656007914d, b: 0.14257658261320605d, c: 0.47373760961489964d),

new NpgsqlTypes.NpgsqlLine(a: 0.4366806562773925d, b: 0.20146202051894901d, c: 0.3244113712884158d),

new NpgsqlTypes.NpgsqlLine(a: 0.41468311552317627d, b: 0.27557991533085235d, c: 0.7788691278257713d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, 833599485, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4822973119466689d, b: 0.792513536759573d, c: 0.499633501292873d),

new NpgsqlTypes.NpgsqlLine(a: 0.8918073488512478d, b: 0.42208129985829845d, c: 0.5329638256901381d),

new NpgsqlTypes.NpgsqlLine(a: 0.5188620987187985d, b: 0.1726952436096839d, c: 0.7227459582321649d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15666178016283616d, b: 0.2873368213961791d, c: 0.4420895689102471d),

new NpgsqlTypes.NpgsqlLine(a: 0.4601057867375493d, b: 0.5622721416121373d, c: 0.2999980165807573d),

new NpgsqlTypes.NpgsqlLine(a: 0.8381583831951187d, b: 0.9764919740330239d, c: 0.18152562681640294d),

}, 1272632761).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(833599485));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4822973119466689d, b: 0.792513536759573d, c: 0.499633501292873d),

new NpgsqlTypes.NpgsqlLine(a: 0.8918073488512478d, b: 0.42208129985829845d, c: 0.5329638256901381d),

new NpgsqlTypes.NpgsqlLine(a: 0.5188620987187985d, b: 0.1726952436096839d, c: 0.7227459582321649d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15666178016283616d, b: 0.2873368213961791d, c: 0.4420895689102471d),

new NpgsqlTypes.NpgsqlLine(a: 0.4601057867375493d, b: 0.5622721416121373d, c: 0.2999980165807573d),

new NpgsqlTypes.NpgsqlLine(a: 0.8381583831951187d, b: 0.9764919740330239d, c: 0.18152562681640294d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1272632761));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, 1006841713, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3814391347607825d, b: 0.6500010795000312d, c: 0.5168910912789877d),

new NpgsqlTypes.NpgsqlLine(a: 0.9809725325416359d, b: 0.5965089551877092d, c: 0.9620206915411497d),

new NpgsqlTypes.NpgsqlLine(a: 0.8326177257415529d, b: 0.9726427466112844d, c: 0.44743910631138517d),

new NpgsqlTypes.NpgsqlLine(a: 0.9428905413649304d, b: 0.2742783552238923d, c: 0.20624247958140818d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4156588878635493d, b: 0.9311562710078888d, c: 0.18729745760128813d),

new NpgsqlTypes.NpgsqlLine(a: 0.7838364754377413d, b: 0.2902143764264882d, c: 0.6468999105347263d),

new NpgsqlTypes.NpgsqlLine(a: 0.2807400125401047d, b: 0.4738433713063067d, c: 0.3414032292061351d),

new NpgsqlTypes.NpgsqlLine(a: 0.07976939589399212d, b: 0.6817427263698487d, c: 0.7162950229594492d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1006841713));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3814391347607825d, b: 0.6500010795000312d, c: 0.5168910912789877d),

new NpgsqlTypes.NpgsqlLine(a: 0.9809725325416359d, b: 0.5965089551877092d, c: 0.9620206915411497d),

new NpgsqlTypes.NpgsqlLine(a: 0.8326177257415529d, b: 0.9726427466112844d, c: 0.44743910631138517d),

new NpgsqlTypes.NpgsqlLine(a: 0.9428905413649304d, b: 0.2742783552238923d, c: 0.20624247958140818d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4156588878635493d, b: 0.9311562710078888d, c: 0.18729745760128813d),

new NpgsqlTypes.NpgsqlLine(a: 0.7838364754377413d, b: 0.2902143764264882d, c: 0.6468999105347263d),

new NpgsqlTypes.NpgsqlLine(a: 0.2807400125401047d, b: 0.4738433713063067d, c: 0.3414032292061351d),

new NpgsqlTypes.NpgsqlLine(a: 0.07976939589399212d, b: 0.6817427263698487d, c: 0.7162950229594492d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, 548719832, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45120792613918626d, b: 0.7981849131464387d, c: 0.6797001557385036d),

new NpgsqlTypes.NpgsqlLine(a: 0.5152860785682492d, b: 0.05860524276063561d, c: 0.31392693425098706d),

new NpgsqlTypes.NpgsqlLine(a: 0.8399321644879826d, b: 0.14127845073157042d, c: 0.04919268640928787d),

new NpgsqlTypes.NpgsqlLine(a: 0.5367279979863265d, b: 0.9037039524330727d, c: 0.5651736207579545d),

}, null, 632564420).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(548719832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45120792613918626d, b: 0.7981849131464387d, c: 0.6797001557385036d),

new NpgsqlTypes.NpgsqlLine(a: 0.5152860785682492d, b: 0.05860524276063561d, c: 0.31392693425098706d),

new NpgsqlTypes.NpgsqlLine(a: 0.8399321644879826d, b: 0.14127845073157042d, c: 0.04919268640928787d),

new NpgsqlTypes.NpgsqlLine(a: 0.5367279979863265d, b: 0.9037039524330727d, c: 0.5651736207579545d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(632564420));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, 964637978, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7665509369596407d, b: 0.32246651386445413d, c: 0.4163237996846909d),

new NpgsqlTypes.NpgsqlLine(a: 0.622867187513811d, b: 0.02481599358005626d, c: 0.6781914372848628d),

new NpgsqlTypes.NpgsqlLine(a: 0.9383962517038102d, b: 0.22799617371669267d, c: 0.11769282658114588d),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(964637978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7665509369596407d, b: 0.32246651386445413d, c: 0.4163237996846909d),

new NpgsqlTypes.NpgsqlLine(a: 0.622867187513811d, b: 0.02481599358005626d, c: 0.6781914372848628d),

new NpgsqlTypes.NpgsqlLine(a: 0.9383962517038102d, b: 0.22799617371669267d, c: 0.11769282658114588d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, 1800975967, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6019711101236188d, b: 0.451502314152629d, c: 0.7567258646896037d),

new NpgsqlTypes.NpgsqlLine(a: 0.20314867633928102d, b: 0.43694052621738755d, c: 0.07972430095228344d),

new NpgsqlTypes.NpgsqlLine(a: 0.38639176328531444d, b: 0.5546727142910798d, c: 0.3595107666863845d),

}, null, 116492752).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1800975967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6019711101236188d, b: 0.451502314152629d, c: 0.7567258646896037d),

new NpgsqlTypes.NpgsqlLine(a: 0.20314867633928102d, b: 0.43694052621738755d, c: 0.07972430095228344d),

new NpgsqlTypes.NpgsqlLine(a: 0.38639176328531444d, b: 0.5546727142910798d, c: 0.3595107666863845d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(116492752));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, 1931477721, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24029930494024243d, b: 0.6494520983530296d, c: 0.6457904476196421d),

new NpgsqlTypes.NpgsqlLine(a: 0.5413106581652064d, b: 0.65922568011039d, c: 0.023000101756869618d),

new NpgsqlTypes.NpgsqlLine(a: 0.05698461456670889d, b: 0.07946838244893384d, c: 0.023133320459978735d),

new NpgsqlTypes.NpgsqlLine(a: 0.023417572430763367d, b: 0.20022755743974863d, c: 0.9001563624157146d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3818728397283605d, b: 0.24081372003152057d, c: 0.42604600108359325d),

new NpgsqlTypes.NpgsqlLine(a: 0.9919565701428744d, b: 0.9836921588174795d, c: 0.6353618672799166d),

new NpgsqlTypes.NpgsqlLine(a: 0.49779514301225014d, b: 0.9235637976007209d, c: 0.26480996790155775d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931477721));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24029930494024243d, b: 0.6494520983530296d, c: 0.6457904476196421d),

new NpgsqlTypes.NpgsqlLine(a: 0.5413106581652064d, b: 0.65922568011039d, c: 0.023000101756869618d),

new NpgsqlTypes.NpgsqlLine(a: 0.05698461456670889d, b: 0.07946838244893384d, c: 0.023133320459978735d),

new NpgsqlTypes.NpgsqlLine(a: 0.023417572430763367d, b: 0.20022755743974863d, c: 0.9001563624157146d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3818728397283605d, b: 0.24081372003152057d, c: 0.42604600108359325d),

new NpgsqlTypes.NpgsqlLine(a: 0.9919565701428744d, b: 0.9836921588174795d, c: 0.6353618672799166d),

new NpgsqlTypes.NpgsqlLine(a: 0.49779514301225014d, b: 0.9235637976007209d, c: 0.26480996790155775d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, 1008288557, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6703103585772012d, b: 0.9414469448287122d, c: 0.32961805156524826d),

new NpgsqlTypes.NpgsqlLine(a: 0.13239408457631574d, b: 0.5134528929025426d, c: 0.5412589816963953d),

new NpgsqlTypes.NpgsqlLine(a: 0.1699098825091695d, b: 0.9194545880639252d, c: 0.7451240040858685d),

new NpgsqlTypes.NpgsqlLine(a: 0.2233903417330374d, b: 0.07771599830861675d, c: 0.5752102020647447d),

}, null, 723640790).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1008288557));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6703103585772012d, b: 0.9414469448287122d, c: 0.32961805156524826d),

new NpgsqlTypes.NpgsqlLine(a: 0.13239408457631574d, b: 0.5134528929025426d, c: 0.5412589816963953d),

new NpgsqlTypes.NpgsqlLine(a: 0.1699098825091695d, b: 0.9194545880639252d, c: 0.7451240040858685d),

new NpgsqlTypes.NpgsqlLine(a: 0.2233903417330374d, b: 0.07771599830861675d, c: 0.5752102020647447d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(723640790));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, 350174520, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23005994787391715d, b: 0.314006898861965d, c: 0.9059890459886075d),

new NpgsqlTypes.NpgsqlLine(a: 0.0034924525333345224d, b: 0.22569705718656508d, c: 0.12293033480738269d),

new NpgsqlTypes.NpgsqlLine(a: 0.13769753447358068d, b: 0.20289930144832358d, c: 0.9141833823361538d),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(350174520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23005994787391715d, b: 0.314006898861965d, c: 0.9059890459886075d),

new NpgsqlTypes.NpgsqlLine(a: 0.0034924525333345224d, b: 0.22569705718656508d, c: 0.12293033480738269d),

new NpgsqlTypes.NpgsqlLine(a: 0.13769753447358068d, b: 0.20289930144832358d, c: 0.9141833823361538d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, 1212970907, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5991478813435879d, b: 0.21696546349723422d, c: 0.7473704822066682d),

new NpgsqlTypes.NpgsqlLine(a: 0.151066097236479d, b: 0.0802844223551269d, c: 0.09162465810768494d),

new NpgsqlTypes.NpgsqlLine(a: 0.8623052986382002d, b: 0.9298840839917386d, c: 0.6660510239194597d),

new NpgsqlTypes.NpgsqlLine(a: 0.9991351159913222d, b: 0.029361445428178645d, c: 0.30760770391653036d),

}, null, 2140414751).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1212970907));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5991478813435879d, b: 0.21696546349723422d, c: 0.7473704822066682d),

new NpgsqlTypes.NpgsqlLine(a: 0.151066097236479d, b: 0.0802844223551269d, c: 0.09162465810768494d),

new NpgsqlTypes.NpgsqlLine(a: 0.8623052986382002d, b: 0.9298840839917386d, c: 0.6660510239194597d),

new NpgsqlTypes.NpgsqlLine(a: 0.9991351159913222d, b: 0.029361445428178645d, c: 0.30760770391653036d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2140414751));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, 1908397739, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36399675452528046d, b: 0.21180965313124933d, c: 0.6232643186817026d),

new NpgsqlTypes.NpgsqlLine(a: 0.8377534917307251d, b: 0.7197248111141329d, c: 0.5638759891270843d),

new NpgsqlTypes.NpgsqlLine(a: 0.9127913721936561d, b: 0.47658260676426356d, c: 0.4401534500107992d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.502181779437056d, b: 0.3652805047459293d, c: 0.32001644451474576d),

new NpgsqlTypes.NpgsqlLine(a: 0.7113651445912559d, b: 0.3869191031273206d, c: 0.7332400621535746d),

new NpgsqlTypes.NpgsqlLine(a: 0.5302147002696467d, b: 0.6514960201183412d, c: 0.8888784836070758d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1908397739));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36399675452528046d, b: 0.21180965313124933d, c: 0.6232643186817026d),

new NpgsqlTypes.NpgsqlLine(a: 0.8377534917307251d, b: 0.7197248111141329d, c: 0.5638759891270843d),

new NpgsqlTypes.NpgsqlLine(a: 0.9127913721936561d, b: 0.47658260676426356d, c: 0.4401534500107992d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.502181779437056d, b: 0.3652805047459293d, c: 0.32001644451474576d),

new NpgsqlTypes.NpgsqlLine(a: 0.7113651445912559d, b: 0.3869191031273206d, c: 0.7332400621535746d),

new NpgsqlTypes.NpgsqlLine(a: 0.5302147002696467d, b: 0.6514960201183412d, c: 0.8888784836070758d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, 1610745034, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6382266935775643d, b: 0.398693329671132d, c: 0.7425094436899613d),

new NpgsqlTypes.NpgsqlLine(a: 0.24327741116998813d, b: 0.1635267687203752d, c: 0.628031718062037d),

new NpgsqlTypes.NpgsqlLine(a: 0.38459544322295613d, b: 0.4141132804519537d, c: 0.8511486540491503d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9861241662988156d, b: 0.25399030999510996d, c: 0.2529918964264557d),

new NpgsqlTypes.NpgsqlLine(a: 0.17574090331875702d, b: 0.5215697754670754d, c: 0.49092403723555744d),

new NpgsqlTypes.NpgsqlLine(a: 0.9755215010138426d, b: 0.5836706698542481d, c: 0.8112425273051307d),

}, 1525343338).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1610745034));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6382266935775643d, b: 0.398693329671132d, c: 0.7425094436899613d),

new NpgsqlTypes.NpgsqlLine(a: 0.24327741116998813d, b: 0.1635267687203752d, c: 0.628031718062037d),

new NpgsqlTypes.NpgsqlLine(a: 0.38459544322295613d, b: 0.4141132804519537d, c: 0.8511486540491503d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9861241662988156d, b: 0.25399030999510996d, c: 0.2529918964264557d),

new NpgsqlTypes.NpgsqlLine(a: 0.17574090331875702d, b: 0.5215697754670754d, c: 0.49092403723555744d),

new NpgsqlTypes.NpgsqlLine(a: 0.9755215010138426d, b: 0.5836706698542481d, c: 0.8112425273051307d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1525343338));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, 899804594, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1970857537444196d, b: 0.9333242638108382d, c: 0.2997924017071659d),

new NpgsqlTypes.NpgsqlLine(a: 0.6311349404614687d, b: 0.19618574736695826d, c: 0.38842914242231885d),

new NpgsqlTypes.NpgsqlLine(a: 0.8616526286116198d, b: 0.5020108677923993d, c: 0.7507796571723376d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8462722154822349d, b: 0.2140170588076531d, c: 0.1555300802445071d),

new NpgsqlTypes.NpgsqlLine(a: 0.05107346767082066d, b: 0.6007632357415391d, c: 0.11568725974145999d),

new NpgsqlTypes.NpgsqlLine(a: 0.9923537289603477d, b: 0.4950249871115745d, c: 0.02343990901364046d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(899804594));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1970857537444196d, b: 0.9333242638108382d, c: 0.2997924017071659d),

new NpgsqlTypes.NpgsqlLine(a: 0.6311349404614687d, b: 0.19618574736695826d, c: 0.38842914242231885d),

new NpgsqlTypes.NpgsqlLine(a: 0.8616526286116198d, b: 0.5020108677923993d, c: 0.7507796571723376d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8462722154822349d, b: 0.2140170588076531d, c: 0.1555300802445071d),

new NpgsqlTypes.NpgsqlLine(a: 0.05107346767082066d, b: 0.6007632357415391d, c: 0.11568725974145999d),

new NpgsqlTypes.NpgsqlLine(a: 0.9923537289603477d, b: 0.4950249871115745d, c: 0.02343990901364046d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, 528252532, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22785571390952986d, b: 0.47384563164287363d, c: 0.7296472935133859d),

new NpgsqlTypes.NpgsqlLine(a: 0.42847852345883053d, b: 0.05295602193643412d, c: 0.7176332323630693d),

new NpgsqlTypes.NpgsqlLine(a: 0.1313916587576558d, b: 0.44047120647606086d, c: 0.4080020542049758d),

}, null, 2023967945).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(528252532));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22785571390952986d, b: 0.47384563164287363d, c: 0.7296472935133859d),

new NpgsqlTypes.NpgsqlLine(a: 0.42847852345883053d, b: 0.05295602193643412d, c: 0.7176332323630693d),

new NpgsqlTypes.NpgsqlLine(a: 0.1313916587576558d, b: 0.44047120647606086d, c: 0.4080020542049758d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2023967945));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, 94091086, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.756130013480001d, b: 0.8070063086186816d, c: 0.5025767314647364d),

new NpgsqlTypes.NpgsqlLine(a: 0.9364656141137178d, b: 0.4282247001937053d, c: 0.659495056495708d),

new NpgsqlTypes.NpgsqlLine(a: 0.2335034105141761d, b: 0.052909961042862275d, c: 0.04122572474287722d),

new NpgsqlTypes.NpgsqlLine(a: 0.5214850980568969d, b: 0.6097853166227842d, c: 0.037564705410715216d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.794741433961441d, b: 0.40948478818553324d, c: 0.8349955153630194d),

new NpgsqlTypes.NpgsqlLine(a: 0.6948645889459438d, b: 0.632857065419259d, c: 0.5039544579972753d),

new NpgsqlTypes.NpgsqlLine(a: 0.08944891276585798d, b: 0.913270540398744d, c: 0.6982865099702906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8541822252456289d, b: 0.7910647286519775d, c: 0.2522573522827649d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(94091086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.756130013480001d, b: 0.8070063086186816d, c: 0.5025767314647364d),

new NpgsqlTypes.NpgsqlLine(a: 0.9364656141137178d, b: 0.4282247001937053d, c: 0.659495056495708d),

new NpgsqlTypes.NpgsqlLine(a: 0.2335034105141761d, b: 0.052909961042862275d, c: 0.04122572474287722d),

new NpgsqlTypes.NpgsqlLine(a: 0.5214850980568969d, b: 0.6097853166227842d, c: 0.037564705410715216d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.794741433961441d, b: 0.40948478818553324d, c: 0.8349955153630194d),

new NpgsqlTypes.NpgsqlLine(a: 0.6948645889459438d, b: 0.632857065419259d, c: 0.5039544579972753d),

new NpgsqlTypes.NpgsqlLine(a: 0.08944891276585798d, b: 0.913270540398744d, c: 0.6982865099702906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8541822252456289d, b: 0.7910647286519775d, c: 0.2522573522827649d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, 1656686707, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08369873952495288d, b: 0.07788317757867735d, c: 0.284112517861248d),

new NpgsqlTypes.NpgsqlLine(a: 0.617171498263342d, b: 0.5865508373972511d, c: 0.36018099841433293d),

new NpgsqlTypes.NpgsqlLine(a: 0.4798021589910493d, b: 0.5378837702166812d, c: 0.2195325878675365d),

new NpgsqlTypes.NpgsqlLine(a: 0.961753857136392d, b: 0.8919192421134503d, c: 0.16540674234160435d),

}, null, 1264360862).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1656686707));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08369873952495288d, b: 0.07788317757867735d, c: 0.284112517861248d),

new NpgsqlTypes.NpgsqlLine(a: 0.617171498263342d, b: 0.5865508373972511d, c: 0.36018099841433293d),

new NpgsqlTypes.NpgsqlLine(a: 0.4798021589910493d, b: 0.5378837702166812d, c: 0.2195325878675365d),

new NpgsqlTypes.NpgsqlLine(a: 0.961753857136392d, b: 0.8919192421134503d, c: 0.16540674234160435d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1264360862));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, 128586765, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7662615462562571d, b: 0.41140775410532837d, c: 0.865079853391942d),

new NpgsqlTypes.NpgsqlLine(a: 0.9304815161900817d, b: 0.6441951572457856d, c: 0.4734484158164034d),

new NpgsqlTypes.NpgsqlLine(a: 0.28545320578356514d, b: 0.7953412500579145d, c: 0.13180882594344d),

new NpgsqlTypes.NpgsqlLine(a: 0.0006534434907554676d, b: 0.7291585410038824d, c: 0.07683170668531758d),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(128586765));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7662615462562571d, b: 0.41140775410532837d, c: 0.865079853391942d),

new NpgsqlTypes.NpgsqlLine(a: 0.9304815161900817d, b: 0.6441951572457856d, c: 0.4734484158164034d),

new NpgsqlTypes.NpgsqlLine(a: 0.28545320578356514d, b: 0.7953412500579145d, c: 0.13180882594344d),

new NpgsqlTypes.NpgsqlLine(a: 0.0006534434907554676d, b: 0.7291585410038824d, c: 0.07683170668531758d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, 896715967, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4784147382307862d, b: 0.6552419336185478d, c: 0.920823919677529d),

new NpgsqlTypes.NpgsqlLine(a: 0.742593437228071d, b: 0.6268935209443758d, c: 0.5071732457335109d),

new NpgsqlTypes.NpgsqlLine(a: 0.6253496198816004d, b: 0.5361783003872929d, c: 0.7158348891331027d),

new NpgsqlTypes.NpgsqlLine(a: 0.4294538215627851d, b: 0.8234156672775046d, c: 0.08688024353682888d),

}, null, 117280179).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(896715967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4784147382307862d, b: 0.6552419336185478d, c: 0.920823919677529d),

new NpgsqlTypes.NpgsqlLine(a: 0.742593437228071d, b: 0.6268935209443758d, c: 0.5071732457335109d),

new NpgsqlTypes.NpgsqlLine(a: 0.6253496198816004d, b: 0.5361783003872929d, c: 0.7158348891331027d),

new NpgsqlTypes.NpgsqlLine(a: 0.4294538215627851d, b: 0.8234156672775046d, c: 0.08688024353682888d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(117280179));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        #endregion

#region Select Models

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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(NpgsqlLinelineArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)
            ),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                )
            ]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineListlineArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(94091086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.756130013480001d, b: 0.8070063086186816d, c: 0.5025767314647364d),

new NpgsqlTypes.NpgsqlLine(a: 0.9364656141137178d, b: 0.4282247001937053d, c: 0.659495056495708d),

new NpgsqlTypes.NpgsqlLine(a: 0.2335034105141761d, b: 0.052909961042862275d, c: 0.04122572474287722d),

new NpgsqlTypes.NpgsqlLine(a: 0.5214850980568969d, b: 0.6097853166227842d, c: 0.037564705410715216d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.794741433961441d, b: 0.40948478818553324d, c: 0.8349955153630194d),

new NpgsqlTypes.NpgsqlLine(a: 0.6948645889459438d, b: 0.632857065419259d, c: 0.5039544579972753d),

new NpgsqlTypes.NpgsqlLine(a: 0.08944891276585798d, b: 0.913270540398744d, c: 0.6982865099702906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8541822252456289d, b: 0.7910647286519775d, c: 0.2522573522827649d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(128586765));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7662615462562571d, b: 0.41140775410532837d, c: 0.865079853391942d),

new NpgsqlTypes.NpgsqlLine(a: 0.9304815161900817d, b: 0.6441951572457856d, c: 0.4734484158164034d),

new NpgsqlTypes.NpgsqlLine(a: 0.28545320578356514d, b: 0.7953412500579145d, c: 0.13180882594344d),

new NpgsqlTypes.NpgsqlLine(a: 0.0006534434907554676d, b: 0.7291585410038824d, c: 0.07683170668531758d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(350174520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23005994787391715d, b: 0.314006898861965d, c: 0.9059890459886075d),

new NpgsqlTypes.NpgsqlLine(a: 0.0034924525333345224d, b: 0.22569705718656508d, c: 0.12293033480738269d),

new NpgsqlTypes.NpgsqlLine(a: 0.13769753447358068d, b: 0.20289930144832358d, c: 0.9141833823361538d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(528252532));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22785571390952986d, b: 0.47384563164287363d, c: 0.7296472935133859d),

new NpgsqlTypes.NpgsqlLine(a: 0.42847852345883053d, b: 0.05295602193643412d, c: 0.7176332323630693d),

new NpgsqlTypes.NpgsqlLine(a: 0.1313916587576558d, b: 0.44047120647606086d, c: 0.4080020542049758d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2023967945));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7526118185907706d, b: 0.7217192659741516d, c: 0.10725515353553927d),

new NpgsqlTypes.NpgsqlLine(a: 0.4123399872860949d, b: 0.9887632111198967d, c: 0.3407478138648996d),

new NpgsqlTypes.NpgsqlLine(a: 0.1972888611598902d, b: 0.21209298014251077d, c: 0.998100482656704d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32204440669620105d, b: 0.40425092983702615d, c: 0.6281187397686202d),

new NpgsqlTypes.NpgsqlLine(a: 0.8736370792109995d, b: 0.8257156419424208d, c: 0.24574228768788875d),

new NpgsqlTypes.NpgsqlLine(a: 0.1777372581271598d, b: 0.02795031420098848d, c: 0.6085263716794568d),

new NpgsqlTypes.NpgsqlLine(a: 0.3937718955623397d, b: 0.3857998777014512d, c: 0.16490107858931902d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(548719832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45120792613918626d, b: 0.7981849131464387d, c: 0.6797001557385036d),

new NpgsqlTypes.NpgsqlLine(a: 0.5152860785682492d, b: 0.05860524276063561d, c: 0.31392693425098706d),

new NpgsqlTypes.NpgsqlLine(a: 0.8399321644879826d, b: 0.14127845073157042d, c: 0.04919268640928787d),

new NpgsqlTypes.NpgsqlLine(a: 0.5367279979863265d, b: 0.9037039524330727d, c: 0.5651736207579545d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(632564420));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9871612756422758d, b: 0.7040000628939183d, c: 0.5741990515908977d),

new NpgsqlTypes.NpgsqlLine(a: 0.8939251170158339d, b: 0.591802460616856d, c: 0.8710953712464558d),

new NpgsqlTypes.NpgsqlLine(a: 0.925765879252592d, b: 0.020003653879282934d, c: 0.27174016206463947d),

new NpgsqlTypes.NpgsqlLine(a: 0.40821497810499396d, b: 0.18426353989680566d, c: 0.35762480728827095d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(569222828));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3541781533895836d, b: 0.8806877333215982d, c: 0.3434395351862555d),

new NpgsqlTypes.NpgsqlLine(a: 0.904182291889472d, b: 0.2725232832902962d, c: 0.11922376175569749d),

new NpgsqlTypes.NpgsqlLine(a: 0.2973949214938665d, b: 0.551548200515303d, c: 0.11510798755200236d),

new NpgsqlTypes.NpgsqlLine(a: 0.6236383027800103d, b: 0.7132402356425214d, c: 0.7946866828405127d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1120533763));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7797869567083358d, b: 0.2361739464389747d, c: 0.48164557546500963d),

new NpgsqlTypes.NpgsqlLine(a: 0.9480048066554808d, b: 0.8035492224666504d, c: 0.9832497213764478d),

new NpgsqlTypes.NpgsqlLine(a: 0.9772596541640088d, b: 0.6093516798517065d, c: 0.6052760903401032d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(617125650));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35787275736319957d, b: 0.702047825867143d, c: 0.965415572167533d),

new NpgsqlTypes.NpgsqlLine(a: 0.31090623461505584d, b: 0.5647177423851781d, c: 0.4846654296503867d),

new NpgsqlTypes.NpgsqlLine(a: 0.3183862992195977d, b: 0.6261458826331173d, c: 0.6907068588712774d),

new NpgsqlTypes.NpgsqlLine(a: 0.6487979418902344d, b: 0.4615179308283234d, c: 0.642127574912425d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9197027266355764d, b: 0.39215058098740485d, c: 0.17261332753094694d),

new NpgsqlTypes.NpgsqlLine(a: 0.11391459246246716d, b: 0.8528811542175645d, c: 0.20274869752530522d),

new NpgsqlTypes.NpgsqlLine(a: 0.36907637605105814d, b: 0.6376511000289307d, c: 0.12998307736849357d),

new NpgsqlTypes.NpgsqlLine(a: 0.9580086581171673d, b: 0.03050170247729178d, c: 0.38029624192446d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1413412459));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42503376733197573d, b: 0.763237079678654d, c: 0.09688502535476584d),

new NpgsqlTypes.NpgsqlLine(a: 0.23240822962655505d, b: 0.8459480271218152d, c: 0.08432931494869422d),

new NpgsqlTypes.NpgsqlLine(a: 0.18886663761414113d, b: 0.5079561486308892d, c: 0.9843388801596968d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(627974170));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15147399565049113d, b: 0.7627100647125816d, c: 0.16010235385722305d),

new NpgsqlTypes.NpgsqlLine(a: 0.9001358065765852d, b: 0.4721890907147458d, c: 0.15927787372271784d),

new NpgsqlTypes.NpgsqlLine(a: 0.7813049144298684d, b: 0.4136335409837938d, c: 0.12660196714031435d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.004236560392559818d, b: 0.39606208609499893d, c: 0.19741769434420997d),

new NpgsqlTypes.NpgsqlLine(a: 0.5953646586031078d, b: 0.6151314480582013d, c: 0.6556527973910132d),

new NpgsqlTypes.NpgsqlLine(a: 0.5407811339876436d, b: 0.9334248245144674d, c: 0.8365874899469636d),

new NpgsqlTypes.NpgsqlLine(a: 0.4764002070454937d, b: 0.16718217080509323d, c: 0.17236129187105342d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(791579102));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3341739254022562d, b: 0.718465753134697d, c: 0.5771634629019262d),

new NpgsqlTypes.NpgsqlLine(a: 0.6322200521292398d, b: 0.8246392866857581d, c: 0.5696079494467468d),

new NpgsqlTypes.NpgsqlLine(a: 0.6545382710133834d, b: 0.4365654599867256d, c: 0.8153585418393168d),

new NpgsqlTypes.NpgsqlLine(a: 0.0910019439659393d, b: 0.7174745892954046d, c: 0.1511089208473413d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1190383178));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12466334172066618d, b: 0.11152073168077081d, c: 0.491230984381532d),

new NpgsqlTypes.NpgsqlLine(a: 0.5547266175262346d, b: 0.13792449594977796d, c: 0.7570674004021489d),

new NpgsqlTypes.NpgsqlLine(a: 0.2085058544453703d, b: 0.08290359377194412d, c: 0.77495272781113d),

new NpgsqlTypes.NpgsqlLine(a: 0.49111506712078934d, b: 0.641116986925848d, c: 0.29516341556351666d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07914996961984966d, b: 0.4871418257809952d, c: 0.7513322508300865d),

new NpgsqlTypes.NpgsqlLine(a: 0.9239635289951339d, b: 0.38794777551433746d, c: 0.676783160212782d),

new NpgsqlTypes.NpgsqlLine(a: 0.0955538255878925d, b: 0.01055236041931451d, c: 0.2842563281409253d),

new NpgsqlTypes.NpgsqlLine(a: 0.02927332855673237d, b: 0.6165842674891228d, c: 0.8012173905302888d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(833599485));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4822973119466689d, b: 0.792513536759573d, c: 0.499633501292873d),

new NpgsqlTypes.NpgsqlLine(a: 0.8918073488512478d, b: 0.42208129985829845d, c: 0.5329638256901381d),

new NpgsqlTypes.NpgsqlLine(a: 0.5188620987187985d, b: 0.1726952436096839d, c: 0.7227459582321649d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15666178016283616d, b: 0.2873368213961791d, c: 0.4420895689102471d),

new NpgsqlTypes.NpgsqlLine(a: 0.4601057867375493d, b: 0.5622721416121373d, c: 0.2999980165807573d),

new NpgsqlTypes.NpgsqlLine(a: 0.8381583831951187d, b: 0.9764919740330239d, c: 0.18152562681640294d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1272632761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8378269016529278d, b: 0.6733240332238696d, c: 0.8919506779863193d),

new NpgsqlTypes.NpgsqlLine(a: 0.48570634731194795d, b: 0.1596671151368555d, c: 0.20750860994967846d),

new NpgsqlTypes.NpgsqlLine(a: 0.779653513645174d, b: 0.8586337096501773d, c: 0.1738735269722934d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2675334980310755d, b: 0.5860654638502302d, c: 0.5223481489931099d),

new NpgsqlTypes.NpgsqlLine(a: 0.2908190505712529d, b: 0.027311571062217044d, c: 0.38897855152716554d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590347289639254d, b: 0.6110078502040162d, c: 0.9773066927065011d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(896715967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4784147382307862d, b: 0.6552419336185478d, c: 0.920823919677529d),

new NpgsqlTypes.NpgsqlLine(a: 0.742593437228071d, b: 0.6268935209443758d, c: 0.5071732457335109d),

new NpgsqlTypes.NpgsqlLine(a: 0.6253496198816004d, b: 0.5361783003872929d, c: 0.7158348891331027d),

new NpgsqlTypes.NpgsqlLine(a: 0.4294538215627851d, b: 0.8234156672775046d, c: 0.08688024353682888d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(117280179));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3605977641294892d, b: 0.17811158147680461d, c: 0.9658058071756186d),

new NpgsqlTypes.NpgsqlLine(a: 0.6970256025820155d, b: 0.5444046414962291d, c: 0.46720686007108925d),

new NpgsqlTypes.NpgsqlLine(a: 0.8561050660597573d, b: 0.11353237597432853d, c: 0.56669941414895d),

new NpgsqlTypes.NpgsqlLine(a: 0.7984600619309864d, b: 0.8109151931011057d, c: 0.769305377302455d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0947306689172811d, b: 0.8302577671800684d, c: 0.8970532400118938d),

new NpgsqlTypes.NpgsqlLine(a: 0.2407748752003226d, b: 0.4567310255560061d, c: 0.4526792803927874d),

new NpgsqlTypes.NpgsqlLine(a: 0.04496104252758981d, b: 0.7589917027634498d, c: 0.6770421060059869d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(899804594));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1970857537444196d, b: 0.9333242638108382d, c: 0.2997924017071659d),

new NpgsqlTypes.NpgsqlLine(a: 0.6311349404614687d, b: 0.19618574736695826d, c: 0.38842914242231885d),

new NpgsqlTypes.NpgsqlLine(a: 0.8616526286116198d, b: 0.5020108677923993d, c: 0.7507796571723376d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8462722154822349d, b: 0.2140170588076531d, c: 0.1555300802445071d),

new NpgsqlTypes.NpgsqlLine(a: 0.05107346767082066d, b: 0.6007632357415391d, c: 0.11568725974145999d),

new NpgsqlTypes.NpgsqlLine(a: 0.9923537289603477d, b: 0.4950249871115745d, c: 0.02343990901364046d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(964637978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7665509369596407d, b: 0.32246651386445413d, c: 0.4163237996846909d),

new NpgsqlTypes.NpgsqlLine(a: 0.622867187513811d, b: 0.02481599358005626d, c: 0.6781914372848628d),

new NpgsqlTypes.NpgsqlLine(a: 0.9383962517038102d, b: 0.22799617371669267d, c: 0.11769282658114588d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1006841713));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3814391347607825d, b: 0.6500010795000312d, c: 0.5168910912789877d),

new NpgsqlTypes.NpgsqlLine(a: 0.9809725325416359d, b: 0.5965089551877092d, c: 0.9620206915411497d),

new NpgsqlTypes.NpgsqlLine(a: 0.8326177257415529d, b: 0.9726427466112844d, c: 0.44743910631138517d),

new NpgsqlTypes.NpgsqlLine(a: 0.9428905413649304d, b: 0.2742783552238923d, c: 0.20624247958140818d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4156588878635493d, b: 0.9311562710078888d, c: 0.18729745760128813d),

new NpgsqlTypes.NpgsqlLine(a: 0.7838364754377413d, b: 0.2902143764264882d, c: 0.6468999105347263d),

new NpgsqlTypes.NpgsqlLine(a: 0.2807400125401047d, b: 0.4738433713063067d, c: 0.3414032292061351d),

new NpgsqlTypes.NpgsqlLine(a: 0.07976939589399212d, b: 0.6817427263698487d, c: 0.7162950229594492d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1008288557));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6703103585772012d, b: 0.9414469448287122d, c: 0.32961805156524826d),

new NpgsqlTypes.NpgsqlLine(a: 0.13239408457631574d, b: 0.5134528929025426d, c: 0.5412589816963953d),

new NpgsqlTypes.NpgsqlLine(a: 0.1699098825091695d, b: 0.9194545880639252d, c: 0.7451240040858685d),

new NpgsqlTypes.NpgsqlLine(a: 0.2233903417330374d, b: 0.07771599830861675d, c: 0.5752102020647447d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(723640790));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8545769023218451d, b: 0.24286566112974062d, c: 0.24373271509232275d),

new NpgsqlTypes.NpgsqlLine(a: 0.8731571462637403d, b: 0.9993617334238951d, c: 0.1725755360195571d),

new NpgsqlTypes.NpgsqlLine(a: 0.2467482163165423d, b: 0.7309207508122816d, c: 0.574326589073651d),

new NpgsqlTypes.NpgsqlLine(a: 0.39429370255535745d, b: 0.12918013405283635d, c: 0.37279548432778786d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8697103680615146d, b: 0.4868697197066526d, c: 0.008300202872866591d),

new NpgsqlTypes.NpgsqlLine(a: 0.9268152455195247d, b: 0.9945415027788427d, c: 0.33225561051564245d),

new NpgsqlTypes.NpgsqlLine(a: 0.06541514412119742d, b: 0.29832372565206444d, c: 0.34837671529944225d),

new NpgsqlTypes.NpgsqlLine(a: 0.7703107306167513d, b: 0.39150187650435253d, c: 0.17912768771478083d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1212970907));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5991478813435879d, b: 0.21696546349723422d, c: 0.7473704822066682d),

new NpgsqlTypes.NpgsqlLine(a: 0.151066097236479d, b: 0.0802844223551269d, c: 0.09162465810768494d),

new NpgsqlTypes.NpgsqlLine(a: 0.8623052986382002d, b: 0.9298840839917386d, c: 0.6660510239194597d),

new NpgsqlTypes.NpgsqlLine(a: 0.9991351159913222d, b: 0.029361445428178645d, c: 0.30760770391653036d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2140414751));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5666355568463651d, b: 0.5532657932652175d, c: 0.043303548850170626d),

new NpgsqlTypes.NpgsqlLine(a: 0.4900959494886681d, b: 0.9349750472343457d, c: 0.4121355471301291d),

new NpgsqlTypes.NpgsqlLine(a: 0.06398838318692368d, b: 0.028285739863693204d, c: 0.8052480125394759d),

new NpgsqlTypes.NpgsqlLine(a: 0.31673961185856914d, b: 0.4141587759463713d, c: 0.1893488396111126d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1370558129));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9082169806472872d, b: 0.9235120225757552d, c: 0.8994934710072177d),

new NpgsqlTypes.NpgsqlLine(a: 0.12419478532476513d, b: 0.805126203795883d, c: 0.21123699569220133d),

new NpgsqlTypes.NpgsqlLine(a: 0.5518835410640954d, b: 0.3470463651950829d, c: 0.4121461426388031d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(196308953));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28578713252269017d, b: 0.8474368218362299d, c: 0.05146566977408318d),

new NpgsqlTypes.NpgsqlLine(a: 0.9109299616024349d, b: 0.5870141058904383d, c: 0.7452912896149598d),

new NpgsqlTypes.NpgsqlLine(a: 0.09671303857190205d, b: 0.22234046410281205d, c: 0.2889776640209598d),

new NpgsqlTypes.NpgsqlLine(a: 0.3594930797393622d, b: 0.1261117062789614d, c: 0.4836691385976134d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1411554384));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.43292849531653743d, b: 0.10139772092942057d, c: 0.19581477698464556d),

new NpgsqlTypes.NpgsqlLine(a: 0.7747830082073887d, b: 0.7612727046736724d, c: 0.49585407932443326d),

new NpgsqlTypes.NpgsqlLine(a: 0.7534769161594925d, b: 0.21640631521439513d, c: 0.9417215429915208d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1423267657));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7028157888188539d, b: 0.4434497177574276d, c: 0.1878584904244096d),

new NpgsqlTypes.NpgsqlLine(a: 0.12779644786129707d, b: 0.6547737034235738d, c: 0.7340324477099678d),

new NpgsqlTypes.NpgsqlLine(a: 0.13473852180731738d, b: 0.7900921279332365d, c: 0.7695417103969711d),

new NpgsqlTypes.NpgsqlLine(a: 0.2618677281295215d, b: 0.24821010444457137d, c: 0.2711393719015588d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1610745034));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6382266935775643d, b: 0.398693329671132d, c: 0.7425094436899613d),

new NpgsqlTypes.NpgsqlLine(a: 0.24327741116998813d, b: 0.1635267687203752d, c: 0.628031718062037d),

new NpgsqlTypes.NpgsqlLine(a: 0.38459544322295613d, b: 0.4141132804519537d, c: 0.8511486540491503d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9861241662988156d, b: 0.25399030999510996d, c: 0.2529918964264557d),

new NpgsqlTypes.NpgsqlLine(a: 0.17574090331875702d, b: 0.5215697754670754d, c: 0.49092403723555744d),

new NpgsqlTypes.NpgsqlLine(a: 0.9755215010138426d, b: 0.5836706698542481d, c: 0.8112425273051307d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1525343338));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5334739519154116d, b: 0.14533927203574382d, c: 0.9972375896646379d),

new NpgsqlTypes.NpgsqlLine(a: 0.5376404385911305d, b: 0.3967355325520928d, c: 0.2690585850054501d),

new NpgsqlTypes.NpgsqlLine(a: 0.7930288640515465d, b: 0.4034090749439643d, c: 0.19977351395319798d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22585130451050572d, b: 0.054454055462575424d, c: 0.3670135684186787d),

new NpgsqlTypes.NpgsqlLine(a: 0.8573417118252535d, b: 0.7290365889192361d, c: 0.15771025911629288d),

new NpgsqlTypes.NpgsqlLine(a: 0.8294206137900973d, b: 0.778292553399524d, c: 0.5844131999897239d),

new NpgsqlTypes.NpgsqlLine(a: 0.8795242286168519d, b: 0.43336364459496624d, c: 0.07939237473054006d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1618779845));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588222459861263d, b: 0.8314528851615401d, c: 0.4091425195520225d),

new NpgsqlTypes.NpgsqlLine(a: 0.15497545879234587d, b: 0.42501177297812087d, c: 0.3930386900482442d),

new NpgsqlTypes.NpgsqlLine(a: 0.49932759733861587d, b: 0.27860846401633954d, c: 0.22371479209453393d),

new NpgsqlTypes.NpgsqlLine(a: 0.6744750487770321d, b: 0.5185555306309229d, c: 0.48333909912156325d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6846715107366038d, b: 0.7822398219668835d, c: 0.6995656002724597d),

new NpgsqlTypes.NpgsqlLine(a: 0.34191163697506577d, b: 0.251427920689659d, c: 0.6372400180339429d),

new NpgsqlTypes.NpgsqlLine(a: 0.7615638356664386d, b: 0.38275705185682163d, c: 0.9430695395246483d),

new NpgsqlTypes.NpgsqlLine(a: 0.25861736938688795d, b: 0.2236086093911689d, c: 0.43081968027669826d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(111191550));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10079392481388938d, b: 0.47419284524344363d, c: 0.46999813598135487d),

new NpgsqlTypes.NpgsqlLine(a: 0.4512330545433114d, b: 0.7685777654216315d, c: 0.761484461621478d),

new NpgsqlTypes.NpgsqlLine(a: 0.7069502335832981d, b: 0.10867536284292001d, c: 0.803973548621565d),

new NpgsqlTypes.NpgsqlLine(a: 0.6710482193897285d, b: 0.3246300803211939d, c: 0.007931088387647223d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1651600176));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16882852097245493d, b: 0.6320810387310721d, c: 0.4943119337666173d),

new NpgsqlTypes.NpgsqlLine(a: 0.1864608664190791d, b: 0.3923939341785333d, c: 0.40778672849944797d),

new NpgsqlTypes.NpgsqlLine(a: 0.21658079009283382d, b: 0.9735580473103661d, c: 0.5313780798893142d),

new NpgsqlTypes.NpgsqlLine(a: 0.608447080933292d, b: 0.9095061095638245d, c: 0.664417030599092d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1656686707));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08369873952495288d, b: 0.07788317757867735d, c: 0.284112517861248d),

new NpgsqlTypes.NpgsqlLine(a: 0.617171498263342d, b: 0.5865508373972511d, c: 0.36018099841433293d),

new NpgsqlTypes.NpgsqlLine(a: 0.4798021589910493d, b: 0.5378837702166812d, c: 0.2195325878675365d),

new NpgsqlTypes.NpgsqlLine(a: 0.961753857136392d, b: 0.8919192421134503d, c: 0.16540674234160435d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1264360862));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3150738269575506d, b: 0.25723902915678687d, c: 0.7085220942560913d),

new NpgsqlTypes.NpgsqlLine(a: 0.10217399526832571d, b: 0.23606907248025677d, c: 0.14832581681823231d),

new NpgsqlTypes.NpgsqlLine(a: 0.38475783269574504d, b: 0.261674953378639d, c: 0.8414017715374641d),

new NpgsqlTypes.NpgsqlLine(a: 0.060969244577031345d, b: 0.7001282741779633d, c: 0.8180532031964253d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1800975967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6019711101236188d, b: 0.451502314152629d, c: 0.7567258646896037d),

new NpgsqlTypes.NpgsqlLine(a: 0.20314867633928102d, b: 0.43694052621738755d, c: 0.07972430095228344d),

new NpgsqlTypes.NpgsqlLine(a: 0.38639176328531444d, b: 0.5546727142910798d, c: 0.3595107666863845d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(116492752));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8534388679989421d, b: 0.17051639981163313d, c: 0.11184373953100968d),

new NpgsqlTypes.NpgsqlLine(a: 0.5545649696933802d, b: 0.6495249060333349d, c: 0.14480165352840013d),

new NpgsqlTypes.NpgsqlLine(a: 0.7068689700072772d, b: 0.10325704725403717d, c: 0.1383403540154834d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.565937691937727d, b: 0.8643068916219007d, c: 0.7899347881580714d),

new NpgsqlTypes.NpgsqlLine(a: 0.5461437063589625d, b: 0.8396992488239946d, c: 0.4549808859483121d),

new NpgsqlTypes.NpgsqlLine(a: 0.11142572920429805d, b: 0.7092154686109046d, c: 0.04531658445440445d),

new NpgsqlTypes.NpgsqlLine(a: 0.8590566964589479d, b: 0.07365357454587718d, c: 0.01783865983951749d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858289195));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25032438445726d, b: 0.0917391846373673d, c: 0.34066051809002806d),

new NpgsqlTypes.NpgsqlLine(a: 0.07831144663304057d, b: 0.77591037387439d, c: 0.19759580235224372d),

new NpgsqlTypes.NpgsqlLine(a: 0.3752205191956137d, b: 0.9100313386910368d, c: 0.6525871812195568d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47106408656007914d, b: 0.14257658261320605d, c: 0.47373760961489964d),

new NpgsqlTypes.NpgsqlLine(a: 0.4366806562773925d, b: 0.20146202051894901d, c: 0.3244113712884158d),

new NpgsqlTypes.NpgsqlLine(a: 0.41468311552317627d, b: 0.27557991533085235d, c: 0.7788691278257713d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1908397739));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36399675452528046d, b: 0.21180965313124933d, c: 0.6232643186817026d),

new NpgsqlTypes.NpgsqlLine(a: 0.8377534917307251d, b: 0.7197248111141329d, c: 0.5638759891270843d),

new NpgsqlTypes.NpgsqlLine(a: 0.9127913721936561d, b: 0.47658260676426356d, c: 0.4401534500107992d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.502181779437056d, b: 0.3652805047459293d, c: 0.32001644451474576d),

new NpgsqlTypes.NpgsqlLine(a: 0.7113651445912559d, b: 0.3869191031273206d, c: 0.7332400621535746d),

new NpgsqlTypes.NpgsqlLine(a: 0.5302147002696467d, b: 0.6514960201183412d, c: 0.8888784836070758d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1921152006));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3706659351474607d, b: 0.20392121211971403d, c: 0.09026673921559647d),

new NpgsqlTypes.NpgsqlLine(a: 0.3426907809834573d, b: 0.11597889224231583d, c: 0.37580383029156417d),

new NpgsqlTypes.NpgsqlLine(a: 0.9569454063294334d, b: 0.5352074925592666d, c: 0.1505041653825815d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(322154126));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17316937563192347d, b: 0.7977878569807266d, c: 0.5061623155222499d),

new NpgsqlTypes.NpgsqlLine(a: 0.39020299771548206d, b: 0.46872469438895703d, c: 0.1947250961658502d),

new NpgsqlTypes.NpgsqlLine(a: 0.9460666899443665d, b: 0.40873002207057996d, c: 0.5383135596603867d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931477721));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24029930494024243d, b: 0.6494520983530296d, c: 0.6457904476196421d),

new NpgsqlTypes.NpgsqlLine(a: 0.5413106581652064d, b: 0.65922568011039d, c: 0.023000101756869618d),

new NpgsqlTypes.NpgsqlLine(a: 0.05698461456670889d, b: 0.07946838244893384d, c: 0.023133320459978735d),

new NpgsqlTypes.NpgsqlLine(a: 0.023417572430763367d, b: 0.20022755743974863d, c: 0.9001563624157146d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3818728397283605d, b: 0.24081372003152057d, c: 0.42604600108359325d),

new NpgsqlTypes.NpgsqlLine(a: 0.9919565701428744d, b: 0.9836921588174795d, c: 0.6353618672799166d),

new NpgsqlTypes.NpgsqlLine(a: 0.49779514301225014d, b: 0.9235637976007209d, c: 0.26480996790155775d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943853869));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5132420668035784d, b: 0.9613252483783701d, c: 0.9242449431625296d),

new NpgsqlTypes.NpgsqlLine(a: 0.36653456446188004d, b: 0.7359631901409467d, c: 0.27792441954855884d),

new NpgsqlTypes.NpgsqlLine(a: 0.4636783251093567d, b: 0.1186591604974756d, c: 0.39388519565520497d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1951774404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4334255210533513d, b: 0.5785255926410576d, c: 0.9661508534687067d),

new NpgsqlTypes.NpgsqlLine(a: 0.19775236418153797d, b: 0.9365672085879589d, c: 0.1494826860380959d),

new NpgsqlTypes.NpgsqlLine(a: 0.176207462329397d, b: 0.2629253672101627d, c: 0.07007543599573873d),

new NpgsqlTypes.NpgsqlLine(a: 0.12818842182277845d, b: 0.1863366614728862d, c: 0.7134229928630377d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6151166351904711d, b: 0.2498835420322547d, c: 0.9733560033126378d),

new NpgsqlTypes.NpgsqlLine(a: 0.7516653963992566d, b: 0.8871254006140514d, c: 0.9688544000775576d),

new NpgsqlTypes.NpgsqlLine(a: 0.5920030979667459d, b: 0.19764908877922582d, c: 0.5631519149614208d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(94091086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.756130013480001d, b: 0.8070063086186816d, c: 0.5025767314647364d),

new NpgsqlTypes.NpgsqlLine(a: 0.9364656141137178d, b: 0.4282247001937053d, c: 0.659495056495708d),

new NpgsqlTypes.NpgsqlLine(a: 0.2335034105141761d, b: 0.052909961042862275d, c: 0.04122572474287722d),

new NpgsqlTypes.NpgsqlLine(a: 0.5214850980568969d, b: 0.6097853166227842d, c: 0.037564705410715216d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.794741433961441d, b: 0.40948478818553324d, c: 0.8349955153630194d),

new NpgsqlTypes.NpgsqlLine(a: 0.6948645889459438d, b: 0.632857065419259d, c: 0.5039544579972753d),

new NpgsqlTypes.NpgsqlLine(a: 0.08944891276585798d, b: 0.913270540398744d, c: 0.6982865099702906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8541822252456289d, b: 0.7910647286519775d, c: 0.2522573522827649d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(128586765));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7662615462562571d, b: 0.41140775410532837d, c: 0.865079853391942d),

new NpgsqlTypes.NpgsqlLine(a: 0.9304815161900817d, b: 0.6441951572457856d, c: 0.4734484158164034d),

new NpgsqlTypes.NpgsqlLine(a: 0.28545320578356514d, b: 0.7953412500579145d, c: 0.13180882594344d),

new NpgsqlTypes.NpgsqlLine(a: 0.0006534434907554676d, b: 0.7291585410038824d, c: 0.07683170668531758d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(350174520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23005994787391715d, b: 0.314006898861965d, c: 0.9059890459886075d),

new NpgsqlTypes.NpgsqlLine(a: 0.0034924525333345224d, b: 0.22569705718656508d, c: 0.12293033480738269d),

new NpgsqlTypes.NpgsqlLine(a: 0.13769753447358068d, b: 0.20289930144832358d, c: 0.9141833823361538d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(528252532));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22785571390952986d, b: 0.47384563164287363d, c: 0.7296472935133859d),

new NpgsqlTypes.NpgsqlLine(a: 0.42847852345883053d, b: 0.05295602193643412d, c: 0.7176332323630693d),

new NpgsqlTypes.NpgsqlLine(a: 0.1313916587576558d, b: 0.44047120647606086d, c: 0.4080020542049758d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2023967945));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7526118185907706d, b: 0.7217192659741516d, c: 0.10725515353553927d),

new NpgsqlTypes.NpgsqlLine(a: 0.4123399872860949d, b: 0.9887632111198967d, c: 0.3407478138648996d),

new NpgsqlTypes.NpgsqlLine(a: 0.1972888611598902d, b: 0.21209298014251077d, c: 0.998100482656704d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32204440669620105d, b: 0.40425092983702615d, c: 0.6281187397686202d),

new NpgsqlTypes.NpgsqlLine(a: 0.8736370792109995d, b: 0.8257156419424208d, c: 0.24574228768788875d),

new NpgsqlTypes.NpgsqlLine(a: 0.1777372581271598d, b: 0.02795031420098848d, c: 0.6085263716794568d),

new NpgsqlTypes.NpgsqlLine(a: 0.3937718955623397d, b: 0.3857998777014512d, c: 0.16490107858931902d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(548719832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45120792613918626d, b: 0.7981849131464387d, c: 0.6797001557385036d),

new NpgsqlTypes.NpgsqlLine(a: 0.5152860785682492d, b: 0.05860524276063561d, c: 0.31392693425098706d),

new NpgsqlTypes.NpgsqlLine(a: 0.8399321644879826d, b: 0.14127845073157042d, c: 0.04919268640928787d),

new NpgsqlTypes.NpgsqlLine(a: 0.5367279979863265d, b: 0.9037039524330727d, c: 0.5651736207579545d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(632564420));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9871612756422758d, b: 0.7040000628939183d, c: 0.5741990515908977d),

new NpgsqlTypes.NpgsqlLine(a: 0.8939251170158339d, b: 0.591802460616856d, c: 0.8710953712464558d),

new NpgsqlTypes.NpgsqlLine(a: 0.925765879252592d, b: 0.020003653879282934d, c: 0.27174016206463947d),

new NpgsqlTypes.NpgsqlLine(a: 0.40821497810499396d, b: 0.18426353989680566d, c: 0.35762480728827095d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(569222828));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3541781533895836d, b: 0.8806877333215982d, c: 0.3434395351862555d),

new NpgsqlTypes.NpgsqlLine(a: 0.904182291889472d, b: 0.2725232832902962d, c: 0.11922376175569749d),

new NpgsqlTypes.NpgsqlLine(a: 0.2973949214938665d, b: 0.551548200515303d, c: 0.11510798755200236d),

new NpgsqlTypes.NpgsqlLine(a: 0.6236383027800103d, b: 0.7132402356425214d, c: 0.7946866828405127d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1120533763));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7797869567083358d, b: 0.2361739464389747d, c: 0.48164557546500963d),

new NpgsqlTypes.NpgsqlLine(a: 0.9480048066554808d, b: 0.8035492224666504d, c: 0.9832497213764478d),

new NpgsqlTypes.NpgsqlLine(a: 0.9772596541640088d, b: 0.6093516798517065d, c: 0.6052760903401032d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(617125650));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35787275736319957d, b: 0.702047825867143d, c: 0.965415572167533d),

new NpgsqlTypes.NpgsqlLine(a: 0.31090623461505584d, b: 0.5647177423851781d, c: 0.4846654296503867d),

new NpgsqlTypes.NpgsqlLine(a: 0.3183862992195977d, b: 0.6261458826331173d, c: 0.6907068588712774d),

new NpgsqlTypes.NpgsqlLine(a: 0.6487979418902344d, b: 0.4615179308283234d, c: 0.642127574912425d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9197027266355764d, b: 0.39215058098740485d, c: 0.17261332753094694d),

new NpgsqlTypes.NpgsqlLine(a: 0.11391459246246716d, b: 0.8528811542175645d, c: 0.20274869752530522d),

new NpgsqlTypes.NpgsqlLine(a: 0.36907637605105814d, b: 0.6376511000289307d, c: 0.12998307736849357d),

new NpgsqlTypes.NpgsqlLine(a: 0.9580086581171673d, b: 0.03050170247729178d, c: 0.38029624192446d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1413412459));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42503376733197573d, b: 0.763237079678654d, c: 0.09688502535476584d),

new NpgsqlTypes.NpgsqlLine(a: 0.23240822962655505d, b: 0.8459480271218152d, c: 0.08432931494869422d),

new NpgsqlTypes.NpgsqlLine(a: 0.18886663761414113d, b: 0.5079561486308892d, c: 0.9843388801596968d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(627974170));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15147399565049113d, b: 0.7627100647125816d, c: 0.16010235385722305d),

new NpgsqlTypes.NpgsqlLine(a: 0.9001358065765852d, b: 0.4721890907147458d, c: 0.15927787372271784d),

new NpgsqlTypes.NpgsqlLine(a: 0.7813049144298684d, b: 0.4136335409837938d, c: 0.12660196714031435d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.004236560392559818d, b: 0.39606208609499893d, c: 0.19741769434420997d),

new NpgsqlTypes.NpgsqlLine(a: 0.5953646586031078d, b: 0.6151314480582013d, c: 0.6556527973910132d),

new NpgsqlTypes.NpgsqlLine(a: 0.5407811339876436d, b: 0.9334248245144674d, c: 0.8365874899469636d),

new NpgsqlTypes.NpgsqlLine(a: 0.4764002070454937d, b: 0.16718217080509323d, c: 0.17236129187105342d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(791579102));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3341739254022562d, b: 0.718465753134697d, c: 0.5771634629019262d),

new NpgsqlTypes.NpgsqlLine(a: 0.6322200521292398d, b: 0.8246392866857581d, c: 0.5696079494467468d),

new NpgsqlTypes.NpgsqlLine(a: 0.6545382710133834d, b: 0.4365654599867256d, c: 0.8153585418393168d),

new NpgsqlTypes.NpgsqlLine(a: 0.0910019439659393d, b: 0.7174745892954046d, c: 0.1511089208473413d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1190383178));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12466334172066618d, b: 0.11152073168077081d, c: 0.491230984381532d),

new NpgsqlTypes.NpgsqlLine(a: 0.5547266175262346d, b: 0.13792449594977796d, c: 0.7570674004021489d),

new NpgsqlTypes.NpgsqlLine(a: 0.2085058544453703d, b: 0.08290359377194412d, c: 0.77495272781113d),

new NpgsqlTypes.NpgsqlLine(a: 0.49111506712078934d, b: 0.641116986925848d, c: 0.29516341556351666d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07914996961984966d, b: 0.4871418257809952d, c: 0.7513322508300865d),

new NpgsqlTypes.NpgsqlLine(a: 0.9239635289951339d, b: 0.38794777551433746d, c: 0.676783160212782d),

new NpgsqlTypes.NpgsqlLine(a: 0.0955538255878925d, b: 0.01055236041931451d, c: 0.2842563281409253d),

new NpgsqlTypes.NpgsqlLine(a: 0.02927332855673237d, b: 0.6165842674891228d, c: 0.8012173905302888d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(833599485));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4822973119466689d, b: 0.792513536759573d, c: 0.499633501292873d),

new NpgsqlTypes.NpgsqlLine(a: 0.8918073488512478d, b: 0.42208129985829845d, c: 0.5329638256901381d),

new NpgsqlTypes.NpgsqlLine(a: 0.5188620987187985d, b: 0.1726952436096839d, c: 0.7227459582321649d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15666178016283616d, b: 0.2873368213961791d, c: 0.4420895689102471d),

new NpgsqlTypes.NpgsqlLine(a: 0.4601057867375493d, b: 0.5622721416121373d, c: 0.2999980165807573d),

new NpgsqlTypes.NpgsqlLine(a: 0.8381583831951187d, b: 0.9764919740330239d, c: 0.18152562681640294d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1272632761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8378269016529278d, b: 0.6733240332238696d, c: 0.8919506779863193d),

new NpgsqlTypes.NpgsqlLine(a: 0.48570634731194795d, b: 0.1596671151368555d, c: 0.20750860994967846d),

new NpgsqlTypes.NpgsqlLine(a: 0.779653513645174d, b: 0.8586337096501773d, c: 0.1738735269722934d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2675334980310755d, b: 0.5860654638502302d, c: 0.5223481489931099d),

new NpgsqlTypes.NpgsqlLine(a: 0.2908190505712529d, b: 0.027311571062217044d, c: 0.38897855152716554d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590347289639254d, b: 0.6110078502040162d, c: 0.9773066927065011d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(896715967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4784147382307862d, b: 0.6552419336185478d, c: 0.920823919677529d),

new NpgsqlTypes.NpgsqlLine(a: 0.742593437228071d, b: 0.6268935209443758d, c: 0.5071732457335109d),

new NpgsqlTypes.NpgsqlLine(a: 0.6253496198816004d, b: 0.5361783003872929d, c: 0.7158348891331027d),

new NpgsqlTypes.NpgsqlLine(a: 0.4294538215627851d, b: 0.8234156672775046d, c: 0.08688024353682888d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(117280179));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3605977641294892d, b: 0.17811158147680461d, c: 0.9658058071756186d),

new NpgsqlTypes.NpgsqlLine(a: 0.6970256025820155d, b: 0.5444046414962291d, c: 0.46720686007108925d),

new NpgsqlTypes.NpgsqlLine(a: 0.8561050660597573d, b: 0.11353237597432853d, c: 0.56669941414895d),

new NpgsqlTypes.NpgsqlLine(a: 0.7984600619309864d, b: 0.8109151931011057d, c: 0.769305377302455d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0947306689172811d, b: 0.8302577671800684d, c: 0.8970532400118938d),

new NpgsqlTypes.NpgsqlLine(a: 0.2407748752003226d, b: 0.4567310255560061d, c: 0.4526792803927874d),

new NpgsqlTypes.NpgsqlLine(a: 0.04496104252758981d, b: 0.7589917027634498d, c: 0.6770421060059869d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(899804594));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1970857537444196d, b: 0.9333242638108382d, c: 0.2997924017071659d),

new NpgsqlTypes.NpgsqlLine(a: 0.6311349404614687d, b: 0.19618574736695826d, c: 0.38842914242231885d),

new NpgsqlTypes.NpgsqlLine(a: 0.8616526286116198d, b: 0.5020108677923993d, c: 0.7507796571723376d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8462722154822349d, b: 0.2140170588076531d, c: 0.1555300802445071d),

new NpgsqlTypes.NpgsqlLine(a: 0.05107346767082066d, b: 0.6007632357415391d, c: 0.11568725974145999d),

new NpgsqlTypes.NpgsqlLine(a: 0.9923537289603477d, b: 0.4950249871115745d, c: 0.02343990901364046d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(964637978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7665509369596407d, b: 0.32246651386445413d, c: 0.4163237996846909d),

new NpgsqlTypes.NpgsqlLine(a: 0.622867187513811d, b: 0.02481599358005626d, c: 0.6781914372848628d),

new NpgsqlTypes.NpgsqlLine(a: 0.9383962517038102d, b: 0.22799617371669267d, c: 0.11769282658114588d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1006841713));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3814391347607825d, b: 0.6500010795000312d, c: 0.5168910912789877d),

new NpgsqlTypes.NpgsqlLine(a: 0.9809725325416359d, b: 0.5965089551877092d, c: 0.9620206915411497d),

new NpgsqlTypes.NpgsqlLine(a: 0.8326177257415529d, b: 0.9726427466112844d, c: 0.44743910631138517d),

new NpgsqlTypes.NpgsqlLine(a: 0.9428905413649304d, b: 0.2742783552238923d, c: 0.20624247958140818d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4156588878635493d, b: 0.9311562710078888d, c: 0.18729745760128813d),

new NpgsqlTypes.NpgsqlLine(a: 0.7838364754377413d, b: 0.2902143764264882d, c: 0.6468999105347263d),

new NpgsqlTypes.NpgsqlLine(a: 0.2807400125401047d, b: 0.4738433713063067d, c: 0.3414032292061351d),

new NpgsqlTypes.NpgsqlLine(a: 0.07976939589399212d, b: 0.6817427263698487d, c: 0.7162950229594492d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1008288557));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6703103585772012d, b: 0.9414469448287122d, c: 0.32961805156524826d),

new NpgsqlTypes.NpgsqlLine(a: 0.13239408457631574d, b: 0.5134528929025426d, c: 0.5412589816963953d),

new NpgsqlTypes.NpgsqlLine(a: 0.1699098825091695d, b: 0.9194545880639252d, c: 0.7451240040858685d),

new NpgsqlTypes.NpgsqlLine(a: 0.2233903417330374d, b: 0.07771599830861675d, c: 0.5752102020647447d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(723640790));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8545769023218451d, b: 0.24286566112974062d, c: 0.24373271509232275d),

new NpgsqlTypes.NpgsqlLine(a: 0.8731571462637403d, b: 0.9993617334238951d, c: 0.1725755360195571d),

new NpgsqlTypes.NpgsqlLine(a: 0.2467482163165423d, b: 0.7309207508122816d, c: 0.574326589073651d),

new NpgsqlTypes.NpgsqlLine(a: 0.39429370255535745d, b: 0.12918013405283635d, c: 0.37279548432778786d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8697103680615146d, b: 0.4868697197066526d, c: 0.008300202872866591d),

new NpgsqlTypes.NpgsqlLine(a: 0.9268152455195247d, b: 0.9945415027788427d, c: 0.33225561051564245d),

new NpgsqlTypes.NpgsqlLine(a: 0.06541514412119742d, b: 0.29832372565206444d, c: 0.34837671529944225d),

new NpgsqlTypes.NpgsqlLine(a: 0.7703107306167513d, b: 0.39150187650435253d, c: 0.17912768771478083d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1212970907));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5991478813435879d, b: 0.21696546349723422d, c: 0.7473704822066682d),

new NpgsqlTypes.NpgsqlLine(a: 0.151066097236479d, b: 0.0802844223551269d, c: 0.09162465810768494d),

new NpgsqlTypes.NpgsqlLine(a: 0.8623052986382002d, b: 0.9298840839917386d, c: 0.6660510239194597d),

new NpgsqlTypes.NpgsqlLine(a: 0.9991351159913222d, b: 0.029361445428178645d, c: 0.30760770391653036d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2140414751));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5666355568463651d, b: 0.5532657932652175d, c: 0.043303548850170626d),

new NpgsqlTypes.NpgsqlLine(a: 0.4900959494886681d, b: 0.9349750472343457d, c: 0.4121355471301291d),

new NpgsqlTypes.NpgsqlLine(a: 0.06398838318692368d, b: 0.028285739863693204d, c: 0.8052480125394759d),

new NpgsqlTypes.NpgsqlLine(a: 0.31673961185856914d, b: 0.4141587759463713d, c: 0.1893488396111126d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1370558129));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9082169806472872d, b: 0.9235120225757552d, c: 0.8994934710072177d),

new NpgsqlTypes.NpgsqlLine(a: 0.12419478532476513d, b: 0.805126203795883d, c: 0.21123699569220133d),

new NpgsqlTypes.NpgsqlLine(a: 0.5518835410640954d, b: 0.3470463651950829d, c: 0.4121461426388031d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(196308953));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28578713252269017d, b: 0.8474368218362299d, c: 0.05146566977408318d),

new NpgsqlTypes.NpgsqlLine(a: 0.9109299616024349d, b: 0.5870141058904383d, c: 0.7452912896149598d),

new NpgsqlTypes.NpgsqlLine(a: 0.09671303857190205d, b: 0.22234046410281205d, c: 0.2889776640209598d),

new NpgsqlTypes.NpgsqlLine(a: 0.3594930797393622d, b: 0.1261117062789614d, c: 0.4836691385976134d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1411554384));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.43292849531653743d, b: 0.10139772092942057d, c: 0.19581477698464556d),

new NpgsqlTypes.NpgsqlLine(a: 0.7747830082073887d, b: 0.7612727046736724d, c: 0.49585407932443326d),

new NpgsqlTypes.NpgsqlLine(a: 0.7534769161594925d, b: 0.21640631521439513d, c: 0.9417215429915208d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1423267657));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7028157888188539d, b: 0.4434497177574276d, c: 0.1878584904244096d),

new NpgsqlTypes.NpgsqlLine(a: 0.12779644786129707d, b: 0.6547737034235738d, c: 0.7340324477099678d),

new NpgsqlTypes.NpgsqlLine(a: 0.13473852180731738d, b: 0.7900921279332365d, c: 0.7695417103969711d),

new NpgsqlTypes.NpgsqlLine(a: 0.2618677281295215d, b: 0.24821010444457137d, c: 0.2711393719015588d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1610745034));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6382266935775643d, b: 0.398693329671132d, c: 0.7425094436899613d),

new NpgsqlTypes.NpgsqlLine(a: 0.24327741116998813d, b: 0.1635267687203752d, c: 0.628031718062037d),

new NpgsqlTypes.NpgsqlLine(a: 0.38459544322295613d, b: 0.4141132804519537d, c: 0.8511486540491503d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9861241662988156d, b: 0.25399030999510996d, c: 0.2529918964264557d),

new NpgsqlTypes.NpgsqlLine(a: 0.17574090331875702d, b: 0.5215697754670754d, c: 0.49092403723555744d),

new NpgsqlTypes.NpgsqlLine(a: 0.9755215010138426d, b: 0.5836706698542481d, c: 0.8112425273051307d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1525343338));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5334739519154116d, b: 0.14533927203574382d, c: 0.9972375896646379d),

new NpgsqlTypes.NpgsqlLine(a: 0.5376404385911305d, b: 0.3967355325520928d, c: 0.2690585850054501d),

new NpgsqlTypes.NpgsqlLine(a: 0.7930288640515465d, b: 0.4034090749439643d, c: 0.19977351395319798d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22585130451050572d, b: 0.054454055462575424d, c: 0.3670135684186787d),

new NpgsqlTypes.NpgsqlLine(a: 0.8573417118252535d, b: 0.7290365889192361d, c: 0.15771025911629288d),

new NpgsqlTypes.NpgsqlLine(a: 0.8294206137900973d, b: 0.778292553399524d, c: 0.5844131999897239d),

new NpgsqlTypes.NpgsqlLine(a: 0.8795242286168519d, b: 0.43336364459496624d, c: 0.07939237473054006d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1618779845));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588222459861263d, b: 0.8314528851615401d, c: 0.4091425195520225d),

new NpgsqlTypes.NpgsqlLine(a: 0.15497545879234587d, b: 0.42501177297812087d, c: 0.3930386900482442d),

new NpgsqlTypes.NpgsqlLine(a: 0.49932759733861587d, b: 0.27860846401633954d, c: 0.22371479209453393d),

new NpgsqlTypes.NpgsqlLine(a: 0.6744750487770321d, b: 0.5185555306309229d, c: 0.48333909912156325d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6846715107366038d, b: 0.7822398219668835d, c: 0.6995656002724597d),

new NpgsqlTypes.NpgsqlLine(a: 0.34191163697506577d, b: 0.251427920689659d, c: 0.6372400180339429d),

new NpgsqlTypes.NpgsqlLine(a: 0.7615638356664386d, b: 0.38275705185682163d, c: 0.9430695395246483d),

new NpgsqlTypes.NpgsqlLine(a: 0.25861736938688795d, b: 0.2236086093911689d, c: 0.43081968027669826d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(111191550));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10079392481388938d, b: 0.47419284524344363d, c: 0.46999813598135487d),

new NpgsqlTypes.NpgsqlLine(a: 0.4512330545433114d, b: 0.7685777654216315d, c: 0.761484461621478d),

new NpgsqlTypes.NpgsqlLine(a: 0.7069502335832981d, b: 0.10867536284292001d, c: 0.803973548621565d),

new NpgsqlTypes.NpgsqlLine(a: 0.6710482193897285d, b: 0.3246300803211939d, c: 0.007931088387647223d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1651600176));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16882852097245493d, b: 0.6320810387310721d, c: 0.4943119337666173d),

new NpgsqlTypes.NpgsqlLine(a: 0.1864608664190791d, b: 0.3923939341785333d, c: 0.40778672849944797d),

new NpgsqlTypes.NpgsqlLine(a: 0.21658079009283382d, b: 0.9735580473103661d, c: 0.5313780798893142d),

new NpgsqlTypes.NpgsqlLine(a: 0.608447080933292d, b: 0.9095061095638245d, c: 0.664417030599092d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1656686707));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08369873952495288d, b: 0.07788317757867735d, c: 0.284112517861248d),

new NpgsqlTypes.NpgsqlLine(a: 0.617171498263342d, b: 0.5865508373972511d, c: 0.36018099841433293d),

new NpgsqlTypes.NpgsqlLine(a: 0.4798021589910493d, b: 0.5378837702166812d, c: 0.2195325878675365d),

new NpgsqlTypes.NpgsqlLine(a: 0.961753857136392d, b: 0.8919192421134503d, c: 0.16540674234160435d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1264360862));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3150738269575506d, b: 0.25723902915678687d, c: 0.7085220942560913d),

new NpgsqlTypes.NpgsqlLine(a: 0.10217399526832571d, b: 0.23606907248025677d, c: 0.14832581681823231d),

new NpgsqlTypes.NpgsqlLine(a: 0.38475783269574504d, b: 0.261674953378639d, c: 0.8414017715374641d),

new NpgsqlTypes.NpgsqlLine(a: 0.060969244577031345d, b: 0.7001282741779633d, c: 0.8180532031964253d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1800975967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6019711101236188d, b: 0.451502314152629d, c: 0.7567258646896037d),

new NpgsqlTypes.NpgsqlLine(a: 0.20314867633928102d, b: 0.43694052621738755d, c: 0.07972430095228344d),

new NpgsqlTypes.NpgsqlLine(a: 0.38639176328531444d, b: 0.5546727142910798d, c: 0.3595107666863845d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(116492752));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8534388679989421d, b: 0.17051639981163313d, c: 0.11184373953100968d),

new NpgsqlTypes.NpgsqlLine(a: 0.5545649696933802d, b: 0.6495249060333349d, c: 0.14480165352840013d),

new NpgsqlTypes.NpgsqlLine(a: 0.7068689700072772d, b: 0.10325704725403717d, c: 0.1383403540154834d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.565937691937727d, b: 0.8643068916219007d, c: 0.7899347881580714d),

new NpgsqlTypes.NpgsqlLine(a: 0.5461437063589625d, b: 0.8396992488239946d, c: 0.4549808859483121d),

new NpgsqlTypes.NpgsqlLine(a: 0.11142572920429805d, b: 0.7092154686109046d, c: 0.04531658445440445d),

new NpgsqlTypes.NpgsqlLine(a: 0.8590566964589479d, b: 0.07365357454587718d, c: 0.01783865983951749d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858289195));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25032438445726d, b: 0.0917391846373673d, c: 0.34066051809002806d),

new NpgsqlTypes.NpgsqlLine(a: 0.07831144663304057d, b: 0.77591037387439d, c: 0.19759580235224372d),

new NpgsqlTypes.NpgsqlLine(a: 0.3752205191956137d, b: 0.9100313386910368d, c: 0.6525871812195568d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47106408656007914d, b: 0.14257658261320605d, c: 0.47373760961489964d),

new NpgsqlTypes.NpgsqlLine(a: 0.4366806562773925d, b: 0.20146202051894901d, c: 0.3244113712884158d),

new NpgsqlTypes.NpgsqlLine(a: 0.41468311552317627d, b: 0.27557991533085235d, c: 0.7788691278257713d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1908397739));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36399675452528046d, b: 0.21180965313124933d, c: 0.6232643186817026d),

new NpgsqlTypes.NpgsqlLine(a: 0.8377534917307251d, b: 0.7197248111141329d, c: 0.5638759891270843d),

new NpgsqlTypes.NpgsqlLine(a: 0.9127913721936561d, b: 0.47658260676426356d, c: 0.4401534500107992d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.502181779437056d, b: 0.3652805047459293d, c: 0.32001644451474576d),

new NpgsqlTypes.NpgsqlLine(a: 0.7113651445912559d, b: 0.3869191031273206d, c: 0.7332400621535746d),

new NpgsqlTypes.NpgsqlLine(a: 0.5302147002696467d, b: 0.6514960201183412d, c: 0.8888784836070758d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1921152006));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3706659351474607d, b: 0.20392121211971403d, c: 0.09026673921559647d),

new NpgsqlTypes.NpgsqlLine(a: 0.3426907809834573d, b: 0.11597889224231583d, c: 0.37580383029156417d),

new NpgsqlTypes.NpgsqlLine(a: 0.9569454063294334d, b: 0.5352074925592666d, c: 0.1505041653825815d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(322154126));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17316937563192347d, b: 0.7977878569807266d, c: 0.5061623155222499d),

new NpgsqlTypes.NpgsqlLine(a: 0.39020299771548206d, b: 0.46872469438895703d, c: 0.1947250961658502d),

new NpgsqlTypes.NpgsqlLine(a: 0.9460666899443665d, b: 0.40873002207057996d, c: 0.5383135596603867d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931477721));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24029930494024243d, b: 0.6494520983530296d, c: 0.6457904476196421d),

new NpgsqlTypes.NpgsqlLine(a: 0.5413106581652064d, b: 0.65922568011039d, c: 0.023000101756869618d),

new NpgsqlTypes.NpgsqlLine(a: 0.05698461456670889d, b: 0.07946838244893384d, c: 0.023133320459978735d),

new NpgsqlTypes.NpgsqlLine(a: 0.023417572430763367d, b: 0.20022755743974863d, c: 0.9001563624157146d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3818728397283605d, b: 0.24081372003152057d, c: 0.42604600108359325d),

new NpgsqlTypes.NpgsqlLine(a: 0.9919565701428744d, b: 0.9836921588174795d, c: 0.6353618672799166d),

new NpgsqlTypes.NpgsqlLine(a: 0.49779514301225014d, b: 0.9235637976007209d, c: 0.26480996790155775d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943853869));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5132420668035784d, b: 0.9613252483783701d, c: 0.9242449431625296d),

new NpgsqlTypes.NpgsqlLine(a: 0.36653456446188004d, b: 0.7359631901409467d, c: 0.27792441954855884d),

new NpgsqlTypes.NpgsqlLine(a: 0.4636783251093567d, b: 0.1186591604974756d, c: 0.39388519565520497d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1951774404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4334255210533513d, b: 0.5785255926410576d, c: 0.9661508534687067d),

new NpgsqlTypes.NpgsqlLine(a: 0.19775236418153797d, b: 0.9365672085879589d, c: 0.1494826860380959d),

new NpgsqlTypes.NpgsqlLine(a: 0.176207462329397d, b: 0.2629253672101627d, c: 0.07007543599573873d),

new NpgsqlTypes.NpgsqlLine(a: 0.12818842182277845d, b: 0.1863366614728862d, c: 0.7134229928630377d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6151166351904711d, b: 0.2498835420322547d, c: 0.9733560033126378d),

new NpgsqlTypes.NpgsqlLine(a: 0.7516653963992566d, b: 0.8871254006140514d, c: 0.9688544000775576d),

new NpgsqlTypes.NpgsqlLine(a: 0.5920030979667459d, b: 0.19764908877922582d, c: 0.5631519149614208d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(NpgsqlLinelineArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)
            ),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11)
                )
            ]
        private void DbConnectionSelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineListlineArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(94091086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.756130013480001d, b: 0.8070063086186816d, c: 0.5025767314647364d),

new NpgsqlTypes.NpgsqlLine(a: 0.9364656141137178d, b: 0.4282247001937053d, c: 0.659495056495708d),

new NpgsqlTypes.NpgsqlLine(a: 0.2335034105141761d, b: 0.052909961042862275d, c: 0.04122572474287722d),

new NpgsqlTypes.NpgsqlLine(a: 0.5214850980568969d, b: 0.6097853166227842d, c: 0.037564705410715216d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.794741433961441d, b: 0.40948478818553324d, c: 0.8349955153630194d),

new NpgsqlTypes.NpgsqlLine(a: 0.6948645889459438d, b: 0.632857065419259d, c: 0.5039544579972753d),

new NpgsqlTypes.NpgsqlLine(a: 0.08944891276585798d, b: 0.913270540398744d, c: 0.6982865099702906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8541822252456289d, b: 0.7910647286519775d, c: 0.2522573522827649d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(128586765));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7662615462562571d, b: 0.41140775410532837d, c: 0.865079853391942d),

new NpgsqlTypes.NpgsqlLine(a: 0.9304815161900817d, b: 0.6441951572457856d, c: 0.4734484158164034d),

new NpgsqlTypes.NpgsqlLine(a: 0.28545320578356514d, b: 0.7953412500579145d, c: 0.13180882594344d),

new NpgsqlTypes.NpgsqlLine(a: 0.0006534434907554676d, b: 0.7291585410038824d, c: 0.07683170668531758d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(350174520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23005994787391715d, b: 0.314006898861965d, c: 0.9059890459886075d),

new NpgsqlTypes.NpgsqlLine(a: 0.0034924525333345224d, b: 0.22569705718656508d, c: 0.12293033480738269d),

new NpgsqlTypes.NpgsqlLine(a: 0.13769753447358068d, b: 0.20289930144832358d, c: 0.9141833823361538d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(528252532));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22785571390952986d, b: 0.47384563164287363d, c: 0.7296472935133859d),

new NpgsqlTypes.NpgsqlLine(a: 0.42847852345883053d, b: 0.05295602193643412d, c: 0.7176332323630693d),

new NpgsqlTypes.NpgsqlLine(a: 0.1313916587576558d, b: 0.44047120647606086d, c: 0.4080020542049758d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2023967945));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7526118185907706d, b: 0.7217192659741516d, c: 0.10725515353553927d),

new NpgsqlTypes.NpgsqlLine(a: 0.4123399872860949d, b: 0.9887632111198967d, c: 0.3407478138648996d),

new NpgsqlTypes.NpgsqlLine(a: 0.1972888611598902d, b: 0.21209298014251077d, c: 0.998100482656704d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32204440669620105d, b: 0.40425092983702615d, c: 0.6281187397686202d),

new NpgsqlTypes.NpgsqlLine(a: 0.8736370792109995d, b: 0.8257156419424208d, c: 0.24574228768788875d),

new NpgsqlTypes.NpgsqlLine(a: 0.1777372581271598d, b: 0.02795031420098848d, c: 0.6085263716794568d),

new NpgsqlTypes.NpgsqlLine(a: 0.3937718955623397d, b: 0.3857998777014512d, c: 0.16490107858931902d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(548719832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45120792613918626d, b: 0.7981849131464387d, c: 0.6797001557385036d),

new NpgsqlTypes.NpgsqlLine(a: 0.5152860785682492d, b: 0.05860524276063561d, c: 0.31392693425098706d),

new NpgsqlTypes.NpgsqlLine(a: 0.8399321644879826d, b: 0.14127845073157042d, c: 0.04919268640928787d),

new NpgsqlTypes.NpgsqlLine(a: 0.5367279979863265d, b: 0.9037039524330727d, c: 0.5651736207579545d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(632564420));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9871612756422758d, b: 0.7040000628939183d, c: 0.5741990515908977d),

new NpgsqlTypes.NpgsqlLine(a: 0.8939251170158339d, b: 0.591802460616856d, c: 0.8710953712464558d),

new NpgsqlTypes.NpgsqlLine(a: 0.925765879252592d, b: 0.020003653879282934d, c: 0.27174016206463947d),

new NpgsqlTypes.NpgsqlLine(a: 0.40821497810499396d, b: 0.18426353989680566d, c: 0.35762480728827095d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(569222828));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3541781533895836d, b: 0.8806877333215982d, c: 0.3434395351862555d),

new NpgsqlTypes.NpgsqlLine(a: 0.904182291889472d, b: 0.2725232832902962d, c: 0.11922376175569749d),

new NpgsqlTypes.NpgsqlLine(a: 0.2973949214938665d, b: 0.551548200515303d, c: 0.11510798755200236d),

new NpgsqlTypes.NpgsqlLine(a: 0.6236383027800103d, b: 0.7132402356425214d, c: 0.7946866828405127d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1120533763));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7797869567083358d, b: 0.2361739464389747d, c: 0.48164557546500963d),

new NpgsqlTypes.NpgsqlLine(a: 0.9480048066554808d, b: 0.8035492224666504d, c: 0.9832497213764478d),

new NpgsqlTypes.NpgsqlLine(a: 0.9772596541640088d, b: 0.6093516798517065d, c: 0.6052760903401032d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(617125650));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35787275736319957d, b: 0.702047825867143d, c: 0.965415572167533d),

new NpgsqlTypes.NpgsqlLine(a: 0.31090623461505584d, b: 0.5647177423851781d, c: 0.4846654296503867d),

new NpgsqlTypes.NpgsqlLine(a: 0.3183862992195977d, b: 0.6261458826331173d, c: 0.6907068588712774d),

new NpgsqlTypes.NpgsqlLine(a: 0.6487979418902344d, b: 0.4615179308283234d, c: 0.642127574912425d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9197027266355764d, b: 0.39215058098740485d, c: 0.17261332753094694d),

new NpgsqlTypes.NpgsqlLine(a: 0.11391459246246716d, b: 0.8528811542175645d, c: 0.20274869752530522d),

new NpgsqlTypes.NpgsqlLine(a: 0.36907637605105814d, b: 0.6376511000289307d, c: 0.12998307736849357d),

new NpgsqlTypes.NpgsqlLine(a: 0.9580086581171673d, b: 0.03050170247729178d, c: 0.38029624192446d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1413412459));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42503376733197573d, b: 0.763237079678654d, c: 0.09688502535476584d),

new NpgsqlTypes.NpgsqlLine(a: 0.23240822962655505d, b: 0.8459480271218152d, c: 0.08432931494869422d),

new NpgsqlTypes.NpgsqlLine(a: 0.18886663761414113d, b: 0.5079561486308892d, c: 0.9843388801596968d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(627974170));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15147399565049113d, b: 0.7627100647125816d, c: 0.16010235385722305d),

new NpgsqlTypes.NpgsqlLine(a: 0.9001358065765852d, b: 0.4721890907147458d, c: 0.15927787372271784d),

new NpgsqlTypes.NpgsqlLine(a: 0.7813049144298684d, b: 0.4136335409837938d, c: 0.12660196714031435d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.004236560392559818d, b: 0.39606208609499893d, c: 0.19741769434420997d),

new NpgsqlTypes.NpgsqlLine(a: 0.5953646586031078d, b: 0.6151314480582013d, c: 0.6556527973910132d),

new NpgsqlTypes.NpgsqlLine(a: 0.5407811339876436d, b: 0.9334248245144674d, c: 0.8365874899469636d),

new NpgsqlTypes.NpgsqlLine(a: 0.4764002070454937d, b: 0.16718217080509323d, c: 0.17236129187105342d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(791579102));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3341739254022562d, b: 0.718465753134697d, c: 0.5771634629019262d),

new NpgsqlTypes.NpgsqlLine(a: 0.6322200521292398d, b: 0.8246392866857581d, c: 0.5696079494467468d),

new NpgsqlTypes.NpgsqlLine(a: 0.6545382710133834d, b: 0.4365654599867256d, c: 0.8153585418393168d),

new NpgsqlTypes.NpgsqlLine(a: 0.0910019439659393d, b: 0.7174745892954046d, c: 0.1511089208473413d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1190383178));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12466334172066618d, b: 0.11152073168077081d, c: 0.491230984381532d),

new NpgsqlTypes.NpgsqlLine(a: 0.5547266175262346d, b: 0.13792449594977796d, c: 0.7570674004021489d),

new NpgsqlTypes.NpgsqlLine(a: 0.2085058544453703d, b: 0.08290359377194412d, c: 0.77495272781113d),

new NpgsqlTypes.NpgsqlLine(a: 0.49111506712078934d, b: 0.641116986925848d, c: 0.29516341556351666d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07914996961984966d, b: 0.4871418257809952d, c: 0.7513322508300865d),

new NpgsqlTypes.NpgsqlLine(a: 0.9239635289951339d, b: 0.38794777551433746d, c: 0.676783160212782d),

new NpgsqlTypes.NpgsqlLine(a: 0.0955538255878925d, b: 0.01055236041931451d, c: 0.2842563281409253d),

new NpgsqlTypes.NpgsqlLine(a: 0.02927332855673237d, b: 0.6165842674891228d, c: 0.8012173905302888d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(833599485));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4822973119466689d, b: 0.792513536759573d, c: 0.499633501292873d),

new NpgsqlTypes.NpgsqlLine(a: 0.8918073488512478d, b: 0.42208129985829845d, c: 0.5329638256901381d),

new NpgsqlTypes.NpgsqlLine(a: 0.5188620987187985d, b: 0.1726952436096839d, c: 0.7227459582321649d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15666178016283616d, b: 0.2873368213961791d, c: 0.4420895689102471d),

new NpgsqlTypes.NpgsqlLine(a: 0.4601057867375493d, b: 0.5622721416121373d, c: 0.2999980165807573d),

new NpgsqlTypes.NpgsqlLine(a: 0.8381583831951187d, b: 0.9764919740330239d, c: 0.18152562681640294d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1272632761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8378269016529278d, b: 0.6733240332238696d, c: 0.8919506779863193d),

new NpgsqlTypes.NpgsqlLine(a: 0.48570634731194795d, b: 0.1596671151368555d, c: 0.20750860994967846d),

new NpgsqlTypes.NpgsqlLine(a: 0.779653513645174d, b: 0.8586337096501773d, c: 0.1738735269722934d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2675334980310755d, b: 0.5860654638502302d, c: 0.5223481489931099d),

new NpgsqlTypes.NpgsqlLine(a: 0.2908190505712529d, b: 0.027311571062217044d, c: 0.38897855152716554d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590347289639254d, b: 0.6110078502040162d, c: 0.9773066927065011d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(896715967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4784147382307862d, b: 0.6552419336185478d, c: 0.920823919677529d),

new NpgsqlTypes.NpgsqlLine(a: 0.742593437228071d, b: 0.6268935209443758d, c: 0.5071732457335109d),

new NpgsqlTypes.NpgsqlLine(a: 0.6253496198816004d, b: 0.5361783003872929d, c: 0.7158348891331027d),

new NpgsqlTypes.NpgsqlLine(a: 0.4294538215627851d, b: 0.8234156672775046d, c: 0.08688024353682888d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(117280179));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3605977641294892d, b: 0.17811158147680461d, c: 0.9658058071756186d),

new NpgsqlTypes.NpgsqlLine(a: 0.6970256025820155d, b: 0.5444046414962291d, c: 0.46720686007108925d),

new NpgsqlTypes.NpgsqlLine(a: 0.8561050660597573d, b: 0.11353237597432853d, c: 0.56669941414895d),

new NpgsqlTypes.NpgsqlLine(a: 0.7984600619309864d, b: 0.8109151931011057d, c: 0.769305377302455d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0947306689172811d, b: 0.8302577671800684d, c: 0.8970532400118938d),

new NpgsqlTypes.NpgsqlLine(a: 0.2407748752003226d, b: 0.4567310255560061d, c: 0.4526792803927874d),

new NpgsqlTypes.NpgsqlLine(a: 0.04496104252758981d, b: 0.7589917027634498d, c: 0.6770421060059869d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(899804594));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1970857537444196d, b: 0.9333242638108382d, c: 0.2997924017071659d),

new NpgsqlTypes.NpgsqlLine(a: 0.6311349404614687d, b: 0.19618574736695826d, c: 0.38842914242231885d),

new NpgsqlTypes.NpgsqlLine(a: 0.8616526286116198d, b: 0.5020108677923993d, c: 0.7507796571723376d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8462722154822349d, b: 0.2140170588076531d, c: 0.1555300802445071d),

new NpgsqlTypes.NpgsqlLine(a: 0.05107346767082066d, b: 0.6007632357415391d, c: 0.11568725974145999d),

new NpgsqlTypes.NpgsqlLine(a: 0.9923537289603477d, b: 0.4950249871115745d, c: 0.02343990901364046d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(964637978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7665509369596407d, b: 0.32246651386445413d, c: 0.4163237996846909d),

new NpgsqlTypes.NpgsqlLine(a: 0.622867187513811d, b: 0.02481599358005626d, c: 0.6781914372848628d),

new NpgsqlTypes.NpgsqlLine(a: 0.9383962517038102d, b: 0.22799617371669267d, c: 0.11769282658114588d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1006841713));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3814391347607825d, b: 0.6500010795000312d, c: 0.5168910912789877d),

new NpgsqlTypes.NpgsqlLine(a: 0.9809725325416359d, b: 0.5965089551877092d, c: 0.9620206915411497d),

new NpgsqlTypes.NpgsqlLine(a: 0.8326177257415529d, b: 0.9726427466112844d, c: 0.44743910631138517d),

new NpgsqlTypes.NpgsqlLine(a: 0.9428905413649304d, b: 0.2742783552238923d, c: 0.20624247958140818d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4156588878635493d, b: 0.9311562710078888d, c: 0.18729745760128813d),

new NpgsqlTypes.NpgsqlLine(a: 0.7838364754377413d, b: 0.2902143764264882d, c: 0.6468999105347263d),

new NpgsqlTypes.NpgsqlLine(a: 0.2807400125401047d, b: 0.4738433713063067d, c: 0.3414032292061351d),

new NpgsqlTypes.NpgsqlLine(a: 0.07976939589399212d, b: 0.6817427263698487d, c: 0.7162950229594492d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1008288557));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6703103585772012d, b: 0.9414469448287122d, c: 0.32961805156524826d),

new NpgsqlTypes.NpgsqlLine(a: 0.13239408457631574d, b: 0.5134528929025426d, c: 0.5412589816963953d),

new NpgsqlTypes.NpgsqlLine(a: 0.1699098825091695d, b: 0.9194545880639252d, c: 0.7451240040858685d),

new NpgsqlTypes.NpgsqlLine(a: 0.2233903417330374d, b: 0.07771599830861675d, c: 0.5752102020647447d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(723640790));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8545769023218451d, b: 0.24286566112974062d, c: 0.24373271509232275d),

new NpgsqlTypes.NpgsqlLine(a: 0.8731571462637403d, b: 0.9993617334238951d, c: 0.1725755360195571d),

new NpgsqlTypes.NpgsqlLine(a: 0.2467482163165423d, b: 0.7309207508122816d, c: 0.574326589073651d),

new NpgsqlTypes.NpgsqlLine(a: 0.39429370255535745d, b: 0.12918013405283635d, c: 0.37279548432778786d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8697103680615146d, b: 0.4868697197066526d, c: 0.008300202872866591d),

new NpgsqlTypes.NpgsqlLine(a: 0.9268152455195247d, b: 0.9945415027788427d, c: 0.33225561051564245d),

new NpgsqlTypes.NpgsqlLine(a: 0.06541514412119742d, b: 0.29832372565206444d, c: 0.34837671529944225d),

new NpgsqlTypes.NpgsqlLine(a: 0.7703107306167513d, b: 0.39150187650435253d, c: 0.17912768771478083d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1212970907));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5991478813435879d, b: 0.21696546349723422d, c: 0.7473704822066682d),

new NpgsqlTypes.NpgsqlLine(a: 0.151066097236479d, b: 0.0802844223551269d, c: 0.09162465810768494d),

new NpgsqlTypes.NpgsqlLine(a: 0.8623052986382002d, b: 0.9298840839917386d, c: 0.6660510239194597d),

new NpgsqlTypes.NpgsqlLine(a: 0.9991351159913222d, b: 0.029361445428178645d, c: 0.30760770391653036d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2140414751));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5666355568463651d, b: 0.5532657932652175d, c: 0.043303548850170626d),

new NpgsqlTypes.NpgsqlLine(a: 0.4900959494886681d, b: 0.9349750472343457d, c: 0.4121355471301291d),

new NpgsqlTypes.NpgsqlLine(a: 0.06398838318692368d, b: 0.028285739863693204d, c: 0.8052480125394759d),

new NpgsqlTypes.NpgsqlLine(a: 0.31673961185856914d, b: 0.4141587759463713d, c: 0.1893488396111126d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1370558129));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9082169806472872d, b: 0.9235120225757552d, c: 0.8994934710072177d),

new NpgsqlTypes.NpgsqlLine(a: 0.12419478532476513d, b: 0.805126203795883d, c: 0.21123699569220133d),

new NpgsqlTypes.NpgsqlLine(a: 0.5518835410640954d, b: 0.3470463651950829d, c: 0.4121461426388031d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(196308953));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28578713252269017d, b: 0.8474368218362299d, c: 0.05146566977408318d),

new NpgsqlTypes.NpgsqlLine(a: 0.9109299616024349d, b: 0.5870141058904383d, c: 0.7452912896149598d),

new NpgsqlTypes.NpgsqlLine(a: 0.09671303857190205d, b: 0.22234046410281205d, c: 0.2889776640209598d),

new NpgsqlTypes.NpgsqlLine(a: 0.3594930797393622d, b: 0.1261117062789614d, c: 0.4836691385976134d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1411554384));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.43292849531653743d, b: 0.10139772092942057d, c: 0.19581477698464556d),

new NpgsqlTypes.NpgsqlLine(a: 0.7747830082073887d, b: 0.7612727046736724d, c: 0.49585407932443326d),

new NpgsqlTypes.NpgsqlLine(a: 0.7534769161594925d, b: 0.21640631521439513d, c: 0.9417215429915208d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1423267657));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7028157888188539d, b: 0.4434497177574276d, c: 0.1878584904244096d),

new NpgsqlTypes.NpgsqlLine(a: 0.12779644786129707d, b: 0.6547737034235738d, c: 0.7340324477099678d),

new NpgsqlTypes.NpgsqlLine(a: 0.13473852180731738d, b: 0.7900921279332365d, c: 0.7695417103969711d),

new NpgsqlTypes.NpgsqlLine(a: 0.2618677281295215d, b: 0.24821010444457137d, c: 0.2711393719015588d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1610745034));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6382266935775643d, b: 0.398693329671132d, c: 0.7425094436899613d),

new NpgsqlTypes.NpgsqlLine(a: 0.24327741116998813d, b: 0.1635267687203752d, c: 0.628031718062037d),

new NpgsqlTypes.NpgsqlLine(a: 0.38459544322295613d, b: 0.4141132804519537d, c: 0.8511486540491503d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9861241662988156d, b: 0.25399030999510996d, c: 0.2529918964264557d),

new NpgsqlTypes.NpgsqlLine(a: 0.17574090331875702d, b: 0.5215697754670754d, c: 0.49092403723555744d),

new NpgsqlTypes.NpgsqlLine(a: 0.9755215010138426d, b: 0.5836706698542481d, c: 0.8112425273051307d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1525343338));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5334739519154116d, b: 0.14533927203574382d, c: 0.9972375896646379d),

new NpgsqlTypes.NpgsqlLine(a: 0.5376404385911305d, b: 0.3967355325520928d, c: 0.2690585850054501d),

new NpgsqlTypes.NpgsqlLine(a: 0.7930288640515465d, b: 0.4034090749439643d, c: 0.19977351395319798d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22585130451050572d, b: 0.054454055462575424d, c: 0.3670135684186787d),

new NpgsqlTypes.NpgsqlLine(a: 0.8573417118252535d, b: 0.7290365889192361d, c: 0.15771025911629288d),

new NpgsqlTypes.NpgsqlLine(a: 0.8294206137900973d, b: 0.778292553399524d, c: 0.5844131999897239d),

new NpgsqlTypes.NpgsqlLine(a: 0.8795242286168519d, b: 0.43336364459496624d, c: 0.07939237473054006d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1618779845));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588222459861263d, b: 0.8314528851615401d, c: 0.4091425195520225d),

new NpgsqlTypes.NpgsqlLine(a: 0.15497545879234587d, b: 0.42501177297812087d, c: 0.3930386900482442d),

new NpgsqlTypes.NpgsqlLine(a: 0.49932759733861587d, b: 0.27860846401633954d, c: 0.22371479209453393d),

new NpgsqlTypes.NpgsqlLine(a: 0.6744750487770321d, b: 0.5185555306309229d, c: 0.48333909912156325d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6846715107366038d, b: 0.7822398219668835d, c: 0.6995656002724597d),

new NpgsqlTypes.NpgsqlLine(a: 0.34191163697506577d, b: 0.251427920689659d, c: 0.6372400180339429d),

new NpgsqlTypes.NpgsqlLine(a: 0.7615638356664386d, b: 0.38275705185682163d, c: 0.9430695395246483d),

new NpgsqlTypes.NpgsqlLine(a: 0.25861736938688795d, b: 0.2236086093911689d, c: 0.43081968027669826d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(111191550));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10079392481388938d, b: 0.47419284524344363d, c: 0.46999813598135487d),

new NpgsqlTypes.NpgsqlLine(a: 0.4512330545433114d, b: 0.7685777654216315d, c: 0.761484461621478d),

new NpgsqlTypes.NpgsqlLine(a: 0.7069502335832981d, b: 0.10867536284292001d, c: 0.803973548621565d),

new NpgsqlTypes.NpgsqlLine(a: 0.6710482193897285d, b: 0.3246300803211939d, c: 0.007931088387647223d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1651600176));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16882852097245493d, b: 0.6320810387310721d, c: 0.4943119337666173d),

new NpgsqlTypes.NpgsqlLine(a: 0.1864608664190791d, b: 0.3923939341785333d, c: 0.40778672849944797d),

new NpgsqlTypes.NpgsqlLine(a: 0.21658079009283382d, b: 0.9735580473103661d, c: 0.5313780798893142d),

new NpgsqlTypes.NpgsqlLine(a: 0.608447080933292d, b: 0.9095061095638245d, c: 0.664417030599092d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1656686707));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08369873952495288d, b: 0.07788317757867735d, c: 0.284112517861248d),

new NpgsqlTypes.NpgsqlLine(a: 0.617171498263342d, b: 0.5865508373972511d, c: 0.36018099841433293d),

new NpgsqlTypes.NpgsqlLine(a: 0.4798021589910493d, b: 0.5378837702166812d, c: 0.2195325878675365d),

new NpgsqlTypes.NpgsqlLine(a: 0.961753857136392d, b: 0.8919192421134503d, c: 0.16540674234160435d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1264360862));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3150738269575506d, b: 0.25723902915678687d, c: 0.7085220942560913d),

new NpgsqlTypes.NpgsqlLine(a: 0.10217399526832571d, b: 0.23606907248025677d, c: 0.14832581681823231d),

new NpgsqlTypes.NpgsqlLine(a: 0.38475783269574504d, b: 0.261674953378639d, c: 0.8414017715374641d),

new NpgsqlTypes.NpgsqlLine(a: 0.060969244577031345d, b: 0.7001282741779633d, c: 0.8180532031964253d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1800975967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6019711101236188d, b: 0.451502314152629d, c: 0.7567258646896037d),

new NpgsqlTypes.NpgsqlLine(a: 0.20314867633928102d, b: 0.43694052621738755d, c: 0.07972430095228344d),

new NpgsqlTypes.NpgsqlLine(a: 0.38639176328531444d, b: 0.5546727142910798d, c: 0.3595107666863845d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(116492752));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8534388679989421d, b: 0.17051639981163313d, c: 0.11184373953100968d),

new NpgsqlTypes.NpgsqlLine(a: 0.5545649696933802d, b: 0.6495249060333349d, c: 0.14480165352840013d),

new NpgsqlTypes.NpgsqlLine(a: 0.7068689700072772d, b: 0.10325704725403717d, c: 0.1383403540154834d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.565937691937727d, b: 0.8643068916219007d, c: 0.7899347881580714d),

new NpgsqlTypes.NpgsqlLine(a: 0.5461437063589625d, b: 0.8396992488239946d, c: 0.4549808859483121d),

new NpgsqlTypes.NpgsqlLine(a: 0.11142572920429805d, b: 0.7092154686109046d, c: 0.04531658445440445d),

new NpgsqlTypes.NpgsqlLine(a: 0.8590566964589479d, b: 0.07365357454587718d, c: 0.01783865983951749d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858289195));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25032438445726d, b: 0.0917391846373673d, c: 0.34066051809002806d),

new NpgsqlTypes.NpgsqlLine(a: 0.07831144663304057d, b: 0.77591037387439d, c: 0.19759580235224372d),

new NpgsqlTypes.NpgsqlLine(a: 0.3752205191956137d, b: 0.9100313386910368d, c: 0.6525871812195568d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47106408656007914d, b: 0.14257658261320605d, c: 0.47373760961489964d),

new NpgsqlTypes.NpgsqlLine(a: 0.4366806562773925d, b: 0.20146202051894901d, c: 0.3244113712884158d),

new NpgsqlTypes.NpgsqlLine(a: 0.41468311552317627d, b: 0.27557991533085235d, c: 0.7788691278257713d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1908397739));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36399675452528046d, b: 0.21180965313124933d, c: 0.6232643186817026d),

new NpgsqlTypes.NpgsqlLine(a: 0.8377534917307251d, b: 0.7197248111141329d, c: 0.5638759891270843d),

new NpgsqlTypes.NpgsqlLine(a: 0.9127913721936561d, b: 0.47658260676426356d, c: 0.4401534500107992d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.502181779437056d, b: 0.3652805047459293d, c: 0.32001644451474576d),

new NpgsqlTypes.NpgsqlLine(a: 0.7113651445912559d, b: 0.3869191031273206d, c: 0.7332400621535746d),

new NpgsqlTypes.NpgsqlLine(a: 0.5302147002696467d, b: 0.6514960201183412d, c: 0.8888784836070758d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1921152006));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3706659351474607d, b: 0.20392121211971403d, c: 0.09026673921559647d),

new NpgsqlTypes.NpgsqlLine(a: 0.3426907809834573d, b: 0.11597889224231583d, c: 0.37580383029156417d),

new NpgsqlTypes.NpgsqlLine(a: 0.9569454063294334d, b: 0.5352074925592666d, c: 0.1505041653825815d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(322154126));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17316937563192347d, b: 0.7977878569807266d, c: 0.5061623155222499d),

new NpgsqlTypes.NpgsqlLine(a: 0.39020299771548206d, b: 0.46872469438895703d, c: 0.1947250961658502d),

new NpgsqlTypes.NpgsqlLine(a: 0.9460666899443665d, b: 0.40873002207057996d, c: 0.5383135596603867d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931477721));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24029930494024243d, b: 0.6494520983530296d, c: 0.6457904476196421d),

new NpgsqlTypes.NpgsqlLine(a: 0.5413106581652064d, b: 0.65922568011039d, c: 0.023000101756869618d),

new NpgsqlTypes.NpgsqlLine(a: 0.05698461456670889d, b: 0.07946838244893384d, c: 0.023133320459978735d),

new NpgsqlTypes.NpgsqlLine(a: 0.023417572430763367d, b: 0.20022755743974863d, c: 0.9001563624157146d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3818728397283605d, b: 0.24081372003152057d, c: 0.42604600108359325d),

new NpgsqlTypes.NpgsqlLine(a: 0.9919565701428744d, b: 0.9836921588174795d, c: 0.6353618672799166d),

new NpgsqlTypes.NpgsqlLine(a: 0.49779514301225014d, b: 0.9235637976007209d, c: 0.26480996790155775d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943853869));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5132420668035784d, b: 0.9613252483783701d, c: 0.9242449431625296d),

new NpgsqlTypes.NpgsqlLine(a: 0.36653456446188004d, b: 0.7359631901409467d, c: 0.27792441954855884d),

new NpgsqlTypes.NpgsqlLine(a: 0.4636783251093567d, b: 0.1186591604974756d, c: 0.39388519565520497d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1951774404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4334255210533513d, b: 0.5785255926410576d, c: 0.9661508534687067d),

new NpgsqlTypes.NpgsqlLine(a: 0.19775236418153797d, b: 0.9365672085879589d, c: 0.1494826860380959d),

new NpgsqlTypes.NpgsqlLine(a: 0.176207462329397d, b: 0.2629253672101627d, c: 0.07007543599573873d),

new NpgsqlTypes.NpgsqlLine(a: 0.12818842182277845d, b: 0.1863366614728862d, c: 0.7134229928630377d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6151166351904711d, b: 0.2498835420322547d, c: 0.9733560033126378d),

new NpgsqlTypes.NpgsqlLine(a: 0.7516653963992566d, b: 0.8871254006140514d, c: 0.9688544000775576d),

new NpgsqlTypes.NpgsqlLine(a: 0.5920030979667459d, b: 0.19764908877922582d, c: 0.5631519149614208d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(94091086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.756130013480001d, b: 0.8070063086186816d, c: 0.5025767314647364d),

new NpgsqlTypes.NpgsqlLine(a: 0.9364656141137178d, b: 0.4282247001937053d, c: 0.659495056495708d),

new NpgsqlTypes.NpgsqlLine(a: 0.2335034105141761d, b: 0.052909961042862275d, c: 0.04122572474287722d),

new NpgsqlTypes.NpgsqlLine(a: 0.5214850980568969d, b: 0.6097853166227842d, c: 0.037564705410715216d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.794741433961441d, b: 0.40948478818553324d, c: 0.8349955153630194d),

new NpgsqlTypes.NpgsqlLine(a: 0.6948645889459438d, b: 0.632857065419259d, c: 0.5039544579972753d),

new NpgsqlTypes.NpgsqlLine(a: 0.08944891276585798d, b: 0.913270540398744d, c: 0.6982865099702906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8541822252456289d, b: 0.7910647286519775d, c: 0.2522573522827649d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(128586765));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7662615462562571d, b: 0.41140775410532837d, c: 0.865079853391942d),

new NpgsqlTypes.NpgsqlLine(a: 0.9304815161900817d, b: 0.6441951572457856d, c: 0.4734484158164034d),

new NpgsqlTypes.NpgsqlLine(a: 0.28545320578356514d, b: 0.7953412500579145d, c: 0.13180882594344d),

new NpgsqlTypes.NpgsqlLine(a: 0.0006534434907554676d, b: 0.7291585410038824d, c: 0.07683170668531758d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(350174520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23005994787391715d, b: 0.314006898861965d, c: 0.9059890459886075d),

new NpgsqlTypes.NpgsqlLine(a: 0.0034924525333345224d, b: 0.22569705718656508d, c: 0.12293033480738269d),

new NpgsqlTypes.NpgsqlLine(a: 0.13769753447358068d, b: 0.20289930144832358d, c: 0.9141833823361538d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(528252532));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22785571390952986d, b: 0.47384563164287363d, c: 0.7296472935133859d),

new NpgsqlTypes.NpgsqlLine(a: 0.42847852345883053d, b: 0.05295602193643412d, c: 0.7176332323630693d),

new NpgsqlTypes.NpgsqlLine(a: 0.1313916587576558d, b: 0.44047120647606086d, c: 0.4080020542049758d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2023967945));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7526118185907706d, b: 0.7217192659741516d, c: 0.10725515353553927d),

new NpgsqlTypes.NpgsqlLine(a: 0.4123399872860949d, b: 0.9887632111198967d, c: 0.3407478138648996d),

new NpgsqlTypes.NpgsqlLine(a: 0.1972888611598902d, b: 0.21209298014251077d, c: 0.998100482656704d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32204440669620105d, b: 0.40425092983702615d, c: 0.6281187397686202d),

new NpgsqlTypes.NpgsqlLine(a: 0.8736370792109995d, b: 0.8257156419424208d, c: 0.24574228768788875d),

new NpgsqlTypes.NpgsqlLine(a: 0.1777372581271598d, b: 0.02795031420098848d, c: 0.6085263716794568d),

new NpgsqlTypes.NpgsqlLine(a: 0.3937718955623397d, b: 0.3857998777014512d, c: 0.16490107858931902d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(548719832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45120792613918626d, b: 0.7981849131464387d, c: 0.6797001557385036d),

new NpgsqlTypes.NpgsqlLine(a: 0.5152860785682492d, b: 0.05860524276063561d, c: 0.31392693425098706d),

new NpgsqlTypes.NpgsqlLine(a: 0.8399321644879826d, b: 0.14127845073157042d, c: 0.04919268640928787d),

new NpgsqlTypes.NpgsqlLine(a: 0.5367279979863265d, b: 0.9037039524330727d, c: 0.5651736207579545d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(632564420));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9871612756422758d, b: 0.7040000628939183d, c: 0.5741990515908977d),

new NpgsqlTypes.NpgsqlLine(a: 0.8939251170158339d, b: 0.591802460616856d, c: 0.8710953712464558d),

new NpgsqlTypes.NpgsqlLine(a: 0.925765879252592d, b: 0.020003653879282934d, c: 0.27174016206463947d),

new NpgsqlTypes.NpgsqlLine(a: 0.40821497810499396d, b: 0.18426353989680566d, c: 0.35762480728827095d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(569222828));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3541781533895836d, b: 0.8806877333215982d, c: 0.3434395351862555d),

new NpgsqlTypes.NpgsqlLine(a: 0.904182291889472d, b: 0.2725232832902962d, c: 0.11922376175569749d),

new NpgsqlTypes.NpgsqlLine(a: 0.2973949214938665d, b: 0.551548200515303d, c: 0.11510798755200236d),

new NpgsqlTypes.NpgsqlLine(a: 0.6236383027800103d, b: 0.7132402356425214d, c: 0.7946866828405127d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1120533763));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7797869567083358d, b: 0.2361739464389747d, c: 0.48164557546500963d),

new NpgsqlTypes.NpgsqlLine(a: 0.9480048066554808d, b: 0.8035492224666504d, c: 0.9832497213764478d),

new NpgsqlTypes.NpgsqlLine(a: 0.9772596541640088d, b: 0.6093516798517065d, c: 0.6052760903401032d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(617125650));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35787275736319957d, b: 0.702047825867143d, c: 0.965415572167533d),

new NpgsqlTypes.NpgsqlLine(a: 0.31090623461505584d, b: 0.5647177423851781d, c: 0.4846654296503867d),

new NpgsqlTypes.NpgsqlLine(a: 0.3183862992195977d, b: 0.6261458826331173d, c: 0.6907068588712774d),

new NpgsqlTypes.NpgsqlLine(a: 0.6487979418902344d, b: 0.4615179308283234d, c: 0.642127574912425d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9197027266355764d, b: 0.39215058098740485d, c: 0.17261332753094694d),

new NpgsqlTypes.NpgsqlLine(a: 0.11391459246246716d, b: 0.8528811542175645d, c: 0.20274869752530522d),

new NpgsqlTypes.NpgsqlLine(a: 0.36907637605105814d, b: 0.6376511000289307d, c: 0.12998307736849357d),

new NpgsqlTypes.NpgsqlLine(a: 0.9580086581171673d, b: 0.03050170247729178d, c: 0.38029624192446d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1413412459));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42503376733197573d, b: 0.763237079678654d, c: 0.09688502535476584d),

new NpgsqlTypes.NpgsqlLine(a: 0.23240822962655505d, b: 0.8459480271218152d, c: 0.08432931494869422d),

new NpgsqlTypes.NpgsqlLine(a: 0.18886663761414113d, b: 0.5079561486308892d, c: 0.9843388801596968d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(627974170));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15147399565049113d, b: 0.7627100647125816d, c: 0.16010235385722305d),

new NpgsqlTypes.NpgsqlLine(a: 0.9001358065765852d, b: 0.4721890907147458d, c: 0.15927787372271784d),

new NpgsqlTypes.NpgsqlLine(a: 0.7813049144298684d, b: 0.4136335409837938d, c: 0.12660196714031435d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.004236560392559818d, b: 0.39606208609499893d, c: 0.19741769434420997d),

new NpgsqlTypes.NpgsqlLine(a: 0.5953646586031078d, b: 0.6151314480582013d, c: 0.6556527973910132d),

new NpgsqlTypes.NpgsqlLine(a: 0.5407811339876436d, b: 0.9334248245144674d, c: 0.8365874899469636d),

new NpgsqlTypes.NpgsqlLine(a: 0.4764002070454937d, b: 0.16718217080509323d, c: 0.17236129187105342d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(791579102));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3341739254022562d, b: 0.718465753134697d, c: 0.5771634629019262d),

new NpgsqlTypes.NpgsqlLine(a: 0.6322200521292398d, b: 0.8246392866857581d, c: 0.5696079494467468d),

new NpgsqlTypes.NpgsqlLine(a: 0.6545382710133834d, b: 0.4365654599867256d, c: 0.8153585418393168d),

new NpgsqlTypes.NpgsqlLine(a: 0.0910019439659393d, b: 0.7174745892954046d, c: 0.1511089208473413d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1190383178));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12466334172066618d, b: 0.11152073168077081d, c: 0.491230984381532d),

new NpgsqlTypes.NpgsqlLine(a: 0.5547266175262346d, b: 0.13792449594977796d, c: 0.7570674004021489d),

new NpgsqlTypes.NpgsqlLine(a: 0.2085058544453703d, b: 0.08290359377194412d, c: 0.77495272781113d),

new NpgsqlTypes.NpgsqlLine(a: 0.49111506712078934d, b: 0.641116986925848d, c: 0.29516341556351666d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07914996961984966d, b: 0.4871418257809952d, c: 0.7513322508300865d),

new NpgsqlTypes.NpgsqlLine(a: 0.9239635289951339d, b: 0.38794777551433746d, c: 0.676783160212782d),

new NpgsqlTypes.NpgsqlLine(a: 0.0955538255878925d, b: 0.01055236041931451d, c: 0.2842563281409253d),

new NpgsqlTypes.NpgsqlLine(a: 0.02927332855673237d, b: 0.6165842674891228d, c: 0.8012173905302888d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(833599485));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4822973119466689d, b: 0.792513536759573d, c: 0.499633501292873d),

new NpgsqlTypes.NpgsqlLine(a: 0.8918073488512478d, b: 0.42208129985829845d, c: 0.5329638256901381d),

new NpgsqlTypes.NpgsqlLine(a: 0.5188620987187985d, b: 0.1726952436096839d, c: 0.7227459582321649d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15666178016283616d, b: 0.2873368213961791d, c: 0.4420895689102471d),

new NpgsqlTypes.NpgsqlLine(a: 0.4601057867375493d, b: 0.5622721416121373d, c: 0.2999980165807573d),

new NpgsqlTypes.NpgsqlLine(a: 0.8381583831951187d, b: 0.9764919740330239d, c: 0.18152562681640294d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1272632761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8378269016529278d, b: 0.6733240332238696d, c: 0.8919506779863193d),

new NpgsqlTypes.NpgsqlLine(a: 0.48570634731194795d, b: 0.1596671151368555d, c: 0.20750860994967846d),

new NpgsqlTypes.NpgsqlLine(a: 0.779653513645174d, b: 0.8586337096501773d, c: 0.1738735269722934d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2675334980310755d, b: 0.5860654638502302d, c: 0.5223481489931099d),

new NpgsqlTypes.NpgsqlLine(a: 0.2908190505712529d, b: 0.027311571062217044d, c: 0.38897855152716554d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590347289639254d, b: 0.6110078502040162d, c: 0.9773066927065011d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(896715967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4784147382307862d, b: 0.6552419336185478d, c: 0.920823919677529d),

new NpgsqlTypes.NpgsqlLine(a: 0.742593437228071d, b: 0.6268935209443758d, c: 0.5071732457335109d),

new NpgsqlTypes.NpgsqlLine(a: 0.6253496198816004d, b: 0.5361783003872929d, c: 0.7158348891331027d),

new NpgsqlTypes.NpgsqlLine(a: 0.4294538215627851d, b: 0.8234156672775046d, c: 0.08688024353682888d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(117280179));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3605977641294892d, b: 0.17811158147680461d, c: 0.9658058071756186d),

new NpgsqlTypes.NpgsqlLine(a: 0.6970256025820155d, b: 0.5444046414962291d, c: 0.46720686007108925d),

new NpgsqlTypes.NpgsqlLine(a: 0.8561050660597573d, b: 0.11353237597432853d, c: 0.56669941414895d),

new NpgsqlTypes.NpgsqlLine(a: 0.7984600619309864d, b: 0.8109151931011057d, c: 0.769305377302455d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0947306689172811d, b: 0.8302577671800684d, c: 0.8970532400118938d),

new NpgsqlTypes.NpgsqlLine(a: 0.2407748752003226d, b: 0.4567310255560061d, c: 0.4526792803927874d),

new NpgsqlTypes.NpgsqlLine(a: 0.04496104252758981d, b: 0.7589917027634498d, c: 0.6770421060059869d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(899804594));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1970857537444196d, b: 0.9333242638108382d, c: 0.2997924017071659d),

new NpgsqlTypes.NpgsqlLine(a: 0.6311349404614687d, b: 0.19618574736695826d, c: 0.38842914242231885d),

new NpgsqlTypes.NpgsqlLine(a: 0.8616526286116198d, b: 0.5020108677923993d, c: 0.7507796571723376d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8462722154822349d, b: 0.2140170588076531d, c: 0.1555300802445071d),

new NpgsqlTypes.NpgsqlLine(a: 0.05107346767082066d, b: 0.6007632357415391d, c: 0.11568725974145999d),

new NpgsqlTypes.NpgsqlLine(a: 0.9923537289603477d, b: 0.4950249871115745d, c: 0.02343990901364046d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(964637978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7665509369596407d, b: 0.32246651386445413d, c: 0.4163237996846909d),

new NpgsqlTypes.NpgsqlLine(a: 0.622867187513811d, b: 0.02481599358005626d, c: 0.6781914372848628d),

new NpgsqlTypes.NpgsqlLine(a: 0.9383962517038102d, b: 0.22799617371669267d, c: 0.11769282658114588d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1006841713));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3814391347607825d, b: 0.6500010795000312d, c: 0.5168910912789877d),

new NpgsqlTypes.NpgsqlLine(a: 0.9809725325416359d, b: 0.5965089551877092d, c: 0.9620206915411497d),

new NpgsqlTypes.NpgsqlLine(a: 0.8326177257415529d, b: 0.9726427466112844d, c: 0.44743910631138517d),

new NpgsqlTypes.NpgsqlLine(a: 0.9428905413649304d, b: 0.2742783552238923d, c: 0.20624247958140818d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4156588878635493d, b: 0.9311562710078888d, c: 0.18729745760128813d),

new NpgsqlTypes.NpgsqlLine(a: 0.7838364754377413d, b: 0.2902143764264882d, c: 0.6468999105347263d),

new NpgsqlTypes.NpgsqlLine(a: 0.2807400125401047d, b: 0.4738433713063067d, c: 0.3414032292061351d),

new NpgsqlTypes.NpgsqlLine(a: 0.07976939589399212d, b: 0.6817427263698487d, c: 0.7162950229594492d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1008288557));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6703103585772012d, b: 0.9414469448287122d, c: 0.32961805156524826d),

new NpgsqlTypes.NpgsqlLine(a: 0.13239408457631574d, b: 0.5134528929025426d, c: 0.5412589816963953d),

new NpgsqlTypes.NpgsqlLine(a: 0.1699098825091695d, b: 0.9194545880639252d, c: 0.7451240040858685d),

new NpgsqlTypes.NpgsqlLine(a: 0.2233903417330374d, b: 0.07771599830861675d, c: 0.5752102020647447d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(723640790));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8545769023218451d, b: 0.24286566112974062d, c: 0.24373271509232275d),

new NpgsqlTypes.NpgsqlLine(a: 0.8731571462637403d, b: 0.9993617334238951d, c: 0.1725755360195571d),

new NpgsqlTypes.NpgsqlLine(a: 0.2467482163165423d, b: 0.7309207508122816d, c: 0.574326589073651d),

new NpgsqlTypes.NpgsqlLine(a: 0.39429370255535745d, b: 0.12918013405283635d, c: 0.37279548432778786d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8697103680615146d, b: 0.4868697197066526d, c: 0.008300202872866591d),

new NpgsqlTypes.NpgsqlLine(a: 0.9268152455195247d, b: 0.9945415027788427d, c: 0.33225561051564245d),

new NpgsqlTypes.NpgsqlLine(a: 0.06541514412119742d, b: 0.29832372565206444d, c: 0.34837671529944225d),

new NpgsqlTypes.NpgsqlLine(a: 0.7703107306167513d, b: 0.39150187650435253d, c: 0.17912768771478083d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1212970907));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5991478813435879d, b: 0.21696546349723422d, c: 0.7473704822066682d),

new NpgsqlTypes.NpgsqlLine(a: 0.151066097236479d, b: 0.0802844223551269d, c: 0.09162465810768494d),

new NpgsqlTypes.NpgsqlLine(a: 0.8623052986382002d, b: 0.9298840839917386d, c: 0.6660510239194597d),

new NpgsqlTypes.NpgsqlLine(a: 0.9991351159913222d, b: 0.029361445428178645d, c: 0.30760770391653036d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2140414751));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5666355568463651d, b: 0.5532657932652175d, c: 0.043303548850170626d),

new NpgsqlTypes.NpgsqlLine(a: 0.4900959494886681d, b: 0.9349750472343457d, c: 0.4121355471301291d),

new NpgsqlTypes.NpgsqlLine(a: 0.06398838318692368d, b: 0.028285739863693204d, c: 0.8052480125394759d),

new NpgsqlTypes.NpgsqlLine(a: 0.31673961185856914d, b: 0.4141587759463713d, c: 0.1893488396111126d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1370558129));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9082169806472872d, b: 0.9235120225757552d, c: 0.8994934710072177d),

new NpgsqlTypes.NpgsqlLine(a: 0.12419478532476513d, b: 0.805126203795883d, c: 0.21123699569220133d),

new NpgsqlTypes.NpgsqlLine(a: 0.5518835410640954d, b: 0.3470463651950829d, c: 0.4121461426388031d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(196308953));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28578713252269017d, b: 0.8474368218362299d, c: 0.05146566977408318d),

new NpgsqlTypes.NpgsqlLine(a: 0.9109299616024349d, b: 0.5870141058904383d, c: 0.7452912896149598d),

new NpgsqlTypes.NpgsqlLine(a: 0.09671303857190205d, b: 0.22234046410281205d, c: 0.2889776640209598d),

new NpgsqlTypes.NpgsqlLine(a: 0.3594930797393622d, b: 0.1261117062789614d, c: 0.4836691385976134d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1411554384));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.43292849531653743d, b: 0.10139772092942057d, c: 0.19581477698464556d),

new NpgsqlTypes.NpgsqlLine(a: 0.7747830082073887d, b: 0.7612727046736724d, c: 0.49585407932443326d),

new NpgsqlTypes.NpgsqlLine(a: 0.7534769161594925d, b: 0.21640631521439513d, c: 0.9417215429915208d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1423267657));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7028157888188539d, b: 0.4434497177574276d, c: 0.1878584904244096d),

new NpgsqlTypes.NpgsqlLine(a: 0.12779644786129707d, b: 0.6547737034235738d, c: 0.7340324477099678d),

new NpgsqlTypes.NpgsqlLine(a: 0.13473852180731738d, b: 0.7900921279332365d, c: 0.7695417103969711d),

new NpgsqlTypes.NpgsqlLine(a: 0.2618677281295215d, b: 0.24821010444457137d, c: 0.2711393719015588d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1610745034));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6382266935775643d, b: 0.398693329671132d, c: 0.7425094436899613d),

new NpgsqlTypes.NpgsqlLine(a: 0.24327741116998813d, b: 0.1635267687203752d, c: 0.628031718062037d),

new NpgsqlTypes.NpgsqlLine(a: 0.38459544322295613d, b: 0.4141132804519537d, c: 0.8511486540491503d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9861241662988156d, b: 0.25399030999510996d, c: 0.2529918964264557d),

new NpgsqlTypes.NpgsqlLine(a: 0.17574090331875702d, b: 0.5215697754670754d, c: 0.49092403723555744d),

new NpgsqlTypes.NpgsqlLine(a: 0.9755215010138426d, b: 0.5836706698542481d, c: 0.8112425273051307d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1525343338));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5334739519154116d, b: 0.14533927203574382d, c: 0.9972375896646379d),

new NpgsqlTypes.NpgsqlLine(a: 0.5376404385911305d, b: 0.3967355325520928d, c: 0.2690585850054501d),

new NpgsqlTypes.NpgsqlLine(a: 0.7930288640515465d, b: 0.4034090749439643d, c: 0.19977351395319798d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22585130451050572d, b: 0.054454055462575424d, c: 0.3670135684186787d),

new NpgsqlTypes.NpgsqlLine(a: 0.8573417118252535d, b: 0.7290365889192361d, c: 0.15771025911629288d),

new NpgsqlTypes.NpgsqlLine(a: 0.8294206137900973d, b: 0.778292553399524d, c: 0.5844131999897239d),

new NpgsqlTypes.NpgsqlLine(a: 0.8795242286168519d, b: 0.43336364459496624d, c: 0.07939237473054006d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1618779845));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588222459861263d, b: 0.8314528851615401d, c: 0.4091425195520225d),

new NpgsqlTypes.NpgsqlLine(a: 0.15497545879234587d, b: 0.42501177297812087d, c: 0.3930386900482442d),

new NpgsqlTypes.NpgsqlLine(a: 0.49932759733861587d, b: 0.27860846401633954d, c: 0.22371479209453393d),

new NpgsqlTypes.NpgsqlLine(a: 0.6744750487770321d, b: 0.5185555306309229d, c: 0.48333909912156325d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6846715107366038d, b: 0.7822398219668835d, c: 0.6995656002724597d),

new NpgsqlTypes.NpgsqlLine(a: 0.34191163697506577d, b: 0.251427920689659d, c: 0.6372400180339429d),

new NpgsqlTypes.NpgsqlLine(a: 0.7615638356664386d, b: 0.38275705185682163d, c: 0.9430695395246483d),

new NpgsqlTypes.NpgsqlLine(a: 0.25861736938688795d, b: 0.2236086093911689d, c: 0.43081968027669826d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(111191550));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10079392481388938d, b: 0.47419284524344363d, c: 0.46999813598135487d),

new NpgsqlTypes.NpgsqlLine(a: 0.4512330545433114d, b: 0.7685777654216315d, c: 0.761484461621478d),

new NpgsqlTypes.NpgsqlLine(a: 0.7069502335832981d, b: 0.10867536284292001d, c: 0.803973548621565d),

new NpgsqlTypes.NpgsqlLine(a: 0.6710482193897285d, b: 0.3246300803211939d, c: 0.007931088387647223d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1651600176));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16882852097245493d, b: 0.6320810387310721d, c: 0.4943119337666173d),

new NpgsqlTypes.NpgsqlLine(a: 0.1864608664190791d, b: 0.3923939341785333d, c: 0.40778672849944797d),

new NpgsqlTypes.NpgsqlLine(a: 0.21658079009283382d, b: 0.9735580473103661d, c: 0.5313780798893142d),

new NpgsqlTypes.NpgsqlLine(a: 0.608447080933292d, b: 0.9095061095638245d, c: 0.664417030599092d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1656686707));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08369873952495288d, b: 0.07788317757867735d, c: 0.284112517861248d),

new NpgsqlTypes.NpgsqlLine(a: 0.617171498263342d, b: 0.5865508373972511d, c: 0.36018099841433293d),

new NpgsqlTypes.NpgsqlLine(a: 0.4798021589910493d, b: 0.5378837702166812d, c: 0.2195325878675365d),

new NpgsqlTypes.NpgsqlLine(a: 0.961753857136392d, b: 0.8919192421134503d, c: 0.16540674234160435d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1264360862));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3150738269575506d, b: 0.25723902915678687d, c: 0.7085220942560913d),

new NpgsqlTypes.NpgsqlLine(a: 0.10217399526832571d, b: 0.23606907248025677d, c: 0.14832581681823231d),

new NpgsqlTypes.NpgsqlLine(a: 0.38475783269574504d, b: 0.261674953378639d, c: 0.8414017715374641d),

new NpgsqlTypes.NpgsqlLine(a: 0.060969244577031345d, b: 0.7001282741779633d, c: 0.8180532031964253d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1800975967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6019711101236188d, b: 0.451502314152629d, c: 0.7567258646896037d),

new NpgsqlTypes.NpgsqlLine(a: 0.20314867633928102d, b: 0.43694052621738755d, c: 0.07972430095228344d),

new NpgsqlTypes.NpgsqlLine(a: 0.38639176328531444d, b: 0.5546727142910798d, c: 0.3595107666863845d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(116492752));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8534388679989421d, b: 0.17051639981163313d, c: 0.11184373953100968d),

new NpgsqlTypes.NpgsqlLine(a: 0.5545649696933802d, b: 0.6495249060333349d, c: 0.14480165352840013d),

new NpgsqlTypes.NpgsqlLine(a: 0.7068689700072772d, b: 0.10325704725403717d, c: 0.1383403540154834d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.565937691937727d, b: 0.8643068916219007d, c: 0.7899347881580714d),

new NpgsqlTypes.NpgsqlLine(a: 0.5461437063589625d, b: 0.8396992488239946d, c: 0.4549808859483121d),

new NpgsqlTypes.NpgsqlLine(a: 0.11142572920429805d, b: 0.7092154686109046d, c: 0.04531658445440445d),

new NpgsqlTypes.NpgsqlLine(a: 0.8590566964589479d, b: 0.07365357454587718d, c: 0.01783865983951749d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858289195));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25032438445726d, b: 0.0917391846373673d, c: 0.34066051809002806d),

new NpgsqlTypes.NpgsqlLine(a: 0.07831144663304057d, b: 0.77591037387439d, c: 0.19759580235224372d),

new NpgsqlTypes.NpgsqlLine(a: 0.3752205191956137d, b: 0.9100313386910368d, c: 0.6525871812195568d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47106408656007914d, b: 0.14257658261320605d, c: 0.47373760961489964d),

new NpgsqlTypes.NpgsqlLine(a: 0.4366806562773925d, b: 0.20146202051894901d, c: 0.3244113712884158d),

new NpgsqlTypes.NpgsqlLine(a: 0.41468311552317627d, b: 0.27557991533085235d, c: 0.7788691278257713d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1908397739));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36399675452528046d, b: 0.21180965313124933d, c: 0.6232643186817026d),

new NpgsqlTypes.NpgsqlLine(a: 0.8377534917307251d, b: 0.7197248111141329d, c: 0.5638759891270843d),

new NpgsqlTypes.NpgsqlLine(a: 0.9127913721936561d, b: 0.47658260676426356d, c: 0.4401534500107992d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.502181779437056d, b: 0.3652805047459293d, c: 0.32001644451474576d),

new NpgsqlTypes.NpgsqlLine(a: 0.7113651445912559d, b: 0.3869191031273206d, c: 0.7332400621535746d),

new NpgsqlTypes.NpgsqlLine(a: 0.5302147002696467d, b: 0.6514960201183412d, c: 0.8888784836070758d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1921152006));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3706659351474607d, b: 0.20392121211971403d, c: 0.09026673921559647d),

new NpgsqlTypes.NpgsqlLine(a: 0.3426907809834573d, b: 0.11597889224231583d, c: 0.37580383029156417d),

new NpgsqlTypes.NpgsqlLine(a: 0.9569454063294334d, b: 0.5352074925592666d, c: 0.1505041653825815d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(322154126));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17316937563192347d, b: 0.7977878569807266d, c: 0.5061623155222499d),

new NpgsqlTypes.NpgsqlLine(a: 0.39020299771548206d, b: 0.46872469438895703d, c: 0.1947250961658502d),

new NpgsqlTypes.NpgsqlLine(a: 0.9460666899443665d, b: 0.40873002207057996d, c: 0.5383135596603867d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931477721));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24029930494024243d, b: 0.6494520983530296d, c: 0.6457904476196421d),

new NpgsqlTypes.NpgsqlLine(a: 0.5413106581652064d, b: 0.65922568011039d, c: 0.023000101756869618d),

new NpgsqlTypes.NpgsqlLine(a: 0.05698461456670889d, b: 0.07946838244893384d, c: 0.023133320459978735d),

new NpgsqlTypes.NpgsqlLine(a: 0.023417572430763367d, b: 0.20022755743974863d, c: 0.9001563624157146d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3818728397283605d, b: 0.24081372003152057d, c: 0.42604600108359325d),

new NpgsqlTypes.NpgsqlLine(a: 0.9919565701428744d, b: 0.9836921588174795d, c: 0.6353618672799166d),

new NpgsqlTypes.NpgsqlLine(a: 0.49779514301225014d, b: 0.9235637976007209d, c: 0.26480996790155775d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943853869));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5132420668035784d, b: 0.9613252483783701d, c: 0.9242449431625296d),

new NpgsqlTypes.NpgsqlLine(a: 0.36653456446188004d, b: 0.7359631901409467d, c: 0.27792441954855884d),

new NpgsqlTypes.NpgsqlLine(a: 0.4636783251093567d, b: 0.1186591604974756d, c: 0.39388519565520497d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1951774404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4334255210533513d, b: 0.5785255926410576d, c: 0.9661508534687067d),

new NpgsqlTypes.NpgsqlLine(a: 0.19775236418153797d, b: 0.9365672085879589d, c: 0.1494826860380959d),

new NpgsqlTypes.NpgsqlLine(a: 0.176207462329397d, b: 0.2629253672101627d, c: 0.07007543599573873d),

new NpgsqlTypes.NpgsqlLine(a: 0.12818842182277845d, b: 0.1863366614728862d, c: 0.7134229928630377d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6151166351904711d, b: 0.2498835420322547d, c: 0.9733560033126378d),

new NpgsqlTypes.NpgsqlLine(a: 0.7516653963992566d, b: 0.8871254006140514d, c: 0.9688544000775576d),

new NpgsqlTypes.NpgsqlLine(a: 0.5920030979667459d, b: 0.19764908877922582d, c: 0.5631519149614208d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 548719832);
                var models =  ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(25));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(569222828));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3541781533895836d, b: 0.8806877333215982d, c: 0.3434395351862555d),

new NpgsqlTypes.NpgsqlLine(a: 0.904182291889472d, b: 0.2725232832902962d, c: 0.11922376175569749d),

new NpgsqlTypes.NpgsqlLine(a: 0.2973949214938665d, b: 0.551548200515303d, c: 0.11510798755200236d),

new NpgsqlTypes.NpgsqlLine(a: 0.6236383027800103d, b: 0.7132402356425214d, c: 0.7946866828405127d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1120533763));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7797869567083358d, b: 0.2361739464389747d, c: 0.48164557546500963d),

new NpgsqlTypes.NpgsqlLine(a: 0.9480048066554808d, b: 0.8035492224666504d, c: 0.9832497213764478d),

new NpgsqlTypes.NpgsqlLine(a: 0.9772596541640088d, b: 0.6093516798517065d, c: 0.6052760903401032d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(617125650));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35787275736319957d, b: 0.702047825867143d, c: 0.965415572167533d),

new NpgsqlTypes.NpgsqlLine(a: 0.31090623461505584d, b: 0.5647177423851781d, c: 0.4846654296503867d),

new NpgsqlTypes.NpgsqlLine(a: 0.3183862992195977d, b: 0.6261458826331173d, c: 0.6907068588712774d),

new NpgsqlTypes.NpgsqlLine(a: 0.6487979418902344d, b: 0.4615179308283234d, c: 0.642127574912425d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9197027266355764d, b: 0.39215058098740485d, c: 0.17261332753094694d),

new NpgsqlTypes.NpgsqlLine(a: 0.11391459246246716d, b: 0.8528811542175645d, c: 0.20274869752530522d),

new NpgsqlTypes.NpgsqlLine(a: 0.36907637605105814d, b: 0.6376511000289307d, c: 0.12998307736849357d),

new NpgsqlTypes.NpgsqlLine(a: 0.9580086581171673d, b: 0.03050170247729178d, c: 0.38029624192446d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1413412459));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42503376733197573d, b: 0.763237079678654d, c: 0.09688502535476584d),

new NpgsqlTypes.NpgsqlLine(a: 0.23240822962655505d, b: 0.8459480271218152d, c: 0.08432931494869422d),

new NpgsqlTypes.NpgsqlLine(a: 0.18886663761414113d, b: 0.5079561486308892d, c: 0.9843388801596968d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(627974170));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15147399565049113d, b: 0.7627100647125816d, c: 0.16010235385722305d),

new NpgsqlTypes.NpgsqlLine(a: 0.9001358065765852d, b: 0.4721890907147458d, c: 0.15927787372271784d),

new NpgsqlTypes.NpgsqlLine(a: 0.7813049144298684d, b: 0.4136335409837938d, c: 0.12660196714031435d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.004236560392559818d, b: 0.39606208609499893d, c: 0.19741769434420997d),

new NpgsqlTypes.NpgsqlLine(a: 0.5953646586031078d, b: 0.6151314480582013d, c: 0.6556527973910132d),

new NpgsqlTypes.NpgsqlLine(a: 0.5407811339876436d, b: 0.9334248245144674d, c: 0.8365874899469636d),

new NpgsqlTypes.NpgsqlLine(a: 0.4764002070454937d, b: 0.16718217080509323d, c: 0.17236129187105342d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(791579102));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3341739254022562d, b: 0.718465753134697d, c: 0.5771634629019262d),

new NpgsqlTypes.NpgsqlLine(a: 0.6322200521292398d, b: 0.8246392866857581d, c: 0.5696079494467468d),

new NpgsqlTypes.NpgsqlLine(a: 0.6545382710133834d, b: 0.4365654599867256d, c: 0.8153585418393168d),

new NpgsqlTypes.NpgsqlLine(a: 0.0910019439659393d, b: 0.7174745892954046d, c: 0.1511089208473413d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1190383178));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12466334172066618d, b: 0.11152073168077081d, c: 0.491230984381532d),

new NpgsqlTypes.NpgsqlLine(a: 0.5547266175262346d, b: 0.13792449594977796d, c: 0.7570674004021489d),

new NpgsqlTypes.NpgsqlLine(a: 0.2085058544453703d, b: 0.08290359377194412d, c: 0.77495272781113d),

new NpgsqlTypes.NpgsqlLine(a: 0.49111506712078934d, b: 0.641116986925848d, c: 0.29516341556351666d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07914996961984966d, b: 0.4871418257809952d, c: 0.7513322508300865d),

new NpgsqlTypes.NpgsqlLine(a: 0.9239635289951339d, b: 0.38794777551433746d, c: 0.676783160212782d),

new NpgsqlTypes.NpgsqlLine(a: 0.0955538255878925d, b: 0.01055236041931451d, c: 0.2842563281409253d),

new NpgsqlTypes.NpgsqlLine(a: 0.02927332855673237d, b: 0.6165842674891228d, c: 0.8012173905302888d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(833599485));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4822973119466689d, b: 0.792513536759573d, c: 0.499633501292873d),

new NpgsqlTypes.NpgsqlLine(a: 0.8918073488512478d, b: 0.42208129985829845d, c: 0.5329638256901381d),

new NpgsqlTypes.NpgsqlLine(a: 0.5188620987187985d, b: 0.1726952436096839d, c: 0.7227459582321649d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15666178016283616d, b: 0.2873368213961791d, c: 0.4420895689102471d),

new NpgsqlTypes.NpgsqlLine(a: 0.4601057867375493d, b: 0.5622721416121373d, c: 0.2999980165807573d),

new NpgsqlTypes.NpgsqlLine(a: 0.8381583831951187d, b: 0.9764919740330239d, c: 0.18152562681640294d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1272632761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8378269016529278d, b: 0.6733240332238696d, c: 0.8919506779863193d),

new NpgsqlTypes.NpgsqlLine(a: 0.48570634731194795d, b: 0.1596671151368555d, c: 0.20750860994967846d),

new NpgsqlTypes.NpgsqlLine(a: 0.779653513645174d, b: 0.8586337096501773d, c: 0.1738735269722934d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2675334980310755d, b: 0.5860654638502302d, c: 0.5223481489931099d),

new NpgsqlTypes.NpgsqlLine(a: 0.2908190505712529d, b: 0.027311571062217044d, c: 0.38897855152716554d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590347289639254d, b: 0.6110078502040162d, c: 0.9773066927065011d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(896715967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4784147382307862d, b: 0.6552419336185478d, c: 0.920823919677529d),

new NpgsqlTypes.NpgsqlLine(a: 0.742593437228071d, b: 0.6268935209443758d, c: 0.5071732457335109d),

new NpgsqlTypes.NpgsqlLine(a: 0.6253496198816004d, b: 0.5361783003872929d, c: 0.7158348891331027d),

new NpgsqlTypes.NpgsqlLine(a: 0.4294538215627851d, b: 0.8234156672775046d, c: 0.08688024353682888d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(117280179));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3605977641294892d, b: 0.17811158147680461d, c: 0.9658058071756186d),

new NpgsqlTypes.NpgsqlLine(a: 0.6970256025820155d, b: 0.5444046414962291d, c: 0.46720686007108925d),

new NpgsqlTypes.NpgsqlLine(a: 0.8561050660597573d, b: 0.11353237597432853d, c: 0.56669941414895d),

new NpgsqlTypes.NpgsqlLine(a: 0.7984600619309864d, b: 0.8109151931011057d, c: 0.769305377302455d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0947306689172811d, b: 0.8302577671800684d, c: 0.8970532400118938d),

new NpgsqlTypes.NpgsqlLine(a: 0.2407748752003226d, b: 0.4567310255560061d, c: 0.4526792803927874d),

new NpgsqlTypes.NpgsqlLine(a: 0.04496104252758981d, b: 0.7589917027634498d, c: 0.6770421060059869d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(899804594));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1970857537444196d, b: 0.9333242638108382d, c: 0.2997924017071659d),

new NpgsqlTypes.NpgsqlLine(a: 0.6311349404614687d, b: 0.19618574736695826d, c: 0.38842914242231885d),

new NpgsqlTypes.NpgsqlLine(a: 0.8616526286116198d, b: 0.5020108677923993d, c: 0.7507796571723376d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8462722154822349d, b: 0.2140170588076531d, c: 0.1555300802445071d),

new NpgsqlTypes.NpgsqlLine(a: 0.05107346767082066d, b: 0.6007632357415391d, c: 0.11568725974145999d),

new NpgsqlTypes.NpgsqlLine(a: 0.9923537289603477d, b: 0.4950249871115745d, c: 0.02343990901364046d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(964637978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7665509369596407d, b: 0.32246651386445413d, c: 0.4163237996846909d),

new NpgsqlTypes.NpgsqlLine(a: 0.622867187513811d, b: 0.02481599358005626d, c: 0.6781914372848628d),

new NpgsqlTypes.NpgsqlLine(a: 0.9383962517038102d, b: 0.22799617371669267d, c: 0.11769282658114588d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1006841713));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3814391347607825d, b: 0.6500010795000312d, c: 0.5168910912789877d),

new NpgsqlTypes.NpgsqlLine(a: 0.9809725325416359d, b: 0.5965089551877092d, c: 0.9620206915411497d),

new NpgsqlTypes.NpgsqlLine(a: 0.8326177257415529d, b: 0.9726427466112844d, c: 0.44743910631138517d),

new NpgsqlTypes.NpgsqlLine(a: 0.9428905413649304d, b: 0.2742783552238923d, c: 0.20624247958140818d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4156588878635493d, b: 0.9311562710078888d, c: 0.18729745760128813d),

new NpgsqlTypes.NpgsqlLine(a: 0.7838364754377413d, b: 0.2902143764264882d, c: 0.6468999105347263d),

new NpgsqlTypes.NpgsqlLine(a: 0.2807400125401047d, b: 0.4738433713063067d, c: 0.3414032292061351d),

new NpgsqlTypes.NpgsqlLine(a: 0.07976939589399212d, b: 0.6817427263698487d, c: 0.7162950229594492d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1008288557));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6703103585772012d, b: 0.9414469448287122d, c: 0.32961805156524826d),

new NpgsqlTypes.NpgsqlLine(a: 0.13239408457631574d, b: 0.5134528929025426d, c: 0.5412589816963953d),

new NpgsqlTypes.NpgsqlLine(a: 0.1699098825091695d, b: 0.9194545880639252d, c: 0.7451240040858685d),

new NpgsqlTypes.NpgsqlLine(a: 0.2233903417330374d, b: 0.07771599830861675d, c: 0.5752102020647447d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(723640790));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8545769023218451d, b: 0.24286566112974062d, c: 0.24373271509232275d),

new NpgsqlTypes.NpgsqlLine(a: 0.8731571462637403d, b: 0.9993617334238951d, c: 0.1725755360195571d),

new NpgsqlTypes.NpgsqlLine(a: 0.2467482163165423d, b: 0.7309207508122816d, c: 0.574326589073651d),

new NpgsqlTypes.NpgsqlLine(a: 0.39429370255535745d, b: 0.12918013405283635d, c: 0.37279548432778786d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8697103680615146d, b: 0.4868697197066526d, c: 0.008300202872866591d),

new NpgsqlTypes.NpgsqlLine(a: 0.9268152455195247d, b: 0.9945415027788427d, c: 0.33225561051564245d),

new NpgsqlTypes.NpgsqlLine(a: 0.06541514412119742d, b: 0.29832372565206444d, c: 0.34837671529944225d),

new NpgsqlTypes.NpgsqlLine(a: 0.7703107306167513d, b: 0.39150187650435253d, c: 0.17912768771478083d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1212970907));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5991478813435879d, b: 0.21696546349723422d, c: 0.7473704822066682d),

new NpgsqlTypes.NpgsqlLine(a: 0.151066097236479d, b: 0.0802844223551269d, c: 0.09162465810768494d),

new NpgsqlTypes.NpgsqlLine(a: 0.8623052986382002d, b: 0.9298840839917386d, c: 0.6660510239194597d),

new NpgsqlTypes.NpgsqlLine(a: 0.9991351159913222d, b: 0.029361445428178645d, c: 0.30760770391653036d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2140414751));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5666355568463651d, b: 0.5532657932652175d, c: 0.043303548850170626d),

new NpgsqlTypes.NpgsqlLine(a: 0.4900959494886681d, b: 0.9349750472343457d, c: 0.4121355471301291d),

new NpgsqlTypes.NpgsqlLine(a: 0.06398838318692368d, b: 0.028285739863693204d, c: 0.8052480125394759d),

new NpgsqlTypes.NpgsqlLine(a: 0.31673961185856914d, b: 0.4141587759463713d, c: 0.1893488396111126d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1370558129));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9082169806472872d, b: 0.9235120225757552d, c: 0.8994934710072177d),

new NpgsqlTypes.NpgsqlLine(a: 0.12419478532476513d, b: 0.805126203795883d, c: 0.21123699569220133d),

new NpgsqlTypes.NpgsqlLine(a: 0.5518835410640954d, b: 0.3470463651950829d, c: 0.4121461426388031d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(196308953));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28578713252269017d, b: 0.8474368218362299d, c: 0.05146566977408318d),

new NpgsqlTypes.NpgsqlLine(a: 0.9109299616024349d, b: 0.5870141058904383d, c: 0.7452912896149598d),

new NpgsqlTypes.NpgsqlLine(a: 0.09671303857190205d, b: 0.22234046410281205d, c: 0.2889776640209598d),

new NpgsqlTypes.NpgsqlLine(a: 0.3594930797393622d, b: 0.1261117062789614d, c: 0.4836691385976134d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1411554384));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.43292849531653743d, b: 0.10139772092942057d, c: 0.19581477698464556d),

new NpgsqlTypes.NpgsqlLine(a: 0.7747830082073887d, b: 0.7612727046736724d, c: 0.49585407932443326d),

new NpgsqlTypes.NpgsqlLine(a: 0.7534769161594925d, b: 0.21640631521439513d, c: 0.9417215429915208d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1423267657));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7028157888188539d, b: 0.4434497177574276d, c: 0.1878584904244096d),

new NpgsqlTypes.NpgsqlLine(a: 0.12779644786129707d, b: 0.6547737034235738d, c: 0.7340324477099678d),

new NpgsqlTypes.NpgsqlLine(a: 0.13473852180731738d, b: 0.7900921279332365d, c: 0.7695417103969711d),

new NpgsqlTypes.NpgsqlLine(a: 0.2618677281295215d, b: 0.24821010444457137d, c: 0.2711393719015588d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1610745034));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6382266935775643d, b: 0.398693329671132d, c: 0.7425094436899613d),

new NpgsqlTypes.NpgsqlLine(a: 0.24327741116998813d, b: 0.1635267687203752d, c: 0.628031718062037d),

new NpgsqlTypes.NpgsqlLine(a: 0.38459544322295613d, b: 0.4141132804519537d, c: 0.8511486540491503d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9861241662988156d, b: 0.25399030999510996d, c: 0.2529918964264557d),

new NpgsqlTypes.NpgsqlLine(a: 0.17574090331875702d, b: 0.5215697754670754d, c: 0.49092403723555744d),

new NpgsqlTypes.NpgsqlLine(a: 0.9755215010138426d, b: 0.5836706698542481d, c: 0.8112425273051307d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1525343338));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5334739519154116d, b: 0.14533927203574382d, c: 0.9972375896646379d),

new NpgsqlTypes.NpgsqlLine(a: 0.5376404385911305d, b: 0.3967355325520928d, c: 0.2690585850054501d),

new NpgsqlTypes.NpgsqlLine(a: 0.7930288640515465d, b: 0.4034090749439643d, c: 0.19977351395319798d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22585130451050572d, b: 0.054454055462575424d, c: 0.3670135684186787d),

new NpgsqlTypes.NpgsqlLine(a: 0.8573417118252535d, b: 0.7290365889192361d, c: 0.15771025911629288d),

new NpgsqlTypes.NpgsqlLine(a: 0.8294206137900973d, b: 0.778292553399524d, c: 0.5844131999897239d),

new NpgsqlTypes.NpgsqlLine(a: 0.8795242286168519d, b: 0.43336364459496624d, c: 0.07939237473054006d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1618779845));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588222459861263d, b: 0.8314528851615401d, c: 0.4091425195520225d),

new NpgsqlTypes.NpgsqlLine(a: 0.15497545879234587d, b: 0.42501177297812087d, c: 0.3930386900482442d),

new NpgsqlTypes.NpgsqlLine(a: 0.49932759733861587d, b: 0.27860846401633954d, c: 0.22371479209453393d),

new NpgsqlTypes.NpgsqlLine(a: 0.6744750487770321d, b: 0.5185555306309229d, c: 0.48333909912156325d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6846715107366038d, b: 0.7822398219668835d, c: 0.6995656002724597d),

new NpgsqlTypes.NpgsqlLine(a: 0.34191163697506577d, b: 0.251427920689659d, c: 0.6372400180339429d),

new NpgsqlTypes.NpgsqlLine(a: 0.7615638356664386d, b: 0.38275705185682163d, c: 0.9430695395246483d),

new NpgsqlTypes.NpgsqlLine(a: 0.25861736938688795d, b: 0.2236086093911689d, c: 0.43081968027669826d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(111191550));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10079392481388938d, b: 0.47419284524344363d, c: 0.46999813598135487d),

new NpgsqlTypes.NpgsqlLine(a: 0.4512330545433114d, b: 0.7685777654216315d, c: 0.761484461621478d),

new NpgsqlTypes.NpgsqlLine(a: 0.7069502335832981d, b: 0.10867536284292001d, c: 0.803973548621565d),

new NpgsqlTypes.NpgsqlLine(a: 0.6710482193897285d, b: 0.3246300803211939d, c: 0.007931088387647223d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1651600176));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16882852097245493d, b: 0.6320810387310721d, c: 0.4943119337666173d),

new NpgsqlTypes.NpgsqlLine(a: 0.1864608664190791d, b: 0.3923939341785333d, c: 0.40778672849944797d),

new NpgsqlTypes.NpgsqlLine(a: 0.21658079009283382d, b: 0.9735580473103661d, c: 0.5313780798893142d),

new NpgsqlTypes.NpgsqlLine(a: 0.608447080933292d, b: 0.9095061095638245d, c: 0.664417030599092d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1656686707));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08369873952495288d, b: 0.07788317757867735d, c: 0.284112517861248d),

new NpgsqlTypes.NpgsqlLine(a: 0.617171498263342d, b: 0.5865508373972511d, c: 0.36018099841433293d),

new NpgsqlTypes.NpgsqlLine(a: 0.4798021589910493d, b: 0.5378837702166812d, c: 0.2195325878675365d),

new NpgsqlTypes.NpgsqlLine(a: 0.961753857136392d, b: 0.8919192421134503d, c: 0.16540674234160435d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1264360862));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3150738269575506d, b: 0.25723902915678687d, c: 0.7085220942560913d),

new NpgsqlTypes.NpgsqlLine(a: 0.10217399526832571d, b: 0.23606907248025677d, c: 0.14832581681823231d),

new NpgsqlTypes.NpgsqlLine(a: 0.38475783269574504d, b: 0.261674953378639d, c: 0.8414017715374641d),

new NpgsqlTypes.NpgsqlLine(a: 0.060969244577031345d, b: 0.7001282741779633d, c: 0.8180532031964253d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1800975967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6019711101236188d, b: 0.451502314152629d, c: 0.7567258646896037d),

new NpgsqlTypes.NpgsqlLine(a: 0.20314867633928102d, b: 0.43694052621738755d, c: 0.07972430095228344d),

new NpgsqlTypes.NpgsqlLine(a: 0.38639176328531444d, b: 0.5546727142910798d, c: 0.3595107666863845d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(116492752));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8534388679989421d, b: 0.17051639981163313d, c: 0.11184373953100968d),

new NpgsqlTypes.NpgsqlLine(a: 0.5545649696933802d, b: 0.6495249060333349d, c: 0.14480165352840013d),

new NpgsqlTypes.NpgsqlLine(a: 0.7068689700072772d, b: 0.10325704725403717d, c: 0.1383403540154834d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.565937691937727d, b: 0.8643068916219007d, c: 0.7899347881580714d),

new NpgsqlTypes.NpgsqlLine(a: 0.5461437063589625d, b: 0.8396992488239946d, c: 0.4549808859483121d),

new NpgsqlTypes.NpgsqlLine(a: 0.11142572920429805d, b: 0.7092154686109046d, c: 0.04531658445440445d),

new NpgsqlTypes.NpgsqlLine(a: 0.8590566964589479d, b: 0.07365357454587718d, c: 0.01783865983951749d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858289195));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25032438445726d, b: 0.0917391846373673d, c: 0.34066051809002806d),

new NpgsqlTypes.NpgsqlLine(a: 0.07831144663304057d, b: 0.77591037387439d, c: 0.19759580235224372d),

new NpgsqlTypes.NpgsqlLine(a: 0.3752205191956137d, b: 0.9100313386910368d, c: 0.6525871812195568d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47106408656007914d, b: 0.14257658261320605d, c: 0.47373760961489964d),

new NpgsqlTypes.NpgsqlLine(a: 0.4366806562773925d, b: 0.20146202051894901d, c: 0.3244113712884158d),

new NpgsqlTypes.NpgsqlLine(a: 0.41468311552317627d, b: 0.27557991533085235d, c: 0.7788691278257713d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1908397739));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36399675452528046d, b: 0.21180965313124933d, c: 0.6232643186817026d),

new NpgsqlTypes.NpgsqlLine(a: 0.8377534917307251d, b: 0.7197248111141329d, c: 0.5638759891270843d),

new NpgsqlTypes.NpgsqlLine(a: 0.9127913721936561d, b: 0.47658260676426356d, c: 0.4401534500107992d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.502181779437056d, b: 0.3652805047459293d, c: 0.32001644451474576d),

new NpgsqlTypes.NpgsqlLine(a: 0.7113651445912559d, b: 0.3869191031273206d, c: 0.7332400621535746d),

new NpgsqlTypes.NpgsqlLine(a: 0.5302147002696467d, b: 0.6514960201183412d, c: 0.8888784836070758d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1921152006));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3706659351474607d, b: 0.20392121211971403d, c: 0.09026673921559647d),

new NpgsqlTypes.NpgsqlLine(a: 0.3426907809834573d, b: 0.11597889224231583d, c: 0.37580383029156417d),

new NpgsqlTypes.NpgsqlLine(a: 0.9569454063294334d, b: 0.5352074925592666d, c: 0.1505041653825815d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(322154126));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17316937563192347d, b: 0.7977878569807266d, c: 0.5061623155222499d),

new NpgsqlTypes.NpgsqlLine(a: 0.39020299771548206d, b: 0.46872469438895703d, c: 0.1947250961658502d),

new NpgsqlTypes.NpgsqlLine(a: 0.9460666899443665d, b: 0.40873002207057996d, c: 0.5383135596603867d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931477721));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24029930494024243d, b: 0.6494520983530296d, c: 0.6457904476196421d),

new NpgsqlTypes.NpgsqlLine(a: 0.5413106581652064d, b: 0.65922568011039d, c: 0.023000101756869618d),

new NpgsqlTypes.NpgsqlLine(a: 0.05698461456670889d, b: 0.07946838244893384d, c: 0.023133320459978735d),

new NpgsqlTypes.NpgsqlLine(a: 0.023417572430763367d, b: 0.20022755743974863d, c: 0.9001563624157146d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3818728397283605d, b: 0.24081372003152057d, c: 0.42604600108359325d),

new NpgsqlTypes.NpgsqlLine(a: 0.9919565701428744d, b: 0.9836921588174795d, c: 0.6353618672799166d),

new NpgsqlTypes.NpgsqlLine(a: 0.49779514301225014d, b: 0.9235637976007209d, c: 0.26480996790155775d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943853869));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5132420668035784d, b: 0.9613252483783701d, c: 0.9242449431625296d),

new NpgsqlTypes.NpgsqlLine(a: 0.36653456446188004d, b: 0.7359631901409467d, c: 0.27792441954855884d),

new NpgsqlTypes.NpgsqlLine(a: 0.4636783251093567d, b: 0.1186591604974756d, c: 0.39388519565520497d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1951774404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4334255210533513d, b: 0.5785255926410576d, c: 0.9661508534687067d),

new NpgsqlTypes.NpgsqlLine(a: 0.19775236418153797d, b: 0.9365672085879589d, c: 0.1494826860380959d),

new NpgsqlTypes.NpgsqlLine(a: 0.176207462329397d, b: 0.2629253672101627d, c: 0.07007543599573873d),

new NpgsqlTypes.NpgsqlLine(a: 0.12818842182277845d, b: 0.1863366614728862d, c: 0.7134229928630377d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6151166351904711d, b: 0.2498835420322547d, c: 0.9733560033126378d),

new NpgsqlTypes.NpgsqlLine(a: 0.7516653963992566d, b: 0.8871254006140514d, c: 0.9688544000775576d),

new NpgsqlTypes.NpgsqlLine(a: 0.5920030979667459d, b: 0.19764908877922582d, c: 0.5631519149614208d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 1370558129);
                var models = await ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(13));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1411554384));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.43292849531653743d, b: 0.10139772092942057d, c: 0.19581477698464556d),

new NpgsqlTypes.NpgsqlLine(a: 0.7747830082073887d, b: 0.7612727046736724d, c: 0.49585407932443326d),

new NpgsqlTypes.NpgsqlLine(a: 0.7534769161594925d, b: 0.21640631521439513d, c: 0.9417215429915208d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1423267657));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7028157888188539d, b: 0.4434497177574276d, c: 0.1878584904244096d),

new NpgsqlTypes.NpgsqlLine(a: 0.12779644786129707d, b: 0.6547737034235738d, c: 0.7340324477099678d),

new NpgsqlTypes.NpgsqlLine(a: 0.13473852180731738d, b: 0.7900921279332365d, c: 0.7695417103969711d),

new NpgsqlTypes.NpgsqlLine(a: 0.2618677281295215d, b: 0.24821010444457137d, c: 0.2711393719015588d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1610745034));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6382266935775643d, b: 0.398693329671132d, c: 0.7425094436899613d),

new NpgsqlTypes.NpgsqlLine(a: 0.24327741116998813d, b: 0.1635267687203752d, c: 0.628031718062037d),

new NpgsqlTypes.NpgsqlLine(a: 0.38459544322295613d, b: 0.4141132804519537d, c: 0.8511486540491503d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9861241662988156d, b: 0.25399030999510996d, c: 0.2529918964264557d),

new NpgsqlTypes.NpgsqlLine(a: 0.17574090331875702d, b: 0.5215697754670754d, c: 0.49092403723555744d),

new NpgsqlTypes.NpgsqlLine(a: 0.9755215010138426d, b: 0.5836706698542481d, c: 0.8112425273051307d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1525343338));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5334739519154116d, b: 0.14533927203574382d, c: 0.9972375896646379d),

new NpgsqlTypes.NpgsqlLine(a: 0.5376404385911305d, b: 0.3967355325520928d, c: 0.2690585850054501d),

new NpgsqlTypes.NpgsqlLine(a: 0.7930288640515465d, b: 0.4034090749439643d, c: 0.19977351395319798d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22585130451050572d, b: 0.054454055462575424d, c: 0.3670135684186787d),

new NpgsqlTypes.NpgsqlLine(a: 0.8573417118252535d, b: 0.7290365889192361d, c: 0.15771025911629288d),

new NpgsqlTypes.NpgsqlLine(a: 0.8294206137900973d, b: 0.778292553399524d, c: 0.5844131999897239d),

new NpgsqlTypes.NpgsqlLine(a: 0.8795242286168519d, b: 0.43336364459496624d, c: 0.07939237473054006d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1618779845));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588222459861263d, b: 0.8314528851615401d, c: 0.4091425195520225d),

new NpgsqlTypes.NpgsqlLine(a: 0.15497545879234587d, b: 0.42501177297812087d, c: 0.3930386900482442d),

new NpgsqlTypes.NpgsqlLine(a: 0.49932759733861587d, b: 0.27860846401633954d, c: 0.22371479209453393d),

new NpgsqlTypes.NpgsqlLine(a: 0.6744750487770321d, b: 0.5185555306309229d, c: 0.48333909912156325d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6846715107366038d, b: 0.7822398219668835d, c: 0.6995656002724597d),

new NpgsqlTypes.NpgsqlLine(a: 0.34191163697506577d, b: 0.251427920689659d, c: 0.6372400180339429d),

new NpgsqlTypes.NpgsqlLine(a: 0.7615638356664386d, b: 0.38275705185682163d, c: 0.9430695395246483d),

new NpgsqlTypes.NpgsqlLine(a: 0.25861736938688795d, b: 0.2236086093911689d, c: 0.43081968027669826d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(111191550));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10079392481388938d, b: 0.47419284524344363d, c: 0.46999813598135487d),

new NpgsqlTypes.NpgsqlLine(a: 0.4512330545433114d, b: 0.7685777654216315d, c: 0.761484461621478d),

new NpgsqlTypes.NpgsqlLine(a: 0.7069502335832981d, b: 0.10867536284292001d, c: 0.803973548621565d),

new NpgsqlTypes.NpgsqlLine(a: 0.6710482193897285d, b: 0.3246300803211939d, c: 0.007931088387647223d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1651600176));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16882852097245493d, b: 0.6320810387310721d, c: 0.4943119337666173d),

new NpgsqlTypes.NpgsqlLine(a: 0.1864608664190791d, b: 0.3923939341785333d, c: 0.40778672849944797d),

new NpgsqlTypes.NpgsqlLine(a: 0.21658079009283382d, b: 0.9735580473103661d, c: 0.5313780798893142d),

new NpgsqlTypes.NpgsqlLine(a: 0.608447080933292d, b: 0.9095061095638245d, c: 0.664417030599092d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1656686707));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08369873952495288d, b: 0.07788317757867735d, c: 0.284112517861248d),

new NpgsqlTypes.NpgsqlLine(a: 0.617171498263342d, b: 0.5865508373972511d, c: 0.36018099841433293d),

new NpgsqlTypes.NpgsqlLine(a: 0.4798021589910493d, b: 0.5378837702166812d, c: 0.2195325878675365d),

new NpgsqlTypes.NpgsqlLine(a: 0.961753857136392d, b: 0.8919192421134503d, c: 0.16540674234160435d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1264360862));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3150738269575506d, b: 0.25723902915678687d, c: 0.7085220942560913d),

new NpgsqlTypes.NpgsqlLine(a: 0.10217399526832571d, b: 0.23606907248025677d, c: 0.14832581681823231d),

new NpgsqlTypes.NpgsqlLine(a: 0.38475783269574504d, b: 0.261674953378639d, c: 0.8414017715374641d),

new NpgsqlTypes.NpgsqlLine(a: 0.060969244577031345d, b: 0.7001282741779633d, c: 0.8180532031964253d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1800975967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6019711101236188d, b: 0.451502314152629d, c: 0.7567258646896037d),

new NpgsqlTypes.NpgsqlLine(a: 0.20314867633928102d, b: 0.43694052621738755d, c: 0.07972430095228344d),

new NpgsqlTypes.NpgsqlLine(a: 0.38639176328531444d, b: 0.5546727142910798d, c: 0.3595107666863845d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(116492752));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8534388679989421d, b: 0.17051639981163313d, c: 0.11184373953100968d),

new NpgsqlTypes.NpgsqlLine(a: 0.5545649696933802d, b: 0.6495249060333349d, c: 0.14480165352840013d),

new NpgsqlTypes.NpgsqlLine(a: 0.7068689700072772d, b: 0.10325704725403717d, c: 0.1383403540154834d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.565937691937727d, b: 0.8643068916219007d, c: 0.7899347881580714d),

new NpgsqlTypes.NpgsqlLine(a: 0.5461437063589625d, b: 0.8396992488239946d, c: 0.4549808859483121d),

new NpgsqlTypes.NpgsqlLine(a: 0.11142572920429805d, b: 0.7092154686109046d, c: 0.04531658445440445d),

new NpgsqlTypes.NpgsqlLine(a: 0.8590566964589479d, b: 0.07365357454587718d, c: 0.01783865983951749d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858289195));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25032438445726d, b: 0.0917391846373673d, c: 0.34066051809002806d),

new NpgsqlTypes.NpgsqlLine(a: 0.07831144663304057d, b: 0.77591037387439d, c: 0.19759580235224372d),

new NpgsqlTypes.NpgsqlLine(a: 0.3752205191956137d, b: 0.9100313386910368d, c: 0.6525871812195568d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47106408656007914d, b: 0.14257658261320605d, c: 0.47373760961489964d),

new NpgsqlTypes.NpgsqlLine(a: 0.4366806562773925d, b: 0.20146202051894901d, c: 0.3244113712884158d),

new NpgsqlTypes.NpgsqlLine(a: 0.41468311552317627d, b: 0.27557991533085235d, c: 0.7788691278257713d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1908397739));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36399675452528046d, b: 0.21180965313124933d, c: 0.6232643186817026d),

new NpgsqlTypes.NpgsqlLine(a: 0.8377534917307251d, b: 0.7197248111141329d, c: 0.5638759891270843d),

new NpgsqlTypes.NpgsqlLine(a: 0.9127913721936561d, b: 0.47658260676426356d, c: 0.4401534500107992d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.502181779437056d, b: 0.3652805047459293d, c: 0.32001644451474576d),

new NpgsqlTypes.NpgsqlLine(a: 0.7113651445912559d, b: 0.3869191031273206d, c: 0.7332400621535746d),

new NpgsqlTypes.NpgsqlLine(a: 0.5302147002696467d, b: 0.6514960201183412d, c: 0.8888784836070758d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1921152006));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3706659351474607d, b: 0.20392121211971403d, c: 0.09026673921559647d),

new NpgsqlTypes.NpgsqlLine(a: 0.3426907809834573d, b: 0.11597889224231583d, c: 0.37580383029156417d),

new NpgsqlTypes.NpgsqlLine(a: 0.9569454063294334d, b: 0.5352074925592666d, c: 0.1505041653825815d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(322154126));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17316937563192347d, b: 0.7977878569807266d, c: 0.5061623155222499d),

new NpgsqlTypes.NpgsqlLine(a: 0.39020299771548206d, b: 0.46872469438895703d, c: 0.1947250961658502d),

new NpgsqlTypes.NpgsqlLine(a: 0.9460666899443665d, b: 0.40873002207057996d, c: 0.5383135596603867d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931477721));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24029930494024243d, b: 0.6494520983530296d, c: 0.6457904476196421d),

new NpgsqlTypes.NpgsqlLine(a: 0.5413106581652064d, b: 0.65922568011039d, c: 0.023000101756869618d),

new NpgsqlTypes.NpgsqlLine(a: 0.05698461456670889d, b: 0.07946838244893384d, c: 0.023133320459978735d),

new NpgsqlTypes.NpgsqlLine(a: 0.023417572430763367d, b: 0.20022755743974863d, c: 0.9001563624157146d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3818728397283605d, b: 0.24081372003152057d, c: 0.42604600108359325d),

new NpgsqlTypes.NpgsqlLine(a: 0.9919565701428744d, b: 0.9836921588174795d, c: 0.6353618672799166d),

new NpgsqlTypes.NpgsqlLine(a: 0.49779514301225014d, b: 0.9235637976007209d, c: 0.26480996790155775d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943853869));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5132420668035784d, b: 0.9613252483783701d, c: 0.9242449431625296d),

new NpgsqlTypes.NpgsqlLine(a: 0.36653456446188004d, b: 0.7359631901409467d, c: 0.27792441954855884d),

new NpgsqlTypes.NpgsqlLine(a: 0.4636783251093567d, b: 0.1186591604974756d, c: 0.39388519565520497d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1951774404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4334255210533513d, b: 0.5785255926410576d, c: 0.9661508534687067d),

new NpgsqlTypes.NpgsqlLine(a: 0.19775236418153797d, b: 0.9365672085879589d, c: 0.1494826860380959d),

new NpgsqlTypes.NpgsqlLine(a: 0.176207462329397d, b: 0.2629253672101627d, c: 0.07007543599573873d),

new NpgsqlTypes.NpgsqlLine(a: 0.12818842182277845d, b: 0.1863366614728862d, c: 0.7134229928630377d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6151166351904711d, b: 0.2498835420322547d, c: 0.9733560033126378d),

new NpgsqlTypes.NpgsqlLine(a: 0.7516653963992566d, b: 0.8871254006140514d, c: 0.9688544000775576d),

new NpgsqlTypes.NpgsqlLine(a: 0.5920030979667459d, b: 0.19764908877922582d, c: 0.5631519149614208d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)
            ),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1
            ),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2
            )
            ]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                 foreach(var batchResult in ((INpgsqlLineListlineArray)this).DbConnectionSelectModelBatch(connection, 1656686707, 1008288557))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(7));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1800975967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6019711101236188d, b: 0.451502314152629d, c: 0.7567258646896037d),

new NpgsqlTypes.NpgsqlLine(a: 0.20314867633928102d, b: 0.43694052621738755d, c: 0.07972430095228344d),

new NpgsqlTypes.NpgsqlLine(a: 0.38639176328531444d, b: 0.5546727142910798d, c: 0.3595107666863845d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(116492752));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8534388679989421d, b: 0.17051639981163313d, c: 0.11184373953100968d),

new NpgsqlTypes.NpgsqlLine(a: 0.5545649696933802d, b: 0.6495249060333349d, c: 0.14480165352840013d),

new NpgsqlTypes.NpgsqlLine(a: 0.7068689700072772d, b: 0.10325704725403717d, c: 0.1383403540154834d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.565937691937727d, b: 0.8643068916219007d, c: 0.7899347881580714d),

new NpgsqlTypes.NpgsqlLine(a: 0.5461437063589625d, b: 0.8396992488239946d, c: 0.4549808859483121d),

new NpgsqlTypes.NpgsqlLine(a: 0.11142572920429805d, b: 0.7092154686109046d, c: 0.04531658445440445d),

new NpgsqlTypes.NpgsqlLine(a: 0.8590566964589479d, b: 0.07365357454587718d, c: 0.01783865983951749d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858289195));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25032438445726d, b: 0.0917391846373673d, c: 0.34066051809002806d),

new NpgsqlTypes.NpgsqlLine(a: 0.07831144663304057d, b: 0.77591037387439d, c: 0.19759580235224372d),

new NpgsqlTypes.NpgsqlLine(a: 0.3752205191956137d, b: 0.9100313386910368d, c: 0.6525871812195568d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47106408656007914d, b: 0.14257658261320605d, c: 0.47373760961489964d),

new NpgsqlTypes.NpgsqlLine(a: 0.4366806562773925d, b: 0.20146202051894901d, c: 0.3244113712884158d),

new NpgsqlTypes.NpgsqlLine(a: 0.41468311552317627d, b: 0.27557991533085235d, c: 0.7788691278257713d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1908397739));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36399675452528046d, b: 0.21180965313124933d, c: 0.6232643186817026d),

new NpgsqlTypes.NpgsqlLine(a: 0.8377534917307251d, b: 0.7197248111141329d, c: 0.5638759891270843d),

new NpgsqlTypes.NpgsqlLine(a: 0.9127913721936561d, b: 0.47658260676426356d, c: 0.4401534500107992d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.502181779437056d, b: 0.3652805047459293d, c: 0.32001644451474576d),

new NpgsqlTypes.NpgsqlLine(a: 0.7113651445912559d, b: 0.3869191031273206d, c: 0.7332400621535746d),

new NpgsqlTypes.NpgsqlLine(a: 0.5302147002696467d, b: 0.6514960201183412d, c: 0.8888784836070758d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1921152006));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3706659351474607d, b: 0.20392121211971403d, c: 0.09026673921559647d),

new NpgsqlTypes.NpgsqlLine(a: 0.3426907809834573d, b: 0.11597889224231583d, c: 0.37580383029156417d),

new NpgsqlTypes.NpgsqlLine(a: 0.9569454063294334d, b: 0.5352074925592666d, c: 0.1505041653825815d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(322154126));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17316937563192347d, b: 0.7977878569807266d, c: 0.5061623155222499d),

new NpgsqlTypes.NpgsqlLine(a: 0.39020299771548206d, b: 0.46872469438895703d, c: 0.1947250961658502d),

new NpgsqlTypes.NpgsqlLine(a: 0.9460666899443665d, b: 0.40873002207057996d, c: 0.5383135596603867d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931477721));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24029930494024243d, b: 0.6494520983530296d, c: 0.6457904476196421d),

new NpgsqlTypes.NpgsqlLine(a: 0.5413106581652064d, b: 0.65922568011039d, c: 0.023000101756869618d),

new NpgsqlTypes.NpgsqlLine(a: 0.05698461456670889d, b: 0.07946838244893384d, c: 0.023133320459978735d),

new NpgsqlTypes.NpgsqlLine(a: 0.023417572430763367d, b: 0.20022755743974863d, c: 0.9001563624157146d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3818728397283605d, b: 0.24081372003152057d, c: 0.42604600108359325d),

new NpgsqlTypes.NpgsqlLine(a: 0.9919565701428744d, b: 0.9836921588174795d, c: 0.6353618672799166d),

new NpgsqlTypes.NpgsqlLine(a: 0.49779514301225014d, b: 0.9235637976007209d, c: 0.26480996790155775d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943853869));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5132420668035784d, b: 0.9613252483783701d, c: 0.9242449431625296d),

new NpgsqlTypes.NpgsqlLine(a: 0.36653456446188004d, b: 0.7359631901409467d, c: 0.27792441954855884d),

new NpgsqlTypes.NpgsqlLine(a: 0.4636783251093567d, b: 0.1186591604974756d, c: 0.39388519565520497d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1951774404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4334255210533513d, b: 0.5785255926410576d, c: 0.9661508534687067d),

new NpgsqlTypes.NpgsqlLine(a: 0.19775236418153797d, b: 0.9365672085879589d, c: 0.1494826860380959d),

new NpgsqlTypes.NpgsqlLine(a: 0.176207462329397d, b: 0.2629253672101627d, c: 0.07007543599573873d),

new NpgsqlTypes.NpgsqlLine(a: 0.12818842182277845d, b: 0.1863366614728862d, c: 0.7134229928630377d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6151166351904711d, b: 0.2498835420322547d, c: 0.9733560033126378d),

new NpgsqlTypes.NpgsqlLine(a: 0.7516653963992566d, b: 0.8871254006140514d, c: 0.9688544000775576d),

new NpgsqlTypes.NpgsqlLine(a: 0.5920030979667459d, b: 0.19764908877922582d, c: 0.5631519149614208d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(15));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1212970907));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5991478813435879d, b: 0.21696546349723422d, c: 0.7473704822066682d),

new NpgsqlTypes.NpgsqlLine(a: 0.151066097236479d, b: 0.0802844223551269d, c: 0.09162465810768494d),

new NpgsqlTypes.NpgsqlLine(a: 0.8623052986382002d, b: 0.9298840839917386d, c: 0.6660510239194597d),

new NpgsqlTypes.NpgsqlLine(a: 0.9991351159913222d, b: 0.029361445428178645d, c: 0.30760770391653036d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2140414751));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5666355568463651d, b: 0.5532657932652175d, c: 0.043303548850170626d),

new NpgsqlTypes.NpgsqlLine(a: 0.4900959494886681d, b: 0.9349750472343457d, c: 0.4121355471301291d),

new NpgsqlTypes.NpgsqlLine(a: 0.06398838318692368d, b: 0.028285739863693204d, c: 0.8052480125394759d),

new NpgsqlTypes.NpgsqlLine(a: 0.31673961185856914d, b: 0.4141587759463713d, c: 0.1893488396111126d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1370558129));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9082169806472872d, b: 0.9235120225757552d, c: 0.8994934710072177d),

new NpgsqlTypes.NpgsqlLine(a: 0.12419478532476513d, b: 0.805126203795883d, c: 0.21123699569220133d),

new NpgsqlTypes.NpgsqlLine(a: 0.5518835410640954d, b: 0.3470463651950829d, c: 0.4121461426388031d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(196308953));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28578713252269017d, b: 0.8474368218362299d, c: 0.05146566977408318d),

new NpgsqlTypes.NpgsqlLine(a: 0.9109299616024349d, b: 0.5870141058904383d, c: 0.7452912896149598d),

new NpgsqlTypes.NpgsqlLine(a: 0.09671303857190205d, b: 0.22234046410281205d, c: 0.2889776640209598d),

new NpgsqlTypes.NpgsqlLine(a: 0.3594930797393622d, b: 0.1261117062789614d, c: 0.4836691385976134d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1411554384));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.43292849531653743d, b: 0.10139772092942057d, c: 0.19581477698464556d),

new NpgsqlTypes.NpgsqlLine(a: 0.7747830082073887d, b: 0.7612727046736724d, c: 0.49585407932443326d),

new NpgsqlTypes.NpgsqlLine(a: 0.7534769161594925d, b: 0.21640631521439513d, c: 0.9417215429915208d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1423267657));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7028157888188539d, b: 0.4434497177574276d, c: 0.1878584904244096d),

new NpgsqlTypes.NpgsqlLine(a: 0.12779644786129707d, b: 0.6547737034235738d, c: 0.7340324477099678d),

new NpgsqlTypes.NpgsqlLine(a: 0.13473852180731738d, b: 0.7900921279332365d, c: 0.7695417103969711d),

new NpgsqlTypes.NpgsqlLine(a: 0.2618677281295215d, b: 0.24821010444457137d, c: 0.2711393719015588d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1610745034));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6382266935775643d, b: 0.398693329671132d, c: 0.7425094436899613d),

new NpgsqlTypes.NpgsqlLine(a: 0.24327741116998813d, b: 0.1635267687203752d, c: 0.628031718062037d),

new NpgsqlTypes.NpgsqlLine(a: 0.38459544322295613d, b: 0.4141132804519537d, c: 0.8511486540491503d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9861241662988156d, b: 0.25399030999510996d, c: 0.2529918964264557d),

new NpgsqlTypes.NpgsqlLine(a: 0.17574090331875702d, b: 0.5215697754670754d, c: 0.49092403723555744d),

new NpgsqlTypes.NpgsqlLine(a: 0.9755215010138426d, b: 0.5836706698542481d, c: 0.8112425273051307d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1525343338));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5334739519154116d, b: 0.14533927203574382d, c: 0.9972375896646379d),

new NpgsqlTypes.NpgsqlLine(a: 0.5376404385911305d, b: 0.3967355325520928d, c: 0.2690585850054501d),

new NpgsqlTypes.NpgsqlLine(a: 0.7930288640515465d, b: 0.4034090749439643d, c: 0.19977351395319798d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22585130451050572d, b: 0.054454055462575424d, c: 0.3670135684186787d),

new NpgsqlTypes.NpgsqlLine(a: 0.8573417118252535d, b: 0.7290365889192361d, c: 0.15771025911629288d),

new NpgsqlTypes.NpgsqlLine(a: 0.8294206137900973d, b: 0.778292553399524d, c: 0.5844131999897239d),

new NpgsqlTypes.NpgsqlLine(a: 0.8795242286168519d, b: 0.43336364459496624d, c: 0.07939237473054006d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1618779845));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588222459861263d, b: 0.8314528851615401d, c: 0.4091425195520225d),

new NpgsqlTypes.NpgsqlLine(a: 0.15497545879234587d, b: 0.42501177297812087d, c: 0.3930386900482442d),

new NpgsqlTypes.NpgsqlLine(a: 0.49932759733861587d, b: 0.27860846401633954d, c: 0.22371479209453393d),

new NpgsqlTypes.NpgsqlLine(a: 0.6744750487770321d, b: 0.5185555306309229d, c: 0.48333909912156325d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6846715107366038d, b: 0.7822398219668835d, c: 0.6995656002724597d),

new NpgsqlTypes.NpgsqlLine(a: 0.34191163697506577d, b: 0.251427920689659d, c: 0.6372400180339429d),

new NpgsqlTypes.NpgsqlLine(a: 0.7615638356664386d, b: 0.38275705185682163d, c: 0.9430695395246483d),

new NpgsqlTypes.NpgsqlLine(a: 0.25861736938688795d, b: 0.2236086093911689d, c: 0.43081968027669826d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(111191550));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10079392481388938d, b: 0.47419284524344363d, c: 0.46999813598135487d),

new NpgsqlTypes.NpgsqlLine(a: 0.4512330545433114d, b: 0.7685777654216315d, c: 0.761484461621478d),

new NpgsqlTypes.NpgsqlLine(a: 0.7069502335832981d, b: 0.10867536284292001d, c: 0.803973548621565d),

new NpgsqlTypes.NpgsqlLine(a: 0.6710482193897285d, b: 0.3246300803211939d, c: 0.007931088387647223d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1651600176));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16882852097245493d, b: 0.6320810387310721d, c: 0.4943119337666173d),

new NpgsqlTypes.NpgsqlLine(a: 0.1864608664190791d, b: 0.3923939341785333d, c: 0.40778672849944797d),

new NpgsqlTypes.NpgsqlLine(a: 0.21658079009283382d, b: 0.9735580473103661d, c: 0.5313780798893142d),

new NpgsqlTypes.NpgsqlLine(a: 0.608447080933292d, b: 0.9095061095638245d, c: 0.664417030599092d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1656686707));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08369873952495288d, b: 0.07788317757867735d, c: 0.284112517861248d),

new NpgsqlTypes.NpgsqlLine(a: 0.617171498263342d, b: 0.5865508373972511d, c: 0.36018099841433293d),

new NpgsqlTypes.NpgsqlLine(a: 0.4798021589910493d, b: 0.5378837702166812d, c: 0.2195325878675365d),

new NpgsqlTypes.NpgsqlLine(a: 0.961753857136392d, b: 0.8919192421134503d, c: 0.16540674234160435d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1264360862));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3150738269575506d, b: 0.25723902915678687d, c: 0.7085220942560913d),

new NpgsqlTypes.NpgsqlLine(a: 0.10217399526832571d, b: 0.23606907248025677d, c: 0.14832581681823231d),

new NpgsqlTypes.NpgsqlLine(a: 0.38475783269574504d, b: 0.261674953378639d, c: 0.8414017715374641d),

new NpgsqlTypes.NpgsqlLine(a: 0.060969244577031345d, b: 0.7001282741779633d, c: 0.8180532031964253d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1800975967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6019711101236188d, b: 0.451502314152629d, c: 0.7567258646896037d),

new NpgsqlTypes.NpgsqlLine(a: 0.20314867633928102d, b: 0.43694052621738755d, c: 0.07972430095228344d),

new NpgsqlTypes.NpgsqlLine(a: 0.38639176328531444d, b: 0.5546727142910798d, c: 0.3595107666863845d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(116492752));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8534388679989421d, b: 0.17051639981163313d, c: 0.11184373953100968d),

new NpgsqlTypes.NpgsqlLine(a: 0.5545649696933802d, b: 0.6495249060333349d, c: 0.14480165352840013d),

new NpgsqlTypes.NpgsqlLine(a: 0.7068689700072772d, b: 0.10325704725403717d, c: 0.1383403540154834d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.565937691937727d, b: 0.8643068916219007d, c: 0.7899347881580714d),

new NpgsqlTypes.NpgsqlLine(a: 0.5461437063589625d, b: 0.8396992488239946d, c: 0.4549808859483121d),

new NpgsqlTypes.NpgsqlLine(a: 0.11142572920429805d, b: 0.7092154686109046d, c: 0.04531658445440445d),

new NpgsqlTypes.NpgsqlLine(a: 0.8590566964589479d, b: 0.07365357454587718d, c: 0.01783865983951749d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858289195));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25032438445726d, b: 0.0917391846373673d, c: 0.34066051809002806d),

new NpgsqlTypes.NpgsqlLine(a: 0.07831144663304057d, b: 0.77591037387439d, c: 0.19759580235224372d),

new NpgsqlTypes.NpgsqlLine(a: 0.3752205191956137d, b: 0.9100313386910368d, c: 0.6525871812195568d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47106408656007914d, b: 0.14257658261320605d, c: 0.47373760961489964d),

new NpgsqlTypes.NpgsqlLine(a: 0.4366806562773925d, b: 0.20146202051894901d, c: 0.3244113712884158d),

new NpgsqlTypes.NpgsqlLine(a: 0.41468311552317627d, b: 0.27557991533085235d, c: 0.7788691278257713d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1908397739));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36399675452528046d, b: 0.21180965313124933d, c: 0.6232643186817026d),

new NpgsqlTypes.NpgsqlLine(a: 0.8377534917307251d, b: 0.7197248111141329d, c: 0.5638759891270843d),

new NpgsqlTypes.NpgsqlLine(a: 0.9127913721936561d, b: 0.47658260676426356d, c: 0.4401534500107992d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.502181779437056d, b: 0.3652805047459293d, c: 0.32001644451474576d),

new NpgsqlTypes.NpgsqlLine(a: 0.7113651445912559d, b: 0.3869191031273206d, c: 0.7332400621535746d),

new NpgsqlTypes.NpgsqlLine(a: 0.5302147002696467d, b: 0.6514960201183412d, c: 0.8888784836070758d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1921152006));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3706659351474607d, b: 0.20392121211971403d, c: 0.09026673921559647d),

new NpgsqlTypes.NpgsqlLine(a: 0.3426907809834573d, b: 0.11597889224231583d, c: 0.37580383029156417d),

new NpgsqlTypes.NpgsqlLine(a: 0.9569454063294334d, b: 0.5352074925592666d, c: 0.1505041653825815d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(322154126));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17316937563192347d, b: 0.7977878569807266d, c: 0.5061623155222499d),

new NpgsqlTypes.NpgsqlLine(a: 0.39020299771548206d, b: 0.46872469438895703d, c: 0.1947250961658502d),

new NpgsqlTypes.NpgsqlLine(a: 0.9460666899443665d, b: 0.40873002207057996d, c: 0.5383135596603867d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931477721));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24029930494024243d, b: 0.6494520983530296d, c: 0.6457904476196421d),

new NpgsqlTypes.NpgsqlLine(a: 0.5413106581652064d, b: 0.65922568011039d, c: 0.023000101756869618d),

new NpgsqlTypes.NpgsqlLine(a: 0.05698461456670889d, b: 0.07946838244893384d, c: 0.023133320459978735d),

new NpgsqlTypes.NpgsqlLine(a: 0.023417572430763367d, b: 0.20022755743974863d, c: 0.9001563624157146d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3818728397283605d, b: 0.24081372003152057d, c: 0.42604600108359325d),

new NpgsqlTypes.NpgsqlLine(a: 0.9919565701428744d, b: 0.9836921588174795d, c: 0.6353618672799166d),

new NpgsqlTypes.NpgsqlLine(a: 0.49779514301225014d, b: 0.9235637976007209d, c: 0.26480996790155775d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943853869));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5132420668035784d, b: 0.9613252483783701d, c: 0.9242449431625296d),

new NpgsqlTypes.NpgsqlLine(a: 0.36653456446188004d, b: 0.7359631901409467d, c: 0.27792441954855884d),

new NpgsqlTypes.NpgsqlLine(a: 0.4636783251093567d, b: 0.1186591604974756d, c: 0.39388519565520497d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1951774404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4334255210533513d, b: 0.5785255926410576d, c: 0.9661508534687067d),

new NpgsqlTypes.NpgsqlLine(a: 0.19775236418153797d, b: 0.9365672085879589d, c: 0.1494826860380959d),

new NpgsqlTypes.NpgsqlLine(a: 0.176207462329397d, b: 0.2629253672101627d, c: 0.07007543599573873d),

new NpgsqlTypes.NpgsqlLine(a: 0.12818842182277845d, b: 0.1863366614728862d, c: 0.7134229928630377d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6151166351904711d, b: 0.2498835420322547d, c: 0.9733560033126378d),

new NpgsqlTypes.NpgsqlLine(a: 0.7516653963992566d, b: 0.8871254006140514d, c: 0.9688544000775576d),

new NpgsqlTypes.NpgsqlLine(a: 0.5920030979667459d, b: 0.19764908877922582d, c: 0.5631519149614208d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }
                    
                    //todo return false
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                await foreach(var batchResult in ((INpgsqlLineListlineArray)this).DbConnectionSelectModelBatchAsync(connection, 350174520, 128586765))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(27));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(528252532));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22785571390952986d, b: 0.47384563164287363d, c: 0.7296472935133859d),

new NpgsqlTypes.NpgsqlLine(a: 0.42847852345883053d, b: 0.05295602193643412d, c: 0.7176332323630693d),

new NpgsqlTypes.NpgsqlLine(a: 0.1313916587576558d, b: 0.44047120647606086d, c: 0.4080020542049758d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2023967945));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7526118185907706d, b: 0.7217192659741516d, c: 0.10725515353553927d),

new NpgsqlTypes.NpgsqlLine(a: 0.4123399872860949d, b: 0.9887632111198967d, c: 0.3407478138648996d),

new NpgsqlTypes.NpgsqlLine(a: 0.1972888611598902d, b: 0.21209298014251077d, c: 0.998100482656704d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32204440669620105d, b: 0.40425092983702615d, c: 0.6281187397686202d),

new NpgsqlTypes.NpgsqlLine(a: 0.8736370792109995d, b: 0.8257156419424208d, c: 0.24574228768788875d),

new NpgsqlTypes.NpgsqlLine(a: 0.1777372581271598d, b: 0.02795031420098848d, c: 0.6085263716794568d),

new NpgsqlTypes.NpgsqlLine(a: 0.3937718955623397d, b: 0.3857998777014512d, c: 0.16490107858931902d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(548719832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45120792613918626d, b: 0.7981849131464387d, c: 0.6797001557385036d),

new NpgsqlTypes.NpgsqlLine(a: 0.5152860785682492d, b: 0.05860524276063561d, c: 0.31392693425098706d),

new NpgsqlTypes.NpgsqlLine(a: 0.8399321644879826d, b: 0.14127845073157042d, c: 0.04919268640928787d),

new NpgsqlTypes.NpgsqlLine(a: 0.5367279979863265d, b: 0.9037039524330727d, c: 0.5651736207579545d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(632564420));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9871612756422758d, b: 0.7040000628939183d, c: 0.5741990515908977d),

new NpgsqlTypes.NpgsqlLine(a: 0.8939251170158339d, b: 0.591802460616856d, c: 0.8710953712464558d),

new NpgsqlTypes.NpgsqlLine(a: 0.925765879252592d, b: 0.020003653879282934d, c: 0.27174016206463947d),

new NpgsqlTypes.NpgsqlLine(a: 0.40821497810499396d, b: 0.18426353989680566d, c: 0.35762480728827095d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(569222828));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3541781533895836d, b: 0.8806877333215982d, c: 0.3434395351862555d),

new NpgsqlTypes.NpgsqlLine(a: 0.904182291889472d, b: 0.2725232832902962d, c: 0.11922376175569749d),

new NpgsqlTypes.NpgsqlLine(a: 0.2973949214938665d, b: 0.551548200515303d, c: 0.11510798755200236d),

new NpgsqlTypes.NpgsqlLine(a: 0.6236383027800103d, b: 0.7132402356425214d, c: 0.7946866828405127d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1120533763));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7797869567083358d, b: 0.2361739464389747d, c: 0.48164557546500963d),

new NpgsqlTypes.NpgsqlLine(a: 0.9480048066554808d, b: 0.8035492224666504d, c: 0.9832497213764478d),

new NpgsqlTypes.NpgsqlLine(a: 0.9772596541640088d, b: 0.6093516798517065d, c: 0.6052760903401032d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(617125650));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35787275736319957d, b: 0.702047825867143d, c: 0.965415572167533d),

new NpgsqlTypes.NpgsqlLine(a: 0.31090623461505584d, b: 0.5647177423851781d, c: 0.4846654296503867d),

new NpgsqlTypes.NpgsqlLine(a: 0.3183862992195977d, b: 0.6261458826331173d, c: 0.6907068588712774d),

new NpgsqlTypes.NpgsqlLine(a: 0.6487979418902344d, b: 0.4615179308283234d, c: 0.642127574912425d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9197027266355764d, b: 0.39215058098740485d, c: 0.17261332753094694d),

new NpgsqlTypes.NpgsqlLine(a: 0.11391459246246716d, b: 0.8528811542175645d, c: 0.20274869752530522d),

new NpgsqlTypes.NpgsqlLine(a: 0.36907637605105814d, b: 0.6376511000289307d, c: 0.12998307736849357d),

new NpgsqlTypes.NpgsqlLine(a: 0.9580086581171673d, b: 0.03050170247729178d, c: 0.38029624192446d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1413412459));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42503376733197573d, b: 0.763237079678654d, c: 0.09688502535476584d),

new NpgsqlTypes.NpgsqlLine(a: 0.23240822962655505d, b: 0.8459480271218152d, c: 0.08432931494869422d),

new NpgsqlTypes.NpgsqlLine(a: 0.18886663761414113d, b: 0.5079561486308892d, c: 0.9843388801596968d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(627974170));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15147399565049113d, b: 0.7627100647125816d, c: 0.16010235385722305d),

new NpgsqlTypes.NpgsqlLine(a: 0.9001358065765852d, b: 0.4721890907147458d, c: 0.15927787372271784d),

new NpgsqlTypes.NpgsqlLine(a: 0.7813049144298684d, b: 0.4136335409837938d, c: 0.12660196714031435d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.004236560392559818d, b: 0.39606208609499893d, c: 0.19741769434420997d),

new NpgsqlTypes.NpgsqlLine(a: 0.5953646586031078d, b: 0.6151314480582013d, c: 0.6556527973910132d),

new NpgsqlTypes.NpgsqlLine(a: 0.5407811339876436d, b: 0.9334248245144674d, c: 0.8365874899469636d),

new NpgsqlTypes.NpgsqlLine(a: 0.4764002070454937d, b: 0.16718217080509323d, c: 0.17236129187105342d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(791579102));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3341739254022562d, b: 0.718465753134697d, c: 0.5771634629019262d),

new NpgsqlTypes.NpgsqlLine(a: 0.6322200521292398d, b: 0.8246392866857581d, c: 0.5696079494467468d),

new NpgsqlTypes.NpgsqlLine(a: 0.6545382710133834d, b: 0.4365654599867256d, c: 0.8153585418393168d),

new NpgsqlTypes.NpgsqlLine(a: 0.0910019439659393d, b: 0.7174745892954046d, c: 0.1511089208473413d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1190383178));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12466334172066618d, b: 0.11152073168077081d, c: 0.491230984381532d),

new NpgsqlTypes.NpgsqlLine(a: 0.5547266175262346d, b: 0.13792449594977796d, c: 0.7570674004021489d),

new NpgsqlTypes.NpgsqlLine(a: 0.2085058544453703d, b: 0.08290359377194412d, c: 0.77495272781113d),

new NpgsqlTypes.NpgsqlLine(a: 0.49111506712078934d, b: 0.641116986925848d, c: 0.29516341556351666d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07914996961984966d, b: 0.4871418257809952d, c: 0.7513322508300865d),

new NpgsqlTypes.NpgsqlLine(a: 0.9239635289951339d, b: 0.38794777551433746d, c: 0.676783160212782d),

new NpgsqlTypes.NpgsqlLine(a: 0.0955538255878925d, b: 0.01055236041931451d, c: 0.2842563281409253d),

new NpgsqlTypes.NpgsqlLine(a: 0.02927332855673237d, b: 0.6165842674891228d, c: 0.8012173905302888d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(833599485));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4822973119466689d, b: 0.792513536759573d, c: 0.499633501292873d),

new NpgsqlTypes.NpgsqlLine(a: 0.8918073488512478d, b: 0.42208129985829845d, c: 0.5329638256901381d),

new NpgsqlTypes.NpgsqlLine(a: 0.5188620987187985d, b: 0.1726952436096839d, c: 0.7227459582321649d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15666178016283616d, b: 0.2873368213961791d, c: 0.4420895689102471d),

new NpgsqlTypes.NpgsqlLine(a: 0.4601057867375493d, b: 0.5622721416121373d, c: 0.2999980165807573d),

new NpgsqlTypes.NpgsqlLine(a: 0.8381583831951187d, b: 0.9764919740330239d, c: 0.18152562681640294d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1272632761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8378269016529278d, b: 0.6733240332238696d, c: 0.8919506779863193d),

new NpgsqlTypes.NpgsqlLine(a: 0.48570634731194795d, b: 0.1596671151368555d, c: 0.20750860994967846d),

new NpgsqlTypes.NpgsqlLine(a: 0.779653513645174d, b: 0.8586337096501773d, c: 0.1738735269722934d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2675334980310755d, b: 0.5860654638502302d, c: 0.5223481489931099d),

new NpgsqlTypes.NpgsqlLine(a: 0.2908190505712529d, b: 0.027311571062217044d, c: 0.38897855152716554d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590347289639254d, b: 0.6110078502040162d, c: 0.9773066927065011d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(896715967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4784147382307862d, b: 0.6552419336185478d, c: 0.920823919677529d),

new NpgsqlTypes.NpgsqlLine(a: 0.742593437228071d, b: 0.6268935209443758d, c: 0.5071732457335109d),

new NpgsqlTypes.NpgsqlLine(a: 0.6253496198816004d, b: 0.5361783003872929d, c: 0.7158348891331027d),

new NpgsqlTypes.NpgsqlLine(a: 0.4294538215627851d, b: 0.8234156672775046d, c: 0.08688024353682888d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(117280179));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3605977641294892d, b: 0.17811158147680461d, c: 0.9658058071756186d),

new NpgsqlTypes.NpgsqlLine(a: 0.6970256025820155d, b: 0.5444046414962291d, c: 0.46720686007108925d),

new NpgsqlTypes.NpgsqlLine(a: 0.8561050660597573d, b: 0.11353237597432853d, c: 0.56669941414895d),

new NpgsqlTypes.NpgsqlLine(a: 0.7984600619309864d, b: 0.8109151931011057d, c: 0.769305377302455d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0947306689172811d, b: 0.8302577671800684d, c: 0.8970532400118938d),

new NpgsqlTypes.NpgsqlLine(a: 0.2407748752003226d, b: 0.4567310255560061d, c: 0.4526792803927874d),

new NpgsqlTypes.NpgsqlLine(a: 0.04496104252758981d, b: 0.7589917027634498d, c: 0.6770421060059869d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(899804594));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1970857537444196d, b: 0.9333242638108382d, c: 0.2997924017071659d),

new NpgsqlTypes.NpgsqlLine(a: 0.6311349404614687d, b: 0.19618574736695826d, c: 0.38842914242231885d),

new NpgsqlTypes.NpgsqlLine(a: 0.8616526286116198d, b: 0.5020108677923993d, c: 0.7507796571723376d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8462722154822349d, b: 0.2140170588076531d, c: 0.1555300802445071d),

new NpgsqlTypes.NpgsqlLine(a: 0.05107346767082066d, b: 0.6007632357415391d, c: 0.11568725974145999d),

new NpgsqlTypes.NpgsqlLine(a: 0.9923537289603477d, b: 0.4950249871115745d, c: 0.02343990901364046d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(964637978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7665509369596407d, b: 0.32246651386445413d, c: 0.4163237996846909d),

new NpgsqlTypes.NpgsqlLine(a: 0.622867187513811d, b: 0.02481599358005626d, c: 0.6781914372848628d),

new NpgsqlTypes.NpgsqlLine(a: 0.9383962517038102d, b: 0.22799617371669267d, c: 0.11769282658114588d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1006841713));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3814391347607825d, b: 0.6500010795000312d, c: 0.5168910912789877d),

new NpgsqlTypes.NpgsqlLine(a: 0.9809725325416359d, b: 0.5965089551877092d, c: 0.9620206915411497d),

new NpgsqlTypes.NpgsqlLine(a: 0.8326177257415529d, b: 0.9726427466112844d, c: 0.44743910631138517d),

new NpgsqlTypes.NpgsqlLine(a: 0.9428905413649304d, b: 0.2742783552238923d, c: 0.20624247958140818d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4156588878635493d, b: 0.9311562710078888d, c: 0.18729745760128813d),

new NpgsqlTypes.NpgsqlLine(a: 0.7838364754377413d, b: 0.2902143764264882d, c: 0.6468999105347263d),

new NpgsqlTypes.NpgsqlLine(a: 0.2807400125401047d, b: 0.4738433713063067d, c: 0.3414032292061351d),

new NpgsqlTypes.NpgsqlLine(a: 0.07976939589399212d, b: 0.6817427263698487d, c: 0.7162950229594492d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1008288557));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6703103585772012d, b: 0.9414469448287122d, c: 0.32961805156524826d),

new NpgsqlTypes.NpgsqlLine(a: 0.13239408457631574d, b: 0.5134528929025426d, c: 0.5412589816963953d),

new NpgsqlTypes.NpgsqlLine(a: 0.1699098825091695d, b: 0.9194545880639252d, c: 0.7451240040858685d),

new NpgsqlTypes.NpgsqlLine(a: 0.2233903417330374d, b: 0.07771599830861675d, c: 0.5752102020647447d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(723640790));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8545769023218451d, b: 0.24286566112974062d, c: 0.24373271509232275d),

new NpgsqlTypes.NpgsqlLine(a: 0.8731571462637403d, b: 0.9993617334238951d, c: 0.1725755360195571d),

new NpgsqlTypes.NpgsqlLine(a: 0.2467482163165423d, b: 0.7309207508122816d, c: 0.574326589073651d),

new NpgsqlTypes.NpgsqlLine(a: 0.39429370255535745d, b: 0.12918013405283635d, c: 0.37279548432778786d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8697103680615146d, b: 0.4868697197066526d, c: 0.008300202872866591d),

new NpgsqlTypes.NpgsqlLine(a: 0.9268152455195247d, b: 0.9945415027788427d, c: 0.33225561051564245d),

new NpgsqlTypes.NpgsqlLine(a: 0.06541514412119742d, b: 0.29832372565206444d, c: 0.34837671529944225d),

new NpgsqlTypes.NpgsqlLine(a: 0.7703107306167513d, b: 0.39150187650435253d, c: 0.17912768771478083d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1212970907));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5991478813435879d, b: 0.21696546349723422d, c: 0.7473704822066682d),

new NpgsqlTypes.NpgsqlLine(a: 0.151066097236479d, b: 0.0802844223551269d, c: 0.09162465810768494d),

new NpgsqlTypes.NpgsqlLine(a: 0.8623052986382002d, b: 0.9298840839917386d, c: 0.6660510239194597d),

new NpgsqlTypes.NpgsqlLine(a: 0.9991351159913222d, b: 0.029361445428178645d, c: 0.30760770391653036d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2140414751));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5666355568463651d, b: 0.5532657932652175d, c: 0.043303548850170626d),

new NpgsqlTypes.NpgsqlLine(a: 0.4900959494886681d, b: 0.9349750472343457d, c: 0.4121355471301291d),

new NpgsqlTypes.NpgsqlLine(a: 0.06398838318692368d, b: 0.028285739863693204d, c: 0.8052480125394759d),

new NpgsqlTypes.NpgsqlLine(a: 0.31673961185856914d, b: 0.4141587759463713d, c: 0.1893488396111126d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1370558129));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9082169806472872d, b: 0.9235120225757552d, c: 0.8994934710072177d),

new NpgsqlTypes.NpgsqlLine(a: 0.12419478532476513d, b: 0.805126203795883d, c: 0.21123699569220133d),

new NpgsqlTypes.NpgsqlLine(a: 0.5518835410640954d, b: 0.3470463651950829d, c: 0.4121461426388031d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(196308953));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28578713252269017d, b: 0.8474368218362299d, c: 0.05146566977408318d),

new NpgsqlTypes.NpgsqlLine(a: 0.9109299616024349d, b: 0.5870141058904383d, c: 0.7452912896149598d),

new NpgsqlTypes.NpgsqlLine(a: 0.09671303857190205d, b: 0.22234046410281205d, c: 0.2889776640209598d),

new NpgsqlTypes.NpgsqlLine(a: 0.3594930797393622d, b: 0.1261117062789614d, c: 0.4836691385976134d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1411554384));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.43292849531653743d, b: 0.10139772092942057d, c: 0.19581477698464556d),

new NpgsqlTypes.NpgsqlLine(a: 0.7747830082073887d, b: 0.7612727046736724d, c: 0.49585407932443326d),

new NpgsqlTypes.NpgsqlLine(a: 0.7534769161594925d, b: 0.21640631521439513d, c: 0.9417215429915208d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1423267657));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7028157888188539d, b: 0.4434497177574276d, c: 0.1878584904244096d),

new NpgsqlTypes.NpgsqlLine(a: 0.12779644786129707d, b: 0.6547737034235738d, c: 0.7340324477099678d),

new NpgsqlTypes.NpgsqlLine(a: 0.13473852180731738d, b: 0.7900921279332365d, c: 0.7695417103969711d),

new NpgsqlTypes.NpgsqlLine(a: 0.2618677281295215d, b: 0.24821010444457137d, c: 0.2711393719015588d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1610745034));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6382266935775643d, b: 0.398693329671132d, c: 0.7425094436899613d),

new NpgsqlTypes.NpgsqlLine(a: 0.24327741116998813d, b: 0.1635267687203752d, c: 0.628031718062037d),

new NpgsqlTypes.NpgsqlLine(a: 0.38459544322295613d, b: 0.4141132804519537d, c: 0.8511486540491503d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9861241662988156d, b: 0.25399030999510996d, c: 0.2529918964264557d),

new NpgsqlTypes.NpgsqlLine(a: 0.17574090331875702d, b: 0.5215697754670754d, c: 0.49092403723555744d),

new NpgsqlTypes.NpgsqlLine(a: 0.9755215010138426d, b: 0.5836706698542481d, c: 0.8112425273051307d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1525343338));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5334739519154116d, b: 0.14533927203574382d, c: 0.9972375896646379d),

new NpgsqlTypes.NpgsqlLine(a: 0.5376404385911305d, b: 0.3967355325520928d, c: 0.2690585850054501d),

new NpgsqlTypes.NpgsqlLine(a: 0.7930288640515465d, b: 0.4034090749439643d, c: 0.19977351395319798d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22585130451050572d, b: 0.054454055462575424d, c: 0.3670135684186787d),

new NpgsqlTypes.NpgsqlLine(a: 0.8573417118252535d, b: 0.7290365889192361d, c: 0.15771025911629288d),

new NpgsqlTypes.NpgsqlLine(a: 0.8294206137900973d, b: 0.778292553399524d, c: 0.5844131999897239d),

new NpgsqlTypes.NpgsqlLine(a: 0.8795242286168519d, b: 0.43336364459496624d, c: 0.07939237473054006d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1618779845));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588222459861263d, b: 0.8314528851615401d, c: 0.4091425195520225d),

new NpgsqlTypes.NpgsqlLine(a: 0.15497545879234587d, b: 0.42501177297812087d, c: 0.3930386900482442d),

new NpgsqlTypes.NpgsqlLine(a: 0.49932759733861587d, b: 0.27860846401633954d, c: 0.22371479209453393d),

new NpgsqlTypes.NpgsqlLine(a: 0.6744750487770321d, b: 0.5185555306309229d, c: 0.48333909912156325d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6846715107366038d, b: 0.7822398219668835d, c: 0.6995656002724597d),

new NpgsqlTypes.NpgsqlLine(a: 0.34191163697506577d, b: 0.251427920689659d, c: 0.6372400180339429d),

new NpgsqlTypes.NpgsqlLine(a: 0.7615638356664386d, b: 0.38275705185682163d, c: 0.9430695395246483d),

new NpgsqlTypes.NpgsqlLine(a: 0.25861736938688795d, b: 0.2236086093911689d, c: 0.43081968027669826d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(111191550));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10079392481388938d, b: 0.47419284524344363d, c: 0.46999813598135487d),

new NpgsqlTypes.NpgsqlLine(a: 0.4512330545433114d, b: 0.7685777654216315d, c: 0.761484461621478d),

new NpgsqlTypes.NpgsqlLine(a: 0.7069502335832981d, b: 0.10867536284292001d, c: 0.803973548621565d),

new NpgsqlTypes.NpgsqlLine(a: 0.6710482193897285d, b: 0.3246300803211939d, c: 0.007931088387647223d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1651600176));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16882852097245493d, b: 0.6320810387310721d, c: 0.4943119337666173d),

new NpgsqlTypes.NpgsqlLine(a: 0.1864608664190791d, b: 0.3923939341785333d, c: 0.40778672849944797d),

new NpgsqlTypes.NpgsqlLine(a: 0.21658079009283382d, b: 0.9735580473103661d, c: 0.5313780798893142d),

new NpgsqlTypes.NpgsqlLine(a: 0.608447080933292d, b: 0.9095061095638245d, c: 0.664417030599092d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1656686707));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08369873952495288d, b: 0.07788317757867735d, c: 0.284112517861248d),

new NpgsqlTypes.NpgsqlLine(a: 0.617171498263342d, b: 0.5865508373972511d, c: 0.36018099841433293d),

new NpgsqlTypes.NpgsqlLine(a: 0.4798021589910493d, b: 0.5378837702166812d, c: 0.2195325878675365d),

new NpgsqlTypes.NpgsqlLine(a: 0.961753857136392d, b: 0.8919192421134503d, c: 0.16540674234160435d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1264360862));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3150738269575506d, b: 0.25723902915678687d, c: 0.7085220942560913d),

new NpgsqlTypes.NpgsqlLine(a: 0.10217399526832571d, b: 0.23606907248025677d, c: 0.14832581681823231d),

new NpgsqlTypes.NpgsqlLine(a: 0.38475783269574504d, b: 0.261674953378639d, c: 0.8414017715374641d),

new NpgsqlTypes.NpgsqlLine(a: 0.060969244577031345d, b: 0.7001282741779633d, c: 0.8180532031964253d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1800975967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6019711101236188d, b: 0.451502314152629d, c: 0.7567258646896037d),

new NpgsqlTypes.NpgsqlLine(a: 0.20314867633928102d, b: 0.43694052621738755d, c: 0.07972430095228344d),

new NpgsqlTypes.NpgsqlLine(a: 0.38639176328531444d, b: 0.5546727142910798d, c: 0.3595107666863845d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(116492752));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8534388679989421d, b: 0.17051639981163313d, c: 0.11184373953100968d),

new NpgsqlTypes.NpgsqlLine(a: 0.5545649696933802d, b: 0.6495249060333349d, c: 0.14480165352840013d),

new NpgsqlTypes.NpgsqlLine(a: 0.7068689700072772d, b: 0.10325704725403717d, c: 0.1383403540154834d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.565937691937727d, b: 0.8643068916219007d, c: 0.7899347881580714d),

new NpgsqlTypes.NpgsqlLine(a: 0.5461437063589625d, b: 0.8396992488239946d, c: 0.4549808859483121d),

new NpgsqlTypes.NpgsqlLine(a: 0.11142572920429805d, b: 0.7092154686109046d, c: 0.04531658445440445d),

new NpgsqlTypes.NpgsqlLine(a: 0.8590566964589479d, b: 0.07365357454587718d, c: 0.01783865983951749d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858289195));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25032438445726d, b: 0.0917391846373673d, c: 0.34066051809002806d),

new NpgsqlTypes.NpgsqlLine(a: 0.07831144663304057d, b: 0.77591037387439d, c: 0.19759580235224372d),

new NpgsqlTypes.NpgsqlLine(a: 0.3752205191956137d, b: 0.9100313386910368d, c: 0.6525871812195568d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47106408656007914d, b: 0.14257658261320605d, c: 0.47373760961489964d),

new NpgsqlTypes.NpgsqlLine(a: 0.4366806562773925d, b: 0.20146202051894901d, c: 0.3244113712884158d),

new NpgsqlTypes.NpgsqlLine(a: 0.41468311552317627d, b: 0.27557991533085235d, c: 0.7788691278257713d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1908397739));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36399675452528046d, b: 0.21180965313124933d, c: 0.6232643186817026d),

new NpgsqlTypes.NpgsqlLine(a: 0.8377534917307251d, b: 0.7197248111141329d, c: 0.5638759891270843d),

new NpgsqlTypes.NpgsqlLine(a: 0.9127913721936561d, b: 0.47658260676426356d, c: 0.4401534500107992d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.502181779437056d, b: 0.3652805047459293d, c: 0.32001644451474576d),

new NpgsqlTypes.NpgsqlLine(a: 0.7113651445912559d, b: 0.3869191031273206d, c: 0.7332400621535746d),

new NpgsqlTypes.NpgsqlLine(a: 0.5302147002696467d, b: 0.6514960201183412d, c: 0.8888784836070758d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1921152006));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3706659351474607d, b: 0.20392121211971403d, c: 0.09026673921559647d),

new NpgsqlTypes.NpgsqlLine(a: 0.3426907809834573d, b: 0.11597889224231583d, c: 0.37580383029156417d),

new NpgsqlTypes.NpgsqlLine(a: 0.9569454063294334d, b: 0.5352074925592666d, c: 0.1505041653825815d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(322154126));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17316937563192347d, b: 0.7977878569807266d, c: 0.5061623155222499d),

new NpgsqlTypes.NpgsqlLine(a: 0.39020299771548206d, b: 0.46872469438895703d, c: 0.1947250961658502d),

new NpgsqlTypes.NpgsqlLine(a: 0.9460666899443665d, b: 0.40873002207057996d, c: 0.5383135596603867d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931477721));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24029930494024243d, b: 0.6494520983530296d, c: 0.6457904476196421d),

new NpgsqlTypes.NpgsqlLine(a: 0.5413106581652064d, b: 0.65922568011039d, c: 0.023000101756869618d),

new NpgsqlTypes.NpgsqlLine(a: 0.05698461456670889d, b: 0.07946838244893384d, c: 0.023133320459978735d),

new NpgsqlTypes.NpgsqlLine(a: 0.023417572430763367d, b: 0.20022755743974863d, c: 0.9001563624157146d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3818728397283605d, b: 0.24081372003152057d, c: 0.42604600108359325d),

new NpgsqlTypes.NpgsqlLine(a: 0.9919565701428744d, b: 0.9836921588174795d, c: 0.6353618672799166d),

new NpgsqlTypes.NpgsqlLine(a: 0.49779514301225014d, b: 0.9235637976007209d, c: 0.26480996790155775d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[25];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943853869));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5132420668035784d, b: 0.9613252483783701d, c: 0.9242449431625296d),

new NpgsqlTypes.NpgsqlLine(a: 0.36653456446188004d, b: 0.7359631901409467d, c: 0.27792441954855884d),

new NpgsqlTypes.NpgsqlLine(a: 0.4636783251093567d, b: 0.1186591604974756d, c: 0.39388519565520497d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[26];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1951774404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4334255210533513d, b: 0.5785255926410576d, c: 0.9661508534687067d),

new NpgsqlTypes.NpgsqlLine(a: 0.19775236418153797d, b: 0.9365672085879589d, c: 0.1494826860380959d),

new NpgsqlTypes.NpgsqlLine(a: 0.176207462329397d, b: 0.2629253672101627d, c: 0.07007543599573873d),

new NpgsqlTypes.NpgsqlLine(a: 0.12818842182277845d, b: 0.1863366614728862d, c: 0.7134229928630377d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6151166351904711d, b: 0.2498835420322547d, c: 0.9733560033126378d),

new NpgsqlTypes.NpgsqlLine(a: 0.7516653963992566d, b: 0.8871254006140514d, c: 0.9688544000775576d),

new NpgsqlTypes.NpgsqlLine(a: 0.5920030979667459d, b: 0.19764908877922582d, c: 0.5631519149614208d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(28));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(350174520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23005994787391715d, b: 0.314006898861965d, c: 0.9059890459886075d),

new NpgsqlTypes.NpgsqlLine(a: 0.0034924525333345224d, b: 0.22569705718656508d, c: 0.12293033480738269d),

new NpgsqlTypes.NpgsqlLine(a: 0.13769753447358068d, b: 0.20289930144832358d, c: 0.9141833823361538d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(528252532));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22785571390952986d, b: 0.47384563164287363d, c: 0.7296472935133859d),

new NpgsqlTypes.NpgsqlLine(a: 0.42847852345883053d, b: 0.05295602193643412d, c: 0.7176332323630693d),

new NpgsqlTypes.NpgsqlLine(a: 0.1313916587576558d, b: 0.44047120647606086d, c: 0.4080020542049758d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2023967945));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7526118185907706d, b: 0.7217192659741516d, c: 0.10725515353553927d),

new NpgsqlTypes.NpgsqlLine(a: 0.4123399872860949d, b: 0.9887632111198967d, c: 0.3407478138648996d),

new NpgsqlTypes.NpgsqlLine(a: 0.1972888611598902d, b: 0.21209298014251077d, c: 0.998100482656704d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32204440669620105d, b: 0.40425092983702615d, c: 0.6281187397686202d),

new NpgsqlTypes.NpgsqlLine(a: 0.8736370792109995d, b: 0.8257156419424208d, c: 0.24574228768788875d),

new NpgsqlTypes.NpgsqlLine(a: 0.1777372581271598d, b: 0.02795031420098848d, c: 0.6085263716794568d),

new NpgsqlTypes.NpgsqlLine(a: 0.3937718955623397d, b: 0.3857998777014512d, c: 0.16490107858931902d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(548719832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45120792613918626d, b: 0.7981849131464387d, c: 0.6797001557385036d),

new NpgsqlTypes.NpgsqlLine(a: 0.5152860785682492d, b: 0.05860524276063561d, c: 0.31392693425098706d),

new NpgsqlTypes.NpgsqlLine(a: 0.8399321644879826d, b: 0.14127845073157042d, c: 0.04919268640928787d),

new NpgsqlTypes.NpgsqlLine(a: 0.5367279979863265d, b: 0.9037039524330727d, c: 0.5651736207579545d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(632564420));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9871612756422758d, b: 0.7040000628939183d, c: 0.5741990515908977d),

new NpgsqlTypes.NpgsqlLine(a: 0.8939251170158339d, b: 0.591802460616856d, c: 0.8710953712464558d),

new NpgsqlTypes.NpgsqlLine(a: 0.925765879252592d, b: 0.020003653879282934d, c: 0.27174016206463947d),

new NpgsqlTypes.NpgsqlLine(a: 0.40821497810499396d, b: 0.18426353989680566d, c: 0.35762480728827095d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(569222828));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3541781533895836d, b: 0.8806877333215982d, c: 0.3434395351862555d),

new NpgsqlTypes.NpgsqlLine(a: 0.904182291889472d, b: 0.2725232832902962d, c: 0.11922376175569749d),

new NpgsqlTypes.NpgsqlLine(a: 0.2973949214938665d, b: 0.551548200515303d, c: 0.11510798755200236d),

new NpgsqlTypes.NpgsqlLine(a: 0.6236383027800103d, b: 0.7132402356425214d, c: 0.7946866828405127d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1120533763));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7797869567083358d, b: 0.2361739464389747d, c: 0.48164557546500963d),

new NpgsqlTypes.NpgsqlLine(a: 0.9480048066554808d, b: 0.8035492224666504d, c: 0.9832497213764478d),

new NpgsqlTypes.NpgsqlLine(a: 0.9772596541640088d, b: 0.6093516798517065d, c: 0.6052760903401032d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(617125650));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35787275736319957d, b: 0.702047825867143d, c: 0.965415572167533d),

new NpgsqlTypes.NpgsqlLine(a: 0.31090623461505584d, b: 0.5647177423851781d, c: 0.4846654296503867d),

new NpgsqlTypes.NpgsqlLine(a: 0.3183862992195977d, b: 0.6261458826331173d, c: 0.6907068588712774d),

new NpgsqlTypes.NpgsqlLine(a: 0.6487979418902344d, b: 0.4615179308283234d, c: 0.642127574912425d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9197027266355764d, b: 0.39215058098740485d, c: 0.17261332753094694d),

new NpgsqlTypes.NpgsqlLine(a: 0.11391459246246716d, b: 0.8528811542175645d, c: 0.20274869752530522d),

new NpgsqlTypes.NpgsqlLine(a: 0.36907637605105814d, b: 0.6376511000289307d, c: 0.12998307736849357d),

new NpgsqlTypes.NpgsqlLine(a: 0.9580086581171673d, b: 0.03050170247729178d, c: 0.38029624192446d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1413412459));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42503376733197573d, b: 0.763237079678654d, c: 0.09688502535476584d),

new NpgsqlTypes.NpgsqlLine(a: 0.23240822962655505d, b: 0.8459480271218152d, c: 0.08432931494869422d),

new NpgsqlTypes.NpgsqlLine(a: 0.18886663761414113d, b: 0.5079561486308892d, c: 0.9843388801596968d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(627974170));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15147399565049113d, b: 0.7627100647125816d, c: 0.16010235385722305d),

new NpgsqlTypes.NpgsqlLine(a: 0.9001358065765852d, b: 0.4721890907147458d, c: 0.15927787372271784d),

new NpgsqlTypes.NpgsqlLine(a: 0.7813049144298684d, b: 0.4136335409837938d, c: 0.12660196714031435d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.004236560392559818d, b: 0.39606208609499893d, c: 0.19741769434420997d),

new NpgsqlTypes.NpgsqlLine(a: 0.5953646586031078d, b: 0.6151314480582013d, c: 0.6556527973910132d),

new NpgsqlTypes.NpgsqlLine(a: 0.5407811339876436d, b: 0.9334248245144674d, c: 0.8365874899469636d),

new NpgsqlTypes.NpgsqlLine(a: 0.4764002070454937d, b: 0.16718217080509323d, c: 0.17236129187105342d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(791579102));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3341739254022562d, b: 0.718465753134697d, c: 0.5771634629019262d),

new NpgsqlTypes.NpgsqlLine(a: 0.6322200521292398d, b: 0.8246392866857581d, c: 0.5696079494467468d),

new NpgsqlTypes.NpgsqlLine(a: 0.6545382710133834d, b: 0.4365654599867256d, c: 0.8153585418393168d),

new NpgsqlTypes.NpgsqlLine(a: 0.0910019439659393d, b: 0.7174745892954046d, c: 0.1511089208473413d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1190383178));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12466334172066618d, b: 0.11152073168077081d, c: 0.491230984381532d),

new NpgsqlTypes.NpgsqlLine(a: 0.5547266175262346d, b: 0.13792449594977796d, c: 0.7570674004021489d),

new NpgsqlTypes.NpgsqlLine(a: 0.2085058544453703d, b: 0.08290359377194412d, c: 0.77495272781113d),

new NpgsqlTypes.NpgsqlLine(a: 0.49111506712078934d, b: 0.641116986925848d, c: 0.29516341556351666d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07914996961984966d, b: 0.4871418257809952d, c: 0.7513322508300865d),

new NpgsqlTypes.NpgsqlLine(a: 0.9239635289951339d, b: 0.38794777551433746d, c: 0.676783160212782d),

new NpgsqlTypes.NpgsqlLine(a: 0.0955538255878925d, b: 0.01055236041931451d, c: 0.2842563281409253d),

new NpgsqlTypes.NpgsqlLine(a: 0.02927332855673237d, b: 0.6165842674891228d, c: 0.8012173905302888d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(833599485));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4822973119466689d, b: 0.792513536759573d, c: 0.499633501292873d),

new NpgsqlTypes.NpgsqlLine(a: 0.8918073488512478d, b: 0.42208129985829845d, c: 0.5329638256901381d),

new NpgsqlTypes.NpgsqlLine(a: 0.5188620987187985d, b: 0.1726952436096839d, c: 0.7227459582321649d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15666178016283616d, b: 0.2873368213961791d, c: 0.4420895689102471d),

new NpgsqlTypes.NpgsqlLine(a: 0.4601057867375493d, b: 0.5622721416121373d, c: 0.2999980165807573d),

new NpgsqlTypes.NpgsqlLine(a: 0.8381583831951187d, b: 0.9764919740330239d, c: 0.18152562681640294d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1272632761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8378269016529278d, b: 0.6733240332238696d, c: 0.8919506779863193d),

new NpgsqlTypes.NpgsqlLine(a: 0.48570634731194795d, b: 0.1596671151368555d, c: 0.20750860994967846d),

new NpgsqlTypes.NpgsqlLine(a: 0.779653513645174d, b: 0.8586337096501773d, c: 0.1738735269722934d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2675334980310755d, b: 0.5860654638502302d, c: 0.5223481489931099d),

new NpgsqlTypes.NpgsqlLine(a: 0.2908190505712529d, b: 0.027311571062217044d, c: 0.38897855152716554d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590347289639254d, b: 0.6110078502040162d, c: 0.9773066927065011d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(896715967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4784147382307862d, b: 0.6552419336185478d, c: 0.920823919677529d),

new NpgsqlTypes.NpgsqlLine(a: 0.742593437228071d, b: 0.6268935209443758d, c: 0.5071732457335109d),

new NpgsqlTypes.NpgsqlLine(a: 0.6253496198816004d, b: 0.5361783003872929d, c: 0.7158348891331027d),

new NpgsqlTypes.NpgsqlLine(a: 0.4294538215627851d, b: 0.8234156672775046d, c: 0.08688024353682888d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(117280179));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3605977641294892d, b: 0.17811158147680461d, c: 0.9658058071756186d),

new NpgsqlTypes.NpgsqlLine(a: 0.6970256025820155d, b: 0.5444046414962291d, c: 0.46720686007108925d),

new NpgsqlTypes.NpgsqlLine(a: 0.8561050660597573d, b: 0.11353237597432853d, c: 0.56669941414895d),

new NpgsqlTypes.NpgsqlLine(a: 0.7984600619309864d, b: 0.8109151931011057d, c: 0.769305377302455d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0947306689172811d, b: 0.8302577671800684d, c: 0.8970532400118938d),

new NpgsqlTypes.NpgsqlLine(a: 0.2407748752003226d, b: 0.4567310255560061d, c: 0.4526792803927874d),

new NpgsqlTypes.NpgsqlLine(a: 0.04496104252758981d, b: 0.7589917027634498d, c: 0.6770421060059869d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(899804594));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1970857537444196d, b: 0.9333242638108382d, c: 0.2997924017071659d),

new NpgsqlTypes.NpgsqlLine(a: 0.6311349404614687d, b: 0.19618574736695826d, c: 0.38842914242231885d),

new NpgsqlTypes.NpgsqlLine(a: 0.8616526286116198d, b: 0.5020108677923993d, c: 0.7507796571723376d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8462722154822349d, b: 0.2140170588076531d, c: 0.1555300802445071d),

new NpgsqlTypes.NpgsqlLine(a: 0.05107346767082066d, b: 0.6007632357415391d, c: 0.11568725974145999d),

new NpgsqlTypes.NpgsqlLine(a: 0.9923537289603477d, b: 0.4950249871115745d, c: 0.02343990901364046d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(964637978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7665509369596407d, b: 0.32246651386445413d, c: 0.4163237996846909d),

new NpgsqlTypes.NpgsqlLine(a: 0.622867187513811d, b: 0.02481599358005626d, c: 0.6781914372848628d),

new NpgsqlTypes.NpgsqlLine(a: 0.9383962517038102d, b: 0.22799617371669267d, c: 0.11769282658114588d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1006841713));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3814391347607825d, b: 0.6500010795000312d, c: 0.5168910912789877d),

new NpgsqlTypes.NpgsqlLine(a: 0.9809725325416359d, b: 0.5965089551877092d, c: 0.9620206915411497d),

new NpgsqlTypes.NpgsqlLine(a: 0.8326177257415529d, b: 0.9726427466112844d, c: 0.44743910631138517d),

new NpgsqlTypes.NpgsqlLine(a: 0.9428905413649304d, b: 0.2742783552238923d, c: 0.20624247958140818d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4156588878635493d, b: 0.9311562710078888d, c: 0.18729745760128813d),

new NpgsqlTypes.NpgsqlLine(a: 0.7838364754377413d, b: 0.2902143764264882d, c: 0.6468999105347263d),

new NpgsqlTypes.NpgsqlLine(a: 0.2807400125401047d, b: 0.4738433713063067d, c: 0.3414032292061351d),

new NpgsqlTypes.NpgsqlLine(a: 0.07976939589399212d, b: 0.6817427263698487d, c: 0.7162950229594492d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1008288557));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6703103585772012d, b: 0.9414469448287122d, c: 0.32961805156524826d),

new NpgsqlTypes.NpgsqlLine(a: 0.13239408457631574d, b: 0.5134528929025426d, c: 0.5412589816963953d),

new NpgsqlTypes.NpgsqlLine(a: 0.1699098825091695d, b: 0.9194545880639252d, c: 0.7451240040858685d),

new NpgsqlTypes.NpgsqlLine(a: 0.2233903417330374d, b: 0.07771599830861675d, c: 0.5752102020647447d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(723640790));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8545769023218451d, b: 0.24286566112974062d, c: 0.24373271509232275d),

new NpgsqlTypes.NpgsqlLine(a: 0.8731571462637403d, b: 0.9993617334238951d, c: 0.1725755360195571d),

new NpgsqlTypes.NpgsqlLine(a: 0.2467482163165423d, b: 0.7309207508122816d, c: 0.574326589073651d),

new NpgsqlTypes.NpgsqlLine(a: 0.39429370255535745d, b: 0.12918013405283635d, c: 0.37279548432778786d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8697103680615146d, b: 0.4868697197066526d, c: 0.008300202872866591d),

new NpgsqlTypes.NpgsqlLine(a: 0.9268152455195247d, b: 0.9945415027788427d, c: 0.33225561051564245d),

new NpgsqlTypes.NpgsqlLine(a: 0.06541514412119742d, b: 0.29832372565206444d, c: 0.34837671529944225d),

new NpgsqlTypes.NpgsqlLine(a: 0.7703107306167513d, b: 0.39150187650435253d, c: 0.17912768771478083d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1212970907));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5991478813435879d, b: 0.21696546349723422d, c: 0.7473704822066682d),

new NpgsqlTypes.NpgsqlLine(a: 0.151066097236479d, b: 0.0802844223551269d, c: 0.09162465810768494d),

new NpgsqlTypes.NpgsqlLine(a: 0.8623052986382002d, b: 0.9298840839917386d, c: 0.6660510239194597d),

new NpgsqlTypes.NpgsqlLine(a: 0.9991351159913222d, b: 0.029361445428178645d, c: 0.30760770391653036d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2140414751));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5666355568463651d, b: 0.5532657932652175d, c: 0.043303548850170626d),

new NpgsqlTypes.NpgsqlLine(a: 0.4900959494886681d, b: 0.9349750472343457d, c: 0.4121355471301291d),

new NpgsqlTypes.NpgsqlLine(a: 0.06398838318692368d, b: 0.028285739863693204d, c: 0.8052480125394759d),

new NpgsqlTypes.NpgsqlLine(a: 0.31673961185856914d, b: 0.4141587759463713d, c: 0.1893488396111126d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1370558129));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9082169806472872d, b: 0.9235120225757552d, c: 0.8994934710072177d),

new NpgsqlTypes.NpgsqlLine(a: 0.12419478532476513d, b: 0.805126203795883d, c: 0.21123699569220133d),

new NpgsqlTypes.NpgsqlLine(a: 0.5518835410640954d, b: 0.3470463651950829d, c: 0.4121461426388031d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(196308953));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28578713252269017d, b: 0.8474368218362299d, c: 0.05146566977408318d),

new NpgsqlTypes.NpgsqlLine(a: 0.9109299616024349d, b: 0.5870141058904383d, c: 0.7452912896149598d),

new NpgsqlTypes.NpgsqlLine(a: 0.09671303857190205d, b: 0.22234046410281205d, c: 0.2889776640209598d),

new NpgsqlTypes.NpgsqlLine(a: 0.3594930797393622d, b: 0.1261117062789614d, c: 0.4836691385976134d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1411554384));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.43292849531653743d, b: 0.10139772092942057d, c: 0.19581477698464556d),

new NpgsqlTypes.NpgsqlLine(a: 0.7747830082073887d, b: 0.7612727046736724d, c: 0.49585407932443326d),

new NpgsqlTypes.NpgsqlLine(a: 0.7534769161594925d, b: 0.21640631521439513d, c: 0.9417215429915208d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1423267657));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7028157888188539d, b: 0.4434497177574276d, c: 0.1878584904244096d),

new NpgsqlTypes.NpgsqlLine(a: 0.12779644786129707d, b: 0.6547737034235738d, c: 0.7340324477099678d),

new NpgsqlTypes.NpgsqlLine(a: 0.13473852180731738d, b: 0.7900921279332365d, c: 0.7695417103969711d),

new NpgsqlTypes.NpgsqlLine(a: 0.2618677281295215d, b: 0.24821010444457137d, c: 0.2711393719015588d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1610745034));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6382266935775643d, b: 0.398693329671132d, c: 0.7425094436899613d),

new NpgsqlTypes.NpgsqlLine(a: 0.24327741116998813d, b: 0.1635267687203752d, c: 0.628031718062037d),

new NpgsqlTypes.NpgsqlLine(a: 0.38459544322295613d, b: 0.4141132804519537d, c: 0.8511486540491503d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9861241662988156d, b: 0.25399030999510996d, c: 0.2529918964264557d),

new NpgsqlTypes.NpgsqlLine(a: 0.17574090331875702d, b: 0.5215697754670754d, c: 0.49092403723555744d),

new NpgsqlTypes.NpgsqlLine(a: 0.9755215010138426d, b: 0.5836706698542481d, c: 0.8112425273051307d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1525343338));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5334739519154116d, b: 0.14533927203574382d, c: 0.9972375896646379d),

new NpgsqlTypes.NpgsqlLine(a: 0.5376404385911305d, b: 0.3967355325520928d, c: 0.2690585850054501d),

new NpgsqlTypes.NpgsqlLine(a: 0.7930288640515465d, b: 0.4034090749439643d, c: 0.19977351395319798d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22585130451050572d, b: 0.054454055462575424d, c: 0.3670135684186787d),

new NpgsqlTypes.NpgsqlLine(a: 0.8573417118252535d, b: 0.7290365889192361d, c: 0.15771025911629288d),

new NpgsqlTypes.NpgsqlLine(a: 0.8294206137900973d, b: 0.778292553399524d, c: 0.5844131999897239d),

new NpgsqlTypes.NpgsqlLine(a: 0.8795242286168519d, b: 0.43336364459496624d, c: 0.07939237473054006d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1618779845));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588222459861263d, b: 0.8314528851615401d, c: 0.4091425195520225d),

new NpgsqlTypes.NpgsqlLine(a: 0.15497545879234587d, b: 0.42501177297812087d, c: 0.3930386900482442d),

new NpgsqlTypes.NpgsqlLine(a: 0.49932759733861587d, b: 0.27860846401633954d, c: 0.22371479209453393d),

new NpgsqlTypes.NpgsqlLine(a: 0.6744750487770321d, b: 0.5185555306309229d, c: 0.48333909912156325d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6846715107366038d, b: 0.7822398219668835d, c: 0.6995656002724597d),

new NpgsqlTypes.NpgsqlLine(a: 0.34191163697506577d, b: 0.251427920689659d, c: 0.6372400180339429d),

new NpgsqlTypes.NpgsqlLine(a: 0.7615638356664386d, b: 0.38275705185682163d, c: 0.9430695395246483d),

new NpgsqlTypes.NpgsqlLine(a: 0.25861736938688795d, b: 0.2236086093911689d, c: 0.43081968027669826d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(111191550));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10079392481388938d, b: 0.47419284524344363d, c: 0.46999813598135487d),

new NpgsqlTypes.NpgsqlLine(a: 0.4512330545433114d, b: 0.7685777654216315d, c: 0.761484461621478d),

new NpgsqlTypes.NpgsqlLine(a: 0.7069502335832981d, b: 0.10867536284292001d, c: 0.803973548621565d),

new NpgsqlTypes.NpgsqlLine(a: 0.6710482193897285d, b: 0.3246300803211939d, c: 0.007931088387647223d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1651600176));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16882852097245493d, b: 0.6320810387310721d, c: 0.4943119337666173d),

new NpgsqlTypes.NpgsqlLine(a: 0.1864608664190791d, b: 0.3923939341785333d, c: 0.40778672849944797d),

new NpgsqlTypes.NpgsqlLine(a: 0.21658079009283382d, b: 0.9735580473103661d, c: 0.5313780798893142d),

new NpgsqlTypes.NpgsqlLine(a: 0.608447080933292d, b: 0.9095061095638245d, c: 0.664417030599092d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1656686707));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08369873952495288d, b: 0.07788317757867735d, c: 0.284112517861248d),

new NpgsqlTypes.NpgsqlLine(a: 0.617171498263342d, b: 0.5865508373972511d, c: 0.36018099841433293d),

new NpgsqlTypes.NpgsqlLine(a: 0.4798021589910493d, b: 0.5378837702166812d, c: 0.2195325878675365d),

new NpgsqlTypes.NpgsqlLine(a: 0.961753857136392d, b: 0.8919192421134503d, c: 0.16540674234160435d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1264360862));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3150738269575506d, b: 0.25723902915678687d, c: 0.7085220942560913d),

new NpgsqlTypes.NpgsqlLine(a: 0.10217399526832571d, b: 0.23606907248025677d, c: 0.14832581681823231d),

new NpgsqlTypes.NpgsqlLine(a: 0.38475783269574504d, b: 0.261674953378639d, c: 0.8414017715374641d),

new NpgsqlTypes.NpgsqlLine(a: 0.060969244577031345d, b: 0.7001282741779633d, c: 0.8180532031964253d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1800975967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6019711101236188d, b: 0.451502314152629d, c: 0.7567258646896037d),

new NpgsqlTypes.NpgsqlLine(a: 0.20314867633928102d, b: 0.43694052621738755d, c: 0.07972430095228344d),

new NpgsqlTypes.NpgsqlLine(a: 0.38639176328531444d, b: 0.5546727142910798d, c: 0.3595107666863845d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(116492752));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8534388679989421d, b: 0.17051639981163313d, c: 0.11184373953100968d),

new NpgsqlTypes.NpgsqlLine(a: 0.5545649696933802d, b: 0.6495249060333349d, c: 0.14480165352840013d),

new NpgsqlTypes.NpgsqlLine(a: 0.7068689700072772d, b: 0.10325704725403717d, c: 0.1383403540154834d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.565937691937727d, b: 0.8643068916219007d, c: 0.7899347881580714d),

new NpgsqlTypes.NpgsqlLine(a: 0.5461437063589625d, b: 0.8396992488239946d, c: 0.4549808859483121d),

new NpgsqlTypes.NpgsqlLine(a: 0.11142572920429805d, b: 0.7092154686109046d, c: 0.04531658445440445d),

new NpgsqlTypes.NpgsqlLine(a: 0.8590566964589479d, b: 0.07365357454587718d, c: 0.01783865983951749d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858289195));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25032438445726d, b: 0.0917391846373673d, c: 0.34066051809002806d),

new NpgsqlTypes.NpgsqlLine(a: 0.07831144663304057d, b: 0.77591037387439d, c: 0.19759580235224372d),

new NpgsqlTypes.NpgsqlLine(a: 0.3752205191956137d, b: 0.9100313386910368d, c: 0.6525871812195568d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47106408656007914d, b: 0.14257658261320605d, c: 0.47373760961489964d),

new NpgsqlTypes.NpgsqlLine(a: 0.4366806562773925d, b: 0.20146202051894901d, c: 0.3244113712884158d),

new NpgsqlTypes.NpgsqlLine(a: 0.41468311552317627d, b: 0.27557991533085235d, c: 0.7788691278257713d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1908397739));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36399675452528046d, b: 0.21180965313124933d, c: 0.6232643186817026d),

new NpgsqlTypes.NpgsqlLine(a: 0.8377534917307251d, b: 0.7197248111141329d, c: 0.5638759891270843d),

new NpgsqlTypes.NpgsqlLine(a: 0.9127913721936561d, b: 0.47658260676426356d, c: 0.4401534500107992d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.502181779437056d, b: 0.3652805047459293d, c: 0.32001644451474576d),

new NpgsqlTypes.NpgsqlLine(a: 0.7113651445912559d, b: 0.3869191031273206d, c: 0.7332400621535746d),

new NpgsqlTypes.NpgsqlLine(a: 0.5302147002696467d, b: 0.6514960201183412d, c: 0.8888784836070758d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1921152006));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3706659351474607d, b: 0.20392121211971403d, c: 0.09026673921559647d),

new NpgsqlTypes.NpgsqlLine(a: 0.3426907809834573d, b: 0.11597889224231583d, c: 0.37580383029156417d),

new NpgsqlTypes.NpgsqlLine(a: 0.9569454063294334d, b: 0.5352074925592666d, c: 0.1505041653825815d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(322154126));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17316937563192347d, b: 0.7977878569807266d, c: 0.5061623155222499d),

new NpgsqlTypes.NpgsqlLine(a: 0.39020299771548206d, b: 0.46872469438895703d, c: 0.1947250961658502d),

new NpgsqlTypes.NpgsqlLine(a: 0.9460666899443665d, b: 0.40873002207057996d, c: 0.5383135596603867d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[25];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931477721));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24029930494024243d, b: 0.6494520983530296d, c: 0.6457904476196421d),

new NpgsqlTypes.NpgsqlLine(a: 0.5413106581652064d, b: 0.65922568011039d, c: 0.023000101756869618d),

new NpgsqlTypes.NpgsqlLine(a: 0.05698461456670889d, b: 0.07946838244893384d, c: 0.023133320459978735d),

new NpgsqlTypes.NpgsqlLine(a: 0.023417572430763367d, b: 0.20022755743974863d, c: 0.9001563624157146d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3818728397283605d, b: 0.24081372003152057d, c: 0.42604600108359325d),

new NpgsqlTypes.NpgsqlLine(a: 0.9919565701428744d, b: 0.9836921588174795d, c: 0.6353618672799166d),

new NpgsqlTypes.NpgsqlLine(a: 0.49779514301225014d, b: 0.9235637976007209d, c: 0.26480996790155775d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[26];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943853869));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5132420668035784d, b: 0.9613252483783701d, c: 0.9242449431625296d),

new NpgsqlTypes.NpgsqlLine(a: 0.36653456446188004d, b: 0.7359631901409467d, c: 0.27792441954855884d),

new NpgsqlTypes.NpgsqlLine(a: 0.4636783251093567d, b: 0.1186591604974756d, c: 0.39388519565520497d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[27];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1951774404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4334255210533513d, b: 0.5785255926410576d, c: 0.9661508534687067d),

new NpgsqlTypes.NpgsqlLine(a: 0.19775236418153797d, b: 0.9365672085879589d, c: 0.1494826860380959d),

new NpgsqlTypes.NpgsqlLine(a: 0.176207462329397d, b: 0.2629253672101627d, c: 0.07007543599573873d),

new NpgsqlTypes.NpgsqlLine(a: 0.12818842182277845d, b: 0.1863366614728862d, c: 0.7134229928630377d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6151166351904711d, b: 0.2498835420322547d, c: 0.9733560033126378d),

new NpgsqlTypes.NpgsqlLine(a: 0.7516653963992566d, b: 0.8871254006140514d, c: 0.9688544000775576d),

new NpgsqlTypes.NpgsqlLine(a: 0.5920030979667459d, b: 0.19764908877922582d, c: 0.5631519149614208d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }
                    
                    //todo return false
                }
            }
        }

        #endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MI),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public
            )
            ]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray2MI>(7);

                importCollection.Add(
                new NpgsqlLinelineArray2MI
                {
                    Id = 111191550,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10079392481388938d, b: 0.47419284524344363d, c: 0.46999813598135487d),

new NpgsqlTypes.NpgsqlLine(a: 0.4512330545433114d, b: 0.7685777654216315d, c: 0.761484461621478d),

new NpgsqlTypes.NpgsqlLine(a: 0.7069502335832981d, b: 0.10867536284292001d, c: 0.803973548621565d),

new NpgsqlTypes.NpgsqlLine(a: 0.6710482193897285d, b: 0.3246300803211939d, c: 0.007931088387647223d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlLinelineArray2MI
                {
                    Id = 116492752,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8534388679989421d, b: 0.17051639981163313d, c: 0.11184373953100968d),

new NpgsqlTypes.NpgsqlLine(a: 0.5545649696933802d, b: 0.6495249060333349d, c: 0.14480165352840013d),

new NpgsqlTypes.NpgsqlLine(a: 0.7068689700072772d, b: 0.10325704725403717d, c: 0.1383403540154834d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.565937691937727d, b: 0.8643068916219007d, c: 0.7899347881580714d),

new NpgsqlTypes.NpgsqlLine(a: 0.5461437063589625d, b: 0.8396992488239946d, c: 0.4549808859483121d),

new NpgsqlTypes.NpgsqlLine(a: 0.11142572920429805d, b: 0.7092154686109046d, c: 0.04531658445440445d),

new NpgsqlTypes.NpgsqlLine(a: 0.8590566964589479d, b: 0.07365357454587718d, c: 0.01783865983951749d),

}
                });

                importCollection.Add(
                new NpgsqlLinelineArray2MI
                {
                    Id = 117280179,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3605977641294892d, b: 0.17811158147680461d, c: 0.9658058071756186d),

new NpgsqlTypes.NpgsqlLine(a: 0.6970256025820155d, b: 0.5444046414962291d, c: 0.46720686007108925d),

new NpgsqlTypes.NpgsqlLine(a: 0.8561050660597573d, b: 0.11353237597432853d, c: 0.56669941414895d),

new NpgsqlTypes.NpgsqlLine(a: 0.7984600619309864d, b: 0.8109151931011057d, c: 0.769305377302455d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0947306689172811d, b: 0.8302577671800684d, c: 0.8970532400118938d),

new NpgsqlTypes.NpgsqlLine(a: 0.2407748752003226d, b: 0.4567310255560061d, c: 0.4526792803927874d),

new NpgsqlTypes.NpgsqlLine(a: 0.04496104252758981d, b: 0.7589917027634498d, c: 0.6770421060059869d),

}
                });

                importCollection.Add(
                new NpgsqlLinelineArray2MI
                {
                    Id = 196308953,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28578713252269017d, b: 0.8474368218362299d, c: 0.05146566977408318d),

new NpgsqlTypes.NpgsqlLine(a: 0.9109299616024349d, b: 0.5870141058904383d, c: 0.7452912896149598d),

new NpgsqlTypes.NpgsqlLine(a: 0.09671303857190205d, b: 0.22234046410281205d, c: 0.2889776640209598d),

new NpgsqlTypes.NpgsqlLine(a: 0.3594930797393622d, b: 0.1261117062789614d, c: 0.4836691385976134d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlLinelineArray2MI
                {
                    Id = 322154126,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17316937563192347d, b: 0.7977878569807266d, c: 0.5061623155222499d),

new NpgsqlTypes.NpgsqlLine(a: 0.39020299771548206d, b: 0.46872469438895703d, c: 0.1947250961658502d),

new NpgsqlTypes.NpgsqlLine(a: 0.9460666899443665d, b: 0.40873002207057996d, c: 0.5383135596603867d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlLinelineArray2MI
                {
                    Id = 632564420,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9871612756422758d, b: 0.7040000628939183d, c: 0.5741990515908977d),

new NpgsqlTypes.NpgsqlLine(a: 0.8939251170158339d, b: 0.591802460616856d, c: 0.8710953712464558d),

new NpgsqlTypes.NpgsqlLine(a: 0.925765879252592d, b: 0.020003653879282934d, c: 0.27174016206463947d),

new NpgsqlTypes.NpgsqlLine(a: 0.40821497810499396d, b: 0.18426353989680566d, c: 0.35762480728827095d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlLinelineArray2MI
                {
                    Id = 723640790,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8545769023218451d, b: 0.24286566112974062d, c: 0.24373271509232275d),

new NpgsqlTypes.NpgsqlLine(a: 0.8731571462637403d, b: 0.9993617334238951d, c: 0.1725755360195571d),

new NpgsqlTypes.NpgsqlLine(a: 0.2467482163165423d, b: 0.7309207508122816d, c: 0.574326589073651d),

new NpgsqlTypes.NpgsqlLine(a: 0.39429370255535745d, b: 0.12918013405283635d, c: 0.37279548432778786d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8697103680615146d, b: 0.4868697197066526d, c: 0.008300202872866591d),

new NpgsqlTypes.NpgsqlLine(a: 0.9268152455195247d, b: 0.9945415027788427d, c: 0.33225561051564245d),

new NpgsqlTypes.NpgsqlLine(a: 0.06541514412119742d, b: 0.29832372565206444d, c: 0.34837671529944225d),

new NpgsqlTypes.NpgsqlLine(a: 0.7703107306167513d, b: 0.39150187650435253d, c: 0.17912768771478083d),

}
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(111191550));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10079392481388938d, b: 0.47419284524344363d, c: 0.46999813598135487d),

new NpgsqlTypes.NpgsqlLine(a: 0.4512330545433114d, b: 0.7685777654216315d, c: 0.761484461621478d),

new NpgsqlTypes.NpgsqlLine(a: 0.7069502335832981d, b: 0.10867536284292001d, c: 0.803973548621565d),

new NpgsqlTypes.NpgsqlLine(a: 0.6710482193897285d, b: 0.3246300803211939d, c: 0.007931088387647223d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(116492752));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8534388679989421d, b: 0.17051639981163313d, c: 0.11184373953100968d),

new NpgsqlTypes.NpgsqlLine(a: 0.5545649696933802d, b: 0.6495249060333349d, c: 0.14480165352840013d),

new NpgsqlTypes.NpgsqlLine(a: 0.7068689700072772d, b: 0.10325704725403717d, c: 0.1383403540154834d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.565937691937727d, b: 0.8643068916219007d, c: 0.7899347881580714d),

new NpgsqlTypes.NpgsqlLine(a: 0.5461437063589625d, b: 0.8396992488239946d, c: 0.4549808859483121d),

new NpgsqlTypes.NpgsqlLine(a: 0.11142572920429805d, b: 0.7092154686109046d, c: 0.04531658445440445d),

new NpgsqlTypes.NpgsqlLine(a: 0.8590566964589479d, b: 0.07365357454587718d, c: 0.01783865983951749d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(117280179));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3605977641294892d, b: 0.17811158147680461d, c: 0.9658058071756186d),

new NpgsqlTypes.NpgsqlLine(a: 0.6970256025820155d, b: 0.5444046414962291d, c: 0.46720686007108925d),

new NpgsqlTypes.NpgsqlLine(a: 0.8561050660597573d, b: 0.11353237597432853d, c: 0.56669941414895d),

new NpgsqlTypes.NpgsqlLine(a: 0.7984600619309864d, b: 0.8109151931011057d, c: 0.769305377302455d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0947306689172811d, b: 0.8302577671800684d, c: 0.8970532400118938d),

new NpgsqlTypes.NpgsqlLine(a: 0.2407748752003226d, b: 0.4567310255560061d, c: 0.4526792803927874d),

new NpgsqlTypes.NpgsqlLine(a: 0.04496104252758981d, b: 0.7589917027634498d, c: 0.6770421060059869d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(196308953));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28578713252269017d, b: 0.8474368218362299d, c: 0.05146566977408318d),

new NpgsqlTypes.NpgsqlLine(a: 0.9109299616024349d, b: 0.5870141058904383d, c: 0.7452912896149598d),

new NpgsqlTypes.NpgsqlLine(a: 0.09671303857190205d, b: 0.22234046410281205d, c: 0.2889776640209598d),

new NpgsqlTypes.NpgsqlLine(a: 0.3594930797393622d, b: 0.1261117062789614d, c: 0.4836691385976134d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(322154126));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17316937563192347d, b: 0.7977878569807266d, c: 0.5061623155222499d),

new NpgsqlTypes.NpgsqlLine(a: 0.39020299771548206d, b: 0.46872469438895703d, c: 0.1947250961658502d),

new NpgsqlTypes.NpgsqlLine(a: 0.9460666899443665d, b: 0.40873002207057996d, c: 0.5383135596603867d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(632564420));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9871612756422758d, b: 0.7040000628939183d, c: 0.5741990515908977d),

new NpgsqlTypes.NpgsqlLine(a: 0.8939251170158339d, b: 0.591802460616856d, c: 0.8710953712464558d),

new NpgsqlTypes.NpgsqlLine(a: 0.925765879252592d, b: 0.020003653879282934d, c: 0.27174016206463947d),

new NpgsqlTypes.NpgsqlLine(a: 0.40821497810499396d, b: 0.18426353989680566d, c: 0.35762480728827095d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(723640790));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8545769023218451d, b: 0.24286566112974062d, c: 0.24373271509232275d),

new NpgsqlTypes.NpgsqlLine(a: 0.8731571462637403d, b: 0.9993617334238951d, c: 0.1725755360195571d),

new NpgsqlTypes.NpgsqlLine(a: 0.2467482163165423d, b: 0.7309207508122816d, c: 0.574326589073651d),

new NpgsqlTypes.NpgsqlLine(a: 0.39429370255535745d, b: 0.12918013405283635d, c: 0.37279548432778786d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8697103680615146d, b: 0.4868697197066526d, c: 0.008300202872866591d),

new NpgsqlTypes.NpgsqlLine(a: 0.9268152455195247d, b: 0.9945415027788427d, c: 0.33225561051564245d),

new NpgsqlTypes.NpgsqlLine(a: 0.06541514412119742d, b: 0.29832372565206444d, c: 0.34837671529944225d),

new NpgsqlTypes.NpgsqlLine(a: 0.7703107306167513d, b: 0.39150187650435253d, c: 0.17912768771478083d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                importCollection.Clear();

                importCollection.Add(
                new NpgsqlLinelineArray2MI
                {
                    Id = 1120533763,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7797869567083358d, b: 0.2361739464389747d, c: 0.48164557546500963d),

new NpgsqlTypes.NpgsqlLine(a: 0.9480048066554808d, b: 0.8035492224666504d, c: 0.9832497213764478d),

new NpgsqlTypes.NpgsqlLine(a: 0.9772596541640088d, b: 0.6093516798517065d, c: 0.6052760903401032d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlLinelineArray2MI
                {
                    Id = 1190383178,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12466334172066618d, b: 0.11152073168077081d, c: 0.491230984381532d),

new NpgsqlTypes.NpgsqlLine(a: 0.5547266175262346d, b: 0.13792449594977796d, c: 0.7570674004021489d),

new NpgsqlTypes.NpgsqlLine(a: 0.2085058544453703d, b: 0.08290359377194412d, c: 0.77495272781113d),

new NpgsqlTypes.NpgsqlLine(a: 0.49111506712078934d, b: 0.641116986925848d, c: 0.29516341556351666d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07914996961984966d, b: 0.4871418257809952d, c: 0.7513322508300865d),

new NpgsqlTypes.NpgsqlLine(a: 0.9239635289951339d, b: 0.38794777551433746d, c: 0.676783160212782d),

new NpgsqlTypes.NpgsqlLine(a: 0.0955538255878925d, b: 0.01055236041931451d, c: 0.2842563281409253d),

new NpgsqlTypes.NpgsqlLine(a: 0.02927332855673237d, b: 0.6165842674891228d, c: 0.8012173905302888d),

}
                });

                importCollection.Add(
                new NpgsqlLinelineArray2MI
                {
                    Id = 1264360862,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3150738269575506d, b: 0.25723902915678687d, c: 0.7085220942560913d),

new NpgsqlTypes.NpgsqlLine(a: 0.10217399526832571d, b: 0.23606907248025677d, c: 0.14832581681823231d),

new NpgsqlTypes.NpgsqlLine(a: 0.38475783269574504d, b: 0.261674953378639d, c: 0.8414017715374641d),

new NpgsqlTypes.NpgsqlLine(a: 0.060969244577031345d, b: 0.7001282741779633d, c: 0.8180532031964253d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlLinelineArray2MI
                {
                    Id = 1272632761,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8378269016529278d, b: 0.6733240332238696d, c: 0.8919506779863193d),

new NpgsqlTypes.NpgsqlLine(a: 0.48570634731194795d, b: 0.1596671151368555d, c: 0.20750860994967846d),

new NpgsqlTypes.NpgsqlLine(a: 0.779653513645174d, b: 0.8586337096501773d, c: 0.1738735269722934d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2675334980310755d, b: 0.5860654638502302d, c: 0.5223481489931099d),

new NpgsqlTypes.NpgsqlLine(a: 0.2908190505712529d, b: 0.027311571062217044d, c: 0.38897855152716554d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590347289639254d, b: 0.6110078502040162d, c: 0.9773066927065011d),

}
                });

                importCollection.Add(
                new NpgsqlLinelineArray2MI
                {
                    Id = 1413412459,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42503376733197573d, b: 0.763237079678654d, c: 0.09688502535476584d),

new NpgsqlTypes.NpgsqlLine(a: 0.23240822962655505d, b: 0.8459480271218152d, c: 0.08432931494869422d),

new NpgsqlTypes.NpgsqlLine(a: 0.18886663761414113d, b: 0.5079561486308892d, c: 0.9843388801596968d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlLinelineArray2MI
                {
                    Id = 1525343338,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5334739519154116d, b: 0.14533927203574382d, c: 0.9972375896646379d),

new NpgsqlTypes.NpgsqlLine(a: 0.5376404385911305d, b: 0.3967355325520928d, c: 0.2690585850054501d),

new NpgsqlTypes.NpgsqlLine(a: 0.7930288640515465d, b: 0.4034090749439643d, c: 0.19977351395319798d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22585130451050572d, b: 0.054454055462575424d, c: 0.3670135684186787d),

new NpgsqlTypes.NpgsqlLine(a: 0.8573417118252535d, b: 0.7290365889192361d, c: 0.15771025911629288d),

new NpgsqlTypes.NpgsqlLine(a: 0.8294206137900973d, b: 0.778292553399524d, c: 0.5844131999897239d),

new NpgsqlTypes.NpgsqlLine(a: 0.8795242286168519d, b: 0.43336364459496624d, c: 0.07939237473054006d),

}
                });

                importCollection.Add(
                new NpgsqlLinelineArray2MI
                {
                    Id = 2023967945,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7526118185907706d, b: 0.7217192659741516d, c: 0.10725515353553927d),

new NpgsqlTypes.NpgsqlLine(a: 0.4123399872860949d, b: 0.9887632111198967d, c: 0.3407478138648996d),

new NpgsqlTypes.NpgsqlLine(a: 0.1972888611598902d, b: 0.21209298014251077d, c: 0.998100482656704d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32204440669620105d, b: 0.40425092983702615d, c: 0.6281187397686202d),

new NpgsqlTypes.NpgsqlLine(a: 0.8736370792109995d, b: 0.8257156419424208d, c: 0.24574228768788875d),

new NpgsqlTypes.NpgsqlLine(a: 0.1777372581271598d, b: 0.02795031420098848d, c: 0.6085263716794568d),

new NpgsqlTypes.NpgsqlLine(a: 0.3937718955623397d, b: 0.3857998777014512d, c: 0.16490107858931902d),

}
                });

                importCollection.Add(
                new NpgsqlLinelineArray2MI
                {
                    Id = 2140414751,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5666355568463651d, b: 0.5532657932652175d, c: 0.043303548850170626d),

new NpgsqlTypes.NpgsqlLine(a: 0.4900959494886681d, b: 0.9349750472343457d, c: 0.4121355471301291d),

new NpgsqlTypes.NpgsqlLine(a: 0.06398838318692368d, b: 0.028285739863693204d, c: 0.8052480125394759d),

new NpgsqlTypes.NpgsqlLine(a: 0.31673961185856914d, b: 0.4141587759463713d, c: 0.1893488396111126d),

},
                    NullableValue = null
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(111191550));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10079392481388938d, b: 0.47419284524344363d, c: 0.46999813598135487d),

new NpgsqlTypes.NpgsqlLine(a: 0.4512330545433114d, b: 0.7685777654216315d, c: 0.761484461621478d),

new NpgsqlTypes.NpgsqlLine(a: 0.7069502335832981d, b: 0.10867536284292001d, c: 0.803973548621565d),

new NpgsqlTypes.NpgsqlLine(a: 0.6710482193897285d, b: 0.3246300803211939d, c: 0.007931088387647223d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(116492752));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8534388679989421d, b: 0.17051639981163313d, c: 0.11184373953100968d),

new NpgsqlTypes.NpgsqlLine(a: 0.5545649696933802d, b: 0.6495249060333349d, c: 0.14480165352840013d),

new NpgsqlTypes.NpgsqlLine(a: 0.7068689700072772d, b: 0.10325704725403717d, c: 0.1383403540154834d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.565937691937727d, b: 0.8643068916219007d, c: 0.7899347881580714d),

new NpgsqlTypes.NpgsqlLine(a: 0.5461437063589625d, b: 0.8396992488239946d, c: 0.4549808859483121d),

new NpgsqlTypes.NpgsqlLine(a: 0.11142572920429805d, b: 0.7092154686109046d, c: 0.04531658445440445d),

new NpgsqlTypes.NpgsqlLine(a: 0.8590566964589479d, b: 0.07365357454587718d, c: 0.01783865983951749d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(117280179));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3605977641294892d, b: 0.17811158147680461d, c: 0.9658058071756186d),

new NpgsqlTypes.NpgsqlLine(a: 0.6970256025820155d, b: 0.5444046414962291d, c: 0.46720686007108925d),

new NpgsqlTypes.NpgsqlLine(a: 0.8561050660597573d, b: 0.11353237597432853d, c: 0.56669941414895d),

new NpgsqlTypes.NpgsqlLine(a: 0.7984600619309864d, b: 0.8109151931011057d, c: 0.769305377302455d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0947306689172811d, b: 0.8302577671800684d, c: 0.8970532400118938d),

new NpgsqlTypes.NpgsqlLine(a: 0.2407748752003226d, b: 0.4567310255560061d, c: 0.4526792803927874d),

new NpgsqlTypes.NpgsqlLine(a: 0.04496104252758981d, b: 0.7589917027634498d, c: 0.6770421060059869d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(196308953));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28578713252269017d, b: 0.8474368218362299d, c: 0.05146566977408318d),

new NpgsqlTypes.NpgsqlLine(a: 0.9109299616024349d, b: 0.5870141058904383d, c: 0.7452912896149598d),

new NpgsqlTypes.NpgsqlLine(a: 0.09671303857190205d, b: 0.22234046410281205d, c: 0.2889776640209598d),

new NpgsqlTypes.NpgsqlLine(a: 0.3594930797393622d, b: 0.1261117062789614d, c: 0.4836691385976134d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(322154126));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17316937563192347d, b: 0.7977878569807266d, c: 0.5061623155222499d),

new NpgsqlTypes.NpgsqlLine(a: 0.39020299771548206d, b: 0.46872469438895703d, c: 0.1947250961658502d),

new NpgsqlTypes.NpgsqlLine(a: 0.9460666899443665d, b: 0.40873002207057996d, c: 0.5383135596603867d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(632564420));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9871612756422758d, b: 0.7040000628939183d, c: 0.5741990515908977d),

new NpgsqlTypes.NpgsqlLine(a: 0.8939251170158339d, b: 0.591802460616856d, c: 0.8710953712464558d),

new NpgsqlTypes.NpgsqlLine(a: 0.925765879252592d, b: 0.020003653879282934d, c: 0.27174016206463947d),

new NpgsqlTypes.NpgsqlLine(a: 0.40821497810499396d, b: 0.18426353989680566d, c: 0.35762480728827095d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(723640790));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8545769023218451d, b: 0.24286566112974062d, c: 0.24373271509232275d),

new NpgsqlTypes.NpgsqlLine(a: 0.8731571462637403d, b: 0.9993617334238951d, c: 0.1725755360195571d),

new NpgsqlTypes.NpgsqlLine(a: 0.2467482163165423d, b: 0.7309207508122816d, c: 0.574326589073651d),

new NpgsqlTypes.NpgsqlLine(a: 0.39429370255535745d, b: 0.12918013405283635d, c: 0.37279548432778786d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8697103680615146d, b: 0.4868697197066526d, c: 0.008300202872866591d),

new NpgsqlTypes.NpgsqlLine(a: 0.9268152455195247d, b: 0.9945415027788427d, c: 0.33225561051564245d),

new NpgsqlTypes.NpgsqlLine(a: 0.06541514412119742d, b: 0.29832372565206444d, c: 0.34837671529944225d),

new NpgsqlTypes.NpgsqlLine(a: 0.7703107306167513d, b: 0.39150187650435253d, c: 0.17912768771478083d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1120533763));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7797869567083358d, b: 0.2361739464389747d, c: 0.48164557546500963d),

new NpgsqlTypes.NpgsqlLine(a: 0.9480048066554808d, b: 0.8035492224666504d, c: 0.9832497213764478d),

new NpgsqlTypes.NpgsqlLine(a: 0.9772596541640088d, b: 0.6093516798517065d, c: 0.6052760903401032d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1190383178));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12466334172066618d, b: 0.11152073168077081d, c: 0.491230984381532d),

new NpgsqlTypes.NpgsqlLine(a: 0.5547266175262346d, b: 0.13792449594977796d, c: 0.7570674004021489d),

new NpgsqlTypes.NpgsqlLine(a: 0.2085058544453703d, b: 0.08290359377194412d, c: 0.77495272781113d),

new NpgsqlTypes.NpgsqlLine(a: 0.49111506712078934d, b: 0.641116986925848d, c: 0.29516341556351666d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07914996961984966d, b: 0.4871418257809952d, c: 0.7513322508300865d),

new NpgsqlTypes.NpgsqlLine(a: 0.9239635289951339d, b: 0.38794777551433746d, c: 0.676783160212782d),

new NpgsqlTypes.NpgsqlLine(a: 0.0955538255878925d, b: 0.01055236041931451d, c: 0.2842563281409253d),

new NpgsqlTypes.NpgsqlLine(a: 0.02927332855673237d, b: 0.6165842674891228d, c: 0.8012173905302888d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1264360862));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3150738269575506d, b: 0.25723902915678687d, c: 0.7085220942560913d),

new NpgsqlTypes.NpgsqlLine(a: 0.10217399526832571d, b: 0.23606907248025677d, c: 0.14832581681823231d),

new NpgsqlTypes.NpgsqlLine(a: 0.38475783269574504d, b: 0.261674953378639d, c: 0.8414017715374641d),

new NpgsqlTypes.NpgsqlLine(a: 0.060969244577031345d, b: 0.7001282741779633d, c: 0.8180532031964253d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1272632761));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8378269016529278d, b: 0.6733240332238696d, c: 0.8919506779863193d),

new NpgsqlTypes.NpgsqlLine(a: 0.48570634731194795d, b: 0.1596671151368555d, c: 0.20750860994967846d),

new NpgsqlTypes.NpgsqlLine(a: 0.779653513645174d, b: 0.8586337096501773d, c: 0.1738735269722934d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2675334980310755d, b: 0.5860654638502302d, c: 0.5223481489931099d),

new NpgsqlTypes.NpgsqlLine(a: 0.2908190505712529d, b: 0.027311571062217044d, c: 0.38897855152716554d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590347289639254d, b: 0.6110078502040162d, c: 0.9773066927065011d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1413412459));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42503376733197573d, b: 0.763237079678654d, c: 0.09688502535476584d),

new NpgsqlTypes.NpgsqlLine(a: 0.23240822962655505d, b: 0.8459480271218152d, c: 0.08432931494869422d),

new NpgsqlTypes.NpgsqlLine(a: 0.18886663761414113d, b: 0.5079561486308892d, c: 0.9843388801596968d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1525343338));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5334739519154116d, b: 0.14533927203574382d, c: 0.9972375896646379d),

new NpgsqlTypes.NpgsqlLine(a: 0.5376404385911305d, b: 0.3967355325520928d, c: 0.2690585850054501d),

new NpgsqlTypes.NpgsqlLine(a: 0.7930288640515465d, b: 0.4034090749439643d, c: 0.19977351395319798d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22585130451050572d, b: 0.054454055462575424d, c: 0.3670135684186787d),

new NpgsqlTypes.NpgsqlLine(a: 0.8573417118252535d, b: 0.7290365889192361d, c: 0.15771025911629288d),

new NpgsqlTypes.NpgsqlLine(a: 0.8294206137900973d, b: 0.778292553399524d, c: 0.5844131999897239d),

new NpgsqlTypes.NpgsqlLine(a: 0.8795242286168519d, b: 0.43336364459496624d, c: 0.07939237473054006d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2023967945));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7526118185907706d, b: 0.7217192659741516d, c: 0.10725515353553927d),

new NpgsqlTypes.NpgsqlLine(a: 0.4123399872860949d, b: 0.9887632111198967d, c: 0.3407478138648996d),

new NpgsqlTypes.NpgsqlLine(a: 0.1972888611598902d, b: 0.21209298014251077d, c: 0.998100482656704d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32204440669620105d, b: 0.40425092983702615d, c: 0.6281187397686202d),

new NpgsqlTypes.NpgsqlLine(a: 0.8736370792109995d, b: 0.8257156419424208d, c: 0.24574228768788875d),

new NpgsqlTypes.NpgsqlLine(a: 0.1777372581271598d, b: 0.02795031420098848d, c: 0.6085263716794568d),

new NpgsqlTypes.NpgsqlLine(a: 0.3937718955623397d, b: 0.3857998777014512d, c: 0.16490107858931902d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2140414751));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5666355568463651d, b: 0.5532657932652175d, c: 0.043303548850170626d),

new NpgsqlTypes.NpgsqlLine(a: 0.4900959494886681d, b: 0.9349750472343457d, c: 0.4121355471301291d),

new NpgsqlTypes.NpgsqlLine(a: 0.06398838318692368d, b: 0.028285739863693204d, c: 0.8052480125394759d),

new NpgsqlTypes.NpgsqlLine(a: 0.31673961185856914d, b: 0.4141587759463713d, c: 0.1893488396111126d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
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
FROM public.binary_npgsqllinelinearray2m m
LEFT JOIN public.binary_npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(NpgsqlLinelineArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public
            )
            ]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray2M>(15);

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 94091086,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.756130013480001d, b: 0.8070063086186816d, c: 0.5025767314647364d),

new NpgsqlTypes.NpgsqlLine(a: 0.9364656141137178d, b: 0.4282247001937053d, c: 0.659495056495708d),

new NpgsqlTypes.NpgsqlLine(a: 0.2335034105141761d, b: 0.052909961042862275d, c: 0.04122572474287722d),

new NpgsqlTypes.NpgsqlLine(a: 0.5214850980568969d, b: 0.6097853166227842d, c: 0.037564705410715216d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.794741433961441d, b: 0.40948478818553324d, c: 0.8349955153630194d),

new NpgsqlTypes.NpgsqlLine(a: 0.6948645889459438d, b: 0.632857065419259d, c: 0.5039544579972753d),

new NpgsqlTypes.NpgsqlLine(a: 0.08944891276585798d, b: 0.913270540398744d, c: 0.6982865099702906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8541822252456289d, b: 0.7910647286519775d, c: 0.2522573522827649d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 128586765,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7662615462562571d, b: 0.41140775410532837d, c: 0.865079853391942d),

new NpgsqlTypes.NpgsqlLine(a: 0.9304815161900817d, b: 0.6441951572457856d, c: 0.4734484158164034d),

new NpgsqlTypes.NpgsqlLine(a: 0.28545320578356514d, b: 0.7953412500579145d, c: 0.13180882594344d),

new NpgsqlTypes.NpgsqlLine(a: 0.0006534434907554676d, b: 0.7291585410038824d, c: 0.07683170668531758d),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 350174520,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23005994787391715d, b: 0.314006898861965d, c: 0.9059890459886075d),

new NpgsqlTypes.NpgsqlLine(a: 0.0034924525333345224d, b: 0.22569705718656508d, c: 0.12293033480738269d),

new NpgsqlTypes.NpgsqlLine(a: 0.13769753447358068d, b: 0.20289930144832358d, c: 0.9141833823361538d),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 528252532,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22785571390952986d, b: 0.47384563164287363d, c: 0.7296472935133859d),

new NpgsqlTypes.NpgsqlLine(a: 0.42847852345883053d, b: 0.05295602193643412d, c: 0.7176332323630693d),

new NpgsqlTypes.NpgsqlLine(a: 0.1313916587576558d, b: 0.44047120647606086d, c: 0.4080020542049758d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlLinelineArray2MI 
                    {
                        Id = 2023967945
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 548719832,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45120792613918626d, b: 0.7981849131464387d, c: 0.6797001557385036d),

new NpgsqlTypes.NpgsqlLine(a: 0.5152860785682492d, b: 0.05860524276063561d, c: 0.31392693425098706d),

new NpgsqlTypes.NpgsqlLine(a: 0.8399321644879826d, b: 0.14127845073157042d, c: 0.04919268640928787d),

new NpgsqlTypes.NpgsqlLine(a: 0.5367279979863265d, b: 0.9037039524330727d, c: 0.5651736207579545d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlLinelineArray2MI 
                    {
                        Id = 632564420
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 569222828,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3541781533895836d, b: 0.8806877333215982d, c: 0.3434395351862555d),

new NpgsqlTypes.NpgsqlLine(a: 0.904182291889472d, b: 0.2725232832902962d, c: 0.11922376175569749d),

new NpgsqlTypes.NpgsqlLine(a: 0.2973949214938665d, b: 0.551548200515303d, c: 0.11510798755200236d),

new NpgsqlTypes.NpgsqlLine(a: 0.6236383027800103d, b: 0.7132402356425214d, c: 0.7946866828405127d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlLinelineArray2MI 
                    {
                        Id = 1120533763
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 617125650,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35787275736319957d, b: 0.702047825867143d, c: 0.965415572167533d),

new NpgsqlTypes.NpgsqlLine(a: 0.31090623461505584d, b: 0.5647177423851781d, c: 0.4846654296503867d),

new NpgsqlTypes.NpgsqlLine(a: 0.3183862992195977d, b: 0.6261458826331173d, c: 0.6907068588712774d),

new NpgsqlTypes.NpgsqlLine(a: 0.6487979418902344d, b: 0.4615179308283234d, c: 0.642127574912425d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9197027266355764d, b: 0.39215058098740485d, c: 0.17261332753094694d),

new NpgsqlTypes.NpgsqlLine(a: 0.11391459246246716d, b: 0.8528811542175645d, c: 0.20274869752530522d),

new NpgsqlTypes.NpgsqlLine(a: 0.36907637605105814d, b: 0.6376511000289307d, c: 0.12998307736849357d),

new NpgsqlTypes.NpgsqlLine(a: 0.9580086581171673d, b: 0.03050170247729178d, c: 0.38029624192446d),

},

                    ModelInner = new NpgsqlLinelineArray2MI 
                    {
                        Id = 1413412459
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 627974170,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15147399565049113d, b: 0.7627100647125816d, c: 0.16010235385722305d),

new NpgsqlTypes.NpgsqlLine(a: 0.9001358065765852d, b: 0.4721890907147458d, c: 0.15927787372271784d),

new NpgsqlTypes.NpgsqlLine(a: 0.7813049144298684d, b: 0.4136335409837938d, c: 0.12660196714031435d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.004236560392559818d, b: 0.39606208609499893d, c: 0.19741769434420997d),

new NpgsqlTypes.NpgsqlLine(a: 0.5953646586031078d, b: 0.6151314480582013d, c: 0.6556527973910132d),

new NpgsqlTypes.NpgsqlLine(a: 0.5407811339876436d, b: 0.9334248245144674d, c: 0.8365874899469636d),

new NpgsqlTypes.NpgsqlLine(a: 0.4764002070454937d, b: 0.16718217080509323d, c: 0.17236129187105342d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 791579102,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3341739254022562d, b: 0.718465753134697d, c: 0.5771634629019262d),

new NpgsqlTypes.NpgsqlLine(a: 0.6322200521292398d, b: 0.8246392866857581d, c: 0.5696079494467468d),

new NpgsqlTypes.NpgsqlLine(a: 0.6545382710133834d, b: 0.4365654599867256d, c: 0.8153585418393168d),

new NpgsqlTypes.NpgsqlLine(a: 0.0910019439659393d, b: 0.7174745892954046d, c: 0.1511089208473413d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlLinelineArray2MI 
                    {
                        Id = 1190383178
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 833599485,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4822973119466689d, b: 0.792513536759573d, c: 0.499633501292873d),

new NpgsqlTypes.NpgsqlLine(a: 0.8918073488512478d, b: 0.42208129985829845d, c: 0.5329638256901381d),

new NpgsqlTypes.NpgsqlLine(a: 0.5188620987187985d, b: 0.1726952436096839d, c: 0.7227459582321649d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15666178016283616d, b: 0.2873368213961791d, c: 0.4420895689102471d),

new NpgsqlTypes.NpgsqlLine(a: 0.4601057867375493d, b: 0.5622721416121373d, c: 0.2999980165807573d),

new NpgsqlTypes.NpgsqlLine(a: 0.8381583831951187d, b: 0.9764919740330239d, c: 0.18152562681640294d),

},

                    ModelInner = new NpgsqlLinelineArray2MI 
                    {
                        Id = 1272632761
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 896715967,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4784147382307862d, b: 0.6552419336185478d, c: 0.920823919677529d),

new NpgsqlTypes.NpgsqlLine(a: 0.742593437228071d, b: 0.6268935209443758d, c: 0.5071732457335109d),

new NpgsqlTypes.NpgsqlLine(a: 0.6253496198816004d, b: 0.5361783003872929d, c: 0.7158348891331027d),

new NpgsqlTypes.NpgsqlLine(a: 0.4294538215627851d, b: 0.8234156672775046d, c: 0.08688024353682888d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlLinelineArray2MI 
                    {
                        Id = 117280179
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 899804594,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1970857537444196d, b: 0.9333242638108382d, c: 0.2997924017071659d),

new NpgsqlTypes.NpgsqlLine(a: 0.6311349404614687d, b: 0.19618574736695826d, c: 0.38842914242231885d),

new NpgsqlTypes.NpgsqlLine(a: 0.8616526286116198d, b: 0.5020108677923993d, c: 0.7507796571723376d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8462722154822349d, b: 0.2140170588076531d, c: 0.1555300802445071d),

new NpgsqlTypes.NpgsqlLine(a: 0.05107346767082066d, b: 0.6007632357415391d, c: 0.11568725974145999d),

new NpgsqlTypes.NpgsqlLine(a: 0.9923537289603477d, b: 0.4950249871115745d, c: 0.02343990901364046d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 964637978,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7665509369596407d, b: 0.32246651386445413d, c: 0.4163237996846909d),

new NpgsqlTypes.NpgsqlLine(a: 0.622867187513811d, b: 0.02481599358005626d, c: 0.6781914372848628d),

new NpgsqlTypes.NpgsqlLine(a: 0.9383962517038102d, b: 0.22799617371669267d, c: 0.11769282658114588d),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 1006841713,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3814391347607825d, b: 0.6500010795000312d, c: 0.5168910912789877d),

new NpgsqlTypes.NpgsqlLine(a: 0.9809725325416359d, b: 0.5965089551877092d, c: 0.9620206915411497d),

new NpgsqlTypes.NpgsqlLine(a: 0.8326177257415529d, b: 0.9726427466112844d, c: 0.44743910631138517d),

new NpgsqlTypes.NpgsqlLine(a: 0.9428905413649304d, b: 0.2742783552238923d, c: 0.20624247958140818d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4156588878635493d, b: 0.9311562710078888d, c: 0.18729745760128813d),

new NpgsqlTypes.NpgsqlLine(a: 0.7838364754377413d, b: 0.2902143764264882d, c: 0.6468999105347263d),

new NpgsqlTypes.NpgsqlLine(a: 0.2807400125401047d, b: 0.4738433713063067d, c: 0.3414032292061351d),

new NpgsqlTypes.NpgsqlLine(a: 0.07976939589399212d, b: 0.6817427263698487d, c: 0.7162950229594492d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 1008288557,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6703103585772012d, b: 0.9414469448287122d, c: 0.32961805156524826d),

new NpgsqlTypes.NpgsqlLine(a: 0.13239408457631574d, b: 0.5134528929025426d, c: 0.5412589816963953d),

new NpgsqlTypes.NpgsqlLine(a: 0.1699098825091695d, b: 0.9194545880639252d, c: 0.7451240040858685d),

new NpgsqlTypes.NpgsqlLine(a: 0.2233903417330374d, b: 0.07771599830861675d, c: 0.5752102020647447d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlLinelineArray2MI 
                    {
                        Id = 723640790
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(94091086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.756130013480001d, b: 0.8070063086186816d, c: 0.5025767314647364d),

new NpgsqlTypes.NpgsqlLine(a: 0.9364656141137178d, b: 0.4282247001937053d, c: 0.659495056495708d),

new NpgsqlTypes.NpgsqlLine(a: 0.2335034105141761d, b: 0.052909961042862275d, c: 0.04122572474287722d),

new NpgsqlTypes.NpgsqlLine(a: 0.5214850980568969d, b: 0.6097853166227842d, c: 0.037564705410715216d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.794741433961441d, b: 0.40948478818553324d, c: 0.8349955153630194d),

new NpgsqlTypes.NpgsqlLine(a: 0.6948645889459438d, b: 0.632857065419259d, c: 0.5039544579972753d),

new NpgsqlTypes.NpgsqlLine(a: 0.08944891276585798d, b: 0.913270540398744d, c: 0.6982865099702906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8541822252456289d, b: 0.7910647286519775d, c: 0.2522573522827649d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(128586765));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7662615462562571d, b: 0.41140775410532837d, c: 0.865079853391942d),

new NpgsqlTypes.NpgsqlLine(a: 0.9304815161900817d, b: 0.6441951572457856d, c: 0.4734484158164034d),

new NpgsqlTypes.NpgsqlLine(a: 0.28545320578356514d, b: 0.7953412500579145d, c: 0.13180882594344d),

new NpgsqlTypes.NpgsqlLine(a: 0.0006534434907554676d, b: 0.7291585410038824d, c: 0.07683170668531758d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(350174520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23005994787391715d, b: 0.314006898861965d, c: 0.9059890459886075d),

new NpgsqlTypes.NpgsqlLine(a: 0.0034924525333345224d, b: 0.22569705718656508d, c: 0.12293033480738269d),

new NpgsqlTypes.NpgsqlLine(a: 0.13769753447358068d, b: 0.20289930144832358d, c: 0.9141833823361538d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(528252532));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22785571390952986d, b: 0.47384563164287363d, c: 0.7296472935133859d),

new NpgsqlTypes.NpgsqlLine(a: 0.42847852345883053d, b: 0.05295602193643412d, c: 0.7176332323630693d),

new NpgsqlTypes.NpgsqlLine(a: 0.1313916587576558d, b: 0.44047120647606086d, c: 0.4080020542049758d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2023967945));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7526118185907706d, b: 0.7217192659741516d, c: 0.10725515353553927d),

new NpgsqlTypes.NpgsqlLine(a: 0.4123399872860949d, b: 0.9887632111198967d, c: 0.3407478138648996d),

new NpgsqlTypes.NpgsqlLine(a: 0.1972888611598902d, b: 0.21209298014251077d, c: 0.998100482656704d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32204440669620105d, b: 0.40425092983702615d, c: 0.6281187397686202d),

new NpgsqlTypes.NpgsqlLine(a: 0.8736370792109995d, b: 0.8257156419424208d, c: 0.24574228768788875d),

new NpgsqlTypes.NpgsqlLine(a: 0.1777372581271598d, b: 0.02795031420098848d, c: 0.6085263716794568d),

new NpgsqlTypes.NpgsqlLine(a: 0.3937718955623397d, b: 0.3857998777014512d, c: 0.16490107858931902d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(548719832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45120792613918626d, b: 0.7981849131464387d, c: 0.6797001557385036d),

new NpgsqlTypes.NpgsqlLine(a: 0.5152860785682492d, b: 0.05860524276063561d, c: 0.31392693425098706d),

new NpgsqlTypes.NpgsqlLine(a: 0.8399321644879826d, b: 0.14127845073157042d, c: 0.04919268640928787d),

new NpgsqlTypes.NpgsqlLine(a: 0.5367279979863265d, b: 0.9037039524330727d, c: 0.5651736207579545d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(632564420));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9871612756422758d, b: 0.7040000628939183d, c: 0.5741990515908977d),

new NpgsqlTypes.NpgsqlLine(a: 0.8939251170158339d, b: 0.591802460616856d, c: 0.8710953712464558d),

new NpgsqlTypes.NpgsqlLine(a: 0.925765879252592d, b: 0.020003653879282934d, c: 0.27174016206463947d),

new NpgsqlTypes.NpgsqlLine(a: 0.40821497810499396d, b: 0.18426353989680566d, c: 0.35762480728827095d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(569222828));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3541781533895836d, b: 0.8806877333215982d, c: 0.3434395351862555d),

new NpgsqlTypes.NpgsqlLine(a: 0.904182291889472d, b: 0.2725232832902962d, c: 0.11922376175569749d),

new NpgsqlTypes.NpgsqlLine(a: 0.2973949214938665d, b: 0.551548200515303d, c: 0.11510798755200236d),

new NpgsqlTypes.NpgsqlLine(a: 0.6236383027800103d, b: 0.7132402356425214d, c: 0.7946866828405127d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1120533763));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7797869567083358d, b: 0.2361739464389747d, c: 0.48164557546500963d),

new NpgsqlTypes.NpgsqlLine(a: 0.9480048066554808d, b: 0.8035492224666504d, c: 0.9832497213764478d),

new NpgsqlTypes.NpgsqlLine(a: 0.9772596541640088d, b: 0.6093516798517065d, c: 0.6052760903401032d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(617125650));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35787275736319957d, b: 0.702047825867143d, c: 0.965415572167533d),

new NpgsqlTypes.NpgsqlLine(a: 0.31090623461505584d, b: 0.5647177423851781d, c: 0.4846654296503867d),

new NpgsqlTypes.NpgsqlLine(a: 0.3183862992195977d, b: 0.6261458826331173d, c: 0.6907068588712774d),

new NpgsqlTypes.NpgsqlLine(a: 0.6487979418902344d, b: 0.4615179308283234d, c: 0.642127574912425d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9197027266355764d, b: 0.39215058098740485d, c: 0.17261332753094694d),

new NpgsqlTypes.NpgsqlLine(a: 0.11391459246246716d, b: 0.8528811542175645d, c: 0.20274869752530522d),

new NpgsqlTypes.NpgsqlLine(a: 0.36907637605105814d, b: 0.6376511000289307d, c: 0.12998307736849357d),

new NpgsqlTypes.NpgsqlLine(a: 0.9580086581171673d, b: 0.03050170247729178d, c: 0.38029624192446d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1413412459));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42503376733197573d, b: 0.763237079678654d, c: 0.09688502535476584d),

new NpgsqlTypes.NpgsqlLine(a: 0.23240822962655505d, b: 0.8459480271218152d, c: 0.08432931494869422d),

new NpgsqlTypes.NpgsqlLine(a: 0.18886663761414113d, b: 0.5079561486308892d, c: 0.9843388801596968d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(627974170));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15147399565049113d, b: 0.7627100647125816d, c: 0.16010235385722305d),

new NpgsqlTypes.NpgsqlLine(a: 0.9001358065765852d, b: 0.4721890907147458d, c: 0.15927787372271784d),

new NpgsqlTypes.NpgsqlLine(a: 0.7813049144298684d, b: 0.4136335409837938d, c: 0.12660196714031435d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.004236560392559818d, b: 0.39606208609499893d, c: 0.19741769434420997d),

new NpgsqlTypes.NpgsqlLine(a: 0.5953646586031078d, b: 0.6151314480582013d, c: 0.6556527973910132d),

new NpgsqlTypes.NpgsqlLine(a: 0.5407811339876436d, b: 0.9334248245144674d, c: 0.8365874899469636d),

new NpgsqlTypes.NpgsqlLine(a: 0.4764002070454937d, b: 0.16718217080509323d, c: 0.17236129187105342d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(791579102));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3341739254022562d, b: 0.718465753134697d, c: 0.5771634629019262d),

new NpgsqlTypes.NpgsqlLine(a: 0.6322200521292398d, b: 0.8246392866857581d, c: 0.5696079494467468d),

new NpgsqlTypes.NpgsqlLine(a: 0.6545382710133834d, b: 0.4365654599867256d, c: 0.8153585418393168d),

new NpgsqlTypes.NpgsqlLine(a: 0.0910019439659393d, b: 0.7174745892954046d, c: 0.1511089208473413d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1190383178));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12466334172066618d, b: 0.11152073168077081d, c: 0.491230984381532d),

new NpgsqlTypes.NpgsqlLine(a: 0.5547266175262346d, b: 0.13792449594977796d, c: 0.7570674004021489d),

new NpgsqlTypes.NpgsqlLine(a: 0.2085058544453703d, b: 0.08290359377194412d, c: 0.77495272781113d),

new NpgsqlTypes.NpgsqlLine(a: 0.49111506712078934d, b: 0.641116986925848d, c: 0.29516341556351666d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07914996961984966d, b: 0.4871418257809952d, c: 0.7513322508300865d),

new NpgsqlTypes.NpgsqlLine(a: 0.9239635289951339d, b: 0.38794777551433746d, c: 0.676783160212782d),

new NpgsqlTypes.NpgsqlLine(a: 0.0955538255878925d, b: 0.01055236041931451d, c: 0.2842563281409253d),

new NpgsqlTypes.NpgsqlLine(a: 0.02927332855673237d, b: 0.6165842674891228d, c: 0.8012173905302888d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(833599485));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4822973119466689d, b: 0.792513536759573d, c: 0.499633501292873d),

new NpgsqlTypes.NpgsqlLine(a: 0.8918073488512478d, b: 0.42208129985829845d, c: 0.5329638256901381d),

new NpgsqlTypes.NpgsqlLine(a: 0.5188620987187985d, b: 0.1726952436096839d, c: 0.7227459582321649d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15666178016283616d, b: 0.2873368213961791d, c: 0.4420895689102471d),

new NpgsqlTypes.NpgsqlLine(a: 0.4601057867375493d, b: 0.5622721416121373d, c: 0.2999980165807573d),

new NpgsqlTypes.NpgsqlLine(a: 0.8381583831951187d, b: 0.9764919740330239d, c: 0.18152562681640294d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1272632761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8378269016529278d, b: 0.6733240332238696d, c: 0.8919506779863193d),

new NpgsqlTypes.NpgsqlLine(a: 0.48570634731194795d, b: 0.1596671151368555d, c: 0.20750860994967846d),

new NpgsqlTypes.NpgsqlLine(a: 0.779653513645174d, b: 0.8586337096501773d, c: 0.1738735269722934d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2675334980310755d, b: 0.5860654638502302d, c: 0.5223481489931099d),

new NpgsqlTypes.NpgsqlLine(a: 0.2908190505712529d, b: 0.027311571062217044d, c: 0.38897855152716554d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590347289639254d, b: 0.6110078502040162d, c: 0.9773066927065011d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(896715967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4784147382307862d, b: 0.6552419336185478d, c: 0.920823919677529d),

new NpgsqlTypes.NpgsqlLine(a: 0.742593437228071d, b: 0.6268935209443758d, c: 0.5071732457335109d),

new NpgsqlTypes.NpgsqlLine(a: 0.6253496198816004d, b: 0.5361783003872929d, c: 0.7158348891331027d),

new NpgsqlTypes.NpgsqlLine(a: 0.4294538215627851d, b: 0.8234156672775046d, c: 0.08688024353682888d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(117280179));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3605977641294892d, b: 0.17811158147680461d, c: 0.9658058071756186d),

new NpgsqlTypes.NpgsqlLine(a: 0.6970256025820155d, b: 0.5444046414962291d, c: 0.46720686007108925d),

new NpgsqlTypes.NpgsqlLine(a: 0.8561050660597573d, b: 0.11353237597432853d, c: 0.56669941414895d),

new NpgsqlTypes.NpgsqlLine(a: 0.7984600619309864d, b: 0.8109151931011057d, c: 0.769305377302455d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0947306689172811d, b: 0.8302577671800684d, c: 0.8970532400118938d),

new NpgsqlTypes.NpgsqlLine(a: 0.2407748752003226d, b: 0.4567310255560061d, c: 0.4526792803927874d),

new NpgsqlTypes.NpgsqlLine(a: 0.04496104252758981d, b: 0.7589917027634498d, c: 0.6770421060059869d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(899804594));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1970857537444196d, b: 0.9333242638108382d, c: 0.2997924017071659d),

new NpgsqlTypes.NpgsqlLine(a: 0.6311349404614687d, b: 0.19618574736695826d, c: 0.38842914242231885d),

new NpgsqlTypes.NpgsqlLine(a: 0.8616526286116198d, b: 0.5020108677923993d, c: 0.7507796571723376d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8462722154822349d, b: 0.2140170588076531d, c: 0.1555300802445071d),

new NpgsqlTypes.NpgsqlLine(a: 0.05107346767082066d, b: 0.6007632357415391d, c: 0.11568725974145999d),

new NpgsqlTypes.NpgsqlLine(a: 0.9923537289603477d, b: 0.4950249871115745d, c: 0.02343990901364046d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(964637978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7665509369596407d, b: 0.32246651386445413d, c: 0.4163237996846909d),

new NpgsqlTypes.NpgsqlLine(a: 0.622867187513811d, b: 0.02481599358005626d, c: 0.6781914372848628d),

new NpgsqlTypes.NpgsqlLine(a: 0.9383962517038102d, b: 0.22799617371669267d, c: 0.11769282658114588d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1006841713));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3814391347607825d, b: 0.6500010795000312d, c: 0.5168910912789877d),

new NpgsqlTypes.NpgsqlLine(a: 0.9809725325416359d, b: 0.5965089551877092d, c: 0.9620206915411497d),

new NpgsqlTypes.NpgsqlLine(a: 0.8326177257415529d, b: 0.9726427466112844d, c: 0.44743910631138517d),

new NpgsqlTypes.NpgsqlLine(a: 0.9428905413649304d, b: 0.2742783552238923d, c: 0.20624247958140818d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4156588878635493d, b: 0.9311562710078888d, c: 0.18729745760128813d),

new NpgsqlTypes.NpgsqlLine(a: 0.7838364754377413d, b: 0.2902143764264882d, c: 0.6468999105347263d),

new NpgsqlTypes.NpgsqlLine(a: 0.2807400125401047d, b: 0.4738433713063067d, c: 0.3414032292061351d),

new NpgsqlTypes.NpgsqlLine(a: 0.07976939589399212d, b: 0.6817427263698487d, c: 0.7162950229594492d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1008288557));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6703103585772012d, b: 0.9414469448287122d, c: 0.32961805156524826d),

new NpgsqlTypes.NpgsqlLine(a: 0.13239408457631574d, b: 0.5134528929025426d, c: 0.5412589816963953d),

new NpgsqlTypes.NpgsqlLine(a: 0.1699098825091695d, b: 0.9194545880639252d, c: 0.7451240040858685d),

new NpgsqlTypes.NpgsqlLine(a: 0.2233903417330374d, b: 0.07771599830861675d, c: 0.5752102020647447d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(723640790));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8545769023218451d, b: 0.24286566112974062d, c: 0.24373271509232275d),

new NpgsqlTypes.NpgsqlLine(a: 0.8731571462637403d, b: 0.9993617334238951d, c: 0.1725755360195571d),

new NpgsqlTypes.NpgsqlLine(a: 0.2467482163165423d, b: 0.7309207508122816d, c: 0.574326589073651d),

new NpgsqlTypes.NpgsqlLine(a: 0.39429370255535745d, b: 0.12918013405283635d, c: 0.37279548432778786d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8697103680615146d, b: 0.4868697197066526d, c: 0.008300202872866591d),

new NpgsqlTypes.NpgsqlLine(a: 0.9268152455195247d, b: 0.9945415027788427d, c: 0.33225561051564245d),

new NpgsqlTypes.NpgsqlLine(a: 0.06541514412119742d, b: 0.29832372565206444d, c: 0.34837671529944225d),

new NpgsqlTypes.NpgsqlLine(a: 0.7703107306167513d, b: 0.39150187650435253d, c: 0.17912768771478083d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                importCollection.Clear();

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 1212970907,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5991478813435879d, b: 0.21696546349723422d, c: 0.7473704822066682d),

new NpgsqlTypes.NpgsqlLine(a: 0.151066097236479d, b: 0.0802844223551269d, c: 0.09162465810768494d),

new NpgsqlTypes.NpgsqlLine(a: 0.8623052986382002d, b: 0.9298840839917386d, c: 0.6660510239194597d),

new NpgsqlTypes.NpgsqlLine(a: 0.9991351159913222d, b: 0.029361445428178645d, c: 0.30760770391653036d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlLinelineArray2MI 
                    {
                        Id = 2140414751
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 1370558129,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9082169806472872d, b: 0.9235120225757552d, c: 0.8994934710072177d),

new NpgsqlTypes.NpgsqlLine(a: 0.12419478532476513d, b: 0.805126203795883d, c: 0.21123699569220133d),

new NpgsqlTypes.NpgsqlLine(a: 0.5518835410640954d, b: 0.3470463651950829d, c: 0.4121461426388031d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlLinelineArray2MI 
                    {
                        Id = 196308953
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 1411554384,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.43292849531653743d, b: 0.10139772092942057d, c: 0.19581477698464556d),

new NpgsqlTypes.NpgsqlLine(a: 0.7747830082073887d, b: 0.7612727046736724d, c: 0.49585407932443326d),

new NpgsqlTypes.NpgsqlLine(a: 0.7534769161594925d, b: 0.21640631521439513d, c: 0.9417215429915208d),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 1423267657,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7028157888188539d, b: 0.4434497177574276d, c: 0.1878584904244096d),

new NpgsqlTypes.NpgsqlLine(a: 0.12779644786129707d, b: 0.6547737034235738d, c: 0.7340324477099678d),

new NpgsqlTypes.NpgsqlLine(a: 0.13473852180731738d, b: 0.7900921279332365d, c: 0.7695417103969711d),

new NpgsqlTypes.NpgsqlLine(a: 0.2618677281295215d, b: 0.24821010444457137d, c: 0.2711393719015588d),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 1610745034,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6382266935775643d, b: 0.398693329671132d, c: 0.7425094436899613d),

new NpgsqlTypes.NpgsqlLine(a: 0.24327741116998813d, b: 0.1635267687203752d, c: 0.628031718062037d),

new NpgsqlTypes.NpgsqlLine(a: 0.38459544322295613d, b: 0.4141132804519537d, c: 0.8511486540491503d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9861241662988156d, b: 0.25399030999510996d, c: 0.2529918964264557d),

new NpgsqlTypes.NpgsqlLine(a: 0.17574090331875702d, b: 0.5215697754670754d, c: 0.49092403723555744d),

new NpgsqlTypes.NpgsqlLine(a: 0.9755215010138426d, b: 0.5836706698542481d, c: 0.8112425273051307d),

},

                    ModelInner = new NpgsqlLinelineArray2MI 
                    {
                        Id = 1525343338
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 1618779845,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588222459861263d, b: 0.8314528851615401d, c: 0.4091425195520225d),

new NpgsqlTypes.NpgsqlLine(a: 0.15497545879234587d, b: 0.42501177297812087d, c: 0.3930386900482442d),

new NpgsqlTypes.NpgsqlLine(a: 0.49932759733861587d, b: 0.27860846401633954d, c: 0.22371479209453393d),

new NpgsqlTypes.NpgsqlLine(a: 0.6744750487770321d, b: 0.5185555306309229d, c: 0.48333909912156325d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6846715107366038d, b: 0.7822398219668835d, c: 0.6995656002724597d),

new NpgsqlTypes.NpgsqlLine(a: 0.34191163697506577d, b: 0.251427920689659d, c: 0.6372400180339429d),

new NpgsqlTypes.NpgsqlLine(a: 0.7615638356664386d, b: 0.38275705185682163d, c: 0.9430695395246483d),

new NpgsqlTypes.NpgsqlLine(a: 0.25861736938688795d, b: 0.2236086093911689d, c: 0.43081968027669826d),

},

                    ModelInner = new NpgsqlLinelineArray2MI 
                    {
                        Id = 111191550
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 1651600176,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16882852097245493d, b: 0.6320810387310721d, c: 0.4943119337666173d),

new NpgsqlTypes.NpgsqlLine(a: 0.1864608664190791d, b: 0.3923939341785333d, c: 0.40778672849944797d),

new NpgsqlTypes.NpgsqlLine(a: 0.21658079009283382d, b: 0.9735580473103661d, c: 0.5313780798893142d),

new NpgsqlTypes.NpgsqlLine(a: 0.608447080933292d, b: 0.9095061095638245d, c: 0.664417030599092d),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 1656686707,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08369873952495288d, b: 0.07788317757867735d, c: 0.284112517861248d),

new NpgsqlTypes.NpgsqlLine(a: 0.617171498263342d, b: 0.5865508373972511d, c: 0.36018099841433293d),

new NpgsqlTypes.NpgsqlLine(a: 0.4798021589910493d, b: 0.5378837702166812d, c: 0.2195325878675365d),

new NpgsqlTypes.NpgsqlLine(a: 0.961753857136392d, b: 0.8919192421134503d, c: 0.16540674234160435d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlLinelineArray2MI 
                    {
                        Id = 1264360862
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 1800975967,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6019711101236188d, b: 0.451502314152629d, c: 0.7567258646896037d),

new NpgsqlTypes.NpgsqlLine(a: 0.20314867633928102d, b: 0.43694052621738755d, c: 0.07972430095228344d),

new NpgsqlTypes.NpgsqlLine(a: 0.38639176328531444d, b: 0.5546727142910798d, c: 0.3595107666863845d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlLinelineArray2MI 
                    {
                        Id = 116492752
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 1858289195,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25032438445726d, b: 0.0917391846373673d, c: 0.34066051809002806d),

new NpgsqlTypes.NpgsqlLine(a: 0.07831144663304057d, b: 0.77591037387439d, c: 0.19759580235224372d),

new NpgsqlTypes.NpgsqlLine(a: 0.3752205191956137d, b: 0.9100313386910368d, c: 0.6525871812195568d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47106408656007914d, b: 0.14257658261320605d, c: 0.47373760961489964d),

new NpgsqlTypes.NpgsqlLine(a: 0.4366806562773925d, b: 0.20146202051894901d, c: 0.3244113712884158d),

new NpgsqlTypes.NpgsqlLine(a: 0.41468311552317627d, b: 0.27557991533085235d, c: 0.7788691278257713d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 1908397739,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36399675452528046d, b: 0.21180965313124933d, c: 0.6232643186817026d),

new NpgsqlTypes.NpgsqlLine(a: 0.8377534917307251d, b: 0.7197248111141329d, c: 0.5638759891270843d),

new NpgsqlTypes.NpgsqlLine(a: 0.9127913721936561d, b: 0.47658260676426356d, c: 0.4401534500107992d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.502181779437056d, b: 0.3652805047459293d, c: 0.32001644451474576d),

new NpgsqlTypes.NpgsqlLine(a: 0.7113651445912559d, b: 0.3869191031273206d, c: 0.7332400621535746d),

new NpgsqlTypes.NpgsqlLine(a: 0.5302147002696467d, b: 0.6514960201183412d, c: 0.8888784836070758d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 1921152006,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3706659351474607d, b: 0.20392121211971403d, c: 0.09026673921559647d),

new NpgsqlTypes.NpgsqlLine(a: 0.3426907809834573d, b: 0.11597889224231583d, c: 0.37580383029156417d),

new NpgsqlTypes.NpgsqlLine(a: 0.9569454063294334d, b: 0.5352074925592666d, c: 0.1505041653825815d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlLinelineArray2MI 
                    {
                        Id = 322154126
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 1931477721,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24029930494024243d, b: 0.6494520983530296d, c: 0.6457904476196421d),

new NpgsqlTypes.NpgsqlLine(a: 0.5413106581652064d, b: 0.65922568011039d, c: 0.023000101756869618d),

new NpgsqlTypes.NpgsqlLine(a: 0.05698461456670889d, b: 0.07946838244893384d, c: 0.023133320459978735d),

new NpgsqlTypes.NpgsqlLine(a: 0.023417572430763367d, b: 0.20022755743974863d, c: 0.9001563624157146d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3818728397283605d, b: 0.24081372003152057d, c: 0.42604600108359325d),

new NpgsqlTypes.NpgsqlLine(a: 0.9919565701428744d, b: 0.9836921588174795d, c: 0.6353618672799166d),

new NpgsqlTypes.NpgsqlLine(a: 0.49779514301225014d, b: 0.9235637976007209d, c: 0.26480996790155775d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 1943853869,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5132420668035784d, b: 0.9613252483783701d, c: 0.9242449431625296d),

new NpgsqlTypes.NpgsqlLine(a: 0.36653456446188004d, b: 0.7359631901409467d, c: 0.27792441954855884d),

new NpgsqlTypes.NpgsqlLine(a: 0.4636783251093567d, b: 0.1186591604974756d, c: 0.39388519565520497d),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray2M
                {
                    Id = 1951774404,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4334255210533513d, b: 0.5785255926410576d, c: 0.9661508534687067d),

new NpgsqlTypes.NpgsqlLine(a: 0.19775236418153797d, b: 0.9365672085879589d, c: 0.1494826860380959d),

new NpgsqlTypes.NpgsqlLine(a: 0.176207462329397d, b: 0.2629253672101627d, c: 0.07007543599573873d),

new NpgsqlTypes.NpgsqlLine(a: 0.12818842182277845d, b: 0.1863366614728862d, c: 0.7134229928630377d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6151166351904711d, b: 0.2498835420322547d, c: 0.9733560033126378d),

new NpgsqlTypes.NpgsqlLine(a: 0.7516653963992566d, b: 0.8871254006140514d, c: 0.9688544000775576d),

new NpgsqlTypes.NpgsqlLine(a: 0.5920030979667459d, b: 0.19764908877922582d, c: 0.5631519149614208d),

},

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(94091086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.756130013480001d, b: 0.8070063086186816d, c: 0.5025767314647364d),

new NpgsqlTypes.NpgsqlLine(a: 0.9364656141137178d, b: 0.4282247001937053d, c: 0.659495056495708d),

new NpgsqlTypes.NpgsqlLine(a: 0.2335034105141761d, b: 0.052909961042862275d, c: 0.04122572474287722d),

new NpgsqlTypes.NpgsqlLine(a: 0.5214850980568969d, b: 0.6097853166227842d, c: 0.037564705410715216d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.794741433961441d, b: 0.40948478818553324d, c: 0.8349955153630194d),

new NpgsqlTypes.NpgsqlLine(a: 0.6948645889459438d, b: 0.632857065419259d, c: 0.5039544579972753d),

new NpgsqlTypes.NpgsqlLine(a: 0.08944891276585798d, b: 0.913270540398744d, c: 0.6982865099702906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8541822252456289d, b: 0.7910647286519775d, c: 0.2522573522827649d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(128586765));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7662615462562571d, b: 0.41140775410532837d, c: 0.865079853391942d),

new NpgsqlTypes.NpgsqlLine(a: 0.9304815161900817d, b: 0.6441951572457856d, c: 0.4734484158164034d),

new NpgsqlTypes.NpgsqlLine(a: 0.28545320578356514d, b: 0.7953412500579145d, c: 0.13180882594344d),

new NpgsqlTypes.NpgsqlLine(a: 0.0006534434907554676d, b: 0.7291585410038824d, c: 0.07683170668531758d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(350174520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23005994787391715d, b: 0.314006898861965d, c: 0.9059890459886075d),

new NpgsqlTypes.NpgsqlLine(a: 0.0034924525333345224d, b: 0.22569705718656508d, c: 0.12293033480738269d),

new NpgsqlTypes.NpgsqlLine(a: 0.13769753447358068d, b: 0.20289930144832358d, c: 0.9141833823361538d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(528252532));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22785571390952986d, b: 0.47384563164287363d, c: 0.7296472935133859d),

new NpgsqlTypes.NpgsqlLine(a: 0.42847852345883053d, b: 0.05295602193643412d, c: 0.7176332323630693d),

new NpgsqlTypes.NpgsqlLine(a: 0.1313916587576558d, b: 0.44047120647606086d, c: 0.4080020542049758d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2023967945));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7526118185907706d, b: 0.7217192659741516d, c: 0.10725515353553927d),

new NpgsqlTypes.NpgsqlLine(a: 0.4123399872860949d, b: 0.9887632111198967d, c: 0.3407478138648996d),

new NpgsqlTypes.NpgsqlLine(a: 0.1972888611598902d, b: 0.21209298014251077d, c: 0.998100482656704d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32204440669620105d, b: 0.40425092983702615d, c: 0.6281187397686202d),

new NpgsqlTypes.NpgsqlLine(a: 0.8736370792109995d, b: 0.8257156419424208d, c: 0.24574228768788875d),

new NpgsqlTypes.NpgsqlLine(a: 0.1777372581271598d, b: 0.02795031420098848d, c: 0.6085263716794568d),

new NpgsqlTypes.NpgsqlLine(a: 0.3937718955623397d, b: 0.3857998777014512d, c: 0.16490107858931902d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(548719832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45120792613918626d, b: 0.7981849131464387d, c: 0.6797001557385036d),

new NpgsqlTypes.NpgsqlLine(a: 0.5152860785682492d, b: 0.05860524276063561d, c: 0.31392693425098706d),

new NpgsqlTypes.NpgsqlLine(a: 0.8399321644879826d, b: 0.14127845073157042d, c: 0.04919268640928787d),

new NpgsqlTypes.NpgsqlLine(a: 0.5367279979863265d, b: 0.9037039524330727d, c: 0.5651736207579545d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(632564420));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9871612756422758d, b: 0.7040000628939183d, c: 0.5741990515908977d),

new NpgsqlTypes.NpgsqlLine(a: 0.8939251170158339d, b: 0.591802460616856d, c: 0.8710953712464558d),

new NpgsqlTypes.NpgsqlLine(a: 0.925765879252592d, b: 0.020003653879282934d, c: 0.27174016206463947d),

new NpgsqlTypes.NpgsqlLine(a: 0.40821497810499396d, b: 0.18426353989680566d, c: 0.35762480728827095d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(569222828));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3541781533895836d, b: 0.8806877333215982d, c: 0.3434395351862555d),

new NpgsqlTypes.NpgsqlLine(a: 0.904182291889472d, b: 0.2725232832902962d, c: 0.11922376175569749d),

new NpgsqlTypes.NpgsqlLine(a: 0.2973949214938665d, b: 0.551548200515303d, c: 0.11510798755200236d),

new NpgsqlTypes.NpgsqlLine(a: 0.6236383027800103d, b: 0.7132402356425214d, c: 0.7946866828405127d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1120533763));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7797869567083358d, b: 0.2361739464389747d, c: 0.48164557546500963d),

new NpgsqlTypes.NpgsqlLine(a: 0.9480048066554808d, b: 0.8035492224666504d, c: 0.9832497213764478d),

new NpgsqlTypes.NpgsqlLine(a: 0.9772596541640088d, b: 0.6093516798517065d, c: 0.6052760903401032d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(617125650));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35787275736319957d, b: 0.702047825867143d, c: 0.965415572167533d),

new NpgsqlTypes.NpgsqlLine(a: 0.31090623461505584d, b: 0.5647177423851781d, c: 0.4846654296503867d),

new NpgsqlTypes.NpgsqlLine(a: 0.3183862992195977d, b: 0.6261458826331173d, c: 0.6907068588712774d),

new NpgsqlTypes.NpgsqlLine(a: 0.6487979418902344d, b: 0.4615179308283234d, c: 0.642127574912425d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9197027266355764d, b: 0.39215058098740485d, c: 0.17261332753094694d),

new NpgsqlTypes.NpgsqlLine(a: 0.11391459246246716d, b: 0.8528811542175645d, c: 0.20274869752530522d),

new NpgsqlTypes.NpgsqlLine(a: 0.36907637605105814d, b: 0.6376511000289307d, c: 0.12998307736849357d),

new NpgsqlTypes.NpgsqlLine(a: 0.9580086581171673d, b: 0.03050170247729178d, c: 0.38029624192446d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1413412459));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42503376733197573d, b: 0.763237079678654d, c: 0.09688502535476584d),

new NpgsqlTypes.NpgsqlLine(a: 0.23240822962655505d, b: 0.8459480271218152d, c: 0.08432931494869422d),

new NpgsqlTypes.NpgsqlLine(a: 0.18886663761414113d, b: 0.5079561486308892d, c: 0.9843388801596968d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(627974170));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15147399565049113d, b: 0.7627100647125816d, c: 0.16010235385722305d),

new NpgsqlTypes.NpgsqlLine(a: 0.9001358065765852d, b: 0.4721890907147458d, c: 0.15927787372271784d),

new NpgsqlTypes.NpgsqlLine(a: 0.7813049144298684d, b: 0.4136335409837938d, c: 0.12660196714031435d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.004236560392559818d, b: 0.39606208609499893d, c: 0.19741769434420997d),

new NpgsqlTypes.NpgsqlLine(a: 0.5953646586031078d, b: 0.6151314480582013d, c: 0.6556527973910132d),

new NpgsqlTypes.NpgsqlLine(a: 0.5407811339876436d, b: 0.9334248245144674d, c: 0.8365874899469636d),

new NpgsqlTypes.NpgsqlLine(a: 0.4764002070454937d, b: 0.16718217080509323d, c: 0.17236129187105342d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(791579102));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3341739254022562d, b: 0.718465753134697d, c: 0.5771634629019262d),

new NpgsqlTypes.NpgsqlLine(a: 0.6322200521292398d, b: 0.8246392866857581d, c: 0.5696079494467468d),

new NpgsqlTypes.NpgsqlLine(a: 0.6545382710133834d, b: 0.4365654599867256d, c: 0.8153585418393168d),

new NpgsqlTypes.NpgsqlLine(a: 0.0910019439659393d, b: 0.7174745892954046d, c: 0.1511089208473413d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1190383178));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12466334172066618d, b: 0.11152073168077081d, c: 0.491230984381532d),

new NpgsqlTypes.NpgsqlLine(a: 0.5547266175262346d, b: 0.13792449594977796d, c: 0.7570674004021489d),

new NpgsqlTypes.NpgsqlLine(a: 0.2085058544453703d, b: 0.08290359377194412d, c: 0.77495272781113d),

new NpgsqlTypes.NpgsqlLine(a: 0.49111506712078934d, b: 0.641116986925848d, c: 0.29516341556351666d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07914996961984966d, b: 0.4871418257809952d, c: 0.7513322508300865d),

new NpgsqlTypes.NpgsqlLine(a: 0.9239635289951339d, b: 0.38794777551433746d, c: 0.676783160212782d),

new NpgsqlTypes.NpgsqlLine(a: 0.0955538255878925d, b: 0.01055236041931451d, c: 0.2842563281409253d),

new NpgsqlTypes.NpgsqlLine(a: 0.02927332855673237d, b: 0.6165842674891228d, c: 0.8012173905302888d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(833599485));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4822973119466689d, b: 0.792513536759573d, c: 0.499633501292873d),

new NpgsqlTypes.NpgsqlLine(a: 0.8918073488512478d, b: 0.42208129985829845d, c: 0.5329638256901381d),

new NpgsqlTypes.NpgsqlLine(a: 0.5188620987187985d, b: 0.1726952436096839d, c: 0.7227459582321649d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15666178016283616d, b: 0.2873368213961791d, c: 0.4420895689102471d),

new NpgsqlTypes.NpgsqlLine(a: 0.4601057867375493d, b: 0.5622721416121373d, c: 0.2999980165807573d),

new NpgsqlTypes.NpgsqlLine(a: 0.8381583831951187d, b: 0.9764919740330239d, c: 0.18152562681640294d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1272632761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8378269016529278d, b: 0.6733240332238696d, c: 0.8919506779863193d),

new NpgsqlTypes.NpgsqlLine(a: 0.48570634731194795d, b: 0.1596671151368555d, c: 0.20750860994967846d),

new NpgsqlTypes.NpgsqlLine(a: 0.779653513645174d, b: 0.8586337096501773d, c: 0.1738735269722934d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2675334980310755d, b: 0.5860654638502302d, c: 0.5223481489931099d),

new NpgsqlTypes.NpgsqlLine(a: 0.2908190505712529d, b: 0.027311571062217044d, c: 0.38897855152716554d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590347289639254d, b: 0.6110078502040162d, c: 0.9773066927065011d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(896715967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4784147382307862d, b: 0.6552419336185478d, c: 0.920823919677529d),

new NpgsqlTypes.NpgsqlLine(a: 0.742593437228071d, b: 0.6268935209443758d, c: 0.5071732457335109d),

new NpgsqlTypes.NpgsqlLine(a: 0.6253496198816004d, b: 0.5361783003872929d, c: 0.7158348891331027d),

new NpgsqlTypes.NpgsqlLine(a: 0.4294538215627851d, b: 0.8234156672775046d, c: 0.08688024353682888d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(117280179));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3605977641294892d, b: 0.17811158147680461d, c: 0.9658058071756186d),

new NpgsqlTypes.NpgsqlLine(a: 0.6970256025820155d, b: 0.5444046414962291d, c: 0.46720686007108925d),

new NpgsqlTypes.NpgsqlLine(a: 0.8561050660597573d, b: 0.11353237597432853d, c: 0.56669941414895d),

new NpgsqlTypes.NpgsqlLine(a: 0.7984600619309864d, b: 0.8109151931011057d, c: 0.769305377302455d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0947306689172811d, b: 0.8302577671800684d, c: 0.8970532400118938d),

new NpgsqlTypes.NpgsqlLine(a: 0.2407748752003226d, b: 0.4567310255560061d, c: 0.4526792803927874d),

new NpgsqlTypes.NpgsqlLine(a: 0.04496104252758981d, b: 0.7589917027634498d, c: 0.6770421060059869d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(899804594));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1970857537444196d, b: 0.9333242638108382d, c: 0.2997924017071659d),

new NpgsqlTypes.NpgsqlLine(a: 0.6311349404614687d, b: 0.19618574736695826d, c: 0.38842914242231885d),

new NpgsqlTypes.NpgsqlLine(a: 0.8616526286116198d, b: 0.5020108677923993d, c: 0.7507796571723376d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8462722154822349d, b: 0.2140170588076531d, c: 0.1555300802445071d),

new NpgsqlTypes.NpgsqlLine(a: 0.05107346767082066d, b: 0.6007632357415391d, c: 0.11568725974145999d),

new NpgsqlTypes.NpgsqlLine(a: 0.9923537289603477d, b: 0.4950249871115745d, c: 0.02343990901364046d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(964637978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7665509369596407d, b: 0.32246651386445413d, c: 0.4163237996846909d),

new NpgsqlTypes.NpgsqlLine(a: 0.622867187513811d, b: 0.02481599358005626d, c: 0.6781914372848628d),

new NpgsqlTypes.NpgsqlLine(a: 0.9383962517038102d, b: 0.22799617371669267d, c: 0.11769282658114588d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1006841713));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3814391347607825d, b: 0.6500010795000312d, c: 0.5168910912789877d),

new NpgsqlTypes.NpgsqlLine(a: 0.9809725325416359d, b: 0.5965089551877092d, c: 0.9620206915411497d),

new NpgsqlTypes.NpgsqlLine(a: 0.8326177257415529d, b: 0.9726427466112844d, c: 0.44743910631138517d),

new NpgsqlTypes.NpgsqlLine(a: 0.9428905413649304d, b: 0.2742783552238923d, c: 0.20624247958140818d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4156588878635493d, b: 0.9311562710078888d, c: 0.18729745760128813d),

new NpgsqlTypes.NpgsqlLine(a: 0.7838364754377413d, b: 0.2902143764264882d, c: 0.6468999105347263d),

new NpgsqlTypes.NpgsqlLine(a: 0.2807400125401047d, b: 0.4738433713063067d, c: 0.3414032292061351d),

new NpgsqlTypes.NpgsqlLine(a: 0.07976939589399212d, b: 0.6817427263698487d, c: 0.7162950229594492d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1008288557));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6703103585772012d, b: 0.9414469448287122d, c: 0.32961805156524826d),

new NpgsqlTypes.NpgsqlLine(a: 0.13239408457631574d, b: 0.5134528929025426d, c: 0.5412589816963953d),

new NpgsqlTypes.NpgsqlLine(a: 0.1699098825091695d, b: 0.9194545880639252d, c: 0.7451240040858685d),

new NpgsqlTypes.NpgsqlLine(a: 0.2233903417330374d, b: 0.07771599830861675d, c: 0.5752102020647447d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(723640790));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8545769023218451d, b: 0.24286566112974062d, c: 0.24373271509232275d),

new NpgsqlTypes.NpgsqlLine(a: 0.8731571462637403d, b: 0.9993617334238951d, c: 0.1725755360195571d),

new NpgsqlTypes.NpgsqlLine(a: 0.2467482163165423d, b: 0.7309207508122816d, c: 0.574326589073651d),

new NpgsqlTypes.NpgsqlLine(a: 0.39429370255535745d, b: 0.12918013405283635d, c: 0.37279548432778786d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8697103680615146d, b: 0.4868697197066526d, c: 0.008300202872866591d),

new NpgsqlTypes.NpgsqlLine(a: 0.9268152455195247d, b: 0.9945415027788427d, c: 0.33225561051564245d),

new NpgsqlTypes.NpgsqlLine(a: 0.06541514412119742d, b: 0.29832372565206444d, c: 0.34837671529944225d),

new NpgsqlTypes.NpgsqlLine(a: 0.7703107306167513d, b: 0.39150187650435253d, c: 0.17912768771478083d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1212970907));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5991478813435879d, b: 0.21696546349723422d, c: 0.7473704822066682d),

new NpgsqlTypes.NpgsqlLine(a: 0.151066097236479d, b: 0.0802844223551269d, c: 0.09162465810768494d),

new NpgsqlTypes.NpgsqlLine(a: 0.8623052986382002d, b: 0.9298840839917386d, c: 0.6660510239194597d),

new NpgsqlTypes.NpgsqlLine(a: 0.9991351159913222d, b: 0.029361445428178645d, c: 0.30760770391653036d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2140414751));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5666355568463651d, b: 0.5532657932652175d, c: 0.043303548850170626d),

new NpgsqlTypes.NpgsqlLine(a: 0.4900959494886681d, b: 0.9349750472343457d, c: 0.4121355471301291d),

new NpgsqlTypes.NpgsqlLine(a: 0.06398838318692368d, b: 0.028285739863693204d, c: 0.8052480125394759d),

new NpgsqlTypes.NpgsqlLine(a: 0.31673961185856914d, b: 0.4141587759463713d, c: 0.1893488396111126d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1370558129));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9082169806472872d, b: 0.9235120225757552d, c: 0.8994934710072177d),

new NpgsqlTypes.NpgsqlLine(a: 0.12419478532476513d, b: 0.805126203795883d, c: 0.21123699569220133d),

new NpgsqlTypes.NpgsqlLine(a: 0.5518835410640954d, b: 0.3470463651950829d, c: 0.4121461426388031d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(196308953));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28578713252269017d, b: 0.8474368218362299d, c: 0.05146566977408318d),

new NpgsqlTypes.NpgsqlLine(a: 0.9109299616024349d, b: 0.5870141058904383d, c: 0.7452912896149598d),

new NpgsqlTypes.NpgsqlLine(a: 0.09671303857190205d, b: 0.22234046410281205d, c: 0.2889776640209598d),

new NpgsqlTypes.NpgsqlLine(a: 0.3594930797393622d, b: 0.1261117062789614d, c: 0.4836691385976134d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1411554384));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.43292849531653743d, b: 0.10139772092942057d, c: 0.19581477698464556d),

new NpgsqlTypes.NpgsqlLine(a: 0.7747830082073887d, b: 0.7612727046736724d, c: 0.49585407932443326d),

new NpgsqlTypes.NpgsqlLine(a: 0.7534769161594925d, b: 0.21640631521439513d, c: 0.9417215429915208d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1423267657));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7028157888188539d, b: 0.4434497177574276d, c: 0.1878584904244096d),

new NpgsqlTypes.NpgsqlLine(a: 0.12779644786129707d, b: 0.6547737034235738d, c: 0.7340324477099678d),

new NpgsqlTypes.NpgsqlLine(a: 0.13473852180731738d, b: 0.7900921279332365d, c: 0.7695417103969711d),

new NpgsqlTypes.NpgsqlLine(a: 0.2618677281295215d, b: 0.24821010444457137d, c: 0.2711393719015588d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1610745034));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6382266935775643d, b: 0.398693329671132d, c: 0.7425094436899613d),

new NpgsqlTypes.NpgsqlLine(a: 0.24327741116998813d, b: 0.1635267687203752d, c: 0.628031718062037d),

new NpgsqlTypes.NpgsqlLine(a: 0.38459544322295613d, b: 0.4141132804519537d, c: 0.8511486540491503d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9861241662988156d, b: 0.25399030999510996d, c: 0.2529918964264557d),

new NpgsqlTypes.NpgsqlLine(a: 0.17574090331875702d, b: 0.5215697754670754d, c: 0.49092403723555744d),

new NpgsqlTypes.NpgsqlLine(a: 0.9755215010138426d, b: 0.5836706698542481d, c: 0.8112425273051307d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1525343338));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5334739519154116d, b: 0.14533927203574382d, c: 0.9972375896646379d),

new NpgsqlTypes.NpgsqlLine(a: 0.5376404385911305d, b: 0.3967355325520928d, c: 0.2690585850054501d),

new NpgsqlTypes.NpgsqlLine(a: 0.7930288640515465d, b: 0.4034090749439643d, c: 0.19977351395319798d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22585130451050572d, b: 0.054454055462575424d, c: 0.3670135684186787d),

new NpgsqlTypes.NpgsqlLine(a: 0.8573417118252535d, b: 0.7290365889192361d, c: 0.15771025911629288d),

new NpgsqlTypes.NpgsqlLine(a: 0.8294206137900973d, b: 0.778292553399524d, c: 0.5844131999897239d),

new NpgsqlTypes.NpgsqlLine(a: 0.8795242286168519d, b: 0.43336364459496624d, c: 0.07939237473054006d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1618779845));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588222459861263d, b: 0.8314528851615401d, c: 0.4091425195520225d),

new NpgsqlTypes.NpgsqlLine(a: 0.15497545879234587d, b: 0.42501177297812087d, c: 0.3930386900482442d),

new NpgsqlTypes.NpgsqlLine(a: 0.49932759733861587d, b: 0.27860846401633954d, c: 0.22371479209453393d),

new NpgsqlTypes.NpgsqlLine(a: 0.6744750487770321d, b: 0.5185555306309229d, c: 0.48333909912156325d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6846715107366038d, b: 0.7822398219668835d, c: 0.6995656002724597d),

new NpgsqlTypes.NpgsqlLine(a: 0.34191163697506577d, b: 0.251427920689659d, c: 0.6372400180339429d),

new NpgsqlTypes.NpgsqlLine(a: 0.7615638356664386d, b: 0.38275705185682163d, c: 0.9430695395246483d),

new NpgsqlTypes.NpgsqlLine(a: 0.25861736938688795d, b: 0.2236086093911689d, c: 0.43081968027669826d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(111191550));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10079392481388938d, b: 0.47419284524344363d, c: 0.46999813598135487d),

new NpgsqlTypes.NpgsqlLine(a: 0.4512330545433114d, b: 0.7685777654216315d, c: 0.761484461621478d),

new NpgsqlTypes.NpgsqlLine(a: 0.7069502335832981d, b: 0.10867536284292001d, c: 0.803973548621565d),

new NpgsqlTypes.NpgsqlLine(a: 0.6710482193897285d, b: 0.3246300803211939d, c: 0.007931088387647223d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1651600176));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16882852097245493d, b: 0.6320810387310721d, c: 0.4943119337666173d),

new NpgsqlTypes.NpgsqlLine(a: 0.1864608664190791d, b: 0.3923939341785333d, c: 0.40778672849944797d),

new NpgsqlTypes.NpgsqlLine(a: 0.21658079009283382d, b: 0.9735580473103661d, c: 0.5313780798893142d),

new NpgsqlTypes.NpgsqlLine(a: 0.608447080933292d, b: 0.9095061095638245d, c: 0.664417030599092d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1656686707));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08369873952495288d, b: 0.07788317757867735d, c: 0.284112517861248d),

new NpgsqlTypes.NpgsqlLine(a: 0.617171498263342d, b: 0.5865508373972511d, c: 0.36018099841433293d),

new NpgsqlTypes.NpgsqlLine(a: 0.4798021589910493d, b: 0.5378837702166812d, c: 0.2195325878675365d),

new NpgsqlTypes.NpgsqlLine(a: 0.961753857136392d, b: 0.8919192421134503d, c: 0.16540674234160435d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1264360862));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3150738269575506d, b: 0.25723902915678687d, c: 0.7085220942560913d),

new NpgsqlTypes.NpgsqlLine(a: 0.10217399526832571d, b: 0.23606907248025677d, c: 0.14832581681823231d),

new NpgsqlTypes.NpgsqlLine(a: 0.38475783269574504d, b: 0.261674953378639d, c: 0.8414017715374641d),

new NpgsqlTypes.NpgsqlLine(a: 0.060969244577031345d, b: 0.7001282741779633d, c: 0.8180532031964253d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1800975967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6019711101236188d, b: 0.451502314152629d, c: 0.7567258646896037d),

new NpgsqlTypes.NpgsqlLine(a: 0.20314867633928102d, b: 0.43694052621738755d, c: 0.07972430095228344d),

new NpgsqlTypes.NpgsqlLine(a: 0.38639176328531444d, b: 0.5546727142910798d, c: 0.3595107666863845d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(116492752));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8534388679989421d, b: 0.17051639981163313d, c: 0.11184373953100968d),

new NpgsqlTypes.NpgsqlLine(a: 0.5545649696933802d, b: 0.6495249060333349d, c: 0.14480165352840013d),

new NpgsqlTypes.NpgsqlLine(a: 0.7068689700072772d, b: 0.10325704725403717d, c: 0.1383403540154834d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.565937691937727d, b: 0.8643068916219007d, c: 0.7899347881580714d),

new NpgsqlTypes.NpgsqlLine(a: 0.5461437063589625d, b: 0.8396992488239946d, c: 0.4549808859483121d),

new NpgsqlTypes.NpgsqlLine(a: 0.11142572920429805d, b: 0.7092154686109046d, c: 0.04531658445440445d),

new NpgsqlTypes.NpgsqlLine(a: 0.8590566964589479d, b: 0.07365357454587718d, c: 0.01783865983951749d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858289195));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25032438445726d, b: 0.0917391846373673d, c: 0.34066051809002806d),

new NpgsqlTypes.NpgsqlLine(a: 0.07831144663304057d, b: 0.77591037387439d, c: 0.19759580235224372d),

new NpgsqlTypes.NpgsqlLine(a: 0.3752205191956137d, b: 0.9100313386910368d, c: 0.6525871812195568d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47106408656007914d, b: 0.14257658261320605d, c: 0.47373760961489964d),

new NpgsqlTypes.NpgsqlLine(a: 0.4366806562773925d, b: 0.20146202051894901d, c: 0.3244113712884158d),

new NpgsqlTypes.NpgsqlLine(a: 0.41468311552317627d, b: 0.27557991533085235d, c: 0.7788691278257713d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1908397739));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36399675452528046d, b: 0.21180965313124933d, c: 0.6232643186817026d),

new NpgsqlTypes.NpgsqlLine(a: 0.8377534917307251d, b: 0.7197248111141329d, c: 0.5638759891270843d),

new NpgsqlTypes.NpgsqlLine(a: 0.9127913721936561d, b: 0.47658260676426356d, c: 0.4401534500107992d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.502181779437056d, b: 0.3652805047459293d, c: 0.32001644451474576d),

new NpgsqlTypes.NpgsqlLine(a: 0.7113651445912559d, b: 0.3869191031273206d, c: 0.7332400621535746d),

new NpgsqlTypes.NpgsqlLine(a: 0.5302147002696467d, b: 0.6514960201183412d, c: 0.8888784836070758d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1921152006));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3706659351474607d, b: 0.20392121211971403d, c: 0.09026673921559647d),

new NpgsqlTypes.NpgsqlLine(a: 0.3426907809834573d, b: 0.11597889224231583d, c: 0.37580383029156417d),

new NpgsqlTypes.NpgsqlLine(a: 0.9569454063294334d, b: 0.5352074925592666d, c: 0.1505041653825815d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(322154126));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17316937563192347d, b: 0.7977878569807266d, c: 0.5061623155222499d),

new NpgsqlTypes.NpgsqlLine(a: 0.39020299771548206d, b: 0.46872469438895703d, c: 0.1947250961658502d),

new NpgsqlTypes.NpgsqlLine(a: 0.9460666899443665d, b: 0.40873002207057996d, c: 0.5383135596603867d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931477721));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24029930494024243d, b: 0.6494520983530296d, c: 0.6457904476196421d),

new NpgsqlTypes.NpgsqlLine(a: 0.5413106581652064d, b: 0.65922568011039d, c: 0.023000101756869618d),

new NpgsqlTypes.NpgsqlLine(a: 0.05698461456670889d, b: 0.07946838244893384d, c: 0.023133320459978735d),

new NpgsqlTypes.NpgsqlLine(a: 0.023417572430763367d, b: 0.20022755743974863d, c: 0.9001563624157146d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3818728397283605d, b: 0.24081372003152057d, c: 0.42604600108359325d),

new NpgsqlTypes.NpgsqlLine(a: 0.9919565701428744d, b: 0.9836921588174795d, c: 0.6353618672799166d),

new NpgsqlTypes.NpgsqlLine(a: 0.49779514301225014d, b: 0.9235637976007209d, c: 0.26480996790155775d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943853869));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5132420668035784d, b: 0.9613252483783701d, c: 0.9242449431625296d),

new NpgsqlTypes.NpgsqlLine(a: 0.36653456446188004d, b: 0.7359631901409467d, c: 0.27792441954855884d),

new NpgsqlTypes.NpgsqlLine(a: 0.4636783251093567d, b: 0.1186591604974756d, c: 0.39388519565520497d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1951774404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4334255210533513d, b: 0.5785255926410576d, c: 0.9661508534687067d),

new NpgsqlTypes.NpgsqlLine(a: 0.19775236418153797d, b: 0.9365672085879589d, c: 0.1494826860380959d),

new NpgsqlTypes.NpgsqlLine(a: 0.176207462329397d, b: 0.2629253672101627d, c: 0.07007543599573873d),

new NpgsqlTypes.NpgsqlLine(a: 0.12818842182277845d, b: 0.1863366614728862d, c: 0.7134229928630377d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6151166351904711d, b: 0.2498835420322547d, c: 0.9733560033126378d),

new NpgsqlTypes.NpgsqlLine(a: 0.7516653963992566d, b: 0.8871254006140514d, c: 0.9688544000775576d),

new NpgsqlTypes.NpgsqlLine(a: 0.5920030979667459d, b: 0.19764908877922582d, c: 0.5631519149614208d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(NpgsqlLinelineArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,NpgsqlLinelineArray2M>(30);

                expected.Add(
                    94091086,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 94091086,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.756130013480001d, b: 0.8070063086186816d, c: 0.5025767314647364d),

new NpgsqlTypes.NpgsqlLine(a: 0.9364656141137178d, b: 0.4282247001937053d, c: 0.659495056495708d),

new NpgsqlTypes.NpgsqlLine(a: 0.2335034105141761d, b: 0.052909961042862275d, c: 0.04122572474287722d),

new NpgsqlTypes.NpgsqlLine(a: 0.5214850980568969d, b: 0.6097853166227842d, c: 0.037564705410715216d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.794741433961441d, b: 0.40948478818553324d, c: 0.8349955153630194d),

new NpgsqlTypes.NpgsqlLine(a: 0.6948645889459438d, b: 0.632857065419259d, c: 0.5039544579972753d),

new NpgsqlTypes.NpgsqlLine(a: 0.08944891276585798d, b: 0.913270540398744d, c: 0.6982865099702906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8541822252456289d, b: 0.7910647286519775d, c: 0.2522573522827649d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    128586765,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 128586765,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7662615462562571d, b: 0.41140775410532837d, c: 0.865079853391942d),

new NpgsqlTypes.NpgsqlLine(a: 0.9304815161900817d, b: 0.6441951572457856d, c: 0.4734484158164034d),

new NpgsqlTypes.NpgsqlLine(a: 0.28545320578356514d, b: 0.7953412500579145d, c: 0.13180882594344d),

new NpgsqlTypes.NpgsqlLine(a: 0.0006534434907554676d, b: 0.7291585410038824d, c: 0.07683170668531758d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    350174520,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 350174520,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23005994787391715d, b: 0.314006898861965d, c: 0.9059890459886075d),

new NpgsqlTypes.NpgsqlLine(a: 0.0034924525333345224d, b: 0.22569705718656508d, c: 0.12293033480738269d),

new NpgsqlTypes.NpgsqlLine(a: 0.13769753447358068d, b: 0.20289930144832358d, c: 0.9141833823361538d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    528252532,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 528252532,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22785571390952986d, b: 0.47384563164287363d, c: 0.7296472935133859d),

new NpgsqlTypes.NpgsqlLine(a: 0.42847852345883053d, b: 0.05295602193643412d, c: 0.7176332323630693d),

new NpgsqlTypes.NpgsqlLine(a: 0.1313916587576558d, b: 0.44047120647606086d, c: 0.4080020542049758d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 2023967945,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7526118185907706d, b: 0.7217192659741516d, c: 0.10725515353553927d),

new NpgsqlTypes.NpgsqlLine(a: 0.4123399872860949d, b: 0.9887632111198967d, c: 0.3407478138648996d),

new NpgsqlTypes.NpgsqlLine(a: 0.1972888611598902d, b: 0.21209298014251077d, c: 0.998100482656704d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32204440669620105d, b: 0.40425092983702615d, c: 0.6281187397686202d),

new NpgsqlTypes.NpgsqlLine(a: 0.8736370792109995d, b: 0.8257156419424208d, c: 0.24574228768788875d),

new NpgsqlTypes.NpgsqlLine(a: 0.1777372581271598d, b: 0.02795031420098848d, c: 0.6085263716794568d),

new NpgsqlTypes.NpgsqlLine(a: 0.3937718955623397d, b: 0.3857998777014512d, c: 0.16490107858931902d),

}
                        }

                    }
                );

                expected.Add(
                    548719832,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 548719832,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45120792613918626d, b: 0.7981849131464387d, c: 0.6797001557385036d),

new NpgsqlTypes.NpgsqlLine(a: 0.5152860785682492d, b: 0.05860524276063561d, c: 0.31392693425098706d),

new NpgsqlTypes.NpgsqlLine(a: 0.8399321644879826d, b: 0.14127845073157042d, c: 0.04919268640928787d),

new NpgsqlTypes.NpgsqlLine(a: 0.5367279979863265d, b: 0.9037039524330727d, c: 0.5651736207579545d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 632564420,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9871612756422758d, b: 0.7040000628939183d, c: 0.5741990515908977d),

new NpgsqlTypes.NpgsqlLine(a: 0.8939251170158339d, b: 0.591802460616856d, c: 0.8710953712464558d),

new NpgsqlTypes.NpgsqlLine(a: 0.925765879252592d, b: 0.020003653879282934d, c: 0.27174016206463947d),

new NpgsqlTypes.NpgsqlLine(a: 0.40821497810499396d, b: 0.18426353989680566d, c: 0.35762480728827095d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    569222828,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 569222828,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3541781533895836d, b: 0.8806877333215982d, c: 0.3434395351862555d),

new NpgsqlTypes.NpgsqlLine(a: 0.904182291889472d, b: 0.2725232832902962d, c: 0.11922376175569749d),

new NpgsqlTypes.NpgsqlLine(a: 0.2973949214938665d, b: 0.551548200515303d, c: 0.11510798755200236d),

new NpgsqlTypes.NpgsqlLine(a: 0.6236383027800103d, b: 0.7132402356425214d, c: 0.7946866828405127d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 1120533763,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7797869567083358d, b: 0.2361739464389747d, c: 0.48164557546500963d),

new NpgsqlTypes.NpgsqlLine(a: 0.9480048066554808d, b: 0.8035492224666504d, c: 0.9832497213764478d),

new NpgsqlTypes.NpgsqlLine(a: 0.9772596541640088d, b: 0.6093516798517065d, c: 0.6052760903401032d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    617125650,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 617125650,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35787275736319957d, b: 0.702047825867143d, c: 0.965415572167533d),

new NpgsqlTypes.NpgsqlLine(a: 0.31090623461505584d, b: 0.5647177423851781d, c: 0.4846654296503867d),

new NpgsqlTypes.NpgsqlLine(a: 0.3183862992195977d, b: 0.6261458826331173d, c: 0.6907068588712774d),

new NpgsqlTypes.NpgsqlLine(a: 0.6487979418902344d, b: 0.4615179308283234d, c: 0.642127574912425d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9197027266355764d, b: 0.39215058098740485d, c: 0.17261332753094694d),

new NpgsqlTypes.NpgsqlLine(a: 0.11391459246246716d, b: 0.8528811542175645d, c: 0.20274869752530522d),

new NpgsqlTypes.NpgsqlLine(a: 0.36907637605105814d, b: 0.6376511000289307d, c: 0.12998307736849357d),

new NpgsqlTypes.NpgsqlLine(a: 0.9580086581171673d, b: 0.03050170247729178d, c: 0.38029624192446d),

},

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 1413412459,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42503376733197573d, b: 0.763237079678654d, c: 0.09688502535476584d),

new NpgsqlTypes.NpgsqlLine(a: 0.23240822962655505d, b: 0.8459480271218152d, c: 0.08432931494869422d),

new NpgsqlTypes.NpgsqlLine(a: 0.18886663761414113d, b: 0.5079561486308892d, c: 0.9843388801596968d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    627974170,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 627974170,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15147399565049113d, b: 0.7627100647125816d, c: 0.16010235385722305d),

new NpgsqlTypes.NpgsqlLine(a: 0.9001358065765852d, b: 0.4721890907147458d, c: 0.15927787372271784d),

new NpgsqlTypes.NpgsqlLine(a: 0.7813049144298684d, b: 0.4136335409837938d, c: 0.12660196714031435d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.004236560392559818d, b: 0.39606208609499893d, c: 0.19741769434420997d),

new NpgsqlTypes.NpgsqlLine(a: 0.5953646586031078d, b: 0.6151314480582013d, c: 0.6556527973910132d),

new NpgsqlTypes.NpgsqlLine(a: 0.5407811339876436d, b: 0.9334248245144674d, c: 0.8365874899469636d),

new NpgsqlTypes.NpgsqlLine(a: 0.4764002070454937d, b: 0.16718217080509323d, c: 0.17236129187105342d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    791579102,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 791579102,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3341739254022562d, b: 0.718465753134697d, c: 0.5771634629019262d),

new NpgsqlTypes.NpgsqlLine(a: 0.6322200521292398d, b: 0.8246392866857581d, c: 0.5696079494467468d),

new NpgsqlTypes.NpgsqlLine(a: 0.6545382710133834d, b: 0.4365654599867256d, c: 0.8153585418393168d),

new NpgsqlTypes.NpgsqlLine(a: 0.0910019439659393d, b: 0.7174745892954046d, c: 0.1511089208473413d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 1190383178,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12466334172066618d, b: 0.11152073168077081d, c: 0.491230984381532d),

new NpgsqlTypes.NpgsqlLine(a: 0.5547266175262346d, b: 0.13792449594977796d, c: 0.7570674004021489d),

new NpgsqlTypes.NpgsqlLine(a: 0.2085058544453703d, b: 0.08290359377194412d, c: 0.77495272781113d),

new NpgsqlTypes.NpgsqlLine(a: 0.49111506712078934d, b: 0.641116986925848d, c: 0.29516341556351666d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07914996961984966d, b: 0.4871418257809952d, c: 0.7513322508300865d),

new NpgsqlTypes.NpgsqlLine(a: 0.9239635289951339d, b: 0.38794777551433746d, c: 0.676783160212782d),

new NpgsqlTypes.NpgsqlLine(a: 0.0955538255878925d, b: 0.01055236041931451d, c: 0.2842563281409253d),

new NpgsqlTypes.NpgsqlLine(a: 0.02927332855673237d, b: 0.6165842674891228d, c: 0.8012173905302888d),

}
                        }

                    }
                );

                expected.Add(
                    833599485,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 833599485,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4822973119466689d, b: 0.792513536759573d, c: 0.499633501292873d),

new NpgsqlTypes.NpgsqlLine(a: 0.8918073488512478d, b: 0.42208129985829845d, c: 0.5329638256901381d),

new NpgsqlTypes.NpgsqlLine(a: 0.5188620987187985d, b: 0.1726952436096839d, c: 0.7227459582321649d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15666178016283616d, b: 0.2873368213961791d, c: 0.4420895689102471d),

new NpgsqlTypes.NpgsqlLine(a: 0.4601057867375493d, b: 0.5622721416121373d, c: 0.2999980165807573d),

new NpgsqlTypes.NpgsqlLine(a: 0.8381583831951187d, b: 0.9764919740330239d, c: 0.18152562681640294d),

},

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 1272632761,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8378269016529278d, b: 0.6733240332238696d, c: 0.8919506779863193d),

new NpgsqlTypes.NpgsqlLine(a: 0.48570634731194795d, b: 0.1596671151368555d, c: 0.20750860994967846d),

new NpgsqlTypes.NpgsqlLine(a: 0.779653513645174d, b: 0.8586337096501773d, c: 0.1738735269722934d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2675334980310755d, b: 0.5860654638502302d, c: 0.5223481489931099d),

new NpgsqlTypes.NpgsqlLine(a: 0.2908190505712529d, b: 0.027311571062217044d, c: 0.38897855152716554d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590347289639254d, b: 0.6110078502040162d, c: 0.9773066927065011d),

}
                        }

                    }
                );

                expected.Add(
                    896715967,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 896715967,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4784147382307862d, b: 0.6552419336185478d, c: 0.920823919677529d),

new NpgsqlTypes.NpgsqlLine(a: 0.742593437228071d, b: 0.6268935209443758d, c: 0.5071732457335109d),

new NpgsqlTypes.NpgsqlLine(a: 0.6253496198816004d, b: 0.5361783003872929d, c: 0.7158348891331027d),

new NpgsqlTypes.NpgsqlLine(a: 0.4294538215627851d, b: 0.8234156672775046d, c: 0.08688024353682888d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 117280179,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3605977641294892d, b: 0.17811158147680461d, c: 0.9658058071756186d),

new NpgsqlTypes.NpgsqlLine(a: 0.6970256025820155d, b: 0.5444046414962291d, c: 0.46720686007108925d),

new NpgsqlTypes.NpgsqlLine(a: 0.8561050660597573d, b: 0.11353237597432853d, c: 0.56669941414895d),

new NpgsqlTypes.NpgsqlLine(a: 0.7984600619309864d, b: 0.8109151931011057d, c: 0.769305377302455d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0947306689172811d, b: 0.8302577671800684d, c: 0.8970532400118938d),

new NpgsqlTypes.NpgsqlLine(a: 0.2407748752003226d, b: 0.4567310255560061d, c: 0.4526792803927874d),

new NpgsqlTypes.NpgsqlLine(a: 0.04496104252758981d, b: 0.7589917027634498d, c: 0.6770421060059869d),

}
                        }

                    }
                );

                expected.Add(
                    899804594,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 899804594,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1970857537444196d, b: 0.9333242638108382d, c: 0.2997924017071659d),

new NpgsqlTypes.NpgsqlLine(a: 0.6311349404614687d, b: 0.19618574736695826d, c: 0.38842914242231885d),

new NpgsqlTypes.NpgsqlLine(a: 0.8616526286116198d, b: 0.5020108677923993d, c: 0.7507796571723376d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8462722154822349d, b: 0.2140170588076531d, c: 0.1555300802445071d),

new NpgsqlTypes.NpgsqlLine(a: 0.05107346767082066d, b: 0.6007632357415391d, c: 0.11568725974145999d),

new NpgsqlTypes.NpgsqlLine(a: 0.9923537289603477d, b: 0.4950249871115745d, c: 0.02343990901364046d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    964637978,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 964637978,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7665509369596407d, b: 0.32246651386445413d, c: 0.4163237996846909d),

new NpgsqlTypes.NpgsqlLine(a: 0.622867187513811d, b: 0.02481599358005626d, c: 0.6781914372848628d),

new NpgsqlTypes.NpgsqlLine(a: 0.9383962517038102d, b: 0.22799617371669267d, c: 0.11769282658114588d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1006841713,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1006841713,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3814391347607825d, b: 0.6500010795000312d, c: 0.5168910912789877d),

new NpgsqlTypes.NpgsqlLine(a: 0.9809725325416359d, b: 0.5965089551877092d, c: 0.9620206915411497d),

new NpgsqlTypes.NpgsqlLine(a: 0.8326177257415529d, b: 0.9726427466112844d, c: 0.44743910631138517d),

new NpgsqlTypes.NpgsqlLine(a: 0.9428905413649304d, b: 0.2742783552238923d, c: 0.20624247958140818d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4156588878635493d, b: 0.9311562710078888d, c: 0.18729745760128813d),

new NpgsqlTypes.NpgsqlLine(a: 0.7838364754377413d, b: 0.2902143764264882d, c: 0.6468999105347263d),

new NpgsqlTypes.NpgsqlLine(a: 0.2807400125401047d, b: 0.4738433713063067d, c: 0.3414032292061351d),

new NpgsqlTypes.NpgsqlLine(a: 0.07976939589399212d, b: 0.6817427263698487d, c: 0.7162950229594492d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1008288557,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1008288557,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6703103585772012d, b: 0.9414469448287122d, c: 0.32961805156524826d),

new NpgsqlTypes.NpgsqlLine(a: 0.13239408457631574d, b: 0.5134528929025426d, c: 0.5412589816963953d),

new NpgsqlTypes.NpgsqlLine(a: 0.1699098825091695d, b: 0.9194545880639252d, c: 0.7451240040858685d),

new NpgsqlTypes.NpgsqlLine(a: 0.2233903417330374d, b: 0.07771599830861675d, c: 0.5752102020647447d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 723640790,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8545769023218451d, b: 0.24286566112974062d, c: 0.24373271509232275d),

new NpgsqlTypes.NpgsqlLine(a: 0.8731571462637403d, b: 0.9993617334238951d, c: 0.1725755360195571d),

new NpgsqlTypes.NpgsqlLine(a: 0.2467482163165423d, b: 0.7309207508122816d, c: 0.574326589073651d),

new NpgsqlTypes.NpgsqlLine(a: 0.39429370255535745d, b: 0.12918013405283635d, c: 0.37279548432778786d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8697103680615146d, b: 0.4868697197066526d, c: 0.008300202872866591d),

new NpgsqlTypes.NpgsqlLine(a: 0.9268152455195247d, b: 0.9945415027788427d, c: 0.33225561051564245d),

new NpgsqlTypes.NpgsqlLine(a: 0.06541514412119742d, b: 0.29832372565206444d, c: 0.34837671529944225d),

new NpgsqlTypes.NpgsqlLine(a: 0.7703107306167513d, b: 0.39150187650435253d, c: 0.17912768771478083d),

}
                        }

                    }
                );

                expected.Add(
                    1212970907,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1212970907,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5991478813435879d, b: 0.21696546349723422d, c: 0.7473704822066682d),

new NpgsqlTypes.NpgsqlLine(a: 0.151066097236479d, b: 0.0802844223551269d, c: 0.09162465810768494d),

new NpgsqlTypes.NpgsqlLine(a: 0.8623052986382002d, b: 0.9298840839917386d, c: 0.6660510239194597d),

new NpgsqlTypes.NpgsqlLine(a: 0.9991351159913222d, b: 0.029361445428178645d, c: 0.30760770391653036d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 2140414751,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5666355568463651d, b: 0.5532657932652175d, c: 0.043303548850170626d),

new NpgsqlTypes.NpgsqlLine(a: 0.4900959494886681d, b: 0.9349750472343457d, c: 0.4121355471301291d),

new NpgsqlTypes.NpgsqlLine(a: 0.06398838318692368d, b: 0.028285739863693204d, c: 0.8052480125394759d),

new NpgsqlTypes.NpgsqlLine(a: 0.31673961185856914d, b: 0.4141587759463713d, c: 0.1893488396111126d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1370558129,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1370558129,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9082169806472872d, b: 0.9235120225757552d, c: 0.8994934710072177d),

new NpgsqlTypes.NpgsqlLine(a: 0.12419478532476513d, b: 0.805126203795883d, c: 0.21123699569220133d),

new NpgsqlTypes.NpgsqlLine(a: 0.5518835410640954d, b: 0.3470463651950829d, c: 0.4121461426388031d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 196308953,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28578713252269017d, b: 0.8474368218362299d, c: 0.05146566977408318d),

new NpgsqlTypes.NpgsqlLine(a: 0.9109299616024349d, b: 0.5870141058904383d, c: 0.7452912896149598d),

new NpgsqlTypes.NpgsqlLine(a: 0.09671303857190205d, b: 0.22234046410281205d, c: 0.2889776640209598d),

new NpgsqlTypes.NpgsqlLine(a: 0.3594930797393622d, b: 0.1261117062789614d, c: 0.4836691385976134d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1411554384,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1411554384,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.43292849531653743d, b: 0.10139772092942057d, c: 0.19581477698464556d),

new NpgsqlTypes.NpgsqlLine(a: 0.7747830082073887d, b: 0.7612727046736724d, c: 0.49585407932443326d),

new NpgsqlTypes.NpgsqlLine(a: 0.7534769161594925d, b: 0.21640631521439513d, c: 0.9417215429915208d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1423267657,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1423267657,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7028157888188539d, b: 0.4434497177574276d, c: 0.1878584904244096d),

new NpgsqlTypes.NpgsqlLine(a: 0.12779644786129707d, b: 0.6547737034235738d, c: 0.7340324477099678d),

new NpgsqlTypes.NpgsqlLine(a: 0.13473852180731738d, b: 0.7900921279332365d, c: 0.7695417103969711d),

new NpgsqlTypes.NpgsqlLine(a: 0.2618677281295215d, b: 0.24821010444457137d, c: 0.2711393719015588d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1610745034,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1610745034,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6382266935775643d, b: 0.398693329671132d, c: 0.7425094436899613d),

new NpgsqlTypes.NpgsqlLine(a: 0.24327741116998813d, b: 0.1635267687203752d, c: 0.628031718062037d),

new NpgsqlTypes.NpgsqlLine(a: 0.38459544322295613d, b: 0.4141132804519537d, c: 0.8511486540491503d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9861241662988156d, b: 0.25399030999510996d, c: 0.2529918964264557d),

new NpgsqlTypes.NpgsqlLine(a: 0.17574090331875702d, b: 0.5215697754670754d, c: 0.49092403723555744d),

new NpgsqlTypes.NpgsqlLine(a: 0.9755215010138426d, b: 0.5836706698542481d, c: 0.8112425273051307d),

},

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 1525343338,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5334739519154116d, b: 0.14533927203574382d, c: 0.9972375896646379d),

new NpgsqlTypes.NpgsqlLine(a: 0.5376404385911305d, b: 0.3967355325520928d, c: 0.2690585850054501d),

new NpgsqlTypes.NpgsqlLine(a: 0.7930288640515465d, b: 0.4034090749439643d, c: 0.19977351395319798d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22585130451050572d, b: 0.054454055462575424d, c: 0.3670135684186787d),

new NpgsqlTypes.NpgsqlLine(a: 0.8573417118252535d, b: 0.7290365889192361d, c: 0.15771025911629288d),

new NpgsqlTypes.NpgsqlLine(a: 0.8294206137900973d, b: 0.778292553399524d, c: 0.5844131999897239d),

new NpgsqlTypes.NpgsqlLine(a: 0.8795242286168519d, b: 0.43336364459496624d, c: 0.07939237473054006d),

}
                        }

                    }
                );

                expected.Add(
                    1618779845,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1618779845,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588222459861263d, b: 0.8314528851615401d, c: 0.4091425195520225d),

new NpgsqlTypes.NpgsqlLine(a: 0.15497545879234587d, b: 0.42501177297812087d, c: 0.3930386900482442d),

new NpgsqlTypes.NpgsqlLine(a: 0.49932759733861587d, b: 0.27860846401633954d, c: 0.22371479209453393d),

new NpgsqlTypes.NpgsqlLine(a: 0.6744750487770321d, b: 0.5185555306309229d, c: 0.48333909912156325d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6846715107366038d, b: 0.7822398219668835d, c: 0.6995656002724597d),

new NpgsqlTypes.NpgsqlLine(a: 0.34191163697506577d, b: 0.251427920689659d, c: 0.6372400180339429d),

new NpgsqlTypes.NpgsqlLine(a: 0.7615638356664386d, b: 0.38275705185682163d, c: 0.9430695395246483d),

new NpgsqlTypes.NpgsqlLine(a: 0.25861736938688795d, b: 0.2236086093911689d, c: 0.43081968027669826d),

},

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 111191550,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10079392481388938d, b: 0.47419284524344363d, c: 0.46999813598135487d),

new NpgsqlTypes.NpgsqlLine(a: 0.4512330545433114d, b: 0.7685777654216315d, c: 0.761484461621478d),

new NpgsqlTypes.NpgsqlLine(a: 0.7069502335832981d, b: 0.10867536284292001d, c: 0.803973548621565d),

new NpgsqlTypes.NpgsqlLine(a: 0.6710482193897285d, b: 0.3246300803211939d, c: 0.007931088387647223d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1651600176,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1651600176,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16882852097245493d, b: 0.6320810387310721d, c: 0.4943119337666173d),

new NpgsqlTypes.NpgsqlLine(a: 0.1864608664190791d, b: 0.3923939341785333d, c: 0.40778672849944797d),

new NpgsqlTypes.NpgsqlLine(a: 0.21658079009283382d, b: 0.9735580473103661d, c: 0.5313780798893142d),

new NpgsqlTypes.NpgsqlLine(a: 0.608447080933292d, b: 0.9095061095638245d, c: 0.664417030599092d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1656686707,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1656686707,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08369873952495288d, b: 0.07788317757867735d, c: 0.284112517861248d),

new NpgsqlTypes.NpgsqlLine(a: 0.617171498263342d, b: 0.5865508373972511d, c: 0.36018099841433293d),

new NpgsqlTypes.NpgsqlLine(a: 0.4798021589910493d, b: 0.5378837702166812d, c: 0.2195325878675365d),

new NpgsqlTypes.NpgsqlLine(a: 0.961753857136392d, b: 0.8919192421134503d, c: 0.16540674234160435d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 1264360862,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3150738269575506d, b: 0.25723902915678687d, c: 0.7085220942560913d),

new NpgsqlTypes.NpgsqlLine(a: 0.10217399526832571d, b: 0.23606907248025677d, c: 0.14832581681823231d),

new NpgsqlTypes.NpgsqlLine(a: 0.38475783269574504d, b: 0.261674953378639d, c: 0.8414017715374641d),

new NpgsqlTypes.NpgsqlLine(a: 0.060969244577031345d, b: 0.7001282741779633d, c: 0.8180532031964253d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1800975967,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1800975967,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6019711101236188d, b: 0.451502314152629d, c: 0.7567258646896037d),

new NpgsqlTypes.NpgsqlLine(a: 0.20314867633928102d, b: 0.43694052621738755d, c: 0.07972430095228344d),

new NpgsqlTypes.NpgsqlLine(a: 0.38639176328531444d, b: 0.5546727142910798d, c: 0.3595107666863845d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 116492752,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8534388679989421d, b: 0.17051639981163313d, c: 0.11184373953100968d),

new NpgsqlTypes.NpgsqlLine(a: 0.5545649696933802d, b: 0.6495249060333349d, c: 0.14480165352840013d),

new NpgsqlTypes.NpgsqlLine(a: 0.7068689700072772d, b: 0.10325704725403717d, c: 0.1383403540154834d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.565937691937727d, b: 0.8643068916219007d, c: 0.7899347881580714d),

new NpgsqlTypes.NpgsqlLine(a: 0.5461437063589625d, b: 0.8396992488239946d, c: 0.4549808859483121d),

new NpgsqlTypes.NpgsqlLine(a: 0.11142572920429805d, b: 0.7092154686109046d, c: 0.04531658445440445d),

new NpgsqlTypes.NpgsqlLine(a: 0.8590566964589479d, b: 0.07365357454587718d, c: 0.01783865983951749d),

}
                        }

                    }
                );

                expected.Add(
                    1858289195,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1858289195,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25032438445726d, b: 0.0917391846373673d, c: 0.34066051809002806d),

new NpgsqlTypes.NpgsqlLine(a: 0.07831144663304057d, b: 0.77591037387439d, c: 0.19759580235224372d),

new NpgsqlTypes.NpgsqlLine(a: 0.3752205191956137d, b: 0.9100313386910368d, c: 0.6525871812195568d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47106408656007914d, b: 0.14257658261320605d, c: 0.47373760961489964d),

new NpgsqlTypes.NpgsqlLine(a: 0.4366806562773925d, b: 0.20146202051894901d, c: 0.3244113712884158d),

new NpgsqlTypes.NpgsqlLine(a: 0.41468311552317627d, b: 0.27557991533085235d, c: 0.7788691278257713d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1908397739,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1908397739,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36399675452528046d, b: 0.21180965313124933d, c: 0.6232643186817026d),

new NpgsqlTypes.NpgsqlLine(a: 0.8377534917307251d, b: 0.7197248111141329d, c: 0.5638759891270843d),

new NpgsqlTypes.NpgsqlLine(a: 0.9127913721936561d, b: 0.47658260676426356d, c: 0.4401534500107992d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.502181779437056d, b: 0.3652805047459293d, c: 0.32001644451474576d),

new NpgsqlTypes.NpgsqlLine(a: 0.7113651445912559d, b: 0.3869191031273206d, c: 0.7332400621535746d),

new NpgsqlTypes.NpgsqlLine(a: 0.5302147002696467d, b: 0.6514960201183412d, c: 0.8888784836070758d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1921152006,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1921152006,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3706659351474607d, b: 0.20392121211971403d, c: 0.09026673921559647d),

new NpgsqlTypes.NpgsqlLine(a: 0.3426907809834573d, b: 0.11597889224231583d, c: 0.37580383029156417d),

new NpgsqlTypes.NpgsqlLine(a: 0.9569454063294334d, b: 0.5352074925592666d, c: 0.1505041653825815d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 322154126,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17316937563192347d, b: 0.7977878569807266d, c: 0.5061623155222499d),

new NpgsqlTypes.NpgsqlLine(a: 0.39020299771548206d, b: 0.46872469438895703d, c: 0.1947250961658502d),

new NpgsqlTypes.NpgsqlLine(a: 0.9460666899443665d, b: 0.40873002207057996d, c: 0.5383135596603867d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1931477721,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1931477721,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24029930494024243d, b: 0.6494520983530296d, c: 0.6457904476196421d),

new NpgsqlTypes.NpgsqlLine(a: 0.5413106581652064d, b: 0.65922568011039d, c: 0.023000101756869618d),

new NpgsqlTypes.NpgsqlLine(a: 0.05698461456670889d, b: 0.07946838244893384d, c: 0.023133320459978735d),

new NpgsqlTypes.NpgsqlLine(a: 0.023417572430763367d, b: 0.20022755743974863d, c: 0.9001563624157146d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3818728397283605d, b: 0.24081372003152057d, c: 0.42604600108359325d),

new NpgsqlTypes.NpgsqlLine(a: 0.9919565701428744d, b: 0.9836921588174795d, c: 0.6353618672799166d),

new NpgsqlTypes.NpgsqlLine(a: 0.49779514301225014d, b: 0.9235637976007209d, c: 0.26480996790155775d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1943853869,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1943853869,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5132420668035784d, b: 0.9613252483783701d, c: 0.9242449431625296d),

new NpgsqlTypes.NpgsqlLine(a: 0.36653456446188004d, b: 0.7359631901409467d, c: 0.27792441954855884d),

new NpgsqlTypes.NpgsqlLine(a: 0.4636783251093567d, b: 0.1186591604974756d, c: 0.39388519565520497d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1951774404,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1951774404,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4334255210533513d, b: 0.5785255926410576d, c: 0.9661508534687067d),

new NpgsqlTypes.NpgsqlLine(a: 0.19775236418153797d, b: 0.9365672085879589d, c: 0.1494826860380959d),

new NpgsqlTypes.NpgsqlLine(a: 0.176207462329397d, b: 0.2629253672101627d, c: 0.07007543599573873d),

new NpgsqlTypes.NpgsqlLine(a: 0.12818842182277845d, b: 0.1863366614728862d, c: 0.7134229928630377d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6151166351904711d, b: 0.2498835420322547d, c: 0.9733560033126378d),

new NpgsqlTypes.NpgsqlLine(a: 0.7516653963992566d, b: 0.8871254006140514d, c: 0.9688544000775576d),

new NpgsqlTypes.NpgsqlLine(a: 0.5920030979667459d, b: 0.19764908877922582d, c: 0.5631519149614208d),

},

                        ModelInner = null

                    }
                );

                var models =  ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                {
                    var expectEnumerValue = expectedModel.Value;
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
                if(expectedModel.NullableValue == null)
                {
                    Assert.That(model.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expectedModel.NullableValue;
                        Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = model.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
                    }
                }

                if(expectedModel.ModelInner == null)
                {
                    Assert.That(model.ModelInner, Is.Null);
                }
                else
                {
                    Assert.That(model.ModelInner, Is.Not.Null);
                    Assert.That(model.ModelInner.Id, Is.EqualTo(expectedModel.ModelInner.Id));

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,NpgsqlLinelineArray2M>(30);

                expected.Add(
                    94091086,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 94091086,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.756130013480001d, b: 0.8070063086186816d, c: 0.5025767314647364d),

new NpgsqlTypes.NpgsqlLine(a: 0.9364656141137178d, b: 0.4282247001937053d, c: 0.659495056495708d),

new NpgsqlTypes.NpgsqlLine(a: 0.2335034105141761d, b: 0.052909961042862275d, c: 0.04122572474287722d),

new NpgsqlTypes.NpgsqlLine(a: 0.5214850980568969d, b: 0.6097853166227842d, c: 0.037564705410715216d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.794741433961441d, b: 0.40948478818553324d, c: 0.8349955153630194d),

new NpgsqlTypes.NpgsqlLine(a: 0.6948645889459438d, b: 0.632857065419259d, c: 0.5039544579972753d),

new NpgsqlTypes.NpgsqlLine(a: 0.08944891276585798d, b: 0.913270540398744d, c: 0.6982865099702906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8541822252456289d, b: 0.7910647286519775d, c: 0.2522573522827649d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    128586765,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 128586765,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7662615462562571d, b: 0.41140775410532837d, c: 0.865079853391942d),

new NpgsqlTypes.NpgsqlLine(a: 0.9304815161900817d, b: 0.6441951572457856d, c: 0.4734484158164034d),

new NpgsqlTypes.NpgsqlLine(a: 0.28545320578356514d, b: 0.7953412500579145d, c: 0.13180882594344d),

new NpgsqlTypes.NpgsqlLine(a: 0.0006534434907554676d, b: 0.7291585410038824d, c: 0.07683170668531758d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    350174520,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 350174520,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23005994787391715d, b: 0.314006898861965d, c: 0.9059890459886075d),

new NpgsqlTypes.NpgsqlLine(a: 0.0034924525333345224d, b: 0.22569705718656508d, c: 0.12293033480738269d),

new NpgsqlTypes.NpgsqlLine(a: 0.13769753447358068d, b: 0.20289930144832358d, c: 0.9141833823361538d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    528252532,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 528252532,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22785571390952986d, b: 0.47384563164287363d, c: 0.7296472935133859d),

new NpgsqlTypes.NpgsqlLine(a: 0.42847852345883053d, b: 0.05295602193643412d, c: 0.7176332323630693d),

new NpgsqlTypes.NpgsqlLine(a: 0.1313916587576558d, b: 0.44047120647606086d, c: 0.4080020542049758d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 2023967945,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7526118185907706d, b: 0.7217192659741516d, c: 0.10725515353553927d),

new NpgsqlTypes.NpgsqlLine(a: 0.4123399872860949d, b: 0.9887632111198967d, c: 0.3407478138648996d),

new NpgsqlTypes.NpgsqlLine(a: 0.1972888611598902d, b: 0.21209298014251077d, c: 0.998100482656704d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32204440669620105d, b: 0.40425092983702615d, c: 0.6281187397686202d),

new NpgsqlTypes.NpgsqlLine(a: 0.8736370792109995d, b: 0.8257156419424208d, c: 0.24574228768788875d),

new NpgsqlTypes.NpgsqlLine(a: 0.1777372581271598d, b: 0.02795031420098848d, c: 0.6085263716794568d),

new NpgsqlTypes.NpgsqlLine(a: 0.3937718955623397d, b: 0.3857998777014512d, c: 0.16490107858931902d),

}
                        }

                    }
                );

                expected.Add(
                    548719832,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 548719832,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45120792613918626d, b: 0.7981849131464387d, c: 0.6797001557385036d),

new NpgsqlTypes.NpgsqlLine(a: 0.5152860785682492d, b: 0.05860524276063561d, c: 0.31392693425098706d),

new NpgsqlTypes.NpgsqlLine(a: 0.8399321644879826d, b: 0.14127845073157042d, c: 0.04919268640928787d),

new NpgsqlTypes.NpgsqlLine(a: 0.5367279979863265d, b: 0.9037039524330727d, c: 0.5651736207579545d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 632564420,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9871612756422758d, b: 0.7040000628939183d, c: 0.5741990515908977d),

new NpgsqlTypes.NpgsqlLine(a: 0.8939251170158339d, b: 0.591802460616856d, c: 0.8710953712464558d),

new NpgsqlTypes.NpgsqlLine(a: 0.925765879252592d, b: 0.020003653879282934d, c: 0.27174016206463947d),

new NpgsqlTypes.NpgsqlLine(a: 0.40821497810499396d, b: 0.18426353989680566d, c: 0.35762480728827095d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    569222828,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 569222828,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3541781533895836d, b: 0.8806877333215982d, c: 0.3434395351862555d),

new NpgsqlTypes.NpgsqlLine(a: 0.904182291889472d, b: 0.2725232832902962d, c: 0.11922376175569749d),

new NpgsqlTypes.NpgsqlLine(a: 0.2973949214938665d, b: 0.551548200515303d, c: 0.11510798755200236d),

new NpgsqlTypes.NpgsqlLine(a: 0.6236383027800103d, b: 0.7132402356425214d, c: 0.7946866828405127d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 1120533763,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7797869567083358d, b: 0.2361739464389747d, c: 0.48164557546500963d),

new NpgsqlTypes.NpgsqlLine(a: 0.9480048066554808d, b: 0.8035492224666504d, c: 0.9832497213764478d),

new NpgsqlTypes.NpgsqlLine(a: 0.9772596541640088d, b: 0.6093516798517065d, c: 0.6052760903401032d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    617125650,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 617125650,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35787275736319957d, b: 0.702047825867143d, c: 0.965415572167533d),

new NpgsqlTypes.NpgsqlLine(a: 0.31090623461505584d, b: 0.5647177423851781d, c: 0.4846654296503867d),

new NpgsqlTypes.NpgsqlLine(a: 0.3183862992195977d, b: 0.6261458826331173d, c: 0.6907068588712774d),

new NpgsqlTypes.NpgsqlLine(a: 0.6487979418902344d, b: 0.4615179308283234d, c: 0.642127574912425d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9197027266355764d, b: 0.39215058098740485d, c: 0.17261332753094694d),

new NpgsqlTypes.NpgsqlLine(a: 0.11391459246246716d, b: 0.8528811542175645d, c: 0.20274869752530522d),

new NpgsqlTypes.NpgsqlLine(a: 0.36907637605105814d, b: 0.6376511000289307d, c: 0.12998307736849357d),

new NpgsqlTypes.NpgsqlLine(a: 0.9580086581171673d, b: 0.03050170247729178d, c: 0.38029624192446d),

},

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 1413412459,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42503376733197573d, b: 0.763237079678654d, c: 0.09688502535476584d),

new NpgsqlTypes.NpgsqlLine(a: 0.23240822962655505d, b: 0.8459480271218152d, c: 0.08432931494869422d),

new NpgsqlTypes.NpgsqlLine(a: 0.18886663761414113d, b: 0.5079561486308892d, c: 0.9843388801596968d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    627974170,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 627974170,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15147399565049113d, b: 0.7627100647125816d, c: 0.16010235385722305d),

new NpgsqlTypes.NpgsqlLine(a: 0.9001358065765852d, b: 0.4721890907147458d, c: 0.15927787372271784d),

new NpgsqlTypes.NpgsqlLine(a: 0.7813049144298684d, b: 0.4136335409837938d, c: 0.12660196714031435d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.004236560392559818d, b: 0.39606208609499893d, c: 0.19741769434420997d),

new NpgsqlTypes.NpgsqlLine(a: 0.5953646586031078d, b: 0.6151314480582013d, c: 0.6556527973910132d),

new NpgsqlTypes.NpgsqlLine(a: 0.5407811339876436d, b: 0.9334248245144674d, c: 0.8365874899469636d),

new NpgsqlTypes.NpgsqlLine(a: 0.4764002070454937d, b: 0.16718217080509323d, c: 0.17236129187105342d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    791579102,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 791579102,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3341739254022562d, b: 0.718465753134697d, c: 0.5771634629019262d),

new NpgsqlTypes.NpgsqlLine(a: 0.6322200521292398d, b: 0.8246392866857581d, c: 0.5696079494467468d),

new NpgsqlTypes.NpgsqlLine(a: 0.6545382710133834d, b: 0.4365654599867256d, c: 0.8153585418393168d),

new NpgsqlTypes.NpgsqlLine(a: 0.0910019439659393d, b: 0.7174745892954046d, c: 0.1511089208473413d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 1190383178,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12466334172066618d, b: 0.11152073168077081d, c: 0.491230984381532d),

new NpgsqlTypes.NpgsqlLine(a: 0.5547266175262346d, b: 0.13792449594977796d, c: 0.7570674004021489d),

new NpgsqlTypes.NpgsqlLine(a: 0.2085058544453703d, b: 0.08290359377194412d, c: 0.77495272781113d),

new NpgsqlTypes.NpgsqlLine(a: 0.49111506712078934d, b: 0.641116986925848d, c: 0.29516341556351666d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07914996961984966d, b: 0.4871418257809952d, c: 0.7513322508300865d),

new NpgsqlTypes.NpgsqlLine(a: 0.9239635289951339d, b: 0.38794777551433746d, c: 0.676783160212782d),

new NpgsqlTypes.NpgsqlLine(a: 0.0955538255878925d, b: 0.01055236041931451d, c: 0.2842563281409253d),

new NpgsqlTypes.NpgsqlLine(a: 0.02927332855673237d, b: 0.6165842674891228d, c: 0.8012173905302888d),

}
                        }

                    }
                );

                expected.Add(
                    833599485,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 833599485,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4822973119466689d, b: 0.792513536759573d, c: 0.499633501292873d),

new NpgsqlTypes.NpgsqlLine(a: 0.8918073488512478d, b: 0.42208129985829845d, c: 0.5329638256901381d),

new NpgsqlTypes.NpgsqlLine(a: 0.5188620987187985d, b: 0.1726952436096839d, c: 0.7227459582321649d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15666178016283616d, b: 0.2873368213961791d, c: 0.4420895689102471d),

new NpgsqlTypes.NpgsqlLine(a: 0.4601057867375493d, b: 0.5622721416121373d, c: 0.2999980165807573d),

new NpgsqlTypes.NpgsqlLine(a: 0.8381583831951187d, b: 0.9764919740330239d, c: 0.18152562681640294d),

},

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 1272632761,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8378269016529278d, b: 0.6733240332238696d, c: 0.8919506779863193d),

new NpgsqlTypes.NpgsqlLine(a: 0.48570634731194795d, b: 0.1596671151368555d, c: 0.20750860994967846d),

new NpgsqlTypes.NpgsqlLine(a: 0.779653513645174d, b: 0.8586337096501773d, c: 0.1738735269722934d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2675334980310755d, b: 0.5860654638502302d, c: 0.5223481489931099d),

new NpgsqlTypes.NpgsqlLine(a: 0.2908190505712529d, b: 0.027311571062217044d, c: 0.38897855152716554d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590347289639254d, b: 0.6110078502040162d, c: 0.9773066927065011d),

}
                        }

                    }
                );

                expected.Add(
                    896715967,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 896715967,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4784147382307862d, b: 0.6552419336185478d, c: 0.920823919677529d),

new NpgsqlTypes.NpgsqlLine(a: 0.742593437228071d, b: 0.6268935209443758d, c: 0.5071732457335109d),

new NpgsqlTypes.NpgsqlLine(a: 0.6253496198816004d, b: 0.5361783003872929d, c: 0.7158348891331027d),

new NpgsqlTypes.NpgsqlLine(a: 0.4294538215627851d, b: 0.8234156672775046d, c: 0.08688024353682888d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 117280179,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3605977641294892d, b: 0.17811158147680461d, c: 0.9658058071756186d),

new NpgsqlTypes.NpgsqlLine(a: 0.6970256025820155d, b: 0.5444046414962291d, c: 0.46720686007108925d),

new NpgsqlTypes.NpgsqlLine(a: 0.8561050660597573d, b: 0.11353237597432853d, c: 0.56669941414895d),

new NpgsqlTypes.NpgsqlLine(a: 0.7984600619309864d, b: 0.8109151931011057d, c: 0.769305377302455d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0947306689172811d, b: 0.8302577671800684d, c: 0.8970532400118938d),

new NpgsqlTypes.NpgsqlLine(a: 0.2407748752003226d, b: 0.4567310255560061d, c: 0.4526792803927874d),

new NpgsqlTypes.NpgsqlLine(a: 0.04496104252758981d, b: 0.7589917027634498d, c: 0.6770421060059869d),

}
                        }

                    }
                );

                expected.Add(
                    899804594,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 899804594,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1970857537444196d, b: 0.9333242638108382d, c: 0.2997924017071659d),

new NpgsqlTypes.NpgsqlLine(a: 0.6311349404614687d, b: 0.19618574736695826d, c: 0.38842914242231885d),

new NpgsqlTypes.NpgsqlLine(a: 0.8616526286116198d, b: 0.5020108677923993d, c: 0.7507796571723376d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8462722154822349d, b: 0.2140170588076531d, c: 0.1555300802445071d),

new NpgsqlTypes.NpgsqlLine(a: 0.05107346767082066d, b: 0.6007632357415391d, c: 0.11568725974145999d),

new NpgsqlTypes.NpgsqlLine(a: 0.9923537289603477d, b: 0.4950249871115745d, c: 0.02343990901364046d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    964637978,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 964637978,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7665509369596407d, b: 0.32246651386445413d, c: 0.4163237996846909d),

new NpgsqlTypes.NpgsqlLine(a: 0.622867187513811d, b: 0.02481599358005626d, c: 0.6781914372848628d),

new NpgsqlTypes.NpgsqlLine(a: 0.9383962517038102d, b: 0.22799617371669267d, c: 0.11769282658114588d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1006841713,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1006841713,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3814391347607825d, b: 0.6500010795000312d, c: 0.5168910912789877d),

new NpgsqlTypes.NpgsqlLine(a: 0.9809725325416359d, b: 0.5965089551877092d, c: 0.9620206915411497d),

new NpgsqlTypes.NpgsqlLine(a: 0.8326177257415529d, b: 0.9726427466112844d, c: 0.44743910631138517d),

new NpgsqlTypes.NpgsqlLine(a: 0.9428905413649304d, b: 0.2742783552238923d, c: 0.20624247958140818d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4156588878635493d, b: 0.9311562710078888d, c: 0.18729745760128813d),

new NpgsqlTypes.NpgsqlLine(a: 0.7838364754377413d, b: 0.2902143764264882d, c: 0.6468999105347263d),

new NpgsqlTypes.NpgsqlLine(a: 0.2807400125401047d, b: 0.4738433713063067d, c: 0.3414032292061351d),

new NpgsqlTypes.NpgsqlLine(a: 0.07976939589399212d, b: 0.6817427263698487d, c: 0.7162950229594492d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1008288557,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1008288557,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6703103585772012d, b: 0.9414469448287122d, c: 0.32961805156524826d),

new NpgsqlTypes.NpgsqlLine(a: 0.13239408457631574d, b: 0.5134528929025426d, c: 0.5412589816963953d),

new NpgsqlTypes.NpgsqlLine(a: 0.1699098825091695d, b: 0.9194545880639252d, c: 0.7451240040858685d),

new NpgsqlTypes.NpgsqlLine(a: 0.2233903417330374d, b: 0.07771599830861675d, c: 0.5752102020647447d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 723640790,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8545769023218451d, b: 0.24286566112974062d, c: 0.24373271509232275d),

new NpgsqlTypes.NpgsqlLine(a: 0.8731571462637403d, b: 0.9993617334238951d, c: 0.1725755360195571d),

new NpgsqlTypes.NpgsqlLine(a: 0.2467482163165423d, b: 0.7309207508122816d, c: 0.574326589073651d),

new NpgsqlTypes.NpgsqlLine(a: 0.39429370255535745d, b: 0.12918013405283635d, c: 0.37279548432778786d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8697103680615146d, b: 0.4868697197066526d, c: 0.008300202872866591d),

new NpgsqlTypes.NpgsqlLine(a: 0.9268152455195247d, b: 0.9945415027788427d, c: 0.33225561051564245d),

new NpgsqlTypes.NpgsqlLine(a: 0.06541514412119742d, b: 0.29832372565206444d, c: 0.34837671529944225d),

new NpgsqlTypes.NpgsqlLine(a: 0.7703107306167513d, b: 0.39150187650435253d, c: 0.17912768771478083d),

}
                        }

                    }
                );

                expected.Add(
                    1212970907,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1212970907,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5991478813435879d, b: 0.21696546349723422d, c: 0.7473704822066682d),

new NpgsqlTypes.NpgsqlLine(a: 0.151066097236479d, b: 0.0802844223551269d, c: 0.09162465810768494d),

new NpgsqlTypes.NpgsqlLine(a: 0.8623052986382002d, b: 0.9298840839917386d, c: 0.6660510239194597d),

new NpgsqlTypes.NpgsqlLine(a: 0.9991351159913222d, b: 0.029361445428178645d, c: 0.30760770391653036d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 2140414751,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5666355568463651d, b: 0.5532657932652175d, c: 0.043303548850170626d),

new NpgsqlTypes.NpgsqlLine(a: 0.4900959494886681d, b: 0.9349750472343457d, c: 0.4121355471301291d),

new NpgsqlTypes.NpgsqlLine(a: 0.06398838318692368d, b: 0.028285739863693204d, c: 0.8052480125394759d),

new NpgsqlTypes.NpgsqlLine(a: 0.31673961185856914d, b: 0.4141587759463713d, c: 0.1893488396111126d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1370558129,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1370558129,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9082169806472872d, b: 0.9235120225757552d, c: 0.8994934710072177d),

new NpgsqlTypes.NpgsqlLine(a: 0.12419478532476513d, b: 0.805126203795883d, c: 0.21123699569220133d),

new NpgsqlTypes.NpgsqlLine(a: 0.5518835410640954d, b: 0.3470463651950829d, c: 0.4121461426388031d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 196308953,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28578713252269017d, b: 0.8474368218362299d, c: 0.05146566977408318d),

new NpgsqlTypes.NpgsqlLine(a: 0.9109299616024349d, b: 0.5870141058904383d, c: 0.7452912896149598d),

new NpgsqlTypes.NpgsqlLine(a: 0.09671303857190205d, b: 0.22234046410281205d, c: 0.2889776640209598d),

new NpgsqlTypes.NpgsqlLine(a: 0.3594930797393622d, b: 0.1261117062789614d, c: 0.4836691385976134d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1411554384,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1411554384,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.43292849531653743d, b: 0.10139772092942057d, c: 0.19581477698464556d),

new NpgsqlTypes.NpgsqlLine(a: 0.7747830082073887d, b: 0.7612727046736724d, c: 0.49585407932443326d),

new NpgsqlTypes.NpgsqlLine(a: 0.7534769161594925d, b: 0.21640631521439513d, c: 0.9417215429915208d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1423267657,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1423267657,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7028157888188539d, b: 0.4434497177574276d, c: 0.1878584904244096d),

new NpgsqlTypes.NpgsqlLine(a: 0.12779644786129707d, b: 0.6547737034235738d, c: 0.7340324477099678d),

new NpgsqlTypes.NpgsqlLine(a: 0.13473852180731738d, b: 0.7900921279332365d, c: 0.7695417103969711d),

new NpgsqlTypes.NpgsqlLine(a: 0.2618677281295215d, b: 0.24821010444457137d, c: 0.2711393719015588d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1610745034,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1610745034,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6382266935775643d, b: 0.398693329671132d, c: 0.7425094436899613d),

new NpgsqlTypes.NpgsqlLine(a: 0.24327741116998813d, b: 0.1635267687203752d, c: 0.628031718062037d),

new NpgsqlTypes.NpgsqlLine(a: 0.38459544322295613d, b: 0.4141132804519537d, c: 0.8511486540491503d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9861241662988156d, b: 0.25399030999510996d, c: 0.2529918964264557d),

new NpgsqlTypes.NpgsqlLine(a: 0.17574090331875702d, b: 0.5215697754670754d, c: 0.49092403723555744d),

new NpgsqlTypes.NpgsqlLine(a: 0.9755215010138426d, b: 0.5836706698542481d, c: 0.8112425273051307d),

},

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 1525343338,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5334739519154116d, b: 0.14533927203574382d, c: 0.9972375896646379d),

new NpgsqlTypes.NpgsqlLine(a: 0.5376404385911305d, b: 0.3967355325520928d, c: 0.2690585850054501d),

new NpgsqlTypes.NpgsqlLine(a: 0.7930288640515465d, b: 0.4034090749439643d, c: 0.19977351395319798d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22585130451050572d, b: 0.054454055462575424d, c: 0.3670135684186787d),

new NpgsqlTypes.NpgsqlLine(a: 0.8573417118252535d, b: 0.7290365889192361d, c: 0.15771025911629288d),

new NpgsqlTypes.NpgsqlLine(a: 0.8294206137900973d, b: 0.778292553399524d, c: 0.5844131999897239d),

new NpgsqlTypes.NpgsqlLine(a: 0.8795242286168519d, b: 0.43336364459496624d, c: 0.07939237473054006d),

}
                        }

                    }
                );

                expected.Add(
                    1618779845,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1618779845,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588222459861263d, b: 0.8314528851615401d, c: 0.4091425195520225d),

new NpgsqlTypes.NpgsqlLine(a: 0.15497545879234587d, b: 0.42501177297812087d, c: 0.3930386900482442d),

new NpgsqlTypes.NpgsqlLine(a: 0.49932759733861587d, b: 0.27860846401633954d, c: 0.22371479209453393d),

new NpgsqlTypes.NpgsqlLine(a: 0.6744750487770321d, b: 0.5185555306309229d, c: 0.48333909912156325d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6846715107366038d, b: 0.7822398219668835d, c: 0.6995656002724597d),

new NpgsqlTypes.NpgsqlLine(a: 0.34191163697506577d, b: 0.251427920689659d, c: 0.6372400180339429d),

new NpgsqlTypes.NpgsqlLine(a: 0.7615638356664386d, b: 0.38275705185682163d, c: 0.9430695395246483d),

new NpgsqlTypes.NpgsqlLine(a: 0.25861736938688795d, b: 0.2236086093911689d, c: 0.43081968027669826d),

},

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 111191550,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10079392481388938d, b: 0.47419284524344363d, c: 0.46999813598135487d),

new NpgsqlTypes.NpgsqlLine(a: 0.4512330545433114d, b: 0.7685777654216315d, c: 0.761484461621478d),

new NpgsqlTypes.NpgsqlLine(a: 0.7069502335832981d, b: 0.10867536284292001d, c: 0.803973548621565d),

new NpgsqlTypes.NpgsqlLine(a: 0.6710482193897285d, b: 0.3246300803211939d, c: 0.007931088387647223d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1651600176,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1651600176,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16882852097245493d, b: 0.6320810387310721d, c: 0.4943119337666173d),

new NpgsqlTypes.NpgsqlLine(a: 0.1864608664190791d, b: 0.3923939341785333d, c: 0.40778672849944797d),

new NpgsqlTypes.NpgsqlLine(a: 0.21658079009283382d, b: 0.9735580473103661d, c: 0.5313780798893142d),

new NpgsqlTypes.NpgsqlLine(a: 0.608447080933292d, b: 0.9095061095638245d, c: 0.664417030599092d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1656686707,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1656686707,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08369873952495288d, b: 0.07788317757867735d, c: 0.284112517861248d),

new NpgsqlTypes.NpgsqlLine(a: 0.617171498263342d, b: 0.5865508373972511d, c: 0.36018099841433293d),

new NpgsqlTypes.NpgsqlLine(a: 0.4798021589910493d, b: 0.5378837702166812d, c: 0.2195325878675365d),

new NpgsqlTypes.NpgsqlLine(a: 0.961753857136392d, b: 0.8919192421134503d, c: 0.16540674234160435d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 1264360862,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3150738269575506d, b: 0.25723902915678687d, c: 0.7085220942560913d),

new NpgsqlTypes.NpgsqlLine(a: 0.10217399526832571d, b: 0.23606907248025677d, c: 0.14832581681823231d),

new NpgsqlTypes.NpgsqlLine(a: 0.38475783269574504d, b: 0.261674953378639d, c: 0.8414017715374641d),

new NpgsqlTypes.NpgsqlLine(a: 0.060969244577031345d, b: 0.7001282741779633d, c: 0.8180532031964253d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1800975967,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1800975967,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6019711101236188d, b: 0.451502314152629d, c: 0.7567258646896037d),

new NpgsqlTypes.NpgsqlLine(a: 0.20314867633928102d, b: 0.43694052621738755d, c: 0.07972430095228344d),

new NpgsqlTypes.NpgsqlLine(a: 0.38639176328531444d, b: 0.5546727142910798d, c: 0.3595107666863845d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 116492752,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8534388679989421d, b: 0.17051639981163313d, c: 0.11184373953100968d),

new NpgsqlTypes.NpgsqlLine(a: 0.5545649696933802d, b: 0.6495249060333349d, c: 0.14480165352840013d),

new NpgsqlTypes.NpgsqlLine(a: 0.7068689700072772d, b: 0.10325704725403717d, c: 0.1383403540154834d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.565937691937727d, b: 0.8643068916219007d, c: 0.7899347881580714d),

new NpgsqlTypes.NpgsqlLine(a: 0.5461437063589625d, b: 0.8396992488239946d, c: 0.4549808859483121d),

new NpgsqlTypes.NpgsqlLine(a: 0.11142572920429805d, b: 0.7092154686109046d, c: 0.04531658445440445d),

new NpgsqlTypes.NpgsqlLine(a: 0.8590566964589479d, b: 0.07365357454587718d, c: 0.01783865983951749d),

}
                        }

                    }
                );

                expected.Add(
                    1858289195,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1858289195,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25032438445726d, b: 0.0917391846373673d, c: 0.34066051809002806d),

new NpgsqlTypes.NpgsqlLine(a: 0.07831144663304057d, b: 0.77591037387439d, c: 0.19759580235224372d),

new NpgsqlTypes.NpgsqlLine(a: 0.3752205191956137d, b: 0.9100313386910368d, c: 0.6525871812195568d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47106408656007914d, b: 0.14257658261320605d, c: 0.47373760961489964d),

new NpgsqlTypes.NpgsqlLine(a: 0.4366806562773925d, b: 0.20146202051894901d, c: 0.3244113712884158d),

new NpgsqlTypes.NpgsqlLine(a: 0.41468311552317627d, b: 0.27557991533085235d, c: 0.7788691278257713d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1908397739,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1908397739,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36399675452528046d, b: 0.21180965313124933d, c: 0.6232643186817026d),

new NpgsqlTypes.NpgsqlLine(a: 0.8377534917307251d, b: 0.7197248111141329d, c: 0.5638759891270843d),

new NpgsqlTypes.NpgsqlLine(a: 0.9127913721936561d, b: 0.47658260676426356d, c: 0.4401534500107992d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.502181779437056d, b: 0.3652805047459293d, c: 0.32001644451474576d),

new NpgsqlTypes.NpgsqlLine(a: 0.7113651445912559d, b: 0.3869191031273206d, c: 0.7332400621535746d),

new NpgsqlTypes.NpgsqlLine(a: 0.5302147002696467d, b: 0.6514960201183412d, c: 0.8888784836070758d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1921152006,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1921152006,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3706659351474607d, b: 0.20392121211971403d, c: 0.09026673921559647d),

new NpgsqlTypes.NpgsqlLine(a: 0.3426907809834573d, b: 0.11597889224231583d, c: 0.37580383029156417d),

new NpgsqlTypes.NpgsqlLine(a: 0.9569454063294334d, b: 0.5352074925592666d, c: 0.1505041653825815d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray2MI
                        {
                            Id = 322154126,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17316937563192347d, b: 0.7977878569807266d, c: 0.5061623155222499d),

new NpgsqlTypes.NpgsqlLine(a: 0.39020299771548206d, b: 0.46872469438895703d, c: 0.1947250961658502d),

new NpgsqlTypes.NpgsqlLine(a: 0.9460666899443665d, b: 0.40873002207057996d, c: 0.5383135596603867d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1931477721,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1931477721,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24029930494024243d, b: 0.6494520983530296d, c: 0.6457904476196421d),

new NpgsqlTypes.NpgsqlLine(a: 0.5413106581652064d, b: 0.65922568011039d, c: 0.023000101756869618d),

new NpgsqlTypes.NpgsqlLine(a: 0.05698461456670889d, b: 0.07946838244893384d, c: 0.023133320459978735d),

new NpgsqlTypes.NpgsqlLine(a: 0.023417572430763367d, b: 0.20022755743974863d, c: 0.9001563624157146d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3818728397283605d, b: 0.24081372003152057d, c: 0.42604600108359325d),

new NpgsqlTypes.NpgsqlLine(a: 0.9919565701428744d, b: 0.9836921588174795d, c: 0.6353618672799166d),

new NpgsqlTypes.NpgsqlLine(a: 0.49779514301225014d, b: 0.9235637976007209d, c: 0.26480996790155775d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1943853869,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1943853869,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5132420668035784d, b: 0.9613252483783701d, c: 0.9242449431625296d),

new NpgsqlTypes.NpgsqlLine(a: 0.36653456446188004d, b: 0.7359631901409467d, c: 0.27792441954855884d),

new NpgsqlTypes.NpgsqlLine(a: 0.4636783251093567d, b: 0.1186591604974756d, c: 0.39388519565520497d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1951774404,
                    new NpgsqlLinelineArray2M
                    {
                        Id = 1951774404,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4334255210533513d, b: 0.5785255926410576d, c: 0.9661508534687067d),

new NpgsqlTypes.NpgsqlLine(a: 0.19775236418153797d, b: 0.9365672085879589d, c: 0.1494826860380959d),

new NpgsqlTypes.NpgsqlLine(a: 0.176207462329397d, b: 0.2629253672101627d, c: 0.07007543599573873d),

new NpgsqlTypes.NpgsqlLine(a: 0.12818842182277845d, b: 0.1863366614728862d, c: 0.7134229928630377d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6151166351904711d, b: 0.2498835420322547d, c: 0.9733560033126378d),

new NpgsqlTypes.NpgsqlLine(a: 0.7516653963992566d, b: 0.8871254006140514d, c: 0.9688544000775576d),

new NpgsqlTypes.NpgsqlLine(a: 0.5920030979667459d, b: 0.19764908877922582d, c: 0.5631519149614208d),

},

                        ModelInner = null

                    }
                );

                var models = await ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                {
                    var expectEnumerValue = expectedModel.Value;
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
                if(expectedModel.NullableValue == null)
                {
                    Assert.That(model.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expectedModel.NullableValue;
                        Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = model.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
                    }
                }

                if(expectedModel.ModelInner == null)
                {
                    Assert.That(model.ModelInner, Is.Null);
                }
                else
                {
                    Assert.That(model.ModelInner, Is.Not.Null);
                    Assert.That(model.ModelInner.Id, Is.EqualTo(expectedModel.ModelInner.Id));

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,NpgsqlLinelineArray2MI>(15);

                expected.Add(
                    111191550,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 111191550,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10079392481388938d, b: 0.47419284524344363d, c: 0.46999813598135487d),

new NpgsqlTypes.NpgsqlLine(a: 0.4512330545433114d, b: 0.7685777654216315d, c: 0.761484461621478d),

new NpgsqlTypes.NpgsqlLine(a: 0.7069502335832981d, b: 0.10867536284292001d, c: 0.803973548621565d),

new NpgsqlTypes.NpgsqlLine(a: 0.6710482193897285d, b: 0.3246300803211939d, c: 0.007931088387647223d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    116492752,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 116492752,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8534388679989421d, b: 0.17051639981163313d, c: 0.11184373953100968d),

new NpgsqlTypes.NpgsqlLine(a: 0.5545649696933802d, b: 0.6495249060333349d, c: 0.14480165352840013d),

new NpgsqlTypes.NpgsqlLine(a: 0.7068689700072772d, b: 0.10325704725403717d, c: 0.1383403540154834d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.565937691937727d, b: 0.8643068916219007d, c: 0.7899347881580714d),

new NpgsqlTypes.NpgsqlLine(a: 0.5461437063589625d, b: 0.8396992488239946d, c: 0.4549808859483121d),

new NpgsqlTypes.NpgsqlLine(a: 0.11142572920429805d, b: 0.7092154686109046d, c: 0.04531658445440445d),

new NpgsqlTypes.NpgsqlLine(a: 0.8590566964589479d, b: 0.07365357454587718d, c: 0.01783865983951749d),

}
                    }
                );

                expected.Add(
                    117280179,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 117280179,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3605977641294892d, b: 0.17811158147680461d, c: 0.9658058071756186d),

new NpgsqlTypes.NpgsqlLine(a: 0.6970256025820155d, b: 0.5444046414962291d, c: 0.46720686007108925d),

new NpgsqlTypes.NpgsqlLine(a: 0.8561050660597573d, b: 0.11353237597432853d, c: 0.56669941414895d),

new NpgsqlTypes.NpgsqlLine(a: 0.7984600619309864d, b: 0.8109151931011057d, c: 0.769305377302455d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0947306689172811d, b: 0.8302577671800684d, c: 0.8970532400118938d),

new NpgsqlTypes.NpgsqlLine(a: 0.2407748752003226d, b: 0.4567310255560061d, c: 0.4526792803927874d),

new NpgsqlTypes.NpgsqlLine(a: 0.04496104252758981d, b: 0.7589917027634498d, c: 0.6770421060059869d),

}
                    }
                );

                expected.Add(
                    196308953,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 196308953,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28578713252269017d, b: 0.8474368218362299d, c: 0.05146566977408318d),

new NpgsqlTypes.NpgsqlLine(a: 0.9109299616024349d, b: 0.5870141058904383d, c: 0.7452912896149598d),

new NpgsqlTypes.NpgsqlLine(a: 0.09671303857190205d, b: 0.22234046410281205d, c: 0.2889776640209598d),

new NpgsqlTypes.NpgsqlLine(a: 0.3594930797393622d, b: 0.1261117062789614d, c: 0.4836691385976134d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    322154126,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 322154126,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17316937563192347d, b: 0.7977878569807266d, c: 0.5061623155222499d),

new NpgsqlTypes.NpgsqlLine(a: 0.39020299771548206d, b: 0.46872469438895703d, c: 0.1947250961658502d),

new NpgsqlTypes.NpgsqlLine(a: 0.9460666899443665d, b: 0.40873002207057996d, c: 0.5383135596603867d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    632564420,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 632564420,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9871612756422758d, b: 0.7040000628939183d, c: 0.5741990515908977d),

new NpgsqlTypes.NpgsqlLine(a: 0.8939251170158339d, b: 0.591802460616856d, c: 0.8710953712464558d),

new NpgsqlTypes.NpgsqlLine(a: 0.925765879252592d, b: 0.020003653879282934d, c: 0.27174016206463947d),

new NpgsqlTypes.NpgsqlLine(a: 0.40821497810499396d, b: 0.18426353989680566d, c: 0.35762480728827095d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    723640790,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 723640790,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8545769023218451d, b: 0.24286566112974062d, c: 0.24373271509232275d),

new NpgsqlTypes.NpgsqlLine(a: 0.8731571462637403d, b: 0.9993617334238951d, c: 0.1725755360195571d),

new NpgsqlTypes.NpgsqlLine(a: 0.2467482163165423d, b: 0.7309207508122816d, c: 0.574326589073651d),

new NpgsqlTypes.NpgsqlLine(a: 0.39429370255535745d, b: 0.12918013405283635d, c: 0.37279548432778786d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8697103680615146d, b: 0.4868697197066526d, c: 0.008300202872866591d),

new NpgsqlTypes.NpgsqlLine(a: 0.9268152455195247d, b: 0.9945415027788427d, c: 0.33225561051564245d),

new NpgsqlTypes.NpgsqlLine(a: 0.06541514412119742d, b: 0.29832372565206444d, c: 0.34837671529944225d),

new NpgsqlTypes.NpgsqlLine(a: 0.7703107306167513d, b: 0.39150187650435253d, c: 0.17912768771478083d),

}
                    }
                );

                expected.Add(
                    1120533763,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 1120533763,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7797869567083358d, b: 0.2361739464389747d, c: 0.48164557546500963d),

new NpgsqlTypes.NpgsqlLine(a: 0.9480048066554808d, b: 0.8035492224666504d, c: 0.9832497213764478d),

new NpgsqlTypes.NpgsqlLine(a: 0.9772596541640088d, b: 0.6093516798517065d, c: 0.6052760903401032d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1190383178,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 1190383178,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12466334172066618d, b: 0.11152073168077081d, c: 0.491230984381532d),

new NpgsqlTypes.NpgsqlLine(a: 0.5547266175262346d, b: 0.13792449594977796d, c: 0.7570674004021489d),

new NpgsqlTypes.NpgsqlLine(a: 0.2085058544453703d, b: 0.08290359377194412d, c: 0.77495272781113d),

new NpgsqlTypes.NpgsqlLine(a: 0.49111506712078934d, b: 0.641116986925848d, c: 0.29516341556351666d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07914996961984966d, b: 0.4871418257809952d, c: 0.7513322508300865d),

new NpgsqlTypes.NpgsqlLine(a: 0.9239635289951339d, b: 0.38794777551433746d, c: 0.676783160212782d),

new NpgsqlTypes.NpgsqlLine(a: 0.0955538255878925d, b: 0.01055236041931451d, c: 0.2842563281409253d),

new NpgsqlTypes.NpgsqlLine(a: 0.02927332855673237d, b: 0.6165842674891228d, c: 0.8012173905302888d),

}
                    }
                );

                expected.Add(
                    1264360862,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 1264360862,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3150738269575506d, b: 0.25723902915678687d, c: 0.7085220942560913d),

new NpgsqlTypes.NpgsqlLine(a: 0.10217399526832571d, b: 0.23606907248025677d, c: 0.14832581681823231d),

new NpgsqlTypes.NpgsqlLine(a: 0.38475783269574504d, b: 0.261674953378639d, c: 0.8414017715374641d),

new NpgsqlTypes.NpgsqlLine(a: 0.060969244577031345d, b: 0.7001282741779633d, c: 0.8180532031964253d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1272632761,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 1272632761,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8378269016529278d, b: 0.6733240332238696d, c: 0.8919506779863193d),

new NpgsqlTypes.NpgsqlLine(a: 0.48570634731194795d, b: 0.1596671151368555d, c: 0.20750860994967846d),

new NpgsqlTypes.NpgsqlLine(a: 0.779653513645174d, b: 0.8586337096501773d, c: 0.1738735269722934d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2675334980310755d, b: 0.5860654638502302d, c: 0.5223481489931099d),

new NpgsqlTypes.NpgsqlLine(a: 0.2908190505712529d, b: 0.027311571062217044d, c: 0.38897855152716554d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590347289639254d, b: 0.6110078502040162d, c: 0.9773066927065011d),

}
                    }
                );

                expected.Add(
                    1413412459,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 1413412459,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42503376733197573d, b: 0.763237079678654d, c: 0.09688502535476584d),

new NpgsqlTypes.NpgsqlLine(a: 0.23240822962655505d, b: 0.8459480271218152d, c: 0.08432931494869422d),

new NpgsqlTypes.NpgsqlLine(a: 0.18886663761414113d, b: 0.5079561486308892d, c: 0.9843388801596968d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1525343338,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 1525343338,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5334739519154116d, b: 0.14533927203574382d, c: 0.9972375896646379d),

new NpgsqlTypes.NpgsqlLine(a: 0.5376404385911305d, b: 0.3967355325520928d, c: 0.2690585850054501d),

new NpgsqlTypes.NpgsqlLine(a: 0.7930288640515465d, b: 0.4034090749439643d, c: 0.19977351395319798d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22585130451050572d, b: 0.054454055462575424d, c: 0.3670135684186787d),

new NpgsqlTypes.NpgsqlLine(a: 0.8573417118252535d, b: 0.7290365889192361d, c: 0.15771025911629288d),

new NpgsqlTypes.NpgsqlLine(a: 0.8294206137900973d, b: 0.778292553399524d, c: 0.5844131999897239d),

new NpgsqlTypes.NpgsqlLine(a: 0.8795242286168519d, b: 0.43336364459496624d, c: 0.07939237473054006d),

}
                    }
                );

                expected.Add(
                    2023967945,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 2023967945,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7526118185907706d, b: 0.7217192659741516d, c: 0.10725515353553927d),

new NpgsqlTypes.NpgsqlLine(a: 0.4123399872860949d, b: 0.9887632111198967d, c: 0.3407478138648996d),

new NpgsqlTypes.NpgsqlLine(a: 0.1972888611598902d, b: 0.21209298014251077d, c: 0.998100482656704d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32204440669620105d, b: 0.40425092983702615d, c: 0.6281187397686202d),

new NpgsqlTypes.NpgsqlLine(a: 0.8736370792109995d, b: 0.8257156419424208d, c: 0.24574228768788875d),

new NpgsqlTypes.NpgsqlLine(a: 0.1777372581271598d, b: 0.02795031420098848d, c: 0.6085263716794568d),

new NpgsqlTypes.NpgsqlLine(a: 0.3937718955623397d, b: 0.3857998777014512d, c: 0.16490107858931902d),

}
                    }
                );

                expected.Add(
                    2140414751,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 2140414751,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5666355568463651d, b: 0.5532657932652175d, c: 0.043303548850170626d),

new NpgsqlTypes.NpgsqlLine(a: 0.4900959494886681d, b: 0.9349750472343457d, c: 0.4121355471301291d),

new NpgsqlTypes.NpgsqlLine(a: 0.06398838318692368d, b: 0.028285739863693204d, c: 0.8052480125394759d),

new NpgsqlTypes.NpgsqlLine(a: 0.31673961185856914d, b: 0.4141587759463713d, c: 0.1893488396111126d),

},
                        NullableValue = null
                    }
                );

                var models =  ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                {
                    var expectEnumerValue = expectedModel.Value;
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
                if(expectedModel.NullableValue != null)
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expectedModel.NullableValue;
                        Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = model.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
                }
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Null);
                }


                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,NpgsqlLinelineArray2MI>(15);

                expected.Add(
                    111191550,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 111191550,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10079392481388938d, b: 0.47419284524344363d, c: 0.46999813598135487d),

new NpgsqlTypes.NpgsqlLine(a: 0.4512330545433114d, b: 0.7685777654216315d, c: 0.761484461621478d),

new NpgsqlTypes.NpgsqlLine(a: 0.7069502335832981d, b: 0.10867536284292001d, c: 0.803973548621565d),

new NpgsqlTypes.NpgsqlLine(a: 0.6710482193897285d, b: 0.3246300803211939d, c: 0.007931088387647223d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    116492752,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 116492752,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8534388679989421d, b: 0.17051639981163313d, c: 0.11184373953100968d),

new NpgsqlTypes.NpgsqlLine(a: 0.5545649696933802d, b: 0.6495249060333349d, c: 0.14480165352840013d),

new NpgsqlTypes.NpgsqlLine(a: 0.7068689700072772d, b: 0.10325704725403717d, c: 0.1383403540154834d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.565937691937727d, b: 0.8643068916219007d, c: 0.7899347881580714d),

new NpgsqlTypes.NpgsqlLine(a: 0.5461437063589625d, b: 0.8396992488239946d, c: 0.4549808859483121d),

new NpgsqlTypes.NpgsqlLine(a: 0.11142572920429805d, b: 0.7092154686109046d, c: 0.04531658445440445d),

new NpgsqlTypes.NpgsqlLine(a: 0.8590566964589479d, b: 0.07365357454587718d, c: 0.01783865983951749d),

}
                    }
                );

                expected.Add(
                    117280179,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 117280179,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3605977641294892d, b: 0.17811158147680461d, c: 0.9658058071756186d),

new NpgsqlTypes.NpgsqlLine(a: 0.6970256025820155d, b: 0.5444046414962291d, c: 0.46720686007108925d),

new NpgsqlTypes.NpgsqlLine(a: 0.8561050660597573d, b: 0.11353237597432853d, c: 0.56669941414895d),

new NpgsqlTypes.NpgsqlLine(a: 0.7984600619309864d, b: 0.8109151931011057d, c: 0.769305377302455d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0947306689172811d, b: 0.8302577671800684d, c: 0.8970532400118938d),

new NpgsqlTypes.NpgsqlLine(a: 0.2407748752003226d, b: 0.4567310255560061d, c: 0.4526792803927874d),

new NpgsqlTypes.NpgsqlLine(a: 0.04496104252758981d, b: 0.7589917027634498d, c: 0.6770421060059869d),

}
                    }
                );

                expected.Add(
                    196308953,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 196308953,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28578713252269017d, b: 0.8474368218362299d, c: 0.05146566977408318d),

new NpgsqlTypes.NpgsqlLine(a: 0.9109299616024349d, b: 0.5870141058904383d, c: 0.7452912896149598d),

new NpgsqlTypes.NpgsqlLine(a: 0.09671303857190205d, b: 0.22234046410281205d, c: 0.2889776640209598d),

new NpgsqlTypes.NpgsqlLine(a: 0.3594930797393622d, b: 0.1261117062789614d, c: 0.4836691385976134d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    322154126,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 322154126,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17316937563192347d, b: 0.7977878569807266d, c: 0.5061623155222499d),

new NpgsqlTypes.NpgsqlLine(a: 0.39020299771548206d, b: 0.46872469438895703d, c: 0.1947250961658502d),

new NpgsqlTypes.NpgsqlLine(a: 0.9460666899443665d, b: 0.40873002207057996d, c: 0.5383135596603867d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    632564420,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 632564420,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9871612756422758d, b: 0.7040000628939183d, c: 0.5741990515908977d),

new NpgsqlTypes.NpgsqlLine(a: 0.8939251170158339d, b: 0.591802460616856d, c: 0.8710953712464558d),

new NpgsqlTypes.NpgsqlLine(a: 0.925765879252592d, b: 0.020003653879282934d, c: 0.27174016206463947d),

new NpgsqlTypes.NpgsqlLine(a: 0.40821497810499396d, b: 0.18426353989680566d, c: 0.35762480728827095d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    723640790,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 723640790,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8545769023218451d, b: 0.24286566112974062d, c: 0.24373271509232275d),

new NpgsqlTypes.NpgsqlLine(a: 0.8731571462637403d, b: 0.9993617334238951d, c: 0.1725755360195571d),

new NpgsqlTypes.NpgsqlLine(a: 0.2467482163165423d, b: 0.7309207508122816d, c: 0.574326589073651d),

new NpgsqlTypes.NpgsqlLine(a: 0.39429370255535745d, b: 0.12918013405283635d, c: 0.37279548432778786d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8697103680615146d, b: 0.4868697197066526d, c: 0.008300202872866591d),

new NpgsqlTypes.NpgsqlLine(a: 0.9268152455195247d, b: 0.9945415027788427d, c: 0.33225561051564245d),

new NpgsqlTypes.NpgsqlLine(a: 0.06541514412119742d, b: 0.29832372565206444d, c: 0.34837671529944225d),

new NpgsqlTypes.NpgsqlLine(a: 0.7703107306167513d, b: 0.39150187650435253d, c: 0.17912768771478083d),

}
                    }
                );

                expected.Add(
                    1120533763,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 1120533763,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7797869567083358d, b: 0.2361739464389747d, c: 0.48164557546500963d),

new NpgsqlTypes.NpgsqlLine(a: 0.9480048066554808d, b: 0.8035492224666504d, c: 0.9832497213764478d),

new NpgsqlTypes.NpgsqlLine(a: 0.9772596541640088d, b: 0.6093516798517065d, c: 0.6052760903401032d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1190383178,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 1190383178,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12466334172066618d, b: 0.11152073168077081d, c: 0.491230984381532d),

new NpgsqlTypes.NpgsqlLine(a: 0.5547266175262346d, b: 0.13792449594977796d, c: 0.7570674004021489d),

new NpgsqlTypes.NpgsqlLine(a: 0.2085058544453703d, b: 0.08290359377194412d, c: 0.77495272781113d),

new NpgsqlTypes.NpgsqlLine(a: 0.49111506712078934d, b: 0.641116986925848d, c: 0.29516341556351666d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07914996961984966d, b: 0.4871418257809952d, c: 0.7513322508300865d),

new NpgsqlTypes.NpgsqlLine(a: 0.9239635289951339d, b: 0.38794777551433746d, c: 0.676783160212782d),

new NpgsqlTypes.NpgsqlLine(a: 0.0955538255878925d, b: 0.01055236041931451d, c: 0.2842563281409253d),

new NpgsqlTypes.NpgsqlLine(a: 0.02927332855673237d, b: 0.6165842674891228d, c: 0.8012173905302888d),

}
                    }
                );

                expected.Add(
                    1264360862,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 1264360862,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3150738269575506d, b: 0.25723902915678687d, c: 0.7085220942560913d),

new NpgsqlTypes.NpgsqlLine(a: 0.10217399526832571d, b: 0.23606907248025677d, c: 0.14832581681823231d),

new NpgsqlTypes.NpgsqlLine(a: 0.38475783269574504d, b: 0.261674953378639d, c: 0.8414017715374641d),

new NpgsqlTypes.NpgsqlLine(a: 0.060969244577031345d, b: 0.7001282741779633d, c: 0.8180532031964253d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1272632761,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 1272632761,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8378269016529278d, b: 0.6733240332238696d, c: 0.8919506779863193d),

new NpgsqlTypes.NpgsqlLine(a: 0.48570634731194795d, b: 0.1596671151368555d, c: 0.20750860994967846d),

new NpgsqlTypes.NpgsqlLine(a: 0.779653513645174d, b: 0.8586337096501773d, c: 0.1738735269722934d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2675334980310755d, b: 0.5860654638502302d, c: 0.5223481489931099d),

new NpgsqlTypes.NpgsqlLine(a: 0.2908190505712529d, b: 0.027311571062217044d, c: 0.38897855152716554d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590347289639254d, b: 0.6110078502040162d, c: 0.9773066927065011d),

}
                    }
                );

                expected.Add(
                    1413412459,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 1413412459,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42503376733197573d, b: 0.763237079678654d, c: 0.09688502535476584d),

new NpgsqlTypes.NpgsqlLine(a: 0.23240822962655505d, b: 0.8459480271218152d, c: 0.08432931494869422d),

new NpgsqlTypes.NpgsqlLine(a: 0.18886663761414113d, b: 0.5079561486308892d, c: 0.9843388801596968d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1525343338,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 1525343338,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5334739519154116d, b: 0.14533927203574382d, c: 0.9972375896646379d),

new NpgsqlTypes.NpgsqlLine(a: 0.5376404385911305d, b: 0.3967355325520928d, c: 0.2690585850054501d),

new NpgsqlTypes.NpgsqlLine(a: 0.7930288640515465d, b: 0.4034090749439643d, c: 0.19977351395319798d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22585130451050572d, b: 0.054454055462575424d, c: 0.3670135684186787d),

new NpgsqlTypes.NpgsqlLine(a: 0.8573417118252535d, b: 0.7290365889192361d, c: 0.15771025911629288d),

new NpgsqlTypes.NpgsqlLine(a: 0.8294206137900973d, b: 0.778292553399524d, c: 0.5844131999897239d),

new NpgsqlTypes.NpgsqlLine(a: 0.8795242286168519d, b: 0.43336364459496624d, c: 0.07939237473054006d),

}
                    }
                );

                expected.Add(
                    2023967945,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 2023967945,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7526118185907706d, b: 0.7217192659741516d, c: 0.10725515353553927d),

new NpgsqlTypes.NpgsqlLine(a: 0.4123399872860949d, b: 0.9887632111198967d, c: 0.3407478138648996d),

new NpgsqlTypes.NpgsqlLine(a: 0.1972888611598902d, b: 0.21209298014251077d, c: 0.998100482656704d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32204440669620105d, b: 0.40425092983702615d, c: 0.6281187397686202d),

new NpgsqlTypes.NpgsqlLine(a: 0.8736370792109995d, b: 0.8257156419424208d, c: 0.24574228768788875d),

new NpgsqlTypes.NpgsqlLine(a: 0.1777372581271598d, b: 0.02795031420098848d, c: 0.6085263716794568d),

new NpgsqlTypes.NpgsqlLine(a: 0.3937718955623397d, b: 0.3857998777014512d, c: 0.16490107858931902d),

}
                    }
                );

                expected.Add(
                    2140414751,
                    new NpgsqlLinelineArray2MI
                    {
                        Id = 2140414751,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5666355568463651d, b: 0.5532657932652175d, c: 0.043303548850170626d),

new NpgsqlTypes.NpgsqlLine(a: 0.4900959494886681d, b: 0.9349750472343457d, c: 0.4121355471301291d),

new NpgsqlTypes.NpgsqlLine(a: 0.06398838318692368d, b: 0.028285739863693204d, c: 0.8052480125394759d),

new NpgsqlTypes.NpgsqlLine(a: 0.31673961185856914d, b: 0.4141587759463713d, c: 0.1893488396111126d),

},
                        NullableValue = null
                    }
                );

                var models = await ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                {
                    var expectEnumerValue = expectedModel.Value;
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
                if(expectedModel.NullableValue != null)
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expectedModel.NullableValue;
                        Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = model.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
                }
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Null);
                }


                }
            }
        }

        #endregion

    }
}

