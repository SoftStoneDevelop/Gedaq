

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
    internal partial interface INpgsqlCircleSingleTypecircle
    {
    }
    
    internal partial class NpgsqlCircleSingleTypecircle : INpgsqlCircleSingleTypecircle
    {


#region TestData

        private readonly NpgsqlCirclecircleE0M[] _testData = new NpgsqlCirclecircleE0M[]
        {
            new NpgsqlCirclecircleE0M
{
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7079241766464421d, y: 0.35823791160787677d), radius: 0.6152005030839914d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3350906016475733d, y: 0.7482479058097107d), radius: 0.5294461201514494d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7331953584137717d, y: 0.11768497554455948d), radius: 0.4868820086496185d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9530361603254214d, y: 0.6127273691189558d), radius: 0.0031969888669424185d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5299621351910622d, y: 0.2743111304718794d), radius: 0.5338061797460683d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2798032138839377d, y: 0.7391505490755138d), radius: 0.46819083400798d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18652094267564578d, y: 0.25447642255754876d), radius: 0.005774969705215405d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23900108950705756d, y: 0.52568937899471d), radius: 0.24566973842223327d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2798869194817546d, y: 0.001250369479879887d), radius: 0.4052556647505119d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7256235826518982d, y: 0.8122509289814246d), radius: 0.4055963831026448d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8076170826521977d, y: 0.19624150920056183d), radius: 0.929454255788742d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.487705022772716d, y: 0.8385838535340373d), radius: 0.15165416168002677d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03342156501713167d, y: 0.2910289146216395d), radius: 0.9131602964562546d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30322979083225277d, y: 0.4555609338036304d), radius: 0.1507641618936143d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5671835297553194d, y: 0.3341536306242886d), radius: 0.17237386109970376d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4140675951591576d, y: 0.08327291451293029d), radius: 0.8808185039914299d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5685347270258779d, y: 0.44096169484106873d), radius: 0.5367886754644889d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.602202392150751d, y: 0.29907843113708965d), radius: 0.6930717855545394d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.342184876706476d, y: 0.8473407424063875d), radius: 0.04368128239927893d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02887866726658217d, y: 0.4418891559995879d), radius: 0.32592689551124276d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5253009779986667d, y: 0.09889158171391887d), radius: 0.29778664875945915d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1353251663964843d, y: 0.3536040916996289d), radius: 0.7241043063797424d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.946628295739315d, y: 0.6203694593487618d), radius: 0.3206704610189317d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5523366653303408d, y: 0.29250661697958835d), radius: 0.37918530264304584d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5928988646266514d, y: 0.8016678718915953d), radius: 0.9396922102650932d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9243272038705147d, y: 0.6402634820239734d), radius: 0.19324966231563723d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45342516567056146d, y: 0.5384427584725404d), radius: 0.23611340131333014d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9067953797547281d, y: 0.940928703796314d), radius: 0.6933821363282999d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.460608222768797d, y: 0.5393771362517913d), radius: 0.0049232404015880915d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6378133986540585d, y: 0.13677483009612734d), radius: 0.11037522340362294d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8087322784526981d, y: 0.7360484639865098d), radius: 0.8492940278772466d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43361098714020985d, y: 0.31434885513501143d), radius: 0.23302121451214886d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8689629861747161d, y: 0.9049407940706792d), radius: 0.9809775343473504d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8334858092329357d, y: 0.13528756349090976d), radius: 0.538175439002167d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0881788818862862d, y: 0.6727367293001262d), radius: 0.674985888466017d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42622162028929456d, y: 0.913585906763682d), radius: 0.16981248757972922d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35980556825319965d, y: 0.6600749479926162d), radius: 0.6961854493526541d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05310223014749482d, y: 0.7419868714379962d), radius: 0.49175998298623524d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.282709642969192d, y: 0.3060878585827842d), radius: 0.045376697030726554d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39484269655008797d, y: 0.3191289313418083d), radius: 0.07756439474633192d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2176363021922575d, y: 0.7758773913087703d), radius: 0.8235008793447353d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 109,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5283639140388957d, y: 0.30788473838448305d), radius: 0.016386545842269507d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13338658222918442d, y: 0.05132172187841377d), radius: 0.8161971946884028d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5375222686066511d, y: 0.7779596465523752d), radius: 0.5497657484600603d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33363800625097007d, y: 0.5091890635109925d), radius: 0.09973993030588268d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09688739193447549d, y: 0.934069673132604d), radius: 0.9977406436553726d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2653696369439603d, y: 0.8959129160244778d), radius: 0.6485109034771704d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9600821070720756d, y: 0.2257366367547753d), radius: 0.26112159729452344d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4973458727570864d, y: 0.9510886331135373d), radius: 0.5577400555618913d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023289361241834894d, y: 0.5586506360488113d), radius: 0.7847291175853746d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05344004493216481d, y: 0.18940922703042318d), radius: 0.3053290479468068d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 129,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13648219292935704d, y: 0.5607176806092451d), radius: 0.40222953641724724d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19879546568505968d, y: 0.6485493162483905d), radius: 0.5066532266454583d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24601864147500463d, y: 0.916918053038933d), radius: 0.946185092596183d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9735159086087053d, y: 0.6049582089531095d), radius: 0.34861256163162213d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38089290369833684d, y: 0.4715007002571776d), radius: 0.5944779291539664d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7187409372925971d, y: 0.08441802791316944d), radius: 0.8006028782342267d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02517667321405559d, y: 0.33267354565676555d), radius: 0.08500096199689267d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4696148878873627d, y: 0.5936238384742862d), radius: 0.8024602526553506d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 150,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26436510662269874d, y: 0.6668179637017232d), radius: 0.9300545807511061d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 155,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5626319928445935d, y: 0.9168279323554376d), radius: 0.22063567630998682d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9962746608600631d, y: 0.0732508020293543d), radius: 0.9296784198125294d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 161,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3671607406633971d, y: 0.5038874765584308d), radius: 0.6369248731742765d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17142926980287498d, y: 0.7147515376701862d), radius: 0.7467534658191635d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 166,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0934848426406637d, y: 0.03713866033302027d), radius: 0.0599631931899578d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9690915618432189d, y: 0.34188238129469695d), radius: 0.42123086996708403d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9111742180176386d, y: 0.2832610021177374d), radius: 0.9689561352029765d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 172,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.494188329484021d, y: 0.2805394789205271d), radius: 0.3640111436252933d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7066255213980427d, y: 0.031749360440269325d), radius: 0.9472432940827983d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 174,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9456004260807964d, y: 0.3688200509236498d), radius: 0.9756580742192817d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21561536456275165d, y: 0.21242226968516342d), radius: 0.3068082659756134d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8224249966559612d, y: 0.257379852610059d), radius: 0.041758996438157725d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 179,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1370498950284077d, y: 0.5299797561497377d), radius: 0.3008183339052133d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49284855436662467d, y: 0.22968015014305287d), radius: 0.9655818224755308d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 188,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46660861857652647d, y: 0.8618457673747675d), radius: 0.7231749878595379d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 92,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.476188427005625d, y: 0.8417982621522654d), radius: 0.8467342524063306d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.431904727346586d, y: 0.6034968839287632d), radius: 0.7832937628385215d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 192,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.599594687201119d, y: 0.062316256488709865d), radius: 0.9744315644338409d),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclee0mi(
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclee0mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5))]
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

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclee0mi(
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
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

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclee0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclee0mi_id
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclee0mi_id", 
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
                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclee0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclee0mi_id
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
    npgsqlcirclecirclee0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2798869194817546d, y: 0.001250369479879887d), radius: 0.4052556647505119d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03342156501713167d, y: 0.2910289146216395d), radius: 0.9131602964562546d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5671835297553194d, y: 0.3341536306242886d), radius: 0.17237386109970376d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclee0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclee0mi_id
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
    npgsqlcirclecirclee0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclee0mi_id", 
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
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5523366653303408d, y: 0.29250661697958835d), radius: 0.37918530264304584d)));
                nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleE0M> models = null;

                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleE0M> models = null;

                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclee0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclee0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlcirclecirclee0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlCircle), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlcirclecirclee0mi_id", 
                methodParametrName: "npgsqlcirclecirclee0mi_id", 
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

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleE0M), typeof(FlatNpgsqlCirclecircleE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecirclee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleE0M>();
                var models2 = new List<FlatNpgsqlCirclecircleE0M>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleE0M>();
                var models2 = new List<FlatNpgsqlCirclecircleE0M>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecirclee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
LEFT JOIN public.npgsqlcirclecirclee0mi mi ON mi.id = m.npgsqlcirclecirclee0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleE0M), typeof(FlatNpgsqlCirclecircleE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecirclee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleE0M>();
                var models2 = new List<FlatNpgsqlCirclecircleE0M>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleE0M>();
                var models2 = new List<FlatNpgsqlCirclecircleE0M>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecirclee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
LEFT JOIN public.npgsqlcirclecirclee0mi mi ON mi.id = m.npgsqlcirclecirclee0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleE0M), typeof(FlatNpgsqlCirclecircleE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleE0M>();
                var models2 = new List<FlatNpgsqlCirclecircleE0M>();
                await((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 179;
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleE0M>();
                var models2 = new List<FlatNpgsqlCirclecircleE0M>();
                ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 12;
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 136;
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 179;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
LEFT JOIN public.npgsqlcirclecirclee0mi mi ON mi.id = m.npgsqlcirclecirclee0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 179;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[34], false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 150;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleE0M), typeof(FlatNpgsqlCirclecircleE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleE0M>();
                var models2 = new List<FlatNpgsqlCirclecircleE0M>();
                await((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 119, query1, 53, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 150, query1, 2, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleE0M>();
                var models2 = new List<FlatNpgsqlCirclecircleE0M>();
                ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 28, query1, 172, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatch(connection, 47, query1, 119, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 119, query1, 29, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[28],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 94, query1, 72, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatch(connection, 120, query1, 119, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatch(connection, 12, query1, 172, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
LEFT JOIN public.npgsqlcirclecirclee0mi mi ON mi.id = m.npgsqlcirclecirclee0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatchAsync(connection, 66, 174))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[12], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[13], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[14], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[15], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[16], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[17], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[18], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[19], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[20], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[16],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[17],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[18],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[19],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[20],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[21],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[34], false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatch(connection, 42, 141))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[8], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[9], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[10], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[11], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[12], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[13], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[14], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[15], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[16], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[17], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[18], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[19], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[20], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[16],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[17],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[18],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[19],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[20],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[21],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[22],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[23],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[24],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[25],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 119);
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[22], false);
                NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[23], false);
                NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[24], false);
                NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[25], false);
                NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[26], false);
                NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[27], false);
                NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[28], false);
                NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[29], false);
                NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[30], false);
                NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[31], false);
                NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[32], false);
                NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[33], false);
                NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 109);
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[20], false);
                NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[21], false);
                NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[22], false);
                NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[23], false);
                NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[24], false);
                NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[25], false);
                NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[26], false);
                NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[27], false);
                NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[28], false);
                NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[29], false);
                NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[30], false);
                NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[31], false);
                NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[32], false);
                NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[33], false);
                NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
