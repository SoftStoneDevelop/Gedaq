

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
    internal partial interface INpgsqlLineArraylineArray
    {
    }
    
    internal partial class NpgsqlLineArraylineArray : INpgsqlLineArraylineArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1mi(
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
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
INSERT INTO public.npgsqllinelinearray1mi(
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
            queryMapType: typeof(NpgsqlLinelineArray1MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
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

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModelInner(connection, 1935239880, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5125009420178407d, b: 0.13553866813087467d, c: 0.6573124881706722d),

new NpgsqlTypes.NpgsqlLine(a: 0.9315668534985179d, b: 0.031339976871202935d, c: 0.7319776155987312d),

new NpgsqlTypes.NpgsqlLine(a: 0.5913519522327184d, b: 0.688194613219936d, c: 0.7487303543444555d),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModelInner(connection, 313349652, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7148027863911385d, b: 0.4116315290140842d, c: 0.9883513693293022d),

new NpgsqlTypes.NpgsqlLine(a: 0.730798769811796d, b: 0.5625059295801093d, c: 0.028144945623879147d),

new NpgsqlTypes.NpgsqlLine(a: 0.7895921923207063d, b: 0.897092096080744d, c: 0.36804397804374556d),

new NpgsqlTypes.NpgsqlLine(a: 0.4403951364132078d, b: 0.48316034726668566d, c: 0.5561087583026281d),

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

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelInnerAsync(connection, 1888587968, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9441675468790086d, b: 0.10273087249159918d, c: 0.36496868371913627d),

new NpgsqlTypes.NpgsqlLine(a: 0.3153900895384264d, b: 0.8953921593705707d, c: 0.6821583482258307d),

new NpgsqlTypes.NpgsqlLine(a: 0.15884512105184567d, b: 0.20745599422324912d, c: 0.5928677501305737d),

new NpgsqlTypes.NpgsqlLine(a: 0.19203772899196803d, b: 0.9281999546867626d, c: 0.9792553764463741d),

}, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.616453689236877d, b: 0.26880075600348696d, c: 0.9911672578342802d),

new NpgsqlTypes.NpgsqlLine(a: 0.41598816366831615d, b: 0.2972198032481773d, c: 0.6096249065094251d),

new NpgsqlTypes.NpgsqlLine(a: 0.21461782395965212d, b: 0.4996081675192614d, c: 0.845029551763019d),

new NpgsqlTypes.NpgsqlLine(a: 0.14603833144353173d, b: 0.5155958582129082d, c: 0.9513100476397736d),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelInnerAsync(connection, 2052209240, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28682097488067404d, b: 0.19347953745544d, c: 0.767001580247448d),

new NpgsqlTypes.NpgsqlLine(a: 0.34168929191792363d, b: 0.5324263819109204d, c: 0.3548736591683712d),

new NpgsqlTypes.NpgsqlLine(a: 0.7601584215479089d, b: 0.9667193856859281d, c: 0.48805620341333844d),

new NpgsqlTypes.NpgsqlLine(a: 0.4778030273140724d, b: 0.6459214140044727d, c: 0.9825570138966864d),

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

                id =  ((INpgsqlLineArraylineArray)this).InsertModelInnerReturning(connection, 699428708, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.75437435623167d, b: 0.4381969103973332d, c: 0.13859938549471296d),

new NpgsqlTypes.NpgsqlLine(a: 0.22478326045746155d, b: 0.7927996319630696d, c: 0.5653146543488808d),

new NpgsqlTypes.NpgsqlLine(a: 0.8148660813324691d, b: 0.5965502974097225d, c: 0.08598406767552191d),

new NpgsqlTypes.NpgsqlLine(a: 0.10261855436837408d, b: 0.22753843400620033d, c: 0.6663050101504865d),

}, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19047502268477823d, b: 0.503647750986701d, c: 0.5140837344549085d),

new NpgsqlTypes.NpgsqlLine(a: 0.5498279015442291d, b: 0.5205498180433044d, c: 0.5511400439881968d),

new NpgsqlTypes.NpgsqlLine(a: 0.07519565206915457d, b: 0.8190939422278946d, c: 0.4842243543091963d),

new NpgsqlTypes.NpgsqlLine(a: 0.11151345358207676d, b: 0.2794260095615846d, c: 0.1977999861392018d),

});
                Assert.That(id, Is.EqualTo(699428708));

                id =  ((INpgsqlLineArraylineArray)this).InsertModelInnerReturning(connection, 160844459, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.49742066568592347d, b: 0.13045995730850435d, c: 0.3240701079822569d),

new NpgsqlTypes.NpgsqlLine(a: 0.4230136983146885d, b: 0.4758823758243249d, c: 0.7245296150407883d),

new NpgsqlTypes.NpgsqlLine(a: 0.902525000709505d, b: 0.3096633545847971d, c: 0.7195095860492445d),

}, null);
                Assert.That(id, Is.EqualTo(160844459));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, 1803941428, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4958174274877982d, b: 0.19935005698584918d, c: 0.6570481803156852d),

new NpgsqlTypes.NpgsqlLine(a: 0.586031122116916d, b: 0.20438200508300097d, c: 0.7214279726394314d),

new NpgsqlTypes.NpgsqlLine(a: 0.3287771922455527d, b: 0.31464931534195395d, c: 0.49275260904707807d),

}, null);
                Assert.That(id, Is.EqualTo(1803941428));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, 1349638635, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8811777097968191d, b: 0.09805743628781294d, c: 0.8476023389336619d),

new NpgsqlTypes.NpgsqlLine(a: 0.16329696312104391d, b: 0.8434248077846473d, c: 0.0171626874853823d),

new NpgsqlTypes.NpgsqlLine(a: 0.5930114320798587d, b: 0.7874763150232159d, c: 0.20169365861720767d),

}, null);
                Assert.That(id, Is.EqualTo(1349638635));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, 1743101311, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30049737151744216d, b: 0.10935998965187232d, c: 0.12002566064851483d),

new NpgsqlTypes.NpgsqlLine(a: 0.4579983959880112d, b: 0.8700234892072651d, c: 0.24545341370685325d),

new NpgsqlTypes.NpgsqlLine(a: 0.6992061752442d, b: 0.8760611086508132d, c: 0.31896424715232463d),

}, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14975557199832845d, b: 0.8649037801511367d, c: 0.8035067258718913d),

new NpgsqlTypes.NpgsqlLine(a: 0.022767088770272226d, b: 0.824519829812387d, c: 0.2990170967826957d),

new NpgsqlTypes.NpgsqlLine(a: 0.264229467978496d, b: 0.4707396384081288d, c: 0.5870444614457326d),

});
                Assert.That(id, Is.EqualTo(1743101311));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, 871029693, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09314286666835214d, b: 0.9419395542104619d, c: 0.23265001920909978d),

new NpgsqlTypes.NpgsqlLine(a: 0.7840922282915723d, b: 0.8769622177219351d, c: 0.08844919095146764d),

new NpgsqlTypes.NpgsqlLine(a: 0.30172065868559383d, b: 0.061796126836928256d, c: 0.7819510380905712d),

}, null);
                Assert.That(id, Is.EqualTo(871029693));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, 671378680, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.579485378096583d, b: 0.7644192687968542d, c: 0.38803543767659376d),

new NpgsqlTypes.NpgsqlLine(a: 0.9272224559192928d, b: 0.04309922869802718d, c: 0.1084146589578524d),

new NpgsqlTypes.NpgsqlLine(a: 0.6194396921461146d, b: 0.3135327751395446d, c: 0.47728859432318693d),

}, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22238461731837955d, b: 0.8832575247518029d, c: 0.5267192016109244d),

new NpgsqlTypes.NpgsqlLine(a: 0.2456814921559901d, b: 0.12396858431218405d, c: 0.7758983059785806d),

new NpgsqlTypes.NpgsqlLine(a: 0.8010355013907535d, b: 0.10724380078506457d, c: 0.8516226142927568d),

});
                Assert.That(id, Is.EqualTo(671378680));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, 507016837, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6329641939546133d, b: 0.7713358064075255d, c: 0.7091675230581173d),

new NpgsqlTypes.NpgsqlLine(a: 0.6401104534145889d, b: 0.4461488045009705d, c: 0.8050604324576476d),

new NpgsqlTypes.NpgsqlLine(a: 0.718200194405203d, b: 0.43497844061299695d, c: 0.8863292600245054d),

new NpgsqlTypes.NpgsqlLine(a: 0.6409377372303063d, b: 0.6727026439221405d, c: 0.709162570856183d),

}, null);
                Assert.That(id, Is.EqualTo(507016837));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, 2000087272, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5174417835536576d, b: 0.9550151039410834d, c: 0.94465021980697d),

new NpgsqlTypes.NpgsqlLine(a: 0.023498567205728516d, b: 0.14704570142511664d, c: 0.5436176118381062d),

new NpgsqlTypes.NpgsqlLine(a: 0.6410825125912296d, b: 0.1638519482392854d, c: 0.07442290044208977d),

new NpgsqlTypes.NpgsqlLine(a: 0.5684954410076702d, b: 0.9517870324925599d, c: 0.7913121037671743d),

}, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5546781844769255d, b: 0.3295435210405563d, c: 0.10332785525555d),

new NpgsqlTypes.NpgsqlLine(a: 0.8619184029547027d, b: 0.6893143841340763d, c: 0.6057919377815917d),

new NpgsqlTypes.NpgsqlLine(a: 0.6918049340506819d, b: 0.29564467871458977d, c: 0.373851052320022d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590711543927416d, b: 0.782456230485786d, c: 0.0557514543823312d),

});
                Assert.That(id, Is.EqualTo(2000087272));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, 259689541, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16915141278580792d, b: 0.5107686791340034d, c: 0.6489920882506348d),

new NpgsqlTypes.NpgsqlLine(a: 0.030879513236027d, b: 0.6401283771223818d, c: 0.4904762444562075d),

new NpgsqlTypes.NpgsqlLine(a: 0.16124954101586042d, b: 0.7102870300472969d, c: 0.9978682907813775d),

}, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3413197342637151d, b: 0.3564754218301692d, c: 0.16698356005321802d),

new NpgsqlTypes.NpgsqlLine(a: 0.24996465538547474d, b: 0.6936235099874405d, c: 0.00768766971096424d),

new NpgsqlTypes.NpgsqlLine(a: 0.9713834412198872d, b: 0.1937685310996965d, c: 0.5638524218711839d),

new NpgsqlTypes.NpgsqlLine(a: 0.20790035052620326d, b: 0.7280555648340241d, c: 0.7150389111804211d),

});
                Assert.That(id, Is.EqualTo(259689541));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, 681877477, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.054876749435908034d, b: 0.7476698065656858d, c: 0.5221215501493097d),

new NpgsqlTypes.NpgsqlLine(a: 0.1689911006864584d, b: 0.16032672190790076d, c: 0.9537953031702238d),

new NpgsqlTypes.NpgsqlLine(a: 0.3133690487713232d, b: 0.21425817972116357d, c: 0.39002508371565625d),

}, null);
                Assert.That(id, Is.EqualTo(681877477));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray1mi_id", 
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

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModel(connection, 24431063, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7432562260700321d, b: 0.9027051106351455d, c: 0.20935776301702913d),

new NpgsqlTypes.NpgsqlLine(a: 0.06877648068052133d, b: 0.4638520424251973d, c: 0.8977581074629934d),

new NpgsqlTypes.NpgsqlLine(a: 0.19824889810271595d, b: 0.101805635004653d, c: 0.6376796129171594d),

}, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.25692356453649523d, b: 0.8249956321761069d, c: 0.7485760418256393d),

new NpgsqlTypes.NpgsqlLine(a: 0.5205543536927003d, b: 0.26409313743898866d, c: 0.11834223656249432d),

new NpgsqlTypes.NpgsqlLine(a: 0.12852097087774939d, b: 0.110468841038458d, c: 0.15781368742463253d),

new NpgsqlTypes.NpgsqlLine(a: 0.5056691167374713d, b: 0.17475361978672044d, c: 0.4301177356479713d),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModel(connection, 447065450, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6636554004535458d, b: 0.4052905058278198d, c: 0.17999403534412883d),

new NpgsqlTypes.NpgsqlLine(a: 0.4929643299593621d, b: 0.04102771738828992d, c: 0.8758588440576921d),

new NpgsqlTypes.NpgsqlLine(a: 0.9843591359807438d, b: 0.9486545770421181d, c: 0.23810538982780194d),

new NpgsqlTypes.NpgsqlLine(a: 0.0373504814930844d, b: 0.29650224807426506d, c: 0.6527517869517908d),

}, null, 1935239880);
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

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelAsync(connection, 929385902, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8285395037487209d, b: 0.25070273066629d, c: 0.2500673109161923d),

new NpgsqlTypes.NpgsqlLine(a: 0.9942717530143405d, b: 0.21539215026712022d, c: 0.20269945939501077d),

new NpgsqlTypes.NpgsqlLine(a: 0.7979702358088475d, b: 0.0037115614378556705d, c: 0.8843432168677479d),

}, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1456202870910711d, b: 0.06772665910903597d, c: 0.691750610472359d),

new NpgsqlTypes.NpgsqlLine(a: 0.765757989281042d, b: 0.32982835634782004d, c: 0.8913701807765988d),

new NpgsqlTypes.NpgsqlLine(a: 0.052240732409688406d, b: 0.618262798295761d, c: 0.8474290495942781d),

new NpgsqlTypes.NpgsqlLine(a: 0.3584922315949717d, b: 0.520574773115294d, c: 0.8310230234204736d),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelAsync(connection, 1247961184, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588334999708729d, b: 0.5781258655739143d, c: 0.4951203893647069d),

new NpgsqlTypes.NpgsqlLine(a: 0.206651781249944d, b: 0.9214488824097644d, c: 0.7102197735978709d),

new NpgsqlTypes.NpgsqlLine(a: 0.8293873017859008d, b: 0.4197388618664637d, c: 0.7538628331143343d),

}, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9886122302398814d, b: 0.09733443476141157d, c: 0.8828756753279827d),

new NpgsqlTypes.NpgsqlLine(a: 0.4191781730328399d, b: 0.8360940579259326d, c: 0.3115604346093266d),

new NpgsqlTypes.NpgsqlLine(a: 0.03123256692948395d, b: 0.4210178852779579d, c: 0.7083559364281564d),

new NpgsqlTypes.NpgsqlLine(a: 0.10193811062121638d, b: 0.7865607707379441d, c: 0.5102014504618864d),

}, 313349652);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;

                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, 776647699, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8841755970938628d, b: 0.039993263617271846d, c: 0.2425222413816407d),

new NpgsqlTypes.NpgsqlLine(a: 0.3162669055857611d, b: 0.1360654949714053d, c: 0.585066125260232d),

new NpgsqlTypes.NpgsqlLine(a: 0.23614085233198578d, b: 0.9624524908146396d, c: 0.8036122013629919d),

new NpgsqlTypes.NpgsqlLine(a: 0.9594786748108928d, b: 0.3334512033062713d, c: 0.8626799508985245d),

}, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7692177568154062d, b: 0.8045212370680859d, c: 0.347836807601842d),

new NpgsqlTypes.NpgsqlLine(a: 0.8596806867272218d, b: 0.42225206488490163d, c: 0.2626771759427945d),

new NpgsqlTypes.NpgsqlLine(a: 0.6334601490046422d, b: 0.5508277640730257d, c: 0.9702039181027914d),

new NpgsqlTypes.NpgsqlLine(a: 0.7862671596820799d, b: 0.6148121550149941d, c: 0.10467782441316142d),

}, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7692177568154062d, b: 0.8045212370680859d, c: 0.347836807601842d),

new NpgsqlTypes.NpgsqlLine(a: 0.8596806867272218d, b: 0.42225206488490163d, c: 0.2626771759427945d),

new NpgsqlTypes.NpgsqlLine(a: 0.6334601490046422d, b: 0.5508277640730257d, c: 0.9702039181027914d),

new NpgsqlTypes.NpgsqlLine(a: 0.7862671596820799d, b: 0.6148121550149941d, c: 0.10467782441316142d),

}));

                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, 1485177216, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7620135774845544d, b: 0.72234986247445d, c: 0.7900958363555012d),

new NpgsqlTypes.NpgsqlLine(a: 0.5982892074823093d, b: 0.9157569165822279d, c: 0.5913666560112503d),

new NpgsqlTypes.NpgsqlLine(a: 0.3694255096703286d, b: 0.43689654039349735d, c: 0.27488642071951885d),

}, null, 1888587968);

                Assert.That(nullable, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;

                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, 1278639929, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8637991908928382d, b: 0.7989476928355281d, c: 0.047074497669961635d),

new NpgsqlTypes.NpgsqlLine(a: 0.24284327761860214d, b: 0.034845279321367495d, c: 0.8243144068858446d),

new NpgsqlTypes.NpgsqlLine(a: 0.2705173386529084d, b: 0.37759514414776285d, c: 0.003784057263189533d),

}, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5464646368268954d, b: 0.1698011067851829d, c: 0.4811896051504386d),

new NpgsqlTypes.NpgsqlLine(a: 0.3264558304845737d, b: 0.09741548986796533d, c: 0.35078408755418944d),

new NpgsqlTypes.NpgsqlLine(a: 0.1253849539183054d, b: 0.9184504405667023d, c: 0.6244095303662431d),

}, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5464646368268954d, b: 0.1698011067851829d, c: 0.4811896051504386d),

new NpgsqlTypes.NpgsqlLine(a: 0.3264558304845737d, b: 0.09741548986796533d, c: 0.35078408755418944d),

new NpgsqlTypes.NpgsqlLine(a: 0.1253849539183054d, b: 0.9184504405667023d, c: 0.6244095303662431d),

}));

                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, 1352296160, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6961581521563707d, b: 0.2870425810465653d, c: 0.022813771410836625d),

new NpgsqlTypes.NpgsqlLine(a: 0.9289180434806266d, b: 0.10310192777053839d, c: 0.4974840036652155d),

new NpgsqlTypes.NpgsqlLine(a: 0.9742618124298718d, b: 0.666155889593685d, c: 0.9108800941033853d),

new NpgsqlTypes.NpgsqlLine(a: 0.4076993728994177d, b: 0.9237619110159688d, c: 0.16349574316883708d),

}, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.40245830157937157d, b: 0.4425237993192568d, c: 0.3605907953188545d),

new NpgsqlTypes.NpgsqlLine(a: 0.3025387755185438d, b: 0.16175616826033246d, c: 0.08369914886846197d),

new NpgsqlTypes.NpgsqlLine(a: 0.7932786053551402d, b: 0.4757892941852452d, c: 0.35215963103511483d),

}, 2052209240);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.40245830157937157d, b: 0.4425237993192568d, c: 0.3605907953188545d),

new NpgsqlTypes.NpgsqlLine(a: 0.3025387755185438d, b: 0.16175616826033246d, c: 0.08369914886846197d),

new NpgsqlTypes.NpgsqlLine(a: 0.7932786053551402d, b: 0.4757892941852452d, c: 0.35215963103511483d),

}));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(NpgsqlLinelineArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray1mi_id", 
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
                List<NpgsqlLinelineArray1M> models = null;
                NpgsqlLinelineArray1M model = null;

                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, 939691488, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15928813769803307d, b: 0.5335096410959914d, c: 0.9693141891385088d),

new NpgsqlTypes.NpgsqlLine(a: 0.9448241901930845d, b: 0.6287076527827521d, c: 0.6660617468801671d),

new NpgsqlTypes.NpgsqlLine(a: 0.30712778702622445d, b: 0.324942912367581d, c: 0.9500282198259326d),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(939691488));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15928813769803307d, b: 0.5335096410959914d, c: 0.9693141891385088d),

new NpgsqlTypes.NpgsqlLine(a: 0.9448241901930845d, b: 0.6287076527827521d, c: 0.6660617468801671d),

new NpgsqlTypes.NpgsqlLine(a: 0.30712778702622445d, b: 0.324942912367581d, c: 0.9500282198259326d),

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

                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, 1765269457, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4428210775962541d, b: 0.44628545865868685d, c: 0.7913435097925557d),

new NpgsqlTypes.NpgsqlLine(a: 0.26419018627718516d, b: 0.12166427922453704d, c: 0.11250832552770584d),

new NpgsqlTypes.NpgsqlLine(a: 0.20276585628171784d, b: 0.14489314174625478d, c: 0.5410582863519566d),

}, null, 699428708).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1765269457));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4428210775962541d, b: 0.44628545865868685d, c: 0.7913435097925557d),

new NpgsqlTypes.NpgsqlLine(a: 0.26419018627718516d, b: 0.12166427922453704d, c: 0.11250832552770584d),

new NpgsqlTypes.NpgsqlLine(a: 0.20276585628171784d, b: 0.14489314174625478d, c: 0.5410582863519566d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(699428708));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlLine[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, 1251267268, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.27064576558959075d, b: 0.24611103650290955d, c: 0.04928435530376152d),

new NpgsqlTypes.NpgsqlLine(a: 0.5382620257248645d, b: 0.586731968734226d, c: 0.9110741668368397d),

new NpgsqlTypes.NpgsqlLine(a: 0.8386954216871374d, b: 0.14045527908308764d, c: 0.5300328684198944d),

}, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7572326327773035d, b: 0.10039993499818312d, c: 0.17339739029118428d),

new NpgsqlTypes.NpgsqlLine(a: 0.9566618331567527d, b: 0.14668861402647748d, c: 0.7767711369985796d),

new NpgsqlTypes.NpgsqlLine(a: 0.932727244163919d, b: 0.12159065636952726d, c: 0.1704609096711438d),

new NpgsqlTypes.NpgsqlLine(a: 0.5792460825794749d, b: 0.985437582839235d, c: 0.557473090399633d),

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1251267268));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.27064576558959075d, b: 0.24611103650290955d, c: 0.04928435530376152d),

new NpgsqlTypes.NpgsqlLine(a: 0.5382620257248645d, b: 0.586731968734226d, c: 0.9110741668368397d),

new NpgsqlTypes.NpgsqlLine(a: 0.8386954216871374d, b: 0.14045527908308764d, c: 0.5300328684198944d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7572326327773035d, b: 0.10039993499818312d, c: 0.17339739029118428d),

new NpgsqlTypes.NpgsqlLine(a: 0.9566618331567527d, b: 0.14668861402647748d, c: 0.7767711369985796d),

new NpgsqlTypes.NpgsqlLine(a: 0.932727244163919d, b: 0.12159065636952726d, c: 0.1704609096711438d),

new NpgsqlTypes.NpgsqlLine(a: 0.5792460825794749d, b: 0.985437582839235d, c: 0.557473090399633d),

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

                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, 214898413, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7273918164372143d, b: 0.3711769692436181d, c: 0.7468659136792664d),

new NpgsqlTypes.NpgsqlLine(a: 0.8155250372031967d, b: 0.5364157660240247d, c: 0.2587745327315204d),

new NpgsqlTypes.NpgsqlLine(a: 0.8823774478354753d, b: 0.24032876435579376d, c: 0.9187231882533503d),

new NpgsqlTypes.NpgsqlLine(a: 0.2761563267007917d, b: 0.8609521972165307d, c: 0.014350256291767893d),

}, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7060914743005817d, b: 0.29942700622480667d, c: 0.38464564338188945d),

new NpgsqlTypes.NpgsqlLine(a: 0.456801666295529d, b: 0.2750050419905442d, c: 0.6523990372650718d),

new NpgsqlTypes.NpgsqlLine(a: 0.593068234761201d, b: 0.986042625015402d, c: 0.7722918655162653d),

new NpgsqlTypes.NpgsqlLine(a: 0.8257270425360131d, b: 0.9234733383976109d, c: 0.16399605960296715d),

}, 160844459).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(214898413));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7273918164372143d, b: 0.3711769692436181d, c: 0.7468659136792664d),

new NpgsqlTypes.NpgsqlLine(a: 0.8155250372031967d, b: 0.5364157660240247d, c: 0.2587745327315204d),

new NpgsqlTypes.NpgsqlLine(a: 0.8823774478354753d, b: 0.24032876435579376d, c: 0.9187231882533503d),

new NpgsqlTypes.NpgsqlLine(a: 0.2761563267007917d, b: 0.8609521972165307d, c: 0.014350256291767893d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7060914743005817d, b: 0.29942700622480667d, c: 0.38464564338188945d),

new NpgsqlTypes.NpgsqlLine(a: 0.456801666295529d, b: 0.2750050419905442d, c: 0.6523990372650718d),

new NpgsqlTypes.NpgsqlLine(a: 0.593068234761201d, b: 0.986042625015402d, c: 0.7722918655162653d),

new NpgsqlTypes.NpgsqlLine(a: 0.8257270425360131d, b: 0.9234733383976109d, c: 0.16399605960296715d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(160844459));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlLine[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray1M> models = null;
                NpgsqlLinelineArray1M model = null;

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, 232426060, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7754569347332767d, b: 0.7449423603392903d, c: 0.7275357910733291d),

new NpgsqlTypes.NpgsqlLine(a: 0.9072872865290874d, b: 0.5188651109794405d, c: 0.49767196437474315d),

new NpgsqlTypes.NpgsqlLine(a: 0.7613773478086597d, b: 0.8726134777514618d, c: 0.7249287737318102d),

new NpgsqlTypes.NpgsqlLine(a: 0.31979325488547383d, b: 0.21963013317369884d, c: 0.995747479981123d),

}, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5136334997132156d, b: 0.4481836733144653d, c: 0.5566013930940901d),

new NpgsqlTypes.NpgsqlLine(a: 0.2628604279970359d, b: 0.34706683348460354d, c: 0.8618758810041756d),

new NpgsqlTypes.NpgsqlLine(a: 0.9066993846202163d, b: 0.9919335952888788d, c: 0.16647553451680086d),

new NpgsqlTypes.NpgsqlLine(a: 0.8084713734948656d, b: 0.9105928653749232d, c: 0.5871692331069964d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(232426060));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7754569347332767d, b: 0.7449423603392903d, c: 0.7275357910733291d),

new NpgsqlTypes.NpgsqlLine(a: 0.9072872865290874d, b: 0.5188651109794405d, c: 0.49767196437474315d),

new NpgsqlTypes.NpgsqlLine(a: 0.7613773478086597d, b: 0.8726134777514618d, c: 0.7249287737318102d),

new NpgsqlTypes.NpgsqlLine(a: 0.31979325488547383d, b: 0.21963013317369884d, c: 0.995747479981123d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5136334997132156d, b: 0.4481836733144653d, c: 0.5566013930940901d),

new NpgsqlTypes.NpgsqlLine(a: 0.2628604279970359d, b: 0.34706683348460354d, c: 0.8618758810041756d),

new NpgsqlTypes.NpgsqlLine(a: 0.9066993846202163d, b: 0.9919335952888788d, c: 0.16647553451680086d),

new NpgsqlTypes.NpgsqlLine(a: 0.8084713734948656d, b: 0.9105928653749232d, c: 0.5871692331069964d),

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

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, 1612037280, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9755688560619167d, b: 0.7517347444178538d, c: 0.4433097656621017d),

new NpgsqlTypes.NpgsqlLine(a: 0.27642151559126893d, b: 0.49560032188535075d, c: 0.4017019854911661d),

new NpgsqlTypes.NpgsqlLine(a: 0.48234378585453686d, b: 0.5838608048706788d, c: 0.45264440736135125d),

}, null, 1803941428).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1612037280));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9755688560619167d, b: 0.7517347444178538d, c: 0.4433097656621017d),

new NpgsqlTypes.NpgsqlLine(a: 0.27642151559126893d, b: 0.49560032188535075d, c: 0.4017019854911661d),

new NpgsqlTypes.NpgsqlLine(a: 0.48234378585453686d, b: 0.5838608048706788d, c: 0.45264440736135125d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1803941428));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlLine[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, 1422030401, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5508950376990435d, b: 0.1842011543506923d, c: 0.7200839172656331d),

new NpgsqlTypes.NpgsqlLine(a: 0.08098131741133519d, b: 0.2512744482896645d, c: 0.4419893154281408d),

new NpgsqlTypes.NpgsqlLine(a: 0.7183180834237055d, b: 0.3821225061156569d, c: 0.320010478004808d),

}, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.605461690855222d, b: 0.5098249599693536d, c: 0.049446338505273246d),

new NpgsqlTypes.NpgsqlLine(a: 0.6383133050473475d, b: 0.5385834180776717d, c: 0.2612256906158803d),

new NpgsqlTypes.NpgsqlLine(a: 0.2259744218921168d, b: 0.0504022254415285d, c: 0.5085817881315488d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1422030401));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5508950376990435d, b: 0.1842011543506923d, c: 0.7200839172656331d),

new NpgsqlTypes.NpgsqlLine(a: 0.08098131741133519d, b: 0.2512744482896645d, c: 0.4419893154281408d),

new NpgsqlTypes.NpgsqlLine(a: 0.7183180834237055d, b: 0.3821225061156569d, c: 0.320010478004808d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.605461690855222d, b: 0.5098249599693536d, c: 0.049446338505273246d),

new NpgsqlTypes.NpgsqlLine(a: 0.6383133050473475d, b: 0.5385834180776717d, c: 0.2612256906158803d),

new NpgsqlTypes.NpgsqlLine(a: 0.2259744218921168d, b: 0.0504022254415285d, c: 0.5085817881315488d),

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

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, 1441068318, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04431673188157559d, b: 0.7118895502319815d, c: 0.8045459394080527d),

new NpgsqlTypes.NpgsqlLine(a: 0.41883883343441664d, b: 0.0856133325697227d, c: 0.45940150990219364d),

new NpgsqlTypes.NpgsqlLine(a: 0.3845455332415372d, b: 0.5278908004707358d, c: 0.45211852173959755d),

new NpgsqlTypes.NpgsqlLine(a: 0.707344526938849d, b: 0.2664835051263448d, c: 0.8012907013628192d),

}, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5167014945187821d, b: 0.2318523474732329d, c: 0.0766480392056259d),

new NpgsqlTypes.NpgsqlLine(a: 0.6239339834043951d, b: 0.4407650281616141d, c: 0.07711199216030074d),

new NpgsqlTypes.NpgsqlLine(a: 0.7330247230488705d, b: 0.06195929907587139d, c: 0.1736910797965654d),

new NpgsqlTypes.NpgsqlLine(a: 0.5060985759956755d, b: 0.12918142066992122d, c: 0.3598502037154421d),

}, 1349638635).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1441068318));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04431673188157559d, b: 0.7118895502319815d, c: 0.8045459394080527d),

new NpgsqlTypes.NpgsqlLine(a: 0.41883883343441664d, b: 0.0856133325697227d, c: 0.45940150990219364d),

new NpgsqlTypes.NpgsqlLine(a: 0.3845455332415372d, b: 0.5278908004707358d, c: 0.45211852173959755d),

new NpgsqlTypes.NpgsqlLine(a: 0.707344526938849d, b: 0.2664835051263448d, c: 0.8012907013628192d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5167014945187821d, b: 0.2318523474732329d, c: 0.0766480392056259d),

new NpgsqlTypes.NpgsqlLine(a: 0.6239339834043951d, b: 0.4407650281616141d, c: 0.07711199216030074d),

new NpgsqlTypes.NpgsqlLine(a: 0.7330247230488705d, b: 0.06195929907587139d, c: 0.1736910797965654d),

new NpgsqlTypes.NpgsqlLine(a: 0.5060985759956755d, b: 0.12918142066992122d, c: 0.3598502037154421d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1349638635));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlLine[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, 1694903385, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5133551130062282d, b: 0.5981369379522861d, c: 0.5856516805262975d),

new NpgsqlTypes.NpgsqlLine(a: 0.4556255479239121d, b: 0.059243842569019045d, c: 0.18272228811839042d),

new NpgsqlTypes.NpgsqlLine(a: 0.8085308768004308d, b: 0.8348590541320315d, c: 0.5895099353964641d),

new NpgsqlTypes.NpgsqlLine(a: 0.24149968696186774d, b: 0.35557480082622506d, c: 0.5451461752136405d),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1694903385));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5133551130062282d, b: 0.5981369379522861d, c: 0.5856516805262975d),

new NpgsqlTypes.NpgsqlLine(a: 0.4556255479239121d, b: 0.059243842569019045d, c: 0.18272228811839042d),

new NpgsqlTypes.NpgsqlLine(a: 0.8085308768004308d, b: 0.8348590541320315d, c: 0.5895099353964641d),

new NpgsqlTypes.NpgsqlLine(a: 0.24149968696186774d, b: 0.35557480082622506d, c: 0.5451461752136405d),

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

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, 1749272119, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48465570613062037d, b: 0.4077570571696034d, c: 0.09124205112015671d),

new NpgsqlTypes.NpgsqlLine(a: 0.4905692123673753d, b: 0.09753381316271936d, c: 0.6219861110019185d),

new NpgsqlTypes.NpgsqlLine(a: 0.7715584772299492d, b: 0.7647042738214676d, c: 0.32981711302760286d),

new NpgsqlTypes.NpgsqlLine(a: 0.7826950107361046d, b: 0.6159017458991703d, c: 0.8761288210787351d),

}, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05854830086605134d, b: 0.4584727830793912d, c: 0.6485776355671607d),

new NpgsqlTypes.NpgsqlLine(a: 0.057402368952540694d, b: 0.814338567877536d, c: 0.36045674525095406d),

new NpgsqlTypes.NpgsqlLine(a: 0.4609921668504162d, b: 0.45446719793916357d, c: 0.6647833262693906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8421363107491464d, b: 0.8724917366553757d, c: 0.2954174236384989d),

}, 1743101311).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1749272119));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48465570613062037d, b: 0.4077570571696034d, c: 0.09124205112015671d),

new NpgsqlTypes.NpgsqlLine(a: 0.4905692123673753d, b: 0.09753381316271936d, c: 0.6219861110019185d),

new NpgsqlTypes.NpgsqlLine(a: 0.7715584772299492d, b: 0.7647042738214676d, c: 0.32981711302760286d),

new NpgsqlTypes.NpgsqlLine(a: 0.7826950107361046d, b: 0.6159017458991703d, c: 0.8761288210787351d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05854830086605134d, b: 0.4584727830793912d, c: 0.6485776355671607d),

new NpgsqlTypes.NpgsqlLine(a: 0.057402368952540694d, b: 0.814338567877536d, c: 0.36045674525095406d),

new NpgsqlTypes.NpgsqlLine(a: 0.4609921668504162d, b: 0.45446719793916357d, c: 0.6647833262693906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8421363107491464d, b: 0.8724917366553757d, c: 0.2954174236384989d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743101311));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlLine[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, 425879955, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7120720914880876d, b: 0.12018496532744738d, c: 0.23458035596972604d),

new NpgsqlTypes.NpgsqlLine(a: 0.8966943482850258d, b: 0.35901938172619774d, c: 0.5153333646331681d),

new NpgsqlTypes.NpgsqlLine(a: 0.772529205234202d, b: 0.3302141544038909d, c: 0.49860223574471696d),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(425879955));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7120720914880876d, b: 0.12018496532744738d, c: 0.23458035596972604d),

new NpgsqlTypes.NpgsqlLine(a: 0.8966943482850258d, b: 0.35901938172619774d, c: 0.5153333646331681d),

new NpgsqlTypes.NpgsqlLine(a: 0.772529205234202d, b: 0.3302141544038909d, c: 0.49860223574471696d),

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

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, 1708194464, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21378574042766885d, b: 0.22474127876321393d, c: 0.01286635194062602d),

new NpgsqlTypes.NpgsqlLine(a: 0.44720527497131246d, b: 0.83386820783986d, c: 0.47600740851603984d),

new NpgsqlTypes.NpgsqlLine(a: 0.9177345103701179d, b: 0.8135674766115204d, c: 0.23923291716083794d),

new NpgsqlTypes.NpgsqlLine(a: 0.9998743487003019d, b: 0.013427841900149451d, c: 0.9133209978570025d),

}, null, 871029693).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1708194464));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21378574042766885d, b: 0.22474127876321393d, c: 0.01286635194062602d),

new NpgsqlTypes.NpgsqlLine(a: 0.44720527497131246d, b: 0.83386820783986d, c: 0.47600740851603984d),

new NpgsqlTypes.NpgsqlLine(a: 0.9177345103701179d, b: 0.8135674766115204d, c: 0.23923291716083794d),

new NpgsqlTypes.NpgsqlLine(a: 0.9998743487003019d, b: 0.013427841900149451d, c: 0.9133209978570025d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(871029693));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlLine[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, 956171576, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6305558129660189d, b: 0.5463622939629917d, c: 0.401891977997777d),

new NpgsqlTypes.NpgsqlLine(a: 0.3662230087345998d, b: 0.4302679455886196d, c: 0.9631184941583132d),

new NpgsqlTypes.NpgsqlLine(a: 0.3634906094993412d, b: 0.18046820180120404d, c: 0.5193725822662353d),

}, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48533853922222536d, b: 0.7781157007327932d, c: 0.20671476643143427d),

new NpgsqlTypes.NpgsqlLine(a: 0.7321919326621603d, b: 0.7704043405190548d, c: 0.5508846640658778d),

new NpgsqlTypes.NpgsqlLine(a: 0.5796306726535371d, b: 0.3621536966457104d, c: 0.3554092618887771d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(956171576));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6305558129660189d, b: 0.5463622939629917d, c: 0.401891977997777d),

new NpgsqlTypes.NpgsqlLine(a: 0.3662230087345998d, b: 0.4302679455886196d, c: 0.9631184941583132d),

new NpgsqlTypes.NpgsqlLine(a: 0.3634906094993412d, b: 0.18046820180120404d, c: 0.5193725822662353d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48533853922222536d, b: 0.7781157007327932d, c: 0.20671476643143427d),

new NpgsqlTypes.NpgsqlLine(a: 0.7321919326621603d, b: 0.7704043405190548d, c: 0.5508846640658778d),

new NpgsqlTypes.NpgsqlLine(a: 0.5796306726535371d, b: 0.3621536966457104d, c: 0.3554092618887771d),

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

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, 88466632, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24038691940074952d, b: 0.4574071819075469d, c: 0.029018693781179494d),

new NpgsqlTypes.NpgsqlLine(a: 0.6230691191149946d, b: 0.6421350132669393d, c: 0.2591755154295573d),

new NpgsqlTypes.NpgsqlLine(a: 0.284214063978114d, b: 0.42055782459666247d, c: 0.4230265799247275d),

new NpgsqlTypes.NpgsqlLine(a: 0.2294933978523651d, b: 0.8434657220550107d, c: 0.1364803149185917d),

}, null, 671378680).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(88466632));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24038691940074952d, b: 0.4574071819075469d, c: 0.029018693781179494d),

new NpgsqlTypes.NpgsqlLine(a: 0.6230691191149946d, b: 0.6421350132669393d, c: 0.2591755154295573d),

new NpgsqlTypes.NpgsqlLine(a: 0.284214063978114d, b: 0.42055782459666247d, c: 0.4230265799247275d),

new NpgsqlTypes.NpgsqlLine(a: 0.2294933978523651d, b: 0.8434657220550107d, c: 0.1364803149185917d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(671378680));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlLine[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, 920410273, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7950181430955406d, b: 0.3848051391253504d, c: 0.1572657802170856d),

new NpgsqlTypes.NpgsqlLine(a: 0.6062151918599252d, b: 0.06062326101597226d, c: 0.14777044879318857d),

new NpgsqlTypes.NpgsqlLine(a: 0.7408182398935058d, b: 0.6661433504932776d, c: 0.15722709569280902d),

}, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2482561889064241d, b: 0.768360521777252d, c: 0.24033198573060877d),

new NpgsqlTypes.NpgsqlLine(a: 0.6078828832971318d, b: 0.25910942482320465d, c: 0.7624300130707319d),

new NpgsqlTypes.NpgsqlLine(a: 0.551230062109523d, b: 0.5951997473266207d, c: 0.05557568229198884d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(920410273));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7950181430955406d, b: 0.3848051391253504d, c: 0.1572657802170856d),

new NpgsqlTypes.NpgsqlLine(a: 0.6062151918599252d, b: 0.06062326101597226d, c: 0.14777044879318857d),

new NpgsqlTypes.NpgsqlLine(a: 0.7408182398935058d, b: 0.6661433504932776d, c: 0.15722709569280902d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2482561889064241d, b: 0.768360521777252d, c: 0.24033198573060877d),

new NpgsqlTypes.NpgsqlLine(a: 0.6078828832971318d, b: 0.25910942482320465d, c: 0.7624300130707319d),

new NpgsqlTypes.NpgsqlLine(a: 0.551230062109523d, b: 0.5951997473266207d, c: 0.05557568229198884d),

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

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, 385864550, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22975102280111437d, b: 0.9248487581270293d, c: 0.13680981887715193d),

new NpgsqlTypes.NpgsqlLine(a: 0.09251582159332017d, b: 0.5284902712490177d, c: 0.5030244379828798d),

new NpgsqlTypes.NpgsqlLine(a: 0.3316636973424488d, b: 0.125908586516723d, c: 0.1307901665228316d),

new NpgsqlTypes.NpgsqlLine(a: 0.4488357278586823d, b: 0.4939460007710509d, c: 0.1486125807477222d),

}, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4793632894446783d, b: 0.7460924351194599d, c: 0.8333281971866928d),

new NpgsqlTypes.NpgsqlLine(a: 0.9911204719862435d, b: 0.02386428262012663d, c: 0.1749191984110413d),

new NpgsqlTypes.NpgsqlLine(a: 0.9855596015822274d, b: 0.652336551342683d, c: 0.13320036109805444d),

new NpgsqlTypes.NpgsqlLine(a: 0.2704642620419001d, b: 0.25815455585325764d, c: 0.781691467105331d),

}, 507016837).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(385864550));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22975102280111437d, b: 0.9248487581270293d, c: 0.13680981887715193d),

new NpgsqlTypes.NpgsqlLine(a: 0.09251582159332017d, b: 0.5284902712490177d, c: 0.5030244379828798d),

new NpgsqlTypes.NpgsqlLine(a: 0.3316636973424488d, b: 0.125908586516723d, c: 0.1307901665228316d),

new NpgsqlTypes.NpgsqlLine(a: 0.4488357278586823d, b: 0.4939460007710509d, c: 0.1486125807477222d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4793632894446783d, b: 0.7460924351194599d, c: 0.8333281971866928d),

new NpgsqlTypes.NpgsqlLine(a: 0.9911204719862435d, b: 0.02386428262012663d, c: 0.1749191984110413d),

new NpgsqlTypes.NpgsqlLine(a: 0.9855596015822274d, b: 0.652336551342683d, c: 0.13320036109805444d),

new NpgsqlTypes.NpgsqlLine(a: 0.2704642620419001d, b: 0.25815455585325764d, c: 0.781691467105331d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(507016837));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlLine[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, 940484658, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8457530794410952d, b: 0.07468146527745967d, c: 0.6058450234777081d),

new NpgsqlTypes.NpgsqlLine(a: 0.43907623012482566d, b: 0.4163533057091461d, c: 0.7083053151407345d),

new NpgsqlTypes.NpgsqlLine(a: 0.6460729456777172d, b: 0.3996032448892458d, c: 0.32058136990645736d),

}, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5056133907420888d, b: 0.687789482585691d, c: 0.5736898296981361d),

new NpgsqlTypes.NpgsqlLine(a: 0.6165837793609097d, b: 0.3896094649555947d, c: 0.782529168193896d),

new NpgsqlTypes.NpgsqlLine(a: 0.19522061405511182d, b: 0.49515141325692447d, c: 0.8154303350690599d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(940484658));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8457530794410952d, b: 0.07468146527745967d, c: 0.6058450234777081d),

new NpgsqlTypes.NpgsqlLine(a: 0.43907623012482566d, b: 0.4163533057091461d, c: 0.7083053151407345d),

new NpgsqlTypes.NpgsqlLine(a: 0.6460729456777172d, b: 0.3996032448892458d, c: 0.32058136990645736d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5056133907420888d, b: 0.687789482585691d, c: 0.5736898296981361d),

new NpgsqlTypes.NpgsqlLine(a: 0.6165837793609097d, b: 0.3896094649555947d, c: 0.782529168193896d),

new NpgsqlTypes.NpgsqlLine(a: 0.19522061405511182d, b: 0.49515141325692447d, c: 0.8154303350690599d),

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

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, 287773256, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5468129373528992d, b: 0.4550697398151482d, c: 0.9323204190693627d),

new NpgsqlTypes.NpgsqlLine(a: 0.09290076953581794d, b: 0.06513797114322906d, c: 0.01453530584939322d),

new NpgsqlTypes.NpgsqlLine(a: 0.06819515445977387d, b: 0.13776512554356624d, c: 0.5971045649241554d),

new NpgsqlTypes.NpgsqlLine(a: 0.17602847632288898d, b: 0.8583377493377162d, c: 0.5319193518068348d),

}, null, 2000087272).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(287773256));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5468129373528992d, b: 0.4550697398151482d, c: 0.9323204190693627d),

new NpgsqlTypes.NpgsqlLine(a: 0.09290076953581794d, b: 0.06513797114322906d, c: 0.01453530584939322d),

new NpgsqlTypes.NpgsqlLine(a: 0.06819515445977387d, b: 0.13776512554356624d, c: 0.5971045649241554d),

new NpgsqlTypes.NpgsqlLine(a: 0.17602847632288898d, b: 0.8583377493377162d, c: 0.5319193518068348d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2000087272));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlLine[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, 1276251566, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4808529939808879d, b: 0.365247596328651d, c: 0.17939866902766977d),

new NpgsqlTypes.NpgsqlLine(a: 0.12809708913748585d, b: 0.18821025600986407d, c: 0.9740037535570704d),

new NpgsqlTypes.NpgsqlLine(a: 0.7729579560840041d, b: 0.5283959837814016d, c: 0.3246873097765165d),

new NpgsqlTypes.NpgsqlLine(a: 0.5804554841359071d, b: 0.7951318743812129d, c: 0.9533437460862759d),

}, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07357632206959641d, b: 0.11099061080365447d, c: 0.47576723756466854d),

new NpgsqlTypes.NpgsqlLine(a: 0.9051522311200175d, b: 0.6041352781626989d, c: 0.962846313750425d),

new NpgsqlTypes.NpgsqlLine(a: 0.7230697163609032d, b: 0.35996997662147945d, c: 0.2719627850842049d),

new NpgsqlTypes.NpgsqlLine(a: 0.039972657007877d, b: 0.6660692046588974d, c: 0.8074219604808613d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276251566));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4808529939808879d, b: 0.365247596328651d, c: 0.17939866902766977d),

new NpgsqlTypes.NpgsqlLine(a: 0.12809708913748585d, b: 0.18821025600986407d, c: 0.9740037535570704d),

new NpgsqlTypes.NpgsqlLine(a: 0.7729579560840041d, b: 0.5283959837814016d, c: 0.3246873097765165d),

new NpgsqlTypes.NpgsqlLine(a: 0.5804554841359071d, b: 0.7951318743812129d, c: 0.9533437460862759d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07357632206959641d, b: 0.11099061080365447d, c: 0.47576723756466854d),

new NpgsqlTypes.NpgsqlLine(a: 0.9051522311200175d, b: 0.6041352781626989d, c: 0.962846313750425d),

new NpgsqlTypes.NpgsqlLine(a: 0.7230697163609032d, b: 0.35996997662147945d, c: 0.2719627850842049d),

new NpgsqlTypes.NpgsqlLine(a: 0.039972657007877d, b: 0.6660692046588974d, c: 0.8074219604808613d),

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

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, 1049476690, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1703167002028123d, b: 0.06899134909065618d, c: 0.39632655876575884d),

new NpgsqlTypes.NpgsqlLine(a: 0.9436521110809849d, b: 0.2716102490692832d, c: 0.21807972083943694d),

new NpgsqlTypes.NpgsqlLine(a: 0.07510391898176405d, b: 0.4622700624960824d, c: 0.6916474126671974d),

}, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3434566231012316d, b: 0.6092872970160005d, c: 0.8285200623737458d),

new NpgsqlTypes.NpgsqlLine(a: 0.438620087459067d, b: 0.42784452615069857d, c: 0.43791996431227087d),

new NpgsqlTypes.NpgsqlLine(a: 0.13822472685663223d, b: 0.3567687904324768d, c: 0.5713362361619454d),

new NpgsqlTypes.NpgsqlLine(a: 0.4225842002023096d, b: 0.13041963778907273d, c: 0.537431949671262d),

}, 259689541).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1049476690));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1703167002028123d, b: 0.06899134909065618d, c: 0.39632655876575884d),

new NpgsqlTypes.NpgsqlLine(a: 0.9436521110809849d, b: 0.2716102490692832d, c: 0.21807972083943694d),

new NpgsqlTypes.NpgsqlLine(a: 0.07510391898176405d, b: 0.4622700624960824d, c: 0.6916474126671974d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3434566231012316d, b: 0.6092872970160005d, c: 0.8285200623737458d),

new NpgsqlTypes.NpgsqlLine(a: 0.438620087459067d, b: 0.42784452615069857d, c: 0.43791996431227087d),

new NpgsqlTypes.NpgsqlLine(a: 0.13822472685663223d, b: 0.3567687904324768d, c: 0.5713362361619454d),

new NpgsqlTypes.NpgsqlLine(a: 0.4225842002023096d, b: 0.13041963778907273d, c: 0.537431949671262d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(259689541));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlLine[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, 1169283916, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6136867588329713d, b: 0.8476721243007673d, c: 0.2920466838690219d),

new NpgsqlTypes.NpgsqlLine(a: 0.5632572533709046d, b: 0.8580393386665631d, c: 0.29067186403759726d),

new NpgsqlTypes.NpgsqlLine(a: 0.05864985939465561d, b: 0.06933376015004311d, c: 0.2622230618531959d),

}, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3083889075922114d, b: 0.40504233141015844d, c: 0.7282625593772889d),

new NpgsqlTypes.NpgsqlLine(a: 0.9760389595620657d, b: 0.5432046524856411d, c: 0.4805721407516501d),

new NpgsqlTypes.NpgsqlLine(a: 0.226094370846618d, b: 0.30929816503923757d, c: 0.749788108094253d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1169283916));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6136867588329713d, b: 0.8476721243007673d, c: 0.2920466838690219d),

new NpgsqlTypes.NpgsqlLine(a: 0.5632572533709046d, b: 0.8580393386665631d, c: 0.29067186403759726d),

new NpgsqlTypes.NpgsqlLine(a: 0.05864985939465561d, b: 0.06933376015004311d, c: 0.2622230618531959d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3083889075922114d, b: 0.40504233141015844d, c: 0.7282625593772889d),

new NpgsqlTypes.NpgsqlLine(a: 0.9760389595620657d, b: 0.5432046524856411d, c: 0.4805721407516501d),

new NpgsqlTypes.NpgsqlLine(a: 0.226094370846618d, b: 0.30929816503923757d, c: 0.749788108094253d),

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

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, 1750072079, 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6509605768915644d, b: 0.2871280523199907d, c: 0.5279864073907687d),

new NpgsqlTypes.NpgsqlLine(a: 0.847627780191932d, b: 0.2863239370866939d, c: 0.39664595009550063d),

new NpgsqlTypes.NpgsqlLine(a: 0.06719070091173818d, b: 0.2998868113793318d, c: 0.8109899934095542d),

}, 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30402634597868494d, b: 0.7741177113732105d, c: 0.4982697795456863d),

new NpgsqlTypes.NpgsqlLine(a: 0.22134239051678783d, b: 0.952989590947333d, c: 0.1976805178607327d),

new NpgsqlTypes.NpgsqlLine(a: 0.48019693876130953d, b: 0.8553553442730837d, c: 0.4578014530562905d),

new NpgsqlTypes.NpgsqlLine(a: 0.7948720279836796d, b: 0.6347165612507009d, c: 0.4915047790558922d),

}, 681877477).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1750072079));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6509605768915644d, b: 0.2871280523199907d, c: 0.5279864073907687d),

new NpgsqlTypes.NpgsqlLine(a: 0.847627780191932d, b: 0.2863239370866939d, c: 0.39664595009550063d),

new NpgsqlTypes.NpgsqlLine(a: 0.06719070091173818d, b: 0.2998868113793318d, c: 0.8109899934095542d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30402634597868494d, b: 0.7741177113732105d, c: 0.4982697795456863d),

new NpgsqlTypes.NpgsqlLine(a: 0.22134239051678783d, b: 0.952989590947333d, c: 0.1976805178607327d),

new NpgsqlTypes.NpgsqlLine(a: 0.48019693876130953d, b: 0.8553553442730837d, c: 0.4578014530562905d),

new NpgsqlTypes.NpgsqlLine(a: 0.7948720279836796d, b: 0.6347165612507009d, c: 0.4915047790558922d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(681877477));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlLine[])default));
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(NpgsqlLinelineArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)
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
                var models =  ((INpgsqlLineArraylineArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(24431063));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7432562260700321d, b: 0.9027051106351455d, c: 0.20935776301702913d),

new NpgsqlTypes.NpgsqlLine(a: 0.06877648068052133d, b: 0.4638520424251973d, c: 0.8977581074629934d),

new NpgsqlTypes.NpgsqlLine(a: 0.19824889810271595d, b: 0.101805635004653d, c: 0.6376796129171594d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.25692356453649523d, b: 0.8249956321761069d, c: 0.7485760418256393d),

new NpgsqlTypes.NpgsqlLine(a: 0.5205543536927003d, b: 0.26409313743898866d, c: 0.11834223656249432d),

new NpgsqlTypes.NpgsqlLine(a: 0.12852097087774939d, b: 0.110468841038458d, c: 0.15781368742463253d),

new NpgsqlTypes.NpgsqlLine(a: 0.5056691167374713d, b: 0.17475361978672044d, c: 0.4301177356479713d),

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
                Assert.That(model.Id, Is.EqualTo(88466632));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24038691940074952d, b: 0.4574071819075469d, c: 0.029018693781179494d),

new NpgsqlTypes.NpgsqlLine(a: 0.6230691191149946d, b: 0.6421350132669393d, c: 0.2591755154295573d),

new NpgsqlTypes.NpgsqlLine(a: 0.284214063978114d, b: 0.42055782459666247d, c: 0.4230265799247275d),

new NpgsqlTypes.NpgsqlLine(a: 0.2294933978523651d, b: 0.8434657220550107d, c: 0.1364803149185917d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(671378680));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.579485378096583d, b: 0.7644192687968542d, c: 0.38803543767659376d),

new NpgsqlTypes.NpgsqlLine(a: 0.9272224559192928d, b: 0.04309922869802718d, c: 0.1084146589578524d),

new NpgsqlTypes.NpgsqlLine(a: 0.6194396921461146d, b: 0.3135327751395446d, c: 0.47728859432318693d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22238461731837955d, b: 0.8832575247518029d, c: 0.5267192016109244d),

new NpgsqlTypes.NpgsqlLine(a: 0.2456814921559901d, b: 0.12396858431218405d, c: 0.7758983059785806d),

new NpgsqlTypes.NpgsqlLine(a: 0.8010355013907535d, b: 0.10724380078506457d, c: 0.8516226142927568d),

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
                Assert.That(model.Id, Is.EqualTo(214898413));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7273918164372143d, b: 0.3711769692436181d, c: 0.7468659136792664d),

new NpgsqlTypes.NpgsqlLine(a: 0.8155250372031967d, b: 0.5364157660240247d, c: 0.2587745327315204d),

new NpgsqlTypes.NpgsqlLine(a: 0.8823774478354753d, b: 0.24032876435579376d, c: 0.9187231882533503d),

new NpgsqlTypes.NpgsqlLine(a: 0.2761563267007917d, b: 0.8609521972165307d, c: 0.014350256291767893d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7060914743005817d, b: 0.29942700622480667d, c: 0.38464564338188945d),

new NpgsqlTypes.NpgsqlLine(a: 0.456801666295529d, b: 0.2750050419905442d, c: 0.6523990372650718d),

new NpgsqlTypes.NpgsqlLine(a: 0.593068234761201d, b: 0.986042625015402d, c: 0.7722918655162653d),

new NpgsqlTypes.NpgsqlLine(a: 0.8257270425360131d, b: 0.9234733383976109d, c: 0.16399605960296715d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(160844459));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.49742066568592347d, b: 0.13045995730850435d, c: 0.3240701079822569d),

new NpgsqlTypes.NpgsqlLine(a: 0.4230136983146885d, b: 0.4758823758243249d, c: 0.7245296150407883d),

new NpgsqlTypes.NpgsqlLine(a: 0.902525000709505d, b: 0.3096633545847971d, c: 0.7195095860492445d),

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
                Assert.That(model.Id, Is.EqualTo(232426060));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7754569347332767d, b: 0.7449423603392903d, c: 0.7275357910733291d),

new NpgsqlTypes.NpgsqlLine(a: 0.9072872865290874d, b: 0.5188651109794405d, c: 0.49767196437474315d),

new NpgsqlTypes.NpgsqlLine(a: 0.7613773478086597d, b: 0.8726134777514618d, c: 0.7249287737318102d),

new NpgsqlTypes.NpgsqlLine(a: 0.31979325488547383d, b: 0.21963013317369884d, c: 0.995747479981123d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5136334997132156d, b: 0.4481836733144653d, c: 0.5566013930940901d),

new NpgsqlTypes.NpgsqlLine(a: 0.2628604279970359d, b: 0.34706683348460354d, c: 0.8618758810041756d),

new NpgsqlTypes.NpgsqlLine(a: 0.9066993846202163d, b: 0.9919335952888788d, c: 0.16647553451680086d),

new NpgsqlTypes.NpgsqlLine(a: 0.8084713734948656d, b: 0.9105928653749232d, c: 0.5871692331069964d),

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

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(287773256));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5468129373528992d, b: 0.4550697398151482d, c: 0.9323204190693627d),

new NpgsqlTypes.NpgsqlLine(a: 0.09290076953581794d, b: 0.06513797114322906d, c: 0.01453530584939322d),

new NpgsqlTypes.NpgsqlLine(a: 0.06819515445977387d, b: 0.13776512554356624d, c: 0.5971045649241554d),

new NpgsqlTypes.NpgsqlLine(a: 0.17602847632288898d, b: 0.8583377493377162d, c: 0.5319193518068348d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2000087272));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5174417835536576d, b: 0.9550151039410834d, c: 0.94465021980697d),

new NpgsqlTypes.NpgsqlLine(a: 0.023498567205728516d, b: 0.14704570142511664d, c: 0.5436176118381062d),

new NpgsqlTypes.NpgsqlLine(a: 0.6410825125912296d, b: 0.1638519482392854d, c: 0.07442290044208977d),

new NpgsqlTypes.NpgsqlLine(a: 0.5684954410076702d, b: 0.9517870324925599d, c: 0.7913121037671743d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5546781844769255d, b: 0.3295435210405563d, c: 0.10332785525555d),

new NpgsqlTypes.NpgsqlLine(a: 0.8619184029547027d, b: 0.6893143841340763d, c: 0.6057919377815917d),

new NpgsqlTypes.NpgsqlLine(a: 0.6918049340506819d, b: 0.29564467871458977d, c: 0.373851052320022d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590711543927416d, b: 0.782456230485786d, c: 0.0557514543823312d),

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
                Assert.That(model.Id, Is.EqualTo(385864550));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22975102280111437d, b: 0.9248487581270293d, c: 0.13680981887715193d),

new NpgsqlTypes.NpgsqlLine(a: 0.09251582159332017d, b: 0.5284902712490177d, c: 0.5030244379828798d),

new NpgsqlTypes.NpgsqlLine(a: 0.3316636973424488d, b: 0.125908586516723d, c: 0.1307901665228316d),

new NpgsqlTypes.NpgsqlLine(a: 0.4488357278586823d, b: 0.4939460007710509d, c: 0.1486125807477222d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4793632894446783d, b: 0.7460924351194599d, c: 0.8333281971866928d),

new NpgsqlTypes.NpgsqlLine(a: 0.9911204719862435d, b: 0.02386428262012663d, c: 0.1749191984110413d),

new NpgsqlTypes.NpgsqlLine(a: 0.9855596015822274d, b: 0.652336551342683d, c: 0.13320036109805444d),

new NpgsqlTypes.NpgsqlLine(a: 0.2704642620419001d, b: 0.25815455585325764d, c: 0.781691467105331d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(507016837));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6329641939546133d, b: 0.7713358064075255d, c: 0.7091675230581173d),

new NpgsqlTypes.NpgsqlLine(a: 0.6401104534145889d, b: 0.4461488045009705d, c: 0.8050604324576476d),

new NpgsqlTypes.NpgsqlLine(a: 0.718200194405203d, b: 0.43497844061299695d, c: 0.8863292600245054d),

new NpgsqlTypes.NpgsqlLine(a: 0.6409377372303063d, b: 0.6727026439221405d, c: 0.709162570856183d),

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
                Assert.That(model.Id, Is.EqualTo(425879955));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7120720914880876d, b: 0.12018496532744738d, c: 0.23458035596972604d),

new NpgsqlTypes.NpgsqlLine(a: 0.8966943482850258d, b: 0.35901938172619774d, c: 0.5153333646331681d),

new NpgsqlTypes.NpgsqlLine(a: 0.772529205234202d, b: 0.3302141544038909d, c: 0.49860223574471696d),

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
                Assert.That(model.Id, Is.EqualTo(447065450));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6636554004535458d, b: 0.4052905058278198d, c: 0.17999403534412883d),

new NpgsqlTypes.NpgsqlLine(a: 0.4929643299593621d, b: 0.04102771738828992d, c: 0.8758588440576921d),

new NpgsqlTypes.NpgsqlLine(a: 0.9843591359807438d, b: 0.9486545770421181d, c: 0.23810538982780194d),

new NpgsqlTypes.NpgsqlLine(a: 0.0373504814930844d, b: 0.29650224807426506d, c: 0.6527517869517908d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1935239880));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5125009420178407d, b: 0.13553866813087467d, c: 0.6573124881706722d),

new NpgsqlTypes.NpgsqlLine(a: 0.9315668534985179d, b: 0.031339976871202935d, c: 0.7319776155987312d),

new NpgsqlTypes.NpgsqlLine(a: 0.5913519522327184d, b: 0.688194613219936d, c: 0.7487303543444555d),

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
                Assert.That(model.Id, Is.EqualTo(776647699));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8841755970938628d, b: 0.039993263617271846d, c: 0.2425222413816407d),

new NpgsqlTypes.NpgsqlLine(a: 0.3162669055857611d, b: 0.1360654949714053d, c: 0.585066125260232d),

new NpgsqlTypes.NpgsqlLine(a: 0.23614085233198578d, b: 0.9624524908146396d, c: 0.8036122013629919d),

new NpgsqlTypes.NpgsqlLine(a: 0.9594786748108928d, b: 0.3334512033062713d, c: 0.8626799508985245d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7692177568154062d, b: 0.8045212370680859d, c: 0.347836807601842d),

new NpgsqlTypes.NpgsqlLine(a: 0.8596806867272218d, b: 0.42225206488490163d, c: 0.2626771759427945d),

new NpgsqlTypes.NpgsqlLine(a: 0.6334601490046422d, b: 0.5508277640730257d, c: 0.9702039181027914d),

new NpgsqlTypes.NpgsqlLine(a: 0.7862671596820799d, b: 0.6148121550149941d, c: 0.10467782441316142d),

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
                Assert.That(model.Id, Is.EqualTo(920410273));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7950181430955406d, b: 0.3848051391253504d, c: 0.1572657802170856d),

new NpgsqlTypes.NpgsqlLine(a: 0.6062151918599252d, b: 0.06062326101597226d, c: 0.14777044879318857d),

new NpgsqlTypes.NpgsqlLine(a: 0.7408182398935058d, b: 0.6661433504932776d, c: 0.15722709569280902d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2482561889064241d, b: 0.768360521777252d, c: 0.24033198573060877d),

new NpgsqlTypes.NpgsqlLine(a: 0.6078828832971318d, b: 0.25910942482320465d, c: 0.7624300130707319d),

new NpgsqlTypes.NpgsqlLine(a: 0.551230062109523d, b: 0.5951997473266207d, c: 0.05557568229198884d),

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
                Assert.That(model.Id, Is.EqualTo(929385902));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8285395037487209d, b: 0.25070273066629d, c: 0.2500673109161923d),

new NpgsqlTypes.NpgsqlLine(a: 0.9942717530143405d, b: 0.21539215026712022d, c: 0.20269945939501077d),

new NpgsqlTypes.NpgsqlLine(a: 0.7979702358088475d, b: 0.0037115614378556705d, c: 0.8843432168677479d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1456202870910711d, b: 0.06772665910903597d, c: 0.691750610472359d),

new NpgsqlTypes.NpgsqlLine(a: 0.765757989281042d, b: 0.32982835634782004d, c: 0.8913701807765988d),

new NpgsqlTypes.NpgsqlLine(a: 0.052240732409688406d, b: 0.618262798295761d, c: 0.8474290495942781d),

new NpgsqlTypes.NpgsqlLine(a: 0.3584922315949717d, b: 0.520574773115294d, c: 0.8310230234204736d),

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
                Assert.That(model.Id, Is.EqualTo(939691488));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15928813769803307d, b: 0.5335096410959914d, c: 0.9693141891385088d),

new NpgsqlTypes.NpgsqlLine(a: 0.9448241901930845d, b: 0.6287076527827521d, c: 0.6660617468801671d),

new NpgsqlTypes.NpgsqlLine(a: 0.30712778702622445d, b: 0.324942912367581d, c: 0.9500282198259326d),

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
                Assert.That(model.Id, Is.EqualTo(940484658));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8457530794410952d, b: 0.07468146527745967d, c: 0.6058450234777081d),

new NpgsqlTypes.NpgsqlLine(a: 0.43907623012482566d, b: 0.4163533057091461d, c: 0.7083053151407345d),

new NpgsqlTypes.NpgsqlLine(a: 0.6460729456777172d, b: 0.3996032448892458d, c: 0.32058136990645736d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5056133907420888d, b: 0.687789482585691d, c: 0.5736898296981361d),

new NpgsqlTypes.NpgsqlLine(a: 0.6165837793609097d, b: 0.3896094649555947d, c: 0.782529168193896d),

new NpgsqlTypes.NpgsqlLine(a: 0.19522061405511182d, b: 0.49515141325692447d, c: 0.8154303350690599d),

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
                Assert.That(model.Id, Is.EqualTo(956171576));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6305558129660189d, b: 0.5463622939629917d, c: 0.401891977997777d),

new NpgsqlTypes.NpgsqlLine(a: 0.3662230087345998d, b: 0.4302679455886196d, c: 0.9631184941583132d),

new NpgsqlTypes.NpgsqlLine(a: 0.3634906094993412d, b: 0.18046820180120404d, c: 0.5193725822662353d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48533853922222536d, b: 0.7781157007327932d, c: 0.20671476643143427d),

new NpgsqlTypes.NpgsqlLine(a: 0.7321919326621603d, b: 0.7704043405190548d, c: 0.5508846640658778d),

new NpgsqlTypes.NpgsqlLine(a: 0.5796306726535371d, b: 0.3621536966457104d, c: 0.3554092618887771d),

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
                Assert.That(model.Id, Is.EqualTo(1049476690));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1703167002028123d, b: 0.06899134909065618d, c: 0.39632655876575884d),

new NpgsqlTypes.NpgsqlLine(a: 0.9436521110809849d, b: 0.2716102490692832d, c: 0.21807972083943694d),

new NpgsqlTypes.NpgsqlLine(a: 0.07510391898176405d, b: 0.4622700624960824d, c: 0.6916474126671974d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3434566231012316d, b: 0.6092872970160005d, c: 0.8285200623737458d),

new NpgsqlTypes.NpgsqlLine(a: 0.438620087459067d, b: 0.42784452615069857d, c: 0.43791996431227087d),

new NpgsqlTypes.NpgsqlLine(a: 0.13822472685663223d, b: 0.3567687904324768d, c: 0.5713362361619454d),

new NpgsqlTypes.NpgsqlLine(a: 0.4225842002023096d, b: 0.13041963778907273d, c: 0.537431949671262d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(259689541));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16915141278580792d, b: 0.5107686791340034d, c: 0.6489920882506348d),

new NpgsqlTypes.NpgsqlLine(a: 0.030879513236027d, b: 0.6401283771223818d, c: 0.4904762444562075d),

new NpgsqlTypes.NpgsqlLine(a: 0.16124954101586042d, b: 0.7102870300472969d, c: 0.9978682907813775d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3413197342637151d, b: 0.3564754218301692d, c: 0.16698356005321802d),

new NpgsqlTypes.NpgsqlLine(a: 0.24996465538547474d, b: 0.6936235099874405d, c: 0.00768766971096424d),

new NpgsqlTypes.NpgsqlLine(a: 0.9713834412198872d, b: 0.1937685310996965d, c: 0.5638524218711839d),

new NpgsqlTypes.NpgsqlLine(a: 0.20790035052620326d, b: 0.7280555648340241d, c: 0.7150389111804211d),

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
                Assert.That(model.Id, Is.EqualTo(1169283916));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6136867588329713d, b: 0.8476721243007673d, c: 0.2920466838690219d),

new NpgsqlTypes.NpgsqlLine(a: 0.5632572533709046d, b: 0.8580393386665631d, c: 0.29067186403759726d),

new NpgsqlTypes.NpgsqlLine(a: 0.05864985939465561d, b: 0.06933376015004311d, c: 0.2622230618531959d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3083889075922114d, b: 0.40504233141015844d, c: 0.7282625593772889d),

new NpgsqlTypes.NpgsqlLine(a: 0.9760389595620657d, b: 0.5432046524856411d, c: 0.4805721407516501d),

new NpgsqlTypes.NpgsqlLine(a: 0.226094370846618d, b: 0.30929816503923757d, c: 0.749788108094253d),

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

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1247961184));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588334999708729d, b: 0.5781258655739143d, c: 0.4951203893647069d),

new NpgsqlTypes.NpgsqlLine(a: 0.206651781249944d, b: 0.9214488824097644d, c: 0.7102197735978709d),

new NpgsqlTypes.NpgsqlLine(a: 0.8293873017859008d, b: 0.4197388618664637d, c: 0.7538628331143343d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9886122302398814d, b: 0.09733443476141157d, c: 0.8828756753279827d),

new NpgsqlTypes.NpgsqlLine(a: 0.4191781730328399d, b: 0.8360940579259326d, c: 0.3115604346093266d),

new NpgsqlTypes.NpgsqlLine(a: 0.03123256692948395d, b: 0.4210178852779579d, c: 0.7083559364281564d),

new NpgsqlTypes.NpgsqlLine(a: 0.10193811062121638d, b: 0.7865607707379441d, c: 0.5102014504618864d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(313349652));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7148027863911385d, b: 0.4116315290140842d, c: 0.9883513693293022d),

new NpgsqlTypes.NpgsqlLine(a: 0.730798769811796d, b: 0.5625059295801093d, c: 0.028144945623879147d),

new NpgsqlTypes.NpgsqlLine(a: 0.7895921923207063d, b: 0.897092096080744d, c: 0.36804397804374556d),

new NpgsqlTypes.NpgsqlLine(a: 0.4403951364132078d, b: 0.48316034726668566d, c: 0.5561087583026281d),

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
                Assert.That(model.Id, Is.EqualTo(1251267268));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.27064576558959075d, b: 0.24611103650290955d, c: 0.04928435530376152d),

new NpgsqlTypes.NpgsqlLine(a: 0.5382620257248645d, b: 0.586731968734226d, c: 0.9110741668368397d),

new NpgsqlTypes.NpgsqlLine(a: 0.8386954216871374d, b: 0.14045527908308764d, c: 0.5300328684198944d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7572326327773035d, b: 0.10039993499818312d, c: 0.17339739029118428d),

new NpgsqlTypes.NpgsqlLine(a: 0.9566618331567527d, b: 0.14668861402647748d, c: 0.7767711369985796d),

new NpgsqlTypes.NpgsqlLine(a: 0.932727244163919d, b: 0.12159065636952726d, c: 0.1704609096711438d),

new NpgsqlTypes.NpgsqlLine(a: 0.5792460825794749d, b: 0.985437582839235d, c: 0.557473090399633d),

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

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276251566));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4808529939808879d, b: 0.365247596328651d, c: 0.17939866902766977d),

new NpgsqlTypes.NpgsqlLine(a: 0.12809708913748585d, b: 0.18821025600986407d, c: 0.9740037535570704d),

new NpgsqlTypes.NpgsqlLine(a: 0.7729579560840041d, b: 0.5283959837814016d, c: 0.3246873097765165d),

new NpgsqlTypes.NpgsqlLine(a: 0.5804554841359071d, b: 0.7951318743812129d, c: 0.9533437460862759d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07357632206959641d, b: 0.11099061080365447d, c: 0.47576723756466854d),

new NpgsqlTypes.NpgsqlLine(a: 0.9051522311200175d, b: 0.6041352781626989d, c: 0.962846313750425d),

new NpgsqlTypes.NpgsqlLine(a: 0.7230697163609032d, b: 0.35996997662147945d, c: 0.2719627850842049d),

new NpgsqlTypes.NpgsqlLine(a: 0.039972657007877d, b: 0.6660692046588974d, c: 0.8074219604808613d),

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

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1278639929));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8637991908928382d, b: 0.7989476928355281d, c: 0.047074497669961635d),

new NpgsqlTypes.NpgsqlLine(a: 0.24284327761860214d, b: 0.034845279321367495d, c: 0.8243144068858446d),

new NpgsqlTypes.NpgsqlLine(a: 0.2705173386529084d, b: 0.37759514414776285d, c: 0.003784057263189533d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5464646368268954d, b: 0.1698011067851829d, c: 0.4811896051504386d),

new NpgsqlTypes.NpgsqlLine(a: 0.3264558304845737d, b: 0.09741548986796533d, c: 0.35078408755418944d),

new NpgsqlTypes.NpgsqlLine(a: 0.1253849539183054d, b: 0.9184504405667023d, c: 0.6244095303662431d),

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
                Assert.That(model.Id, Is.EqualTo(1352296160));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6961581521563707d, b: 0.2870425810465653d, c: 0.022813771410836625d),

new NpgsqlTypes.NpgsqlLine(a: 0.9289180434806266d, b: 0.10310192777053839d, c: 0.4974840036652155d),

new NpgsqlTypes.NpgsqlLine(a: 0.9742618124298718d, b: 0.666155889593685d, c: 0.9108800941033853d),

new NpgsqlTypes.NpgsqlLine(a: 0.4076993728994177d, b: 0.9237619110159688d, c: 0.16349574316883708d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.40245830157937157d, b: 0.4425237993192568d, c: 0.3605907953188545d),

new NpgsqlTypes.NpgsqlLine(a: 0.3025387755185438d, b: 0.16175616826033246d, c: 0.08369914886846197d),

new NpgsqlTypes.NpgsqlLine(a: 0.7932786053551402d, b: 0.4757892941852452d, c: 0.35215963103511483d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2052209240));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28682097488067404d, b: 0.19347953745544d, c: 0.767001580247448d),

new NpgsqlTypes.NpgsqlLine(a: 0.34168929191792363d, b: 0.5324263819109204d, c: 0.3548736591683712d),

new NpgsqlTypes.NpgsqlLine(a: 0.7601584215479089d, b: 0.9667193856859281d, c: 0.48805620341333844d),

new NpgsqlTypes.NpgsqlLine(a: 0.4778030273140724d, b: 0.6459214140044727d, c: 0.9825570138966864d),

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
                Assert.That(model.Id, Is.EqualTo(1422030401));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5508950376990435d, b: 0.1842011543506923d, c: 0.7200839172656331d),

new NpgsqlTypes.NpgsqlLine(a: 0.08098131741133519d, b: 0.2512744482896645d, c: 0.4419893154281408d),

new NpgsqlTypes.NpgsqlLine(a: 0.7183180834237055d, b: 0.3821225061156569d, c: 0.320010478004808d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.605461690855222d, b: 0.5098249599693536d, c: 0.049446338505273246d),

new NpgsqlTypes.NpgsqlLine(a: 0.6383133050473475d, b: 0.5385834180776717d, c: 0.2612256906158803d),

new NpgsqlTypes.NpgsqlLine(a: 0.2259744218921168d, b: 0.0504022254415285d, c: 0.5085817881315488d),

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
                Assert.That(model.Id, Is.EqualTo(1441068318));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04431673188157559d, b: 0.7118895502319815d, c: 0.8045459394080527d),

new NpgsqlTypes.NpgsqlLine(a: 0.41883883343441664d, b: 0.0856133325697227d, c: 0.45940150990219364d),

new NpgsqlTypes.NpgsqlLine(a: 0.3845455332415372d, b: 0.5278908004707358d, c: 0.45211852173959755d),

new NpgsqlTypes.NpgsqlLine(a: 0.707344526938849d, b: 0.2664835051263448d, c: 0.8012907013628192d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5167014945187821d, b: 0.2318523474732329d, c: 0.0766480392056259d),

new NpgsqlTypes.NpgsqlLine(a: 0.6239339834043951d, b: 0.4407650281616141d, c: 0.07711199216030074d),

new NpgsqlTypes.NpgsqlLine(a: 0.7330247230488705d, b: 0.06195929907587139d, c: 0.1736910797965654d),

new NpgsqlTypes.NpgsqlLine(a: 0.5060985759956755d, b: 0.12918142066992122d, c: 0.3598502037154421d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1349638635));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8811777097968191d, b: 0.09805743628781294d, c: 0.8476023389336619d),

new NpgsqlTypes.NpgsqlLine(a: 0.16329696312104391d, b: 0.8434248077846473d, c: 0.0171626874853823d),

new NpgsqlTypes.NpgsqlLine(a: 0.5930114320798587d, b: 0.7874763150232159d, c: 0.20169365861720767d),

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
                Assert.That(model.Id, Is.EqualTo(1485177216));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7620135774845544d, b: 0.72234986247445d, c: 0.7900958363555012d),

new NpgsqlTypes.NpgsqlLine(a: 0.5982892074823093d, b: 0.9157569165822279d, c: 0.5913666560112503d),

new NpgsqlTypes.NpgsqlLine(a: 0.3694255096703286d, b: 0.43689654039349735d, c: 0.27488642071951885d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1888587968));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9441675468790086d, b: 0.10273087249159918d, c: 0.36496868371913627d),

new NpgsqlTypes.NpgsqlLine(a: 0.3153900895384264d, b: 0.8953921593705707d, c: 0.6821583482258307d),

new NpgsqlTypes.NpgsqlLine(a: 0.15884512105184567d, b: 0.20745599422324912d, c: 0.5928677501305737d),

new NpgsqlTypes.NpgsqlLine(a: 0.19203772899196803d, b: 0.9281999546867626d, c: 0.9792553764463741d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.616453689236877d, b: 0.26880075600348696d, c: 0.9911672578342802d),

new NpgsqlTypes.NpgsqlLine(a: 0.41598816366831615d, b: 0.2972198032481773d, c: 0.6096249065094251d),

new NpgsqlTypes.NpgsqlLine(a: 0.21461782395965212d, b: 0.4996081675192614d, c: 0.845029551763019d),

new NpgsqlTypes.NpgsqlLine(a: 0.14603833144353173d, b: 0.5155958582129082d, c: 0.9513100476397736d),

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
                Assert.That(model.Id, Is.EqualTo(1612037280));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9755688560619167d, b: 0.7517347444178538d, c: 0.4433097656621017d),

new NpgsqlTypes.NpgsqlLine(a: 0.27642151559126893d, b: 0.49560032188535075d, c: 0.4017019854911661d),

new NpgsqlTypes.NpgsqlLine(a: 0.48234378585453686d, b: 0.5838608048706788d, c: 0.45264440736135125d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1803941428));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4958174274877982d, b: 0.19935005698584918d, c: 0.6570481803156852d),

new NpgsqlTypes.NpgsqlLine(a: 0.586031122116916d, b: 0.20438200508300097d, c: 0.7214279726394314d),

new NpgsqlTypes.NpgsqlLine(a: 0.3287771922455527d, b: 0.31464931534195395d, c: 0.49275260904707807d),

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
                Assert.That(model.Id, Is.EqualTo(1694903385));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5133551130062282d, b: 0.5981369379522861d, c: 0.5856516805262975d),

new NpgsqlTypes.NpgsqlLine(a: 0.4556255479239121d, b: 0.059243842569019045d, c: 0.18272228811839042d),

new NpgsqlTypes.NpgsqlLine(a: 0.8085308768004308d, b: 0.8348590541320315d, c: 0.5895099353964641d),

new NpgsqlTypes.NpgsqlLine(a: 0.24149968696186774d, b: 0.35557480082622506d, c: 0.5451461752136405d),

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
                Assert.That(model.Id, Is.EqualTo(1708194464));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21378574042766885d, b: 0.22474127876321393d, c: 0.01286635194062602d),

new NpgsqlTypes.NpgsqlLine(a: 0.44720527497131246d, b: 0.83386820783986d, c: 0.47600740851603984d),

new NpgsqlTypes.NpgsqlLine(a: 0.9177345103701179d, b: 0.8135674766115204d, c: 0.23923291716083794d),

new NpgsqlTypes.NpgsqlLine(a: 0.9998743487003019d, b: 0.013427841900149451d, c: 0.9133209978570025d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(871029693));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09314286666835214d, b: 0.9419395542104619d, c: 0.23265001920909978d),

new NpgsqlTypes.NpgsqlLine(a: 0.7840922282915723d, b: 0.8769622177219351d, c: 0.08844919095146764d),

new NpgsqlTypes.NpgsqlLine(a: 0.30172065868559383d, b: 0.061796126836928256d, c: 0.7819510380905712d),

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
                Assert.That(model.Id, Is.EqualTo(1749272119));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48465570613062037d, b: 0.4077570571696034d, c: 0.09124205112015671d),

new NpgsqlTypes.NpgsqlLine(a: 0.4905692123673753d, b: 0.09753381316271936d, c: 0.6219861110019185d),

new NpgsqlTypes.NpgsqlLine(a: 0.7715584772299492d, b: 0.7647042738214676d, c: 0.32981711302760286d),

new NpgsqlTypes.NpgsqlLine(a: 0.7826950107361046d, b: 0.6159017458991703d, c: 0.8761288210787351d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05854830086605134d, b: 0.4584727830793912d, c: 0.6485776355671607d),

new NpgsqlTypes.NpgsqlLine(a: 0.057402368952540694d, b: 0.814338567877536d, c: 0.36045674525095406d),

new NpgsqlTypes.NpgsqlLine(a: 0.4609921668504162d, b: 0.45446719793916357d, c: 0.6647833262693906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8421363107491464d, b: 0.8724917366553757d, c: 0.2954174236384989d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743101311));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30049737151744216d, b: 0.10935998965187232d, c: 0.12002566064851483d),

new NpgsqlTypes.NpgsqlLine(a: 0.4579983959880112d, b: 0.8700234892072651d, c: 0.24545341370685325d),

new NpgsqlTypes.NpgsqlLine(a: 0.6992061752442d, b: 0.8760611086508132d, c: 0.31896424715232463d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14975557199832845d, b: 0.8649037801511367d, c: 0.8035067258718913d),

new NpgsqlTypes.NpgsqlLine(a: 0.022767088770272226d, b: 0.824519829812387d, c: 0.2990170967826957d),

new NpgsqlTypes.NpgsqlLine(a: 0.264229467978496d, b: 0.4707396384081288d, c: 0.5870444614457326d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1750072079));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6509605768915644d, b: 0.2871280523199907d, c: 0.5279864073907687d),

new NpgsqlTypes.NpgsqlLine(a: 0.847627780191932d, b: 0.2863239370866939d, c: 0.39664595009550063d),

new NpgsqlTypes.NpgsqlLine(a: 0.06719070091173818d, b: 0.2998868113793318d, c: 0.8109899934095542d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30402634597868494d, b: 0.7741177113732105d, c: 0.4982697795456863d),

new NpgsqlTypes.NpgsqlLine(a: 0.22134239051678783d, b: 0.952989590947333d, c: 0.1976805178607327d),

new NpgsqlTypes.NpgsqlLine(a: 0.48019693876130953d, b: 0.8553553442730837d, c: 0.4578014530562905d),

new NpgsqlTypes.NpgsqlLine(a: 0.7948720279836796d, b: 0.6347165612507009d, c: 0.4915047790558922d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(681877477));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.054876749435908034d, b: 0.7476698065656858d, c: 0.5221215501493097d),

new NpgsqlTypes.NpgsqlLine(a: 0.1689911006864584d, b: 0.16032672190790076d, c: 0.9537953031702238d),

new NpgsqlTypes.NpgsqlLine(a: 0.3133690487713232d, b: 0.21425817972116357d, c: 0.39002508371565625d),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1765269457));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4428210775962541d, b: 0.44628545865868685d, c: 0.7913435097925557d),

new NpgsqlTypes.NpgsqlLine(a: 0.26419018627718516d, b: 0.12166427922453704d, c: 0.11250832552770584d),

new NpgsqlTypes.NpgsqlLine(a: 0.20276585628171784d, b: 0.14489314174625478d, c: 0.5410582863519566d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(699428708));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.75437435623167d, b: 0.4381969103973332d, c: 0.13859938549471296d),

new NpgsqlTypes.NpgsqlLine(a: 0.22478326045746155d, b: 0.7927996319630696d, c: 0.5653146543488808d),

new NpgsqlTypes.NpgsqlLine(a: 0.8148660813324691d, b: 0.5965502974097225d, c: 0.08598406767552191d),

new NpgsqlTypes.NpgsqlLine(a: 0.10261855436837408d, b: 0.22753843400620033d, c: 0.6663050101504865d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19047502268477823d, b: 0.503647750986701d, c: 0.5140837344549085d),

new NpgsqlTypes.NpgsqlLine(a: 0.5498279015442291d, b: 0.5205498180433044d, c: 0.5511400439881968d),

new NpgsqlTypes.NpgsqlLine(a: 0.07519565206915457d, b: 0.8190939422278946d, c: 0.4842243543091963d),

new NpgsqlTypes.NpgsqlLine(a: 0.11151345358207676d, b: 0.2794260095615846d, c: 0.1977999861392018d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineArraylineArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(24431063));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7432562260700321d, b: 0.9027051106351455d, c: 0.20935776301702913d),

new NpgsqlTypes.NpgsqlLine(a: 0.06877648068052133d, b: 0.4638520424251973d, c: 0.8977581074629934d),

new NpgsqlTypes.NpgsqlLine(a: 0.19824889810271595d, b: 0.101805635004653d, c: 0.6376796129171594d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.25692356453649523d, b: 0.8249956321761069d, c: 0.7485760418256393d),

new NpgsqlTypes.NpgsqlLine(a: 0.5205543536927003d, b: 0.26409313743898866d, c: 0.11834223656249432d),

new NpgsqlTypes.NpgsqlLine(a: 0.12852097087774939d, b: 0.110468841038458d, c: 0.15781368742463253d),

new NpgsqlTypes.NpgsqlLine(a: 0.5056691167374713d, b: 0.17475361978672044d, c: 0.4301177356479713d),

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
                Assert.That(model.Id, Is.EqualTo(88466632));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24038691940074952d, b: 0.4574071819075469d, c: 0.029018693781179494d),

new NpgsqlTypes.NpgsqlLine(a: 0.6230691191149946d, b: 0.6421350132669393d, c: 0.2591755154295573d),

new NpgsqlTypes.NpgsqlLine(a: 0.284214063978114d, b: 0.42055782459666247d, c: 0.4230265799247275d),

new NpgsqlTypes.NpgsqlLine(a: 0.2294933978523651d, b: 0.8434657220550107d, c: 0.1364803149185917d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(671378680));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.579485378096583d, b: 0.7644192687968542d, c: 0.38803543767659376d),

new NpgsqlTypes.NpgsqlLine(a: 0.9272224559192928d, b: 0.04309922869802718d, c: 0.1084146589578524d),

new NpgsqlTypes.NpgsqlLine(a: 0.6194396921461146d, b: 0.3135327751395446d, c: 0.47728859432318693d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22238461731837955d, b: 0.8832575247518029d, c: 0.5267192016109244d),

new NpgsqlTypes.NpgsqlLine(a: 0.2456814921559901d, b: 0.12396858431218405d, c: 0.7758983059785806d),

new NpgsqlTypes.NpgsqlLine(a: 0.8010355013907535d, b: 0.10724380078506457d, c: 0.8516226142927568d),

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
                Assert.That(model.Id, Is.EqualTo(214898413));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7273918164372143d, b: 0.3711769692436181d, c: 0.7468659136792664d),

new NpgsqlTypes.NpgsqlLine(a: 0.8155250372031967d, b: 0.5364157660240247d, c: 0.2587745327315204d),

new NpgsqlTypes.NpgsqlLine(a: 0.8823774478354753d, b: 0.24032876435579376d, c: 0.9187231882533503d),

new NpgsqlTypes.NpgsqlLine(a: 0.2761563267007917d, b: 0.8609521972165307d, c: 0.014350256291767893d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7060914743005817d, b: 0.29942700622480667d, c: 0.38464564338188945d),

new NpgsqlTypes.NpgsqlLine(a: 0.456801666295529d, b: 0.2750050419905442d, c: 0.6523990372650718d),

new NpgsqlTypes.NpgsqlLine(a: 0.593068234761201d, b: 0.986042625015402d, c: 0.7722918655162653d),

new NpgsqlTypes.NpgsqlLine(a: 0.8257270425360131d, b: 0.9234733383976109d, c: 0.16399605960296715d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(160844459));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.49742066568592347d, b: 0.13045995730850435d, c: 0.3240701079822569d),

new NpgsqlTypes.NpgsqlLine(a: 0.4230136983146885d, b: 0.4758823758243249d, c: 0.7245296150407883d),

new NpgsqlTypes.NpgsqlLine(a: 0.902525000709505d, b: 0.3096633545847971d, c: 0.7195095860492445d),

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
                Assert.That(model.Id, Is.EqualTo(232426060));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7754569347332767d, b: 0.7449423603392903d, c: 0.7275357910733291d),

new NpgsqlTypes.NpgsqlLine(a: 0.9072872865290874d, b: 0.5188651109794405d, c: 0.49767196437474315d),

new NpgsqlTypes.NpgsqlLine(a: 0.7613773478086597d, b: 0.8726134777514618d, c: 0.7249287737318102d),

new NpgsqlTypes.NpgsqlLine(a: 0.31979325488547383d, b: 0.21963013317369884d, c: 0.995747479981123d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5136334997132156d, b: 0.4481836733144653d, c: 0.5566013930940901d),

new NpgsqlTypes.NpgsqlLine(a: 0.2628604279970359d, b: 0.34706683348460354d, c: 0.8618758810041756d),

new NpgsqlTypes.NpgsqlLine(a: 0.9066993846202163d, b: 0.9919335952888788d, c: 0.16647553451680086d),

new NpgsqlTypes.NpgsqlLine(a: 0.8084713734948656d, b: 0.9105928653749232d, c: 0.5871692331069964d),

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

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(287773256));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5468129373528992d, b: 0.4550697398151482d, c: 0.9323204190693627d),

new NpgsqlTypes.NpgsqlLine(a: 0.09290076953581794d, b: 0.06513797114322906d, c: 0.01453530584939322d),

new NpgsqlTypes.NpgsqlLine(a: 0.06819515445977387d, b: 0.13776512554356624d, c: 0.5971045649241554d),

new NpgsqlTypes.NpgsqlLine(a: 0.17602847632288898d, b: 0.8583377493377162d, c: 0.5319193518068348d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2000087272));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5174417835536576d, b: 0.9550151039410834d, c: 0.94465021980697d),

new NpgsqlTypes.NpgsqlLine(a: 0.023498567205728516d, b: 0.14704570142511664d, c: 0.5436176118381062d),

new NpgsqlTypes.NpgsqlLine(a: 0.6410825125912296d, b: 0.1638519482392854d, c: 0.07442290044208977d),

new NpgsqlTypes.NpgsqlLine(a: 0.5684954410076702d, b: 0.9517870324925599d, c: 0.7913121037671743d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5546781844769255d, b: 0.3295435210405563d, c: 0.10332785525555d),

new NpgsqlTypes.NpgsqlLine(a: 0.8619184029547027d, b: 0.6893143841340763d, c: 0.6057919377815917d),

new NpgsqlTypes.NpgsqlLine(a: 0.6918049340506819d, b: 0.29564467871458977d, c: 0.373851052320022d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590711543927416d, b: 0.782456230485786d, c: 0.0557514543823312d),

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
                Assert.That(model.Id, Is.EqualTo(385864550));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22975102280111437d, b: 0.9248487581270293d, c: 0.13680981887715193d),

new NpgsqlTypes.NpgsqlLine(a: 0.09251582159332017d, b: 0.5284902712490177d, c: 0.5030244379828798d),

new NpgsqlTypes.NpgsqlLine(a: 0.3316636973424488d, b: 0.125908586516723d, c: 0.1307901665228316d),

new NpgsqlTypes.NpgsqlLine(a: 0.4488357278586823d, b: 0.4939460007710509d, c: 0.1486125807477222d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4793632894446783d, b: 0.7460924351194599d, c: 0.8333281971866928d),

new NpgsqlTypes.NpgsqlLine(a: 0.9911204719862435d, b: 0.02386428262012663d, c: 0.1749191984110413d),

new NpgsqlTypes.NpgsqlLine(a: 0.9855596015822274d, b: 0.652336551342683d, c: 0.13320036109805444d),

new NpgsqlTypes.NpgsqlLine(a: 0.2704642620419001d, b: 0.25815455585325764d, c: 0.781691467105331d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(507016837));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6329641939546133d, b: 0.7713358064075255d, c: 0.7091675230581173d),

new NpgsqlTypes.NpgsqlLine(a: 0.6401104534145889d, b: 0.4461488045009705d, c: 0.8050604324576476d),

new NpgsqlTypes.NpgsqlLine(a: 0.718200194405203d, b: 0.43497844061299695d, c: 0.8863292600245054d),

new NpgsqlTypes.NpgsqlLine(a: 0.6409377372303063d, b: 0.6727026439221405d, c: 0.709162570856183d),

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
                Assert.That(model.Id, Is.EqualTo(425879955));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7120720914880876d, b: 0.12018496532744738d, c: 0.23458035596972604d),

new NpgsqlTypes.NpgsqlLine(a: 0.8966943482850258d, b: 0.35901938172619774d, c: 0.5153333646331681d),

new NpgsqlTypes.NpgsqlLine(a: 0.772529205234202d, b: 0.3302141544038909d, c: 0.49860223574471696d),

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
                Assert.That(model.Id, Is.EqualTo(447065450));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6636554004535458d, b: 0.4052905058278198d, c: 0.17999403534412883d),

new NpgsqlTypes.NpgsqlLine(a: 0.4929643299593621d, b: 0.04102771738828992d, c: 0.8758588440576921d),

new NpgsqlTypes.NpgsqlLine(a: 0.9843591359807438d, b: 0.9486545770421181d, c: 0.23810538982780194d),

new NpgsqlTypes.NpgsqlLine(a: 0.0373504814930844d, b: 0.29650224807426506d, c: 0.6527517869517908d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1935239880));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5125009420178407d, b: 0.13553866813087467d, c: 0.6573124881706722d),

new NpgsqlTypes.NpgsqlLine(a: 0.9315668534985179d, b: 0.031339976871202935d, c: 0.7319776155987312d),

new NpgsqlTypes.NpgsqlLine(a: 0.5913519522327184d, b: 0.688194613219936d, c: 0.7487303543444555d),

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
                Assert.That(model.Id, Is.EqualTo(776647699));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8841755970938628d, b: 0.039993263617271846d, c: 0.2425222413816407d),

new NpgsqlTypes.NpgsqlLine(a: 0.3162669055857611d, b: 0.1360654949714053d, c: 0.585066125260232d),

new NpgsqlTypes.NpgsqlLine(a: 0.23614085233198578d, b: 0.9624524908146396d, c: 0.8036122013629919d),

new NpgsqlTypes.NpgsqlLine(a: 0.9594786748108928d, b: 0.3334512033062713d, c: 0.8626799508985245d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7692177568154062d, b: 0.8045212370680859d, c: 0.347836807601842d),

new NpgsqlTypes.NpgsqlLine(a: 0.8596806867272218d, b: 0.42225206488490163d, c: 0.2626771759427945d),

new NpgsqlTypes.NpgsqlLine(a: 0.6334601490046422d, b: 0.5508277640730257d, c: 0.9702039181027914d),

new NpgsqlTypes.NpgsqlLine(a: 0.7862671596820799d, b: 0.6148121550149941d, c: 0.10467782441316142d),

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
                Assert.That(model.Id, Is.EqualTo(920410273));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7950181430955406d, b: 0.3848051391253504d, c: 0.1572657802170856d),

new NpgsqlTypes.NpgsqlLine(a: 0.6062151918599252d, b: 0.06062326101597226d, c: 0.14777044879318857d),

new NpgsqlTypes.NpgsqlLine(a: 0.7408182398935058d, b: 0.6661433504932776d, c: 0.15722709569280902d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2482561889064241d, b: 0.768360521777252d, c: 0.24033198573060877d),

new NpgsqlTypes.NpgsqlLine(a: 0.6078828832971318d, b: 0.25910942482320465d, c: 0.7624300130707319d),

new NpgsqlTypes.NpgsqlLine(a: 0.551230062109523d, b: 0.5951997473266207d, c: 0.05557568229198884d),

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
                Assert.That(model.Id, Is.EqualTo(929385902));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8285395037487209d, b: 0.25070273066629d, c: 0.2500673109161923d),

new NpgsqlTypes.NpgsqlLine(a: 0.9942717530143405d, b: 0.21539215026712022d, c: 0.20269945939501077d),

new NpgsqlTypes.NpgsqlLine(a: 0.7979702358088475d, b: 0.0037115614378556705d, c: 0.8843432168677479d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1456202870910711d, b: 0.06772665910903597d, c: 0.691750610472359d),

new NpgsqlTypes.NpgsqlLine(a: 0.765757989281042d, b: 0.32982835634782004d, c: 0.8913701807765988d),

new NpgsqlTypes.NpgsqlLine(a: 0.052240732409688406d, b: 0.618262798295761d, c: 0.8474290495942781d),

new NpgsqlTypes.NpgsqlLine(a: 0.3584922315949717d, b: 0.520574773115294d, c: 0.8310230234204736d),

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
                Assert.That(model.Id, Is.EqualTo(939691488));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15928813769803307d, b: 0.5335096410959914d, c: 0.9693141891385088d),

new NpgsqlTypes.NpgsqlLine(a: 0.9448241901930845d, b: 0.6287076527827521d, c: 0.6660617468801671d),

new NpgsqlTypes.NpgsqlLine(a: 0.30712778702622445d, b: 0.324942912367581d, c: 0.9500282198259326d),

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
                Assert.That(model.Id, Is.EqualTo(940484658));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8457530794410952d, b: 0.07468146527745967d, c: 0.6058450234777081d),

new NpgsqlTypes.NpgsqlLine(a: 0.43907623012482566d, b: 0.4163533057091461d, c: 0.7083053151407345d),

new NpgsqlTypes.NpgsqlLine(a: 0.6460729456777172d, b: 0.3996032448892458d, c: 0.32058136990645736d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5056133907420888d, b: 0.687789482585691d, c: 0.5736898296981361d),

new NpgsqlTypes.NpgsqlLine(a: 0.6165837793609097d, b: 0.3896094649555947d, c: 0.782529168193896d),

new NpgsqlTypes.NpgsqlLine(a: 0.19522061405511182d, b: 0.49515141325692447d, c: 0.8154303350690599d),

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
                Assert.That(model.Id, Is.EqualTo(956171576));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6305558129660189d, b: 0.5463622939629917d, c: 0.401891977997777d),

new NpgsqlTypes.NpgsqlLine(a: 0.3662230087345998d, b: 0.4302679455886196d, c: 0.9631184941583132d),

new NpgsqlTypes.NpgsqlLine(a: 0.3634906094993412d, b: 0.18046820180120404d, c: 0.5193725822662353d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48533853922222536d, b: 0.7781157007327932d, c: 0.20671476643143427d),

new NpgsqlTypes.NpgsqlLine(a: 0.7321919326621603d, b: 0.7704043405190548d, c: 0.5508846640658778d),

new NpgsqlTypes.NpgsqlLine(a: 0.5796306726535371d, b: 0.3621536966457104d, c: 0.3554092618887771d),

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
                Assert.That(model.Id, Is.EqualTo(1049476690));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1703167002028123d, b: 0.06899134909065618d, c: 0.39632655876575884d),

new NpgsqlTypes.NpgsqlLine(a: 0.9436521110809849d, b: 0.2716102490692832d, c: 0.21807972083943694d),

new NpgsqlTypes.NpgsqlLine(a: 0.07510391898176405d, b: 0.4622700624960824d, c: 0.6916474126671974d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3434566231012316d, b: 0.6092872970160005d, c: 0.8285200623737458d),

new NpgsqlTypes.NpgsqlLine(a: 0.438620087459067d, b: 0.42784452615069857d, c: 0.43791996431227087d),

new NpgsqlTypes.NpgsqlLine(a: 0.13822472685663223d, b: 0.3567687904324768d, c: 0.5713362361619454d),

new NpgsqlTypes.NpgsqlLine(a: 0.4225842002023096d, b: 0.13041963778907273d, c: 0.537431949671262d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(259689541));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16915141278580792d, b: 0.5107686791340034d, c: 0.6489920882506348d),

new NpgsqlTypes.NpgsqlLine(a: 0.030879513236027d, b: 0.6401283771223818d, c: 0.4904762444562075d),

new NpgsqlTypes.NpgsqlLine(a: 0.16124954101586042d, b: 0.7102870300472969d, c: 0.9978682907813775d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3413197342637151d, b: 0.3564754218301692d, c: 0.16698356005321802d),

new NpgsqlTypes.NpgsqlLine(a: 0.24996465538547474d, b: 0.6936235099874405d, c: 0.00768766971096424d),

new NpgsqlTypes.NpgsqlLine(a: 0.9713834412198872d, b: 0.1937685310996965d, c: 0.5638524218711839d),

new NpgsqlTypes.NpgsqlLine(a: 0.20790035052620326d, b: 0.7280555648340241d, c: 0.7150389111804211d),

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
                Assert.That(model.Id, Is.EqualTo(1169283916));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6136867588329713d, b: 0.8476721243007673d, c: 0.2920466838690219d),

new NpgsqlTypes.NpgsqlLine(a: 0.5632572533709046d, b: 0.8580393386665631d, c: 0.29067186403759726d),

new NpgsqlTypes.NpgsqlLine(a: 0.05864985939465561d, b: 0.06933376015004311d, c: 0.2622230618531959d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3083889075922114d, b: 0.40504233141015844d, c: 0.7282625593772889d),

new NpgsqlTypes.NpgsqlLine(a: 0.9760389595620657d, b: 0.5432046524856411d, c: 0.4805721407516501d),

new NpgsqlTypes.NpgsqlLine(a: 0.226094370846618d, b: 0.30929816503923757d, c: 0.749788108094253d),

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

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1247961184));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588334999708729d, b: 0.5781258655739143d, c: 0.4951203893647069d),

new NpgsqlTypes.NpgsqlLine(a: 0.206651781249944d, b: 0.9214488824097644d, c: 0.7102197735978709d),

new NpgsqlTypes.NpgsqlLine(a: 0.8293873017859008d, b: 0.4197388618664637d, c: 0.7538628331143343d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9886122302398814d, b: 0.09733443476141157d, c: 0.8828756753279827d),

new NpgsqlTypes.NpgsqlLine(a: 0.4191781730328399d, b: 0.8360940579259326d, c: 0.3115604346093266d),

new NpgsqlTypes.NpgsqlLine(a: 0.03123256692948395d, b: 0.4210178852779579d, c: 0.7083559364281564d),

new NpgsqlTypes.NpgsqlLine(a: 0.10193811062121638d, b: 0.7865607707379441d, c: 0.5102014504618864d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(313349652));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7148027863911385d, b: 0.4116315290140842d, c: 0.9883513693293022d),

new NpgsqlTypes.NpgsqlLine(a: 0.730798769811796d, b: 0.5625059295801093d, c: 0.028144945623879147d),

new NpgsqlTypes.NpgsqlLine(a: 0.7895921923207063d, b: 0.897092096080744d, c: 0.36804397804374556d),

new NpgsqlTypes.NpgsqlLine(a: 0.4403951364132078d, b: 0.48316034726668566d, c: 0.5561087583026281d),

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
                Assert.That(model.Id, Is.EqualTo(1251267268));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.27064576558959075d, b: 0.24611103650290955d, c: 0.04928435530376152d),

new NpgsqlTypes.NpgsqlLine(a: 0.5382620257248645d, b: 0.586731968734226d, c: 0.9110741668368397d),

new NpgsqlTypes.NpgsqlLine(a: 0.8386954216871374d, b: 0.14045527908308764d, c: 0.5300328684198944d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7572326327773035d, b: 0.10039993499818312d, c: 0.17339739029118428d),

new NpgsqlTypes.NpgsqlLine(a: 0.9566618331567527d, b: 0.14668861402647748d, c: 0.7767711369985796d),

new NpgsqlTypes.NpgsqlLine(a: 0.932727244163919d, b: 0.12159065636952726d, c: 0.1704609096711438d),

new NpgsqlTypes.NpgsqlLine(a: 0.5792460825794749d, b: 0.985437582839235d, c: 0.557473090399633d),

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

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276251566));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4808529939808879d, b: 0.365247596328651d, c: 0.17939866902766977d),

new NpgsqlTypes.NpgsqlLine(a: 0.12809708913748585d, b: 0.18821025600986407d, c: 0.9740037535570704d),

new NpgsqlTypes.NpgsqlLine(a: 0.7729579560840041d, b: 0.5283959837814016d, c: 0.3246873097765165d),

new NpgsqlTypes.NpgsqlLine(a: 0.5804554841359071d, b: 0.7951318743812129d, c: 0.9533437460862759d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07357632206959641d, b: 0.11099061080365447d, c: 0.47576723756466854d),

new NpgsqlTypes.NpgsqlLine(a: 0.9051522311200175d, b: 0.6041352781626989d, c: 0.962846313750425d),

new NpgsqlTypes.NpgsqlLine(a: 0.7230697163609032d, b: 0.35996997662147945d, c: 0.2719627850842049d),

new NpgsqlTypes.NpgsqlLine(a: 0.039972657007877d, b: 0.6660692046588974d, c: 0.8074219604808613d),

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

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1278639929));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8637991908928382d, b: 0.7989476928355281d, c: 0.047074497669961635d),

new NpgsqlTypes.NpgsqlLine(a: 0.24284327761860214d, b: 0.034845279321367495d, c: 0.8243144068858446d),

new NpgsqlTypes.NpgsqlLine(a: 0.2705173386529084d, b: 0.37759514414776285d, c: 0.003784057263189533d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5464646368268954d, b: 0.1698011067851829d, c: 0.4811896051504386d),

new NpgsqlTypes.NpgsqlLine(a: 0.3264558304845737d, b: 0.09741548986796533d, c: 0.35078408755418944d),

new NpgsqlTypes.NpgsqlLine(a: 0.1253849539183054d, b: 0.9184504405667023d, c: 0.6244095303662431d),

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
                Assert.That(model.Id, Is.EqualTo(1352296160));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6961581521563707d, b: 0.2870425810465653d, c: 0.022813771410836625d),

new NpgsqlTypes.NpgsqlLine(a: 0.9289180434806266d, b: 0.10310192777053839d, c: 0.4974840036652155d),

new NpgsqlTypes.NpgsqlLine(a: 0.9742618124298718d, b: 0.666155889593685d, c: 0.9108800941033853d),

new NpgsqlTypes.NpgsqlLine(a: 0.4076993728994177d, b: 0.9237619110159688d, c: 0.16349574316883708d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.40245830157937157d, b: 0.4425237993192568d, c: 0.3605907953188545d),

new NpgsqlTypes.NpgsqlLine(a: 0.3025387755185438d, b: 0.16175616826033246d, c: 0.08369914886846197d),

new NpgsqlTypes.NpgsqlLine(a: 0.7932786053551402d, b: 0.4757892941852452d, c: 0.35215963103511483d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2052209240));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28682097488067404d, b: 0.19347953745544d, c: 0.767001580247448d),

new NpgsqlTypes.NpgsqlLine(a: 0.34168929191792363d, b: 0.5324263819109204d, c: 0.3548736591683712d),

new NpgsqlTypes.NpgsqlLine(a: 0.7601584215479089d, b: 0.9667193856859281d, c: 0.48805620341333844d),

new NpgsqlTypes.NpgsqlLine(a: 0.4778030273140724d, b: 0.6459214140044727d, c: 0.9825570138966864d),

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
                Assert.That(model.Id, Is.EqualTo(1422030401));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5508950376990435d, b: 0.1842011543506923d, c: 0.7200839172656331d),

new NpgsqlTypes.NpgsqlLine(a: 0.08098131741133519d, b: 0.2512744482896645d, c: 0.4419893154281408d),

new NpgsqlTypes.NpgsqlLine(a: 0.7183180834237055d, b: 0.3821225061156569d, c: 0.320010478004808d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.605461690855222d, b: 0.5098249599693536d, c: 0.049446338505273246d),

new NpgsqlTypes.NpgsqlLine(a: 0.6383133050473475d, b: 0.5385834180776717d, c: 0.2612256906158803d),

new NpgsqlTypes.NpgsqlLine(a: 0.2259744218921168d, b: 0.0504022254415285d, c: 0.5085817881315488d),

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
                Assert.That(model.Id, Is.EqualTo(1441068318));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04431673188157559d, b: 0.7118895502319815d, c: 0.8045459394080527d),

new NpgsqlTypes.NpgsqlLine(a: 0.41883883343441664d, b: 0.0856133325697227d, c: 0.45940150990219364d),

new NpgsqlTypes.NpgsqlLine(a: 0.3845455332415372d, b: 0.5278908004707358d, c: 0.45211852173959755d),

new NpgsqlTypes.NpgsqlLine(a: 0.707344526938849d, b: 0.2664835051263448d, c: 0.8012907013628192d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5167014945187821d, b: 0.2318523474732329d, c: 0.0766480392056259d),

new NpgsqlTypes.NpgsqlLine(a: 0.6239339834043951d, b: 0.4407650281616141d, c: 0.07711199216030074d),

new NpgsqlTypes.NpgsqlLine(a: 0.7330247230488705d, b: 0.06195929907587139d, c: 0.1736910797965654d),

new NpgsqlTypes.NpgsqlLine(a: 0.5060985759956755d, b: 0.12918142066992122d, c: 0.3598502037154421d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1349638635));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8811777097968191d, b: 0.09805743628781294d, c: 0.8476023389336619d),

new NpgsqlTypes.NpgsqlLine(a: 0.16329696312104391d, b: 0.8434248077846473d, c: 0.0171626874853823d),

new NpgsqlTypes.NpgsqlLine(a: 0.5930114320798587d, b: 0.7874763150232159d, c: 0.20169365861720767d),

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
                Assert.That(model.Id, Is.EqualTo(1485177216));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7620135774845544d, b: 0.72234986247445d, c: 0.7900958363555012d),

new NpgsqlTypes.NpgsqlLine(a: 0.5982892074823093d, b: 0.9157569165822279d, c: 0.5913666560112503d),

new NpgsqlTypes.NpgsqlLine(a: 0.3694255096703286d, b: 0.43689654039349735d, c: 0.27488642071951885d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1888587968));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9441675468790086d, b: 0.10273087249159918d, c: 0.36496868371913627d),

new NpgsqlTypes.NpgsqlLine(a: 0.3153900895384264d, b: 0.8953921593705707d, c: 0.6821583482258307d),

new NpgsqlTypes.NpgsqlLine(a: 0.15884512105184567d, b: 0.20745599422324912d, c: 0.5928677501305737d),

new NpgsqlTypes.NpgsqlLine(a: 0.19203772899196803d, b: 0.9281999546867626d, c: 0.9792553764463741d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.616453689236877d, b: 0.26880075600348696d, c: 0.9911672578342802d),

new NpgsqlTypes.NpgsqlLine(a: 0.41598816366831615d, b: 0.2972198032481773d, c: 0.6096249065094251d),

new NpgsqlTypes.NpgsqlLine(a: 0.21461782395965212d, b: 0.4996081675192614d, c: 0.845029551763019d),

new NpgsqlTypes.NpgsqlLine(a: 0.14603833144353173d, b: 0.5155958582129082d, c: 0.9513100476397736d),

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
                Assert.That(model.Id, Is.EqualTo(1612037280));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9755688560619167d, b: 0.7517347444178538d, c: 0.4433097656621017d),

new NpgsqlTypes.NpgsqlLine(a: 0.27642151559126893d, b: 0.49560032188535075d, c: 0.4017019854911661d),

new NpgsqlTypes.NpgsqlLine(a: 0.48234378585453686d, b: 0.5838608048706788d, c: 0.45264440736135125d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1803941428));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4958174274877982d, b: 0.19935005698584918d, c: 0.6570481803156852d),

new NpgsqlTypes.NpgsqlLine(a: 0.586031122116916d, b: 0.20438200508300097d, c: 0.7214279726394314d),

new NpgsqlTypes.NpgsqlLine(a: 0.3287771922455527d, b: 0.31464931534195395d, c: 0.49275260904707807d),

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
                Assert.That(model.Id, Is.EqualTo(1694903385));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5133551130062282d, b: 0.5981369379522861d, c: 0.5856516805262975d),

new NpgsqlTypes.NpgsqlLine(a: 0.4556255479239121d, b: 0.059243842569019045d, c: 0.18272228811839042d),

new NpgsqlTypes.NpgsqlLine(a: 0.8085308768004308d, b: 0.8348590541320315d, c: 0.5895099353964641d),

new NpgsqlTypes.NpgsqlLine(a: 0.24149968696186774d, b: 0.35557480082622506d, c: 0.5451461752136405d),

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
                Assert.That(model.Id, Is.EqualTo(1708194464));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21378574042766885d, b: 0.22474127876321393d, c: 0.01286635194062602d),

new NpgsqlTypes.NpgsqlLine(a: 0.44720527497131246d, b: 0.83386820783986d, c: 0.47600740851603984d),

new NpgsqlTypes.NpgsqlLine(a: 0.9177345103701179d, b: 0.8135674766115204d, c: 0.23923291716083794d),

new NpgsqlTypes.NpgsqlLine(a: 0.9998743487003019d, b: 0.013427841900149451d, c: 0.9133209978570025d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(871029693));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09314286666835214d, b: 0.9419395542104619d, c: 0.23265001920909978d),

new NpgsqlTypes.NpgsqlLine(a: 0.7840922282915723d, b: 0.8769622177219351d, c: 0.08844919095146764d),

new NpgsqlTypes.NpgsqlLine(a: 0.30172065868559383d, b: 0.061796126836928256d, c: 0.7819510380905712d),

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
                Assert.That(model.Id, Is.EqualTo(1749272119));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48465570613062037d, b: 0.4077570571696034d, c: 0.09124205112015671d),

new NpgsqlTypes.NpgsqlLine(a: 0.4905692123673753d, b: 0.09753381316271936d, c: 0.6219861110019185d),

new NpgsqlTypes.NpgsqlLine(a: 0.7715584772299492d, b: 0.7647042738214676d, c: 0.32981711302760286d),

new NpgsqlTypes.NpgsqlLine(a: 0.7826950107361046d, b: 0.6159017458991703d, c: 0.8761288210787351d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05854830086605134d, b: 0.4584727830793912d, c: 0.6485776355671607d),

new NpgsqlTypes.NpgsqlLine(a: 0.057402368952540694d, b: 0.814338567877536d, c: 0.36045674525095406d),

new NpgsqlTypes.NpgsqlLine(a: 0.4609921668504162d, b: 0.45446719793916357d, c: 0.6647833262693906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8421363107491464d, b: 0.8724917366553757d, c: 0.2954174236384989d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743101311));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30049737151744216d, b: 0.10935998965187232d, c: 0.12002566064851483d),

new NpgsqlTypes.NpgsqlLine(a: 0.4579983959880112d, b: 0.8700234892072651d, c: 0.24545341370685325d),

new NpgsqlTypes.NpgsqlLine(a: 0.6992061752442d, b: 0.8760611086508132d, c: 0.31896424715232463d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14975557199832845d, b: 0.8649037801511367d, c: 0.8035067258718913d),

new NpgsqlTypes.NpgsqlLine(a: 0.022767088770272226d, b: 0.824519829812387d, c: 0.2990170967826957d),

new NpgsqlTypes.NpgsqlLine(a: 0.264229467978496d, b: 0.4707396384081288d, c: 0.5870444614457326d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1750072079));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6509605768915644d, b: 0.2871280523199907d, c: 0.5279864073907687d),

new NpgsqlTypes.NpgsqlLine(a: 0.847627780191932d, b: 0.2863239370866939d, c: 0.39664595009550063d),

new NpgsqlTypes.NpgsqlLine(a: 0.06719070091173818d, b: 0.2998868113793318d, c: 0.8109899934095542d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30402634597868494d, b: 0.7741177113732105d, c: 0.4982697795456863d),

new NpgsqlTypes.NpgsqlLine(a: 0.22134239051678783d, b: 0.952989590947333d, c: 0.1976805178607327d),

new NpgsqlTypes.NpgsqlLine(a: 0.48019693876130953d, b: 0.8553553442730837d, c: 0.4578014530562905d),

new NpgsqlTypes.NpgsqlLine(a: 0.7948720279836796d, b: 0.6347165612507009d, c: 0.4915047790558922d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(681877477));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.054876749435908034d, b: 0.7476698065656858d, c: 0.5221215501493097d),

new NpgsqlTypes.NpgsqlLine(a: 0.1689911006864584d, b: 0.16032672190790076d, c: 0.9537953031702238d),

new NpgsqlTypes.NpgsqlLine(a: 0.3133690487713232d, b: 0.21425817972116357d, c: 0.39002508371565625d),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1765269457));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4428210775962541d, b: 0.44628545865868685d, c: 0.7913435097925557d),

new NpgsqlTypes.NpgsqlLine(a: 0.26419018627718516d, b: 0.12166427922453704d, c: 0.11250832552770584d),

new NpgsqlTypes.NpgsqlLine(a: 0.20276585628171784d, b: 0.14489314174625478d, c: 0.5410582863519566d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(699428708));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.75437435623167d, b: 0.4381969103973332d, c: 0.13859938549471296d),

new NpgsqlTypes.NpgsqlLine(a: 0.22478326045746155d, b: 0.7927996319630696d, c: 0.5653146543488808d),

new NpgsqlTypes.NpgsqlLine(a: 0.8148660813324691d, b: 0.5965502974097225d, c: 0.08598406767552191d),

new NpgsqlTypes.NpgsqlLine(a: 0.10261855436837408d, b: 0.22753843400620033d, c: 0.6663050101504865d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19047502268477823d, b: 0.503647750986701d, c: 0.5140837344549085d),

new NpgsqlTypes.NpgsqlLine(a: 0.5498279015442291d, b: 0.5205498180433044d, c: 0.5511400439881968d),

new NpgsqlTypes.NpgsqlLine(a: 0.07519565206915457d, b: 0.8190939422278946d, c: 0.4842243543091963d),

new NpgsqlTypes.NpgsqlLine(a: 0.11151345358207676d, b: 0.2794260095615846d, c: 0.1977999861392018d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(NpgsqlLinelineArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)
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
                var models =  ((INpgsqlLineArraylineArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(24431063));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7432562260700321d, b: 0.9027051106351455d, c: 0.20935776301702913d),

new NpgsqlTypes.NpgsqlLine(a: 0.06877648068052133d, b: 0.4638520424251973d, c: 0.8977581074629934d),

new NpgsqlTypes.NpgsqlLine(a: 0.19824889810271595d, b: 0.101805635004653d, c: 0.6376796129171594d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.25692356453649523d, b: 0.8249956321761069d, c: 0.7485760418256393d),

new NpgsqlTypes.NpgsqlLine(a: 0.5205543536927003d, b: 0.26409313743898866d, c: 0.11834223656249432d),

new NpgsqlTypes.NpgsqlLine(a: 0.12852097087774939d, b: 0.110468841038458d, c: 0.15781368742463253d),

new NpgsqlTypes.NpgsqlLine(a: 0.5056691167374713d, b: 0.17475361978672044d, c: 0.4301177356479713d),

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
                Assert.That(model.Id, Is.EqualTo(88466632));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24038691940074952d, b: 0.4574071819075469d, c: 0.029018693781179494d),

new NpgsqlTypes.NpgsqlLine(a: 0.6230691191149946d, b: 0.6421350132669393d, c: 0.2591755154295573d),

new NpgsqlTypes.NpgsqlLine(a: 0.284214063978114d, b: 0.42055782459666247d, c: 0.4230265799247275d),

new NpgsqlTypes.NpgsqlLine(a: 0.2294933978523651d, b: 0.8434657220550107d, c: 0.1364803149185917d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(671378680));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.579485378096583d, b: 0.7644192687968542d, c: 0.38803543767659376d),

new NpgsqlTypes.NpgsqlLine(a: 0.9272224559192928d, b: 0.04309922869802718d, c: 0.1084146589578524d),

new NpgsqlTypes.NpgsqlLine(a: 0.6194396921461146d, b: 0.3135327751395446d, c: 0.47728859432318693d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22238461731837955d, b: 0.8832575247518029d, c: 0.5267192016109244d),

new NpgsqlTypes.NpgsqlLine(a: 0.2456814921559901d, b: 0.12396858431218405d, c: 0.7758983059785806d),

new NpgsqlTypes.NpgsqlLine(a: 0.8010355013907535d, b: 0.10724380078506457d, c: 0.8516226142927568d),

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
                Assert.That(model.Id, Is.EqualTo(214898413));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7273918164372143d, b: 0.3711769692436181d, c: 0.7468659136792664d),

new NpgsqlTypes.NpgsqlLine(a: 0.8155250372031967d, b: 0.5364157660240247d, c: 0.2587745327315204d),

new NpgsqlTypes.NpgsqlLine(a: 0.8823774478354753d, b: 0.24032876435579376d, c: 0.9187231882533503d),

new NpgsqlTypes.NpgsqlLine(a: 0.2761563267007917d, b: 0.8609521972165307d, c: 0.014350256291767893d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7060914743005817d, b: 0.29942700622480667d, c: 0.38464564338188945d),

new NpgsqlTypes.NpgsqlLine(a: 0.456801666295529d, b: 0.2750050419905442d, c: 0.6523990372650718d),

new NpgsqlTypes.NpgsqlLine(a: 0.593068234761201d, b: 0.986042625015402d, c: 0.7722918655162653d),

new NpgsqlTypes.NpgsqlLine(a: 0.8257270425360131d, b: 0.9234733383976109d, c: 0.16399605960296715d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(160844459));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.49742066568592347d, b: 0.13045995730850435d, c: 0.3240701079822569d),

new NpgsqlTypes.NpgsqlLine(a: 0.4230136983146885d, b: 0.4758823758243249d, c: 0.7245296150407883d),

new NpgsqlTypes.NpgsqlLine(a: 0.902525000709505d, b: 0.3096633545847971d, c: 0.7195095860492445d),

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
                Assert.That(model.Id, Is.EqualTo(232426060));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7754569347332767d, b: 0.7449423603392903d, c: 0.7275357910733291d),

new NpgsqlTypes.NpgsqlLine(a: 0.9072872865290874d, b: 0.5188651109794405d, c: 0.49767196437474315d),

new NpgsqlTypes.NpgsqlLine(a: 0.7613773478086597d, b: 0.8726134777514618d, c: 0.7249287737318102d),

new NpgsqlTypes.NpgsqlLine(a: 0.31979325488547383d, b: 0.21963013317369884d, c: 0.995747479981123d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5136334997132156d, b: 0.4481836733144653d, c: 0.5566013930940901d),

new NpgsqlTypes.NpgsqlLine(a: 0.2628604279970359d, b: 0.34706683348460354d, c: 0.8618758810041756d),

new NpgsqlTypes.NpgsqlLine(a: 0.9066993846202163d, b: 0.9919335952888788d, c: 0.16647553451680086d),

new NpgsqlTypes.NpgsqlLine(a: 0.8084713734948656d, b: 0.9105928653749232d, c: 0.5871692331069964d),

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

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(287773256));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5468129373528992d, b: 0.4550697398151482d, c: 0.9323204190693627d),

new NpgsqlTypes.NpgsqlLine(a: 0.09290076953581794d, b: 0.06513797114322906d, c: 0.01453530584939322d),

new NpgsqlTypes.NpgsqlLine(a: 0.06819515445977387d, b: 0.13776512554356624d, c: 0.5971045649241554d),

new NpgsqlTypes.NpgsqlLine(a: 0.17602847632288898d, b: 0.8583377493377162d, c: 0.5319193518068348d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2000087272));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5174417835536576d, b: 0.9550151039410834d, c: 0.94465021980697d),

new NpgsqlTypes.NpgsqlLine(a: 0.023498567205728516d, b: 0.14704570142511664d, c: 0.5436176118381062d),

new NpgsqlTypes.NpgsqlLine(a: 0.6410825125912296d, b: 0.1638519482392854d, c: 0.07442290044208977d),

new NpgsqlTypes.NpgsqlLine(a: 0.5684954410076702d, b: 0.9517870324925599d, c: 0.7913121037671743d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5546781844769255d, b: 0.3295435210405563d, c: 0.10332785525555d),

new NpgsqlTypes.NpgsqlLine(a: 0.8619184029547027d, b: 0.6893143841340763d, c: 0.6057919377815917d),

new NpgsqlTypes.NpgsqlLine(a: 0.6918049340506819d, b: 0.29564467871458977d, c: 0.373851052320022d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590711543927416d, b: 0.782456230485786d, c: 0.0557514543823312d),

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
                Assert.That(model.Id, Is.EqualTo(385864550));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22975102280111437d, b: 0.9248487581270293d, c: 0.13680981887715193d),

new NpgsqlTypes.NpgsqlLine(a: 0.09251582159332017d, b: 0.5284902712490177d, c: 0.5030244379828798d),

new NpgsqlTypes.NpgsqlLine(a: 0.3316636973424488d, b: 0.125908586516723d, c: 0.1307901665228316d),

new NpgsqlTypes.NpgsqlLine(a: 0.4488357278586823d, b: 0.4939460007710509d, c: 0.1486125807477222d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4793632894446783d, b: 0.7460924351194599d, c: 0.8333281971866928d),

new NpgsqlTypes.NpgsqlLine(a: 0.9911204719862435d, b: 0.02386428262012663d, c: 0.1749191984110413d),

new NpgsqlTypes.NpgsqlLine(a: 0.9855596015822274d, b: 0.652336551342683d, c: 0.13320036109805444d),

new NpgsqlTypes.NpgsqlLine(a: 0.2704642620419001d, b: 0.25815455585325764d, c: 0.781691467105331d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(507016837));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6329641939546133d, b: 0.7713358064075255d, c: 0.7091675230581173d),

new NpgsqlTypes.NpgsqlLine(a: 0.6401104534145889d, b: 0.4461488045009705d, c: 0.8050604324576476d),

new NpgsqlTypes.NpgsqlLine(a: 0.718200194405203d, b: 0.43497844061299695d, c: 0.8863292600245054d),

new NpgsqlTypes.NpgsqlLine(a: 0.6409377372303063d, b: 0.6727026439221405d, c: 0.709162570856183d),

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
                Assert.That(model.Id, Is.EqualTo(425879955));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7120720914880876d, b: 0.12018496532744738d, c: 0.23458035596972604d),

new NpgsqlTypes.NpgsqlLine(a: 0.8966943482850258d, b: 0.35901938172619774d, c: 0.5153333646331681d),

new NpgsqlTypes.NpgsqlLine(a: 0.772529205234202d, b: 0.3302141544038909d, c: 0.49860223574471696d),

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
                Assert.That(model.Id, Is.EqualTo(447065450));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6636554004535458d, b: 0.4052905058278198d, c: 0.17999403534412883d),

new NpgsqlTypes.NpgsqlLine(a: 0.4929643299593621d, b: 0.04102771738828992d, c: 0.8758588440576921d),

new NpgsqlTypes.NpgsqlLine(a: 0.9843591359807438d, b: 0.9486545770421181d, c: 0.23810538982780194d),

new NpgsqlTypes.NpgsqlLine(a: 0.0373504814930844d, b: 0.29650224807426506d, c: 0.6527517869517908d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1935239880));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5125009420178407d, b: 0.13553866813087467d, c: 0.6573124881706722d),

new NpgsqlTypes.NpgsqlLine(a: 0.9315668534985179d, b: 0.031339976871202935d, c: 0.7319776155987312d),

new NpgsqlTypes.NpgsqlLine(a: 0.5913519522327184d, b: 0.688194613219936d, c: 0.7487303543444555d),

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
                Assert.That(model.Id, Is.EqualTo(776647699));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8841755970938628d, b: 0.039993263617271846d, c: 0.2425222413816407d),

new NpgsqlTypes.NpgsqlLine(a: 0.3162669055857611d, b: 0.1360654949714053d, c: 0.585066125260232d),

new NpgsqlTypes.NpgsqlLine(a: 0.23614085233198578d, b: 0.9624524908146396d, c: 0.8036122013629919d),

new NpgsqlTypes.NpgsqlLine(a: 0.9594786748108928d, b: 0.3334512033062713d, c: 0.8626799508985245d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7692177568154062d, b: 0.8045212370680859d, c: 0.347836807601842d),

new NpgsqlTypes.NpgsqlLine(a: 0.8596806867272218d, b: 0.42225206488490163d, c: 0.2626771759427945d),

new NpgsqlTypes.NpgsqlLine(a: 0.6334601490046422d, b: 0.5508277640730257d, c: 0.9702039181027914d),

new NpgsqlTypes.NpgsqlLine(a: 0.7862671596820799d, b: 0.6148121550149941d, c: 0.10467782441316142d),

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
                Assert.That(model.Id, Is.EqualTo(920410273));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7950181430955406d, b: 0.3848051391253504d, c: 0.1572657802170856d),

new NpgsqlTypes.NpgsqlLine(a: 0.6062151918599252d, b: 0.06062326101597226d, c: 0.14777044879318857d),

new NpgsqlTypes.NpgsqlLine(a: 0.7408182398935058d, b: 0.6661433504932776d, c: 0.15722709569280902d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2482561889064241d, b: 0.768360521777252d, c: 0.24033198573060877d),

new NpgsqlTypes.NpgsqlLine(a: 0.6078828832971318d, b: 0.25910942482320465d, c: 0.7624300130707319d),

new NpgsqlTypes.NpgsqlLine(a: 0.551230062109523d, b: 0.5951997473266207d, c: 0.05557568229198884d),

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
                Assert.That(model.Id, Is.EqualTo(929385902));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8285395037487209d, b: 0.25070273066629d, c: 0.2500673109161923d),

new NpgsqlTypes.NpgsqlLine(a: 0.9942717530143405d, b: 0.21539215026712022d, c: 0.20269945939501077d),

new NpgsqlTypes.NpgsqlLine(a: 0.7979702358088475d, b: 0.0037115614378556705d, c: 0.8843432168677479d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1456202870910711d, b: 0.06772665910903597d, c: 0.691750610472359d),

new NpgsqlTypes.NpgsqlLine(a: 0.765757989281042d, b: 0.32982835634782004d, c: 0.8913701807765988d),

new NpgsqlTypes.NpgsqlLine(a: 0.052240732409688406d, b: 0.618262798295761d, c: 0.8474290495942781d),

new NpgsqlTypes.NpgsqlLine(a: 0.3584922315949717d, b: 0.520574773115294d, c: 0.8310230234204736d),

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
                Assert.That(model.Id, Is.EqualTo(939691488));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15928813769803307d, b: 0.5335096410959914d, c: 0.9693141891385088d),

new NpgsqlTypes.NpgsqlLine(a: 0.9448241901930845d, b: 0.6287076527827521d, c: 0.6660617468801671d),

new NpgsqlTypes.NpgsqlLine(a: 0.30712778702622445d, b: 0.324942912367581d, c: 0.9500282198259326d),

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
                Assert.That(model.Id, Is.EqualTo(940484658));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8457530794410952d, b: 0.07468146527745967d, c: 0.6058450234777081d),

new NpgsqlTypes.NpgsqlLine(a: 0.43907623012482566d, b: 0.4163533057091461d, c: 0.7083053151407345d),

new NpgsqlTypes.NpgsqlLine(a: 0.6460729456777172d, b: 0.3996032448892458d, c: 0.32058136990645736d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5056133907420888d, b: 0.687789482585691d, c: 0.5736898296981361d),

new NpgsqlTypes.NpgsqlLine(a: 0.6165837793609097d, b: 0.3896094649555947d, c: 0.782529168193896d),

new NpgsqlTypes.NpgsqlLine(a: 0.19522061405511182d, b: 0.49515141325692447d, c: 0.8154303350690599d),

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
                Assert.That(model.Id, Is.EqualTo(956171576));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6305558129660189d, b: 0.5463622939629917d, c: 0.401891977997777d),

new NpgsqlTypes.NpgsqlLine(a: 0.3662230087345998d, b: 0.4302679455886196d, c: 0.9631184941583132d),

new NpgsqlTypes.NpgsqlLine(a: 0.3634906094993412d, b: 0.18046820180120404d, c: 0.5193725822662353d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48533853922222536d, b: 0.7781157007327932d, c: 0.20671476643143427d),

new NpgsqlTypes.NpgsqlLine(a: 0.7321919326621603d, b: 0.7704043405190548d, c: 0.5508846640658778d),

new NpgsqlTypes.NpgsqlLine(a: 0.5796306726535371d, b: 0.3621536966457104d, c: 0.3554092618887771d),

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
                Assert.That(model.Id, Is.EqualTo(1049476690));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1703167002028123d, b: 0.06899134909065618d, c: 0.39632655876575884d),

new NpgsqlTypes.NpgsqlLine(a: 0.9436521110809849d, b: 0.2716102490692832d, c: 0.21807972083943694d),

new NpgsqlTypes.NpgsqlLine(a: 0.07510391898176405d, b: 0.4622700624960824d, c: 0.6916474126671974d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3434566231012316d, b: 0.6092872970160005d, c: 0.8285200623737458d),

new NpgsqlTypes.NpgsqlLine(a: 0.438620087459067d, b: 0.42784452615069857d, c: 0.43791996431227087d),

new NpgsqlTypes.NpgsqlLine(a: 0.13822472685663223d, b: 0.3567687904324768d, c: 0.5713362361619454d),

new NpgsqlTypes.NpgsqlLine(a: 0.4225842002023096d, b: 0.13041963778907273d, c: 0.537431949671262d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(259689541));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16915141278580792d, b: 0.5107686791340034d, c: 0.6489920882506348d),

new NpgsqlTypes.NpgsqlLine(a: 0.030879513236027d, b: 0.6401283771223818d, c: 0.4904762444562075d),

new NpgsqlTypes.NpgsqlLine(a: 0.16124954101586042d, b: 0.7102870300472969d, c: 0.9978682907813775d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3413197342637151d, b: 0.3564754218301692d, c: 0.16698356005321802d),

new NpgsqlTypes.NpgsqlLine(a: 0.24996465538547474d, b: 0.6936235099874405d, c: 0.00768766971096424d),

new NpgsqlTypes.NpgsqlLine(a: 0.9713834412198872d, b: 0.1937685310996965d, c: 0.5638524218711839d),

new NpgsqlTypes.NpgsqlLine(a: 0.20790035052620326d, b: 0.7280555648340241d, c: 0.7150389111804211d),

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
                Assert.That(model.Id, Is.EqualTo(1169283916));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6136867588329713d, b: 0.8476721243007673d, c: 0.2920466838690219d),

new NpgsqlTypes.NpgsqlLine(a: 0.5632572533709046d, b: 0.8580393386665631d, c: 0.29067186403759726d),

new NpgsqlTypes.NpgsqlLine(a: 0.05864985939465561d, b: 0.06933376015004311d, c: 0.2622230618531959d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3083889075922114d, b: 0.40504233141015844d, c: 0.7282625593772889d),

new NpgsqlTypes.NpgsqlLine(a: 0.9760389595620657d, b: 0.5432046524856411d, c: 0.4805721407516501d),

new NpgsqlTypes.NpgsqlLine(a: 0.226094370846618d, b: 0.30929816503923757d, c: 0.749788108094253d),

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

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1247961184));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588334999708729d, b: 0.5781258655739143d, c: 0.4951203893647069d),

new NpgsqlTypes.NpgsqlLine(a: 0.206651781249944d, b: 0.9214488824097644d, c: 0.7102197735978709d),

new NpgsqlTypes.NpgsqlLine(a: 0.8293873017859008d, b: 0.4197388618664637d, c: 0.7538628331143343d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9886122302398814d, b: 0.09733443476141157d, c: 0.8828756753279827d),

new NpgsqlTypes.NpgsqlLine(a: 0.4191781730328399d, b: 0.8360940579259326d, c: 0.3115604346093266d),

new NpgsqlTypes.NpgsqlLine(a: 0.03123256692948395d, b: 0.4210178852779579d, c: 0.7083559364281564d),

new NpgsqlTypes.NpgsqlLine(a: 0.10193811062121638d, b: 0.7865607707379441d, c: 0.5102014504618864d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(313349652));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7148027863911385d, b: 0.4116315290140842d, c: 0.9883513693293022d),

new NpgsqlTypes.NpgsqlLine(a: 0.730798769811796d, b: 0.5625059295801093d, c: 0.028144945623879147d),

new NpgsqlTypes.NpgsqlLine(a: 0.7895921923207063d, b: 0.897092096080744d, c: 0.36804397804374556d),

new NpgsqlTypes.NpgsqlLine(a: 0.4403951364132078d, b: 0.48316034726668566d, c: 0.5561087583026281d),

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
                Assert.That(model.Id, Is.EqualTo(1251267268));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.27064576558959075d, b: 0.24611103650290955d, c: 0.04928435530376152d),

new NpgsqlTypes.NpgsqlLine(a: 0.5382620257248645d, b: 0.586731968734226d, c: 0.9110741668368397d),

new NpgsqlTypes.NpgsqlLine(a: 0.8386954216871374d, b: 0.14045527908308764d, c: 0.5300328684198944d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7572326327773035d, b: 0.10039993499818312d, c: 0.17339739029118428d),

new NpgsqlTypes.NpgsqlLine(a: 0.9566618331567527d, b: 0.14668861402647748d, c: 0.7767711369985796d),

new NpgsqlTypes.NpgsqlLine(a: 0.932727244163919d, b: 0.12159065636952726d, c: 0.1704609096711438d),

new NpgsqlTypes.NpgsqlLine(a: 0.5792460825794749d, b: 0.985437582839235d, c: 0.557473090399633d),

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

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276251566));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4808529939808879d, b: 0.365247596328651d, c: 0.17939866902766977d),

new NpgsqlTypes.NpgsqlLine(a: 0.12809708913748585d, b: 0.18821025600986407d, c: 0.9740037535570704d),

new NpgsqlTypes.NpgsqlLine(a: 0.7729579560840041d, b: 0.5283959837814016d, c: 0.3246873097765165d),

new NpgsqlTypes.NpgsqlLine(a: 0.5804554841359071d, b: 0.7951318743812129d, c: 0.9533437460862759d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07357632206959641d, b: 0.11099061080365447d, c: 0.47576723756466854d),

new NpgsqlTypes.NpgsqlLine(a: 0.9051522311200175d, b: 0.6041352781626989d, c: 0.962846313750425d),

new NpgsqlTypes.NpgsqlLine(a: 0.7230697163609032d, b: 0.35996997662147945d, c: 0.2719627850842049d),

new NpgsqlTypes.NpgsqlLine(a: 0.039972657007877d, b: 0.6660692046588974d, c: 0.8074219604808613d),

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

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1278639929));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8637991908928382d, b: 0.7989476928355281d, c: 0.047074497669961635d),

new NpgsqlTypes.NpgsqlLine(a: 0.24284327761860214d, b: 0.034845279321367495d, c: 0.8243144068858446d),

new NpgsqlTypes.NpgsqlLine(a: 0.2705173386529084d, b: 0.37759514414776285d, c: 0.003784057263189533d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5464646368268954d, b: 0.1698011067851829d, c: 0.4811896051504386d),

new NpgsqlTypes.NpgsqlLine(a: 0.3264558304845737d, b: 0.09741548986796533d, c: 0.35078408755418944d),

new NpgsqlTypes.NpgsqlLine(a: 0.1253849539183054d, b: 0.9184504405667023d, c: 0.6244095303662431d),

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
                Assert.That(model.Id, Is.EqualTo(1352296160));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6961581521563707d, b: 0.2870425810465653d, c: 0.022813771410836625d),

new NpgsqlTypes.NpgsqlLine(a: 0.9289180434806266d, b: 0.10310192777053839d, c: 0.4974840036652155d),

new NpgsqlTypes.NpgsqlLine(a: 0.9742618124298718d, b: 0.666155889593685d, c: 0.9108800941033853d),

new NpgsqlTypes.NpgsqlLine(a: 0.4076993728994177d, b: 0.9237619110159688d, c: 0.16349574316883708d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.40245830157937157d, b: 0.4425237993192568d, c: 0.3605907953188545d),

new NpgsqlTypes.NpgsqlLine(a: 0.3025387755185438d, b: 0.16175616826033246d, c: 0.08369914886846197d),

new NpgsqlTypes.NpgsqlLine(a: 0.7932786053551402d, b: 0.4757892941852452d, c: 0.35215963103511483d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2052209240));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28682097488067404d, b: 0.19347953745544d, c: 0.767001580247448d),

new NpgsqlTypes.NpgsqlLine(a: 0.34168929191792363d, b: 0.5324263819109204d, c: 0.3548736591683712d),

new NpgsqlTypes.NpgsqlLine(a: 0.7601584215479089d, b: 0.9667193856859281d, c: 0.48805620341333844d),

new NpgsqlTypes.NpgsqlLine(a: 0.4778030273140724d, b: 0.6459214140044727d, c: 0.9825570138966864d),

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
                Assert.That(model.Id, Is.EqualTo(1422030401));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5508950376990435d, b: 0.1842011543506923d, c: 0.7200839172656331d),

new NpgsqlTypes.NpgsqlLine(a: 0.08098131741133519d, b: 0.2512744482896645d, c: 0.4419893154281408d),

new NpgsqlTypes.NpgsqlLine(a: 0.7183180834237055d, b: 0.3821225061156569d, c: 0.320010478004808d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.605461690855222d, b: 0.5098249599693536d, c: 0.049446338505273246d),

new NpgsqlTypes.NpgsqlLine(a: 0.6383133050473475d, b: 0.5385834180776717d, c: 0.2612256906158803d),

new NpgsqlTypes.NpgsqlLine(a: 0.2259744218921168d, b: 0.0504022254415285d, c: 0.5085817881315488d),

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
                Assert.That(model.Id, Is.EqualTo(1441068318));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04431673188157559d, b: 0.7118895502319815d, c: 0.8045459394080527d),

new NpgsqlTypes.NpgsqlLine(a: 0.41883883343441664d, b: 0.0856133325697227d, c: 0.45940150990219364d),

new NpgsqlTypes.NpgsqlLine(a: 0.3845455332415372d, b: 0.5278908004707358d, c: 0.45211852173959755d),

new NpgsqlTypes.NpgsqlLine(a: 0.707344526938849d, b: 0.2664835051263448d, c: 0.8012907013628192d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5167014945187821d, b: 0.2318523474732329d, c: 0.0766480392056259d),

new NpgsqlTypes.NpgsqlLine(a: 0.6239339834043951d, b: 0.4407650281616141d, c: 0.07711199216030074d),

new NpgsqlTypes.NpgsqlLine(a: 0.7330247230488705d, b: 0.06195929907587139d, c: 0.1736910797965654d),

new NpgsqlTypes.NpgsqlLine(a: 0.5060985759956755d, b: 0.12918142066992122d, c: 0.3598502037154421d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1349638635));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8811777097968191d, b: 0.09805743628781294d, c: 0.8476023389336619d),

new NpgsqlTypes.NpgsqlLine(a: 0.16329696312104391d, b: 0.8434248077846473d, c: 0.0171626874853823d),

new NpgsqlTypes.NpgsqlLine(a: 0.5930114320798587d, b: 0.7874763150232159d, c: 0.20169365861720767d),

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
                Assert.That(model.Id, Is.EqualTo(1485177216));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7620135774845544d, b: 0.72234986247445d, c: 0.7900958363555012d),

new NpgsqlTypes.NpgsqlLine(a: 0.5982892074823093d, b: 0.9157569165822279d, c: 0.5913666560112503d),

new NpgsqlTypes.NpgsqlLine(a: 0.3694255096703286d, b: 0.43689654039349735d, c: 0.27488642071951885d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1888587968));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9441675468790086d, b: 0.10273087249159918d, c: 0.36496868371913627d),

new NpgsqlTypes.NpgsqlLine(a: 0.3153900895384264d, b: 0.8953921593705707d, c: 0.6821583482258307d),

new NpgsqlTypes.NpgsqlLine(a: 0.15884512105184567d, b: 0.20745599422324912d, c: 0.5928677501305737d),

new NpgsqlTypes.NpgsqlLine(a: 0.19203772899196803d, b: 0.9281999546867626d, c: 0.9792553764463741d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.616453689236877d, b: 0.26880075600348696d, c: 0.9911672578342802d),

new NpgsqlTypes.NpgsqlLine(a: 0.41598816366831615d, b: 0.2972198032481773d, c: 0.6096249065094251d),

new NpgsqlTypes.NpgsqlLine(a: 0.21461782395965212d, b: 0.4996081675192614d, c: 0.845029551763019d),

new NpgsqlTypes.NpgsqlLine(a: 0.14603833144353173d, b: 0.5155958582129082d, c: 0.9513100476397736d),

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
                Assert.That(model.Id, Is.EqualTo(1612037280));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9755688560619167d, b: 0.7517347444178538d, c: 0.4433097656621017d),

new NpgsqlTypes.NpgsqlLine(a: 0.27642151559126893d, b: 0.49560032188535075d, c: 0.4017019854911661d),

new NpgsqlTypes.NpgsqlLine(a: 0.48234378585453686d, b: 0.5838608048706788d, c: 0.45264440736135125d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1803941428));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4958174274877982d, b: 0.19935005698584918d, c: 0.6570481803156852d),

new NpgsqlTypes.NpgsqlLine(a: 0.586031122116916d, b: 0.20438200508300097d, c: 0.7214279726394314d),

new NpgsqlTypes.NpgsqlLine(a: 0.3287771922455527d, b: 0.31464931534195395d, c: 0.49275260904707807d),

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
                Assert.That(model.Id, Is.EqualTo(1694903385));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5133551130062282d, b: 0.5981369379522861d, c: 0.5856516805262975d),

new NpgsqlTypes.NpgsqlLine(a: 0.4556255479239121d, b: 0.059243842569019045d, c: 0.18272228811839042d),

new NpgsqlTypes.NpgsqlLine(a: 0.8085308768004308d, b: 0.8348590541320315d, c: 0.5895099353964641d),

new NpgsqlTypes.NpgsqlLine(a: 0.24149968696186774d, b: 0.35557480082622506d, c: 0.5451461752136405d),

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
                Assert.That(model.Id, Is.EqualTo(1708194464));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21378574042766885d, b: 0.22474127876321393d, c: 0.01286635194062602d),

new NpgsqlTypes.NpgsqlLine(a: 0.44720527497131246d, b: 0.83386820783986d, c: 0.47600740851603984d),

new NpgsqlTypes.NpgsqlLine(a: 0.9177345103701179d, b: 0.8135674766115204d, c: 0.23923291716083794d),

new NpgsqlTypes.NpgsqlLine(a: 0.9998743487003019d, b: 0.013427841900149451d, c: 0.9133209978570025d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(871029693));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09314286666835214d, b: 0.9419395542104619d, c: 0.23265001920909978d),

new NpgsqlTypes.NpgsqlLine(a: 0.7840922282915723d, b: 0.8769622177219351d, c: 0.08844919095146764d),

new NpgsqlTypes.NpgsqlLine(a: 0.30172065868559383d, b: 0.061796126836928256d, c: 0.7819510380905712d),

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
                Assert.That(model.Id, Is.EqualTo(1749272119));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48465570613062037d, b: 0.4077570571696034d, c: 0.09124205112015671d),

new NpgsqlTypes.NpgsqlLine(a: 0.4905692123673753d, b: 0.09753381316271936d, c: 0.6219861110019185d),

new NpgsqlTypes.NpgsqlLine(a: 0.7715584772299492d, b: 0.7647042738214676d, c: 0.32981711302760286d),

new NpgsqlTypes.NpgsqlLine(a: 0.7826950107361046d, b: 0.6159017458991703d, c: 0.8761288210787351d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05854830086605134d, b: 0.4584727830793912d, c: 0.6485776355671607d),

new NpgsqlTypes.NpgsqlLine(a: 0.057402368952540694d, b: 0.814338567877536d, c: 0.36045674525095406d),

new NpgsqlTypes.NpgsqlLine(a: 0.4609921668504162d, b: 0.45446719793916357d, c: 0.6647833262693906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8421363107491464d, b: 0.8724917366553757d, c: 0.2954174236384989d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743101311));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30049737151744216d, b: 0.10935998965187232d, c: 0.12002566064851483d),

new NpgsqlTypes.NpgsqlLine(a: 0.4579983959880112d, b: 0.8700234892072651d, c: 0.24545341370685325d),

new NpgsqlTypes.NpgsqlLine(a: 0.6992061752442d, b: 0.8760611086508132d, c: 0.31896424715232463d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14975557199832845d, b: 0.8649037801511367d, c: 0.8035067258718913d),

new NpgsqlTypes.NpgsqlLine(a: 0.022767088770272226d, b: 0.824519829812387d, c: 0.2990170967826957d),

new NpgsqlTypes.NpgsqlLine(a: 0.264229467978496d, b: 0.4707396384081288d, c: 0.5870444614457326d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1750072079));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6509605768915644d, b: 0.2871280523199907d, c: 0.5279864073907687d),

new NpgsqlTypes.NpgsqlLine(a: 0.847627780191932d, b: 0.2863239370866939d, c: 0.39664595009550063d),

new NpgsqlTypes.NpgsqlLine(a: 0.06719070091173818d, b: 0.2998868113793318d, c: 0.8109899934095542d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30402634597868494d, b: 0.7741177113732105d, c: 0.4982697795456863d),

new NpgsqlTypes.NpgsqlLine(a: 0.22134239051678783d, b: 0.952989590947333d, c: 0.1976805178607327d),

new NpgsqlTypes.NpgsqlLine(a: 0.48019693876130953d, b: 0.8553553442730837d, c: 0.4578014530562905d),

new NpgsqlTypes.NpgsqlLine(a: 0.7948720279836796d, b: 0.6347165612507009d, c: 0.4915047790558922d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(681877477));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.054876749435908034d, b: 0.7476698065656858d, c: 0.5221215501493097d),

new NpgsqlTypes.NpgsqlLine(a: 0.1689911006864584d, b: 0.16032672190790076d, c: 0.9537953031702238d),

new NpgsqlTypes.NpgsqlLine(a: 0.3133690487713232d, b: 0.21425817972116357d, c: 0.39002508371565625d),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1765269457));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4428210775962541d, b: 0.44628545865868685d, c: 0.7913435097925557d),

new NpgsqlTypes.NpgsqlLine(a: 0.26419018627718516d, b: 0.12166427922453704d, c: 0.11250832552770584d),

new NpgsqlTypes.NpgsqlLine(a: 0.20276585628171784d, b: 0.14489314174625478d, c: 0.5410582863519566d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(699428708));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.75437435623167d, b: 0.4381969103973332d, c: 0.13859938549471296d),

new NpgsqlTypes.NpgsqlLine(a: 0.22478326045746155d, b: 0.7927996319630696d, c: 0.5653146543488808d),

new NpgsqlTypes.NpgsqlLine(a: 0.8148660813324691d, b: 0.5965502974097225d, c: 0.08598406767552191d),

new NpgsqlTypes.NpgsqlLine(a: 0.10261855436837408d, b: 0.22753843400620033d, c: 0.6663050101504865d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19047502268477823d, b: 0.503647750986701d, c: 0.5140837344549085d),

new NpgsqlTypes.NpgsqlLine(a: 0.5498279015442291d, b: 0.5205498180433044d, c: 0.5511400439881968d),

new NpgsqlTypes.NpgsqlLine(a: 0.07519565206915457d, b: 0.8190939422278946d, c: 0.4842243543091963d),

new NpgsqlTypes.NpgsqlLine(a: 0.11151345358207676d, b: 0.2794260095615846d, c: 0.1977999861392018d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(24431063));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7432562260700321d, b: 0.9027051106351455d, c: 0.20935776301702913d),

new NpgsqlTypes.NpgsqlLine(a: 0.06877648068052133d, b: 0.4638520424251973d, c: 0.8977581074629934d),

new NpgsqlTypes.NpgsqlLine(a: 0.19824889810271595d, b: 0.101805635004653d, c: 0.6376796129171594d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.25692356453649523d, b: 0.8249956321761069d, c: 0.7485760418256393d),

new NpgsqlTypes.NpgsqlLine(a: 0.5205543536927003d, b: 0.26409313743898866d, c: 0.11834223656249432d),

new NpgsqlTypes.NpgsqlLine(a: 0.12852097087774939d, b: 0.110468841038458d, c: 0.15781368742463253d),

new NpgsqlTypes.NpgsqlLine(a: 0.5056691167374713d, b: 0.17475361978672044d, c: 0.4301177356479713d),

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
                Assert.That(model.Id, Is.EqualTo(88466632));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24038691940074952d, b: 0.4574071819075469d, c: 0.029018693781179494d),

new NpgsqlTypes.NpgsqlLine(a: 0.6230691191149946d, b: 0.6421350132669393d, c: 0.2591755154295573d),

new NpgsqlTypes.NpgsqlLine(a: 0.284214063978114d, b: 0.42055782459666247d, c: 0.4230265799247275d),

new NpgsqlTypes.NpgsqlLine(a: 0.2294933978523651d, b: 0.8434657220550107d, c: 0.1364803149185917d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(671378680));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.579485378096583d, b: 0.7644192687968542d, c: 0.38803543767659376d),

new NpgsqlTypes.NpgsqlLine(a: 0.9272224559192928d, b: 0.04309922869802718d, c: 0.1084146589578524d),

new NpgsqlTypes.NpgsqlLine(a: 0.6194396921461146d, b: 0.3135327751395446d, c: 0.47728859432318693d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22238461731837955d, b: 0.8832575247518029d, c: 0.5267192016109244d),

new NpgsqlTypes.NpgsqlLine(a: 0.2456814921559901d, b: 0.12396858431218405d, c: 0.7758983059785806d),

new NpgsqlTypes.NpgsqlLine(a: 0.8010355013907535d, b: 0.10724380078506457d, c: 0.8516226142927568d),

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
                Assert.That(model.Id, Is.EqualTo(214898413));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7273918164372143d, b: 0.3711769692436181d, c: 0.7468659136792664d),

new NpgsqlTypes.NpgsqlLine(a: 0.8155250372031967d, b: 0.5364157660240247d, c: 0.2587745327315204d),

new NpgsqlTypes.NpgsqlLine(a: 0.8823774478354753d, b: 0.24032876435579376d, c: 0.9187231882533503d),

new NpgsqlTypes.NpgsqlLine(a: 0.2761563267007917d, b: 0.8609521972165307d, c: 0.014350256291767893d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7060914743005817d, b: 0.29942700622480667d, c: 0.38464564338188945d),

new NpgsqlTypes.NpgsqlLine(a: 0.456801666295529d, b: 0.2750050419905442d, c: 0.6523990372650718d),

new NpgsqlTypes.NpgsqlLine(a: 0.593068234761201d, b: 0.986042625015402d, c: 0.7722918655162653d),

new NpgsqlTypes.NpgsqlLine(a: 0.8257270425360131d, b: 0.9234733383976109d, c: 0.16399605960296715d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(160844459));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.49742066568592347d, b: 0.13045995730850435d, c: 0.3240701079822569d),

new NpgsqlTypes.NpgsqlLine(a: 0.4230136983146885d, b: 0.4758823758243249d, c: 0.7245296150407883d),

new NpgsqlTypes.NpgsqlLine(a: 0.902525000709505d, b: 0.3096633545847971d, c: 0.7195095860492445d),

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
                Assert.That(model.Id, Is.EqualTo(232426060));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7754569347332767d, b: 0.7449423603392903d, c: 0.7275357910733291d),

new NpgsqlTypes.NpgsqlLine(a: 0.9072872865290874d, b: 0.5188651109794405d, c: 0.49767196437474315d),

new NpgsqlTypes.NpgsqlLine(a: 0.7613773478086597d, b: 0.8726134777514618d, c: 0.7249287737318102d),

new NpgsqlTypes.NpgsqlLine(a: 0.31979325488547383d, b: 0.21963013317369884d, c: 0.995747479981123d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5136334997132156d, b: 0.4481836733144653d, c: 0.5566013930940901d),

new NpgsqlTypes.NpgsqlLine(a: 0.2628604279970359d, b: 0.34706683348460354d, c: 0.8618758810041756d),

new NpgsqlTypes.NpgsqlLine(a: 0.9066993846202163d, b: 0.9919335952888788d, c: 0.16647553451680086d),

new NpgsqlTypes.NpgsqlLine(a: 0.8084713734948656d, b: 0.9105928653749232d, c: 0.5871692331069964d),

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

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(287773256));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5468129373528992d, b: 0.4550697398151482d, c: 0.9323204190693627d),

new NpgsqlTypes.NpgsqlLine(a: 0.09290076953581794d, b: 0.06513797114322906d, c: 0.01453530584939322d),

new NpgsqlTypes.NpgsqlLine(a: 0.06819515445977387d, b: 0.13776512554356624d, c: 0.5971045649241554d),

new NpgsqlTypes.NpgsqlLine(a: 0.17602847632288898d, b: 0.8583377493377162d, c: 0.5319193518068348d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2000087272));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5174417835536576d, b: 0.9550151039410834d, c: 0.94465021980697d),

new NpgsqlTypes.NpgsqlLine(a: 0.023498567205728516d, b: 0.14704570142511664d, c: 0.5436176118381062d),

new NpgsqlTypes.NpgsqlLine(a: 0.6410825125912296d, b: 0.1638519482392854d, c: 0.07442290044208977d),

new NpgsqlTypes.NpgsqlLine(a: 0.5684954410076702d, b: 0.9517870324925599d, c: 0.7913121037671743d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5546781844769255d, b: 0.3295435210405563d, c: 0.10332785525555d),

new NpgsqlTypes.NpgsqlLine(a: 0.8619184029547027d, b: 0.6893143841340763d, c: 0.6057919377815917d),

new NpgsqlTypes.NpgsqlLine(a: 0.6918049340506819d, b: 0.29564467871458977d, c: 0.373851052320022d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590711543927416d, b: 0.782456230485786d, c: 0.0557514543823312d),

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
                Assert.That(model.Id, Is.EqualTo(385864550));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22975102280111437d, b: 0.9248487581270293d, c: 0.13680981887715193d),

new NpgsqlTypes.NpgsqlLine(a: 0.09251582159332017d, b: 0.5284902712490177d, c: 0.5030244379828798d),

new NpgsqlTypes.NpgsqlLine(a: 0.3316636973424488d, b: 0.125908586516723d, c: 0.1307901665228316d),

new NpgsqlTypes.NpgsqlLine(a: 0.4488357278586823d, b: 0.4939460007710509d, c: 0.1486125807477222d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4793632894446783d, b: 0.7460924351194599d, c: 0.8333281971866928d),

new NpgsqlTypes.NpgsqlLine(a: 0.9911204719862435d, b: 0.02386428262012663d, c: 0.1749191984110413d),

new NpgsqlTypes.NpgsqlLine(a: 0.9855596015822274d, b: 0.652336551342683d, c: 0.13320036109805444d),

new NpgsqlTypes.NpgsqlLine(a: 0.2704642620419001d, b: 0.25815455585325764d, c: 0.781691467105331d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(507016837));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6329641939546133d, b: 0.7713358064075255d, c: 0.7091675230581173d),

new NpgsqlTypes.NpgsqlLine(a: 0.6401104534145889d, b: 0.4461488045009705d, c: 0.8050604324576476d),

new NpgsqlTypes.NpgsqlLine(a: 0.718200194405203d, b: 0.43497844061299695d, c: 0.8863292600245054d),

new NpgsqlTypes.NpgsqlLine(a: 0.6409377372303063d, b: 0.6727026439221405d, c: 0.709162570856183d),

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
                Assert.That(model.Id, Is.EqualTo(425879955));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7120720914880876d, b: 0.12018496532744738d, c: 0.23458035596972604d),

new NpgsqlTypes.NpgsqlLine(a: 0.8966943482850258d, b: 0.35901938172619774d, c: 0.5153333646331681d),

new NpgsqlTypes.NpgsqlLine(a: 0.772529205234202d, b: 0.3302141544038909d, c: 0.49860223574471696d),

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
                Assert.That(model.Id, Is.EqualTo(447065450));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6636554004535458d, b: 0.4052905058278198d, c: 0.17999403534412883d),

new NpgsqlTypes.NpgsqlLine(a: 0.4929643299593621d, b: 0.04102771738828992d, c: 0.8758588440576921d),

new NpgsqlTypes.NpgsqlLine(a: 0.9843591359807438d, b: 0.9486545770421181d, c: 0.23810538982780194d),

new NpgsqlTypes.NpgsqlLine(a: 0.0373504814930844d, b: 0.29650224807426506d, c: 0.6527517869517908d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1935239880));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5125009420178407d, b: 0.13553866813087467d, c: 0.6573124881706722d),

new NpgsqlTypes.NpgsqlLine(a: 0.9315668534985179d, b: 0.031339976871202935d, c: 0.7319776155987312d),

new NpgsqlTypes.NpgsqlLine(a: 0.5913519522327184d, b: 0.688194613219936d, c: 0.7487303543444555d),

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
                Assert.That(model.Id, Is.EqualTo(776647699));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8841755970938628d, b: 0.039993263617271846d, c: 0.2425222413816407d),

new NpgsqlTypes.NpgsqlLine(a: 0.3162669055857611d, b: 0.1360654949714053d, c: 0.585066125260232d),

new NpgsqlTypes.NpgsqlLine(a: 0.23614085233198578d, b: 0.9624524908146396d, c: 0.8036122013629919d),

new NpgsqlTypes.NpgsqlLine(a: 0.9594786748108928d, b: 0.3334512033062713d, c: 0.8626799508985245d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7692177568154062d, b: 0.8045212370680859d, c: 0.347836807601842d),

new NpgsqlTypes.NpgsqlLine(a: 0.8596806867272218d, b: 0.42225206488490163d, c: 0.2626771759427945d),

new NpgsqlTypes.NpgsqlLine(a: 0.6334601490046422d, b: 0.5508277640730257d, c: 0.9702039181027914d),

new NpgsqlTypes.NpgsqlLine(a: 0.7862671596820799d, b: 0.6148121550149941d, c: 0.10467782441316142d),

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
                Assert.That(model.Id, Is.EqualTo(920410273));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7950181430955406d, b: 0.3848051391253504d, c: 0.1572657802170856d),

new NpgsqlTypes.NpgsqlLine(a: 0.6062151918599252d, b: 0.06062326101597226d, c: 0.14777044879318857d),

new NpgsqlTypes.NpgsqlLine(a: 0.7408182398935058d, b: 0.6661433504932776d, c: 0.15722709569280902d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2482561889064241d, b: 0.768360521777252d, c: 0.24033198573060877d),

new NpgsqlTypes.NpgsqlLine(a: 0.6078828832971318d, b: 0.25910942482320465d, c: 0.7624300130707319d),

new NpgsqlTypes.NpgsqlLine(a: 0.551230062109523d, b: 0.5951997473266207d, c: 0.05557568229198884d),

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
                Assert.That(model.Id, Is.EqualTo(929385902));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8285395037487209d, b: 0.25070273066629d, c: 0.2500673109161923d),

new NpgsqlTypes.NpgsqlLine(a: 0.9942717530143405d, b: 0.21539215026712022d, c: 0.20269945939501077d),

new NpgsqlTypes.NpgsqlLine(a: 0.7979702358088475d, b: 0.0037115614378556705d, c: 0.8843432168677479d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1456202870910711d, b: 0.06772665910903597d, c: 0.691750610472359d),

new NpgsqlTypes.NpgsqlLine(a: 0.765757989281042d, b: 0.32982835634782004d, c: 0.8913701807765988d),

new NpgsqlTypes.NpgsqlLine(a: 0.052240732409688406d, b: 0.618262798295761d, c: 0.8474290495942781d),

new NpgsqlTypes.NpgsqlLine(a: 0.3584922315949717d, b: 0.520574773115294d, c: 0.8310230234204736d),

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
                Assert.That(model.Id, Is.EqualTo(939691488));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15928813769803307d, b: 0.5335096410959914d, c: 0.9693141891385088d),

new NpgsqlTypes.NpgsqlLine(a: 0.9448241901930845d, b: 0.6287076527827521d, c: 0.6660617468801671d),

new NpgsqlTypes.NpgsqlLine(a: 0.30712778702622445d, b: 0.324942912367581d, c: 0.9500282198259326d),

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
                Assert.That(model.Id, Is.EqualTo(940484658));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8457530794410952d, b: 0.07468146527745967d, c: 0.6058450234777081d),

new NpgsqlTypes.NpgsqlLine(a: 0.43907623012482566d, b: 0.4163533057091461d, c: 0.7083053151407345d),

new NpgsqlTypes.NpgsqlLine(a: 0.6460729456777172d, b: 0.3996032448892458d, c: 0.32058136990645736d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5056133907420888d, b: 0.687789482585691d, c: 0.5736898296981361d),

new NpgsqlTypes.NpgsqlLine(a: 0.6165837793609097d, b: 0.3896094649555947d, c: 0.782529168193896d),

new NpgsqlTypes.NpgsqlLine(a: 0.19522061405511182d, b: 0.49515141325692447d, c: 0.8154303350690599d),

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
                Assert.That(model.Id, Is.EqualTo(956171576));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6305558129660189d, b: 0.5463622939629917d, c: 0.401891977997777d),

new NpgsqlTypes.NpgsqlLine(a: 0.3662230087345998d, b: 0.4302679455886196d, c: 0.9631184941583132d),

new NpgsqlTypes.NpgsqlLine(a: 0.3634906094993412d, b: 0.18046820180120404d, c: 0.5193725822662353d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48533853922222536d, b: 0.7781157007327932d, c: 0.20671476643143427d),

new NpgsqlTypes.NpgsqlLine(a: 0.7321919326621603d, b: 0.7704043405190548d, c: 0.5508846640658778d),

new NpgsqlTypes.NpgsqlLine(a: 0.5796306726535371d, b: 0.3621536966457104d, c: 0.3554092618887771d),

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
                Assert.That(model.Id, Is.EqualTo(1049476690));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1703167002028123d, b: 0.06899134909065618d, c: 0.39632655876575884d),

new NpgsqlTypes.NpgsqlLine(a: 0.9436521110809849d, b: 0.2716102490692832d, c: 0.21807972083943694d),

new NpgsqlTypes.NpgsqlLine(a: 0.07510391898176405d, b: 0.4622700624960824d, c: 0.6916474126671974d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3434566231012316d, b: 0.6092872970160005d, c: 0.8285200623737458d),

new NpgsqlTypes.NpgsqlLine(a: 0.438620087459067d, b: 0.42784452615069857d, c: 0.43791996431227087d),

new NpgsqlTypes.NpgsqlLine(a: 0.13822472685663223d, b: 0.3567687904324768d, c: 0.5713362361619454d),

new NpgsqlTypes.NpgsqlLine(a: 0.4225842002023096d, b: 0.13041963778907273d, c: 0.537431949671262d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(259689541));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16915141278580792d, b: 0.5107686791340034d, c: 0.6489920882506348d),

new NpgsqlTypes.NpgsqlLine(a: 0.030879513236027d, b: 0.6401283771223818d, c: 0.4904762444562075d),

new NpgsqlTypes.NpgsqlLine(a: 0.16124954101586042d, b: 0.7102870300472969d, c: 0.9978682907813775d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3413197342637151d, b: 0.3564754218301692d, c: 0.16698356005321802d),

new NpgsqlTypes.NpgsqlLine(a: 0.24996465538547474d, b: 0.6936235099874405d, c: 0.00768766971096424d),

new NpgsqlTypes.NpgsqlLine(a: 0.9713834412198872d, b: 0.1937685310996965d, c: 0.5638524218711839d),

new NpgsqlTypes.NpgsqlLine(a: 0.20790035052620326d, b: 0.7280555648340241d, c: 0.7150389111804211d),

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
                Assert.That(model.Id, Is.EqualTo(1169283916));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6136867588329713d, b: 0.8476721243007673d, c: 0.2920466838690219d),

new NpgsqlTypes.NpgsqlLine(a: 0.5632572533709046d, b: 0.8580393386665631d, c: 0.29067186403759726d),

new NpgsqlTypes.NpgsqlLine(a: 0.05864985939465561d, b: 0.06933376015004311d, c: 0.2622230618531959d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3083889075922114d, b: 0.40504233141015844d, c: 0.7282625593772889d),

new NpgsqlTypes.NpgsqlLine(a: 0.9760389595620657d, b: 0.5432046524856411d, c: 0.4805721407516501d),

new NpgsqlTypes.NpgsqlLine(a: 0.226094370846618d, b: 0.30929816503923757d, c: 0.749788108094253d),

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

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1247961184));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588334999708729d, b: 0.5781258655739143d, c: 0.4951203893647069d),

new NpgsqlTypes.NpgsqlLine(a: 0.206651781249944d, b: 0.9214488824097644d, c: 0.7102197735978709d),

new NpgsqlTypes.NpgsqlLine(a: 0.8293873017859008d, b: 0.4197388618664637d, c: 0.7538628331143343d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9886122302398814d, b: 0.09733443476141157d, c: 0.8828756753279827d),

new NpgsqlTypes.NpgsqlLine(a: 0.4191781730328399d, b: 0.8360940579259326d, c: 0.3115604346093266d),

new NpgsqlTypes.NpgsqlLine(a: 0.03123256692948395d, b: 0.4210178852779579d, c: 0.7083559364281564d),

new NpgsqlTypes.NpgsqlLine(a: 0.10193811062121638d, b: 0.7865607707379441d, c: 0.5102014504618864d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(313349652));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7148027863911385d, b: 0.4116315290140842d, c: 0.9883513693293022d),

new NpgsqlTypes.NpgsqlLine(a: 0.730798769811796d, b: 0.5625059295801093d, c: 0.028144945623879147d),

new NpgsqlTypes.NpgsqlLine(a: 0.7895921923207063d, b: 0.897092096080744d, c: 0.36804397804374556d),

new NpgsqlTypes.NpgsqlLine(a: 0.4403951364132078d, b: 0.48316034726668566d, c: 0.5561087583026281d),

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
                Assert.That(model.Id, Is.EqualTo(1251267268));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.27064576558959075d, b: 0.24611103650290955d, c: 0.04928435530376152d),

new NpgsqlTypes.NpgsqlLine(a: 0.5382620257248645d, b: 0.586731968734226d, c: 0.9110741668368397d),

new NpgsqlTypes.NpgsqlLine(a: 0.8386954216871374d, b: 0.14045527908308764d, c: 0.5300328684198944d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7572326327773035d, b: 0.10039993499818312d, c: 0.17339739029118428d),

new NpgsqlTypes.NpgsqlLine(a: 0.9566618331567527d, b: 0.14668861402647748d, c: 0.7767711369985796d),

new NpgsqlTypes.NpgsqlLine(a: 0.932727244163919d, b: 0.12159065636952726d, c: 0.1704609096711438d),

new NpgsqlTypes.NpgsqlLine(a: 0.5792460825794749d, b: 0.985437582839235d, c: 0.557473090399633d),

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

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276251566));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4808529939808879d, b: 0.365247596328651d, c: 0.17939866902766977d),

new NpgsqlTypes.NpgsqlLine(a: 0.12809708913748585d, b: 0.18821025600986407d, c: 0.9740037535570704d),

new NpgsqlTypes.NpgsqlLine(a: 0.7729579560840041d, b: 0.5283959837814016d, c: 0.3246873097765165d),

new NpgsqlTypes.NpgsqlLine(a: 0.5804554841359071d, b: 0.7951318743812129d, c: 0.9533437460862759d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07357632206959641d, b: 0.11099061080365447d, c: 0.47576723756466854d),

new NpgsqlTypes.NpgsqlLine(a: 0.9051522311200175d, b: 0.6041352781626989d, c: 0.962846313750425d),

new NpgsqlTypes.NpgsqlLine(a: 0.7230697163609032d, b: 0.35996997662147945d, c: 0.2719627850842049d),

new NpgsqlTypes.NpgsqlLine(a: 0.039972657007877d, b: 0.6660692046588974d, c: 0.8074219604808613d),

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

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1278639929));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8637991908928382d, b: 0.7989476928355281d, c: 0.047074497669961635d),

new NpgsqlTypes.NpgsqlLine(a: 0.24284327761860214d, b: 0.034845279321367495d, c: 0.8243144068858446d),

new NpgsqlTypes.NpgsqlLine(a: 0.2705173386529084d, b: 0.37759514414776285d, c: 0.003784057263189533d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5464646368268954d, b: 0.1698011067851829d, c: 0.4811896051504386d),

new NpgsqlTypes.NpgsqlLine(a: 0.3264558304845737d, b: 0.09741548986796533d, c: 0.35078408755418944d),

new NpgsqlTypes.NpgsqlLine(a: 0.1253849539183054d, b: 0.9184504405667023d, c: 0.6244095303662431d),

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
                Assert.That(model.Id, Is.EqualTo(1352296160));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6961581521563707d, b: 0.2870425810465653d, c: 0.022813771410836625d),

new NpgsqlTypes.NpgsqlLine(a: 0.9289180434806266d, b: 0.10310192777053839d, c: 0.4974840036652155d),

new NpgsqlTypes.NpgsqlLine(a: 0.9742618124298718d, b: 0.666155889593685d, c: 0.9108800941033853d),

new NpgsqlTypes.NpgsqlLine(a: 0.4076993728994177d, b: 0.9237619110159688d, c: 0.16349574316883708d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.40245830157937157d, b: 0.4425237993192568d, c: 0.3605907953188545d),

new NpgsqlTypes.NpgsqlLine(a: 0.3025387755185438d, b: 0.16175616826033246d, c: 0.08369914886846197d),

new NpgsqlTypes.NpgsqlLine(a: 0.7932786053551402d, b: 0.4757892941852452d, c: 0.35215963103511483d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2052209240));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28682097488067404d, b: 0.19347953745544d, c: 0.767001580247448d),

new NpgsqlTypes.NpgsqlLine(a: 0.34168929191792363d, b: 0.5324263819109204d, c: 0.3548736591683712d),

new NpgsqlTypes.NpgsqlLine(a: 0.7601584215479089d, b: 0.9667193856859281d, c: 0.48805620341333844d),

new NpgsqlTypes.NpgsqlLine(a: 0.4778030273140724d, b: 0.6459214140044727d, c: 0.9825570138966864d),

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
                Assert.That(model.Id, Is.EqualTo(1422030401));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5508950376990435d, b: 0.1842011543506923d, c: 0.7200839172656331d),

new NpgsqlTypes.NpgsqlLine(a: 0.08098131741133519d, b: 0.2512744482896645d, c: 0.4419893154281408d),

new NpgsqlTypes.NpgsqlLine(a: 0.7183180834237055d, b: 0.3821225061156569d, c: 0.320010478004808d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.605461690855222d, b: 0.5098249599693536d, c: 0.049446338505273246d),

new NpgsqlTypes.NpgsqlLine(a: 0.6383133050473475d, b: 0.5385834180776717d, c: 0.2612256906158803d),

new NpgsqlTypes.NpgsqlLine(a: 0.2259744218921168d, b: 0.0504022254415285d, c: 0.5085817881315488d),

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
                Assert.That(model.Id, Is.EqualTo(1441068318));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04431673188157559d, b: 0.7118895502319815d, c: 0.8045459394080527d),

new NpgsqlTypes.NpgsqlLine(a: 0.41883883343441664d, b: 0.0856133325697227d, c: 0.45940150990219364d),

new NpgsqlTypes.NpgsqlLine(a: 0.3845455332415372d, b: 0.5278908004707358d, c: 0.45211852173959755d),

new NpgsqlTypes.NpgsqlLine(a: 0.707344526938849d, b: 0.2664835051263448d, c: 0.8012907013628192d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5167014945187821d, b: 0.2318523474732329d, c: 0.0766480392056259d),

new NpgsqlTypes.NpgsqlLine(a: 0.6239339834043951d, b: 0.4407650281616141d, c: 0.07711199216030074d),

new NpgsqlTypes.NpgsqlLine(a: 0.7330247230488705d, b: 0.06195929907587139d, c: 0.1736910797965654d),

new NpgsqlTypes.NpgsqlLine(a: 0.5060985759956755d, b: 0.12918142066992122d, c: 0.3598502037154421d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1349638635));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8811777097968191d, b: 0.09805743628781294d, c: 0.8476023389336619d),

new NpgsqlTypes.NpgsqlLine(a: 0.16329696312104391d, b: 0.8434248077846473d, c: 0.0171626874853823d),

new NpgsqlTypes.NpgsqlLine(a: 0.5930114320798587d, b: 0.7874763150232159d, c: 0.20169365861720767d),

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
                Assert.That(model.Id, Is.EqualTo(1485177216));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7620135774845544d, b: 0.72234986247445d, c: 0.7900958363555012d),

new NpgsqlTypes.NpgsqlLine(a: 0.5982892074823093d, b: 0.9157569165822279d, c: 0.5913666560112503d),

new NpgsqlTypes.NpgsqlLine(a: 0.3694255096703286d, b: 0.43689654039349735d, c: 0.27488642071951885d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1888587968));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9441675468790086d, b: 0.10273087249159918d, c: 0.36496868371913627d),

new NpgsqlTypes.NpgsqlLine(a: 0.3153900895384264d, b: 0.8953921593705707d, c: 0.6821583482258307d),

new NpgsqlTypes.NpgsqlLine(a: 0.15884512105184567d, b: 0.20745599422324912d, c: 0.5928677501305737d),

new NpgsqlTypes.NpgsqlLine(a: 0.19203772899196803d, b: 0.9281999546867626d, c: 0.9792553764463741d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.616453689236877d, b: 0.26880075600348696d, c: 0.9911672578342802d),

new NpgsqlTypes.NpgsqlLine(a: 0.41598816366831615d, b: 0.2972198032481773d, c: 0.6096249065094251d),

new NpgsqlTypes.NpgsqlLine(a: 0.21461782395965212d, b: 0.4996081675192614d, c: 0.845029551763019d),

new NpgsqlTypes.NpgsqlLine(a: 0.14603833144353173d, b: 0.5155958582129082d, c: 0.9513100476397736d),

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
                Assert.That(model.Id, Is.EqualTo(1612037280));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9755688560619167d, b: 0.7517347444178538d, c: 0.4433097656621017d),

new NpgsqlTypes.NpgsqlLine(a: 0.27642151559126893d, b: 0.49560032188535075d, c: 0.4017019854911661d),

new NpgsqlTypes.NpgsqlLine(a: 0.48234378585453686d, b: 0.5838608048706788d, c: 0.45264440736135125d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1803941428));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4958174274877982d, b: 0.19935005698584918d, c: 0.6570481803156852d),

new NpgsqlTypes.NpgsqlLine(a: 0.586031122116916d, b: 0.20438200508300097d, c: 0.7214279726394314d),

new NpgsqlTypes.NpgsqlLine(a: 0.3287771922455527d, b: 0.31464931534195395d, c: 0.49275260904707807d),

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
                Assert.That(model.Id, Is.EqualTo(1694903385));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5133551130062282d, b: 0.5981369379522861d, c: 0.5856516805262975d),

new NpgsqlTypes.NpgsqlLine(a: 0.4556255479239121d, b: 0.059243842569019045d, c: 0.18272228811839042d),

new NpgsqlTypes.NpgsqlLine(a: 0.8085308768004308d, b: 0.8348590541320315d, c: 0.5895099353964641d),

new NpgsqlTypes.NpgsqlLine(a: 0.24149968696186774d, b: 0.35557480082622506d, c: 0.5451461752136405d),

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
                Assert.That(model.Id, Is.EqualTo(1708194464));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21378574042766885d, b: 0.22474127876321393d, c: 0.01286635194062602d),

new NpgsqlTypes.NpgsqlLine(a: 0.44720527497131246d, b: 0.83386820783986d, c: 0.47600740851603984d),

new NpgsqlTypes.NpgsqlLine(a: 0.9177345103701179d, b: 0.8135674766115204d, c: 0.23923291716083794d),

new NpgsqlTypes.NpgsqlLine(a: 0.9998743487003019d, b: 0.013427841900149451d, c: 0.9133209978570025d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(871029693));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09314286666835214d, b: 0.9419395542104619d, c: 0.23265001920909978d),

new NpgsqlTypes.NpgsqlLine(a: 0.7840922282915723d, b: 0.8769622177219351d, c: 0.08844919095146764d),

new NpgsqlTypes.NpgsqlLine(a: 0.30172065868559383d, b: 0.061796126836928256d, c: 0.7819510380905712d),

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
                Assert.That(model.Id, Is.EqualTo(1749272119));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48465570613062037d, b: 0.4077570571696034d, c: 0.09124205112015671d),

new NpgsqlTypes.NpgsqlLine(a: 0.4905692123673753d, b: 0.09753381316271936d, c: 0.6219861110019185d),

new NpgsqlTypes.NpgsqlLine(a: 0.7715584772299492d, b: 0.7647042738214676d, c: 0.32981711302760286d),

new NpgsqlTypes.NpgsqlLine(a: 0.7826950107361046d, b: 0.6159017458991703d, c: 0.8761288210787351d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05854830086605134d, b: 0.4584727830793912d, c: 0.6485776355671607d),

new NpgsqlTypes.NpgsqlLine(a: 0.057402368952540694d, b: 0.814338567877536d, c: 0.36045674525095406d),

new NpgsqlTypes.NpgsqlLine(a: 0.4609921668504162d, b: 0.45446719793916357d, c: 0.6647833262693906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8421363107491464d, b: 0.8724917366553757d, c: 0.2954174236384989d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743101311));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30049737151744216d, b: 0.10935998965187232d, c: 0.12002566064851483d),

new NpgsqlTypes.NpgsqlLine(a: 0.4579983959880112d, b: 0.8700234892072651d, c: 0.24545341370685325d),

new NpgsqlTypes.NpgsqlLine(a: 0.6992061752442d, b: 0.8760611086508132d, c: 0.31896424715232463d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14975557199832845d, b: 0.8649037801511367d, c: 0.8035067258718913d),

new NpgsqlTypes.NpgsqlLine(a: 0.022767088770272226d, b: 0.824519829812387d, c: 0.2990170967826957d),

new NpgsqlTypes.NpgsqlLine(a: 0.264229467978496d, b: 0.4707396384081288d, c: 0.5870444614457326d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1750072079));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6509605768915644d, b: 0.2871280523199907d, c: 0.5279864073907687d),

new NpgsqlTypes.NpgsqlLine(a: 0.847627780191932d, b: 0.2863239370866939d, c: 0.39664595009550063d),

new NpgsqlTypes.NpgsqlLine(a: 0.06719070091173818d, b: 0.2998868113793318d, c: 0.8109899934095542d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30402634597868494d, b: 0.7741177113732105d, c: 0.4982697795456863d),

new NpgsqlTypes.NpgsqlLine(a: 0.22134239051678783d, b: 0.952989590947333d, c: 0.1976805178607327d),

new NpgsqlTypes.NpgsqlLine(a: 0.48019693876130953d, b: 0.8553553442730837d, c: 0.4578014530562905d),

new NpgsqlTypes.NpgsqlLine(a: 0.7948720279836796d, b: 0.6347165612507009d, c: 0.4915047790558922d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(681877477));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.054876749435908034d, b: 0.7476698065656858d, c: 0.5221215501493097d),

new NpgsqlTypes.NpgsqlLine(a: 0.1689911006864584d, b: 0.16032672190790076d, c: 0.9537953031702238d),

new NpgsqlTypes.NpgsqlLine(a: 0.3133690487713232d, b: 0.21425817972116357d, c: 0.39002508371565625d),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1765269457));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4428210775962541d, b: 0.44628545865868685d, c: 0.7913435097925557d),

new NpgsqlTypes.NpgsqlLine(a: 0.26419018627718516d, b: 0.12166427922453704d, c: 0.11250832552770584d),

new NpgsqlTypes.NpgsqlLine(a: 0.20276585628171784d, b: 0.14489314174625478d, c: 0.5410582863519566d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(699428708));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.75437435623167d, b: 0.4381969103973332d, c: 0.13859938549471296d),

new NpgsqlTypes.NpgsqlLine(a: 0.22478326045746155d, b: 0.7927996319630696d, c: 0.5653146543488808d),

new NpgsqlTypes.NpgsqlLine(a: 0.8148660813324691d, b: 0.5965502974097225d, c: 0.08598406767552191d),

new NpgsqlTypes.NpgsqlLine(a: 0.10261855436837408d, b: 0.22753843400620033d, c: 0.6663050101504865d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19047502268477823d, b: 0.503647750986701d, c: 0.5140837344549085d),

new NpgsqlTypes.NpgsqlLine(a: 0.5498279015442291d, b: 0.5205498180433044d, c: 0.5511400439881968d),

new NpgsqlTypes.NpgsqlLine(a: 0.07519565206915457d, b: 0.8190939422278946d, c: 0.4842243543091963d),

new NpgsqlTypes.NpgsqlLine(a: 0.11151345358207676d, b: 0.2794260095615846d, c: 0.1977999861392018d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 1352296160);
                var models =  ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(9));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1422030401));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5508950376990435d, b: 0.1842011543506923d, c: 0.7200839172656331d),

new NpgsqlTypes.NpgsqlLine(a: 0.08098131741133519d, b: 0.2512744482896645d, c: 0.4419893154281408d),

new NpgsqlTypes.NpgsqlLine(a: 0.7183180834237055d, b: 0.3821225061156569d, c: 0.320010478004808d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.605461690855222d, b: 0.5098249599693536d, c: 0.049446338505273246d),

new NpgsqlTypes.NpgsqlLine(a: 0.6383133050473475d, b: 0.5385834180776717d, c: 0.2612256906158803d),

new NpgsqlTypes.NpgsqlLine(a: 0.2259744218921168d, b: 0.0504022254415285d, c: 0.5085817881315488d),

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
                Assert.That(model.Id, Is.EqualTo(1441068318));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04431673188157559d, b: 0.7118895502319815d, c: 0.8045459394080527d),

new NpgsqlTypes.NpgsqlLine(a: 0.41883883343441664d, b: 0.0856133325697227d, c: 0.45940150990219364d),

new NpgsqlTypes.NpgsqlLine(a: 0.3845455332415372d, b: 0.5278908004707358d, c: 0.45211852173959755d),

new NpgsqlTypes.NpgsqlLine(a: 0.707344526938849d, b: 0.2664835051263448d, c: 0.8012907013628192d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5167014945187821d, b: 0.2318523474732329d, c: 0.0766480392056259d),

new NpgsqlTypes.NpgsqlLine(a: 0.6239339834043951d, b: 0.4407650281616141d, c: 0.07711199216030074d),

new NpgsqlTypes.NpgsqlLine(a: 0.7330247230488705d, b: 0.06195929907587139d, c: 0.1736910797965654d),

new NpgsqlTypes.NpgsqlLine(a: 0.5060985759956755d, b: 0.12918142066992122d, c: 0.3598502037154421d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1349638635));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8811777097968191d, b: 0.09805743628781294d, c: 0.8476023389336619d),

new NpgsqlTypes.NpgsqlLine(a: 0.16329696312104391d, b: 0.8434248077846473d, c: 0.0171626874853823d),

new NpgsqlTypes.NpgsqlLine(a: 0.5930114320798587d, b: 0.7874763150232159d, c: 0.20169365861720767d),

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
                Assert.That(model.Id, Is.EqualTo(1485177216));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7620135774845544d, b: 0.72234986247445d, c: 0.7900958363555012d),

new NpgsqlTypes.NpgsqlLine(a: 0.5982892074823093d, b: 0.9157569165822279d, c: 0.5913666560112503d),

new NpgsqlTypes.NpgsqlLine(a: 0.3694255096703286d, b: 0.43689654039349735d, c: 0.27488642071951885d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1888587968));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9441675468790086d, b: 0.10273087249159918d, c: 0.36496868371913627d),

new NpgsqlTypes.NpgsqlLine(a: 0.3153900895384264d, b: 0.8953921593705707d, c: 0.6821583482258307d),

new NpgsqlTypes.NpgsqlLine(a: 0.15884512105184567d, b: 0.20745599422324912d, c: 0.5928677501305737d),

new NpgsqlTypes.NpgsqlLine(a: 0.19203772899196803d, b: 0.9281999546867626d, c: 0.9792553764463741d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.616453689236877d, b: 0.26880075600348696d, c: 0.9911672578342802d),

new NpgsqlTypes.NpgsqlLine(a: 0.41598816366831615d, b: 0.2972198032481773d, c: 0.6096249065094251d),

new NpgsqlTypes.NpgsqlLine(a: 0.21461782395965212d, b: 0.4996081675192614d, c: 0.845029551763019d),

new NpgsqlTypes.NpgsqlLine(a: 0.14603833144353173d, b: 0.5155958582129082d, c: 0.9513100476397736d),

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
                Assert.That(model.Id, Is.EqualTo(1612037280));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9755688560619167d, b: 0.7517347444178538d, c: 0.4433097656621017d),

new NpgsqlTypes.NpgsqlLine(a: 0.27642151559126893d, b: 0.49560032188535075d, c: 0.4017019854911661d),

new NpgsqlTypes.NpgsqlLine(a: 0.48234378585453686d, b: 0.5838608048706788d, c: 0.45264440736135125d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1803941428));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4958174274877982d, b: 0.19935005698584918d, c: 0.6570481803156852d),

new NpgsqlTypes.NpgsqlLine(a: 0.586031122116916d, b: 0.20438200508300097d, c: 0.7214279726394314d),

new NpgsqlTypes.NpgsqlLine(a: 0.3287771922455527d, b: 0.31464931534195395d, c: 0.49275260904707807d),

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
                Assert.That(model.Id, Is.EqualTo(1694903385));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5133551130062282d, b: 0.5981369379522861d, c: 0.5856516805262975d),

new NpgsqlTypes.NpgsqlLine(a: 0.4556255479239121d, b: 0.059243842569019045d, c: 0.18272228811839042d),

new NpgsqlTypes.NpgsqlLine(a: 0.8085308768004308d, b: 0.8348590541320315d, c: 0.5895099353964641d),

new NpgsqlTypes.NpgsqlLine(a: 0.24149968696186774d, b: 0.35557480082622506d, c: 0.5451461752136405d),

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
                Assert.That(model.Id, Is.EqualTo(1708194464));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21378574042766885d, b: 0.22474127876321393d, c: 0.01286635194062602d),

new NpgsqlTypes.NpgsqlLine(a: 0.44720527497131246d, b: 0.83386820783986d, c: 0.47600740851603984d),

new NpgsqlTypes.NpgsqlLine(a: 0.9177345103701179d, b: 0.8135674766115204d, c: 0.23923291716083794d),

new NpgsqlTypes.NpgsqlLine(a: 0.9998743487003019d, b: 0.013427841900149451d, c: 0.9133209978570025d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(871029693));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09314286666835214d, b: 0.9419395542104619d, c: 0.23265001920909978d),

new NpgsqlTypes.NpgsqlLine(a: 0.7840922282915723d, b: 0.8769622177219351d, c: 0.08844919095146764d),

new NpgsqlTypes.NpgsqlLine(a: 0.30172065868559383d, b: 0.061796126836928256d, c: 0.7819510380905712d),

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
                Assert.That(model.Id, Is.EqualTo(1749272119));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48465570613062037d, b: 0.4077570571696034d, c: 0.09124205112015671d),

new NpgsqlTypes.NpgsqlLine(a: 0.4905692123673753d, b: 0.09753381316271936d, c: 0.6219861110019185d),

new NpgsqlTypes.NpgsqlLine(a: 0.7715584772299492d, b: 0.7647042738214676d, c: 0.32981711302760286d),

new NpgsqlTypes.NpgsqlLine(a: 0.7826950107361046d, b: 0.6159017458991703d, c: 0.8761288210787351d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05854830086605134d, b: 0.4584727830793912d, c: 0.6485776355671607d),

new NpgsqlTypes.NpgsqlLine(a: 0.057402368952540694d, b: 0.814338567877536d, c: 0.36045674525095406d),

new NpgsqlTypes.NpgsqlLine(a: 0.4609921668504162d, b: 0.45446719793916357d, c: 0.6647833262693906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8421363107491464d, b: 0.8724917366553757d, c: 0.2954174236384989d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743101311));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30049737151744216d, b: 0.10935998965187232d, c: 0.12002566064851483d),

new NpgsqlTypes.NpgsqlLine(a: 0.4579983959880112d, b: 0.8700234892072651d, c: 0.24545341370685325d),

new NpgsqlTypes.NpgsqlLine(a: 0.6992061752442d, b: 0.8760611086508132d, c: 0.31896424715232463d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14975557199832845d, b: 0.8649037801511367d, c: 0.8035067258718913d),

new NpgsqlTypes.NpgsqlLine(a: 0.022767088770272226d, b: 0.824519829812387d, c: 0.2990170967826957d),

new NpgsqlTypes.NpgsqlLine(a: 0.264229467978496d, b: 0.4707396384081288d, c: 0.5870444614457326d),

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
                Assert.That(model.Id, Is.EqualTo(1750072079));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6509605768915644d, b: 0.2871280523199907d, c: 0.5279864073907687d),

new NpgsqlTypes.NpgsqlLine(a: 0.847627780191932d, b: 0.2863239370866939d, c: 0.39664595009550063d),

new NpgsqlTypes.NpgsqlLine(a: 0.06719070091173818d, b: 0.2998868113793318d, c: 0.8109899934095542d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30402634597868494d, b: 0.7741177113732105d, c: 0.4982697795456863d),

new NpgsqlTypes.NpgsqlLine(a: 0.22134239051678783d, b: 0.952989590947333d, c: 0.1976805178607327d),

new NpgsqlTypes.NpgsqlLine(a: 0.48019693876130953d, b: 0.8553553442730837d, c: 0.4578014530562905d),

new NpgsqlTypes.NpgsqlLine(a: 0.7948720279836796d, b: 0.6347165612507009d, c: 0.4915047790558922d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(681877477));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.054876749435908034d, b: 0.7476698065656858d, c: 0.5221215501493097d),

new NpgsqlTypes.NpgsqlLine(a: 0.1689911006864584d, b: 0.16032672190790076d, c: 0.9537953031702238d),

new NpgsqlTypes.NpgsqlLine(a: 0.3133690487713232d, b: 0.21425817972116357d, c: 0.39002508371565625d),

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
                Assert.That(model.Id, Is.EqualTo(1765269457));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4428210775962541d, b: 0.44628545865868685d, c: 0.7913435097925557d),

new NpgsqlTypes.NpgsqlLine(a: 0.26419018627718516d, b: 0.12166427922453704d, c: 0.11250832552770584d),

new NpgsqlTypes.NpgsqlLine(a: 0.20276585628171784d, b: 0.14489314174625478d, c: 0.5410582863519566d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(699428708));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.75437435623167d, b: 0.4381969103973332d, c: 0.13859938549471296d),

new NpgsqlTypes.NpgsqlLine(a: 0.22478326045746155d, b: 0.7927996319630696d, c: 0.5653146543488808d),

new NpgsqlTypes.NpgsqlLine(a: 0.8148660813324691d, b: 0.5965502974097225d, c: 0.08598406767552191d),

new NpgsqlTypes.NpgsqlLine(a: 0.10261855436837408d, b: 0.22753843400620033d, c: 0.6663050101504865d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19047502268477823d, b: 0.503647750986701d, c: 0.5140837344549085d),

new NpgsqlTypes.NpgsqlLine(a: 0.5498279015442291d, b: 0.5205498180433044d, c: 0.5511400439881968d),

new NpgsqlTypes.NpgsqlLine(a: 0.07519565206915457d, b: 0.8190939422278946d, c: 0.4842243543091963d),

new NpgsqlTypes.NpgsqlLine(a: 0.11151345358207676d, b: 0.2794260095615846d, c: 0.1977999861392018d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 940484658);
                var models = await ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(17));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(956171576));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6305558129660189d, b: 0.5463622939629917d, c: 0.401891977997777d),

new NpgsqlTypes.NpgsqlLine(a: 0.3662230087345998d, b: 0.4302679455886196d, c: 0.9631184941583132d),

new NpgsqlTypes.NpgsqlLine(a: 0.3634906094993412d, b: 0.18046820180120404d, c: 0.5193725822662353d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48533853922222536d, b: 0.7781157007327932d, c: 0.20671476643143427d),

new NpgsqlTypes.NpgsqlLine(a: 0.7321919326621603d, b: 0.7704043405190548d, c: 0.5508846640658778d),

new NpgsqlTypes.NpgsqlLine(a: 0.5796306726535371d, b: 0.3621536966457104d, c: 0.3554092618887771d),

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
                Assert.That(model.Id, Is.EqualTo(1049476690));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1703167002028123d, b: 0.06899134909065618d, c: 0.39632655876575884d),

new NpgsqlTypes.NpgsqlLine(a: 0.9436521110809849d, b: 0.2716102490692832d, c: 0.21807972083943694d),

new NpgsqlTypes.NpgsqlLine(a: 0.07510391898176405d, b: 0.4622700624960824d, c: 0.6916474126671974d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3434566231012316d, b: 0.6092872970160005d, c: 0.8285200623737458d),

new NpgsqlTypes.NpgsqlLine(a: 0.438620087459067d, b: 0.42784452615069857d, c: 0.43791996431227087d),

new NpgsqlTypes.NpgsqlLine(a: 0.13822472685663223d, b: 0.3567687904324768d, c: 0.5713362361619454d),

new NpgsqlTypes.NpgsqlLine(a: 0.4225842002023096d, b: 0.13041963778907273d, c: 0.537431949671262d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(259689541));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16915141278580792d, b: 0.5107686791340034d, c: 0.6489920882506348d),

new NpgsqlTypes.NpgsqlLine(a: 0.030879513236027d, b: 0.6401283771223818d, c: 0.4904762444562075d),

new NpgsqlTypes.NpgsqlLine(a: 0.16124954101586042d, b: 0.7102870300472969d, c: 0.9978682907813775d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3413197342637151d, b: 0.3564754218301692d, c: 0.16698356005321802d),

new NpgsqlTypes.NpgsqlLine(a: 0.24996465538547474d, b: 0.6936235099874405d, c: 0.00768766971096424d),

new NpgsqlTypes.NpgsqlLine(a: 0.9713834412198872d, b: 0.1937685310996965d, c: 0.5638524218711839d),

new NpgsqlTypes.NpgsqlLine(a: 0.20790035052620326d, b: 0.7280555648340241d, c: 0.7150389111804211d),

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
                Assert.That(model.Id, Is.EqualTo(1169283916));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6136867588329713d, b: 0.8476721243007673d, c: 0.2920466838690219d),

new NpgsqlTypes.NpgsqlLine(a: 0.5632572533709046d, b: 0.8580393386665631d, c: 0.29067186403759726d),

new NpgsqlTypes.NpgsqlLine(a: 0.05864985939465561d, b: 0.06933376015004311d, c: 0.2622230618531959d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3083889075922114d, b: 0.40504233141015844d, c: 0.7282625593772889d),

new NpgsqlTypes.NpgsqlLine(a: 0.9760389595620657d, b: 0.5432046524856411d, c: 0.4805721407516501d),

new NpgsqlTypes.NpgsqlLine(a: 0.226094370846618d, b: 0.30929816503923757d, c: 0.749788108094253d),

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
                Assert.That(model.Id, Is.EqualTo(1247961184));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588334999708729d, b: 0.5781258655739143d, c: 0.4951203893647069d),

new NpgsqlTypes.NpgsqlLine(a: 0.206651781249944d, b: 0.9214488824097644d, c: 0.7102197735978709d),

new NpgsqlTypes.NpgsqlLine(a: 0.8293873017859008d, b: 0.4197388618664637d, c: 0.7538628331143343d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9886122302398814d, b: 0.09733443476141157d, c: 0.8828756753279827d),

new NpgsqlTypes.NpgsqlLine(a: 0.4191781730328399d, b: 0.8360940579259326d, c: 0.3115604346093266d),

new NpgsqlTypes.NpgsqlLine(a: 0.03123256692948395d, b: 0.4210178852779579d, c: 0.7083559364281564d),

new NpgsqlTypes.NpgsqlLine(a: 0.10193811062121638d, b: 0.7865607707379441d, c: 0.5102014504618864d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(313349652));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7148027863911385d, b: 0.4116315290140842d, c: 0.9883513693293022d),

new NpgsqlTypes.NpgsqlLine(a: 0.730798769811796d, b: 0.5625059295801093d, c: 0.028144945623879147d),

new NpgsqlTypes.NpgsqlLine(a: 0.7895921923207063d, b: 0.897092096080744d, c: 0.36804397804374556d),

new NpgsqlTypes.NpgsqlLine(a: 0.4403951364132078d, b: 0.48316034726668566d, c: 0.5561087583026281d),

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
                Assert.That(model.Id, Is.EqualTo(1251267268));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.27064576558959075d, b: 0.24611103650290955d, c: 0.04928435530376152d),

new NpgsqlTypes.NpgsqlLine(a: 0.5382620257248645d, b: 0.586731968734226d, c: 0.9110741668368397d),

new NpgsqlTypes.NpgsqlLine(a: 0.8386954216871374d, b: 0.14045527908308764d, c: 0.5300328684198944d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7572326327773035d, b: 0.10039993499818312d, c: 0.17339739029118428d),

new NpgsqlTypes.NpgsqlLine(a: 0.9566618331567527d, b: 0.14668861402647748d, c: 0.7767711369985796d),

new NpgsqlTypes.NpgsqlLine(a: 0.932727244163919d, b: 0.12159065636952726d, c: 0.1704609096711438d),

new NpgsqlTypes.NpgsqlLine(a: 0.5792460825794749d, b: 0.985437582839235d, c: 0.557473090399633d),

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
                Assert.That(model.Id, Is.EqualTo(1276251566));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4808529939808879d, b: 0.365247596328651d, c: 0.17939866902766977d),

new NpgsqlTypes.NpgsqlLine(a: 0.12809708913748585d, b: 0.18821025600986407d, c: 0.9740037535570704d),

new NpgsqlTypes.NpgsqlLine(a: 0.7729579560840041d, b: 0.5283959837814016d, c: 0.3246873097765165d),

new NpgsqlTypes.NpgsqlLine(a: 0.5804554841359071d, b: 0.7951318743812129d, c: 0.9533437460862759d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07357632206959641d, b: 0.11099061080365447d, c: 0.47576723756466854d),

new NpgsqlTypes.NpgsqlLine(a: 0.9051522311200175d, b: 0.6041352781626989d, c: 0.962846313750425d),

new NpgsqlTypes.NpgsqlLine(a: 0.7230697163609032d, b: 0.35996997662147945d, c: 0.2719627850842049d),

new NpgsqlTypes.NpgsqlLine(a: 0.039972657007877d, b: 0.6660692046588974d, c: 0.8074219604808613d),

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
                Assert.That(model.Id, Is.EqualTo(1278639929));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8637991908928382d, b: 0.7989476928355281d, c: 0.047074497669961635d),

new NpgsqlTypes.NpgsqlLine(a: 0.24284327761860214d, b: 0.034845279321367495d, c: 0.8243144068858446d),

new NpgsqlTypes.NpgsqlLine(a: 0.2705173386529084d, b: 0.37759514414776285d, c: 0.003784057263189533d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5464646368268954d, b: 0.1698011067851829d, c: 0.4811896051504386d),

new NpgsqlTypes.NpgsqlLine(a: 0.3264558304845737d, b: 0.09741548986796533d, c: 0.35078408755418944d),

new NpgsqlTypes.NpgsqlLine(a: 0.1253849539183054d, b: 0.9184504405667023d, c: 0.6244095303662431d),

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
                Assert.That(model.Id, Is.EqualTo(1352296160));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6961581521563707d, b: 0.2870425810465653d, c: 0.022813771410836625d),

new NpgsqlTypes.NpgsqlLine(a: 0.9289180434806266d, b: 0.10310192777053839d, c: 0.4974840036652155d),

new NpgsqlTypes.NpgsqlLine(a: 0.9742618124298718d, b: 0.666155889593685d, c: 0.9108800941033853d),

new NpgsqlTypes.NpgsqlLine(a: 0.4076993728994177d, b: 0.9237619110159688d, c: 0.16349574316883708d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.40245830157937157d, b: 0.4425237993192568d, c: 0.3605907953188545d),

new NpgsqlTypes.NpgsqlLine(a: 0.3025387755185438d, b: 0.16175616826033246d, c: 0.08369914886846197d),

new NpgsqlTypes.NpgsqlLine(a: 0.7932786053551402d, b: 0.4757892941852452d, c: 0.35215963103511483d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2052209240));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28682097488067404d, b: 0.19347953745544d, c: 0.767001580247448d),

new NpgsqlTypes.NpgsqlLine(a: 0.34168929191792363d, b: 0.5324263819109204d, c: 0.3548736591683712d),

new NpgsqlTypes.NpgsqlLine(a: 0.7601584215479089d, b: 0.9667193856859281d, c: 0.48805620341333844d),

new NpgsqlTypes.NpgsqlLine(a: 0.4778030273140724d, b: 0.6459214140044727d, c: 0.9825570138966864d),

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
                Assert.That(model.Id, Is.EqualTo(1422030401));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5508950376990435d, b: 0.1842011543506923d, c: 0.7200839172656331d),

new NpgsqlTypes.NpgsqlLine(a: 0.08098131741133519d, b: 0.2512744482896645d, c: 0.4419893154281408d),

new NpgsqlTypes.NpgsqlLine(a: 0.7183180834237055d, b: 0.3821225061156569d, c: 0.320010478004808d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.605461690855222d, b: 0.5098249599693536d, c: 0.049446338505273246d),

new NpgsqlTypes.NpgsqlLine(a: 0.6383133050473475d, b: 0.5385834180776717d, c: 0.2612256906158803d),

new NpgsqlTypes.NpgsqlLine(a: 0.2259744218921168d, b: 0.0504022254415285d, c: 0.5085817881315488d),

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
                Assert.That(model.Id, Is.EqualTo(1441068318));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04431673188157559d, b: 0.7118895502319815d, c: 0.8045459394080527d),

new NpgsqlTypes.NpgsqlLine(a: 0.41883883343441664d, b: 0.0856133325697227d, c: 0.45940150990219364d),

new NpgsqlTypes.NpgsqlLine(a: 0.3845455332415372d, b: 0.5278908004707358d, c: 0.45211852173959755d),

new NpgsqlTypes.NpgsqlLine(a: 0.707344526938849d, b: 0.2664835051263448d, c: 0.8012907013628192d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5167014945187821d, b: 0.2318523474732329d, c: 0.0766480392056259d),

new NpgsqlTypes.NpgsqlLine(a: 0.6239339834043951d, b: 0.4407650281616141d, c: 0.07711199216030074d),

new NpgsqlTypes.NpgsqlLine(a: 0.7330247230488705d, b: 0.06195929907587139d, c: 0.1736910797965654d),

new NpgsqlTypes.NpgsqlLine(a: 0.5060985759956755d, b: 0.12918142066992122d, c: 0.3598502037154421d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1349638635));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8811777097968191d, b: 0.09805743628781294d, c: 0.8476023389336619d),

new NpgsqlTypes.NpgsqlLine(a: 0.16329696312104391d, b: 0.8434248077846473d, c: 0.0171626874853823d),

new NpgsqlTypes.NpgsqlLine(a: 0.5930114320798587d, b: 0.7874763150232159d, c: 0.20169365861720767d),

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
                Assert.That(model.Id, Is.EqualTo(1485177216));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7620135774845544d, b: 0.72234986247445d, c: 0.7900958363555012d),

new NpgsqlTypes.NpgsqlLine(a: 0.5982892074823093d, b: 0.9157569165822279d, c: 0.5913666560112503d),

new NpgsqlTypes.NpgsqlLine(a: 0.3694255096703286d, b: 0.43689654039349735d, c: 0.27488642071951885d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1888587968));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9441675468790086d, b: 0.10273087249159918d, c: 0.36496868371913627d),

new NpgsqlTypes.NpgsqlLine(a: 0.3153900895384264d, b: 0.8953921593705707d, c: 0.6821583482258307d),

new NpgsqlTypes.NpgsqlLine(a: 0.15884512105184567d, b: 0.20745599422324912d, c: 0.5928677501305737d),

new NpgsqlTypes.NpgsqlLine(a: 0.19203772899196803d, b: 0.9281999546867626d, c: 0.9792553764463741d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.616453689236877d, b: 0.26880075600348696d, c: 0.9911672578342802d),

new NpgsqlTypes.NpgsqlLine(a: 0.41598816366831615d, b: 0.2972198032481773d, c: 0.6096249065094251d),

new NpgsqlTypes.NpgsqlLine(a: 0.21461782395965212d, b: 0.4996081675192614d, c: 0.845029551763019d),

new NpgsqlTypes.NpgsqlLine(a: 0.14603833144353173d, b: 0.5155958582129082d, c: 0.9513100476397736d),

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
                Assert.That(model.Id, Is.EqualTo(1612037280));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9755688560619167d, b: 0.7517347444178538d, c: 0.4433097656621017d),

new NpgsqlTypes.NpgsqlLine(a: 0.27642151559126893d, b: 0.49560032188535075d, c: 0.4017019854911661d),

new NpgsqlTypes.NpgsqlLine(a: 0.48234378585453686d, b: 0.5838608048706788d, c: 0.45264440736135125d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1803941428));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4958174274877982d, b: 0.19935005698584918d, c: 0.6570481803156852d),

new NpgsqlTypes.NpgsqlLine(a: 0.586031122116916d, b: 0.20438200508300097d, c: 0.7214279726394314d),

new NpgsqlTypes.NpgsqlLine(a: 0.3287771922455527d, b: 0.31464931534195395d, c: 0.49275260904707807d),

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
                Assert.That(model.Id, Is.EqualTo(1694903385));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5133551130062282d, b: 0.5981369379522861d, c: 0.5856516805262975d),

new NpgsqlTypes.NpgsqlLine(a: 0.4556255479239121d, b: 0.059243842569019045d, c: 0.18272228811839042d),

new NpgsqlTypes.NpgsqlLine(a: 0.8085308768004308d, b: 0.8348590541320315d, c: 0.5895099353964641d),

new NpgsqlTypes.NpgsqlLine(a: 0.24149968696186774d, b: 0.35557480082622506d, c: 0.5451461752136405d),

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
                Assert.That(model.Id, Is.EqualTo(1708194464));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21378574042766885d, b: 0.22474127876321393d, c: 0.01286635194062602d),

new NpgsqlTypes.NpgsqlLine(a: 0.44720527497131246d, b: 0.83386820783986d, c: 0.47600740851603984d),

new NpgsqlTypes.NpgsqlLine(a: 0.9177345103701179d, b: 0.8135674766115204d, c: 0.23923291716083794d),

new NpgsqlTypes.NpgsqlLine(a: 0.9998743487003019d, b: 0.013427841900149451d, c: 0.9133209978570025d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(871029693));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09314286666835214d, b: 0.9419395542104619d, c: 0.23265001920909978d),

new NpgsqlTypes.NpgsqlLine(a: 0.7840922282915723d, b: 0.8769622177219351d, c: 0.08844919095146764d),

new NpgsqlTypes.NpgsqlLine(a: 0.30172065868559383d, b: 0.061796126836928256d, c: 0.7819510380905712d),

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
                Assert.That(model.Id, Is.EqualTo(1749272119));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48465570613062037d, b: 0.4077570571696034d, c: 0.09124205112015671d),

new NpgsqlTypes.NpgsqlLine(a: 0.4905692123673753d, b: 0.09753381316271936d, c: 0.6219861110019185d),

new NpgsqlTypes.NpgsqlLine(a: 0.7715584772299492d, b: 0.7647042738214676d, c: 0.32981711302760286d),

new NpgsqlTypes.NpgsqlLine(a: 0.7826950107361046d, b: 0.6159017458991703d, c: 0.8761288210787351d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05854830086605134d, b: 0.4584727830793912d, c: 0.6485776355671607d),

new NpgsqlTypes.NpgsqlLine(a: 0.057402368952540694d, b: 0.814338567877536d, c: 0.36045674525095406d),

new NpgsqlTypes.NpgsqlLine(a: 0.4609921668504162d, b: 0.45446719793916357d, c: 0.6647833262693906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8421363107491464d, b: 0.8724917366553757d, c: 0.2954174236384989d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743101311));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30049737151744216d, b: 0.10935998965187232d, c: 0.12002566064851483d),

new NpgsqlTypes.NpgsqlLine(a: 0.4579983959880112d, b: 0.8700234892072651d, c: 0.24545341370685325d),

new NpgsqlTypes.NpgsqlLine(a: 0.6992061752442d, b: 0.8760611086508132d, c: 0.31896424715232463d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14975557199832845d, b: 0.8649037801511367d, c: 0.8035067258718913d),

new NpgsqlTypes.NpgsqlLine(a: 0.022767088770272226d, b: 0.824519829812387d, c: 0.2990170967826957d),

new NpgsqlTypes.NpgsqlLine(a: 0.264229467978496d, b: 0.4707396384081288d, c: 0.5870444614457326d),

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
                Assert.That(model.Id, Is.EqualTo(1750072079));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6509605768915644d, b: 0.2871280523199907d, c: 0.5279864073907687d),

new NpgsqlTypes.NpgsqlLine(a: 0.847627780191932d, b: 0.2863239370866939d, c: 0.39664595009550063d),

new NpgsqlTypes.NpgsqlLine(a: 0.06719070091173818d, b: 0.2998868113793318d, c: 0.8109899934095542d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30402634597868494d, b: 0.7741177113732105d, c: 0.4982697795456863d),

new NpgsqlTypes.NpgsqlLine(a: 0.22134239051678783d, b: 0.952989590947333d, c: 0.1976805178607327d),

new NpgsqlTypes.NpgsqlLine(a: 0.48019693876130953d, b: 0.8553553442730837d, c: 0.4578014530562905d),

new NpgsqlTypes.NpgsqlLine(a: 0.7948720279836796d, b: 0.6347165612507009d, c: 0.4915047790558922d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(681877477));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.054876749435908034d, b: 0.7476698065656858d, c: 0.5221215501493097d),

new NpgsqlTypes.NpgsqlLine(a: 0.1689911006864584d, b: 0.16032672190790076d, c: 0.9537953031702238d),

new NpgsqlTypes.NpgsqlLine(a: 0.3133690487713232d, b: 0.21425817972116357d, c: 0.39002508371565625d),

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
                Assert.That(model.Id, Is.EqualTo(1765269457));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4428210775962541d, b: 0.44628545865868685d, c: 0.7913435097925557d),

new NpgsqlTypes.NpgsqlLine(a: 0.26419018627718516d, b: 0.12166427922453704d, c: 0.11250832552770584d),

new NpgsqlTypes.NpgsqlLine(a: 0.20276585628171784d, b: 0.14489314174625478d, c: 0.5410582863519566d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(699428708));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.75437435623167d, b: 0.4381969103973332d, c: 0.13859938549471296d),

new NpgsqlTypes.NpgsqlLine(a: 0.22478326045746155d, b: 0.7927996319630696d, c: 0.5653146543488808d),

new NpgsqlTypes.NpgsqlLine(a: 0.8148660813324691d, b: 0.5965502974097225d, c: 0.08598406767552191d),

new NpgsqlTypes.NpgsqlLine(a: 0.10261855436837408d, b: 0.22753843400620033d, c: 0.6663050101504865d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19047502268477823d, b: 0.503647750986701d, c: 0.5140837344549085d),

new NpgsqlTypes.NpgsqlLine(a: 0.5498279015442291d, b: 0.5205498180433044d, c: 0.5511400439881968d),

new NpgsqlTypes.NpgsqlLine(a: 0.07519565206915457d, b: 0.8190939422278946d, c: 0.4842243543091963d),

new NpgsqlTypes.NpgsqlLine(a: 0.11151345358207676d, b: 0.2794260095615846d, c: 0.1977999861392018d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)
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
                 foreach(var batchResult in ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelBatch(connection, 425879955, 920410273))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(23));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(447065450));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6636554004535458d, b: 0.4052905058278198d, c: 0.17999403534412883d),

new NpgsqlTypes.NpgsqlLine(a: 0.4929643299593621d, b: 0.04102771738828992d, c: 0.8758588440576921d),

new NpgsqlTypes.NpgsqlLine(a: 0.9843591359807438d, b: 0.9486545770421181d, c: 0.23810538982780194d),

new NpgsqlTypes.NpgsqlLine(a: 0.0373504814930844d, b: 0.29650224807426506d, c: 0.6527517869517908d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1935239880));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5125009420178407d, b: 0.13553866813087467d, c: 0.6573124881706722d),

new NpgsqlTypes.NpgsqlLine(a: 0.9315668534985179d, b: 0.031339976871202935d, c: 0.7319776155987312d),

new NpgsqlTypes.NpgsqlLine(a: 0.5913519522327184d, b: 0.688194613219936d, c: 0.7487303543444555d),

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
                Assert.That(model.Id, Is.EqualTo(776647699));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8841755970938628d, b: 0.039993263617271846d, c: 0.2425222413816407d),

new NpgsqlTypes.NpgsqlLine(a: 0.3162669055857611d, b: 0.1360654949714053d, c: 0.585066125260232d),

new NpgsqlTypes.NpgsqlLine(a: 0.23614085233198578d, b: 0.9624524908146396d, c: 0.8036122013629919d),

new NpgsqlTypes.NpgsqlLine(a: 0.9594786748108928d, b: 0.3334512033062713d, c: 0.8626799508985245d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7692177568154062d, b: 0.8045212370680859d, c: 0.347836807601842d),

new NpgsqlTypes.NpgsqlLine(a: 0.8596806867272218d, b: 0.42225206488490163d, c: 0.2626771759427945d),

new NpgsqlTypes.NpgsqlLine(a: 0.6334601490046422d, b: 0.5508277640730257d, c: 0.9702039181027914d),

new NpgsqlTypes.NpgsqlLine(a: 0.7862671596820799d, b: 0.6148121550149941d, c: 0.10467782441316142d),

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
                Assert.That(model.Id, Is.EqualTo(920410273));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7950181430955406d, b: 0.3848051391253504d, c: 0.1572657802170856d),

new NpgsqlTypes.NpgsqlLine(a: 0.6062151918599252d, b: 0.06062326101597226d, c: 0.14777044879318857d),

new NpgsqlTypes.NpgsqlLine(a: 0.7408182398935058d, b: 0.6661433504932776d, c: 0.15722709569280902d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2482561889064241d, b: 0.768360521777252d, c: 0.24033198573060877d),

new NpgsqlTypes.NpgsqlLine(a: 0.6078828832971318d, b: 0.25910942482320465d, c: 0.7624300130707319d),

new NpgsqlTypes.NpgsqlLine(a: 0.551230062109523d, b: 0.5951997473266207d, c: 0.05557568229198884d),

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
                Assert.That(model.Id, Is.EqualTo(929385902));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8285395037487209d, b: 0.25070273066629d, c: 0.2500673109161923d),

new NpgsqlTypes.NpgsqlLine(a: 0.9942717530143405d, b: 0.21539215026712022d, c: 0.20269945939501077d),

new NpgsqlTypes.NpgsqlLine(a: 0.7979702358088475d, b: 0.0037115614378556705d, c: 0.8843432168677479d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1456202870910711d, b: 0.06772665910903597d, c: 0.691750610472359d),

new NpgsqlTypes.NpgsqlLine(a: 0.765757989281042d, b: 0.32982835634782004d, c: 0.8913701807765988d),

new NpgsqlTypes.NpgsqlLine(a: 0.052240732409688406d, b: 0.618262798295761d, c: 0.8474290495942781d),

new NpgsqlTypes.NpgsqlLine(a: 0.3584922315949717d, b: 0.520574773115294d, c: 0.8310230234204736d),

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

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(939691488));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15928813769803307d, b: 0.5335096410959914d, c: 0.9693141891385088d),

new NpgsqlTypes.NpgsqlLine(a: 0.9448241901930845d, b: 0.6287076527827521d, c: 0.6660617468801671d),

new NpgsqlTypes.NpgsqlLine(a: 0.30712778702622445d, b: 0.324942912367581d, c: 0.9500282198259326d),

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
                Assert.That(model.Id, Is.EqualTo(940484658));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8457530794410952d, b: 0.07468146527745967d, c: 0.6058450234777081d),

new NpgsqlTypes.NpgsqlLine(a: 0.43907623012482566d, b: 0.4163533057091461d, c: 0.7083053151407345d),

new NpgsqlTypes.NpgsqlLine(a: 0.6460729456777172d, b: 0.3996032448892458d, c: 0.32058136990645736d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5056133907420888d, b: 0.687789482585691d, c: 0.5736898296981361d),

new NpgsqlTypes.NpgsqlLine(a: 0.6165837793609097d, b: 0.3896094649555947d, c: 0.782529168193896d),

new NpgsqlTypes.NpgsqlLine(a: 0.19522061405511182d, b: 0.49515141325692447d, c: 0.8154303350690599d),

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
                Assert.That(model.Id, Is.EqualTo(956171576));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6305558129660189d, b: 0.5463622939629917d, c: 0.401891977997777d),

new NpgsqlTypes.NpgsqlLine(a: 0.3662230087345998d, b: 0.4302679455886196d, c: 0.9631184941583132d),

new NpgsqlTypes.NpgsqlLine(a: 0.3634906094993412d, b: 0.18046820180120404d, c: 0.5193725822662353d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48533853922222536d, b: 0.7781157007327932d, c: 0.20671476643143427d),

new NpgsqlTypes.NpgsqlLine(a: 0.7321919326621603d, b: 0.7704043405190548d, c: 0.5508846640658778d),

new NpgsqlTypes.NpgsqlLine(a: 0.5796306726535371d, b: 0.3621536966457104d, c: 0.3554092618887771d),

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
                Assert.That(model.Id, Is.EqualTo(1049476690));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1703167002028123d, b: 0.06899134909065618d, c: 0.39632655876575884d),

new NpgsqlTypes.NpgsqlLine(a: 0.9436521110809849d, b: 0.2716102490692832d, c: 0.21807972083943694d),

new NpgsqlTypes.NpgsqlLine(a: 0.07510391898176405d, b: 0.4622700624960824d, c: 0.6916474126671974d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3434566231012316d, b: 0.6092872970160005d, c: 0.8285200623737458d),

new NpgsqlTypes.NpgsqlLine(a: 0.438620087459067d, b: 0.42784452615069857d, c: 0.43791996431227087d),

new NpgsqlTypes.NpgsqlLine(a: 0.13822472685663223d, b: 0.3567687904324768d, c: 0.5713362361619454d),

new NpgsqlTypes.NpgsqlLine(a: 0.4225842002023096d, b: 0.13041963778907273d, c: 0.537431949671262d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(259689541));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16915141278580792d, b: 0.5107686791340034d, c: 0.6489920882506348d),

new NpgsqlTypes.NpgsqlLine(a: 0.030879513236027d, b: 0.6401283771223818d, c: 0.4904762444562075d),

new NpgsqlTypes.NpgsqlLine(a: 0.16124954101586042d, b: 0.7102870300472969d, c: 0.9978682907813775d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3413197342637151d, b: 0.3564754218301692d, c: 0.16698356005321802d),

new NpgsqlTypes.NpgsqlLine(a: 0.24996465538547474d, b: 0.6936235099874405d, c: 0.00768766971096424d),

new NpgsqlTypes.NpgsqlLine(a: 0.9713834412198872d, b: 0.1937685310996965d, c: 0.5638524218711839d),

new NpgsqlTypes.NpgsqlLine(a: 0.20790035052620326d, b: 0.7280555648340241d, c: 0.7150389111804211d),

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
                Assert.That(model.Id, Is.EqualTo(1169283916));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6136867588329713d, b: 0.8476721243007673d, c: 0.2920466838690219d),

new NpgsqlTypes.NpgsqlLine(a: 0.5632572533709046d, b: 0.8580393386665631d, c: 0.29067186403759726d),

new NpgsqlTypes.NpgsqlLine(a: 0.05864985939465561d, b: 0.06933376015004311d, c: 0.2622230618531959d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3083889075922114d, b: 0.40504233141015844d, c: 0.7282625593772889d),

new NpgsqlTypes.NpgsqlLine(a: 0.9760389595620657d, b: 0.5432046524856411d, c: 0.4805721407516501d),

new NpgsqlTypes.NpgsqlLine(a: 0.226094370846618d, b: 0.30929816503923757d, c: 0.749788108094253d),

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
                Assert.That(model.Id, Is.EqualTo(1247961184));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588334999708729d, b: 0.5781258655739143d, c: 0.4951203893647069d),

new NpgsqlTypes.NpgsqlLine(a: 0.206651781249944d, b: 0.9214488824097644d, c: 0.7102197735978709d),

new NpgsqlTypes.NpgsqlLine(a: 0.8293873017859008d, b: 0.4197388618664637d, c: 0.7538628331143343d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9886122302398814d, b: 0.09733443476141157d, c: 0.8828756753279827d),

new NpgsqlTypes.NpgsqlLine(a: 0.4191781730328399d, b: 0.8360940579259326d, c: 0.3115604346093266d),

new NpgsqlTypes.NpgsqlLine(a: 0.03123256692948395d, b: 0.4210178852779579d, c: 0.7083559364281564d),

new NpgsqlTypes.NpgsqlLine(a: 0.10193811062121638d, b: 0.7865607707379441d, c: 0.5102014504618864d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(313349652));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7148027863911385d, b: 0.4116315290140842d, c: 0.9883513693293022d),

new NpgsqlTypes.NpgsqlLine(a: 0.730798769811796d, b: 0.5625059295801093d, c: 0.028144945623879147d),

new NpgsqlTypes.NpgsqlLine(a: 0.7895921923207063d, b: 0.897092096080744d, c: 0.36804397804374556d),

new NpgsqlTypes.NpgsqlLine(a: 0.4403951364132078d, b: 0.48316034726668566d, c: 0.5561087583026281d),

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
                Assert.That(model.Id, Is.EqualTo(1251267268));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.27064576558959075d, b: 0.24611103650290955d, c: 0.04928435530376152d),

new NpgsqlTypes.NpgsqlLine(a: 0.5382620257248645d, b: 0.586731968734226d, c: 0.9110741668368397d),

new NpgsqlTypes.NpgsqlLine(a: 0.8386954216871374d, b: 0.14045527908308764d, c: 0.5300328684198944d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7572326327773035d, b: 0.10039993499818312d, c: 0.17339739029118428d),

new NpgsqlTypes.NpgsqlLine(a: 0.9566618331567527d, b: 0.14668861402647748d, c: 0.7767711369985796d),

new NpgsqlTypes.NpgsqlLine(a: 0.932727244163919d, b: 0.12159065636952726d, c: 0.1704609096711438d),

new NpgsqlTypes.NpgsqlLine(a: 0.5792460825794749d, b: 0.985437582839235d, c: 0.557473090399633d),

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
                Assert.That(model.Id, Is.EqualTo(1276251566));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4808529939808879d, b: 0.365247596328651d, c: 0.17939866902766977d),

new NpgsqlTypes.NpgsqlLine(a: 0.12809708913748585d, b: 0.18821025600986407d, c: 0.9740037535570704d),

new NpgsqlTypes.NpgsqlLine(a: 0.7729579560840041d, b: 0.5283959837814016d, c: 0.3246873097765165d),

new NpgsqlTypes.NpgsqlLine(a: 0.5804554841359071d, b: 0.7951318743812129d, c: 0.9533437460862759d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07357632206959641d, b: 0.11099061080365447d, c: 0.47576723756466854d),

new NpgsqlTypes.NpgsqlLine(a: 0.9051522311200175d, b: 0.6041352781626989d, c: 0.962846313750425d),

new NpgsqlTypes.NpgsqlLine(a: 0.7230697163609032d, b: 0.35996997662147945d, c: 0.2719627850842049d),

new NpgsqlTypes.NpgsqlLine(a: 0.039972657007877d, b: 0.6660692046588974d, c: 0.8074219604808613d),

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
                Assert.That(model.Id, Is.EqualTo(1278639929));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8637991908928382d, b: 0.7989476928355281d, c: 0.047074497669961635d),

new NpgsqlTypes.NpgsqlLine(a: 0.24284327761860214d, b: 0.034845279321367495d, c: 0.8243144068858446d),

new NpgsqlTypes.NpgsqlLine(a: 0.2705173386529084d, b: 0.37759514414776285d, c: 0.003784057263189533d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5464646368268954d, b: 0.1698011067851829d, c: 0.4811896051504386d),

new NpgsqlTypes.NpgsqlLine(a: 0.3264558304845737d, b: 0.09741548986796533d, c: 0.35078408755418944d),

new NpgsqlTypes.NpgsqlLine(a: 0.1253849539183054d, b: 0.9184504405667023d, c: 0.6244095303662431d),

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
                Assert.That(model.Id, Is.EqualTo(1352296160));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6961581521563707d, b: 0.2870425810465653d, c: 0.022813771410836625d),

new NpgsqlTypes.NpgsqlLine(a: 0.9289180434806266d, b: 0.10310192777053839d, c: 0.4974840036652155d),

new NpgsqlTypes.NpgsqlLine(a: 0.9742618124298718d, b: 0.666155889593685d, c: 0.9108800941033853d),

new NpgsqlTypes.NpgsqlLine(a: 0.4076993728994177d, b: 0.9237619110159688d, c: 0.16349574316883708d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.40245830157937157d, b: 0.4425237993192568d, c: 0.3605907953188545d),

new NpgsqlTypes.NpgsqlLine(a: 0.3025387755185438d, b: 0.16175616826033246d, c: 0.08369914886846197d),

new NpgsqlTypes.NpgsqlLine(a: 0.7932786053551402d, b: 0.4757892941852452d, c: 0.35215963103511483d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2052209240));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28682097488067404d, b: 0.19347953745544d, c: 0.767001580247448d),

new NpgsqlTypes.NpgsqlLine(a: 0.34168929191792363d, b: 0.5324263819109204d, c: 0.3548736591683712d),

new NpgsqlTypes.NpgsqlLine(a: 0.7601584215479089d, b: 0.9667193856859281d, c: 0.48805620341333844d),

new NpgsqlTypes.NpgsqlLine(a: 0.4778030273140724d, b: 0.6459214140044727d, c: 0.9825570138966864d),

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
                Assert.That(model.Id, Is.EqualTo(1422030401));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5508950376990435d, b: 0.1842011543506923d, c: 0.7200839172656331d),

new NpgsqlTypes.NpgsqlLine(a: 0.08098131741133519d, b: 0.2512744482896645d, c: 0.4419893154281408d),

new NpgsqlTypes.NpgsqlLine(a: 0.7183180834237055d, b: 0.3821225061156569d, c: 0.320010478004808d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.605461690855222d, b: 0.5098249599693536d, c: 0.049446338505273246d),

new NpgsqlTypes.NpgsqlLine(a: 0.6383133050473475d, b: 0.5385834180776717d, c: 0.2612256906158803d),

new NpgsqlTypes.NpgsqlLine(a: 0.2259744218921168d, b: 0.0504022254415285d, c: 0.5085817881315488d),

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

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1441068318));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04431673188157559d, b: 0.7118895502319815d, c: 0.8045459394080527d),

new NpgsqlTypes.NpgsqlLine(a: 0.41883883343441664d, b: 0.0856133325697227d, c: 0.45940150990219364d),

new NpgsqlTypes.NpgsqlLine(a: 0.3845455332415372d, b: 0.5278908004707358d, c: 0.45211852173959755d),

new NpgsqlTypes.NpgsqlLine(a: 0.707344526938849d, b: 0.2664835051263448d, c: 0.8012907013628192d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5167014945187821d, b: 0.2318523474732329d, c: 0.0766480392056259d),

new NpgsqlTypes.NpgsqlLine(a: 0.6239339834043951d, b: 0.4407650281616141d, c: 0.07711199216030074d),

new NpgsqlTypes.NpgsqlLine(a: 0.7330247230488705d, b: 0.06195929907587139d, c: 0.1736910797965654d),

new NpgsqlTypes.NpgsqlLine(a: 0.5060985759956755d, b: 0.12918142066992122d, c: 0.3598502037154421d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1349638635));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8811777097968191d, b: 0.09805743628781294d, c: 0.8476023389336619d),

new NpgsqlTypes.NpgsqlLine(a: 0.16329696312104391d, b: 0.8434248077846473d, c: 0.0171626874853823d),

new NpgsqlTypes.NpgsqlLine(a: 0.5930114320798587d, b: 0.7874763150232159d, c: 0.20169365861720767d),

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
                Assert.That(model.Id, Is.EqualTo(1485177216));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7620135774845544d, b: 0.72234986247445d, c: 0.7900958363555012d),

new NpgsqlTypes.NpgsqlLine(a: 0.5982892074823093d, b: 0.9157569165822279d, c: 0.5913666560112503d),

new NpgsqlTypes.NpgsqlLine(a: 0.3694255096703286d, b: 0.43689654039349735d, c: 0.27488642071951885d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1888587968));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9441675468790086d, b: 0.10273087249159918d, c: 0.36496868371913627d),

new NpgsqlTypes.NpgsqlLine(a: 0.3153900895384264d, b: 0.8953921593705707d, c: 0.6821583482258307d),

new NpgsqlTypes.NpgsqlLine(a: 0.15884512105184567d, b: 0.20745599422324912d, c: 0.5928677501305737d),

new NpgsqlTypes.NpgsqlLine(a: 0.19203772899196803d, b: 0.9281999546867626d, c: 0.9792553764463741d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.616453689236877d, b: 0.26880075600348696d, c: 0.9911672578342802d),

new NpgsqlTypes.NpgsqlLine(a: 0.41598816366831615d, b: 0.2972198032481773d, c: 0.6096249065094251d),

new NpgsqlTypes.NpgsqlLine(a: 0.21461782395965212d, b: 0.4996081675192614d, c: 0.845029551763019d),

new NpgsqlTypes.NpgsqlLine(a: 0.14603833144353173d, b: 0.5155958582129082d, c: 0.9513100476397736d),

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
                Assert.That(model.Id, Is.EqualTo(1612037280));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9755688560619167d, b: 0.7517347444178538d, c: 0.4433097656621017d),

new NpgsqlTypes.NpgsqlLine(a: 0.27642151559126893d, b: 0.49560032188535075d, c: 0.4017019854911661d),

new NpgsqlTypes.NpgsqlLine(a: 0.48234378585453686d, b: 0.5838608048706788d, c: 0.45264440736135125d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1803941428));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4958174274877982d, b: 0.19935005698584918d, c: 0.6570481803156852d),

new NpgsqlTypes.NpgsqlLine(a: 0.586031122116916d, b: 0.20438200508300097d, c: 0.7214279726394314d),

new NpgsqlTypes.NpgsqlLine(a: 0.3287771922455527d, b: 0.31464931534195395d, c: 0.49275260904707807d),

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
                Assert.That(model.Id, Is.EqualTo(1694903385));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5133551130062282d, b: 0.5981369379522861d, c: 0.5856516805262975d),

new NpgsqlTypes.NpgsqlLine(a: 0.4556255479239121d, b: 0.059243842569019045d, c: 0.18272228811839042d),

new NpgsqlTypes.NpgsqlLine(a: 0.8085308768004308d, b: 0.8348590541320315d, c: 0.5895099353964641d),

new NpgsqlTypes.NpgsqlLine(a: 0.24149968696186774d, b: 0.35557480082622506d, c: 0.5451461752136405d),

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
                Assert.That(model.Id, Is.EqualTo(1708194464));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21378574042766885d, b: 0.22474127876321393d, c: 0.01286635194062602d),

new NpgsqlTypes.NpgsqlLine(a: 0.44720527497131246d, b: 0.83386820783986d, c: 0.47600740851603984d),

new NpgsqlTypes.NpgsqlLine(a: 0.9177345103701179d, b: 0.8135674766115204d, c: 0.23923291716083794d),

new NpgsqlTypes.NpgsqlLine(a: 0.9998743487003019d, b: 0.013427841900149451d, c: 0.9133209978570025d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(871029693));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09314286666835214d, b: 0.9419395542104619d, c: 0.23265001920909978d),

new NpgsqlTypes.NpgsqlLine(a: 0.7840922282915723d, b: 0.8769622177219351d, c: 0.08844919095146764d),

new NpgsqlTypes.NpgsqlLine(a: 0.30172065868559383d, b: 0.061796126836928256d, c: 0.7819510380905712d),

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
                Assert.That(model.Id, Is.EqualTo(1749272119));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48465570613062037d, b: 0.4077570571696034d, c: 0.09124205112015671d),

new NpgsqlTypes.NpgsqlLine(a: 0.4905692123673753d, b: 0.09753381316271936d, c: 0.6219861110019185d),

new NpgsqlTypes.NpgsqlLine(a: 0.7715584772299492d, b: 0.7647042738214676d, c: 0.32981711302760286d),

new NpgsqlTypes.NpgsqlLine(a: 0.7826950107361046d, b: 0.6159017458991703d, c: 0.8761288210787351d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05854830086605134d, b: 0.4584727830793912d, c: 0.6485776355671607d),

new NpgsqlTypes.NpgsqlLine(a: 0.057402368952540694d, b: 0.814338567877536d, c: 0.36045674525095406d),

new NpgsqlTypes.NpgsqlLine(a: 0.4609921668504162d, b: 0.45446719793916357d, c: 0.6647833262693906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8421363107491464d, b: 0.8724917366553757d, c: 0.2954174236384989d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743101311));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30049737151744216d, b: 0.10935998965187232d, c: 0.12002566064851483d),

new NpgsqlTypes.NpgsqlLine(a: 0.4579983959880112d, b: 0.8700234892072651d, c: 0.24545341370685325d),

new NpgsqlTypes.NpgsqlLine(a: 0.6992061752442d, b: 0.8760611086508132d, c: 0.31896424715232463d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14975557199832845d, b: 0.8649037801511367d, c: 0.8035067258718913d),

new NpgsqlTypes.NpgsqlLine(a: 0.022767088770272226d, b: 0.824519829812387d, c: 0.2990170967826957d),

new NpgsqlTypes.NpgsqlLine(a: 0.264229467978496d, b: 0.4707396384081288d, c: 0.5870444614457326d),

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
                Assert.That(model.Id, Is.EqualTo(1750072079));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6509605768915644d, b: 0.2871280523199907d, c: 0.5279864073907687d),

new NpgsqlTypes.NpgsqlLine(a: 0.847627780191932d, b: 0.2863239370866939d, c: 0.39664595009550063d),

new NpgsqlTypes.NpgsqlLine(a: 0.06719070091173818d, b: 0.2998868113793318d, c: 0.8109899934095542d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30402634597868494d, b: 0.7741177113732105d, c: 0.4982697795456863d),

new NpgsqlTypes.NpgsqlLine(a: 0.22134239051678783d, b: 0.952989590947333d, c: 0.1976805178607327d),

new NpgsqlTypes.NpgsqlLine(a: 0.48019693876130953d, b: 0.8553553442730837d, c: 0.4578014530562905d),

new NpgsqlTypes.NpgsqlLine(a: 0.7948720279836796d, b: 0.6347165612507009d, c: 0.4915047790558922d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(681877477));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.054876749435908034d, b: 0.7476698065656858d, c: 0.5221215501493097d),

new NpgsqlTypes.NpgsqlLine(a: 0.1689911006864584d, b: 0.16032672190790076d, c: 0.9537953031702238d),

new NpgsqlTypes.NpgsqlLine(a: 0.3133690487713232d, b: 0.21425817972116357d, c: 0.39002508371565625d),

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
                Assert.That(model.Id, Is.EqualTo(1765269457));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4428210775962541d, b: 0.44628545865868685d, c: 0.7913435097925557d),

new NpgsqlTypes.NpgsqlLine(a: 0.26419018627718516d, b: 0.12166427922453704d, c: 0.11250832552770584d),

new NpgsqlTypes.NpgsqlLine(a: 0.20276585628171784d, b: 0.14489314174625478d, c: 0.5410582863519566d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(699428708));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.75437435623167d, b: 0.4381969103973332d, c: 0.13859938549471296d),

new NpgsqlTypes.NpgsqlLine(a: 0.22478326045746155d, b: 0.7927996319630696d, c: 0.5653146543488808d),

new NpgsqlTypes.NpgsqlLine(a: 0.8148660813324691d, b: 0.5965502974097225d, c: 0.08598406767552191d),

new NpgsqlTypes.NpgsqlLine(a: 0.10261855436837408d, b: 0.22753843400620033d, c: 0.6663050101504865d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19047502268477823d, b: 0.503647750986701d, c: 0.5140837344549085d),

new NpgsqlTypes.NpgsqlLine(a: 0.5498279015442291d, b: 0.5205498180433044d, c: 0.5511400439881968d),

new NpgsqlTypes.NpgsqlLine(a: 0.07519565206915457d, b: 0.8190939422278946d, c: 0.4842243543091963d),

new NpgsqlTypes.NpgsqlLine(a: 0.11151345358207676d, b: 0.2794260095615846d, c: 0.1977999861392018d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(20));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(929385902));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8285395037487209d, b: 0.25070273066629d, c: 0.2500673109161923d),

new NpgsqlTypes.NpgsqlLine(a: 0.9942717530143405d, b: 0.21539215026712022d, c: 0.20269945939501077d),

new NpgsqlTypes.NpgsqlLine(a: 0.7979702358088475d, b: 0.0037115614378556705d, c: 0.8843432168677479d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1456202870910711d, b: 0.06772665910903597d, c: 0.691750610472359d),

new NpgsqlTypes.NpgsqlLine(a: 0.765757989281042d, b: 0.32982835634782004d, c: 0.8913701807765988d),

new NpgsqlTypes.NpgsqlLine(a: 0.052240732409688406d, b: 0.618262798295761d, c: 0.8474290495942781d),

new NpgsqlTypes.NpgsqlLine(a: 0.3584922315949717d, b: 0.520574773115294d, c: 0.8310230234204736d),

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
                Assert.That(model.Id, Is.EqualTo(939691488));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15928813769803307d, b: 0.5335096410959914d, c: 0.9693141891385088d),

new NpgsqlTypes.NpgsqlLine(a: 0.9448241901930845d, b: 0.6287076527827521d, c: 0.6660617468801671d),

new NpgsqlTypes.NpgsqlLine(a: 0.30712778702622445d, b: 0.324942912367581d, c: 0.9500282198259326d),

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
                Assert.That(model.Id, Is.EqualTo(940484658));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8457530794410952d, b: 0.07468146527745967d, c: 0.6058450234777081d),

new NpgsqlTypes.NpgsqlLine(a: 0.43907623012482566d, b: 0.4163533057091461d, c: 0.7083053151407345d),

new NpgsqlTypes.NpgsqlLine(a: 0.6460729456777172d, b: 0.3996032448892458d, c: 0.32058136990645736d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5056133907420888d, b: 0.687789482585691d, c: 0.5736898296981361d),

new NpgsqlTypes.NpgsqlLine(a: 0.6165837793609097d, b: 0.3896094649555947d, c: 0.782529168193896d),

new NpgsqlTypes.NpgsqlLine(a: 0.19522061405511182d, b: 0.49515141325692447d, c: 0.8154303350690599d),

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
                Assert.That(model.Id, Is.EqualTo(956171576));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6305558129660189d, b: 0.5463622939629917d, c: 0.401891977997777d),

new NpgsqlTypes.NpgsqlLine(a: 0.3662230087345998d, b: 0.4302679455886196d, c: 0.9631184941583132d),

new NpgsqlTypes.NpgsqlLine(a: 0.3634906094993412d, b: 0.18046820180120404d, c: 0.5193725822662353d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48533853922222536d, b: 0.7781157007327932d, c: 0.20671476643143427d),

new NpgsqlTypes.NpgsqlLine(a: 0.7321919326621603d, b: 0.7704043405190548d, c: 0.5508846640658778d),

new NpgsqlTypes.NpgsqlLine(a: 0.5796306726535371d, b: 0.3621536966457104d, c: 0.3554092618887771d),

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

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1049476690));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1703167002028123d, b: 0.06899134909065618d, c: 0.39632655876575884d),

new NpgsqlTypes.NpgsqlLine(a: 0.9436521110809849d, b: 0.2716102490692832d, c: 0.21807972083943694d),

new NpgsqlTypes.NpgsqlLine(a: 0.07510391898176405d, b: 0.4622700624960824d, c: 0.6916474126671974d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3434566231012316d, b: 0.6092872970160005d, c: 0.8285200623737458d),

new NpgsqlTypes.NpgsqlLine(a: 0.438620087459067d, b: 0.42784452615069857d, c: 0.43791996431227087d),

new NpgsqlTypes.NpgsqlLine(a: 0.13822472685663223d, b: 0.3567687904324768d, c: 0.5713362361619454d),

new NpgsqlTypes.NpgsqlLine(a: 0.4225842002023096d, b: 0.13041963778907273d, c: 0.537431949671262d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(259689541));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16915141278580792d, b: 0.5107686791340034d, c: 0.6489920882506348d),

new NpgsqlTypes.NpgsqlLine(a: 0.030879513236027d, b: 0.6401283771223818d, c: 0.4904762444562075d),

new NpgsqlTypes.NpgsqlLine(a: 0.16124954101586042d, b: 0.7102870300472969d, c: 0.9978682907813775d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3413197342637151d, b: 0.3564754218301692d, c: 0.16698356005321802d),

new NpgsqlTypes.NpgsqlLine(a: 0.24996465538547474d, b: 0.6936235099874405d, c: 0.00768766971096424d),

new NpgsqlTypes.NpgsqlLine(a: 0.9713834412198872d, b: 0.1937685310996965d, c: 0.5638524218711839d),

new NpgsqlTypes.NpgsqlLine(a: 0.20790035052620326d, b: 0.7280555648340241d, c: 0.7150389111804211d),

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
                Assert.That(model.Id, Is.EqualTo(1169283916));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6136867588329713d, b: 0.8476721243007673d, c: 0.2920466838690219d),

new NpgsqlTypes.NpgsqlLine(a: 0.5632572533709046d, b: 0.8580393386665631d, c: 0.29067186403759726d),

new NpgsqlTypes.NpgsqlLine(a: 0.05864985939465561d, b: 0.06933376015004311d, c: 0.2622230618531959d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3083889075922114d, b: 0.40504233141015844d, c: 0.7282625593772889d),

new NpgsqlTypes.NpgsqlLine(a: 0.9760389595620657d, b: 0.5432046524856411d, c: 0.4805721407516501d),

new NpgsqlTypes.NpgsqlLine(a: 0.226094370846618d, b: 0.30929816503923757d, c: 0.749788108094253d),

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
                Assert.That(model.Id, Is.EqualTo(1247961184));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588334999708729d, b: 0.5781258655739143d, c: 0.4951203893647069d),

new NpgsqlTypes.NpgsqlLine(a: 0.206651781249944d, b: 0.9214488824097644d, c: 0.7102197735978709d),

new NpgsqlTypes.NpgsqlLine(a: 0.8293873017859008d, b: 0.4197388618664637d, c: 0.7538628331143343d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9886122302398814d, b: 0.09733443476141157d, c: 0.8828756753279827d),

new NpgsqlTypes.NpgsqlLine(a: 0.4191781730328399d, b: 0.8360940579259326d, c: 0.3115604346093266d),

new NpgsqlTypes.NpgsqlLine(a: 0.03123256692948395d, b: 0.4210178852779579d, c: 0.7083559364281564d),

new NpgsqlTypes.NpgsqlLine(a: 0.10193811062121638d, b: 0.7865607707379441d, c: 0.5102014504618864d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(313349652));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7148027863911385d, b: 0.4116315290140842d, c: 0.9883513693293022d),

new NpgsqlTypes.NpgsqlLine(a: 0.730798769811796d, b: 0.5625059295801093d, c: 0.028144945623879147d),

new NpgsqlTypes.NpgsqlLine(a: 0.7895921923207063d, b: 0.897092096080744d, c: 0.36804397804374556d),

new NpgsqlTypes.NpgsqlLine(a: 0.4403951364132078d, b: 0.48316034726668566d, c: 0.5561087583026281d),

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
                Assert.That(model.Id, Is.EqualTo(1251267268));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.27064576558959075d, b: 0.24611103650290955d, c: 0.04928435530376152d),

new NpgsqlTypes.NpgsqlLine(a: 0.5382620257248645d, b: 0.586731968734226d, c: 0.9110741668368397d),

new NpgsqlTypes.NpgsqlLine(a: 0.8386954216871374d, b: 0.14045527908308764d, c: 0.5300328684198944d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7572326327773035d, b: 0.10039993499818312d, c: 0.17339739029118428d),

new NpgsqlTypes.NpgsqlLine(a: 0.9566618331567527d, b: 0.14668861402647748d, c: 0.7767711369985796d),

new NpgsqlTypes.NpgsqlLine(a: 0.932727244163919d, b: 0.12159065636952726d, c: 0.1704609096711438d),

new NpgsqlTypes.NpgsqlLine(a: 0.5792460825794749d, b: 0.985437582839235d, c: 0.557473090399633d),

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
                Assert.That(model.Id, Is.EqualTo(1276251566));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4808529939808879d, b: 0.365247596328651d, c: 0.17939866902766977d),

new NpgsqlTypes.NpgsqlLine(a: 0.12809708913748585d, b: 0.18821025600986407d, c: 0.9740037535570704d),

new NpgsqlTypes.NpgsqlLine(a: 0.7729579560840041d, b: 0.5283959837814016d, c: 0.3246873097765165d),

new NpgsqlTypes.NpgsqlLine(a: 0.5804554841359071d, b: 0.7951318743812129d, c: 0.9533437460862759d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07357632206959641d, b: 0.11099061080365447d, c: 0.47576723756466854d),

new NpgsqlTypes.NpgsqlLine(a: 0.9051522311200175d, b: 0.6041352781626989d, c: 0.962846313750425d),

new NpgsqlTypes.NpgsqlLine(a: 0.7230697163609032d, b: 0.35996997662147945d, c: 0.2719627850842049d),

new NpgsqlTypes.NpgsqlLine(a: 0.039972657007877d, b: 0.6660692046588974d, c: 0.8074219604808613d),

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
                Assert.That(model.Id, Is.EqualTo(1278639929));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8637991908928382d, b: 0.7989476928355281d, c: 0.047074497669961635d),

new NpgsqlTypes.NpgsqlLine(a: 0.24284327761860214d, b: 0.034845279321367495d, c: 0.8243144068858446d),

new NpgsqlTypes.NpgsqlLine(a: 0.2705173386529084d, b: 0.37759514414776285d, c: 0.003784057263189533d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5464646368268954d, b: 0.1698011067851829d, c: 0.4811896051504386d),

new NpgsqlTypes.NpgsqlLine(a: 0.3264558304845737d, b: 0.09741548986796533d, c: 0.35078408755418944d),

new NpgsqlTypes.NpgsqlLine(a: 0.1253849539183054d, b: 0.9184504405667023d, c: 0.6244095303662431d),

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
                Assert.That(model.Id, Is.EqualTo(1352296160));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6961581521563707d, b: 0.2870425810465653d, c: 0.022813771410836625d),

new NpgsqlTypes.NpgsqlLine(a: 0.9289180434806266d, b: 0.10310192777053839d, c: 0.4974840036652155d),

new NpgsqlTypes.NpgsqlLine(a: 0.9742618124298718d, b: 0.666155889593685d, c: 0.9108800941033853d),

new NpgsqlTypes.NpgsqlLine(a: 0.4076993728994177d, b: 0.9237619110159688d, c: 0.16349574316883708d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.40245830157937157d, b: 0.4425237993192568d, c: 0.3605907953188545d),

new NpgsqlTypes.NpgsqlLine(a: 0.3025387755185438d, b: 0.16175616826033246d, c: 0.08369914886846197d),

new NpgsqlTypes.NpgsqlLine(a: 0.7932786053551402d, b: 0.4757892941852452d, c: 0.35215963103511483d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2052209240));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28682097488067404d, b: 0.19347953745544d, c: 0.767001580247448d),

new NpgsqlTypes.NpgsqlLine(a: 0.34168929191792363d, b: 0.5324263819109204d, c: 0.3548736591683712d),

new NpgsqlTypes.NpgsqlLine(a: 0.7601584215479089d, b: 0.9667193856859281d, c: 0.48805620341333844d),

new NpgsqlTypes.NpgsqlLine(a: 0.4778030273140724d, b: 0.6459214140044727d, c: 0.9825570138966864d),

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
                Assert.That(model.Id, Is.EqualTo(1422030401));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5508950376990435d, b: 0.1842011543506923d, c: 0.7200839172656331d),

new NpgsqlTypes.NpgsqlLine(a: 0.08098131741133519d, b: 0.2512744482896645d, c: 0.4419893154281408d),

new NpgsqlTypes.NpgsqlLine(a: 0.7183180834237055d, b: 0.3821225061156569d, c: 0.320010478004808d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.605461690855222d, b: 0.5098249599693536d, c: 0.049446338505273246d),

new NpgsqlTypes.NpgsqlLine(a: 0.6383133050473475d, b: 0.5385834180776717d, c: 0.2612256906158803d),

new NpgsqlTypes.NpgsqlLine(a: 0.2259744218921168d, b: 0.0504022254415285d, c: 0.5085817881315488d),

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
                Assert.That(model.Id, Is.EqualTo(1441068318));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04431673188157559d, b: 0.7118895502319815d, c: 0.8045459394080527d),

new NpgsqlTypes.NpgsqlLine(a: 0.41883883343441664d, b: 0.0856133325697227d, c: 0.45940150990219364d),

new NpgsqlTypes.NpgsqlLine(a: 0.3845455332415372d, b: 0.5278908004707358d, c: 0.45211852173959755d),

new NpgsqlTypes.NpgsqlLine(a: 0.707344526938849d, b: 0.2664835051263448d, c: 0.8012907013628192d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5167014945187821d, b: 0.2318523474732329d, c: 0.0766480392056259d),

new NpgsqlTypes.NpgsqlLine(a: 0.6239339834043951d, b: 0.4407650281616141d, c: 0.07711199216030074d),

new NpgsqlTypes.NpgsqlLine(a: 0.7330247230488705d, b: 0.06195929907587139d, c: 0.1736910797965654d),

new NpgsqlTypes.NpgsqlLine(a: 0.5060985759956755d, b: 0.12918142066992122d, c: 0.3598502037154421d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1349638635));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8811777097968191d, b: 0.09805743628781294d, c: 0.8476023389336619d),

new NpgsqlTypes.NpgsqlLine(a: 0.16329696312104391d, b: 0.8434248077846473d, c: 0.0171626874853823d),

new NpgsqlTypes.NpgsqlLine(a: 0.5930114320798587d, b: 0.7874763150232159d, c: 0.20169365861720767d),

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
                Assert.That(model.Id, Is.EqualTo(1485177216));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7620135774845544d, b: 0.72234986247445d, c: 0.7900958363555012d),

new NpgsqlTypes.NpgsqlLine(a: 0.5982892074823093d, b: 0.9157569165822279d, c: 0.5913666560112503d),

new NpgsqlTypes.NpgsqlLine(a: 0.3694255096703286d, b: 0.43689654039349735d, c: 0.27488642071951885d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1888587968));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9441675468790086d, b: 0.10273087249159918d, c: 0.36496868371913627d),

new NpgsqlTypes.NpgsqlLine(a: 0.3153900895384264d, b: 0.8953921593705707d, c: 0.6821583482258307d),

new NpgsqlTypes.NpgsqlLine(a: 0.15884512105184567d, b: 0.20745599422324912d, c: 0.5928677501305737d),

new NpgsqlTypes.NpgsqlLine(a: 0.19203772899196803d, b: 0.9281999546867626d, c: 0.9792553764463741d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.616453689236877d, b: 0.26880075600348696d, c: 0.9911672578342802d),

new NpgsqlTypes.NpgsqlLine(a: 0.41598816366831615d, b: 0.2972198032481773d, c: 0.6096249065094251d),

new NpgsqlTypes.NpgsqlLine(a: 0.21461782395965212d, b: 0.4996081675192614d, c: 0.845029551763019d),

new NpgsqlTypes.NpgsqlLine(a: 0.14603833144353173d, b: 0.5155958582129082d, c: 0.9513100476397736d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1612037280));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9755688560619167d, b: 0.7517347444178538d, c: 0.4433097656621017d),

new NpgsqlTypes.NpgsqlLine(a: 0.27642151559126893d, b: 0.49560032188535075d, c: 0.4017019854911661d),

new NpgsqlTypes.NpgsqlLine(a: 0.48234378585453686d, b: 0.5838608048706788d, c: 0.45264440736135125d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1803941428));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4958174274877982d, b: 0.19935005698584918d, c: 0.6570481803156852d),

new NpgsqlTypes.NpgsqlLine(a: 0.586031122116916d, b: 0.20438200508300097d, c: 0.7214279726394314d),

new NpgsqlTypes.NpgsqlLine(a: 0.3287771922455527d, b: 0.31464931534195395d, c: 0.49275260904707807d),

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
                Assert.That(model.Id, Is.EqualTo(1694903385));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5133551130062282d, b: 0.5981369379522861d, c: 0.5856516805262975d),

new NpgsqlTypes.NpgsqlLine(a: 0.4556255479239121d, b: 0.059243842569019045d, c: 0.18272228811839042d),

new NpgsqlTypes.NpgsqlLine(a: 0.8085308768004308d, b: 0.8348590541320315d, c: 0.5895099353964641d),

new NpgsqlTypes.NpgsqlLine(a: 0.24149968696186774d, b: 0.35557480082622506d, c: 0.5451461752136405d),

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
                Assert.That(model.Id, Is.EqualTo(1708194464));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21378574042766885d, b: 0.22474127876321393d, c: 0.01286635194062602d),

new NpgsqlTypes.NpgsqlLine(a: 0.44720527497131246d, b: 0.83386820783986d, c: 0.47600740851603984d),

new NpgsqlTypes.NpgsqlLine(a: 0.9177345103701179d, b: 0.8135674766115204d, c: 0.23923291716083794d),

new NpgsqlTypes.NpgsqlLine(a: 0.9998743487003019d, b: 0.013427841900149451d, c: 0.9133209978570025d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(871029693));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09314286666835214d, b: 0.9419395542104619d, c: 0.23265001920909978d),

new NpgsqlTypes.NpgsqlLine(a: 0.7840922282915723d, b: 0.8769622177219351d, c: 0.08844919095146764d),

new NpgsqlTypes.NpgsqlLine(a: 0.30172065868559383d, b: 0.061796126836928256d, c: 0.7819510380905712d),

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
                Assert.That(model.Id, Is.EqualTo(1749272119));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48465570613062037d, b: 0.4077570571696034d, c: 0.09124205112015671d),

new NpgsqlTypes.NpgsqlLine(a: 0.4905692123673753d, b: 0.09753381316271936d, c: 0.6219861110019185d),

new NpgsqlTypes.NpgsqlLine(a: 0.7715584772299492d, b: 0.7647042738214676d, c: 0.32981711302760286d),

new NpgsqlTypes.NpgsqlLine(a: 0.7826950107361046d, b: 0.6159017458991703d, c: 0.8761288210787351d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05854830086605134d, b: 0.4584727830793912d, c: 0.6485776355671607d),

new NpgsqlTypes.NpgsqlLine(a: 0.057402368952540694d, b: 0.814338567877536d, c: 0.36045674525095406d),

new NpgsqlTypes.NpgsqlLine(a: 0.4609921668504162d, b: 0.45446719793916357d, c: 0.6647833262693906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8421363107491464d, b: 0.8724917366553757d, c: 0.2954174236384989d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743101311));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30049737151744216d, b: 0.10935998965187232d, c: 0.12002566064851483d),

new NpgsqlTypes.NpgsqlLine(a: 0.4579983959880112d, b: 0.8700234892072651d, c: 0.24545341370685325d),

new NpgsqlTypes.NpgsqlLine(a: 0.6992061752442d, b: 0.8760611086508132d, c: 0.31896424715232463d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14975557199832845d, b: 0.8649037801511367d, c: 0.8035067258718913d),

new NpgsqlTypes.NpgsqlLine(a: 0.022767088770272226d, b: 0.824519829812387d, c: 0.2990170967826957d),

new NpgsqlTypes.NpgsqlLine(a: 0.264229467978496d, b: 0.4707396384081288d, c: 0.5870444614457326d),

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
                Assert.That(model.Id, Is.EqualTo(1750072079));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6509605768915644d, b: 0.2871280523199907d, c: 0.5279864073907687d),

new NpgsqlTypes.NpgsqlLine(a: 0.847627780191932d, b: 0.2863239370866939d, c: 0.39664595009550063d),

new NpgsqlTypes.NpgsqlLine(a: 0.06719070091173818d, b: 0.2998868113793318d, c: 0.8109899934095542d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30402634597868494d, b: 0.7741177113732105d, c: 0.4982697795456863d),

new NpgsqlTypes.NpgsqlLine(a: 0.22134239051678783d, b: 0.952989590947333d, c: 0.1976805178607327d),

new NpgsqlTypes.NpgsqlLine(a: 0.48019693876130953d, b: 0.8553553442730837d, c: 0.4578014530562905d),

new NpgsqlTypes.NpgsqlLine(a: 0.7948720279836796d, b: 0.6347165612507009d, c: 0.4915047790558922d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(681877477));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.054876749435908034d, b: 0.7476698065656858d, c: 0.5221215501493097d),

new NpgsqlTypes.NpgsqlLine(a: 0.1689911006864584d, b: 0.16032672190790076d, c: 0.9537953031702238d),

new NpgsqlTypes.NpgsqlLine(a: 0.3133690487713232d, b: 0.21425817972116357d, c: 0.39002508371565625d),

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
                Assert.That(model.Id, Is.EqualTo(1765269457));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4428210775962541d, b: 0.44628545865868685d, c: 0.7913435097925557d),

new NpgsqlTypes.NpgsqlLine(a: 0.26419018627718516d, b: 0.12166427922453704d, c: 0.11250832552770584d),

new NpgsqlTypes.NpgsqlLine(a: 0.20276585628171784d, b: 0.14489314174625478d, c: 0.5410582863519566d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(699428708));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.75437435623167d, b: 0.4381969103973332d, c: 0.13859938549471296d),

new NpgsqlTypes.NpgsqlLine(a: 0.22478326045746155d, b: 0.7927996319630696d, c: 0.5653146543488808d),

new NpgsqlTypes.NpgsqlLine(a: 0.8148660813324691d, b: 0.5965502974097225d, c: 0.08598406767552191d),

new NpgsqlTypes.NpgsqlLine(a: 0.10261855436837408d, b: 0.22753843400620033d, c: 0.6663050101504865d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19047502268477823d, b: 0.503647750986701d, c: 0.5140837344549085d),

new NpgsqlTypes.NpgsqlLine(a: 0.5498279015442291d, b: 0.5205498180433044d, c: 0.5511400439881968d),

new NpgsqlTypes.NpgsqlLine(a: 0.07519565206915457d, b: 0.8190939422278946d, c: 0.4842243543091963d),

new NpgsqlTypes.NpgsqlLine(a: 0.11151345358207676d, b: 0.2794260095615846d, c: 0.1977999861392018d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

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
                await foreach(var batchResult in ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelBatchAsync(connection, 214898413, 385864550))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(27));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(232426060));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7754569347332767d, b: 0.7449423603392903d, c: 0.7275357910733291d),

new NpgsqlTypes.NpgsqlLine(a: 0.9072872865290874d, b: 0.5188651109794405d, c: 0.49767196437474315d),

new NpgsqlTypes.NpgsqlLine(a: 0.7613773478086597d, b: 0.8726134777514618d, c: 0.7249287737318102d),

new NpgsqlTypes.NpgsqlLine(a: 0.31979325488547383d, b: 0.21963013317369884d, c: 0.995747479981123d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5136334997132156d, b: 0.4481836733144653d, c: 0.5566013930940901d),

new NpgsqlTypes.NpgsqlLine(a: 0.2628604279970359d, b: 0.34706683348460354d, c: 0.8618758810041756d),

new NpgsqlTypes.NpgsqlLine(a: 0.9066993846202163d, b: 0.9919335952888788d, c: 0.16647553451680086d),

new NpgsqlTypes.NpgsqlLine(a: 0.8084713734948656d, b: 0.9105928653749232d, c: 0.5871692331069964d),

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
                Assert.That(model.Id, Is.EqualTo(287773256));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5468129373528992d, b: 0.4550697398151482d, c: 0.9323204190693627d),

new NpgsqlTypes.NpgsqlLine(a: 0.09290076953581794d, b: 0.06513797114322906d, c: 0.01453530584939322d),

new NpgsqlTypes.NpgsqlLine(a: 0.06819515445977387d, b: 0.13776512554356624d, c: 0.5971045649241554d),

new NpgsqlTypes.NpgsqlLine(a: 0.17602847632288898d, b: 0.8583377493377162d, c: 0.5319193518068348d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2000087272));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5174417835536576d, b: 0.9550151039410834d, c: 0.94465021980697d),

new NpgsqlTypes.NpgsqlLine(a: 0.023498567205728516d, b: 0.14704570142511664d, c: 0.5436176118381062d),

new NpgsqlTypes.NpgsqlLine(a: 0.6410825125912296d, b: 0.1638519482392854d, c: 0.07442290044208977d),

new NpgsqlTypes.NpgsqlLine(a: 0.5684954410076702d, b: 0.9517870324925599d, c: 0.7913121037671743d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5546781844769255d, b: 0.3295435210405563d, c: 0.10332785525555d),

new NpgsqlTypes.NpgsqlLine(a: 0.8619184029547027d, b: 0.6893143841340763d, c: 0.6057919377815917d),

new NpgsqlTypes.NpgsqlLine(a: 0.6918049340506819d, b: 0.29564467871458977d, c: 0.373851052320022d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590711543927416d, b: 0.782456230485786d, c: 0.0557514543823312d),

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
                Assert.That(model.Id, Is.EqualTo(385864550));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22975102280111437d, b: 0.9248487581270293d, c: 0.13680981887715193d),

new NpgsqlTypes.NpgsqlLine(a: 0.09251582159332017d, b: 0.5284902712490177d, c: 0.5030244379828798d),

new NpgsqlTypes.NpgsqlLine(a: 0.3316636973424488d, b: 0.125908586516723d, c: 0.1307901665228316d),

new NpgsqlTypes.NpgsqlLine(a: 0.4488357278586823d, b: 0.4939460007710509d, c: 0.1486125807477222d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4793632894446783d, b: 0.7460924351194599d, c: 0.8333281971866928d),

new NpgsqlTypes.NpgsqlLine(a: 0.9911204719862435d, b: 0.02386428262012663d, c: 0.1749191984110413d),

new NpgsqlTypes.NpgsqlLine(a: 0.9855596015822274d, b: 0.652336551342683d, c: 0.13320036109805444d),

new NpgsqlTypes.NpgsqlLine(a: 0.2704642620419001d, b: 0.25815455585325764d, c: 0.781691467105331d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(507016837));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6329641939546133d, b: 0.7713358064075255d, c: 0.7091675230581173d),

new NpgsqlTypes.NpgsqlLine(a: 0.6401104534145889d, b: 0.4461488045009705d, c: 0.8050604324576476d),

new NpgsqlTypes.NpgsqlLine(a: 0.718200194405203d, b: 0.43497844061299695d, c: 0.8863292600245054d),

new NpgsqlTypes.NpgsqlLine(a: 0.6409377372303063d, b: 0.6727026439221405d, c: 0.709162570856183d),

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
                Assert.That(model.Id, Is.EqualTo(425879955));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7120720914880876d, b: 0.12018496532744738d, c: 0.23458035596972604d),

new NpgsqlTypes.NpgsqlLine(a: 0.8966943482850258d, b: 0.35901938172619774d, c: 0.5153333646331681d),

new NpgsqlTypes.NpgsqlLine(a: 0.772529205234202d, b: 0.3302141544038909d, c: 0.49860223574471696d),

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
                Assert.That(model.Id, Is.EqualTo(447065450));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6636554004535458d, b: 0.4052905058278198d, c: 0.17999403534412883d),

new NpgsqlTypes.NpgsqlLine(a: 0.4929643299593621d, b: 0.04102771738828992d, c: 0.8758588440576921d),

new NpgsqlTypes.NpgsqlLine(a: 0.9843591359807438d, b: 0.9486545770421181d, c: 0.23810538982780194d),

new NpgsqlTypes.NpgsqlLine(a: 0.0373504814930844d, b: 0.29650224807426506d, c: 0.6527517869517908d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1935239880));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5125009420178407d, b: 0.13553866813087467d, c: 0.6573124881706722d),

new NpgsqlTypes.NpgsqlLine(a: 0.9315668534985179d, b: 0.031339976871202935d, c: 0.7319776155987312d),

new NpgsqlTypes.NpgsqlLine(a: 0.5913519522327184d, b: 0.688194613219936d, c: 0.7487303543444555d),

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
                Assert.That(model.Id, Is.EqualTo(776647699));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8841755970938628d, b: 0.039993263617271846d, c: 0.2425222413816407d),

new NpgsqlTypes.NpgsqlLine(a: 0.3162669055857611d, b: 0.1360654949714053d, c: 0.585066125260232d),

new NpgsqlTypes.NpgsqlLine(a: 0.23614085233198578d, b: 0.9624524908146396d, c: 0.8036122013629919d),

new NpgsqlTypes.NpgsqlLine(a: 0.9594786748108928d, b: 0.3334512033062713d, c: 0.8626799508985245d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7692177568154062d, b: 0.8045212370680859d, c: 0.347836807601842d),

new NpgsqlTypes.NpgsqlLine(a: 0.8596806867272218d, b: 0.42225206488490163d, c: 0.2626771759427945d),

new NpgsqlTypes.NpgsqlLine(a: 0.6334601490046422d, b: 0.5508277640730257d, c: 0.9702039181027914d),

new NpgsqlTypes.NpgsqlLine(a: 0.7862671596820799d, b: 0.6148121550149941d, c: 0.10467782441316142d),

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
                Assert.That(model.Id, Is.EqualTo(920410273));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7950181430955406d, b: 0.3848051391253504d, c: 0.1572657802170856d),

new NpgsqlTypes.NpgsqlLine(a: 0.6062151918599252d, b: 0.06062326101597226d, c: 0.14777044879318857d),

new NpgsqlTypes.NpgsqlLine(a: 0.7408182398935058d, b: 0.6661433504932776d, c: 0.15722709569280902d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2482561889064241d, b: 0.768360521777252d, c: 0.24033198573060877d),

new NpgsqlTypes.NpgsqlLine(a: 0.6078828832971318d, b: 0.25910942482320465d, c: 0.7624300130707319d),

new NpgsqlTypes.NpgsqlLine(a: 0.551230062109523d, b: 0.5951997473266207d, c: 0.05557568229198884d),

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
                Assert.That(model.Id, Is.EqualTo(929385902));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8285395037487209d, b: 0.25070273066629d, c: 0.2500673109161923d),

new NpgsqlTypes.NpgsqlLine(a: 0.9942717530143405d, b: 0.21539215026712022d, c: 0.20269945939501077d),

new NpgsqlTypes.NpgsqlLine(a: 0.7979702358088475d, b: 0.0037115614378556705d, c: 0.8843432168677479d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1456202870910711d, b: 0.06772665910903597d, c: 0.691750610472359d),

new NpgsqlTypes.NpgsqlLine(a: 0.765757989281042d, b: 0.32982835634782004d, c: 0.8913701807765988d),

new NpgsqlTypes.NpgsqlLine(a: 0.052240732409688406d, b: 0.618262798295761d, c: 0.8474290495942781d),

new NpgsqlTypes.NpgsqlLine(a: 0.3584922315949717d, b: 0.520574773115294d, c: 0.8310230234204736d),

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
                Assert.That(model.Id, Is.EqualTo(939691488));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15928813769803307d, b: 0.5335096410959914d, c: 0.9693141891385088d),

new NpgsqlTypes.NpgsqlLine(a: 0.9448241901930845d, b: 0.6287076527827521d, c: 0.6660617468801671d),

new NpgsqlTypes.NpgsqlLine(a: 0.30712778702622445d, b: 0.324942912367581d, c: 0.9500282198259326d),

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

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(940484658));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8457530794410952d, b: 0.07468146527745967d, c: 0.6058450234777081d),

new NpgsqlTypes.NpgsqlLine(a: 0.43907623012482566d, b: 0.4163533057091461d, c: 0.7083053151407345d),

new NpgsqlTypes.NpgsqlLine(a: 0.6460729456777172d, b: 0.3996032448892458d, c: 0.32058136990645736d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5056133907420888d, b: 0.687789482585691d, c: 0.5736898296981361d),

new NpgsqlTypes.NpgsqlLine(a: 0.6165837793609097d, b: 0.3896094649555947d, c: 0.782529168193896d),

new NpgsqlTypes.NpgsqlLine(a: 0.19522061405511182d, b: 0.49515141325692447d, c: 0.8154303350690599d),

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
                Assert.That(model.Id, Is.EqualTo(956171576));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6305558129660189d, b: 0.5463622939629917d, c: 0.401891977997777d),

new NpgsqlTypes.NpgsqlLine(a: 0.3662230087345998d, b: 0.4302679455886196d, c: 0.9631184941583132d),

new NpgsqlTypes.NpgsqlLine(a: 0.3634906094993412d, b: 0.18046820180120404d, c: 0.5193725822662353d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48533853922222536d, b: 0.7781157007327932d, c: 0.20671476643143427d),

new NpgsqlTypes.NpgsqlLine(a: 0.7321919326621603d, b: 0.7704043405190548d, c: 0.5508846640658778d),

new NpgsqlTypes.NpgsqlLine(a: 0.5796306726535371d, b: 0.3621536966457104d, c: 0.3554092618887771d),

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
                Assert.That(model.Id, Is.EqualTo(1049476690));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1703167002028123d, b: 0.06899134909065618d, c: 0.39632655876575884d),

new NpgsqlTypes.NpgsqlLine(a: 0.9436521110809849d, b: 0.2716102490692832d, c: 0.21807972083943694d),

new NpgsqlTypes.NpgsqlLine(a: 0.07510391898176405d, b: 0.4622700624960824d, c: 0.6916474126671974d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3434566231012316d, b: 0.6092872970160005d, c: 0.8285200623737458d),

new NpgsqlTypes.NpgsqlLine(a: 0.438620087459067d, b: 0.42784452615069857d, c: 0.43791996431227087d),

new NpgsqlTypes.NpgsqlLine(a: 0.13822472685663223d, b: 0.3567687904324768d, c: 0.5713362361619454d),

new NpgsqlTypes.NpgsqlLine(a: 0.4225842002023096d, b: 0.13041963778907273d, c: 0.537431949671262d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(259689541));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16915141278580792d, b: 0.5107686791340034d, c: 0.6489920882506348d),

new NpgsqlTypes.NpgsqlLine(a: 0.030879513236027d, b: 0.6401283771223818d, c: 0.4904762444562075d),

new NpgsqlTypes.NpgsqlLine(a: 0.16124954101586042d, b: 0.7102870300472969d, c: 0.9978682907813775d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3413197342637151d, b: 0.3564754218301692d, c: 0.16698356005321802d),

new NpgsqlTypes.NpgsqlLine(a: 0.24996465538547474d, b: 0.6936235099874405d, c: 0.00768766971096424d),

new NpgsqlTypes.NpgsqlLine(a: 0.9713834412198872d, b: 0.1937685310996965d, c: 0.5638524218711839d),

new NpgsqlTypes.NpgsqlLine(a: 0.20790035052620326d, b: 0.7280555648340241d, c: 0.7150389111804211d),

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
                Assert.That(model.Id, Is.EqualTo(1169283916));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6136867588329713d, b: 0.8476721243007673d, c: 0.2920466838690219d),

new NpgsqlTypes.NpgsqlLine(a: 0.5632572533709046d, b: 0.8580393386665631d, c: 0.29067186403759726d),

new NpgsqlTypes.NpgsqlLine(a: 0.05864985939465561d, b: 0.06933376015004311d, c: 0.2622230618531959d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3083889075922114d, b: 0.40504233141015844d, c: 0.7282625593772889d),

new NpgsqlTypes.NpgsqlLine(a: 0.9760389595620657d, b: 0.5432046524856411d, c: 0.4805721407516501d),

new NpgsqlTypes.NpgsqlLine(a: 0.226094370846618d, b: 0.30929816503923757d, c: 0.749788108094253d),

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
                Assert.That(model.Id, Is.EqualTo(1247961184));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588334999708729d, b: 0.5781258655739143d, c: 0.4951203893647069d),

new NpgsqlTypes.NpgsqlLine(a: 0.206651781249944d, b: 0.9214488824097644d, c: 0.7102197735978709d),

new NpgsqlTypes.NpgsqlLine(a: 0.8293873017859008d, b: 0.4197388618664637d, c: 0.7538628331143343d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9886122302398814d, b: 0.09733443476141157d, c: 0.8828756753279827d),

new NpgsqlTypes.NpgsqlLine(a: 0.4191781730328399d, b: 0.8360940579259326d, c: 0.3115604346093266d),

new NpgsqlTypes.NpgsqlLine(a: 0.03123256692948395d, b: 0.4210178852779579d, c: 0.7083559364281564d),

new NpgsqlTypes.NpgsqlLine(a: 0.10193811062121638d, b: 0.7865607707379441d, c: 0.5102014504618864d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(313349652));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7148027863911385d, b: 0.4116315290140842d, c: 0.9883513693293022d),

new NpgsqlTypes.NpgsqlLine(a: 0.730798769811796d, b: 0.5625059295801093d, c: 0.028144945623879147d),

new NpgsqlTypes.NpgsqlLine(a: 0.7895921923207063d, b: 0.897092096080744d, c: 0.36804397804374556d),

new NpgsqlTypes.NpgsqlLine(a: 0.4403951364132078d, b: 0.48316034726668566d, c: 0.5561087583026281d),

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
                Assert.That(model.Id, Is.EqualTo(1251267268));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.27064576558959075d, b: 0.24611103650290955d, c: 0.04928435530376152d),

new NpgsqlTypes.NpgsqlLine(a: 0.5382620257248645d, b: 0.586731968734226d, c: 0.9110741668368397d),

new NpgsqlTypes.NpgsqlLine(a: 0.8386954216871374d, b: 0.14045527908308764d, c: 0.5300328684198944d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7572326327773035d, b: 0.10039993499818312d, c: 0.17339739029118428d),

new NpgsqlTypes.NpgsqlLine(a: 0.9566618331567527d, b: 0.14668861402647748d, c: 0.7767711369985796d),

new NpgsqlTypes.NpgsqlLine(a: 0.932727244163919d, b: 0.12159065636952726d, c: 0.1704609096711438d),

new NpgsqlTypes.NpgsqlLine(a: 0.5792460825794749d, b: 0.985437582839235d, c: 0.557473090399633d),

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

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276251566));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4808529939808879d, b: 0.365247596328651d, c: 0.17939866902766977d),

new NpgsqlTypes.NpgsqlLine(a: 0.12809708913748585d, b: 0.18821025600986407d, c: 0.9740037535570704d),

new NpgsqlTypes.NpgsqlLine(a: 0.7729579560840041d, b: 0.5283959837814016d, c: 0.3246873097765165d),

new NpgsqlTypes.NpgsqlLine(a: 0.5804554841359071d, b: 0.7951318743812129d, c: 0.9533437460862759d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07357632206959641d, b: 0.11099061080365447d, c: 0.47576723756466854d),

new NpgsqlTypes.NpgsqlLine(a: 0.9051522311200175d, b: 0.6041352781626989d, c: 0.962846313750425d),

new NpgsqlTypes.NpgsqlLine(a: 0.7230697163609032d, b: 0.35996997662147945d, c: 0.2719627850842049d),

new NpgsqlTypes.NpgsqlLine(a: 0.039972657007877d, b: 0.6660692046588974d, c: 0.8074219604808613d),

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

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1278639929));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8637991908928382d, b: 0.7989476928355281d, c: 0.047074497669961635d),

new NpgsqlTypes.NpgsqlLine(a: 0.24284327761860214d, b: 0.034845279321367495d, c: 0.8243144068858446d),

new NpgsqlTypes.NpgsqlLine(a: 0.2705173386529084d, b: 0.37759514414776285d, c: 0.003784057263189533d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5464646368268954d, b: 0.1698011067851829d, c: 0.4811896051504386d),

new NpgsqlTypes.NpgsqlLine(a: 0.3264558304845737d, b: 0.09741548986796533d, c: 0.35078408755418944d),

new NpgsqlTypes.NpgsqlLine(a: 0.1253849539183054d, b: 0.9184504405667023d, c: 0.6244095303662431d),

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

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1352296160));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6961581521563707d, b: 0.2870425810465653d, c: 0.022813771410836625d),

new NpgsqlTypes.NpgsqlLine(a: 0.9289180434806266d, b: 0.10310192777053839d, c: 0.4974840036652155d),

new NpgsqlTypes.NpgsqlLine(a: 0.9742618124298718d, b: 0.666155889593685d, c: 0.9108800941033853d),

new NpgsqlTypes.NpgsqlLine(a: 0.4076993728994177d, b: 0.9237619110159688d, c: 0.16349574316883708d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.40245830157937157d, b: 0.4425237993192568d, c: 0.3605907953188545d),

new NpgsqlTypes.NpgsqlLine(a: 0.3025387755185438d, b: 0.16175616826033246d, c: 0.08369914886846197d),

new NpgsqlTypes.NpgsqlLine(a: 0.7932786053551402d, b: 0.4757892941852452d, c: 0.35215963103511483d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2052209240));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28682097488067404d, b: 0.19347953745544d, c: 0.767001580247448d),

new NpgsqlTypes.NpgsqlLine(a: 0.34168929191792363d, b: 0.5324263819109204d, c: 0.3548736591683712d),

new NpgsqlTypes.NpgsqlLine(a: 0.7601584215479089d, b: 0.9667193856859281d, c: 0.48805620341333844d),

new NpgsqlTypes.NpgsqlLine(a: 0.4778030273140724d, b: 0.6459214140044727d, c: 0.9825570138966864d),

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
                Assert.That(model.Id, Is.EqualTo(1422030401));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5508950376990435d, b: 0.1842011543506923d, c: 0.7200839172656331d),

new NpgsqlTypes.NpgsqlLine(a: 0.08098131741133519d, b: 0.2512744482896645d, c: 0.4419893154281408d),

new NpgsqlTypes.NpgsqlLine(a: 0.7183180834237055d, b: 0.3821225061156569d, c: 0.320010478004808d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.605461690855222d, b: 0.5098249599693536d, c: 0.049446338505273246d),

new NpgsqlTypes.NpgsqlLine(a: 0.6383133050473475d, b: 0.5385834180776717d, c: 0.2612256906158803d),

new NpgsqlTypes.NpgsqlLine(a: 0.2259744218921168d, b: 0.0504022254415285d, c: 0.5085817881315488d),

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

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1441068318));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04431673188157559d, b: 0.7118895502319815d, c: 0.8045459394080527d),

new NpgsqlTypes.NpgsqlLine(a: 0.41883883343441664d, b: 0.0856133325697227d, c: 0.45940150990219364d),

new NpgsqlTypes.NpgsqlLine(a: 0.3845455332415372d, b: 0.5278908004707358d, c: 0.45211852173959755d),

new NpgsqlTypes.NpgsqlLine(a: 0.707344526938849d, b: 0.2664835051263448d, c: 0.8012907013628192d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5167014945187821d, b: 0.2318523474732329d, c: 0.0766480392056259d),

new NpgsqlTypes.NpgsqlLine(a: 0.6239339834043951d, b: 0.4407650281616141d, c: 0.07711199216030074d),

new NpgsqlTypes.NpgsqlLine(a: 0.7330247230488705d, b: 0.06195929907587139d, c: 0.1736910797965654d),

new NpgsqlTypes.NpgsqlLine(a: 0.5060985759956755d, b: 0.12918142066992122d, c: 0.3598502037154421d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1349638635));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8811777097968191d, b: 0.09805743628781294d, c: 0.8476023389336619d),

new NpgsqlTypes.NpgsqlLine(a: 0.16329696312104391d, b: 0.8434248077846473d, c: 0.0171626874853823d),

new NpgsqlTypes.NpgsqlLine(a: 0.5930114320798587d, b: 0.7874763150232159d, c: 0.20169365861720767d),

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
                Assert.That(model.Id, Is.EqualTo(1485177216));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7620135774845544d, b: 0.72234986247445d, c: 0.7900958363555012d),

new NpgsqlTypes.NpgsqlLine(a: 0.5982892074823093d, b: 0.9157569165822279d, c: 0.5913666560112503d),

new NpgsqlTypes.NpgsqlLine(a: 0.3694255096703286d, b: 0.43689654039349735d, c: 0.27488642071951885d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1888587968));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9441675468790086d, b: 0.10273087249159918d, c: 0.36496868371913627d),

new NpgsqlTypes.NpgsqlLine(a: 0.3153900895384264d, b: 0.8953921593705707d, c: 0.6821583482258307d),

new NpgsqlTypes.NpgsqlLine(a: 0.15884512105184567d, b: 0.20745599422324912d, c: 0.5928677501305737d),

new NpgsqlTypes.NpgsqlLine(a: 0.19203772899196803d, b: 0.9281999546867626d, c: 0.9792553764463741d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.616453689236877d, b: 0.26880075600348696d, c: 0.9911672578342802d),

new NpgsqlTypes.NpgsqlLine(a: 0.41598816366831615d, b: 0.2972198032481773d, c: 0.6096249065094251d),

new NpgsqlTypes.NpgsqlLine(a: 0.21461782395965212d, b: 0.4996081675192614d, c: 0.845029551763019d),

new NpgsqlTypes.NpgsqlLine(a: 0.14603833144353173d, b: 0.5155958582129082d, c: 0.9513100476397736d),

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
                Assert.That(model.Id, Is.EqualTo(1612037280));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9755688560619167d, b: 0.7517347444178538d, c: 0.4433097656621017d),

new NpgsqlTypes.NpgsqlLine(a: 0.27642151559126893d, b: 0.49560032188535075d, c: 0.4017019854911661d),

new NpgsqlTypes.NpgsqlLine(a: 0.48234378585453686d, b: 0.5838608048706788d, c: 0.45264440736135125d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1803941428));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4958174274877982d, b: 0.19935005698584918d, c: 0.6570481803156852d),

new NpgsqlTypes.NpgsqlLine(a: 0.586031122116916d, b: 0.20438200508300097d, c: 0.7214279726394314d),

new NpgsqlTypes.NpgsqlLine(a: 0.3287771922455527d, b: 0.31464931534195395d, c: 0.49275260904707807d),

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
                Assert.That(model.Id, Is.EqualTo(1694903385));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5133551130062282d, b: 0.5981369379522861d, c: 0.5856516805262975d),

new NpgsqlTypes.NpgsqlLine(a: 0.4556255479239121d, b: 0.059243842569019045d, c: 0.18272228811839042d),

new NpgsqlTypes.NpgsqlLine(a: 0.8085308768004308d, b: 0.8348590541320315d, c: 0.5895099353964641d),

new NpgsqlTypes.NpgsqlLine(a: 0.24149968696186774d, b: 0.35557480082622506d, c: 0.5451461752136405d),

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

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1708194464));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21378574042766885d, b: 0.22474127876321393d, c: 0.01286635194062602d),

new NpgsqlTypes.NpgsqlLine(a: 0.44720527497131246d, b: 0.83386820783986d, c: 0.47600740851603984d),

new NpgsqlTypes.NpgsqlLine(a: 0.9177345103701179d, b: 0.8135674766115204d, c: 0.23923291716083794d),

new NpgsqlTypes.NpgsqlLine(a: 0.9998743487003019d, b: 0.013427841900149451d, c: 0.9133209978570025d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(871029693));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09314286666835214d, b: 0.9419395542104619d, c: 0.23265001920909978d),

new NpgsqlTypes.NpgsqlLine(a: 0.7840922282915723d, b: 0.8769622177219351d, c: 0.08844919095146764d),

new NpgsqlTypes.NpgsqlLine(a: 0.30172065868559383d, b: 0.061796126836928256d, c: 0.7819510380905712d),

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
                Assert.That(model.Id, Is.EqualTo(1749272119));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48465570613062037d, b: 0.4077570571696034d, c: 0.09124205112015671d),

new NpgsqlTypes.NpgsqlLine(a: 0.4905692123673753d, b: 0.09753381316271936d, c: 0.6219861110019185d),

new NpgsqlTypes.NpgsqlLine(a: 0.7715584772299492d, b: 0.7647042738214676d, c: 0.32981711302760286d),

new NpgsqlTypes.NpgsqlLine(a: 0.7826950107361046d, b: 0.6159017458991703d, c: 0.8761288210787351d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05854830086605134d, b: 0.4584727830793912d, c: 0.6485776355671607d),

new NpgsqlTypes.NpgsqlLine(a: 0.057402368952540694d, b: 0.814338567877536d, c: 0.36045674525095406d),

new NpgsqlTypes.NpgsqlLine(a: 0.4609921668504162d, b: 0.45446719793916357d, c: 0.6647833262693906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8421363107491464d, b: 0.8724917366553757d, c: 0.2954174236384989d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743101311));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30049737151744216d, b: 0.10935998965187232d, c: 0.12002566064851483d),

new NpgsqlTypes.NpgsqlLine(a: 0.4579983959880112d, b: 0.8700234892072651d, c: 0.24545341370685325d),

new NpgsqlTypes.NpgsqlLine(a: 0.6992061752442d, b: 0.8760611086508132d, c: 0.31896424715232463d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14975557199832845d, b: 0.8649037801511367d, c: 0.8035067258718913d),

new NpgsqlTypes.NpgsqlLine(a: 0.022767088770272226d, b: 0.824519829812387d, c: 0.2990170967826957d),

new NpgsqlTypes.NpgsqlLine(a: 0.264229467978496d, b: 0.4707396384081288d, c: 0.5870444614457326d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[25];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1750072079));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6509605768915644d, b: 0.2871280523199907d, c: 0.5279864073907687d),

new NpgsqlTypes.NpgsqlLine(a: 0.847627780191932d, b: 0.2863239370866939d, c: 0.39664595009550063d),

new NpgsqlTypes.NpgsqlLine(a: 0.06719070091173818d, b: 0.2998868113793318d, c: 0.8109899934095542d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30402634597868494d, b: 0.7741177113732105d, c: 0.4982697795456863d),

new NpgsqlTypes.NpgsqlLine(a: 0.22134239051678783d, b: 0.952989590947333d, c: 0.1976805178607327d),

new NpgsqlTypes.NpgsqlLine(a: 0.48019693876130953d, b: 0.8553553442730837d, c: 0.4578014530562905d),

new NpgsqlTypes.NpgsqlLine(a: 0.7948720279836796d, b: 0.6347165612507009d, c: 0.4915047790558922d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(681877477));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.054876749435908034d, b: 0.7476698065656858d, c: 0.5221215501493097d),

new NpgsqlTypes.NpgsqlLine(a: 0.1689911006864584d, b: 0.16032672190790076d, c: 0.9537953031702238d),

new NpgsqlTypes.NpgsqlLine(a: 0.3133690487713232d, b: 0.21425817972116357d, c: 0.39002508371565625d),

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

                        model = models[26];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1765269457));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4428210775962541d, b: 0.44628545865868685d, c: 0.7913435097925557d),

new NpgsqlTypes.NpgsqlLine(a: 0.26419018627718516d, b: 0.12166427922453704d, c: 0.11250832552770584d),

new NpgsqlTypes.NpgsqlLine(a: 0.20276585628171784d, b: 0.14489314174625478d, c: 0.5410582863519566d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(699428708));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.75437435623167d, b: 0.4381969103973332d, c: 0.13859938549471296d),

new NpgsqlTypes.NpgsqlLine(a: 0.22478326045746155d, b: 0.7927996319630696d, c: 0.5653146543488808d),

new NpgsqlTypes.NpgsqlLine(a: 0.8148660813324691d, b: 0.5965502974097225d, c: 0.08598406767552191d),

new NpgsqlTypes.NpgsqlLine(a: 0.10261855436837408d, b: 0.22753843400620033d, c: 0.6663050101504865d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19047502268477823d, b: 0.503647750986701d, c: 0.5140837344549085d),

new NpgsqlTypes.NpgsqlLine(a: 0.5498279015442291d, b: 0.5205498180433044d, c: 0.5511400439881968d),

new NpgsqlTypes.NpgsqlLine(a: 0.07519565206915457d, b: 0.8190939422278946d, c: 0.4842243543091963d),

new NpgsqlTypes.NpgsqlLine(a: 0.11151345358207676d, b: 0.2794260095615846d, c: 0.1977999861392018d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(24));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(425879955));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7120720914880876d, b: 0.12018496532744738d, c: 0.23458035596972604d),

new NpgsqlTypes.NpgsqlLine(a: 0.8966943482850258d, b: 0.35901938172619774d, c: 0.5153333646331681d),

new NpgsqlTypes.NpgsqlLine(a: 0.772529205234202d, b: 0.3302141544038909d, c: 0.49860223574471696d),

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
                Assert.That(model.Id, Is.EqualTo(447065450));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6636554004535458d, b: 0.4052905058278198d, c: 0.17999403534412883d),

new NpgsqlTypes.NpgsqlLine(a: 0.4929643299593621d, b: 0.04102771738828992d, c: 0.8758588440576921d),

new NpgsqlTypes.NpgsqlLine(a: 0.9843591359807438d, b: 0.9486545770421181d, c: 0.23810538982780194d),

new NpgsqlTypes.NpgsqlLine(a: 0.0373504814930844d, b: 0.29650224807426506d, c: 0.6527517869517908d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1935239880));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5125009420178407d, b: 0.13553866813087467d, c: 0.6573124881706722d),

new NpgsqlTypes.NpgsqlLine(a: 0.9315668534985179d, b: 0.031339976871202935d, c: 0.7319776155987312d),

new NpgsqlTypes.NpgsqlLine(a: 0.5913519522327184d, b: 0.688194613219936d, c: 0.7487303543444555d),

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
                Assert.That(model.Id, Is.EqualTo(776647699));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8841755970938628d, b: 0.039993263617271846d, c: 0.2425222413816407d),

new NpgsqlTypes.NpgsqlLine(a: 0.3162669055857611d, b: 0.1360654949714053d, c: 0.585066125260232d),

new NpgsqlTypes.NpgsqlLine(a: 0.23614085233198578d, b: 0.9624524908146396d, c: 0.8036122013629919d),

new NpgsqlTypes.NpgsqlLine(a: 0.9594786748108928d, b: 0.3334512033062713d, c: 0.8626799508985245d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7692177568154062d, b: 0.8045212370680859d, c: 0.347836807601842d),

new NpgsqlTypes.NpgsqlLine(a: 0.8596806867272218d, b: 0.42225206488490163d, c: 0.2626771759427945d),

new NpgsqlTypes.NpgsqlLine(a: 0.6334601490046422d, b: 0.5508277640730257d, c: 0.9702039181027914d),

new NpgsqlTypes.NpgsqlLine(a: 0.7862671596820799d, b: 0.6148121550149941d, c: 0.10467782441316142d),

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
                Assert.That(model.Id, Is.EqualTo(920410273));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7950181430955406d, b: 0.3848051391253504d, c: 0.1572657802170856d),

new NpgsqlTypes.NpgsqlLine(a: 0.6062151918599252d, b: 0.06062326101597226d, c: 0.14777044879318857d),

new NpgsqlTypes.NpgsqlLine(a: 0.7408182398935058d, b: 0.6661433504932776d, c: 0.15722709569280902d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2482561889064241d, b: 0.768360521777252d, c: 0.24033198573060877d),

new NpgsqlTypes.NpgsqlLine(a: 0.6078828832971318d, b: 0.25910942482320465d, c: 0.7624300130707319d),

new NpgsqlTypes.NpgsqlLine(a: 0.551230062109523d, b: 0.5951997473266207d, c: 0.05557568229198884d),

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

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(929385902));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8285395037487209d, b: 0.25070273066629d, c: 0.2500673109161923d),

new NpgsqlTypes.NpgsqlLine(a: 0.9942717530143405d, b: 0.21539215026712022d, c: 0.20269945939501077d),

new NpgsqlTypes.NpgsqlLine(a: 0.7979702358088475d, b: 0.0037115614378556705d, c: 0.8843432168677479d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1456202870910711d, b: 0.06772665910903597d, c: 0.691750610472359d),

new NpgsqlTypes.NpgsqlLine(a: 0.765757989281042d, b: 0.32982835634782004d, c: 0.8913701807765988d),

new NpgsqlTypes.NpgsqlLine(a: 0.052240732409688406d, b: 0.618262798295761d, c: 0.8474290495942781d),

new NpgsqlTypes.NpgsqlLine(a: 0.3584922315949717d, b: 0.520574773115294d, c: 0.8310230234204736d),

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
                Assert.That(model.Id, Is.EqualTo(939691488));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15928813769803307d, b: 0.5335096410959914d, c: 0.9693141891385088d),

new NpgsqlTypes.NpgsqlLine(a: 0.9448241901930845d, b: 0.6287076527827521d, c: 0.6660617468801671d),

new NpgsqlTypes.NpgsqlLine(a: 0.30712778702622445d, b: 0.324942912367581d, c: 0.9500282198259326d),

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
                Assert.That(model.Id, Is.EqualTo(940484658));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8457530794410952d, b: 0.07468146527745967d, c: 0.6058450234777081d),

new NpgsqlTypes.NpgsqlLine(a: 0.43907623012482566d, b: 0.4163533057091461d, c: 0.7083053151407345d),

new NpgsqlTypes.NpgsqlLine(a: 0.6460729456777172d, b: 0.3996032448892458d, c: 0.32058136990645736d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5056133907420888d, b: 0.687789482585691d, c: 0.5736898296981361d),

new NpgsqlTypes.NpgsqlLine(a: 0.6165837793609097d, b: 0.3896094649555947d, c: 0.782529168193896d),

new NpgsqlTypes.NpgsqlLine(a: 0.19522061405511182d, b: 0.49515141325692447d, c: 0.8154303350690599d),

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
                Assert.That(model.Id, Is.EqualTo(956171576));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6305558129660189d, b: 0.5463622939629917d, c: 0.401891977997777d),

new NpgsqlTypes.NpgsqlLine(a: 0.3662230087345998d, b: 0.4302679455886196d, c: 0.9631184941583132d),

new NpgsqlTypes.NpgsqlLine(a: 0.3634906094993412d, b: 0.18046820180120404d, c: 0.5193725822662353d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48533853922222536d, b: 0.7781157007327932d, c: 0.20671476643143427d),

new NpgsqlTypes.NpgsqlLine(a: 0.7321919326621603d, b: 0.7704043405190548d, c: 0.5508846640658778d),

new NpgsqlTypes.NpgsqlLine(a: 0.5796306726535371d, b: 0.3621536966457104d, c: 0.3554092618887771d),

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
                Assert.That(model.Id, Is.EqualTo(1049476690));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1703167002028123d, b: 0.06899134909065618d, c: 0.39632655876575884d),

new NpgsqlTypes.NpgsqlLine(a: 0.9436521110809849d, b: 0.2716102490692832d, c: 0.21807972083943694d),

new NpgsqlTypes.NpgsqlLine(a: 0.07510391898176405d, b: 0.4622700624960824d, c: 0.6916474126671974d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3434566231012316d, b: 0.6092872970160005d, c: 0.8285200623737458d),

new NpgsqlTypes.NpgsqlLine(a: 0.438620087459067d, b: 0.42784452615069857d, c: 0.43791996431227087d),

new NpgsqlTypes.NpgsqlLine(a: 0.13822472685663223d, b: 0.3567687904324768d, c: 0.5713362361619454d),

new NpgsqlTypes.NpgsqlLine(a: 0.4225842002023096d, b: 0.13041963778907273d, c: 0.537431949671262d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(259689541));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16915141278580792d, b: 0.5107686791340034d, c: 0.6489920882506348d),

new NpgsqlTypes.NpgsqlLine(a: 0.030879513236027d, b: 0.6401283771223818d, c: 0.4904762444562075d),

new NpgsqlTypes.NpgsqlLine(a: 0.16124954101586042d, b: 0.7102870300472969d, c: 0.9978682907813775d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3413197342637151d, b: 0.3564754218301692d, c: 0.16698356005321802d),

new NpgsqlTypes.NpgsqlLine(a: 0.24996465538547474d, b: 0.6936235099874405d, c: 0.00768766971096424d),

new NpgsqlTypes.NpgsqlLine(a: 0.9713834412198872d, b: 0.1937685310996965d, c: 0.5638524218711839d),

new NpgsqlTypes.NpgsqlLine(a: 0.20790035052620326d, b: 0.7280555648340241d, c: 0.7150389111804211d),

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
                Assert.That(model.Id, Is.EqualTo(1169283916));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6136867588329713d, b: 0.8476721243007673d, c: 0.2920466838690219d),

new NpgsqlTypes.NpgsqlLine(a: 0.5632572533709046d, b: 0.8580393386665631d, c: 0.29067186403759726d),

new NpgsqlTypes.NpgsqlLine(a: 0.05864985939465561d, b: 0.06933376015004311d, c: 0.2622230618531959d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3083889075922114d, b: 0.40504233141015844d, c: 0.7282625593772889d),

new NpgsqlTypes.NpgsqlLine(a: 0.9760389595620657d, b: 0.5432046524856411d, c: 0.4805721407516501d),

new NpgsqlTypes.NpgsqlLine(a: 0.226094370846618d, b: 0.30929816503923757d, c: 0.749788108094253d),

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
                Assert.That(model.Id, Is.EqualTo(1247961184));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588334999708729d, b: 0.5781258655739143d, c: 0.4951203893647069d),

new NpgsqlTypes.NpgsqlLine(a: 0.206651781249944d, b: 0.9214488824097644d, c: 0.7102197735978709d),

new NpgsqlTypes.NpgsqlLine(a: 0.8293873017859008d, b: 0.4197388618664637d, c: 0.7538628331143343d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9886122302398814d, b: 0.09733443476141157d, c: 0.8828756753279827d),

new NpgsqlTypes.NpgsqlLine(a: 0.4191781730328399d, b: 0.8360940579259326d, c: 0.3115604346093266d),

new NpgsqlTypes.NpgsqlLine(a: 0.03123256692948395d, b: 0.4210178852779579d, c: 0.7083559364281564d),

new NpgsqlTypes.NpgsqlLine(a: 0.10193811062121638d, b: 0.7865607707379441d, c: 0.5102014504618864d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(313349652));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7148027863911385d, b: 0.4116315290140842d, c: 0.9883513693293022d),

new NpgsqlTypes.NpgsqlLine(a: 0.730798769811796d, b: 0.5625059295801093d, c: 0.028144945623879147d),

new NpgsqlTypes.NpgsqlLine(a: 0.7895921923207063d, b: 0.897092096080744d, c: 0.36804397804374556d),

new NpgsqlTypes.NpgsqlLine(a: 0.4403951364132078d, b: 0.48316034726668566d, c: 0.5561087583026281d),

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
                Assert.That(model.Id, Is.EqualTo(1251267268));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.27064576558959075d, b: 0.24611103650290955d, c: 0.04928435530376152d),

new NpgsqlTypes.NpgsqlLine(a: 0.5382620257248645d, b: 0.586731968734226d, c: 0.9110741668368397d),

new NpgsqlTypes.NpgsqlLine(a: 0.8386954216871374d, b: 0.14045527908308764d, c: 0.5300328684198944d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7572326327773035d, b: 0.10039993499818312d, c: 0.17339739029118428d),

new NpgsqlTypes.NpgsqlLine(a: 0.9566618331567527d, b: 0.14668861402647748d, c: 0.7767711369985796d),

new NpgsqlTypes.NpgsqlLine(a: 0.932727244163919d, b: 0.12159065636952726d, c: 0.1704609096711438d),

new NpgsqlTypes.NpgsqlLine(a: 0.5792460825794749d, b: 0.985437582839235d, c: 0.557473090399633d),

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
                Assert.That(model.Id, Is.EqualTo(1276251566));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4808529939808879d, b: 0.365247596328651d, c: 0.17939866902766977d),

new NpgsqlTypes.NpgsqlLine(a: 0.12809708913748585d, b: 0.18821025600986407d, c: 0.9740037535570704d),

new NpgsqlTypes.NpgsqlLine(a: 0.7729579560840041d, b: 0.5283959837814016d, c: 0.3246873097765165d),

new NpgsqlTypes.NpgsqlLine(a: 0.5804554841359071d, b: 0.7951318743812129d, c: 0.9533437460862759d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07357632206959641d, b: 0.11099061080365447d, c: 0.47576723756466854d),

new NpgsqlTypes.NpgsqlLine(a: 0.9051522311200175d, b: 0.6041352781626989d, c: 0.962846313750425d),

new NpgsqlTypes.NpgsqlLine(a: 0.7230697163609032d, b: 0.35996997662147945d, c: 0.2719627850842049d),

new NpgsqlTypes.NpgsqlLine(a: 0.039972657007877d, b: 0.6660692046588974d, c: 0.8074219604808613d),

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
                Assert.That(model.Id, Is.EqualTo(1278639929));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8637991908928382d, b: 0.7989476928355281d, c: 0.047074497669961635d),

new NpgsqlTypes.NpgsqlLine(a: 0.24284327761860214d, b: 0.034845279321367495d, c: 0.8243144068858446d),

new NpgsqlTypes.NpgsqlLine(a: 0.2705173386529084d, b: 0.37759514414776285d, c: 0.003784057263189533d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5464646368268954d, b: 0.1698011067851829d, c: 0.4811896051504386d),

new NpgsqlTypes.NpgsqlLine(a: 0.3264558304845737d, b: 0.09741548986796533d, c: 0.35078408755418944d),

new NpgsqlTypes.NpgsqlLine(a: 0.1253849539183054d, b: 0.9184504405667023d, c: 0.6244095303662431d),

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
                Assert.That(model.Id, Is.EqualTo(1352296160));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6961581521563707d, b: 0.2870425810465653d, c: 0.022813771410836625d),

new NpgsqlTypes.NpgsqlLine(a: 0.9289180434806266d, b: 0.10310192777053839d, c: 0.4974840036652155d),

new NpgsqlTypes.NpgsqlLine(a: 0.9742618124298718d, b: 0.666155889593685d, c: 0.9108800941033853d),

new NpgsqlTypes.NpgsqlLine(a: 0.4076993728994177d, b: 0.9237619110159688d, c: 0.16349574316883708d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.40245830157937157d, b: 0.4425237993192568d, c: 0.3605907953188545d),

new NpgsqlTypes.NpgsqlLine(a: 0.3025387755185438d, b: 0.16175616826033246d, c: 0.08369914886846197d),

new NpgsqlTypes.NpgsqlLine(a: 0.7932786053551402d, b: 0.4757892941852452d, c: 0.35215963103511483d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2052209240));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28682097488067404d, b: 0.19347953745544d, c: 0.767001580247448d),

new NpgsqlTypes.NpgsqlLine(a: 0.34168929191792363d, b: 0.5324263819109204d, c: 0.3548736591683712d),

new NpgsqlTypes.NpgsqlLine(a: 0.7601584215479089d, b: 0.9667193856859281d, c: 0.48805620341333844d),

new NpgsqlTypes.NpgsqlLine(a: 0.4778030273140724d, b: 0.6459214140044727d, c: 0.9825570138966864d),

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
                Assert.That(model.Id, Is.EqualTo(1422030401));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5508950376990435d, b: 0.1842011543506923d, c: 0.7200839172656331d),

new NpgsqlTypes.NpgsqlLine(a: 0.08098131741133519d, b: 0.2512744482896645d, c: 0.4419893154281408d),

new NpgsqlTypes.NpgsqlLine(a: 0.7183180834237055d, b: 0.3821225061156569d, c: 0.320010478004808d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.605461690855222d, b: 0.5098249599693536d, c: 0.049446338505273246d),

new NpgsqlTypes.NpgsqlLine(a: 0.6383133050473475d, b: 0.5385834180776717d, c: 0.2612256906158803d),

new NpgsqlTypes.NpgsqlLine(a: 0.2259744218921168d, b: 0.0504022254415285d, c: 0.5085817881315488d),

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

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1441068318));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04431673188157559d, b: 0.7118895502319815d, c: 0.8045459394080527d),

new NpgsqlTypes.NpgsqlLine(a: 0.41883883343441664d, b: 0.0856133325697227d, c: 0.45940150990219364d),

new NpgsqlTypes.NpgsqlLine(a: 0.3845455332415372d, b: 0.5278908004707358d, c: 0.45211852173959755d),

new NpgsqlTypes.NpgsqlLine(a: 0.707344526938849d, b: 0.2664835051263448d, c: 0.8012907013628192d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5167014945187821d, b: 0.2318523474732329d, c: 0.0766480392056259d),

new NpgsqlTypes.NpgsqlLine(a: 0.6239339834043951d, b: 0.4407650281616141d, c: 0.07711199216030074d),

new NpgsqlTypes.NpgsqlLine(a: 0.7330247230488705d, b: 0.06195929907587139d, c: 0.1736910797965654d),

new NpgsqlTypes.NpgsqlLine(a: 0.5060985759956755d, b: 0.12918142066992122d, c: 0.3598502037154421d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1349638635));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8811777097968191d, b: 0.09805743628781294d, c: 0.8476023389336619d),

new NpgsqlTypes.NpgsqlLine(a: 0.16329696312104391d, b: 0.8434248077846473d, c: 0.0171626874853823d),

new NpgsqlTypes.NpgsqlLine(a: 0.5930114320798587d, b: 0.7874763150232159d, c: 0.20169365861720767d),

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
                Assert.That(model.Id, Is.EqualTo(1485177216));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7620135774845544d, b: 0.72234986247445d, c: 0.7900958363555012d),

new NpgsqlTypes.NpgsqlLine(a: 0.5982892074823093d, b: 0.9157569165822279d, c: 0.5913666560112503d),

new NpgsqlTypes.NpgsqlLine(a: 0.3694255096703286d, b: 0.43689654039349735d, c: 0.27488642071951885d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1888587968));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9441675468790086d, b: 0.10273087249159918d, c: 0.36496868371913627d),

new NpgsqlTypes.NpgsqlLine(a: 0.3153900895384264d, b: 0.8953921593705707d, c: 0.6821583482258307d),

new NpgsqlTypes.NpgsqlLine(a: 0.15884512105184567d, b: 0.20745599422324912d, c: 0.5928677501305737d),

new NpgsqlTypes.NpgsqlLine(a: 0.19203772899196803d, b: 0.9281999546867626d, c: 0.9792553764463741d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.616453689236877d, b: 0.26880075600348696d, c: 0.9911672578342802d),

new NpgsqlTypes.NpgsqlLine(a: 0.41598816366831615d, b: 0.2972198032481773d, c: 0.6096249065094251d),

new NpgsqlTypes.NpgsqlLine(a: 0.21461782395965212d, b: 0.4996081675192614d, c: 0.845029551763019d),

new NpgsqlTypes.NpgsqlLine(a: 0.14603833144353173d, b: 0.5155958582129082d, c: 0.9513100476397736d),

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
                Assert.That(model.Id, Is.EqualTo(1612037280));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9755688560619167d, b: 0.7517347444178538d, c: 0.4433097656621017d),

new NpgsqlTypes.NpgsqlLine(a: 0.27642151559126893d, b: 0.49560032188535075d, c: 0.4017019854911661d),

new NpgsqlTypes.NpgsqlLine(a: 0.48234378585453686d, b: 0.5838608048706788d, c: 0.45264440736135125d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1803941428));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4958174274877982d, b: 0.19935005698584918d, c: 0.6570481803156852d),

new NpgsqlTypes.NpgsqlLine(a: 0.586031122116916d, b: 0.20438200508300097d, c: 0.7214279726394314d),

new NpgsqlTypes.NpgsqlLine(a: 0.3287771922455527d, b: 0.31464931534195395d, c: 0.49275260904707807d),

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
                Assert.That(model.Id, Is.EqualTo(1694903385));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5133551130062282d, b: 0.5981369379522861d, c: 0.5856516805262975d),

new NpgsqlTypes.NpgsqlLine(a: 0.4556255479239121d, b: 0.059243842569019045d, c: 0.18272228811839042d),

new NpgsqlTypes.NpgsqlLine(a: 0.8085308768004308d, b: 0.8348590541320315d, c: 0.5895099353964641d),

new NpgsqlTypes.NpgsqlLine(a: 0.24149968696186774d, b: 0.35557480082622506d, c: 0.5451461752136405d),

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
                Assert.That(model.Id, Is.EqualTo(1708194464));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21378574042766885d, b: 0.22474127876321393d, c: 0.01286635194062602d),

new NpgsqlTypes.NpgsqlLine(a: 0.44720527497131246d, b: 0.83386820783986d, c: 0.47600740851603984d),

new NpgsqlTypes.NpgsqlLine(a: 0.9177345103701179d, b: 0.8135674766115204d, c: 0.23923291716083794d),

new NpgsqlTypes.NpgsqlLine(a: 0.9998743487003019d, b: 0.013427841900149451d, c: 0.9133209978570025d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(871029693));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09314286666835214d, b: 0.9419395542104619d, c: 0.23265001920909978d),

new NpgsqlTypes.NpgsqlLine(a: 0.7840922282915723d, b: 0.8769622177219351d, c: 0.08844919095146764d),

new NpgsqlTypes.NpgsqlLine(a: 0.30172065868559383d, b: 0.061796126836928256d, c: 0.7819510380905712d),

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
                Assert.That(model.Id, Is.EqualTo(1749272119));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48465570613062037d, b: 0.4077570571696034d, c: 0.09124205112015671d),

new NpgsqlTypes.NpgsqlLine(a: 0.4905692123673753d, b: 0.09753381316271936d, c: 0.6219861110019185d),

new NpgsqlTypes.NpgsqlLine(a: 0.7715584772299492d, b: 0.7647042738214676d, c: 0.32981711302760286d),

new NpgsqlTypes.NpgsqlLine(a: 0.7826950107361046d, b: 0.6159017458991703d, c: 0.8761288210787351d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05854830086605134d, b: 0.4584727830793912d, c: 0.6485776355671607d),

new NpgsqlTypes.NpgsqlLine(a: 0.057402368952540694d, b: 0.814338567877536d, c: 0.36045674525095406d),

new NpgsqlTypes.NpgsqlLine(a: 0.4609921668504162d, b: 0.45446719793916357d, c: 0.6647833262693906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8421363107491464d, b: 0.8724917366553757d, c: 0.2954174236384989d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743101311));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30049737151744216d, b: 0.10935998965187232d, c: 0.12002566064851483d),

new NpgsqlTypes.NpgsqlLine(a: 0.4579983959880112d, b: 0.8700234892072651d, c: 0.24545341370685325d),

new NpgsqlTypes.NpgsqlLine(a: 0.6992061752442d, b: 0.8760611086508132d, c: 0.31896424715232463d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14975557199832845d, b: 0.8649037801511367d, c: 0.8035067258718913d),

new NpgsqlTypes.NpgsqlLine(a: 0.022767088770272226d, b: 0.824519829812387d, c: 0.2990170967826957d),

new NpgsqlTypes.NpgsqlLine(a: 0.264229467978496d, b: 0.4707396384081288d, c: 0.5870444614457326d),

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
                Assert.That(model.Id, Is.EqualTo(1750072079));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6509605768915644d, b: 0.2871280523199907d, c: 0.5279864073907687d),

new NpgsqlTypes.NpgsqlLine(a: 0.847627780191932d, b: 0.2863239370866939d, c: 0.39664595009550063d),

new NpgsqlTypes.NpgsqlLine(a: 0.06719070091173818d, b: 0.2998868113793318d, c: 0.8109899934095542d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30402634597868494d, b: 0.7741177113732105d, c: 0.4982697795456863d),

new NpgsqlTypes.NpgsqlLine(a: 0.22134239051678783d, b: 0.952989590947333d, c: 0.1976805178607327d),

new NpgsqlTypes.NpgsqlLine(a: 0.48019693876130953d, b: 0.8553553442730837d, c: 0.4578014530562905d),

new NpgsqlTypes.NpgsqlLine(a: 0.7948720279836796d, b: 0.6347165612507009d, c: 0.4915047790558922d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(681877477));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.054876749435908034d, b: 0.7476698065656858d, c: 0.5221215501493097d),

new NpgsqlTypes.NpgsqlLine(a: 0.1689911006864584d, b: 0.16032672190790076d, c: 0.9537953031702238d),

new NpgsqlTypes.NpgsqlLine(a: 0.3133690487713232d, b: 0.21425817972116357d, c: 0.39002508371565625d),

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
                Assert.That(model.Id, Is.EqualTo(1765269457));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4428210775962541d, b: 0.44628545865868685d, c: 0.7913435097925557d),

new NpgsqlTypes.NpgsqlLine(a: 0.26419018627718516d, b: 0.12166427922453704d, c: 0.11250832552770584d),

new NpgsqlTypes.NpgsqlLine(a: 0.20276585628171784d, b: 0.14489314174625478d, c: 0.5410582863519566d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(699428708));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.75437435623167d, b: 0.4381969103973332d, c: 0.13859938549471296d),

new NpgsqlTypes.NpgsqlLine(a: 0.22478326045746155d, b: 0.7927996319630696d, c: 0.5653146543488808d),

new NpgsqlTypes.NpgsqlLine(a: 0.8148660813324691d, b: 0.5965502974097225d, c: 0.08598406767552191d),

new NpgsqlTypes.NpgsqlLine(a: 0.10261855436837408d, b: 0.22753843400620033d, c: 0.6663050101504865d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19047502268477823d, b: 0.503647750986701d, c: 0.5140837344549085d),

new NpgsqlTypes.NpgsqlLine(a: 0.5498279015442291d, b: 0.5205498180433044d, c: 0.5511400439881968d),

new NpgsqlTypes.NpgsqlLine(a: 0.07519565206915457d, b: 0.8190939422278946d, c: 0.4842243543091963d),

new NpgsqlTypes.NpgsqlLine(a: 0.11151345358207676d, b: 0.2794260095615846d, c: 0.1977999861392018d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

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
COPY public.binary_npgsqllinelinearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MI),
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MI),
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

                var importCollection = new List<NpgsqlLinelineArray1MI>(7);

                importCollection.Add(
                new NpgsqlLinelineArray1MI
                {
                    Id = 160844459,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.49742066568592347d, b: 0.13045995730850435d, c: 0.3240701079822569d),

new NpgsqlTypes.NpgsqlLine(a: 0.4230136983146885d, b: 0.4758823758243249d, c: 0.7245296150407883d),

new NpgsqlTypes.NpgsqlLine(a: 0.902525000709505d, b: 0.3096633545847971d, c: 0.7195095860492445d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlLinelineArray1MI
                {
                    Id = 259689541,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16915141278580792d, b: 0.5107686791340034d, c: 0.6489920882506348d),

new NpgsqlTypes.NpgsqlLine(a: 0.030879513236027d, b: 0.6401283771223818d, c: 0.4904762444562075d),

new NpgsqlTypes.NpgsqlLine(a: 0.16124954101586042d, b: 0.7102870300472969d, c: 0.9978682907813775d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3413197342637151d, b: 0.3564754218301692d, c: 0.16698356005321802d),

new NpgsqlTypes.NpgsqlLine(a: 0.24996465538547474d, b: 0.6936235099874405d, c: 0.00768766971096424d),

new NpgsqlTypes.NpgsqlLine(a: 0.9713834412198872d, b: 0.1937685310996965d, c: 0.5638524218711839d),

new NpgsqlTypes.NpgsqlLine(a: 0.20790035052620326d, b: 0.7280555648340241d, c: 0.7150389111804211d),

}
                });

                importCollection.Add(
                new NpgsqlLinelineArray1MI
                {
                    Id = 313349652,
                    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7148027863911385d, b: 0.4116315290140842d, c: 0.9883513693293022d),

new NpgsqlTypes.NpgsqlLine(a: 0.730798769811796d, b: 0.5625059295801093d, c: 0.028144945623879147d),

new NpgsqlTypes.NpgsqlLine(a: 0.7895921923207063d, b: 0.897092096080744d, c: 0.36804397804374556d),

new NpgsqlTypes.NpgsqlLine(a: 0.4403951364132078d, b: 0.48316034726668566d, c: 0.5561087583026281d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlLinelineArray1MI
                {
                    Id = 507016837,
                    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6329641939546133d, b: 0.7713358064075255d, c: 0.7091675230581173d),

new NpgsqlTypes.NpgsqlLine(a: 0.6401104534145889d, b: 0.4461488045009705d, c: 0.8050604324576476d),

new NpgsqlTypes.NpgsqlLine(a: 0.718200194405203d, b: 0.43497844061299695d, c: 0.8863292600245054d),

new NpgsqlTypes.NpgsqlLine(a: 0.6409377372303063d, b: 0.6727026439221405d, c: 0.709162570856183d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlLinelineArray1MI
                {
                    Id = 671378680,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.579485378096583d, b: 0.7644192687968542d, c: 0.38803543767659376d),

new NpgsqlTypes.NpgsqlLine(a: 0.9272224559192928d, b: 0.04309922869802718d, c: 0.1084146589578524d),

new NpgsqlTypes.NpgsqlLine(a: 0.6194396921461146d, b: 0.3135327751395446d, c: 0.47728859432318693d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22238461731837955d, b: 0.8832575247518029d, c: 0.5267192016109244d),

new NpgsqlTypes.NpgsqlLine(a: 0.2456814921559901d, b: 0.12396858431218405d, c: 0.7758983059785806d),

new NpgsqlTypes.NpgsqlLine(a: 0.8010355013907535d, b: 0.10724380078506457d, c: 0.8516226142927568d),

}
                });

                importCollection.Add(
                new NpgsqlLinelineArray1MI
                {
                    Id = 681877477,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.054876749435908034d, b: 0.7476698065656858d, c: 0.5221215501493097d),

new NpgsqlTypes.NpgsqlLine(a: 0.1689911006864584d, b: 0.16032672190790076d, c: 0.9537953031702238d),

new NpgsqlTypes.NpgsqlLine(a: 0.3133690487713232d, b: 0.21425817972116357d, c: 0.39002508371565625d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlLinelineArray1MI
                {
                    Id = 699428708,
                    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.75437435623167d, b: 0.4381969103973332d, c: 0.13859938549471296d),

new NpgsqlTypes.NpgsqlLine(a: 0.22478326045746155d, b: 0.7927996319630696d, c: 0.5653146543488808d),

new NpgsqlTypes.NpgsqlLine(a: 0.8148660813324691d, b: 0.5965502974097225d, c: 0.08598406767552191d),

new NpgsqlTypes.NpgsqlLine(a: 0.10261855436837408d, b: 0.22753843400620033d, c: 0.6663050101504865d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19047502268477823d, b: 0.503647750986701d, c: 0.5140837344549085d),

new NpgsqlTypes.NpgsqlLine(a: 0.5498279015442291d, b: 0.5205498180433044d, c: 0.5511400439881968d),

new NpgsqlTypes.NpgsqlLine(a: 0.07519565206915457d, b: 0.8190939422278946d, c: 0.4842243543091963d),

new NpgsqlTypes.NpgsqlLine(a: 0.11151345358207676d, b: 0.2794260095615846d, c: 0.1977999861392018d),

}
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(160844459));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.49742066568592347d, b: 0.13045995730850435d, c: 0.3240701079822569d),

new NpgsqlTypes.NpgsqlLine(a: 0.4230136983146885d, b: 0.4758823758243249d, c: 0.7245296150407883d),

new NpgsqlTypes.NpgsqlLine(a: 0.902525000709505d, b: 0.3096633545847971d, c: 0.7195095860492445d),

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
                Assert.That(model.Id, Is.EqualTo(259689541));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16915141278580792d, b: 0.5107686791340034d, c: 0.6489920882506348d),

new NpgsqlTypes.NpgsqlLine(a: 0.030879513236027d, b: 0.6401283771223818d, c: 0.4904762444562075d),

new NpgsqlTypes.NpgsqlLine(a: 0.16124954101586042d, b: 0.7102870300472969d, c: 0.9978682907813775d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3413197342637151d, b: 0.3564754218301692d, c: 0.16698356005321802d),

new NpgsqlTypes.NpgsqlLine(a: 0.24996465538547474d, b: 0.6936235099874405d, c: 0.00768766971096424d),

new NpgsqlTypes.NpgsqlLine(a: 0.9713834412198872d, b: 0.1937685310996965d, c: 0.5638524218711839d),

new NpgsqlTypes.NpgsqlLine(a: 0.20790035052620326d, b: 0.7280555648340241d, c: 0.7150389111804211d),

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
                Assert.That(model.Id, Is.EqualTo(313349652));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7148027863911385d, b: 0.4116315290140842d, c: 0.9883513693293022d),

new NpgsqlTypes.NpgsqlLine(a: 0.730798769811796d, b: 0.5625059295801093d, c: 0.028144945623879147d),

new NpgsqlTypes.NpgsqlLine(a: 0.7895921923207063d, b: 0.897092096080744d, c: 0.36804397804374556d),

new NpgsqlTypes.NpgsqlLine(a: 0.4403951364132078d, b: 0.48316034726668566d, c: 0.5561087583026281d),

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

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(507016837));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6329641939546133d, b: 0.7713358064075255d, c: 0.7091675230581173d),

new NpgsqlTypes.NpgsqlLine(a: 0.6401104534145889d, b: 0.4461488045009705d, c: 0.8050604324576476d),

new NpgsqlTypes.NpgsqlLine(a: 0.718200194405203d, b: 0.43497844061299695d, c: 0.8863292600245054d),

new NpgsqlTypes.NpgsqlLine(a: 0.6409377372303063d, b: 0.6727026439221405d, c: 0.709162570856183d),

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
                Assert.That(model.Id, Is.EqualTo(671378680));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.579485378096583d, b: 0.7644192687968542d, c: 0.38803543767659376d),

new NpgsqlTypes.NpgsqlLine(a: 0.9272224559192928d, b: 0.04309922869802718d, c: 0.1084146589578524d),

new NpgsqlTypes.NpgsqlLine(a: 0.6194396921461146d, b: 0.3135327751395446d, c: 0.47728859432318693d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22238461731837955d, b: 0.8832575247518029d, c: 0.5267192016109244d),

new NpgsqlTypes.NpgsqlLine(a: 0.2456814921559901d, b: 0.12396858431218405d, c: 0.7758983059785806d),

new NpgsqlTypes.NpgsqlLine(a: 0.8010355013907535d, b: 0.10724380078506457d, c: 0.8516226142927568d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(681877477));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.054876749435908034d, b: 0.7476698065656858d, c: 0.5221215501493097d),

new NpgsqlTypes.NpgsqlLine(a: 0.1689911006864584d, b: 0.16032672190790076d, c: 0.9537953031702238d),

new NpgsqlTypes.NpgsqlLine(a: 0.3133690487713232d, b: 0.21425817972116357d, c: 0.39002508371565625d),

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
                Assert.That(model.Id, Is.EqualTo(699428708));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.75437435623167d, b: 0.4381969103973332d, c: 0.13859938549471296d),

new NpgsqlTypes.NpgsqlLine(a: 0.22478326045746155d, b: 0.7927996319630696d, c: 0.5653146543488808d),

new NpgsqlTypes.NpgsqlLine(a: 0.8148660813324691d, b: 0.5965502974097225d, c: 0.08598406767552191d),

new NpgsqlTypes.NpgsqlLine(a: 0.10261855436837408d, b: 0.22753843400620033d, c: 0.6663050101504865d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19047502268477823d, b: 0.503647750986701d, c: 0.5140837344549085d),

new NpgsqlTypes.NpgsqlLine(a: 0.5498279015442291d, b: 0.5205498180433044d, c: 0.5511400439881968d),

new NpgsqlTypes.NpgsqlLine(a: 0.07519565206915457d, b: 0.8190939422278946d, c: 0.4842243543091963d),

new NpgsqlTypes.NpgsqlLine(a: 0.11151345358207676d, b: 0.2794260095615846d, c: 0.1977999861392018d),

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
                new NpgsqlLinelineArray1MI
                {
                    Id = 871029693,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09314286666835214d, b: 0.9419395542104619d, c: 0.23265001920909978d),

new NpgsqlTypes.NpgsqlLine(a: 0.7840922282915723d, b: 0.8769622177219351d, c: 0.08844919095146764d),

new NpgsqlTypes.NpgsqlLine(a: 0.30172065868559383d, b: 0.061796126836928256d, c: 0.7819510380905712d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlLinelineArray1MI
                {
                    Id = 1349638635,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8811777097968191d, b: 0.09805743628781294d, c: 0.8476023389336619d),

new NpgsqlTypes.NpgsqlLine(a: 0.16329696312104391d, b: 0.8434248077846473d, c: 0.0171626874853823d),

new NpgsqlTypes.NpgsqlLine(a: 0.5930114320798587d, b: 0.7874763150232159d, c: 0.20169365861720767d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlLinelineArray1MI
                {
                    Id = 1743101311,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30049737151744216d, b: 0.10935998965187232d, c: 0.12002566064851483d),

new NpgsqlTypes.NpgsqlLine(a: 0.4579983959880112d, b: 0.8700234892072651d, c: 0.24545341370685325d),

new NpgsqlTypes.NpgsqlLine(a: 0.6992061752442d, b: 0.8760611086508132d, c: 0.31896424715232463d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14975557199832845d, b: 0.8649037801511367d, c: 0.8035067258718913d),

new NpgsqlTypes.NpgsqlLine(a: 0.022767088770272226d, b: 0.824519829812387d, c: 0.2990170967826957d),

new NpgsqlTypes.NpgsqlLine(a: 0.264229467978496d, b: 0.4707396384081288d, c: 0.5870444614457326d),

}
                });

                importCollection.Add(
                new NpgsqlLinelineArray1MI
                {
                    Id = 1803941428,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4958174274877982d, b: 0.19935005698584918d, c: 0.6570481803156852d),

new NpgsqlTypes.NpgsqlLine(a: 0.586031122116916d, b: 0.20438200508300097d, c: 0.7214279726394314d),

new NpgsqlTypes.NpgsqlLine(a: 0.3287771922455527d, b: 0.31464931534195395d, c: 0.49275260904707807d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlLinelineArray1MI
                {
                    Id = 1888587968,
                    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9441675468790086d, b: 0.10273087249159918d, c: 0.36496868371913627d),

new NpgsqlTypes.NpgsqlLine(a: 0.3153900895384264d, b: 0.8953921593705707d, c: 0.6821583482258307d),

new NpgsqlTypes.NpgsqlLine(a: 0.15884512105184567d, b: 0.20745599422324912d, c: 0.5928677501305737d),

new NpgsqlTypes.NpgsqlLine(a: 0.19203772899196803d, b: 0.9281999546867626d, c: 0.9792553764463741d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.616453689236877d, b: 0.26880075600348696d, c: 0.9911672578342802d),

new NpgsqlTypes.NpgsqlLine(a: 0.41598816366831615d, b: 0.2972198032481773d, c: 0.6096249065094251d),

new NpgsqlTypes.NpgsqlLine(a: 0.21461782395965212d, b: 0.4996081675192614d, c: 0.845029551763019d),

new NpgsqlTypes.NpgsqlLine(a: 0.14603833144353173d, b: 0.5155958582129082d, c: 0.9513100476397736d),

}
                });

                importCollection.Add(
                new NpgsqlLinelineArray1MI
                {
                    Id = 1935239880,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5125009420178407d, b: 0.13553866813087467d, c: 0.6573124881706722d),

new NpgsqlTypes.NpgsqlLine(a: 0.9315668534985179d, b: 0.031339976871202935d, c: 0.7319776155987312d),

new NpgsqlTypes.NpgsqlLine(a: 0.5913519522327184d, b: 0.688194613219936d, c: 0.7487303543444555d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlLinelineArray1MI
                {
                    Id = 2000087272,
                    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5174417835536576d, b: 0.9550151039410834d, c: 0.94465021980697d),

new NpgsqlTypes.NpgsqlLine(a: 0.023498567205728516d, b: 0.14704570142511664d, c: 0.5436176118381062d),

new NpgsqlTypes.NpgsqlLine(a: 0.6410825125912296d, b: 0.1638519482392854d, c: 0.07442290044208977d),

new NpgsqlTypes.NpgsqlLine(a: 0.5684954410076702d, b: 0.9517870324925599d, c: 0.7913121037671743d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5546781844769255d, b: 0.3295435210405563d, c: 0.10332785525555d),

new NpgsqlTypes.NpgsqlLine(a: 0.8619184029547027d, b: 0.6893143841340763d, c: 0.6057919377815917d),

new NpgsqlTypes.NpgsqlLine(a: 0.6918049340506819d, b: 0.29564467871458977d, c: 0.373851052320022d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590711543927416d, b: 0.782456230485786d, c: 0.0557514543823312d),

}
                });

                importCollection.Add(
                new NpgsqlLinelineArray1MI
                {
                    Id = 2052209240,
                    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28682097488067404d, b: 0.19347953745544d, c: 0.767001580247448d),

new NpgsqlTypes.NpgsqlLine(a: 0.34168929191792363d, b: 0.5324263819109204d, c: 0.3548736591683712d),

new NpgsqlTypes.NpgsqlLine(a: 0.7601584215479089d, b: 0.9667193856859281d, c: 0.48805620341333844d),

new NpgsqlTypes.NpgsqlLine(a: 0.4778030273140724d, b: 0.6459214140044727d, c: 0.9825570138966864d),

},
                    NullableValue = null
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(160844459));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.49742066568592347d, b: 0.13045995730850435d, c: 0.3240701079822569d),

new NpgsqlTypes.NpgsqlLine(a: 0.4230136983146885d, b: 0.4758823758243249d, c: 0.7245296150407883d),

new NpgsqlTypes.NpgsqlLine(a: 0.902525000709505d, b: 0.3096633545847971d, c: 0.7195095860492445d),

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
                Assert.That(model.Id, Is.EqualTo(259689541));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16915141278580792d, b: 0.5107686791340034d, c: 0.6489920882506348d),

new NpgsqlTypes.NpgsqlLine(a: 0.030879513236027d, b: 0.6401283771223818d, c: 0.4904762444562075d),

new NpgsqlTypes.NpgsqlLine(a: 0.16124954101586042d, b: 0.7102870300472969d, c: 0.9978682907813775d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3413197342637151d, b: 0.3564754218301692d, c: 0.16698356005321802d),

new NpgsqlTypes.NpgsqlLine(a: 0.24996465538547474d, b: 0.6936235099874405d, c: 0.00768766971096424d),

new NpgsqlTypes.NpgsqlLine(a: 0.9713834412198872d, b: 0.1937685310996965d, c: 0.5638524218711839d),

new NpgsqlTypes.NpgsqlLine(a: 0.20790035052620326d, b: 0.7280555648340241d, c: 0.7150389111804211d),

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
                Assert.That(model.Id, Is.EqualTo(313349652));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7148027863911385d, b: 0.4116315290140842d, c: 0.9883513693293022d),

new NpgsqlTypes.NpgsqlLine(a: 0.730798769811796d, b: 0.5625059295801093d, c: 0.028144945623879147d),

new NpgsqlTypes.NpgsqlLine(a: 0.7895921923207063d, b: 0.897092096080744d, c: 0.36804397804374556d),

new NpgsqlTypes.NpgsqlLine(a: 0.4403951364132078d, b: 0.48316034726668566d, c: 0.5561087583026281d),

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


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(507016837));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6329641939546133d, b: 0.7713358064075255d, c: 0.7091675230581173d),

new NpgsqlTypes.NpgsqlLine(a: 0.6401104534145889d, b: 0.4461488045009705d, c: 0.8050604324576476d),

new NpgsqlTypes.NpgsqlLine(a: 0.718200194405203d, b: 0.43497844061299695d, c: 0.8863292600245054d),

new NpgsqlTypes.NpgsqlLine(a: 0.6409377372303063d, b: 0.6727026439221405d, c: 0.709162570856183d),

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
                Assert.That(model.Id, Is.EqualTo(671378680));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.579485378096583d, b: 0.7644192687968542d, c: 0.38803543767659376d),

new NpgsqlTypes.NpgsqlLine(a: 0.9272224559192928d, b: 0.04309922869802718d, c: 0.1084146589578524d),

new NpgsqlTypes.NpgsqlLine(a: 0.6194396921461146d, b: 0.3135327751395446d, c: 0.47728859432318693d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22238461731837955d, b: 0.8832575247518029d, c: 0.5267192016109244d),

new NpgsqlTypes.NpgsqlLine(a: 0.2456814921559901d, b: 0.12396858431218405d, c: 0.7758983059785806d),

new NpgsqlTypes.NpgsqlLine(a: 0.8010355013907535d, b: 0.10724380078506457d, c: 0.8516226142927568d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(681877477));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.054876749435908034d, b: 0.7476698065656858d, c: 0.5221215501493097d),

new NpgsqlTypes.NpgsqlLine(a: 0.1689911006864584d, b: 0.16032672190790076d, c: 0.9537953031702238d),

new NpgsqlTypes.NpgsqlLine(a: 0.3133690487713232d, b: 0.21425817972116357d, c: 0.39002508371565625d),

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
                Assert.That(model.Id, Is.EqualTo(699428708));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.75437435623167d, b: 0.4381969103973332d, c: 0.13859938549471296d),

new NpgsqlTypes.NpgsqlLine(a: 0.22478326045746155d, b: 0.7927996319630696d, c: 0.5653146543488808d),

new NpgsqlTypes.NpgsqlLine(a: 0.8148660813324691d, b: 0.5965502974097225d, c: 0.08598406767552191d),

new NpgsqlTypes.NpgsqlLine(a: 0.10261855436837408d, b: 0.22753843400620033d, c: 0.6663050101504865d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19047502268477823d, b: 0.503647750986701d, c: 0.5140837344549085d),

new NpgsqlTypes.NpgsqlLine(a: 0.5498279015442291d, b: 0.5205498180433044d, c: 0.5511400439881968d),

new NpgsqlTypes.NpgsqlLine(a: 0.07519565206915457d, b: 0.8190939422278946d, c: 0.4842243543091963d),

new NpgsqlTypes.NpgsqlLine(a: 0.11151345358207676d, b: 0.2794260095615846d, c: 0.1977999861392018d),

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
                Assert.That(model.Id, Is.EqualTo(871029693));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09314286666835214d, b: 0.9419395542104619d, c: 0.23265001920909978d),

new NpgsqlTypes.NpgsqlLine(a: 0.7840922282915723d, b: 0.8769622177219351d, c: 0.08844919095146764d),

new NpgsqlTypes.NpgsqlLine(a: 0.30172065868559383d, b: 0.061796126836928256d, c: 0.7819510380905712d),

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
                Assert.That(model.Id, Is.EqualTo(1349638635));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8811777097968191d, b: 0.09805743628781294d, c: 0.8476023389336619d),

new NpgsqlTypes.NpgsqlLine(a: 0.16329696312104391d, b: 0.8434248077846473d, c: 0.0171626874853823d),

new NpgsqlTypes.NpgsqlLine(a: 0.5930114320798587d, b: 0.7874763150232159d, c: 0.20169365861720767d),

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


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1743101311));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30049737151744216d, b: 0.10935998965187232d, c: 0.12002566064851483d),

new NpgsqlTypes.NpgsqlLine(a: 0.4579983959880112d, b: 0.8700234892072651d, c: 0.24545341370685325d),

new NpgsqlTypes.NpgsqlLine(a: 0.6992061752442d, b: 0.8760611086508132d, c: 0.31896424715232463d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14975557199832845d, b: 0.8649037801511367d, c: 0.8035067258718913d),

new NpgsqlTypes.NpgsqlLine(a: 0.022767088770272226d, b: 0.824519829812387d, c: 0.2990170967826957d),

new NpgsqlTypes.NpgsqlLine(a: 0.264229467978496d, b: 0.4707396384081288d, c: 0.5870444614457326d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1803941428));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4958174274877982d, b: 0.19935005698584918d, c: 0.6570481803156852d),

new NpgsqlTypes.NpgsqlLine(a: 0.586031122116916d, b: 0.20438200508300097d, c: 0.7214279726394314d),

new NpgsqlTypes.NpgsqlLine(a: 0.3287771922455527d, b: 0.31464931534195395d, c: 0.49275260904707807d),

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


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1888587968));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9441675468790086d, b: 0.10273087249159918d, c: 0.36496868371913627d),

new NpgsqlTypes.NpgsqlLine(a: 0.3153900895384264d, b: 0.8953921593705707d, c: 0.6821583482258307d),

new NpgsqlTypes.NpgsqlLine(a: 0.15884512105184567d, b: 0.20745599422324912d, c: 0.5928677501305737d),

new NpgsqlTypes.NpgsqlLine(a: 0.19203772899196803d, b: 0.9281999546867626d, c: 0.9792553764463741d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.616453689236877d, b: 0.26880075600348696d, c: 0.9911672578342802d),

new NpgsqlTypes.NpgsqlLine(a: 0.41598816366831615d, b: 0.2972198032481773d, c: 0.6096249065094251d),

new NpgsqlTypes.NpgsqlLine(a: 0.21461782395965212d, b: 0.4996081675192614d, c: 0.845029551763019d),

new NpgsqlTypes.NpgsqlLine(a: 0.14603833144353173d, b: 0.5155958582129082d, c: 0.9513100476397736d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1935239880));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5125009420178407d, b: 0.13553866813087467d, c: 0.6573124881706722d),

new NpgsqlTypes.NpgsqlLine(a: 0.9315668534985179d, b: 0.031339976871202935d, c: 0.7319776155987312d),

new NpgsqlTypes.NpgsqlLine(a: 0.5913519522327184d, b: 0.688194613219936d, c: 0.7487303543444555d),

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


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000087272));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5174417835536576d, b: 0.9550151039410834d, c: 0.94465021980697d),

new NpgsqlTypes.NpgsqlLine(a: 0.023498567205728516d, b: 0.14704570142511664d, c: 0.5436176118381062d),

new NpgsqlTypes.NpgsqlLine(a: 0.6410825125912296d, b: 0.1638519482392854d, c: 0.07442290044208977d),

new NpgsqlTypes.NpgsqlLine(a: 0.5684954410076702d, b: 0.9517870324925599d, c: 0.7913121037671743d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5546781844769255d, b: 0.3295435210405563d, c: 0.10332785525555d),

new NpgsqlTypes.NpgsqlLine(a: 0.8619184029547027d, b: 0.6893143841340763d, c: 0.6057919377815917d),

new NpgsqlTypes.NpgsqlLine(a: 0.6918049340506819d, b: 0.29564467871458977d, c: 0.373851052320022d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590711543927416d, b: 0.782456230485786d, c: 0.0557514543823312d),

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
                Assert.That(model.Id, Is.EqualTo(2052209240));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28682097488067404d, b: 0.19347953745544d, c: 0.767001580247448d),

new NpgsqlTypes.NpgsqlLine(a: 0.34168929191792363d, b: 0.5324263819109204d, c: 0.3548736591683712d),

new NpgsqlTypes.NpgsqlLine(a: 0.7601584215479089d, b: 0.9667193856859281d, c: 0.48805620341333844d),

new NpgsqlTypes.NpgsqlLine(a: 0.4778030273140724d, b: 0.6459214140044727d, c: 0.9825570138966864d),

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
COPY public.binary_npgsqllinelinearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineArray1M),
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
FROM public.binary_npgsqllinelinearray1m m
LEFT JOIN public.binary_npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(NpgsqlLinelineArray1M),
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

                var importCollection = new List<NpgsqlLinelineArray1M>(15);

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 24431063,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7432562260700321d, b: 0.9027051106351455d, c: 0.20935776301702913d),

new NpgsqlTypes.NpgsqlLine(a: 0.06877648068052133d, b: 0.4638520424251973d, c: 0.8977581074629934d),

new NpgsqlTypes.NpgsqlLine(a: 0.19824889810271595d, b: 0.101805635004653d, c: 0.6376796129171594d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.25692356453649523d, b: 0.8249956321761069d, c: 0.7485760418256393d),

new NpgsqlTypes.NpgsqlLine(a: 0.5205543536927003d, b: 0.26409313743898866d, c: 0.11834223656249432d),

new NpgsqlTypes.NpgsqlLine(a: 0.12852097087774939d, b: 0.110468841038458d, c: 0.15781368742463253d),

new NpgsqlTypes.NpgsqlLine(a: 0.5056691167374713d, b: 0.17475361978672044d, c: 0.4301177356479713d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 88466632,
                    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24038691940074952d, b: 0.4574071819075469d, c: 0.029018693781179494d),

new NpgsqlTypes.NpgsqlLine(a: 0.6230691191149946d, b: 0.6421350132669393d, c: 0.2591755154295573d),

new NpgsqlTypes.NpgsqlLine(a: 0.284214063978114d, b: 0.42055782459666247d, c: 0.4230265799247275d),

new NpgsqlTypes.NpgsqlLine(a: 0.2294933978523651d, b: 0.8434657220550107d, c: 0.1364803149185917d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlLinelineArray1MI 
                    {
                        Id = 671378680
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 214898413,
                    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7273918164372143d, b: 0.3711769692436181d, c: 0.7468659136792664d),

new NpgsqlTypes.NpgsqlLine(a: 0.8155250372031967d, b: 0.5364157660240247d, c: 0.2587745327315204d),

new NpgsqlTypes.NpgsqlLine(a: 0.8823774478354753d, b: 0.24032876435579376d, c: 0.9187231882533503d),

new NpgsqlTypes.NpgsqlLine(a: 0.2761563267007917d, b: 0.8609521972165307d, c: 0.014350256291767893d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7060914743005817d, b: 0.29942700622480667d, c: 0.38464564338188945d),

new NpgsqlTypes.NpgsqlLine(a: 0.456801666295529d, b: 0.2750050419905442d, c: 0.6523990372650718d),

new NpgsqlTypes.NpgsqlLine(a: 0.593068234761201d, b: 0.986042625015402d, c: 0.7722918655162653d),

new NpgsqlTypes.NpgsqlLine(a: 0.8257270425360131d, b: 0.9234733383976109d, c: 0.16399605960296715d),

},

                    ModelInner = new NpgsqlLinelineArray1MI 
                    {
                        Id = 160844459
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 232426060,
                    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7754569347332767d, b: 0.7449423603392903d, c: 0.7275357910733291d),

new NpgsqlTypes.NpgsqlLine(a: 0.9072872865290874d, b: 0.5188651109794405d, c: 0.49767196437474315d),

new NpgsqlTypes.NpgsqlLine(a: 0.7613773478086597d, b: 0.8726134777514618d, c: 0.7249287737318102d),

new NpgsqlTypes.NpgsqlLine(a: 0.31979325488547383d, b: 0.21963013317369884d, c: 0.995747479981123d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5136334997132156d, b: 0.4481836733144653d, c: 0.5566013930940901d),

new NpgsqlTypes.NpgsqlLine(a: 0.2628604279970359d, b: 0.34706683348460354d, c: 0.8618758810041756d),

new NpgsqlTypes.NpgsqlLine(a: 0.9066993846202163d, b: 0.9919335952888788d, c: 0.16647553451680086d),

new NpgsqlTypes.NpgsqlLine(a: 0.8084713734948656d, b: 0.9105928653749232d, c: 0.5871692331069964d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 287773256,
                    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5468129373528992d, b: 0.4550697398151482d, c: 0.9323204190693627d),

new NpgsqlTypes.NpgsqlLine(a: 0.09290076953581794d, b: 0.06513797114322906d, c: 0.01453530584939322d),

new NpgsqlTypes.NpgsqlLine(a: 0.06819515445977387d, b: 0.13776512554356624d, c: 0.5971045649241554d),

new NpgsqlTypes.NpgsqlLine(a: 0.17602847632288898d, b: 0.8583377493377162d, c: 0.5319193518068348d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlLinelineArray1MI 
                    {
                        Id = 2000087272
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 385864550,
                    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22975102280111437d, b: 0.9248487581270293d, c: 0.13680981887715193d),

new NpgsqlTypes.NpgsqlLine(a: 0.09251582159332017d, b: 0.5284902712490177d, c: 0.5030244379828798d),

new NpgsqlTypes.NpgsqlLine(a: 0.3316636973424488d, b: 0.125908586516723d, c: 0.1307901665228316d),

new NpgsqlTypes.NpgsqlLine(a: 0.4488357278586823d, b: 0.4939460007710509d, c: 0.1486125807477222d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4793632894446783d, b: 0.7460924351194599d, c: 0.8333281971866928d),

new NpgsqlTypes.NpgsqlLine(a: 0.9911204719862435d, b: 0.02386428262012663d, c: 0.1749191984110413d),

new NpgsqlTypes.NpgsqlLine(a: 0.9855596015822274d, b: 0.652336551342683d, c: 0.13320036109805444d),

new NpgsqlTypes.NpgsqlLine(a: 0.2704642620419001d, b: 0.25815455585325764d, c: 0.781691467105331d),

},

                    ModelInner = new NpgsqlLinelineArray1MI 
                    {
                        Id = 507016837
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 425879955,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7120720914880876d, b: 0.12018496532744738d, c: 0.23458035596972604d),

new NpgsqlTypes.NpgsqlLine(a: 0.8966943482850258d, b: 0.35901938172619774d, c: 0.5153333646331681d),

new NpgsqlTypes.NpgsqlLine(a: 0.772529205234202d, b: 0.3302141544038909d, c: 0.49860223574471696d),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 447065450,
                    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6636554004535458d, b: 0.4052905058278198d, c: 0.17999403534412883d),

new NpgsqlTypes.NpgsqlLine(a: 0.4929643299593621d, b: 0.04102771738828992d, c: 0.8758588440576921d),

new NpgsqlTypes.NpgsqlLine(a: 0.9843591359807438d, b: 0.9486545770421181d, c: 0.23810538982780194d),

new NpgsqlTypes.NpgsqlLine(a: 0.0373504814930844d, b: 0.29650224807426506d, c: 0.6527517869517908d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlLinelineArray1MI 
                    {
                        Id = 1935239880
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 776647699,
                    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8841755970938628d, b: 0.039993263617271846d, c: 0.2425222413816407d),

new NpgsqlTypes.NpgsqlLine(a: 0.3162669055857611d, b: 0.1360654949714053d, c: 0.585066125260232d),

new NpgsqlTypes.NpgsqlLine(a: 0.23614085233198578d, b: 0.9624524908146396d, c: 0.8036122013629919d),

new NpgsqlTypes.NpgsqlLine(a: 0.9594786748108928d, b: 0.3334512033062713d, c: 0.8626799508985245d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7692177568154062d, b: 0.8045212370680859d, c: 0.347836807601842d),

new NpgsqlTypes.NpgsqlLine(a: 0.8596806867272218d, b: 0.42225206488490163d, c: 0.2626771759427945d),

new NpgsqlTypes.NpgsqlLine(a: 0.6334601490046422d, b: 0.5508277640730257d, c: 0.9702039181027914d),

new NpgsqlTypes.NpgsqlLine(a: 0.7862671596820799d, b: 0.6148121550149941d, c: 0.10467782441316142d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 920410273,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7950181430955406d, b: 0.3848051391253504d, c: 0.1572657802170856d),

new NpgsqlTypes.NpgsqlLine(a: 0.6062151918599252d, b: 0.06062326101597226d, c: 0.14777044879318857d),

new NpgsqlTypes.NpgsqlLine(a: 0.7408182398935058d, b: 0.6661433504932776d, c: 0.15722709569280902d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2482561889064241d, b: 0.768360521777252d, c: 0.24033198573060877d),

new NpgsqlTypes.NpgsqlLine(a: 0.6078828832971318d, b: 0.25910942482320465d, c: 0.7624300130707319d),

new NpgsqlTypes.NpgsqlLine(a: 0.551230062109523d, b: 0.5951997473266207d, c: 0.05557568229198884d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 929385902,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8285395037487209d, b: 0.25070273066629d, c: 0.2500673109161923d),

new NpgsqlTypes.NpgsqlLine(a: 0.9942717530143405d, b: 0.21539215026712022d, c: 0.20269945939501077d),

new NpgsqlTypes.NpgsqlLine(a: 0.7979702358088475d, b: 0.0037115614378556705d, c: 0.8843432168677479d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1456202870910711d, b: 0.06772665910903597d, c: 0.691750610472359d),

new NpgsqlTypes.NpgsqlLine(a: 0.765757989281042d, b: 0.32982835634782004d, c: 0.8913701807765988d),

new NpgsqlTypes.NpgsqlLine(a: 0.052240732409688406d, b: 0.618262798295761d, c: 0.8474290495942781d),

new NpgsqlTypes.NpgsqlLine(a: 0.3584922315949717d, b: 0.520574773115294d, c: 0.8310230234204736d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 939691488,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15928813769803307d, b: 0.5335096410959914d, c: 0.9693141891385088d),

new NpgsqlTypes.NpgsqlLine(a: 0.9448241901930845d, b: 0.6287076527827521d, c: 0.6660617468801671d),

new NpgsqlTypes.NpgsqlLine(a: 0.30712778702622445d, b: 0.324942912367581d, c: 0.9500282198259326d),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 940484658,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8457530794410952d, b: 0.07468146527745967d, c: 0.6058450234777081d),

new NpgsqlTypes.NpgsqlLine(a: 0.43907623012482566d, b: 0.4163533057091461d, c: 0.7083053151407345d),

new NpgsqlTypes.NpgsqlLine(a: 0.6460729456777172d, b: 0.3996032448892458d, c: 0.32058136990645736d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5056133907420888d, b: 0.687789482585691d, c: 0.5736898296981361d),

new NpgsqlTypes.NpgsqlLine(a: 0.6165837793609097d, b: 0.3896094649555947d, c: 0.782529168193896d),

new NpgsqlTypes.NpgsqlLine(a: 0.19522061405511182d, b: 0.49515141325692447d, c: 0.8154303350690599d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 956171576,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6305558129660189d, b: 0.5463622939629917d, c: 0.401891977997777d),

new NpgsqlTypes.NpgsqlLine(a: 0.3662230087345998d, b: 0.4302679455886196d, c: 0.9631184941583132d),

new NpgsqlTypes.NpgsqlLine(a: 0.3634906094993412d, b: 0.18046820180120404d, c: 0.5193725822662353d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48533853922222536d, b: 0.7781157007327932d, c: 0.20671476643143427d),

new NpgsqlTypes.NpgsqlLine(a: 0.7321919326621603d, b: 0.7704043405190548d, c: 0.5508846640658778d),

new NpgsqlTypes.NpgsqlLine(a: 0.5796306726535371d, b: 0.3621536966457104d, c: 0.3554092618887771d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 1049476690,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1703167002028123d, b: 0.06899134909065618d, c: 0.39632655876575884d),

new NpgsqlTypes.NpgsqlLine(a: 0.9436521110809849d, b: 0.2716102490692832d, c: 0.21807972083943694d),

new NpgsqlTypes.NpgsqlLine(a: 0.07510391898176405d, b: 0.4622700624960824d, c: 0.6916474126671974d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3434566231012316d, b: 0.6092872970160005d, c: 0.8285200623737458d),

new NpgsqlTypes.NpgsqlLine(a: 0.438620087459067d, b: 0.42784452615069857d, c: 0.43791996431227087d),

new NpgsqlTypes.NpgsqlLine(a: 0.13822472685663223d, b: 0.3567687904324768d, c: 0.5713362361619454d),

new NpgsqlTypes.NpgsqlLine(a: 0.4225842002023096d, b: 0.13041963778907273d, c: 0.537431949671262d),

},

                    ModelInner = new NpgsqlLinelineArray1MI 
                    {
                        Id = 259689541
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(24431063));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7432562260700321d, b: 0.9027051106351455d, c: 0.20935776301702913d),

new NpgsqlTypes.NpgsqlLine(a: 0.06877648068052133d, b: 0.4638520424251973d, c: 0.8977581074629934d),

new NpgsqlTypes.NpgsqlLine(a: 0.19824889810271595d, b: 0.101805635004653d, c: 0.6376796129171594d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.25692356453649523d, b: 0.8249956321761069d, c: 0.7485760418256393d),

new NpgsqlTypes.NpgsqlLine(a: 0.5205543536927003d, b: 0.26409313743898866d, c: 0.11834223656249432d),

new NpgsqlTypes.NpgsqlLine(a: 0.12852097087774939d, b: 0.110468841038458d, c: 0.15781368742463253d),

new NpgsqlTypes.NpgsqlLine(a: 0.5056691167374713d, b: 0.17475361978672044d, c: 0.4301177356479713d),

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
                Assert.That(model.Id, Is.EqualTo(88466632));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24038691940074952d, b: 0.4574071819075469d, c: 0.029018693781179494d),

new NpgsqlTypes.NpgsqlLine(a: 0.6230691191149946d, b: 0.6421350132669393d, c: 0.2591755154295573d),

new NpgsqlTypes.NpgsqlLine(a: 0.284214063978114d, b: 0.42055782459666247d, c: 0.4230265799247275d),

new NpgsqlTypes.NpgsqlLine(a: 0.2294933978523651d, b: 0.8434657220550107d, c: 0.1364803149185917d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(671378680));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.579485378096583d, b: 0.7644192687968542d, c: 0.38803543767659376d),

new NpgsqlTypes.NpgsqlLine(a: 0.9272224559192928d, b: 0.04309922869802718d, c: 0.1084146589578524d),

new NpgsqlTypes.NpgsqlLine(a: 0.6194396921461146d, b: 0.3135327751395446d, c: 0.47728859432318693d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22238461731837955d, b: 0.8832575247518029d, c: 0.5267192016109244d),

new NpgsqlTypes.NpgsqlLine(a: 0.2456814921559901d, b: 0.12396858431218405d, c: 0.7758983059785806d),

new NpgsqlTypes.NpgsqlLine(a: 0.8010355013907535d, b: 0.10724380078506457d, c: 0.8516226142927568d),

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
                Assert.That(model.Id, Is.EqualTo(214898413));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7273918164372143d, b: 0.3711769692436181d, c: 0.7468659136792664d),

new NpgsqlTypes.NpgsqlLine(a: 0.8155250372031967d, b: 0.5364157660240247d, c: 0.2587745327315204d),

new NpgsqlTypes.NpgsqlLine(a: 0.8823774478354753d, b: 0.24032876435579376d, c: 0.9187231882533503d),

new NpgsqlTypes.NpgsqlLine(a: 0.2761563267007917d, b: 0.8609521972165307d, c: 0.014350256291767893d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7060914743005817d, b: 0.29942700622480667d, c: 0.38464564338188945d),

new NpgsqlTypes.NpgsqlLine(a: 0.456801666295529d, b: 0.2750050419905442d, c: 0.6523990372650718d),

new NpgsqlTypes.NpgsqlLine(a: 0.593068234761201d, b: 0.986042625015402d, c: 0.7722918655162653d),

new NpgsqlTypes.NpgsqlLine(a: 0.8257270425360131d, b: 0.9234733383976109d, c: 0.16399605960296715d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(160844459));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.49742066568592347d, b: 0.13045995730850435d, c: 0.3240701079822569d),

new NpgsqlTypes.NpgsqlLine(a: 0.4230136983146885d, b: 0.4758823758243249d, c: 0.7245296150407883d),

new NpgsqlTypes.NpgsqlLine(a: 0.902525000709505d, b: 0.3096633545847971d, c: 0.7195095860492445d),

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
                Assert.That(model.Id, Is.EqualTo(232426060));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7754569347332767d, b: 0.7449423603392903d, c: 0.7275357910733291d),

new NpgsqlTypes.NpgsqlLine(a: 0.9072872865290874d, b: 0.5188651109794405d, c: 0.49767196437474315d),

new NpgsqlTypes.NpgsqlLine(a: 0.7613773478086597d, b: 0.8726134777514618d, c: 0.7249287737318102d),

new NpgsqlTypes.NpgsqlLine(a: 0.31979325488547383d, b: 0.21963013317369884d, c: 0.995747479981123d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5136334997132156d, b: 0.4481836733144653d, c: 0.5566013930940901d),

new NpgsqlTypes.NpgsqlLine(a: 0.2628604279970359d, b: 0.34706683348460354d, c: 0.8618758810041756d),

new NpgsqlTypes.NpgsqlLine(a: 0.9066993846202163d, b: 0.9919335952888788d, c: 0.16647553451680086d),

new NpgsqlTypes.NpgsqlLine(a: 0.8084713734948656d, b: 0.9105928653749232d, c: 0.5871692331069964d),

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

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(287773256));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5468129373528992d, b: 0.4550697398151482d, c: 0.9323204190693627d),

new NpgsqlTypes.NpgsqlLine(a: 0.09290076953581794d, b: 0.06513797114322906d, c: 0.01453530584939322d),

new NpgsqlTypes.NpgsqlLine(a: 0.06819515445977387d, b: 0.13776512554356624d, c: 0.5971045649241554d),

new NpgsqlTypes.NpgsqlLine(a: 0.17602847632288898d, b: 0.8583377493377162d, c: 0.5319193518068348d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2000087272));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5174417835536576d, b: 0.9550151039410834d, c: 0.94465021980697d),

new NpgsqlTypes.NpgsqlLine(a: 0.023498567205728516d, b: 0.14704570142511664d, c: 0.5436176118381062d),

new NpgsqlTypes.NpgsqlLine(a: 0.6410825125912296d, b: 0.1638519482392854d, c: 0.07442290044208977d),

new NpgsqlTypes.NpgsqlLine(a: 0.5684954410076702d, b: 0.9517870324925599d, c: 0.7913121037671743d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5546781844769255d, b: 0.3295435210405563d, c: 0.10332785525555d),

new NpgsqlTypes.NpgsqlLine(a: 0.8619184029547027d, b: 0.6893143841340763d, c: 0.6057919377815917d),

new NpgsqlTypes.NpgsqlLine(a: 0.6918049340506819d, b: 0.29564467871458977d, c: 0.373851052320022d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590711543927416d, b: 0.782456230485786d, c: 0.0557514543823312d),

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
                Assert.That(model.Id, Is.EqualTo(385864550));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22975102280111437d, b: 0.9248487581270293d, c: 0.13680981887715193d),

new NpgsqlTypes.NpgsqlLine(a: 0.09251582159332017d, b: 0.5284902712490177d, c: 0.5030244379828798d),

new NpgsqlTypes.NpgsqlLine(a: 0.3316636973424488d, b: 0.125908586516723d, c: 0.1307901665228316d),

new NpgsqlTypes.NpgsqlLine(a: 0.4488357278586823d, b: 0.4939460007710509d, c: 0.1486125807477222d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4793632894446783d, b: 0.7460924351194599d, c: 0.8333281971866928d),

new NpgsqlTypes.NpgsqlLine(a: 0.9911204719862435d, b: 0.02386428262012663d, c: 0.1749191984110413d),

new NpgsqlTypes.NpgsqlLine(a: 0.9855596015822274d, b: 0.652336551342683d, c: 0.13320036109805444d),

new NpgsqlTypes.NpgsqlLine(a: 0.2704642620419001d, b: 0.25815455585325764d, c: 0.781691467105331d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(507016837));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6329641939546133d, b: 0.7713358064075255d, c: 0.7091675230581173d),

new NpgsqlTypes.NpgsqlLine(a: 0.6401104534145889d, b: 0.4461488045009705d, c: 0.8050604324576476d),

new NpgsqlTypes.NpgsqlLine(a: 0.718200194405203d, b: 0.43497844061299695d, c: 0.8863292600245054d),

new NpgsqlTypes.NpgsqlLine(a: 0.6409377372303063d, b: 0.6727026439221405d, c: 0.709162570856183d),

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
                Assert.That(model.Id, Is.EqualTo(425879955));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7120720914880876d, b: 0.12018496532744738d, c: 0.23458035596972604d),

new NpgsqlTypes.NpgsqlLine(a: 0.8966943482850258d, b: 0.35901938172619774d, c: 0.5153333646331681d),

new NpgsqlTypes.NpgsqlLine(a: 0.772529205234202d, b: 0.3302141544038909d, c: 0.49860223574471696d),

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
                Assert.That(model.Id, Is.EqualTo(447065450));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6636554004535458d, b: 0.4052905058278198d, c: 0.17999403534412883d),

new NpgsqlTypes.NpgsqlLine(a: 0.4929643299593621d, b: 0.04102771738828992d, c: 0.8758588440576921d),

new NpgsqlTypes.NpgsqlLine(a: 0.9843591359807438d, b: 0.9486545770421181d, c: 0.23810538982780194d),

new NpgsqlTypes.NpgsqlLine(a: 0.0373504814930844d, b: 0.29650224807426506d, c: 0.6527517869517908d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1935239880));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5125009420178407d, b: 0.13553866813087467d, c: 0.6573124881706722d),

new NpgsqlTypes.NpgsqlLine(a: 0.9315668534985179d, b: 0.031339976871202935d, c: 0.7319776155987312d),

new NpgsqlTypes.NpgsqlLine(a: 0.5913519522327184d, b: 0.688194613219936d, c: 0.7487303543444555d),

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
                Assert.That(model.Id, Is.EqualTo(776647699));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8841755970938628d, b: 0.039993263617271846d, c: 0.2425222413816407d),

new NpgsqlTypes.NpgsqlLine(a: 0.3162669055857611d, b: 0.1360654949714053d, c: 0.585066125260232d),

new NpgsqlTypes.NpgsqlLine(a: 0.23614085233198578d, b: 0.9624524908146396d, c: 0.8036122013629919d),

new NpgsqlTypes.NpgsqlLine(a: 0.9594786748108928d, b: 0.3334512033062713d, c: 0.8626799508985245d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7692177568154062d, b: 0.8045212370680859d, c: 0.347836807601842d),

new NpgsqlTypes.NpgsqlLine(a: 0.8596806867272218d, b: 0.42225206488490163d, c: 0.2626771759427945d),

new NpgsqlTypes.NpgsqlLine(a: 0.6334601490046422d, b: 0.5508277640730257d, c: 0.9702039181027914d),

new NpgsqlTypes.NpgsqlLine(a: 0.7862671596820799d, b: 0.6148121550149941d, c: 0.10467782441316142d),

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
                Assert.That(model.Id, Is.EqualTo(920410273));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7950181430955406d, b: 0.3848051391253504d, c: 0.1572657802170856d),

new NpgsqlTypes.NpgsqlLine(a: 0.6062151918599252d, b: 0.06062326101597226d, c: 0.14777044879318857d),

new NpgsqlTypes.NpgsqlLine(a: 0.7408182398935058d, b: 0.6661433504932776d, c: 0.15722709569280902d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2482561889064241d, b: 0.768360521777252d, c: 0.24033198573060877d),

new NpgsqlTypes.NpgsqlLine(a: 0.6078828832971318d, b: 0.25910942482320465d, c: 0.7624300130707319d),

new NpgsqlTypes.NpgsqlLine(a: 0.551230062109523d, b: 0.5951997473266207d, c: 0.05557568229198884d),

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
                Assert.That(model.Id, Is.EqualTo(929385902));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8285395037487209d, b: 0.25070273066629d, c: 0.2500673109161923d),

new NpgsqlTypes.NpgsqlLine(a: 0.9942717530143405d, b: 0.21539215026712022d, c: 0.20269945939501077d),

new NpgsqlTypes.NpgsqlLine(a: 0.7979702358088475d, b: 0.0037115614378556705d, c: 0.8843432168677479d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1456202870910711d, b: 0.06772665910903597d, c: 0.691750610472359d),

new NpgsqlTypes.NpgsqlLine(a: 0.765757989281042d, b: 0.32982835634782004d, c: 0.8913701807765988d),

new NpgsqlTypes.NpgsqlLine(a: 0.052240732409688406d, b: 0.618262798295761d, c: 0.8474290495942781d),

new NpgsqlTypes.NpgsqlLine(a: 0.3584922315949717d, b: 0.520574773115294d, c: 0.8310230234204736d),

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
                Assert.That(model.Id, Is.EqualTo(939691488));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15928813769803307d, b: 0.5335096410959914d, c: 0.9693141891385088d),

new NpgsqlTypes.NpgsqlLine(a: 0.9448241901930845d, b: 0.6287076527827521d, c: 0.6660617468801671d),

new NpgsqlTypes.NpgsqlLine(a: 0.30712778702622445d, b: 0.324942912367581d, c: 0.9500282198259326d),

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
                Assert.That(model.Id, Is.EqualTo(940484658));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8457530794410952d, b: 0.07468146527745967d, c: 0.6058450234777081d),

new NpgsqlTypes.NpgsqlLine(a: 0.43907623012482566d, b: 0.4163533057091461d, c: 0.7083053151407345d),

new NpgsqlTypes.NpgsqlLine(a: 0.6460729456777172d, b: 0.3996032448892458d, c: 0.32058136990645736d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5056133907420888d, b: 0.687789482585691d, c: 0.5736898296981361d),

new NpgsqlTypes.NpgsqlLine(a: 0.6165837793609097d, b: 0.3896094649555947d, c: 0.782529168193896d),

new NpgsqlTypes.NpgsqlLine(a: 0.19522061405511182d, b: 0.49515141325692447d, c: 0.8154303350690599d),

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
                Assert.That(model.Id, Is.EqualTo(956171576));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6305558129660189d, b: 0.5463622939629917d, c: 0.401891977997777d),

new NpgsqlTypes.NpgsqlLine(a: 0.3662230087345998d, b: 0.4302679455886196d, c: 0.9631184941583132d),

new NpgsqlTypes.NpgsqlLine(a: 0.3634906094993412d, b: 0.18046820180120404d, c: 0.5193725822662353d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48533853922222536d, b: 0.7781157007327932d, c: 0.20671476643143427d),

new NpgsqlTypes.NpgsqlLine(a: 0.7321919326621603d, b: 0.7704043405190548d, c: 0.5508846640658778d),

new NpgsqlTypes.NpgsqlLine(a: 0.5796306726535371d, b: 0.3621536966457104d, c: 0.3554092618887771d),

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
                Assert.That(model.Id, Is.EqualTo(1049476690));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1703167002028123d, b: 0.06899134909065618d, c: 0.39632655876575884d),

new NpgsqlTypes.NpgsqlLine(a: 0.9436521110809849d, b: 0.2716102490692832d, c: 0.21807972083943694d),

new NpgsqlTypes.NpgsqlLine(a: 0.07510391898176405d, b: 0.4622700624960824d, c: 0.6916474126671974d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3434566231012316d, b: 0.6092872970160005d, c: 0.8285200623737458d),

new NpgsqlTypes.NpgsqlLine(a: 0.438620087459067d, b: 0.42784452615069857d, c: 0.43791996431227087d),

new NpgsqlTypes.NpgsqlLine(a: 0.13822472685663223d, b: 0.3567687904324768d, c: 0.5713362361619454d),

new NpgsqlTypes.NpgsqlLine(a: 0.4225842002023096d, b: 0.13041963778907273d, c: 0.537431949671262d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(259689541));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16915141278580792d, b: 0.5107686791340034d, c: 0.6489920882506348d),

new NpgsqlTypes.NpgsqlLine(a: 0.030879513236027d, b: 0.6401283771223818d, c: 0.4904762444562075d),

new NpgsqlTypes.NpgsqlLine(a: 0.16124954101586042d, b: 0.7102870300472969d, c: 0.9978682907813775d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3413197342637151d, b: 0.3564754218301692d, c: 0.16698356005321802d),

new NpgsqlTypes.NpgsqlLine(a: 0.24996465538547474d, b: 0.6936235099874405d, c: 0.00768766971096424d),

new NpgsqlTypes.NpgsqlLine(a: 0.9713834412198872d, b: 0.1937685310996965d, c: 0.5638524218711839d),

new NpgsqlTypes.NpgsqlLine(a: 0.20790035052620326d, b: 0.7280555648340241d, c: 0.7150389111804211d),

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
                new NpgsqlLinelineArray1M
                {
                    Id = 1169283916,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6136867588329713d, b: 0.8476721243007673d, c: 0.2920466838690219d),

new NpgsqlTypes.NpgsqlLine(a: 0.5632572533709046d, b: 0.8580393386665631d, c: 0.29067186403759726d),

new NpgsqlTypes.NpgsqlLine(a: 0.05864985939465561d, b: 0.06933376015004311d, c: 0.2622230618531959d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3083889075922114d, b: 0.40504233141015844d, c: 0.7282625593772889d),

new NpgsqlTypes.NpgsqlLine(a: 0.9760389595620657d, b: 0.5432046524856411d, c: 0.4805721407516501d),

new NpgsqlTypes.NpgsqlLine(a: 0.226094370846618d, b: 0.30929816503923757d, c: 0.749788108094253d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 1247961184,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588334999708729d, b: 0.5781258655739143d, c: 0.4951203893647069d),

new NpgsqlTypes.NpgsqlLine(a: 0.206651781249944d, b: 0.9214488824097644d, c: 0.7102197735978709d),

new NpgsqlTypes.NpgsqlLine(a: 0.8293873017859008d, b: 0.4197388618664637d, c: 0.7538628331143343d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9886122302398814d, b: 0.09733443476141157d, c: 0.8828756753279827d),

new NpgsqlTypes.NpgsqlLine(a: 0.4191781730328399d, b: 0.8360940579259326d, c: 0.3115604346093266d),

new NpgsqlTypes.NpgsqlLine(a: 0.03123256692948395d, b: 0.4210178852779579d, c: 0.7083559364281564d),

new NpgsqlTypes.NpgsqlLine(a: 0.10193811062121638d, b: 0.7865607707379441d, c: 0.5102014504618864d),

},

                    ModelInner = new NpgsqlLinelineArray1MI 
                    {
                        Id = 313349652
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 1251267268,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.27064576558959075d, b: 0.24611103650290955d, c: 0.04928435530376152d),

new NpgsqlTypes.NpgsqlLine(a: 0.5382620257248645d, b: 0.586731968734226d, c: 0.9110741668368397d),

new NpgsqlTypes.NpgsqlLine(a: 0.8386954216871374d, b: 0.14045527908308764d, c: 0.5300328684198944d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7572326327773035d, b: 0.10039993499818312d, c: 0.17339739029118428d),

new NpgsqlTypes.NpgsqlLine(a: 0.9566618331567527d, b: 0.14668861402647748d, c: 0.7767711369985796d),

new NpgsqlTypes.NpgsqlLine(a: 0.932727244163919d, b: 0.12159065636952726d, c: 0.1704609096711438d),

new NpgsqlTypes.NpgsqlLine(a: 0.5792460825794749d, b: 0.985437582839235d, c: 0.557473090399633d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 1276251566,
                    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4808529939808879d, b: 0.365247596328651d, c: 0.17939866902766977d),

new NpgsqlTypes.NpgsqlLine(a: 0.12809708913748585d, b: 0.18821025600986407d, c: 0.9740037535570704d),

new NpgsqlTypes.NpgsqlLine(a: 0.7729579560840041d, b: 0.5283959837814016d, c: 0.3246873097765165d),

new NpgsqlTypes.NpgsqlLine(a: 0.5804554841359071d, b: 0.7951318743812129d, c: 0.9533437460862759d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07357632206959641d, b: 0.11099061080365447d, c: 0.47576723756466854d),

new NpgsqlTypes.NpgsqlLine(a: 0.9051522311200175d, b: 0.6041352781626989d, c: 0.962846313750425d),

new NpgsqlTypes.NpgsqlLine(a: 0.7230697163609032d, b: 0.35996997662147945d, c: 0.2719627850842049d),

new NpgsqlTypes.NpgsqlLine(a: 0.039972657007877d, b: 0.6660692046588974d, c: 0.8074219604808613d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 1278639929,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8637991908928382d, b: 0.7989476928355281d, c: 0.047074497669961635d),

new NpgsqlTypes.NpgsqlLine(a: 0.24284327761860214d, b: 0.034845279321367495d, c: 0.8243144068858446d),

new NpgsqlTypes.NpgsqlLine(a: 0.2705173386529084d, b: 0.37759514414776285d, c: 0.003784057263189533d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5464646368268954d, b: 0.1698011067851829d, c: 0.4811896051504386d),

new NpgsqlTypes.NpgsqlLine(a: 0.3264558304845737d, b: 0.09741548986796533d, c: 0.35078408755418944d),

new NpgsqlTypes.NpgsqlLine(a: 0.1253849539183054d, b: 0.9184504405667023d, c: 0.6244095303662431d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 1352296160,
                    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6961581521563707d, b: 0.2870425810465653d, c: 0.022813771410836625d),

new NpgsqlTypes.NpgsqlLine(a: 0.9289180434806266d, b: 0.10310192777053839d, c: 0.4974840036652155d),

new NpgsqlTypes.NpgsqlLine(a: 0.9742618124298718d, b: 0.666155889593685d, c: 0.9108800941033853d),

new NpgsqlTypes.NpgsqlLine(a: 0.4076993728994177d, b: 0.9237619110159688d, c: 0.16349574316883708d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.40245830157937157d, b: 0.4425237993192568d, c: 0.3605907953188545d),

new NpgsqlTypes.NpgsqlLine(a: 0.3025387755185438d, b: 0.16175616826033246d, c: 0.08369914886846197d),

new NpgsqlTypes.NpgsqlLine(a: 0.7932786053551402d, b: 0.4757892941852452d, c: 0.35215963103511483d),

},

                    ModelInner = new NpgsqlLinelineArray1MI 
                    {
                        Id = 2052209240
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 1422030401,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5508950376990435d, b: 0.1842011543506923d, c: 0.7200839172656331d),

new NpgsqlTypes.NpgsqlLine(a: 0.08098131741133519d, b: 0.2512744482896645d, c: 0.4419893154281408d),

new NpgsqlTypes.NpgsqlLine(a: 0.7183180834237055d, b: 0.3821225061156569d, c: 0.320010478004808d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.605461690855222d, b: 0.5098249599693536d, c: 0.049446338505273246d),

new NpgsqlTypes.NpgsqlLine(a: 0.6383133050473475d, b: 0.5385834180776717d, c: 0.2612256906158803d),

new NpgsqlTypes.NpgsqlLine(a: 0.2259744218921168d, b: 0.0504022254415285d, c: 0.5085817881315488d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 1441068318,
                    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04431673188157559d, b: 0.7118895502319815d, c: 0.8045459394080527d),

new NpgsqlTypes.NpgsqlLine(a: 0.41883883343441664d, b: 0.0856133325697227d, c: 0.45940150990219364d),

new NpgsqlTypes.NpgsqlLine(a: 0.3845455332415372d, b: 0.5278908004707358d, c: 0.45211852173959755d),

new NpgsqlTypes.NpgsqlLine(a: 0.707344526938849d, b: 0.2664835051263448d, c: 0.8012907013628192d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5167014945187821d, b: 0.2318523474732329d, c: 0.0766480392056259d),

new NpgsqlTypes.NpgsqlLine(a: 0.6239339834043951d, b: 0.4407650281616141d, c: 0.07711199216030074d),

new NpgsqlTypes.NpgsqlLine(a: 0.7330247230488705d, b: 0.06195929907587139d, c: 0.1736910797965654d),

new NpgsqlTypes.NpgsqlLine(a: 0.5060985759956755d, b: 0.12918142066992122d, c: 0.3598502037154421d),

},

                    ModelInner = new NpgsqlLinelineArray1MI 
                    {
                        Id = 1349638635
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 1485177216,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7620135774845544d, b: 0.72234986247445d, c: 0.7900958363555012d),

new NpgsqlTypes.NpgsqlLine(a: 0.5982892074823093d, b: 0.9157569165822279d, c: 0.5913666560112503d),

new NpgsqlTypes.NpgsqlLine(a: 0.3694255096703286d, b: 0.43689654039349735d, c: 0.27488642071951885d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlLinelineArray1MI 
                    {
                        Id = 1888587968
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 1612037280,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9755688560619167d, b: 0.7517347444178538d, c: 0.4433097656621017d),

new NpgsqlTypes.NpgsqlLine(a: 0.27642151559126893d, b: 0.49560032188535075d, c: 0.4017019854911661d),

new NpgsqlTypes.NpgsqlLine(a: 0.48234378585453686d, b: 0.5838608048706788d, c: 0.45264440736135125d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlLinelineArray1MI 
                    {
                        Id = 1803941428
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 1694903385,
                    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5133551130062282d, b: 0.5981369379522861d, c: 0.5856516805262975d),

new NpgsqlTypes.NpgsqlLine(a: 0.4556255479239121d, b: 0.059243842569019045d, c: 0.18272228811839042d),

new NpgsqlTypes.NpgsqlLine(a: 0.8085308768004308d, b: 0.8348590541320315d, c: 0.5895099353964641d),

new NpgsqlTypes.NpgsqlLine(a: 0.24149968696186774d, b: 0.35557480082622506d, c: 0.5451461752136405d),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 1708194464,
                    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21378574042766885d, b: 0.22474127876321393d, c: 0.01286635194062602d),

new NpgsqlTypes.NpgsqlLine(a: 0.44720527497131246d, b: 0.83386820783986d, c: 0.47600740851603984d),

new NpgsqlTypes.NpgsqlLine(a: 0.9177345103701179d, b: 0.8135674766115204d, c: 0.23923291716083794d),

new NpgsqlTypes.NpgsqlLine(a: 0.9998743487003019d, b: 0.013427841900149451d, c: 0.9133209978570025d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlLinelineArray1MI 
                    {
                        Id = 871029693
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 1749272119,
                    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48465570613062037d, b: 0.4077570571696034d, c: 0.09124205112015671d),

new NpgsqlTypes.NpgsqlLine(a: 0.4905692123673753d, b: 0.09753381316271936d, c: 0.6219861110019185d),

new NpgsqlTypes.NpgsqlLine(a: 0.7715584772299492d, b: 0.7647042738214676d, c: 0.32981711302760286d),

new NpgsqlTypes.NpgsqlLine(a: 0.7826950107361046d, b: 0.6159017458991703d, c: 0.8761288210787351d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05854830086605134d, b: 0.4584727830793912d, c: 0.6485776355671607d),

new NpgsqlTypes.NpgsqlLine(a: 0.057402368952540694d, b: 0.814338567877536d, c: 0.36045674525095406d),

new NpgsqlTypes.NpgsqlLine(a: 0.4609921668504162d, b: 0.45446719793916357d, c: 0.6647833262693906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8421363107491464d, b: 0.8724917366553757d, c: 0.2954174236384989d),

},

                    ModelInner = new NpgsqlLinelineArray1MI 
                    {
                        Id = 1743101311
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 1750072079,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6509605768915644d, b: 0.2871280523199907d, c: 0.5279864073907687d),

new NpgsqlTypes.NpgsqlLine(a: 0.847627780191932d, b: 0.2863239370866939d, c: 0.39664595009550063d),

new NpgsqlTypes.NpgsqlLine(a: 0.06719070091173818d, b: 0.2998868113793318d, c: 0.8109899934095542d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30402634597868494d, b: 0.7741177113732105d, c: 0.4982697795456863d),

new NpgsqlTypes.NpgsqlLine(a: 0.22134239051678783d, b: 0.952989590947333d, c: 0.1976805178607327d),

new NpgsqlTypes.NpgsqlLine(a: 0.48019693876130953d, b: 0.8553553442730837d, c: 0.4578014530562905d),

new NpgsqlTypes.NpgsqlLine(a: 0.7948720279836796d, b: 0.6347165612507009d, c: 0.4915047790558922d),

},

                    ModelInner = new NpgsqlLinelineArray1MI 
                    {
                        Id = 681877477
                    }

                });

                importCollection.Add(
                new NpgsqlLinelineArray1M
                {
                    Id = 1765269457,
                    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4428210775962541d, b: 0.44628545865868685d, c: 0.7913435097925557d),

new NpgsqlTypes.NpgsqlLine(a: 0.26419018627718516d, b: 0.12166427922453704d, c: 0.11250832552770584d),

new NpgsqlTypes.NpgsqlLine(a: 0.20276585628171784d, b: 0.14489314174625478d, c: 0.5410582863519566d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlLinelineArray1MI 
                    {
                        Id = 699428708
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(24431063));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7432562260700321d, b: 0.9027051106351455d, c: 0.20935776301702913d),

new NpgsqlTypes.NpgsqlLine(a: 0.06877648068052133d, b: 0.4638520424251973d, c: 0.8977581074629934d),

new NpgsqlTypes.NpgsqlLine(a: 0.19824889810271595d, b: 0.101805635004653d, c: 0.6376796129171594d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.25692356453649523d, b: 0.8249956321761069d, c: 0.7485760418256393d),

new NpgsqlTypes.NpgsqlLine(a: 0.5205543536927003d, b: 0.26409313743898866d, c: 0.11834223656249432d),

new NpgsqlTypes.NpgsqlLine(a: 0.12852097087774939d, b: 0.110468841038458d, c: 0.15781368742463253d),

new NpgsqlTypes.NpgsqlLine(a: 0.5056691167374713d, b: 0.17475361978672044d, c: 0.4301177356479713d),

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
                Assert.That(model.Id, Is.EqualTo(88466632));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24038691940074952d, b: 0.4574071819075469d, c: 0.029018693781179494d),

new NpgsqlTypes.NpgsqlLine(a: 0.6230691191149946d, b: 0.6421350132669393d, c: 0.2591755154295573d),

new NpgsqlTypes.NpgsqlLine(a: 0.284214063978114d, b: 0.42055782459666247d, c: 0.4230265799247275d),

new NpgsqlTypes.NpgsqlLine(a: 0.2294933978523651d, b: 0.8434657220550107d, c: 0.1364803149185917d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(671378680));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.579485378096583d, b: 0.7644192687968542d, c: 0.38803543767659376d),

new NpgsqlTypes.NpgsqlLine(a: 0.9272224559192928d, b: 0.04309922869802718d, c: 0.1084146589578524d),

new NpgsqlTypes.NpgsqlLine(a: 0.6194396921461146d, b: 0.3135327751395446d, c: 0.47728859432318693d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22238461731837955d, b: 0.8832575247518029d, c: 0.5267192016109244d),

new NpgsqlTypes.NpgsqlLine(a: 0.2456814921559901d, b: 0.12396858431218405d, c: 0.7758983059785806d),

new NpgsqlTypes.NpgsqlLine(a: 0.8010355013907535d, b: 0.10724380078506457d, c: 0.8516226142927568d),

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
                Assert.That(model.Id, Is.EqualTo(214898413));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7273918164372143d, b: 0.3711769692436181d, c: 0.7468659136792664d),

new NpgsqlTypes.NpgsqlLine(a: 0.8155250372031967d, b: 0.5364157660240247d, c: 0.2587745327315204d),

new NpgsqlTypes.NpgsqlLine(a: 0.8823774478354753d, b: 0.24032876435579376d, c: 0.9187231882533503d),

new NpgsqlTypes.NpgsqlLine(a: 0.2761563267007917d, b: 0.8609521972165307d, c: 0.014350256291767893d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7060914743005817d, b: 0.29942700622480667d, c: 0.38464564338188945d),

new NpgsqlTypes.NpgsqlLine(a: 0.456801666295529d, b: 0.2750050419905442d, c: 0.6523990372650718d),

new NpgsqlTypes.NpgsqlLine(a: 0.593068234761201d, b: 0.986042625015402d, c: 0.7722918655162653d),

new NpgsqlTypes.NpgsqlLine(a: 0.8257270425360131d, b: 0.9234733383976109d, c: 0.16399605960296715d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(160844459));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.49742066568592347d, b: 0.13045995730850435d, c: 0.3240701079822569d),

new NpgsqlTypes.NpgsqlLine(a: 0.4230136983146885d, b: 0.4758823758243249d, c: 0.7245296150407883d),

new NpgsqlTypes.NpgsqlLine(a: 0.902525000709505d, b: 0.3096633545847971d, c: 0.7195095860492445d),

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
                Assert.That(model.Id, Is.EqualTo(232426060));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7754569347332767d, b: 0.7449423603392903d, c: 0.7275357910733291d),

new NpgsqlTypes.NpgsqlLine(a: 0.9072872865290874d, b: 0.5188651109794405d, c: 0.49767196437474315d),

new NpgsqlTypes.NpgsqlLine(a: 0.7613773478086597d, b: 0.8726134777514618d, c: 0.7249287737318102d),

new NpgsqlTypes.NpgsqlLine(a: 0.31979325488547383d, b: 0.21963013317369884d, c: 0.995747479981123d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5136334997132156d, b: 0.4481836733144653d, c: 0.5566013930940901d),

new NpgsqlTypes.NpgsqlLine(a: 0.2628604279970359d, b: 0.34706683348460354d, c: 0.8618758810041756d),

new NpgsqlTypes.NpgsqlLine(a: 0.9066993846202163d, b: 0.9919335952888788d, c: 0.16647553451680086d),

new NpgsqlTypes.NpgsqlLine(a: 0.8084713734948656d, b: 0.9105928653749232d, c: 0.5871692331069964d),

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


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(287773256));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5468129373528992d, b: 0.4550697398151482d, c: 0.9323204190693627d),

new NpgsqlTypes.NpgsqlLine(a: 0.09290076953581794d, b: 0.06513797114322906d, c: 0.01453530584939322d),

new NpgsqlTypes.NpgsqlLine(a: 0.06819515445977387d, b: 0.13776512554356624d, c: 0.5971045649241554d),

new NpgsqlTypes.NpgsqlLine(a: 0.17602847632288898d, b: 0.8583377493377162d, c: 0.5319193518068348d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2000087272));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5174417835536576d, b: 0.9550151039410834d, c: 0.94465021980697d),

new NpgsqlTypes.NpgsqlLine(a: 0.023498567205728516d, b: 0.14704570142511664d, c: 0.5436176118381062d),

new NpgsqlTypes.NpgsqlLine(a: 0.6410825125912296d, b: 0.1638519482392854d, c: 0.07442290044208977d),

new NpgsqlTypes.NpgsqlLine(a: 0.5684954410076702d, b: 0.9517870324925599d, c: 0.7913121037671743d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5546781844769255d, b: 0.3295435210405563d, c: 0.10332785525555d),

new NpgsqlTypes.NpgsqlLine(a: 0.8619184029547027d, b: 0.6893143841340763d, c: 0.6057919377815917d),

new NpgsqlTypes.NpgsqlLine(a: 0.6918049340506819d, b: 0.29564467871458977d, c: 0.373851052320022d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590711543927416d, b: 0.782456230485786d, c: 0.0557514543823312d),

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
                Assert.That(model.Id, Is.EqualTo(385864550));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22975102280111437d, b: 0.9248487581270293d, c: 0.13680981887715193d),

new NpgsqlTypes.NpgsqlLine(a: 0.09251582159332017d, b: 0.5284902712490177d, c: 0.5030244379828798d),

new NpgsqlTypes.NpgsqlLine(a: 0.3316636973424488d, b: 0.125908586516723d, c: 0.1307901665228316d),

new NpgsqlTypes.NpgsqlLine(a: 0.4488357278586823d, b: 0.4939460007710509d, c: 0.1486125807477222d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4793632894446783d, b: 0.7460924351194599d, c: 0.8333281971866928d),

new NpgsqlTypes.NpgsqlLine(a: 0.9911204719862435d, b: 0.02386428262012663d, c: 0.1749191984110413d),

new NpgsqlTypes.NpgsqlLine(a: 0.9855596015822274d, b: 0.652336551342683d, c: 0.13320036109805444d),

new NpgsqlTypes.NpgsqlLine(a: 0.2704642620419001d, b: 0.25815455585325764d, c: 0.781691467105331d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(507016837));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6329641939546133d, b: 0.7713358064075255d, c: 0.7091675230581173d),

new NpgsqlTypes.NpgsqlLine(a: 0.6401104534145889d, b: 0.4461488045009705d, c: 0.8050604324576476d),

new NpgsqlTypes.NpgsqlLine(a: 0.718200194405203d, b: 0.43497844061299695d, c: 0.8863292600245054d),

new NpgsqlTypes.NpgsqlLine(a: 0.6409377372303063d, b: 0.6727026439221405d, c: 0.709162570856183d),

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
                Assert.That(model.Id, Is.EqualTo(425879955));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7120720914880876d, b: 0.12018496532744738d, c: 0.23458035596972604d),

new NpgsqlTypes.NpgsqlLine(a: 0.8966943482850258d, b: 0.35901938172619774d, c: 0.5153333646331681d),

new NpgsqlTypes.NpgsqlLine(a: 0.772529205234202d, b: 0.3302141544038909d, c: 0.49860223574471696d),

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
                Assert.That(model.Id, Is.EqualTo(447065450));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6636554004535458d, b: 0.4052905058278198d, c: 0.17999403534412883d),

new NpgsqlTypes.NpgsqlLine(a: 0.4929643299593621d, b: 0.04102771738828992d, c: 0.8758588440576921d),

new NpgsqlTypes.NpgsqlLine(a: 0.9843591359807438d, b: 0.9486545770421181d, c: 0.23810538982780194d),

new NpgsqlTypes.NpgsqlLine(a: 0.0373504814930844d, b: 0.29650224807426506d, c: 0.6527517869517908d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1935239880));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5125009420178407d, b: 0.13553866813087467d, c: 0.6573124881706722d),

new NpgsqlTypes.NpgsqlLine(a: 0.9315668534985179d, b: 0.031339976871202935d, c: 0.7319776155987312d),

new NpgsqlTypes.NpgsqlLine(a: 0.5913519522327184d, b: 0.688194613219936d, c: 0.7487303543444555d),

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
                Assert.That(model.Id, Is.EqualTo(776647699));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8841755970938628d, b: 0.039993263617271846d, c: 0.2425222413816407d),

new NpgsqlTypes.NpgsqlLine(a: 0.3162669055857611d, b: 0.1360654949714053d, c: 0.585066125260232d),

new NpgsqlTypes.NpgsqlLine(a: 0.23614085233198578d, b: 0.9624524908146396d, c: 0.8036122013629919d),

new NpgsqlTypes.NpgsqlLine(a: 0.9594786748108928d, b: 0.3334512033062713d, c: 0.8626799508985245d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7692177568154062d, b: 0.8045212370680859d, c: 0.347836807601842d),

new NpgsqlTypes.NpgsqlLine(a: 0.8596806867272218d, b: 0.42225206488490163d, c: 0.2626771759427945d),

new NpgsqlTypes.NpgsqlLine(a: 0.6334601490046422d, b: 0.5508277640730257d, c: 0.9702039181027914d),

new NpgsqlTypes.NpgsqlLine(a: 0.7862671596820799d, b: 0.6148121550149941d, c: 0.10467782441316142d),

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
                Assert.That(model.Id, Is.EqualTo(920410273));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7950181430955406d, b: 0.3848051391253504d, c: 0.1572657802170856d),

new NpgsqlTypes.NpgsqlLine(a: 0.6062151918599252d, b: 0.06062326101597226d, c: 0.14777044879318857d),

new NpgsqlTypes.NpgsqlLine(a: 0.7408182398935058d, b: 0.6661433504932776d, c: 0.15722709569280902d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2482561889064241d, b: 0.768360521777252d, c: 0.24033198573060877d),

new NpgsqlTypes.NpgsqlLine(a: 0.6078828832971318d, b: 0.25910942482320465d, c: 0.7624300130707319d),

new NpgsqlTypes.NpgsqlLine(a: 0.551230062109523d, b: 0.5951997473266207d, c: 0.05557568229198884d),

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
                Assert.That(model.Id, Is.EqualTo(929385902));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8285395037487209d, b: 0.25070273066629d, c: 0.2500673109161923d),

new NpgsqlTypes.NpgsqlLine(a: 0.9942717530143405d, b: 0.21539215026712022d, c: 0.20269945939501077d),

new NpgsqlTypes.NpgsqlLine(a: 0.7979702358088475d, b: 0.0037115614378556705d, c: 0.8843432168677479d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1456202870910711d, b: 0.06772665910903597d, c: 0.691750610472359d),

new NpgsqlTypes.NpgsqlLine(a: 0.765757989281042d, b: 0.32982835634782004d, c: 0.8913701807765988d),

new NpgsqlTypes.NpgsqlLine(a: 0.052240732409688406d, b: 0.618262798295761d, c: 0.8474290495942781d),

new NpgsqlTypes.NpgsqlLine(a: 0.3584922315949717d, b: 0.520574773115294d, c: 0.8310230234204736d),

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
                Assert.That(model.Id, Is.EqualTo(939691488));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15928813769803307d, b: 0.5335096410959914d, c: 0.9693141891385088d),

new NpgsqlTypes.NpgsqlLine(a: 0.9448241901930845d, b: 0.6287076527827521d, c: 0.6660617468801671d),

new NpgsqlTypes.NpgsqlLine(a: 0.30712778702622445d, b: 0.324942912367581d, c: 0.9500282198259326d),

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
                Assert.That(model.Id, Is.EqualTo(940484658));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8457530794410952d, b: 0.07468146527745967d, c: 0.6058450234777081d),

new NpgsqlTypes.NpgsqlLine(a: 0.43907623012482566d, b: 0.4163533057091461d, c: 0.7083053151407345d),

new NpgsqlTypes.NpgsqlLine(a: 0.6460729456777172d, b: 0.3996032448892458d, c: 0.32058136990645736d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5056133907420888d, b: 0.687789482585691d, c: 0.5736898296981361d),

new NpgsqlTypes.NpgsqlLine(a: 0.6165837793609097d, b: 0.3896094649555947d, c: 0.782529168193896d),

new NpgsqlTypes.NpgsqlLine(a: 0.19522061405511182d, b: 0.49515141325692447d, c: 0.8154303350690599d),

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
                Assert.That(model.Id, Is.EqualTo(956171576));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6305558129660189d, b: 0.5463622939629917d, c: 0.401891977997777d),

new NpgsqlTypes.NpgsqlLine(a: 0.3662230087345998d, b: 0.4302679455886196d, c: 0.9631184941583132d),

new NpgsqlTypes.NpgsqlLine(a: 0.3634906094993412d, b: 0.18046820180120404d, c: 0.5193725822662353d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48533853922222536d, b: 0.7781157007327932d, c: 0.20671476643143427d),

new NpgsqlTypes.NpgsqlLine(a: 0.7321919326621603d, b: 0.7704043405190548d, c: 0.5508846640658778d),

new NpgsqlTypes.NpgsqlLine(a: 0.5796306726535371d, b: 0.3621536966457104d, c: 0.3554092618887771d),

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
                Assert.That(model.Id, Is.EqualTo(1049476690));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1703167002028123d, b: 0.06899134909065618d, c: 0.39632655876575884d),

new NpgsqlTypes.NpgsqlLine(a: 0.9436521110809849d, b: 0.2716102490692832d, c: 0.21807972083943694d),

new NpgsqlTypes.NpgsqlLine(a: 0.07510391898176405d, b: 0.4622700624960824d, c: 0.6916474126671974d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3434566231012316d, b: 0.6092872970160005d, c: 0.8285200623737458d),

new NpgsqlTypes.NpgsqlLine(a: 0.438620087459067d, b: 0.42784452615069857d, c: 0.43791996431227087d),

new NpgsqlTypes.NpgsqlLine(a: 0.13822472685663223d, b: 0.3567687904324768d, c: 0.5713362361619454d),

new NpgsqlTypes.NpgsqlLine(a: 0.4225842002023096d, b: 0.13041963778907273d, c: 0.537431949671262d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(259689541));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16915141278580792d, b: 0.5107686791340034d, c: 0.6489920882506348d),

new NpgsqlTypes.NpgsqlLine(a: 0.030879513236027d, b: 0.6401283771223818d, c: 0.4904762444562075d),

new NpgsqlTypes.NpgsqlLine(a: 0.16124954101586042d, b: 0.7102870300472969d, c: 0.9978682907813775d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3413197342637151d, b: 0.3564754218301692d, c: 0.16698356005321802d),

new NpgsqlTypes.NpgsqlLine(a: 0.24996465538547474d, b: 0.6936235099874405d, c: 0.00768766971096424d),

new NpgsqlTypes.NpgsqlLine(a: 0.9713834412198872d, b: 0.1937685310996965d, c: 0.5638524218711839d),

new NpgsqlTypes.NpgsqlLine(a: 0.20790035052620326d, b: 0.7280555648340241d, c: 0.7150389111804211d),

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
                Assert.That(model.Id, Is.EqualTo(1169283916));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6136867588329713d, b: 0.8476721243007673d, c: 0.2920466838690219d),

new NpgsqlTypes.NpgsqlLine(a: 0.5632572533709046d, b: 0.8580393386665631d, c: 0.29067186403759726d),

new NpgsqlTypes.NpgsqlLine(a: 0.05864985939465561d, b: 0.06933376015004311d, c: 0.2622230618531959d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3083889075922114d, b: 0.40504233141015844d, c: 0.7282625593772889d),

new NpgsqlTypes.NpgsqlLine(a: 0.9760389595620657d, b: 0.5432046524856411d, c: 0.4805721407516501d),

new NpgsqlTypes.NpgsqlLine(a: 0.226094370846618d, b: 0.30929816503923757d, c: 0.749788108094253d),

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


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1247961184));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588334999708729d, b: 0.5781258655739143d, c: 0.4951203893647069d),

new NpgsqlTypes.NpgsqlLine(a: 0.206651781249944d, b: 0.9214488824097644d, c: 0.7102197735978709d),

new NpgsqlTypes.NpgsqlLine(a: 0.8293873017859008d, b: 0.4197388618664637d, c: 0.7538628331143343d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9886122302398814d, b: 0.09733443476141157d, c: 0.8828756753279827d),

new NpgsqlTypes.NpgsqlLine(a: 0.4191781730328399d, b: 0.8360940579259326d, c: 0.3115604346093266d),

new NpgsqlTypes.NpgsqlLine(a: 0.03123256692948395d, b: 0.4210178852779579d, c: 0.7083559364281564d),

new NpgsqlTypes.NpgsqlLine(a: 0.10193811062121638d, b: 0.7865607707379441d, c: 0.5102014504618864d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(313349652));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7148027863911385d, b: 0.4116315290140842d, c: 0.9883513693293022d),

new NpgsqlTypes.NpgsqlLine(a: 0.730798769811796d, b: 0.5625059295801093d, c: 0.028144945623879147d),

new NpgsqlTypes.NpgsqlLine(a: 0.7895921923207063d, b: 0.897092096080744d, c: 0.36804397804374556d),

new NpgsqlTypes.NpgsqlLine(a: 0.4403951364132078d, b: 0.48316034726668566d, c: 0.5561087583026281d),

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
                Assert.That(model.Id, Is.EqualTo(1251267268));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.27064576558959075d, b: 0.24611103650290955d, c: 0.04928435530376152d),

new NpgsqlTypes.NpgsqlLine(a: 0.5382620257248645d, b: 0.586731968734226d, c: 0.9110741668368397d),

new NpgsqlTypes.NpgsqlLine(a: 0.8386954216871374d, b: 0.14045527908308764d, c: 0.5300328684198944d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7572326327773035d, b: 0.10039993499818312d, c: 0.17339739029118428d),

new NpgsqlTypes.NpgsqlLine(a: 0.9566618331567527d, b: 0.14668861402647748d, c: 0.7767711369985796d),

new NpgsqlTypes.NpgsqlLine(a: 0.932727244163919d, b: 0.12159065636952726d, c: 0.1704609096711438d),

new NpgsqlTypes.NpgsqlLine(a: 0.5792460825794749d, b: 0.985437582839235d, c: 0.557473090399633d),

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


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276251566));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4808529939808879d, b: 0.365247596328651d, c: 0.17939866902766977d),

new NpgsqlTypes.NpgsqlLine(a: 0.12809708913748585d, b: 0.18821025600986407d, c: 0.9740037535570704d),

new NpgsqlTypes.NpgsqlLine(a: 0.7729579560840041d, b: 0.5283959837814016d, c: 0.3246873097765165d),

new NpgsqlTypes.NpgsqlLine(a: 0.5804554841359071d, b: 0.7951318743812129d, c: 0.9533437460862759d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07357632206959641d, b: 0.11099061080365447d, c: 0.47576723756466854d),

new NpgsqlTypes.NpgsqlLine(a: 0.9051522311200175d, b: 0.6041352781626989d, c: 0.962846313750425d),

new NpgsqlTypes.NpgsqlLine(a: 0.7230697163609032d, b: 0.35996997662147945d, c: 0.2719627850842049d),

new NpgsqlTypes.NpgsqlLine(a: 0.039972657007877d, b: 0.6660692046588974d, c: 0.8074219604808613d),

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


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1278639929));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8637991908928382d, b: 0.7989476928355281d, c: 0.047074497669961635d),

new NpgsqlTypes.NpgsqlLine(a: 0.24284327761860214d, b: 0.034845279321367495d, c: 0.8243144068858446d),

new NpgsqlTypes.NpgsqlLine(a: 0.2705173386529084d, b: 0.37759514414776285d, c: 0.003784057263189533d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5464646368268954d, b: 0.1698011067851829d, c: 0.4811896051504386d),

new NpgsqlTypes.NpgsqlLine(a: 0.3264558304845737d, b: 0.09741548986796533d, c: 0.35078408755418944d),

new NpgsqlTypes.NpgsqlLine(a: 0.1253849539183054d, b: 0.9184504405667023d, c: 0.6244095303662431d),

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
                Assert.That(model.Id, Is.EqualTo(1352296160));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6961581521563707d, b: 0.2870425810465653d, c: 0.022813771410836625d),

new NpgsqlTypes.NpgsqlLine(a: 0.9289180434806266d, b: 0.10310192777053839d, c: 0.4974840036652155d),

new NpgsqlTypes.NpgsqlLine(a: 0.9742618124298718d, b: 0.666155889593685d, c: 0.9108800941033853d),

new NpgsqlTypes.NpgsqlLine(a: 0.4076993728994177d, b: 0.9237619110159688d, c: 0.16349574316883708d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.40245830157937157d, b: 0.4425237993192568d, c: 0.3605907953188545d),

new NpgsqlTypes.NpgsqlLine(a: 0.3025387755185438d, b: 0.16175616826033246d, c: 0.08369914886846197d),

new NpgsqlTypes.NpgsqlLine(a: 0.7932786053551402d, b: 0.4757892941852452d, c: 0.35215963103511483d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2052209240));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28682097488067404d, b: 0.19347953745544d, c: 0.767001580247448d),

new NpgsqlTypes.NpgsqlLine(a: 0.34168929191792363d, b: 0.5324263819109204d, c: 0.3548736591683712d),

new NpgsqlTypes.NpgsqlLine(a: 0.7601584215479089d, b: 0.9667193856859281d, c: 0.48805620341333844d),

new NpgsqlTypes.NpgsqlLine(a: 0.4778030273140724d, b: 0.6459214140044727d, c: 0.9825570138966864d),

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
                Assert.That(model.Id, Is.EqualTo(1422030401));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5508950376990435d, b: 0.1842011543506923d, c: 0.7200839172656331d),

new NpgsqlTypes.NpgsqlLine(a: 0.08098131741133519d, b: 0.2512744482896645d, c: 0.4419893154281408d),

new NpgsqlTypes.NpgsqlLine(a: 0.7183180834237055d, b: 0.3821225061156569d, c: 0.320010478004808d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.605461690855222d, b: 0.5098249599693536d, c: 0.049446338505273246d),

new NpgsqlTypes.NpgsqlLine(a: 0.6383133050473475d, b: 0.5385834180776717d, c: 0.2612256906158803d),

new NpgsqlTypes.NpgsqlLine(a: 0.2259744218921168d, b: 0.0504022254415285d, c: 0.5085817881315488d),

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
                Assert.That(model.Id, Is.EqualTo(1441068318));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04431673188157559d, b: 0.7118895502319815d, c: 0.8045459394080527d),

new NpgsqlTypes.NpgsqlLine(a: 0.41883883343441664d, b: 0.0856133325697227d, c: 0.45940150990219364d),

new NpgsqlTypes.NpgsqlLine(a: 0.3845455332415372d, b: 0.5278908004707358d, c: 0.45211852173959755d),

new NpgsqlTypes.NpgsqlLine(a: 0.707344526938849d, b: 0.2664835051263448d, c: 0.8012907013628192d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5167014945187821d, b: 0.2318523474732329d, c: 0.0766480392056259d),

new NpgsqlTypes.NpgsqlLine(a: 0.6239339834043951d, b: 0.4407650281616141d, c: 0.07711199216030074d),

new NpgsqlTypes.NpgsqlLine(a: 0.7330247230488705d, b: 0.06195929907587139d, c: 0.1736910797965654d),

new NpgsqlTypes.NpgsqlLine(a: 0.5060985759956755d, b: 0.12918142066992122d, c: 0.3598502037154421d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1349638635));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8811777097968191d, b: 0.09805743628781294d, c: 0.8476023389336619d),

new NpgsqlTypes.NpgsqlLine(a: 0.16329696312104391d, b: 0.8434248077846473d, c: 0.0171626874853823d),

new NpgsqlTypes.NpgsqlLine(a: 0.5930114320798587d, b: 0.7874763150232159d, c: 0.20169365861720767d),

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
                Assert.That(model.Id, Is.EqualTo(1485177216));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7620135774845544d, b: 0.72234986247445d, c: 0.7900958363555012d),

new NpgsqlTypes.NpgsqlLine(a: 0.5982892074823093d, b: 0.9157569165822279d, c: 0.5913666560112503d),

new NpgsqlTypes.NpgsqlLine(a: 0.3694255096703286d, b: 0.43689654039349735d, c: 0.27488642071951885d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1888587968));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9441675468790086d, b: 0.10273087249159918d, c: 0.36496868371913627d),

new NpgsqlTypes.NpgsqlLine(a: 0.3153900895384264d, b: 0.8953921593705707d, c: 0.6821583482258307d),

new NpgsqlTypes.NpgsqlLine(a: 0.15884512105184567d, b: 0.20745599422324912d, c: 0.5928677501305737d),

new NpgsqlTypes.NpgsqlLine(a: 0.19203772899196803d, b: 0.9281999546867626d, c: 0.9792553764463741d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.616453689236877d, b: 0.26880075600348696d, c: 0.9911672578342802d),

new NpgsqlTypes.NpgsqlLine(a: 0.41598816366831615d, b: 0.2972198032481773d, c: 0.6096249065094251d),

new NpgsqlTypes.NpgsqlLine(a: 0.21461782395965212d, b: 0.4996081675192614d, c: 0.845029551763019d),

new NpgsqlTypes.NpgsqlLine(a: 0.14603833144353173d, b: 0.5155958582129082d, c: 0.9513100476397736d),

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
                Assert.That(model.Id, Is.EqualTo(1612037280));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9755688560619167d, b: 0.7517347444178538d, c: 0.4433097656621017d),

new NpgsqlTypes.NpgsqlLine(a: 0.27642151559126893d, b: 0.49560032188535075d, c: 0.4017019854911661d),

new NpgsqlTypes.NpgsqlLine(a: 0.48234378585453686d, b: 0.5838608048706788d, c: 0.45264440736135125d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1803941428));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4958174274877982d, b: 0.19935005698584918d, c: 0.6570481803156852d),

new NpgsqlTypes.NpgsqlLine(a: 0.586031122116916d, b: 0.20438200508300097d, c: 0.7214279726394314d),

new NpgsqlTypes.NpgsqlLine(a: 0.3287771922455527d, b: 0.31464931534195395d, c: 0.49275260904707807d),

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
                Assert.That(model.Id, Is.EqualTo(1694903385));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5133551130062282d, b: 0.5981369379522861d, c: 0.5856516805262975d),

new NpgsqlTypes.NpgsqlLine(a: 0.4556255479239121d, b: 0.059243842569019045d, c: 0.18272228811839042d),

new NpgsqlTypes.NpgsqlLine(a: 0.8085308768004308d, b: 0.8348590541320315d, c: 0.5895099353964641d),

new NpgsqlTypes.NpgsqlLine(a: 0.24149968696186774d, b: 0.35557480082622506d, c: 0.5451461752136405d),

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
                Assert.That(model.Id, Is.EqualTo(1708194464));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21378574042766885d, b: 0.22474127876321393d, c: 0.01286635194062602d),

new NpgsqlTypes.NpgsqlLine(a: 0.44720527497131246d, b: 0.83386820783986d, c: 0.47600740851603984d),

new NpgsqlTypes.NpgsqlLine(a: 0.9177345103701179d, b: 0.8135674766115204d, c: 0.23923291716083794d),

new NpgsqlTypes.NpgsqlLine(a: 0.9998743487003019d, b: 0.013427841900149451d, c: 0.9133209978570025d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(871029693));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09314286666835214d, b: 0.9419395542104619d, c: 0.23265001920909978d),

new NpgsqlTypes.NpgsqlLine(a: 0.7840922282915723d, b: 0.8769622177219351d, c: 0.08844919095146764d),

new NpgsqlTypes.NpgsqlLine(a: 0.30172065868559383d, b: 0.061796126836928256d, c: 0.7819510380905712d),

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
                Assert.That(model.Id, Is.EqualTo(1749272119));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48465570613062037d, b: 0.4077570571696034d, c: 0.09124205112015671d),

new NpgsqlTypes.NpgsqlLine(a: 0.4905692123673753d, b: 0.09753381316271936d, c: 0.6219861110019185d),

new NpgsqlTypes.NpgsqlLine(a: 0.7715584772299492d, b: 0.7647042738214676d, c: 0.32981711302760286d),

new NpgsqlTypes.NpgsqlLine(a: 0.7826950107361046d, b: 0.6159017458991703d, c: 0.8761288210787351d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05854830086605134d, b: 0.4584727830793912d, c: 0.6485776355671607d),

new NpgsqlTypes.NpgsqlLine(a: 0.057402368952540694d, b: 0.814338567877536d, c: 0.36045674525095406d),

new NpgsqlTypes.NpgsqlLine(a: 0.4609921668504162d, b: 0.45446719793916357d, c: 0.6647833262693906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8421363107491464d, b: 0.8724917366553757d, c: 0.2954174236384989d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743101311));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30049737151744216d, b: 0.10935998965187232d, c: 0.12002566064851483d),

new NpgsqlTypes.NpgsqlLine(a: 0.4579983959880112d, b: 0.8700234892072651d, c: 0.24545341370685325d),

new NpgsqlTypes.NpgsqlLine(a: 0.6992061752442d, b: 0.8760611086508132d, c: 0.31896424715232463d),

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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14975557199832845d, b: 0.8649037801511367d, c: 0.8035067258718913d),

new NpgsqlTypes.NpgsqlLine(a: 0.022767088770272226d, b: 0.824519829812387d, c: 0.2990170967826957d),

new NpgsqlTypes.NpgsqlLine(a: 0.264229467978496d, b: 0.4707396384081288d, c: 0.5870444614457326d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1750072079));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6509605768915644d, b: 0.2871280523199907d, c: 0.5279864073907687d),

new NpgsqlTypes.NpgsqlLine(a: 0.847627780191932d, b: 0.2863239370866939d, c: 0.39664595009550063d),

new NpgsqlTypes.NpgsqlLine(a: 0.06719070091173818d, b: 0.2998868113793318d, c: 0.8109899934095542d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30402634597868494d, b: 0.7741177113732105d, c: 0.4982697795456863d),

new NpgsqlTypes.NpgsqlLine(a: 0.22134239051678783d, b: 0.952989590947333d, c: 0.1976805178607327d),

new NpgsqlTypes.NpgsqlLine(a: 0.48019693876130953d, b: 0.8553553442730837d, c: 0.4578014530562905d),

new NpgsqlTypes.NpgsqlLine(a: 0.7948720279836796d, b: 0.6347165612507009d, c: 0.4915047790558922d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(681877477));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.054876749435908034d, b: 0.7476698065656858d, c: 0.5221215501493097d),

new NpgsqlTypes.NpgsqlLine(a: 0.1689911006864584d, b: 0.16032672190790076d, c: 0.9537953031702238d),

new NpgsqlTypes.NpgsqlLine(a: 0.3133690487713232d, b: 0.21425817972116357d, c: 0.39002508371565625d),

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


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1765269457));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4428210775962541d, b: 0.44628545865868685d, c: 0.7913435097925557d),

new NpgsqlTypes.NpgsqlLine(a: 0.26419018627718516d, b: 0.12166427922453704d, c: 0.11250832552770584d),

new NpgsqlTypes.NpgsqlLine(a: 0.20276585628171784d, b: 0.14489314174625478d, c: 0.5410582863519566d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(699428708));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.75437435623167d, b: 0.4381969103973332d, c: 0.13859938549471296d),

new NpgsqlTypes.NpgsqlLine(a: 0.22478326045746155d, b: 0.7927996319630696d, c: 0.5653146543488808d),

new NpgsqlTypes.NpgsqlLine(a: 0.8148660813324691d, b: 0.5965502974097225d, c: 0.08598406767552191d),

new NpgsqlTypes.NpgsqlLine(a: 0.10261855436837408d, b: 0.22753843400620033d, c: 0.6663050101504865d),

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19047502268477823d, b: 0.503647750986701d, c: 0.5140837344549085d),

new NpgsqlTypes.NpgsqlLine(a: 0.5498279015442291d, b: 0.5205498180433044d, c: 0.5511400439881968d),

new NpgsqlTypes.NpgsqlLine(a: 0.07519565206915457d, b: 0.8190939422278946d, c: 0.4842243543091963d),

new NpgsqlTypes.NpgsqlLine(a: 0.11151345358207676d, b: 0.2794260095615846d, c: 0.1977999861392018d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(NpgsqlLinelineArray1M),
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

                var expected = new Dictionary<System.Int32,NpgsqlLinelineArray1M>(30);

                expected.Add(
                    24431063,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 24431063,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7432562260700321d, b: 0.9027051106351455d, c: 0.20935776301702913d),

new NpgsqlTypes.NpgsqlLine(a: 0.06877648068052133d, b: 0.4638520424251973d, c: 0.8977581074629934d),

new NpgsqlTypes.NpgsqlLine(a: 0.19824889810271595d, b: 0.101805635004653d, c: 0.6376796129171594d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.25692356453649523d, b: 0.8249956321761069d, c: 0.7485760418256393d),

new NpgsqlTypes.NpgsqlLine(a: 0.5205543536927003d, b: 0.26409313743898866d, c: 0.11834223656249432d),

new NpgsqlTypes.NpgsqlLine(a: 0.12852097087774939d, b: 0.110468841038458d, c: 0.15781368742463253d),

new NpgsqlTypes.NpgsqlLine(a: 0.5056691167374713d, b: 0.17475361978672044d, c: 0.4301177356479713d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    88466632,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 88466632,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24038691940074952d, b: 0.4574071819075469d, c: 0.029018693781179494d),

new NpgsqlTypes.NpgsqlLine(a: 0.6230691191149946d, b: 0.6421350132669393d, c: 0.2591755154295573d),

new NpgsqlTypes.NpgsqlLine(a: 0.284214063978114d, b: 0.42055782459666247d, c: 0.4230265799247275d),

new NpgsqlTypes.NpgsqlLine(a: 0.2294933978523651d, b: 0.8434657220550107d, c: 0.1364803149185917d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 671378680,
                            Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.579485378096583d, b: 0.7644192687968542d, c: 0.38803543767659376d),

new NpgsqlTypes.NpgsqlLine(a: 0.9272224559192928d, b: 0.04309922869802718d, c: 0.1084146589578524d),

new NpgsqlTypes.NpgsqlLine(a: 0.6194396921461146d, b: 0.3135327751395446d, c: 0.47728859432318693d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22238461731837955d, b: 0.8832575247518029d, c: 0.5267192016109244d),

new NpgsqlTypes.NpgsqlLine(a: 0.2456814921559901d, b: 0.12396858431218405d, c: 0.7758983059785806d),

new NpgsqlTypes.NpgsqlLine(a: 0.8010355013907535d, b: 0.10724380078506457d, c: 0.8516226142927568d),

}
                        }

                    }
                );

                expected.Add(
                    214898413,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 214898413,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7273918164372143d, b: 0.3711769692436181d, c: 0.7468659136792664d),

new NpgsqlTypes.NpgsqlLine(a: 0.8155250372031967d, b: 0.5364157660240247d, c: 0.2587745327315204d),

new NpgsqlTypes.NpgsqlLine(a: 0.8823774478354753d, b: 0.24032876435579376d, c: 0.9187231882533503d),

new NpgsqlTypes.NpgsqlLine(a: 0.2761563267007917d, b: 0.8609521972165307d, c: 0.014350256291767893d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7060914743005817d, b: 0.29942700622480667d, c: 0.38464564338188945d),

new NpgsqlTypes.NpgsqlLine(a: 0.456801666295529d, b: 0.2750050419905442d, c: 0.6523990372650718d),

new NpgsqlTypes.NpgsqlLine(a: 0.593068234761201d, b: 0.986042625015402d, c: 0.7722918655162653d),

new NpgsqlTypes.NpgsqlLine(a: 0.8257270425360131d, b: 0.9234733383976109d, c: 0.16399605960296715d),

},

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 160844459,
                            Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.49742066568592347d, b: 0.13045995730850435d, c: 0.3240701079822569d),

new NpgsqlTypes.NpgsqlLine(a: 0.4230136983146885d, b: 0.4758823758243249d, c: 0.7245296150407883d),

new NpgsqlTypes.NpgsqlLine(a: 0.902525000709505d, b: 0.3096633545847971d, c: 0.7195095860492445d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    232426060,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 232426060,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7754569347332767d, b: 0.7449423603392903d, c: 0.7275357910733291d),

new NpgsqlTypes.NpgsqlLine(a: 0.9072872865290874d, b: 0.5188651109794405d, c: 0.49767196437474315d),

new NpgsqlTypes.NpgsqlLine(a: 0.7613773478086597d, b: 0.8726134777514618d, c: 0.7249287737318102d),

new NpgsqlTypes.NpgsqlLine(a: 0.31979325488547383d, b: 0.21963013317369884d, c: 0.995747479981123d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5136334997132156d, b: 0.4481836733144653d, c: 0.5566013930940901d),

new NpgsqlTypes.NpgsqlLine(a: 0.2628604279970359d, b: 0.34706683348460354d, c: 0.8618758810041756d),

new NpgsqlTypes.NpgsqlLine(a: 0.9066993846202163d, b: 0.9919335952888788d, c: 0.16647553451680086d),

new NpgsqlTypes.NpgsqlLine(a: 0.8084713734948656d, b: 0.9105928653749232d, c: 0.5871692331069964d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    287773256,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 287773256,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5468129373528992d, b: 0.4550697398151482d, c: 0.9323204190693627d),

new NpgsqlTypes.NpgsqlLine(a: 0.09290076953581794d, b: 0.06513797114322906d, c: 0.01453530584939322d),

new NpgsqlTypes.NpgsqlLine(a: 0.06819515445977387d, b: 0.13776512554356624d, c: 0.5971045649241554d),

new NpgsqlTypes.NpgsqlLine(a: 0.17602847632288898d, b: 0.8583377493377162d, c: 0.5319193518068348d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 2000087272,
                            Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5174417835536576d, b: 0.9550151039410834d, c: 0.94465021980697d),

new NpgsqlTypes.NpgsqlLine(a: 0.023498567205728516d, b: 0.14704570142511664d, c: 0.5436176118381062d),

new NpgsqlTypes.NpgsqlLine(a: 0.6410825125912296d, b: 0.1638519482392854d, c: 0.07442290044208977d),

new NpgsqlTypes.NpgsqlLine(a: 0.5684954410076702d, b: 0.9517870324925599d, c: 0.7913121037671743d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5546781844769255d, b: 0.3295435210405563d, c: 0.10332785525555d),

new NpgsqlTypes.NpgsqlLine(a: 0.8619184029547027d, b: 0.6893143841340763d, c: 0.6057919377815917d),

new NpgsqlTypes.NpgsqlLine(a: 0.6918049340506819d, b: 0.29564467871458977d, c: 0.373851052320022d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590711543927416d, b: 0.782456230485786d, c: 0.0557514543823312d),

}
                        }

                    }
                );

                expected.Add(
                    385864550,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 385864550,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22975102280111437d, b: 0.9248487581270293d, c: 0.13680981887715193d),

new NpgsqlTypes.NpgsqlLine(a: 0.09251582159332017d, b: 0.5284902712490177d, c: 0.5030244379828798d),

new NpgsqlTypes.NpgsqlLine(a: 0.3316636973424488d, b: 0.125908586516723d, c: 0.1307901665228316d),

new NpgsqlTypes.NpgsqlLine(a: 0.4488357278586823d, b: 0.4939460007710509d, c: 0.1486125807477222d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4793632894446783d, b: 0.7460924351194599d, c: 0.8333281971866928d),

new NpgsqlTypes.NpgsqlLine(a: 0.9911204719862435d, b: 0.02386428262012663d, c: 0.1749191984110413d),

new NpgsqlTypes.NpgsqlLine(a: 0.9855596015822274d, b: 0.652336551342683d, c: 0.13320036109805444d),

new NpgsqlTypes.NpgsqlLine(a: 0.2704642620419001d, b: 0.25815455585325764d, c: 0.781691467105331d),

},

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 507016837,
                            Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6329641939546133d, b: 0.7713358064075255d, c: 0.7091675230581173d),

new NpgsqlTypes.NpgsqlLine(a: 0.6401104534145889d, b: 0.4461488045009705d, c: 0.8050604324576476d),

new NpgsqlTypes.NpgsqlLine(a: 0.718200194405203d, b: 0.43497844061299695d, c: 0.8863292600245054d),

new NpgsqlTypes.NpgsqlLine(a: 0.6409377372303063d, b: 0.6727026439221405d, c: 0.709162570856183d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    425879955,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 425879955,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7120720914880876d, b: 0.12018496532744738d, c: 0.23458035596972604d),

new NpgsqlTypes.NpgsqlLine(a: 0.8966943482850258d, b: 0.35901938172619774d, c: 0.5153333646331681d),

new NpgsqlTypes.NpgsqlLine(a: 0.772529205234202d, b: 0.3302141544038909d, c: 0.49860223574471696d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    447065450,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 447065450,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6636554004535458d, b: 0.4052905058278198d, c: 0.17999403534412883d),

new NpgsqlTypes.NpgsqlLine(a: 0.4929643299593621d, b: 0.04102771738828992d, c: 0.8758588440576921d),

new NpgsqlTypes.NpgsqlLine(a: 0.9843591359807438d, b: 0.9486545770421181d, c: 0.23810538982780194d),

new NpgsqlTypes.NpgsqlLine(a: 0.0373504814930844d, b: 0.29650224807426506d, c: 0.6527517869517908d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 1935239880,
                            Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5125009420178407d, b: 0.13553866813087467d, c: 0.6573124881706722d),

new NpgsqlTypes.NpgsqlLine(a: 0.9315668534985179d, b: 0.031339976871202935d, c: 0.7319776155987312d),

new NpgsqlTypes.NpgsqlLine(a: 0.5913519522327184d, b: 0.688194613219936d, c: 0.7487303543444555d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    776647699,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 776647699,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8841755970938628d, b: 0.039993263617271846d, c: 0.2425222413816407d),

new NpgsqlTypes.NpgsqlLine(a: 0.3162669055857611d, b: 0.1360654949714053d, c: 0.585066125260232d),

new NpgsqlTypes.NpgsqlLine(a: 0.23614085233198578d, b: 0.9624524908146396d, c: 0.8036122013629919d),

new NpgsqlTypes.NpgsqlLine(a: 0.9594786748108928d, b: 0.3334512033062713d, c: 0.8626799508985245d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7692177568154062d, b: 0.8045212370680859d, c: 0.347836807601842d),

new NpgsqlTypes.NpgsqlLine(a: 0.8596806867272218d, b: 0.42225206488490163d, c: 0.2626771759427945d),

new NpgsqlTypes.NpgsqlLine(a: 0.6334601490046422d, b: 0.5508277640730257d, c: 0.9702039181027914d),

new NpgsqlTypes.NpgsqlLine(a: 0.7862671596820799d, b: 0.6148121550149941d, c: 0.10467782441316142d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    920410273,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 920410273,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7950181430955406d, b: 0.3848051391253504d, c: 0.1572657802170856d),

new NpgsqlTypes.NpgsqlLine(a: 0.6062151918599252d, b: 0.06062326101597226d, c: 0.14777044879318857d),

new NpgsqlTypes.NpgsqlLine(a: 0.7408182398935058d, b: 0.6661433504932776d, c: 0.15722709569280902d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2482561889064241d, b: 0.768360521777252d, c: 0.24033198573060877d),

new NpgsqlTypes.NpgsqlLine(a: 0.6078828832971318d, b: 0.25910942482320465d, c: 0.7624300130707319d),

new NpgsqlTypes.NpgsqlLine(a: 0.551230062109523d, b: 0.5951997473266207d, c: 0.05557568229198884d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    929385902,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 929385902,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8285395037487209d, b: 0.25070273066629d, c: 0.2500673109161923d),

new NpgsqlTypes.NpgsqlLine(a: 0.9942717530143405d, b: 0.21539215026712022d, c: 0.20269945939501077d),

new NpgsqlTypes.NpgsqlLine(a: 0.7979702358088475d, b: 0.0037115614378556705d, c: 0.8843432168677479d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1456202870910711d, b: 0.06772665910903597d, c: 0.691750610472359d),

new NpgsqlTypes.NpgsqlLine(a: 0.765757989281042d, b: 0.32982835634782004d, c: 0.8913701807765988d),

new NpgsqlTypes.NpgsqlLine(a: 0.052240732409688406d, b: 0.618262798295761d, c: 0.8474290495942781d),

new NpgsqlTypes.NpgsqlLine(a: 0.3584922315949717d, b: 0.520574773115294d, c: 0.8310230234204736d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    939691488,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 939691488,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15928813769803307d, b: 0.5335096410959914d, c: 0.9693141891385088d),

new NpgsqlTypes.NpgsqlLine(a: 0.9448241901930845d, b: 0.6287076527827521d, c: 0.6660617468801671d),

new NpgsqlTypes.NpgsqlLine(a: 0.30712778702622445d, b: 0.324942912367581d, c: 0.9500282198259326d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    940484658,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 940484658,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8457530794410952d, b: 0.07468146527745967d, c: 0.6058450234777081d),

new NpgsqlTypes.NpgsqlLine(a: 0.43907623012482566d, b: 0.4163533057091461d, c: 0.7083053151407345d),

new NpgsqlTypes.NpgsqlLine(a: 0.6460729456777172d, b: 0.3996032448892458d, c: 0.32058136990645736d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5056133907420888d, b: 0.687789482585691d, c: 0.5736898296981361d),

new NpgsqlTypes.NpgsqlLine(a: 0.6165837793609097d, b: 0.3896094649555947d, c: 0.782529168193896d),

new NpgsqlTypes.NpgsqlLine(a: 0.19522061405511182d, b: 0.49515141325692447d, c: 0.8154303350690599d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    956171576,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 956171576,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6305558129660189d, b: 0.5463622939629917d, c: 0.401891977997777d),

new NpgsqlTypes.NpgsqlLine(a: 0.3662230087345998d, b: 0.4302679455886196d, c: 0.9631184941583132d),

new NpgsqlTypes.NpgsqlLine(a: 0.3634906094993412d, b: 0.18046820180120404d, c: 0.5193725822662353d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48533853922222536d, b: 0.7781157007327932d, c: 0.20671476643143427d),

new NpgsqlTypes.NpgsqlLine(a: 0.7321919326621603d, b: 0.7704043405190548d, c: 0.5508846640658778d),

new NpgsqlTypes.NpgsqlLine(a: 0.5796306726535371d, b: 0.3621536966457104d, c: 0.3554092618887771d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1049476690,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1049476690,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1703167002028123d, b: 0.06899134909065618d, c: 0.39632655876575884d),

new NpgsqlTypes.NpgsqlLine(a: 0.9436521110809849d, b: 0.2716102490692832d, c: 0.21807972083943694d),

new NpgsqlTypes.NpgsqlLine(a: 0.07510391898176405d, b: 0.4622700624960824d, c: 0.6916474126671974d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3434566231012316d, b: 0.6092872970160005d, c: 0.8285200623737458d),

new NpgsqlTypes.NpgsqlLine(a: 0.438620087459067d, b: 0.42784452615069857d, c: 0.43791996431227087d),

new NpgsqlTypes.NpgsqlLine(a: 0.13822472685663223d, b: 0.3567687904324768d, c: 0.5713362361619454d),

new NpgsqlTypes.NpgsqlLine(a: 0.4225842002023096d, b: 0.13041963778907273d, c: 0.537431949671262d),

},

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 259689541,
                            Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16915141278580792d, b: 0.5107686791340034d, c: 0.6489920882506348d),

new NpgsqlTypes.NpgsqlLine(a: 0.030879513236027d, b: 0.6401283771223818d, c: 0.4904762444562075d),

new NpgsqlTypes.NpgsqlLine(a: 0.16124954101586042d, b: 0.7102870300472969d, c: 0.9978682907813775d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3413197342637151d, b: 0.3564754218301692d, c: 0.16698356005321802d),

new NpgsqlTypes.NpgsqlLine(a: 0.24996465538547474d, b: 0.6936235099874405d, c: 0.00768766971096424d),

new NpgsqlTypes.NpgsqlLine(a: 0.9713834412198872d, b: 0.1937685310996965d, c: 0.5638524218711839d),

new NpgsqlTypes.NpgsqlLine(a: 0.20790035052620326d, b: 0.7280555648340241d, c: 0.7150389111804211d),

}
                        }

                    }
                );

                expected.Add(
                    1169283916,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1169283916,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6136867588329713d, b: 0.8476721243007673d, c: 0.2920466838690219d),

new NpgsqlTypes.NpgsqlLine(a: 0.5632572533709046d, b: 0.8580393386665631d, c: 0.29067186403759726d),

new NpgsqlTypes.NpgsqlLine(a: 0.05864985939465561d, b: 0.06933376015004311d, c: 0.2622230618531959d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3083889075922114d, b: 0.40504233141015844d, c: 0.7282625593772889d),

new NpgsqlTypes.NpgsqlLine(a: 0.9760389595620657d, b: 0.5432046524856411d, c: 0.4805721407516501d),

new NpgsqlTypes.NpgsqlLine(a: 0.226094370846618d, b: 0.30929816503923757d, c: 0.749788108094253d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1247961184,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1247961184,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588334999708729d, b: 0.5781258655739143d, c: 0.4951203893647069d),

new NpgsqlTypes.NpgsqlLine(a: 0.206651781249944d, b: 0.9214488824097644d, c: 0.7102197735978709d),

new NpgsqlTypes.NpgsqlLine(a: 0.8293873017859008d, b: 0.4197388618664637d, c: 0.7538628331143343d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9886122302398814d, b: 0.09733443476141157d, c: 0.8828756753279827d),

new NpgsqlTypes.NpgsqlLine(a: 0.4191781730328399d, b: 0.8360940579259326d, c: 0.3115604346093266d),

new NpgsqlTypes.NpgsqlLine(a: 0.03123256692948395d, b: 0.4210178852779579d, c: 0.7083559364281564d),

new NpgsqlTypes.NpgsqlLine(a: 0.10193811062121638d, b: 0.7865607707379441d, c: 0.5102014504618864d),

},

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 313349652,
                            Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7148027863911385d, b: 0.4116315290140842d, c: 0.9883513693293022d),

new NpgsqlTypes.NpgsqlLine(a: 0.730798769811796d, b: 0.5625059295801093d, c: 0.028144945623879147d),

new NpgsqlTypes.NpgsqlLine(a: 0.7895921923207063d, b: 0.897092096080744d, c: 0.36804397804374556d),

new NpgsqlTypes.NpgsqlLine(a: 0.4403951364132078d, b: 0.48316034726668566d, c: 0.5561087583026281d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1251267268,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1251267268,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.27064576558959075d, b: 0.24611103650290955d, c: 0.04928435530376152d),

new NpgsqlTypes.NpgsqlLine(a: 0.5382620257248645d, b: 0.586731968734226d, c: 0.9110741668368397d),

new NpgsqlTypes.NpgsqlLine(a: 0.8386954216871374d, b: 0.14045527908308764d, c: 0.5300328684198944d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7572326327773035d, b: 0.10039993499818312d, c: 0.17339739029118428d),

new NpgsqlTypes.NpgsqlLine(a: 0.9566618331567527d, b: 0.14668861402647748d, c: 0.7767711369985796d),

new NpgsqlTypes.NpgsqlLine(a: 0.932727244163919d, b: 0.12159065636952726d, c: 0.1704609096711438d),

new NpgsqlTypes.NpgsqlLine(a: 0.5792460825794749d, b: 0.985437582839235d, c: 0.557473090399633d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1276251566,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1276251566,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4808529939808879d, b: 0.365247596328651d, c: 0.17939866902766977d),

new NpgsqlTypes.NpgsqlLine(a: 0.12809708913748585d, b: 0.18821025600986407d, c: 0.9740037535570704d),

new NpgsqlTypes.NpgsqlLine(a: 0.7729579560840041d, b: 0.5283959837814016d, c: 0.3246873097765165d),

new NpgsqlTypes.NpgsqlLine(a: 0.5804554841359071d, b: 0.7951318743812129d, c: 0.9533437460862759d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07357632206959641d, b: 0.11099061080365447d, c: 0.47576723756466854d),

new NpgsqlTypes.NpgsqlLine(a: 0.9051522311200175d, b: 0.6041352781626989d, c: 0.962846313750425d),

new NpgsqlTypes.NpgsqlLine(a: 0.7230697163609032d, b: 0.35996997662147945d, c: 0.2719627850842049d),

new NpgsqlTypes.NpgsqlLine(a: 0.039972657007877d, b: 0.6660692046588974d, c: 0.8074219604808613d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1278639929,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1278639929,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8637991908928382d, b: 0.7989476928355281d, c: 0.047074497669961635d),

new NpgsqlTypes.NpgsqlLine(a: 0.24284327761860214d, b: 0.034845279321367495d, c: 0.8243144068858446d),

new NpgsqlTypes.NpgsqlLine(a: 0.2705173386529084d, b: 0.37759514414776285d, c: 0.003784057263189533d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5464646368268954d, b: 0.1698011067851829d, c: 0.4811896051504386d),

new NpgsqlTypes.NpgsqlLine(a: 0.3264558304845737d, b: 0.09741548986796533d, c: 0.35078408755418944d),

new NpgsqlTypes.NpgsqlLine(a: 0.1253849539183054d, b: 0.9184504405667023d, c: 0.6244095303662431d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1352296160,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1352296160,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6961581521563707d, b: 0.2870425810465653d, c: 0.022813771410836625d),

new NpgsqlTypes.NpgsqlLine(a: 0.9289180434806266d, b: 0.10310192777053839d, c: 0.4974840036652155d),

new NpgsqlTypes.NpgsqlLine(a: 0.9742618124298718d, b: 0.666155889593685d, c: 0.9108800941033853d),

new NpgsqlTypes.NpgsqlLine(a: 0.4076993728994177d, b: 0.9237619110159688d, c: 0.16349574316883708d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.40245830157937157d, b: 0.4425237993192568d, c: 0.3605907953188545d),

new NpgsqlTypes.NpgsqlLine(a: 0.3025387755185438d, b: 0.16175616826033246d, c: 0.08369914886846197d),

new NpgsqlTypes.NpgsqlLine(a: 0.7932786053551402d, b: 0.4757892941852452d, c: 0.35215963103511483d),

},

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 2052209240,
                            Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28682097488067404d, b: 0.19347953745544d, c: 0.767001580247448d),

new NpgsqlTypes.NpgsqlLine(a: 0.34168929191792363d, b: 0.5324263819109204d, c: 0.3548736591683712d),

new NpgsqlTypes.NpgsqlLine(a: 0.7601584215479089d, b: 0.9667193856859281d, c: 0.48805620341333844d),

new NpgsqlTypes.NpgsqlLine(a: 0.4778030273140724d, b: 0.6459214140044727d, c: 0.9825570138966864d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1422030401,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1422030401,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5508950376990435d, b: 0.1842011543506923d, c: 0.7200839172656331d),

new NpgsqlTypes.NpgsqlLine(a: 0.08098131741133519d, b: 0.2512744482896645d, c: 0.4419893154281408d),

new NpgsqlTypes.NpgsqlLine(a: 0.7183180834237055d, b: 0.3821225061156569d, c: 0.320010478004808d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.605461690855222d, b: 0.5098249599693536d, c: 0.049446338505273246d),

new NpgsqlTypes.NpgsqlLine(a: 0.6383133050473475d, b: 0.5385834180776717d, c: 0.2612256906158803d),

new NpgsqlTypes.NpgsqlLine(a: 0.2259744218921168d, b: 0.0504022254415285d, c: 0.5085817881315488d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1441068318,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1441068318,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04431673188157559d, b: 0.7118895502319815d, c: 0.8045459394080527d),

new NpgsqlTypes.NpgsqlLine(a: 0.41883883343441664d, b: 0.0856133325697227d, c: 0.45940150990219364d),

new NpgsqlTypes.NpgsqlLine(a: 0.3845455332415372d, b: 0.5278908004707358d, c: 0.45211852173959755d),

new NpgsqlTypes.NpgsqlLine(a: 0.707344526938849d, b: 0.2664835051263448d, c: 0.8012907013628192d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5167014945187821d, b: 0.2318523474732329d, c: 0.0766480392056259d),

new NpgsqlTypes.NpgsqlLine(a: 0.6239339834043951d, b: 0.4407650281616141d, c: 0.07711199216030074d),

new NpgsqlTypes.NpgsqlLine(a: 0.7330247230488705d, b: 0.06195929907587139d, c: 0.1736910797965654d),

new NpgsqlTypes.NpgsqlLine(a: 0.5060985759956755d, b: 0.12918142066992122d, c: 0.3598502037154421d),

},

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 1349638635,
                            Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8811777097968191d, b: 0.09805743628781294d, c: 0.8476023389336619d),

new NpgsqlTypes.NpgsqlLine(a: 0.16329696312104391d, b: 0.8434248077846473d, c: 0.0171626874853823d),

new NpgsqlTypes.NpgsqlLine(a: 0.5930114320798587d, b: 0.7874763150232159d, c: 0.20169365861720767d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1485177216,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1485177216,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7620135774845544d, b: 0.72234986247445d, c: 0.7900958363555012d),

new NpgsqlTypes.NpgsqlLine(a: 0.5982892074823093d, b: 0.9157569165822279d, c: 0.5913666560112503d),

new NpgsqlTypes.NpgsqlLine(a: 0.3694255096703286d, b: 0.43689654039349735d, c: 0.27488642071951885d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 1888587968,
                            Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9441675468790086d, b: 0.10273087249159918d, c: 0.36496868371913627d),

new NpgsqlTypes.NpgsqlLine(a: 0.3153900895384264d, b: 0.8953921593705707d, c: 0.6821583482258307d),

new NpgsqlTypes.NpgsqlLine(a: 0.15884512105184567d, b: 0.20745599422324912d, c: 0.5928677501305737d),

new NpgsqlTypes.NpgsqlLine(a: 0.19203772899196803d, b: 0.9281999546867626d, c: 0.9792553764463741d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.616453689236877d, b: 0.26880075600348696d, c: 0.9911672578342802d),

new NpgsqlTypes.NpgsqlLine(a: 0.41598816366831615d, b: 0.2972198032481773d, c: 0.6096249065094251d),

new NpgsqlTypes.NpgsqlLine(a: 0.21461782395965212d, b: 0.4996081675192614d, c: 0.845029551763019d),

new NpgsqlTypes.NpgsqlLine(a: 0.14603833144353173d, b: 0.5155958582129082d, c: 0.9513100476397736d),

}
                        }

                    }
                );

                expected.Add(
                    1612037280,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1612037280,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9755688560619167d, b: 0.7517347444178538d, c: 0.4433097656621017d),

new NpgsqlTypes.NpgsqlLine(a: 0.27642151559126893d, b: 0.49560032188535075d, c: 0.4017019854911661d),

new NpgsqlTypes.NpgsqlLine(a: 0.48234378585453686d, b: 0.5838608048706788d, c: 0.45264440736135125d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 1803941428,
                            Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4958174274877982d, b: 0.19935005698584918d, c: 0.6570481803156852d),

new NpgsqlTypes.NpgsqlLine(a: 0.586031122116916d, b: 0.20438200508300097d, c: 0.7214279726394314d),

new NpgsqlTypes.NpgsqlLine(a: 0.3287771922455527d, b: 0.31464931534195395d, c: 0.49275260904707807d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1694903385,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1694903385,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5133551130062282d, b: 0.5981369379522861d, c: 0.5856516805262975d),

new NpgsqlTypes.NpgsqlLine(a: 0.4556255479239121d, b: 0.059243842569019045d, c: 0.18272228811839042d),

new NpgsqlTypes.NpgsqlLine(a: 0.8085308768004308d, b: 0.8348590541320315d, c: 0.5895099353964641d),

new NpgsqlTypes.NpgsqlLine(a: 0.24149968696186774d, b: 0.35557480082622506d, c: 0.5451461752136405d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1708194464,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1708194464,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21378574042766885d, b: 0.22474127876321393d, c: 0.01286635194062602d),

new NpgsqlTypes.NpgsqlLine(a: 0.44720527497131246d, b: 0.83386820783986d, c: 0.47600740851603984d),

new NpgsqlTypes.NpgsqlLine(a: 0.9177345103701179d, b: 0.8135674766115204d, c: 0.23923291716083794d),

new NpgsqlTypes.NpgsqlLine(a: 0.9998743487003019d, b: 0.013427841900149451d, c: 0.9133209978570025d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 871029693,
                            Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09314286666835214d, b: 0.9419395542104619d, c: 0.23265001920909978d),

new NpgsqlTypes.NpgsqlLine(a: 0.7840922282915723d, b: 0.8769622177219351d, c: 0.08844919095146764d),

new NpgsqlTypes.NpgsqlLine(a: 0.30172065868559383d, b: 0.061796126836928256d, c: 0.7819510380905712d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1749272119,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1749272119,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48465570613062037d, b: 0.4077570571696034d, c: 0.09124205112015671d),

new NpgsqlTypes.NpgsqlLine(a: 0.4905692123673753d, b: 0.09753381316271936d, c: 0.6219861110019185d),

new NpgsqlTypes.NpgsqlLine(a: 0.7715584772299492d, b: 0.7647042738214676d, c: 0.32981711302760286d),

new NpgsqlTypes.NpgsqlLine(a: 0.7826950107361046d, b: 0.6159017458991703d, c: 0.8761288210787351d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05854830086605134d, b: 0.4584727830793912d, c: 0.6485776355671607d),

new NpgsqlTypes.NpgsqlLine(a: 0.057402368952540694d, b: 0.814338567877536d, c: 0.36045674525095406d),

new NpgsqlTypes.NpgsqlLine(a: 0.4609921668504162d, b: 0.45446719793916357d, c: 0.6647833262693906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8421363107491464d, b: 0.8724917366553757d, c: 0.2954174236384989d),

},

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 1743101311,
                            Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30049737151744216d, b: 0.10935998965187232d, c: 0.12002566064851483d),

new NpgsqlTypes.NpgsqlLine(a: 0.4579983959880112d, b: 0.8700234892072651d, c: 0.24545341370685325d),

new NpgsqlTypes.NpgsqlLine(a: 0.6992061752442d, b: 0.8760611086508132d, c: 0.31896424715232463d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14975557199832845d, b: 0.8649037801511367d, c: 0.8035067258718913d),

new NpgsqlTypes.NpgsqlLine(a: 0.022767088770272226d, b: 0.824519829812387d, c: 0.2990170967826957d),

new NpgsqlTypes.NpgsqlLine(a: 0.264229467978496d, b: 0.4707396384081288d, c: 0.5870444614457326d),

}
                        }

                    }
                );

                expected.Add(
                    1750072079,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1750072079,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6509605768915644d, b: 0.2871280523199907d, c: 0.5279864073907687d),

new NpgsqlTypes.NpgsqlLine(a: 0.847627780191932d, b: 0.2863239370866939d, c: 0.39664595009550063d),

new NpgsqlTypes.NpgsqlLine(a: 0.06719070091173818d, b: 0.2998868113793318d, c: 0.8109899934095542d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30402634597868494d, b: 0.7741177113732105d, c: 0.4982697795456863d),

new NpgsqlTypes.NpgsqlLine(a: 0.22134239051678783d, b: 0.952989590947333d, c: 0.1976805178607327d),

new NpgsqlTypes.NpgsqlLine(a: 0.48019693876130953d, b: 0.8553553442730837d, c: 0.4578014530562905d),

new NpgsqlTypes.NpgsqlLine(a: 0.7948720279836796d, b: 0.6347165612507009d, c: 0.4915047790558922d),

},

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 681877477,
                            Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.054876749435908034d, b: 0.7476698065656858d, c: 0.5221215501493097d),

new NpgsqlTypes.NpgsqlLine(a: 0.1689911006864584d, b: 0.16032672190790076d, c: 0.9537953031702238d),

new NpgsqlTypes.NpgsqlLine(a: 0.3133690487713232d, b: 0.21425817972116357d, c: 0.39002508371565625d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1765269457,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1765269457,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4428210775962541d, b: 0.44628545865868685d, c: 0.7913435097925557d),

new NpgsqlTypes.NpgsqlLine(a: 0.26419018627718516d, b: 0.12166427922453704d, c: 0.11250832552770584d),

new NpgsqlTypes.NpgsqlLine(a: 0.20276585628171784d, b: 0.14489314174625478d, c: 0.5410582863519566d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 699428708,
                            Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.75437435623167d, b: 0.4381969103973332d, c: 0.13859938549471296d),

new NpgsqlTypes.NpgsqlLine(a: 0.22478326045746155d, b: 0.7927996319630696d, c: 0.5653146543488808d),

new NpgsqlTypes.NpgsqlLine(a: 0.8148660813324691d, b: 0.5965502974097225d, c: 0.08598406767552191d),

new NpgsqlTypes.NpgsqlLine(a: 0.10261855436837408d, b: 0.22753843400620033d, c: 0.6663050101504865d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19047502268477823d, b: 0.503647750986701d, c: 0.5140837344549085d),

new NpgsqlTypes.NpgsqlLine(a: 0.5498279015442291d, b: 0.5205498180433044d, c: 0.5511400439881968d),

new NpgsqlTypes.NpgsqlLine(a: 0.07519565206915457d, b: 0.8190939422278946d, c: 0.4842243543091963d),

new NpgsqlTypes.NpgsqlLine(a: 0.11151345358207676d, b: 0.2794260095615846d, c: 0.1977999861392018d),

}
                        }

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlLine[])default));
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

                var expected = new Dictionary<System.Int32,NpgsqlLinelineArray1M>(30);

                expected.Add(
                    24431063,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 24431063,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7432562260700321d, b: 0.9027051106351455d, c: 0.20935776301702913d),

new NpgsqlTypes.NpgsqlLine(a: 0.06877648068052133d, b: 0.4638520424251973d, c: 0.8977581074629934d),

new NpgsqlTypes.NpgsqlLine(a: 0.19824889810271595d, b: 0.101805635004653d, c: 0.6376796129171594d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.25692356453649523d, b: 0.8249956321761069d, c: 0.7485760418256393d),

new NpgsqlTypes.NpgsqlLine(a: 0.5205543536927003d, b: 0.26409313743898866d, c: 0.11834223656249432d),

new NpgsqlTypes.NpgsqlLine(a: 0.12852097087774939d, b: 0.110468841038458d, c: 0.15781368742463253d),

new NpgsqlTypes.NpgsqlLine(a: 0.5056691167374713d, b: 0.17475361978672044d, c: 0.4301177356479713d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    88466632,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 88466632,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24038691940074952d, b: 0.4574071819075469d, c: 0.029018693781179494d),

new NpgsqlTypes.NpgsqlLine(a: 0.6230691191149946d, b: 0.6421350132669393d, c: 0.2591755154295573d),

new NpgsqlTypes.NpgsqlLine(a: 0.284214063978114d, b: 0.42055782459666247d, c: 0.4230265799247275d),

new NpgsqlTypes.NpgsqlLine(a: 0.2294933978523651d, b: 0.8434657220550107d, c: 0.1364803149185917d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 671378680,
                            Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.579485378096583d, b: 0.7644192687968542d, c: 0.38803543767659376d),

new NpgsqlTypes.NpgsqlLine(a: 0.9272224559192928d, b: 0.04309922869802718d, c: 0.1084146589578524d),

new NpgsqlTypes.NpgsqlLine(a: 0.6194396921461146d, b: 0.3135327751395446d, c: 0.47728859432318693d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22238461731837955d, b: 0.8832575247518029d, c: 0.5267192016109244d),

new NpgsqlTypes.NpgsqlLine(a: 0.2456814921559901d, b: 0.12396858431218405d, c: 0.7758983059785806d),

new NpgsqlTypes.NpgsqlLine(a: 0.8010355013907535d, b: 0.10724380078506457d, c: 0.8516226142927568d),

}
                        }

                    }
                );

                expected.Add(
                    214898413,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 214898413,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7273918164372143d, b: 0.3711769692436181d, c: 0.7468659136792664d),

new NpgsqlTypes.NpgsqlLine(a: 0.8155250372031967d, b: 0.5364157660240247d, c: 0.2587745327315204d),

new NpgsqlTypes.NpgsqlLine(a: 0.8823774478354753d, b: 0.24032876435579376d, c: 0.9187231882533503d),

new NpgsqlTypes.NpgsqlLine(a: 0.2761563267007917d, b: 0.8609521972165307d, c: 0.014350256291767893d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7060914743005817d, b: 0.29942700622480667d, c: 0.38464564338188945d),

new NpgsqlTypes.NpgsqlLine(a: 0.456801666295529d, b: 0.2750050419905442d, c: 0.6523990372650718d),

new NpgsqlTypes.NpgsqlLine(a: 0.593068234761201d, b: 0.986042625015402d, c: 0.7722918655162653d),

new NpgsqlTypes.NpgsqlLine(a: 0.8257270425360131d, b: 0.9234733383976109d, c: 0.16399605960296715d),

},

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 160844459,
                            Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.49742066568592347d, b: 0.13045995730850435d, c: 0.3240701079822569d),

new NpgsqlTypes.NpgsqlLine(a: 0.4230136983146885d, b: 0.4758823758243249d, c: 0.7245296150407883d),

new NpgsqlTypes.NpgsqlLine(a: 0.902525000709505d, b: 0.3096633545847971d, c: 0.7195095860492445d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    232426060,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 232426060,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7754569347332767d, b: 0.7449423603392903d, c: 0.7275357910733291d),

new NpgsqlTypes.NpgsqlLine(a: 0.9072872865290874d, b: 0.5188651109794405d, c: 0.49767196437474315d),

new NpgsqlTypes.NpgsqlLine(a: 0.7613773478086597d, b: 0.8726134777514618d, c: 0.7249287737318102d),

new NpgsqlTypes.NpgsqlLine(a: 0.31979325488547383d, b: 0.21963013317369884d, c: 0.995747479981123d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5136334997132156d, b: 0.4481836733144653d, c: 0.5566013930940901d),

new NpgsqlTypes.NpgsqlLine(a: 0.2628604279970359d, b: 0.34706683348460354d, c: 0.8618758810041756d),

new NpgsqlTypes.NpgsqlLine(a: 0.9066993846202163d, b: 0.9919335952888788d, c: 0.16647553451680086d),

new NpgsqlTypes.NpgsqlLine(a: 0.8084713734948656d, b: 0.9105928653749232d, c: 0.5871692331069964d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    287773256,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 287773256,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5468129373528992d, b: 0.4550697398151482d, c: 0.9323204190693627d),

new NpgsqlTypes.NpgsqlLine(a: 0.09290076953581794d, b: 0.06513797114322906d, c: 0.01453530584939322d),

new NpgsqlTypes.NpgsqlLine(a: 0.06819515445977387d, b: 0.13776512554356624d, c: 0.5971045649241554d),

new NpgsqlTypes.NpgsqlLine(a: 0.17602847632288898d, b: 0.8583377493377162d, c: 0.5319193518068348d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 2000087272,
                            Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5174417835536576d, b: 0.9550151039410834d, c: 0.94465021980697d),

new NpgsqlTypes.NpgsqlLine(a: 0.023498567205728516d, b: 0.14704570142511664d, c: 0.5436176118381062d),

new NpgsqlTypes.NpgsqlLine(a: 0.6410825125912296d, b: 0.1638519482392854d, c: 0.07442290044208977d),

new NpgsqlTypes.NpgsqlLine(a: 0.5684954410076702d, b: 0.9517870324925599d, c: 0.7913121037671743d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5546781844769255d, b: 0.3295435210405563d, c: 0.10332785525555d),

new NpgsqlTypes.NpgsqlLine(a: 0.8619184029547027d, b: 0.6893143841340763d, c: 0.6057919377815917d),

new NpgsqlTypes.NpgsqlLine(a: 0.6918049340506819d, b: 0.29564467871458977d, c: 0.373851052320022d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590711543927416d, b: 0.782456230485786d, c: 0.0557514543823312d),

}
                        }

                    }
                );

                expected.Add(
                    385864550,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 385864550,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22975102280111437d, b: 0.9248487581270293d, c: 0.13680981887715193d),

new NpgsqlTypes.NpgsqlLine(a: 0.09251582159332017d, b: 0.5284902712490177d, c: 0.5030244379828798d),

new NpgsqlTypes.NpgsqlLine(a: 0.3316636973424488d, b: 0.125908586516723d, c: 0.1307901665228316d),

new NpgsqlTypes.NpgsqlLine(a: 0.4488357278586823d, b: 0.4939460007710509d, c: 0.1486125807477222d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4793632894446783d, b: 0.7460924351194599d, c: 0.8333281971866928d),

new NpgsqlTypes.NpgsqlLine(a: 0.9911204719862435d, b: 0.02386428262012663d, c: 0.1749191984110413d),

new NpgsqlTypes.NpgsqlLine(a: 0.9855596015822274d, b: 0.652336551342683d, c: 0.13320036109805444d),

new NpgsqlTypes.NpgsqlLine(a: 0.2704642620419001d, b: 0.25815455585325764d, c: 0.781691467105331d),

},

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 507016837,
                            Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6329641939546133d, b: 0.7713358064075255d, c: 0.7091675230581173d),

new NpgsqlTypes.NpgsqlLine(a: 0.6401104534145889d, b: 0.4461488045009705d, c: 0.8050604324576476d),

new NpgsqlTypes.NpgsqlLine(a: 0.718200194405203d, b: 0.43497844061299695d, c: 0.8863292600245054d),

new NpgsqlTypes.NpgsqlLine(a: 0.6409377372303063d, b: 0.6727026439221405d, c: 0.709162570856183d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    425879955,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 425879955,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7120720914880876d, b: 0.12018496532744738d, c: 0.23458035596972604d),

new NpgsqlTypes.NpgsqlLine(a: 0.8966943482850258d, b: 0.35901938172619774d, c: 0.5153333646331681d),

new NpgsqlTypes.NpgsqlLine(a: 0.772529205234202d, b: 0.3302141544038909d, c: 0.49860223574471696d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    447065450,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 447065450,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6636554004535458d, b: 0.4052905058278198d, c: 0.17999403534412883d),

new NpgsqlTypes.NpgsqlLine(a: 0.4929643299593621d, b: 0.04102771738828992d, c: 0.8758588440576921d),

new NpgsqlTypes.NpgsqlLine(a: 0.9843591359807438d, b: 0.9486545770421181d, c: 0.23810538982780194d),

new NpgsqlTypes.NpgsqlLine(a: 0.0373504814930844d, b: 0.29650224807426506d, c: 0.6527517869517908d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 1935239880,
                            Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5125009420178407d, b: 0.13553866813087467d, c: 0.6573124881706722d),

new NpgsqlTypes.NpgsqlLine(a: 0.9315668534985179d, b: 0.031339976871202935d, c: 0.7319776155987312d),

new NpgsqlTypes.NpgsqlLine(a: 0.5913519522327184d, b: 0.688194613219936d, c: 0.7487303543444555d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    776647699,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 776647699,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8841755970938628d, b: 0.039993263617271846d, c: 0.2425222413816407d),

new NpgsqlTypes.NpgsqlLine(a: 0.3162669055857611d, b: 0.1360654949714053d, c: 0.585066125260232d),

new NpgsqlTypes.NpgsqlLine(a: 0.23614085233198578d, b: 0.9624524908146396d, c: 0.8036122013629919d),

new NpgsqlTypes.NpgsqlLine(a: 0.9594786748108928d, b: 0.3334512033062713d, c: 0.8626799508985245d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7692177568154062d, b: 0.8045212370680859d, c: 0.347836807601842d),

new NpgsqlTypes.NpgsqlLine(a: 0.8596806867272218d, b: 0.42225206488490163d, c: 0.2626771759427945d),

new NpgsqlTypes.NpgsqlLine(a: 0.6334601490046422d, b: 0.5508277640730257d, c: 0.9702039181027914d),

new NpgsqlTypes.NpgsqlLine(a: 0.7862671596820799d, b: 0.6148121550149941d, c: 0.10467782441316142d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    920410273,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 920410273,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7950181430955406d, b: 0.3848051391253504d, c: 0.1572657802170856d),

new NpgsqlTypes.NpgsqlLine(a: 0.6062151918599252d, b: 0.06062326101597226d, c: 0.14777044879318857d),

new NpgsqlTypes.NpgsqlLine(a: 0.7408182398935058d, b: 0.6661433504932776d, c: 0.15722709569280902d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2482561889064241d, b: 0.768360521777252d, c: 0.24033198573060877d),

new NpgsqlTypes.NpgsqlLine(a: 0.6078828832971318d, b: 0.25910942482320465d, c: 0.7624300130707319d),

new NpgsqlTypes.NpgsqlLine(a: 0.551230062109523d, b: 0.5951997473266207d, c: 0.05557568229198884d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    929385902,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 929385902,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8285395037487209d, b: 0.25070273066629d, c: 0.2500673109161923d),

new NpgsqlTypes.NpgsqlLine(a: 0.9942717530143405d, b: 0.21539215026712022d, c: 0.20269945939501077d),

new NpgsqlTypes.NpgsqlLine(a: 0.7979702358088475d, b: 0.0037115614378556705d, c: 0.8843432168677479d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1456202870910711d, b: 0.06772665910903597d, c: 0.691750610472359d),

new NpgsqlTypes.NpgsqlLine(a: 0.765757989281042d, b: 0.32982835634782004d, c: 0.8913701807765988d),

new NpgsqlTypes.NpgsqlLine(a: 0.052240732409688406d, b: 0.618262798295761d, c: 0.8474290495942781d),

new NpgsqlTypes.NpgsqlLine(a: 0.3584922315949717d, b: 0.520574773115294d, c: 0.8310230234204736d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    939691488,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 939691488,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15928813769803307d, b: 0.5335096410959914d, c: 0.9693141891385088d),

new NpgsqlTypes.NpgsqlLine(a: 0.9448241901930845d, b: 0.6287076527827521d, c: 0.6660617468801671d),

new NpgsqlTypes.NpgsqlLine(a: 0.30712778702622445d, b: 0.324942912367581d, c: 0.9500282198259326d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    940484658,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 940484658,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8457530794410952d, b: 0.07468146527745967d, c: 0.6058450234777081d),

new NpgsqlTypes.NpgsqlLine(a: 0.43907623012482566d, b: 0.4163533057091461d, c: 0.7083053151407345d),

new NpgsqlTypes.NpgsqlLine(a: 0.6460729456777172d, b: 0.3996032448892458d, c: 0.32058136990645736d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5056133907420888d, b: 0.687789482585691d, c: 0.5736898296981361d),

new NpgsqlTypes.NpgsqlLine(a: 0.6165837793609097d, b: 0.3896094649555947d, c: 0.782529168193896d),

new NpgsqlTypes.NpgsqlLine(a: 0.19522061405511182d, b: 0.49515141325692447d, c: 0.8154303350690599d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    956171576,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 956171576,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6305558129660189d, b: 0.5463622939629917d, c: 0.401891977997777d),

new NpgsqlTypes.NpgsqlLine(a: 0.3662230087345998d, b: 0.4302679455886196d, c: 0.9631184941583132d),

new NpgsqlTypes.NpgsqlLine(a: 0.3634906094993412d, b: 0.18046820180120404d, c: 0.5193725822662353d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48533853922222536d, b: 0.7781157007327932d, c: 0.20671476643143427d),

new NpgsqlTypes.NpgsqlLine(a: 0.7321919326621603d, b: 0.7704043405190548d, c: 0.5508846640658778d),

new NpgsqlTypes.NpgsqlLine(a: 0.5796306726535371d, b: 0.3621536966457104d, c: 0.3554092618887771d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1049476690,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1049476690,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1703167002028123d, b: 0.06899134909065618d, c: 0.39632655876575884d),

new NpgsqlTypes.NpgsqlLine(a: 0.9436521110809849d, b: 0.2716102490692832d, c: 0.21807972083943694d),

new NpgsqlTypes.NpgsqlLine(a: 0.07510391898176405d, b: 0.4622700624960824d, c: 0.6916474126671974d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3434566231012316d, b: 0.6092872970160005d, c: 0.8285200623737458d),

new NpgsqlTypes.NpgsqlLine(a: 0.438620087459067d, b: 0.42784452615069857d, c: 0.43791996431227087d),

new NpgsqlTypes.NpgsqlLine(a: 0.13822472685663223d, b: 0.3567687904324768d, c: 0.5713362361619454d),

new NpgsqlTypes.NpgsqlLine(a: 0.4225842002023096d, b: 0.13041963778907273d, c: 0.537431949671262d),

},

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 259689541,
                            Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16915141278580792d, b: 0.5107686791340034d, c: 0.6489920882506348d),

new NpgsqlTypes.NpgsqlLine(a: 0.030879513236027d, b: 0.6401283771223818d, c: 0.4904762444562075d),

new NpgsqlTypes.NpgsqlLine(a: 0.16124954101586042d, b: 0.7102870300472969d, c: 0.9978682907813775d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3413197342637151d, b: 0.3564754218301692d, c: 0.16698356005321802d),

new NpgsqlTypes.NpgsqlLine(a: 0.24996465538547474d, b: 0.6936235099874405d, c: 0.00768766971096424d),

new NpgsqlTypes.NpgsqlLine(a: 0.9713834412198872d, b: 0.1937685310996965d, c: 0.5638524218711839d),

new NpgsqlTypes.NpgsqlLine(a: 0.20790035052620326d, b: 0.7280555648340241d, c: 0.7150389111804211d),

}
                        }

                    }
                );

                expected.Add(
                    1169283916,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1169283916,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6136867588329713d, b: 0.8476721243007673d, c: 0.2920466838690219d),

new NpgsqlTypes.NpgsqlLine(a: 0.5632572533709046d, b: 0.8580393386665631d, c: 0.29067186403759726d),

new NpgsqlTypes.NpgsqlLine(a: 0.05864985939465561d, b: 0.06933376015004311d, c: 0.2622230618531959d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3083889075922114d, b: 0.40504233141015844d, c: 0.7282625593772889d),

new NpgsqlTypes.NpgsqlLine(a: 0.9760389595620657d, b: 0.5432046524856411d, c: 0.4805721407516501d),

new NpgsqlTypes.NpgsqlLine(a: 0.226094370846618d, b: 0.30929816503923757d, c: 0.749788108094253d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1247961184,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1247961184,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9588334999708729d, b: 0.5781258655739143d, c: 0.4951203893647069d),

new NpgsqlTypes.NpgsqlLine(a: 0.206651781249944d, b: 0.9214488824097644d, c: 0.7102197735978709d),

new NpgsqlTypes.NpgsqlLine(a: 0.8293873017859008d, b: 0.4197388618664637d, c: 0.7538628331143343d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9886122302398814d, b: 0.09733443476141157d, c: 0.8828756753279827d),

new NpgsqlTypes.NpgsqlLine(a: 0.4191781730328399d, b: 0.8360940579259326d, c: 0.3115604346093266d),

new NpgsqlTypes.NpgsqlLine(a: 0.03123256692948395d, b: 0.4210178852779579d, c: 0.7083559364281564d),

new NpgsqlTypes.NpgsqlLine(a: 0.10193811062121638d, b: 0.7865607707379441d, c: 0.5102014504618864d),

},

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 313349652,
                            Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7148027863911385d, b: 0.4116315290140842d, c: 0.9883513693293022d),

new NpgsqlTypes.NpgsqlLine(a: 0.730798769811796d, b: 0.5625059295801093d, c: 0.028144945623879147d),

new NpgsqlTypes.NpgsqlLine(a: 0.7895921923207063d, b: 0.897092096080744d, c: 0.36804397804374556d),

new NpgsqlTypes.NpgsqlLine(a: 0.4403951364132078d, b: 0.48316034726668566d, c: 0.5561087583026281d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1251267268,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1251267268,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.27064576558959075d, b: 0.24611103650290955d, c: 0.04928435530376152d),

new NpgsqlTypes.NpgsqlLine(a: 0.5382620257248645d, b: 0.586731968734226d, c: 0.9110741668368397d),

new NpgsqlTypes.NpgsqlLine(a: 0.8386954216871374d, b: 0.14045527908308764d, c: 0.5300328684198944d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7572326327773035d, b: 0.10039993499818312d, c: 0.17339739029118428d),

new NpgsqlTypes.NpgsqlLine(a: 0.9566618331567527d, b: 0.14668861402647748d, c: 0.7767711369985796d),

new NpgsqlTypes.NpgsqlLine(a: 0.932727244163919d, b: 0.12159065636952726d, c: 0.1704609096711438d),

new NpgsqlTypes.NpgsqlLine(a: 0.5792460825794749d, b: 0.985437582839235d, c: 0.557473090399633d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1276251566,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1276251566,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4808529939808879d, b: 0.365247596328651d, c: 0.17939866902766977d),

new NpgsqlTypes.NpgsqlLine(a: 0.12809708913748585d, b: 0.18821025600986407d, c: 0.9740037535570704d),

new NpgsqlTypes.NpgsqlLine(a: 0.7729579560840041d, b: 0.5283959837814016d, c: 0.3246873097765165d),

new NpgsqlTypes.NpgsqlLine(a: 0.5804554841359071d, b: 0.7951318743812129d, c: 0.9533437460862759d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07357632206959641d, b: 0.11099061080365447d, c: 0.47576723756466854d),

new NpgsqlTypes.NpgsqlLine(a: 0.9051522311200175d, b: 0.6041352781626989d, c: 0.962846313750425d),

new NpgsqlTypes.NpgsqlLine(a: 0.7230697163609032d, b: 0.35996997662147945d, c: 0.2719627850842049d),

new NpgsqlTypes.NpgsqlLine(a: 0.039972657007877d, b: 0.6660692046588974d, c: 0.8074219604808613d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1278639929,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1278639929,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8637991908928382d, b: 0.7989476928355281d, c: 0.047074497669961635d),

new NpgsqlTypes.NpgsqlLine(a: 0.24284327761860214d, b: 0.034845279321367495d, c: 0.8243144068858446d),

new NpgsqlTypes.NpgsqlLine(a: 0.2705173386529084d, b: 0.37759514414776285d, c: 0.003784057263189533d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5464646368268954d, b: 0.1698011067851829d, c: 0.4811896051504386d),

new NpgsqlTypes.NpgsqlLine(a: 0.3264558304845737d, b: 0.09741548986796533d, c: 0.35078408755418944d),

new NpgsqlTypes.NpgsqlLine(a: 0.1253849539183054d, b: 0.9184504405667023d, c: 0.6244095303662431d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1352296160,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1352296160,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6961581521563707d, b: 0.2870425810465653d, c: 0.022813771410836625d),

new NpgsqlTypes.NpgsqlLine(a: 0.9289180434806266d, b: 0.10310192777053839d, c: 0.4974840036652155d),

new NpgsqlTypes.NpgsqlLine(a: 0.9742618124298718d, b: 0.666155889593685d, c: 0.9108800941033853d),

new NpgsqlTypes.NpgsqlLine(a: 0.4076993728994177d, b: 0.9237619110159688d, c: 0.16349574316883708d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.40245830157937157d, b: 0.4425237993192568d, c: 0.3605907953188545d),

new NpgsqlTypes.NpgsqlLine(a: 0.3025387755185438d, b: 0.16175616826033246d, c: 0.08369914886846197d),

new NpgsqlTypes.NpgsqlLine(a: 0.7932786053551402d, b: 0.4757892941852452d, c: 0.35215963103511483d),

},

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 2052209240,
                            Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28682097488067404d, b: 0.19347953745544d, c: 0.767001580247448d),

new NpgsqlTypes.NpgsqlLine(a: 0.34168929191792363d, b: 0.5324263819109204d, c: 0.3548736591683712d),

new NpgsqlTypes.NpgsqlLine(a: 0.7601584215479089d, b: 0.9667193856859281d, c: 0.48805620341333844d),

new NpgsqlTypes.NpgsqlLine(a: 0.4778030273140724d, b: 0.6459214140044727d, c: 0.9825570138966864d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1422030401,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1422030401,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5508950376990435d, b: 0.1842011543506923d, c: 0.7200839172656331d),

new NpgsqlTypes.NpgsqlLine(a: 0.08098131741133519d, b: 0.2512744482896645d, c: 0.4419893154281408d),

new NpgsqlTypes.NpgsqlLine(a: 0.7183180834237055d, b: 0.3821225061156569d, c: 0.320010478004808d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.605461690855222d, b: 0.5098249599693536d, c: 0.049446338505273246d),

new NpgsqlTypes.NpgsqlLine(a: 0.6383133050473475d, b: 0.5385834180776717d, c: 0.2612256906158803d),

new NpgsqlTypes.NpgsqlLine(a: 0.2259744218921168d, b: 0.0504022254415285d, c: 0.5085817881315488d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1441068318,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1441068318,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04431673188157559d, b: 0.7118895502319815d, c: 0.8045459394080527d),

new NpgsqlTypes.NpgsqlLine(a: 0.41883883343441664d, b: 0.0856133325697227d, c: 0.45940150990219364d),

new NpgsqlTypes.NpgsqlLine(a: 0.3845455332415372d, b: 0.5278908004707358d, c: 0.45211852173959755d),

new NpgsqlTypes.NpgsqlLine(a: 0.707344526938849d, b: 0.2664835051263448d, c: 0.8012907013628192d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5167014945187821d, b: 0.2318523474732329d, c: 0.0766480392056259d),

new NpgsqlTypes.NpgsqlLine(a: 0.6239339834043951d, b: 0.4407650281616141d, c: 0.07711199216030074d),

new NpgsqlTypes.NpgsqlLine(a: 0.7330247230488705d, b: 0.06195929907587139d, c: 0.1736910797965654d),

new NpgsqlTypes.NpgsqlLine(a: 0.5060985759956755d, b: 0.12918142066992122d, c: 0.3598502037154421d),

},

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 1349638635,
                            Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8811777097968191d, b: 0.09805743628781294d, c: 0.8476023389336619d),

new NpgsqlTypes.NpgsqlLine(a: 0.16329696312104391d, b: 0.8434248077846473d, c: 0.0171626874853823d),

new NpgsqlTypes.NpgsqlLine(a: 0.5930114320798587d, b: 0.7874763150232159d, c: 0.20169365861720767d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1485177216,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1485177216,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7620135774845544d, b: 0.72234986247445d, c: 0.7900958363555012d),

new NpgsqlTypes.NpgsqlLine(a: 0.5982892074823093d, b: 0.9157569165822279d, c: 0.5913666560112503d),

new NpgsqlTypes.NpgsqlLine(a: 0.3694255096703286d, b: 0.43689654039349735d, c: 0.27488642071951885d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 1888587968,
                            Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9441675468790086d, b: 0.10273087249159918d, c: 0.36496868371913627d),

new NpgsqlTypes.NpgsqlLine(a: 0.3153900895384264d, b: 0.8953921593705707d, c: 0.6821583482258307d),

new NpgsqlTypes.NpgsqlLine(a: 0.15884512105184567d, b: 0.20745599422324912d, c: 0.5928677501305737d),

new NpgsqlTypes.NpgsqlLine(a: 0.19203772899196803d, b: 0.9281999546867626d, c: 0.9792553764463741d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.616453689236877d, b: 0.26880075600348696d, c: 0.9911672578342802d),

new NpgsqlTypes.NpgsqlLine(a: 0.41598816366831615d, b: 0.2972198032481773d, c: 0.6096249065094251d),

new NpgsqlTypes.NpgsqlLine(a: 0.21461782395965212d, b: 0.4996081675192614d, c: 0.845029551763019d),

new NpgsqlTypes.NpgsqlLine(a: 0.14603833144353173d, b: 0.5155958582129082d, c: 0.9513100476397736d),

}
                        }

                    }
                );

                expected.Add(
                    1612037280,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1612037280,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9755688560619167d, b: 0.7517347444178538d, c: 0.4433097656621017d),

new NpgsqlTypes.NpgsqlLine(a: 0.27642151559126893d, b: 0.49560032188535075d, c: 0.4017019854911661d),

new NpgsqlTypes.NpgsqlLine(a: 0.48234378585453686d, b: 0.5838608048706788d, c: 0.45264440736135125d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 1803941428,
                            Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4958174274877982d, b: 0.19935005698584918d, c: 0.6570481803156852d),

new NpgsqlTypes.NpgsqlLine(a: 0.586031122116916d, b: 0.20438200508300097d, c: 0.7214279726394314d),

new NpgsqlTypes.NpgsqlLine(a: 0.3287771922455527d, b: 0.31464931534195395d, c: 0.49275260904707807d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1694903385,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1694903385,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5133551130062282d, b: 0.5981369379522861d, c: 0.5856516805262975d),

new NpgsqlTypes.NpgsqlLine(a: 0.4556255479239121d, b: 0.059243842569019045d, c: 0.18272228811839042d),

new NpgsqlTypes.NpgsqlLine(a: 0.8085308768004308d, b: 0.8348590541320315d, c: 0.5895099353964641d),

new NpgsqlTypes.NpgsqlLine(a: 0.24149968696186774d, b: 0.35557480082622506d, c: 0.5451461752136405d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1708194464,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1708194464,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21378574042766885d, b: 0.22474127876321393d, c: 0.01286635194062602d),

new NpgsqlTypes.NpgsqlLine(a: 0.44720527497131246d, b: 0.83386820783986d, c: 0.47600740851603984d),

new NpgsqlTypes.NpgsqlLine(a: 0.9177345103701179d, b: 0.8135674766115204d, c: 0.23923291716083794d),

new NpgsqlTypes.NpgsqlLine(a: 0.9998743487003019d, b: 0.013427841900149451d, c: 0.9133209978570025d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 871029693,
                            Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09314286666835214d, b: 0.9419395542104619d, c: 0.23265001920909978d),

new NpgsqlTypes.NpgsqlLine(a: 0.7840922282915723d, b: 0.8769622177219351d, c: 0.08844919095146764d),

new NpgsqlTypes.NpgsqlLine(a: 0.30172065868559383d, b: 0.061796126836928256d, c: 0.7819510380905712d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1749272119,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1749272119,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48465570613062037d, b: 0.4077570571696034d, c: 0.09124205112015671d),

new NpgsqlTypes.NpgsqlLine(a: 0.4905692123673753d, b: 0.09753381316271936d, c: 0.6219861110019185d),

new NpgsqlTypes.NpgsqlLine(a: 0.7715584772299492d, b: 0.7647042738214676d, c: 0.32981711302760286d),

new NpgsqlTypes.NpgsqlLine(a: 0.7826950107361046d, b: 0.6159017458991703d, c: 0.8761288210787351d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05854830086605134d, b: 0.4584727830793912d, c: 0.6485776355671607d),

new NpgsqlTypes.NpgsqlLine(a: 0.057402368952540694d, b: 0.814338567877536d, c: 0.36045674525095406d),

new NpgsqlTypes.NpgsqlLine(a: 0.4609921668504162d, b: 0.45446719793916357d, c: 0.6647833262693906d),

new NpgsqlTypes.NpgsqlLine(a: 0.8421363107491464d, b: 0.8724917366553757d, c: 0.2954174236384989d),

},

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 1743101311,
                            Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30049737151744216d, b: 0.10935998965187232d, c: 0.12002566064851483d),

new NpgsqlTypes.NpgsqlLine(a: 0.4579983959880112d, b: 0.8700234892072651d, c: 0.24545341370685325d),

new NpgsqlTypes.NpgsqlLine(a: 0.6992061752442d, b: 0.8760611086508132d, c: 0.31896424715232463d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14975557199832845d, b: 0.8649037801511367d, c: 0.8035067258718913d),

new NpgsqlTypes.NpgsqlLine(a: 0.022767088770272226d, b: 0.824519829812387d, c: 0.2990170967826957d),

new NpgsqlTypes.NpgsqlLine(a: 0.264229467978496d, b: 0.4707396384081288d, c: 0.5870444614457326d),

}
                        }

                    }
                );

                expected.Add(
                    1750072079,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1750072079,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6509605768915644d, b: 0.2871280523199907d, c: 0.5279864073907687d),

new NpgsqlTypes.NpgsqlLine(a: 0.847627780191932d, b: 0.2863239370866939d, c: 0.39664595009550063d),

new NpgsqlTypes.NpgsqlLine(a: 0.06719070091173818d, b: 0.2998868113793318d, c: 0.8109899934095542d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30402634597868494d, b: 0.7741177113732105d, c: 0.4982697795456863d),

new NpgsqlTypes.NpgsqlLine(a: 0.22134239051678783d, b: 0.952989590947333d, c: 0.1976805178607327d),

new NpgsqlTypes.NpgsqlLine(a: 0.48019693876130953d, b: 0.8553553442730837d, c: 0.4578014530562905d),

new NpgsqlTypes.NpgsqlLine(a: 0.7948720279836796d, b: 0.6347165612507009d, c: 0.4915047790558922d),

},

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 681877477,
                            Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.054876749435908034d, b: 0.7476698065656858d, c: 0.5221215501493097d),

new NpgsqlTypes.NpgsqlLine(a: 0.1689911006864584d, b: 0.16032672190790076d, c: 0.9537953031702238d),

new NpgsqlTypes.NpgsqlLine(a: 0.3133690487713232d, b: 0.21425817972116357d, c: 0.39002508371565625d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1765269457,
                    new NpgsqlLinelineArray1M
                    {
                        Id = 1765269457,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4428210775962541d, b: 0.44628545865868685d, c: 0.7913435097925557d),

new NpgsqlTypes.NpgsqlLine(a: 0.26419018627718516d, b: 0.12166427922453704d, c: 0.11250832552770584d),

new NpgsqlTypes.NpgsqlLine(a: 0.20276585628171784d, b: 0.14489314174625478d, c: 0.5410582863519566d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlLinelineArray1MI
                        {
                            Id = 699428708,
                            Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.75437435623167d, b: 0.4381969103973332d, c: 0.13859938549471296d),

new NpgsqlTypes.NpgsqlLine(a: 0.22478326045746155d, b: 0.7927996319630696d, c: 0.5653146543488808d),

new NpgsqlTypes.NpgsqlLine(a: 0.8148660813324691d, b: 0.5965502974097225d, c: 0.08598406767552191d),

new NpgsqlTypes.NpgsqlLine(a: 0.10261855436837408d, b: 0.22753843400620033d, c: 0.6663050101504865d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19047502268477823d, b: 0.503647750986701d, c: 0.5140837344549085d),

new NpgsqlTypes.NpgsqlLine(a: 0.5498279015442291d, b: 0.5205498180433044d, c: 0.5511400439881968d),

new NpgsqlTypes.NpgsqlLine(a: 0.07519565206915457d, b: 0.8190939422278946d, c: 0.4842243543091963d),

new NpgsqlTypes.NpgsqlLine(a: 0.11151345358207676d, b: 0.2794260095615846d, c: 0.1977999861392018d),

}
                        }

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlLine[])default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MI),
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

                var expected = new Dictionary<System.Int32,NpgsqlLinelineArray1MI>(15);

                expected.Add(
                    160844459,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 160844459,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.49742066568592347d, b: 0.13045995730850435d, c: 0.3240701079822569d),

new NpgsqlTypes.NpgsqlLine(a: 0.4230136983146885d, b: 0.4758823758243249d, c: 0.7245296150407883d),

new NpgsqlTypes.NpgsqlLine(a: 0.902525000709505d, b: 0.3096633545847971d, c: 0.7195095860492445d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    259689541,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 259689541,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16915141278580792d, b: 0.5107686791340034d, c: 0.6489920882506348d),

new NpgsqlTypes.NpgsqlLine(a: 0.030879513236027d, b: 0.6401283771223818d, c: 0.4904762444562075d),

new NpgsqlTypes.NpgsqlLine(a: 0.16124954101586042d, b: 0.7102870300472969d, c: 0.9978682907813775d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3413197342637151d, b: 0.3564754218301692d, c: 0.16698356005321802d),

new NpgsqlTypes.NpgsqlLine(a: 0.24996465538547474d, b: 0.6936235099874405d, c: 0.00768766971096424d),

new NpgsqlTypes.NpgsqlLine(a: 0.9713834412198872d, b: 0.1937685310996965d, c: 0.5638524218711839d),

new NpgsqlTypes.NpgsqlLine(a: 0.20790035052620326d, b: 0.7280555648340241d, c: 0.7150389111804211d),

}
                    }
                );

                expected.Add(
                    313349652,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 313349652,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7148027863911385d, b: 0.4116315290140842d, c: 0.9883513693293022d),

new NpgsqlTypes.NpgsqlLine(a: 0.730798769811796d, b: 0.5625059295801093d, c: 0.028144945623879147d),

new NpgsqlTypes.NpgsqlLine(a: 0.7895921923207063d, b: 0.897092096080744d, c: 0.36804397804374556d),

new NpgsqlTypes.NpgsqlLine(a: 0.4403951364132078d, b: 0.48316034726668566d, c: 0.5561087583026281d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    507016837,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 507016837,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6329641939546133d, b: 0.7713358064075255d, c: 0.7091675230581173d),

new NpgsqlTypes.NpgsqlLine(a: 0.6401104534145889d, b: 0.4461488045009705d, c: 0.8050604324576476d),

new NpgsqlTypes.NpgsqlLine(a: 0.718200194405203d, b: 0.43497844061299695d, c: 0.8863292600245054d),

new NpgsqlTypes.NpgsqlLine(a: 0.6409377372303063d, b: 0.6727026439221405d, c: 0.709162570856183d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    671378680,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 671378680,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.579485378096583d, b: 0.7644192687968542d, c: 0.38803543767659376d),

new NpgsqlTypes.NpgsqlLine(a: 0.9272224559192928d, b: 0.04309922869802718d, c: 0.1084146589578524d),

new NpgsqlTypes.NpgsqlLine(a: 0.6194396921461146d, b: 0.3135327751395446d, c: 0.47728859432318693d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22238461731837955d, b: 0.8832575247518029d, c: 0.5267192016109244d),

new NpgsqlTypes.NpgsqlLine(a: 0.2456814921559901d, b: 0.12396858431218405d, c: 0.7758983059785806d),

new NpgsqlTypes.NpgsqlLine(a: 0.8010355013907535d, b: 0.10724380078506457d, c: 0.8516226142927568d),

}
                    }
                );

                expected.Add(
                    681877477,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 681877477,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.054876749435908034d, b: 0.7476698065656858d, c: 0.5221215501493097d),

new NpgsqlTypes.NpgsqlLine(a: 0.1689911006864584d, b: 0.16032672190790076d, c: 0.9537953031702238d),

new NpgsqlTypes.NpgsqlLine(a: 0.3133690487713232d, b: 0.21425817972116357d, c: 0.39002508371565625d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    699428708,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 699428708,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.75437435623167d, b: 0.4381969103973332d, c: 0.13859938549471296d),

new NpgsqlTypes.NpgsqlLine(a: 0.22478326045746155d, b: 0.7927996319630696d, c: 0.5653146543488808d),

new NpgsqlTypes.NpgsqlLine(a: 0.8148660813324691d, b: 0.5965502974097225d, c: 0.08598406767552191d),

new NpgsqlTypes.NpgsqlLine(a: 0.10261855436837408d, b: 0.22753843400620033d, c: 0.6663050101504865d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19047502268477823d, b: 0.503647750986701d, c: 0.5140837344549085d),

new NpgsqlTypes.NpgsqlLine(a: 0.5498279015442291d, b: 0.5205498180433044d, c: 0.5511400439881968d),

new NpgsqlTypes.NpgsqlLine(a: 0.07519565206915457d, b: 0.8190939422278946d, c: 0.4842243543091963d),

new NpgsqlTypes.NpgsqlLine(a: 0.11151345358207676d, b: 0.2794260095615846d, c: 0.1977999861392018d),

}
                    }
                );

                expected.Add(
                    871029693,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 871029693,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09314286666835214d, b: 0.9419395542104619d, c: 0.23265001920909978d),

new NpgsqlTypes.NpgsqlLine(a: 0.7840922282915723d, b: 0.8769622177219351d, c: 0.08844919095146764d),

new NpgsqlTypes.NpgsqlLine(a: 0.30172065868559383d, b: 0.061796126836928256d, c: 0.7819510380905712d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1349638635,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 1349638635,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8811777097968191d, b: 0.09805743628781294d, c: 0.8476023389336619d),

new NpgsqlTypes.NpgsqlLine(a: 0.16329696312104391d, b: 0.8434248077846473d, c: 0.0171626874853823d),

new NpgsqlTypes.NpgsqlLine(a: 0.5930114320798587d, b: 0.7874763150232159d, c: 0.20169365861720767d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1743101311,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 1743101311,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30049737151744216d, b: 0.10935998965187232d, c: 0.12002566064851483d),

new NpgsqlTypes.NpgsqlLine(a: 0.4579983959880112d, b: 0.8700234892072651d, c: 0.24545341370685325d),

new NpgsqlTypes.NpgsqlLine(a: 0.6992061752442d, b: 0.8760611086508132d, c: 0.31896424715232463d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14975557199832845d, b: 0.8649037801511367d, c: 0.8035067258718913d),

new NpgsqlTypes.NpgsqlLine(a: 0.022767088770272226d, b: 0.824519829812387d, c: 0.2990170967826957d),

new NpgsqlTypes.NpgsqlLine(a: 0.264229467978496d, b: 0.4707396384081288d, c: 0.5870444614457326d),

}
                    }
                );

                expected.Add(
                    1803941428,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 1803941428,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4958174274877982d, b: 0.19935005698584918d, c: 0.6570481803156852d),

new NpgsqlTypes.NpgsqlLine(a: 0.586031122116916d, b: 0.20438200508300097d, c: 0.7214279726394314d),

new NpgsqlTypes.NpgsqlLine(a: 0.3287771922455527d, b: 0.31464931534195395d, c: 0.49275260904707807d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1888587968,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 1888587968,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9441675468790086d, b: 0.10273087249159918d, c: 0.36496868371913627d),

new NpgsqlTypes.NpgsqlLine(a: 0.3153900895384264d, b: 0.8953921593705707d, c: 0.6821583482258307d),

new NpgsqlTypes.NpgsqlLine(a: 0.15884512105184567d, b: 0.20745599422324912d, c: 0.5928677501305737d),

new NpgsqlTypes.NpgsqlLine(a: 0.19203772899196803d, b: 0.9281999546867626d, c: 0.9792553764463741d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.616453689236877d, b: 0.26880075600348696d, c: 0.9911672578342802d),

new NpgsqlTypes.NpgsqlLine(a: 0.41598816366831615d, b: 0.2972198032481773d, c: 0.6096249065094251d),

new NpgsqlTypes.NpgsqlLine(a: 0.21461782395965212d, b: 0.4996081675192614d, c: 0.845029551763019d),

new NpgsqlTypes.NpgsqlLine(a: 0.14603833144353173d, b: 0.5155958582129082d, c: 0.9513100476397736d),

}
                    }
                );

                expected.Add(
                    1935239880,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 1935239880,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5125009420178407d, b: 0.13553866813087467d, c: 0.6573124881706722d),

new NpgsqlTypes.NpgsqlLine(a: 0.9315668534985179d, b: 0.031339976871202935d, c: 0.7319776155987312d),

new NpgsqlTypes.NpgsqlLine(a: 0.5913519522327184d, b: 0.688194613219936d, c: 0.7487303543444555d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    2000087272,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 2000087272,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5174417835536576d, b: 0.9550151039410834d, c: 0.94465021980697d),

new NpgsqlTypes.NpgsqlLine(a: 0.023498567205728516d, b: 0.14704570142511664d, c: 0.5436176118381062d),

new NpgsqlTypes.NpgsqlLine(a: 0.6410825125912296d, b: 0.1638519482392854d, c: 0.07442290044208977d),

new NpgsqlTypes.NpgsqlLine(a: 0.5684954410076702d, b: 0.9517870324925599d, c: 0.7913121037671743d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5546781844769255d, b: 0.3295435210405563d, c: 0.10332785525555d),

new NpgsqlTypes.NpgsqlLine(a: 0.8619184029547027d, b: 0.6893143841340763d, c: 0.6057919377815917d),

new NpgsqlTypes.NpgsqlLine(a: 0.6918049340506819d, b: 0.29564467871458977d, c: 0.373851052320022d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590711543927416d, b: 0.782456230485786d, c: 0.0557514543823312d),

}
                    }
                );

                expected.Add(
                    2052209240,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 2052209240,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28682097488067404d, b: 0.19347953745544d, c: 0.767001580247448d),

new NpgsqlTypes.NpgsqlLine(a: 0.34168929191792363d, b: 0.5324263819109204d, c: 0.3548736591683712d),

new NpgsqlTypes.NpgsqlLine(a: 0.7601584215479089d, b: 0.9667193856859281d, c: 0.48805620341333844d),

new NpgsqlTypes.NpgsqlLine(a: 0.4778030273140724d, b: 0.6459214140044727d, c: 0.9825570138966864d),

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

                var expected = new Dictionary<System.Int32,NpgsqlLinelineArray1MI>(15);

                expected.Add(
                    160844459,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 160844459,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.49742066568592347d, b: 0.13045995730850435d, c: 0.3240701079822569d),

new NpgsqlTypes.NpgsqlLine(a: 0.4230136983146885d, b: 0.4758823758243249d, c: 0.7245296150407883d),

new NpgsqlTypes.NpgsqlLine(a: 0.902525000709505d, b: 0.3096633545847971d, c: 0.7195095860492445d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    259689541,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 259689541,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16915141278580792d, b: 0.5107686791340034d, c: 0.6489920882506348d),

new NpgsqlTypes.NpgsqlLine(a: 0.030879513236027d, b: 0.6401283771223818d, c: 0.4904762444562075d),

new NpgsqlTypes.NpgsqlLine(a: 0.16124954101586042d, b: 0.7102870300472969d, c: 0.9978682907813775d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3413197342637151d, b: 0.3564754218301692d, c: 0.16698356005321802d),

new NpgsqlTypes.NpgsqlLine(a: 0.24996465538547474d, b: 0.6936235099874405d, c: 0.00768766971096424d),

new NpgsqlTypes.NpgsqlLine(a: 0.9713834412198872d, b: 0.1937685310996965d, c: 0.5638524218711839d),

new NpgsqlTypes.NpgsqlLine(a: 0.20790035052620326d, b: 0.7280555648340241d, c: 0.7150389111804211d),

}
                    }
                );

                expected.Add(
                    313349652,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 313349652,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7148027863911385d, b: 0.4116315290140842d, c: 0.9883513693293022d),

new NpgsqlTypes.NpgsqlLine(a: 0.730798769811796d, b: 0.5625059295801093d, c: 0.028144945623879147d),

new NpgsqlTypes.NpgsqlLine(a: 0.7895921923207063d, b: 0.897092096080744d, c: 0.36804397804374556d),

new NpgsqlTypes.NpgsqlLine(a: 0.4403951364132078d, b: 0.48316034726668566d, c: 0.5561087583026281d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    507016837,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 507016837,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6329641939546133d, b: 0.7713358064075255d, c: 0.7091675230581173d),

new NpgsqlTypes.NpgsqlLine(a: 0.6401104534145889d, b: 0.4461488045009705d, c: 0.8050604324576476d),

new NpgsqlTypes.NpgsqlLine(a: 0.718200194405203d, b: 0.43497844061299695d, c: 0.8863292600245054d),

new NpgsqlTypes.NpgsqlLine(a: 0.6409377372303063d, b: 0.6727026439221405d, c: 0.709162570856183d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    671378680,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 671378680,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.579485378096583d, b: 0.7644192687968542d, c: 0.38803543767659376d),

new NpgsqlTypes.NpgsqlLine(a: 0.9272224559192928d, b: 0.04309922869802718d, c: 0.1084146589578524d),

new NpgsqlTypes.NpgsqlLine(a: 0.6194396921461146d, b: 0.3135327751395446d, c: 0.47728859432318693d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22238461731837955d, b: 0.8832575247518029d, c: 0.5267192016109244d),

new NpgsqlTypes.NpgsqlLine(a: 0.2456814921559901d, b: 0.12396858431218405d, c: 0.7758983059785806d),

new NpgsqlTypes.NpgsqlLine(a: 0.8010355013907535d, b: 0.10724380078506457d, c: 0.8516226142927568d),

}
                    }
                );

                expected.Add(
                    681877477,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 681877477,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.054876749435908034d, b: 0.7476698065656858d, c: 0.5221215501493097d),

new NpgsqlTypes.NpgsqlLine(a: 0.1689911006864584d, b: 0.16032672190790076d, c: 0.9537953031702238d),

new NpgsqlTypes.NpgsqlLine(a: 0.3133690487713232d, b: 0.21425817972116357d, c: 0.39002508371565625d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    699428708,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 699428708,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.75437435623167d, b: 0.4381969103973332d, c: 0.13859938549471296d),

new NpgsqlTypes.NpgsqlLine(a: 0.22478326045746155d, b: 0.7927996319630696d, c: 0.5653146543488808d),

new NpgsqlTypes.NpgsqlLine(a: 0.8148660813324691d, b: 0.5965502974097225d, c: 0.08598406767552191d),

new NpgsqlTypes.NpgsqlLine(a: 0.10261855436837408d, b: 0.22753843400620033d, c: 0.6663050101504865d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19047502268477823d, b: 0.503647750986701d, c: 0.5140837344549085d),

new NpgsqlTypes.NpgsqlLine(a: 0.5498279015442291d, b: 0.5205498180433044d, c: 0.5511400439881968d),

new NpgsqlTypes.NpgsqlLine(a: 0.07519565206915457d, b: 0.8190939422278946d, c: 0.4842243543091963d),

new NpgsqlTypes.NpgsqlLine(a: 0.11151345358207676d, b: 0.2794260095615846d, c: 0.1977999861392018d),

}
                    }
                );

                expected.Add(
                    871029693,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 871029693,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09314286666835214d, b: 0.9419395542104619d, c: 0.23265001920909978d),

new NpgsqlTypes.NpgsqlLine(a: 0.7840922282915723d, b: 0.8769622177219351d, c: 0.08844919095146764d),

new NpgsqlTypes.NpgsqlLine(a: 0.30172065868559383d, b: 0.061796126836928256d, c: 0.7819510380905712d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1349638635,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 1349638635,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8811777097968191d, b: 0.09805743628781294d, c: 0.8476023389336619d),

new NpgsqlTypes.NpgsqlLine(a: 0.16329696312104391d, b: 0.8434248077846473d, c: 0.0171626874853823d),

new NpgsqlTypes.NpgsqlLine(a: 0.5930114320798587d, b: 0.7874763150232159d, c: 0.20169365861720767d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1743101311,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 1743101311,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30049737151744216d, b: 0.10935998965187232d, c: 0.12002566064851483d),

new NpgsqlTypes.NpgsqlLine(a: 0.4579983959880112d, b: 0.8700234892072651d, c: 0.24545341370685325d),

new NpgsqlTypes.NpgsqlLine(a: 0.6992061752442d, b: 0.8760611086508132d, c: 0.31896424715232463d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14975557199832845d, b: 0.8649037801511367d, c: 0.8035067258718913d),

new NpgsqlTypes.NpgsqlLine(a: 0.022767088770272226d, b: 0.824519829812387d, c: 0.2990170967826957d),

new NpgsqlTypes.NpgsqlLine(a: 0.264229467978496d, b: 0.4707396384081288d, c: 0.5870444614457326d),

}
                    }
                );

                expected.Add(
                    1803941428,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 1803941428,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4958174274877982d, b: 0.19935005698584918d, c: 0.6570481803156852d),

new NpgsqlTypes.NpgsqlLine(a: 0.586031122116916d, b: 0.20438200508300097d, c: 0.7214279726394314d),

new NpgsqlTypes.NpgsqlLine(a: 0.3287771922455527d, b: 0.31464931534195395d, c: 0.49275260904707807d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1888587968,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 1888587968,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9441675468790086d, b: 0.10273087249159918d, c: 0.36496868371913627d),

new NpgsqlTypes.NpgsqlLine(a: 0.3153900895384264d, b: 0.8953921593705707d, c: 0.6821583482258307d),

new NpgsqlTypes.NpgsqlLine(a: 0.15884512105184567d, b: 0.20745599422324912d, c: 0.5928677501305737d),

new NpgsqlTypes.NpgsqlLine(a: 0.19203772899196803d, b: 0.9281999546867626d, c: 0.9792553764463741d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.616453689236877d, b: 0.26880075600348696d, c: 0.9911672578342802d),

new NpgsqlTypes.NpgsqlLine(a: 0.41598816366831615d, b: 0.2972198032481773d, c: 0.6096249065094251d),

new NpgsqlTypes.NpgsqlLine(a: 0.21461782395965212d, b: 0.4996081675192614d, c: 0.845029551763019d),

new NpgsqlTypes.NpgsqlLine(a: 0.14603833144353173d, b: 0.5155958582129082d, c: 0.9513100476397736d),

}
                    }
                );

                expected.Add(
                    1935239880,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 1935239880,
                        Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5125009420178407d, b: 0.13553866813087467d, c: 0.6573124881706722d),

new NpgsqlTypes.NpgsqlLine(a: 0.9315668534985179d, b: 0.031339976871202935d, c: 0.7319776155987312d),

new NpgsqlTypes.NpgsqlLine(a: 0.5913519522327184d, b: 0.688194613219936d, c: 0.7487303543444555d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    2000087272,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 2000087272,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5174417835536576d, b: 0.9550151039410834d, c: 0.94465021980697d),

new NpgsqlTypes.NpgsqlLine(a: 0.023498567205728516d, b: 0.14704570142511664d, c: 0.5436176118381062d),

new NpgsqlTypes.NpgsqlLine(a: 0.6410825125912296d, b: 0.1638519482392854d, c: 0.07442290044208977d),

new NpgsqlTypes.NpgsqlLine(a: 0.5684954410076702d, b: 0.9517870324925599d, c: 0.7913121037671743d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5546781844769255d, b: 0.3295435210405563d, c: 0.10332785525555d),

new NpgsqlTypes.NpgsqlLine(a: 0.8619184029547027d, b: 0.6893143841340763d, c: 0.6057919377815917d),

new NpgsqlTypes.NpgsqlLine(a: 0.6918049340506819d, b: 0.29564467871458977d, c: 0.373851052320022d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590711543927416d, b: 0.782456230485786d, c: 0.0557514543823312d),

}
                    }
                );

                expected.Add(
                    2052209240,
                    new NpgsqlLinelineArray1MI
                    {
                        Id = 2052209240,
                        Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28682097488067404d, b: 0.19347953745544d, c: 0.767001580247448d),

new NpgsqlTypes.NpgsqlLine(a: 0.34168929191792363d, b: 0.5324263819109204d, c: 0.3548736591683712d),

new NpgsqlTypes.NpgsqlLine(a: 0.7601584215479089d, b: 0.9667193856859281d, c: 0.48805620341333844d),

new NpgsqlTypes.NpgsqlLine(a: 0.4778030273140724d, b: 0.6459214140044727d, c: 0.9825570138966864d),

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