LEFT JOIN public.npgsqlcirclecirclee0mi mi ON mi.id = m.npgsqlcirclecirclee0mi_id
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7079241766464421d, y: 0.35823791160787677d), radius: 0.6152005030839914d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3350906016475733d, y: 0.7482479058097107d), radius: 0.5294461201514494d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7331953584137717d, y: 0.11768497554455948d), radius: 0.4868820086496185d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9530361603254214d, y: 0.6127273691189558d), radius: 0.0031969888669424185d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5299621351910622d, y: 0.2743111304718794d), radius: 0.5338061797460683d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2798032138839377d, y: 0.7391505490755138d), radius: 0.46819083400798d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18652094267564578d, y: 0.25447642255754876d), radius: 0.005774969705215405d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23900108950705756d, y: 0.52568937899471d), radius: 0.24566973842223327d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2798869194817546d, y: 0.001250369479879887d), radius: 0.4052556647505119d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7256235826518982d, y: 0.8122509289814246d), radius: 0.4055963831026448d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8076170826521977d, y: 0.19624150920056183d), radius: 0.929454255788742d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.487705022772716d, y: 0.8385838535340373d), radius: 0.15165416168002677d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03342156501713167d, y: 0.2910289146216395d), radius: 0.9131602964562546d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30322979083225277d, y: 0.4555609338036304d), radius: 0.1507641618936143d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5671835297553194d, y: 0.3341536306242886d), radius: 0.17237386109970376d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4140675951591576d, y: 0.08327291451293029d), radius: 0.8808185039914299d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5685347270258779d, y: 0.44096169484106873d), radius: 0.5367886754644889d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.602202392150751d, y: 0.29907843113708965d), radius: 0.6930717855545394d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.342184876706476d, y: 0.8473407424063875d), radius: 0.04368128239927893d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02887866726658217d, y: 0.4418891559995879d), radius: 0.32592689551124276d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5253009779986667d, y: 0.09889158171391887d), radius: 0.29778664875945915d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1353251663964843d, y: 0.3536040916996289d), radius: 0.7241043063797424d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.946628295739315d, y: 0.6203694593487618d), radius: 0.3206704610189317d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5523366653303408d, y: 0.29250661697958835d), radius: 0.37918530264304584d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5928988646266514d, y: 0.8016678718915953d), radius: 0.9396922102650932d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9243272038705147d, y: 0.6402634820239734d), radius: 0.19324966231563723d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45342516567056146d, y: 0.5384427584725404d), radius: 0.23611340131333014d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9067953797547281d, y: 0.940928703796314d), radius: 0.6933821363282999d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.460608222768797d, y: 0.5393771362517913d), radius: 0.0049232404015880915d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6378133986540585d, y: 0.13677483009612734d), radius: 0.11037522340362294d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8087322784526981d, y: 0.7360484639865098d), radius: 0.8492940278772466d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43361098714020985d, y: 0.31434885513501143d), radius: 0.23302121451214886d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8689629861747161d, y: 0.9049407940706792d), radius: 0.9809775343473504d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8334858092329357d, y: 0.13528756349090976d), radius: 0.538175439002167d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0881788818862862d, y: 0.6727367293001262d), radius: 0.674985888466017d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42622162028929456d, y: 0.913585906763682d), radius: 0.16981248757972922d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35980556825319965d, y: 0.6600749479926162d), radius: 0.6961854493526541d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05310223014749482d, y: 0.7419868714379962d), radius: 0.49175998298623524d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.282709642969192d, y: 0.3060878585827842d), radius: 0.045376697030726554d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39484269655008797d, y: 0.3191289313418083d), radius: 0.07756439474633192d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2176363021922575d, y: 0.7758773913087703d), radius: 0.8235008793447353d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5283639140388957d, y: 0.30788473838448305d), radius: 0.016386545842269507d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13338658222918442d, y: 0.05132172187841377d), radius: 0.8161971946884028d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5375222686066511d, y: 0.7779596465523752d), radius: 0.5497657484600603d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33363800625097007d, y: 0.5091890635109925d), radius: 0.09973993030588268d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09688739193447549d, y: 0.934069673132604d), radius: 0.9977406436553726d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2653696369439603d, y: 0.8959129160244778d), radius: 0.6485109034771704d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9600821070720756d, y: 0.2257366367547753d), radius: 0.26112159729452344d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4973458727570864d, y: 0.9510886331135373d), radius: 0.5577400555618913d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023289361241834894d, y: 0.5586506360488113d), radius: 0.7847291175853746d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05344004493216481d, y: 0.18940922703042318d), radius: 0.3053290479468068d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13648219292935704d, y: 0.5607176806092451d), radius: 0.40222953641724724d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19879546568505968d, y: 0.6485493162483905d), radius: 0.5066532266454583d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24601864147500463d, y: 0.916918053038933d), radius: 0.946185092596183d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9735159086087053d, y: 0.6049582089531095d), radius: 0.34861256163162213d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38089290369833684d, y: 0.4715007002571776d), radius: 0.5944779291539664d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7187409372925971d, y: 0.08441802791316944d), radius: 0.8006028782342267d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02517667321405559d, y: 0.33267354565676555d), radius: 0.08500096199689267d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4696148878873627d, y: 0.5936238384742862d), radius: 0.8024602526553506d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26436510662269874d, y: 0.6668179637017232d), radius: 0.9300545807511061d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5626319928445935d, y: 0.9168279323554376d), radius: 0.22063567630998682d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9962746608600631d, y: 0.0732508020293543d), radius: 0.9296784198125294d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3671607406633971d, y: 0.5038874765584308d), radius: 0.6369248731742765d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17142926980287498d, y: 0.7147515376701862d), radius: 0.7467534658191635d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0934848426406637d, y: 0.03713866033302027d), radius: 0.0599631931899578d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9690915618432189d, y: 0.34188238129469695d), radius: 0.42123086996708403d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9111742180176386d, y: 0.2832610021177374d), radius: 0.9689561352029765d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.494188329484021d, y: 0.2805394789205271d), radius: 0.3640111436252933d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7066255213980427d, y: 0.031749360440269325d), radius: 0.9472432940827983d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9456004260807964d, y: 0.3688200509236498d), radius: 0.9756580742192817d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21561536456275165d, y: 0.21242226968516342d), radius: 0.3068082659756134d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8224249966559612d, y: 0.257379852610059d), radius: 0.041758996438157725d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1370498950284077d, y: 0.5299797561497377d), radius: 0.3008183339052133d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49284855436662467d, y: 0.22968015014305287d), radius: 0.9655818224755308d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((188)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46660861857652647d, y: 0.8618457673747675d), radius: 0.7231749878595379d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.476188427005625d, y: 0.8417982621522654d), radius: 0.8467342524063306d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.431904727346586d, y: 0.6034968839287632d), radius: 0.7832937628385215d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((192)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.599594687201119d, y: 0.062316256488709865d), radius: 0.9744315644338409d))));//Value

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
                var models =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7079241766464421d, y: 0.35823791160787677d), radius: 0.6152005030839914d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3350906016475733d, y: 0.7482479058097107d), radius: 0.5294461201514494d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7331953584137717d, y: 0.11768497554455948d), radius: 0.4868820086496185d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9530361603254214d, y: 0.6127273691189558d), radius: 0.0031969888669424185d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5299621351910622d, y: 0.2743111304718794d), radius: 0.5338061797460683d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2798032138839377d, y: 0.7391505490755138d), radius: 0.46819083400798d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18652094267564578d, y: 0.25447642255754876d), radius: 0.005774969705215405d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23900108950705756d, y: 0.52568937899471d), radius: 0.24566973842223327d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2798869194817546d, y: 0.001250369479879887d), radius: 0.4052556647505119d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7256235826518982d, y: 0.8122509289814246d), radius: 0.4055963831026448d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8076170826521977d, y: 0.19624150920056183d), radius: 0.929454255788742d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.487705022772716d, y: 0.8385838535340373d), radius: 0.15165416168002677d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03342156501713167d, y: 0.2910289146216395d), radius: 0.9131602964562546d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30322979083225277d, y: 0.4555609338036304d), radius: 0.1507641618936143d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5671835297553194d, y: 0.3341536306242886d), radius: 0.17237386109970376d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4140675951591576d, y: 0.08327291451293029d), radius: 0.8808185039914299d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5685347270258779d, y: 0.44096169484106873d), radius: 0.5367886754644889d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.602202392150751d, y: 0.29907843113708965d), radius: 0.6930717855545394d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.342184876706476d, y: 0.8473407424063875d), radius: 0.04368128239927893d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02887866726658217d, y: 0.4418891559995879d), radius: 0.32592689551124276d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5253009779986667d, y: 0.09889158171391887d), radius: 0.29778664875945915d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1353251663964843d, y: 0.3536040916996289d), radius: 0.7241043063797424d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.946628295739315d, y: 0.6203694593487618d), radius: 0.3206704610189317d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5523366653303408d, y: 0.29250661697958835d), radius: 0.37918530264304584d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5928988646266514d, y: 0.8016678718915953d), radius: 0.9396922102650932d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9243272038705147d, y: 0.6402634820239734d), radius: 0.19324966231563723d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45342516567056146d, y: 0.5384427584725404d), radius: 0.23611340131333014d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9067953797547281d, y: 0.940928703796314d), radius: 0.6933821363282999d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.460608222768797d, y: 0.5393771362517913d), radius: 0.0049232404015880915d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6378133986540585d, y: 0.13677483009612734d), radius: 0.11037522340362294d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8087322784526981d, y: 0.7360484639865098d), radius: 0.8492940278772466d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43361098714020985d, y: 0.31434885513501143d), radius: 0.23302121451214886d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8689629861747161d, y: 0.9049407940706792d), radius: 0.9809775343473504d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8334858092329357d, y: 0.13528756349090976d), radius: 0.538175439002167d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0881788818862862d, y: 0.6727367293001262d), radius: 0.674985888466017d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42622162028929456d, y: 0.913585906763682d), radius: 0.16981248757972922d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35980556825319965d, y: 0.6600749479926162d), radius: 0.6961854493526541d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05310223014749482d, y: 0.7419868714379962d), radius: 0.49175998298623524d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.282709642969192d, y: 0.3060878585827842d), radius: 0.045376697030726554d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39484269655008797d, y: 0.3191289313418083d), radius: 0.07756439474633192d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2176363021922575d, y: 0.7758773913087703d), radius: 0.8235008793447353d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5283639140388957d, y: 0.30788473838448305d), radius: 0.016386545842269507d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13338658222918442d, y: 0.05132172187841377d), radius: 0.8161971946884028d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5375222686066511d, y: 0.7779596465523752d), radius: 0.5497657484600603d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33363800625097007d, y: 0.5091890635109925d), radius: 0.09973993030588268d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09688739193447549d, y: 0.934069673132604d), radius: 0.9977406436553726d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2653696369439603d, y: 0.8959129160244778d), radius: 0.6485109034771704d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9600821070720756d, y: 0.2257366367547753d), radius: 0.26112159729452344d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4973458727570864d, y: 0.9510886331135373d), radius: 0.5577400555618913d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023289361241834894d, y: 0.5586506360488113d), radius: 0.7847291175853746d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05344004493216481d, y: 0.18940922703042318d), radius: 0.3053290479468068d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13648219292935704d, y: 0.5607176806092451d), radius: 0.40222953641724724d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19879546568505968d, y: 0.6485493162483905d), radius: 0.5066532266454583d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24601864147500463d, y: 0.916918053038933d), radius: 0.946185092596183d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9735159086087053d, y: 0.6049582089531095d), radius: 0.34861256163162213d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38089290369833684d, y: 0.4715007002571776d), radius: 0.5944779291539664d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7187409372925971d, y: 0.08441802791316944d), radius: 0.8006028782342267d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02517667321405559d, y: 0.33267354565676555d), radius: 0.08500096199689267d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4696148878873627d, y: 0.5936238384742862d), radius: 0.8024602526553506d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26436510662269874d, y: 0.6668179637017232d), radius: 0.9300545807511061d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5626319928445935d, y: 0.9168279323554376d), radius: 0.22063567630998682d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9962746608600631d, y: 0.0732508020293543d), radius: 0.9296784198125294d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3671607406633971d, y: 0.5038874765584308d), radius: 0.6369248731742765d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17142926980287498d, y: 0.7147515376701862d), radius: 0.7467534658191635d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0934848426406637d, y: 0.03713866033302027d), radius: 0.0599631931899578d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9690915618432189d, y: 0.34188238129469695d), radius: 0.42123086996708403d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9111742180176386d, y: 0.2832610021177374d), radius: 0.9689561352029765d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.494188329484021d, y: 0.2805394789205271d), radius: 0.3640111436252933d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7066255213980427d, y: 0.031749360440269325d), radius: 0.9472432940827983d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9456004260807964d, y: 0.3688200509236498d), radius: 0.9756580742192817d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21561536456275165d, y: 0.21242226968516342d), radius: 0.3068082659756134d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8224249966559612d, y: 0.257379852610059d), radius: 0.041758996438157725d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1370498950284077d, y: 0.5299797561497377d), radius: 0.3008183339052133d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49284855436662467d, y: 0.22968015014305287d), radius: 0.9655818224755308d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((188)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46660861857652647d, y: 0.8618457673747675d), radius: 0.7231749878595379d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.476188427005625d, y: 0.8417982621522654d), radius: 0.8467342524063306d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.431904727346586d, y: 0.6034968839287632d), radius: 0.7832937628385215d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((192)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.599594687201119d, y: 0.062316256488709865d), radius: 0.9744315644338409d))));//Value

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
FROM public.binary_npgsqlcirclecirclee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleE0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleSingleTypecircle)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclee0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleSingleTypecircle)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclee0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleSingleTypecircle)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclee0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleSingleTypecircle)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclee0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclee0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleE0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleSingleTypecircle)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleSingleTypecircle)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleSingleTypecircle)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleSingleTypecircle)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclee0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleSingleTypecircle)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleSingleTypecircle)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclee0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclee0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleE0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
FROM public.binary_npgsqlcirclecirclee0m m
LEFT JOIN public.binary_npgsqlcirclecirclee0mi mi ON mi.id = m.npgsqlcirclecirclee0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleSingleTypecircle)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleSingleTypecircle)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclee0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclee0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5)
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
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA), typeof(NpgsqlCirclecircleE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
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
                var models1 = new List<NpgsqlCirclecircleE0MIWA>();
                var models2 = new List<NpgsqlCirclecircleE0MIWA>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleE0MIWA>();
                var models2 = new List<NpgsqlCirclecircleE0MIWA>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclee0mi
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
                    NpgsqlCirclecircleE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclee0mi
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
                    NpgsqlCirclecircleE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA), typeof(NpgsqlCirclecircleE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
                var models1 = new List<NpgsqlCirclecircleE0MIWA>();
                var models2 = new List<NpgsqlCirclecircleE0MIWA>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleE0MIWA>();
                var models2 = new List<NpgsqlCirclecircleE0MIWA>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclee0mi
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
                    NpgsqlCirclecircleE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclee0mi
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
                    NpgsqlCirclecircleE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclee0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MI), typeof(NpgsqlCirclecircleE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
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
                var models1 = new List<NpgsqlCirclecircleE0MI>();
                var models2 = new List<NpgsqlCirclecircleE0MI>();
                await ((INpgsqlCircleSingleTypecircle)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleE0MI>();
                var models2 = new List<NpgsqlCirclecircleE0MI>();
                ((INpgsqlCircleSingleTypecircle)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclee0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclee0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA), typeof(NpgsqlCirclecircleE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
                var models1 = new List<NpgsqlCirclecircleE0MIWA>();
                var models2 = new List<NpgsqlCirclecircleE0MIWA>();
                await ((INpgsqlCircleSingleTypecircle)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleE0MIWA>();
                var models2 = new List<NpgsqlCirclecircleE0MIWA>();
                ((INpgsqlCircleSingleTypecircle)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclee0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

