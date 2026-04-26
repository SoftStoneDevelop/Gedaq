

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

        private readonly NpgsqlCirclecircle0M[] _testData = new NpgsqlCirclecircle0M[]
        {
            new NpgsqlCirclecircle0M
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43189242255459004d, y: 0.6281341595850557d), radius: 0.214482482021653d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43066611881330463d, y: 0.15852399967368702d), radius: 0.3017498558984154d),
},
            new NpgsqlCirclecircle0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2136913562535877d, y: 0.023211213036073874d), radius: 0.11668329784709608d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5950866451147121d, y: 0.11382214151535341d), radius: 0.10565968758644595d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3206723796378653d, y: 0.5701428575931639d), radius: 0.5391514830033309d),
},
            new NpgsqlCirclecircle0M
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7402736706782522d, y: 0.43635721612976186d), radius: 0.9834030051252284d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.86419514935638d, y: 0.268414627767088d), radius: 0.2737328018373444d),
},
            new NpgsqlCirclecircle0M
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5653891510472436d, y: 0.600597407554274d), radius: 0.05610071643177361d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5143688240422777d, y: 0.3581511467479902d), radius: 0.5390890314370088d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15356369383647994d, y: 0.4617921918870096d), radius: 0.7470812941596028d),
},
            new NpgsqlCirclecircle0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2366100600678942d, y: 0.7778173592587311d), radius: 0.9864351813024512d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3549882755203174d, y: 0.9338495609046518d), radius: 0.7558677790594555d),
},
            new NpgsqlCirclecircle0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08435232490583944d, y: 0.8290873561609723d), radius: 0.8396314403274119d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11745217744944647d, y: 0.45020949130582844d), radius: 0.23097663631736365d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36472339727259906d, y: 0.7125776215660586d), radius: 0.3199109797530474d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7934298450340024d, y: 0.9622781803842675d), radius: 0.15105061036156542d),
},
            new NpgsqlCirclecircle0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4051547030607382d, y: 0.7341669744921919d), radius: 0.13501613529687118d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10220917182313449d, y: 0.7199839487051429d), radius: 0.21695490921375227d),
},
            new NpgsqlCirclecircle0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3818965315944962d, y: 0.9854179353175999d), radius: 0.4241043162793875d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6917900479571663d, y: 0.4642094936384271d), radius: 0.8907853201671136d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5238735998221258d, y: 0.36947296287940656d), radius: 0.3651187088560143d),
},
            new NpgsqlCirclecircle0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9461223840524248d, y: 0.44547956445202397d), radius: 0.1479730191493399d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06170777388497106d, y: 0.028113565981159994d), radius: 0.7384313756551109d),
},
            new NpgsqlCirclecircle0M
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.888455140894486d, y: 0.6382658890927744d), radius: 0.06952921243767429d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09062653751792638d, y: 0.27500950293616044d), radius: 0.4432815149710585d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5788241235002597d, y: 0.7276473371912225d), radius: 0.18892830467841937d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3175960501184736d, y: 0.4757924478979594d), radius: 0.6618840691509589d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.779627784316765d, y: 0.21878714368880336d), radius: 0.8879265180907678d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2512604032930513d, y: 0.3723203859591693d), radius: 0.7154376328486002d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7812862667930052d, y: 0.7125068866192538d), radius: 0.3212654433559047d),
},
            new NpgsqlCirclecircle0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08705384412326034d, y: 0.17995450047863282d), radius: 0.5064621345970189d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2854996026876737d, y: 0.9088858702863883d), radius: 0.24859971277816773d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8706985667132583d, y: 0.05517100848032053d), radius: 0.7111927768477067d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7663143277984279d, y: 0.6644151837436882d), radius: 0.7028600313800695d),
},
            new NpgsqlCirclecircle0M
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020333853062769358d, y: 0.4672178670398178d), radius: 0.9228632081771551d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03384777750364942d, y: 0.6910906032874659d), radius: 0.9396127519123323d),
},
            new NpgsqlCirclecircle0M
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17051101667701885d, y: 0.663684484227292d), radius: 0.05122217780542759d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06617457543998884d, y: 0.48559405891603d), radius: 0.7945553511322585d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8381180777583388d, y: 0.47417520758778553d), radius: 0.5627665412499266d),
},
            new NpgsqlCirclecircle0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19092066452558987d, y: 0.05845453230766162d), radius: 0.012173472446699418d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34157281295923303d, y: 0.6338328620793257d), radius: 0.5663732861589991d),
},
            new NpgsqlCirclecircle0M
{
    Id = 98,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.716181864180684d, y: 0.27769095265680355d), radius: 0.3354777326824381d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.987400429716878d, y: 0.5641466320523828d), radius: 0.945636480023413d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05843665635224948d, y: 0.42611281440752424d), radius: 0.24553188461247089d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8827372474348893d, y: 0.8801159377016956d), radius: 0.22860311256846788d),
},
            new NpgsqlCirclecircle0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1520152501573364d, y: 0.13063752016965635d), radius: 0.5777392945354192d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8577177109333519d, y: 0.8204838902138966d), radius: 0.11935506620662717d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9257883443413619d, y: 0.39623020431171363d), radius: 0.7755814155386545d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.511631160330754d, y: 0.15611772837700832d), radius: 0.5670153867879957d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30345555601266405d, y: 0.45190124441453605d), radius: 0.2857563416795973d),
},
            new NpgsqlCirclecircle0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.479162914346957d, y: 0.09494026594691019d), radius: 0.9026365011424459d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44341999383619657d, y: 0.08593428063982489d), radius: 0.4054927838815394d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6489175099038844d, y: 0.22587731751365536d), radius: 0.23299866358554966d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46958963794929565d, y: 0.07094524821058912d), radius: 0.27760345600135794d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35862954561951843d, y: 0.9998823792212063d), radius: 0.23958998191074665d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3141020005305325d, y: 0.30108637392174364d), radius: 0.9126330447138274d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38166385375369705d, y: 0.7227417744077622d), radius: 0.44298311099989496d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 144,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9744832055412603d, y: 0.8876445711434099d), radius: 0.3432777707168697d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8446174832644104d, y: 0.7575601515996012d), radius: 0.46481291218219556d),
},
            new NpgsqlCirclecircle0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11090356282546276d, y: 0.9259164094116851d), radius: 0.29046013363414047d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9958160071699524d, y: 0.1833125625854879d), radius: 0.9067372325098075d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2404162365744028d, y: 0.31122341685490884d), radius: 0.026889403131830525d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 152,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02500611874687997d, y: 0.842522419149292d), radius: 0.9573608581313283d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4924004058788377d, y: 0.012035979616373815d), radius: 0.3273306145068212d),
},
            new NpgsqlCirclecircle0M
{
    Id = 158,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11033430227685737d, y: 0.021248702150420518d), radius: 0.9291131734536748d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9155480196901161d, y: 0.08695910112790461d), radius: 0.6928814611760182d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48962680678144244d, y: 0.5324300383227751d), radius: 0.794469149899103d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8921436447193842d, y: 0.5921649874292841d), radius: 0.7326927935424218d),
},
            new NpgsqlCirclecircle0M
{
    Id = 163,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7826745492369169d, y: 0.8240312715855396d), radius: 0.47246123555798125d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 172,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8159465947857059d, y: 0.20924204257193713d), radius: 0.49375617515809855d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23056458090343357d, y: 0.3622929703177604d), radius: 0.6940758818566388d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47078921596136947d, y: 0.17232849490232094d), radius: 0.29774366315551803d),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0mi(
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
INSERT INTO public.npgsqlcirclecircle0mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI)],
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
INSERT INTO public.npgsqlcirclecircle0mi(
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

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
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
                methodParametrName: "npgsqlcirclecircle0mi_id", 
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
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
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
    npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3549882755203174d, y: 0.9338495609046518d), radius: 0.7558677790594555d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7934298450340024d, y: 0.9622781803842675d), radius: 0.15105061036156542d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10220917182313449d, y: 0.7199839487051429d), radius: 0.21695490921375227d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5238735998221258d, y: 0.36947296287940656d), radius: 0.3651187088560143d)));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
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
    npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
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
                methodParametrName: "npgsqlcirclecircle0mi_id", 
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06170777388497106d, y: 0.028113565981159994d), radius: 0.7384313756551109d)));
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
                Assert.That(nullable, Is.Null);
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
                List<NpgsqlCirclecircle0M> models = null;

                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircle0M> models = null;

                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlcirclecircle0mi_id
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
                parametrName: "npgsqlcirclecircle0mi_id", 
                methodParametrName: "npgsqlcirclecircle0mi_id", 
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

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((INpgsqlCircleSingleTypecircle)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleSingleTypecircle)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[6], false);FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[7], false);FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[8], false);FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[9], false);FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[10], false);FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[11], false);FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[12], false);FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[13], false);FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[14], false);FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[15], false);FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[16], false);FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[17], false);FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[18], false);FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[19], false);FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[20], false);FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[21], false);FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[22], false);FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[23], false);FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[24], false);FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[25], false);FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[26], false);FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[27], false);FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[28], false);FlatNpgsqlCirclecircle0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[23], false);FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[24], false);FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[25], false);FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[26], false);FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[27], false);FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[28], false);FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[6], false);FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[7], false);FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[8], false);FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[9], false);FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[10], false);FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[11], false);FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[12], false);FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[13], false);FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[14], false);FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[15], false);FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[16], false);FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[17], false);FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[18], false);FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[19], false);FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[20], false);FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[21], false);FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[22], false);FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[23], false);FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[24], false);FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[25], false);FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[26], false);FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[27], false);FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[28], false);FlatNpgsqlCirclecircle0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[3], false);FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[4], false);FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[5], false);FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[6], false);FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[7], false);FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[8], false);FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[9], false);FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[10], false);FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[11], false);FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[12], false);FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[13], false);FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[14], false);FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[15], false);FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[16], false);FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[17], false);FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[18], false);FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[19], false);FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[20], false);FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[21], false);FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[22], false);FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[23], false);FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[24], false);FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[25], false);FlatNpgsqlCirclecircle0M.AssertModel(models[23],_testData[26], false);FlatNpgsqlCirclecircle0M.AssertModel(models[24],_testData[27], false);FlatNpgsqlCirclecircle0M.AssertModel(models[25],_testData[28], false);FlatNpgsqlCirclecircle0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
        private void DbConnectionSelectModelDynParBatchConfig()
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

                var models = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
NpgsqlCirclecircle0M.AssertModel(models[0],_testData[12], false);NpgsqlCirclecircle0M.AssertModel(models[1],_testData[13], false);NpgsqlCirclecircle0M.AssertModel(models[2],_testData[14], false);NpgsqlCirclecircle0M.AssertModel(models[3],_testData[15], false);NpgsqlCirclecircle0M.AssertModel(models[4],_testData[16], false);NpgsqlCirclecircle0M.AssertModel(models[5],_testData[17], false);NpgsqlCirclecircle0M.AssertModel(models[6],_testData[18], false);NpgsqlCirclecircle0M.AssertModel(models[7],_testData[19], false);NpgsqlCirclecircle0M.AssertModel(models[8],_testData[20], false);NpgsqlCirclecircle0M.AssertModel(models[9],_testData[21], false);NpgsqlCirclecircle0M.AssertModel(models[10],_testData[22], false);NpgsqlCirclecircle0M.AssertModel(models[11],_testData[23], false);NpgsqlCirclecircle0M.AssertModel(models[12],_testData[24], false);NpgsqlCirclecircle0M.AssertModel(models[13],_testData[25], false);NpgsqlCirclecircle0M.AssertModel(models[14],_testData[26], false);NpgsqlCirclecircle0M.AssertModel(models[15],_testData[27], false);NpgsqlCirclecircle0M.AssertModel(models[16],_testData[28], false);NpgsqlCirclecircle0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
NpgsqlCirclecircle0M.AssertModel(models[0],_testData[23], false);NpgsqlCirclecircle0M.AssertModel(models[1],_testData[24], false);NpgsqlCirclecircle0M.AssertModel(models[2],_testData[25], false);NpgsqlCirclecircle0M.AssertModel(models[3],_testData[26], false);NpgsqlCirclecircle0M.AssertModel(models[4],_testData[27], false);NpgsqlCirclecircle0M.AssertModel(models[5],_testData[28], false);NpgsqlCirclecircle0M.AssertModel(models[6],_testData[29], false);
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

                var models =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
NpgsqlCirclecircle0M.AssertModel(models[0],_testData[13], false);NpgsqlCirclecircle0M.AssertModel(models[1],_testData[14], false);NpgsqlCirclecircle0M.AssertModel(models[2],_testData[15], false);NpgsqlCirclecircle0M.AssertModel(models[3],_testData[16], false);NpgsqlCirclecircle0M.AssertModel(models[4],_testData[17], false);NpgsqlCirclecircle0M.AssertModel(models[5],_testData[18], false);NpgsqlCirclecircle0M.AssertModel(models[6],_testData[19], false);NpgsqlCirclecircle0M.AssertModel(models[7],_testData[20], false);NpgsqlCirclecircle0M.AssertModel(models[8],_testData[21], false);NpgsqlCirclecircle0M.AssertModel(models[9],_testData[22], false);NpgsqlCirclecircle0M.AssertModel(models[10],_testData[23], false);NpgsqlCirclecircle0M.AssertModel(models[11],_testData[24], false);NpgsqlCirclecircle0M.AssertModel(models[12],_testData[25], false);NpgsqlCirclecircle0M.AssertModel(models[13],_testData[26], false);NpgsqlCirclecircle0M.AssertModel(models[14],_testData[27], false);NpgsqlCirclecircle0M.AssertModel(models[15],_testData[28], false);NpgsqlCirclecircle0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlCirclecircle0M.AssertModel(models[0],_testData[7], false);NpgsqlCirclecircle0M.AssertModel(models[1],_testData[8], false);NpgsqlCirclecircle0M.AssertModel(models[2],_testData[9], false);NpgsqlCirclecircle0M.AssertModel(models[3],_testData[10], false);NpgsqlCirclecircle0M.AssertModel(models[4],_testData[11], false);NpgsqlCirclecircle0M.AssertModel(models[5],_testData[12], false);NpgsqlCirclecircle0M.AssertModel(models[6],_testData[13], false);NpgsqlCirclecircle0M.AssertModel(models[7],_testData[14], false);NpgsqlCirclecircle0M.AssertModel(models[8],_testData[15], false);NpgsqlCirclecircle0M.AssertModel(models[9],_testData[16], false);NpgsqlCirclecircle0M.AssertModel(models[10],_testData[17], false);NpgsqlCirclecircle0M.AssertModel(models[11],_testData[18], false);NpgsqlCirclecircle0M.AssertModel(models[12],_testData[19], false);NpgsqlCirclecircle0M.AssertModel(models[13],_testData[20], false);NpgsqlCirclecircle0M.AssertModel(models[14],_testData[21], false);NpgsqlCirclecircle0M.AssertModel(models[15],_testData[22], false);NpgsqlCirclecircle0M.AssertModel(models[16],_testData[23], false);NpgsqlCirclecircle0M.AssertModel(models[17],_testData[24], false);NpgsqlCirclecircle0M.AssertModel(models[18],_testData[25], false);NpgsqlCirclecircle0M.AssertModel(models[19],_testData[26], false);NpgsqlCirclecircle0M.AssertModel(models[20],_testData[27], false);NpgsqlCirclecircle0M.AssertModel(models[21],_testData[28], false);NpgsqlCirclecircle0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 19, query1, 152, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[4], false);FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[5], false);FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[6], false);FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[7], false);FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[8], false);FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[9], false);FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[10], false);FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[11], false);FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[12], false);FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[13], false);FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[14], false);FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[15], false);FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[16], false);FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[17], false);FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[18], false);FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[19], false);FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[20], false);FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[21], false);FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[22], false);FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[23], false);FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[24], false);FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[25], false);FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[26], false);FlatNpgsqlCirclecircle0M.AssertModel(models[23],_testData[27], false);FlatNpgsqlCirclecircle0M.AssertModel(models[24],_testData[28], false);FlatNpgsqlCirclecircle0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[27], false);FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[28], false);FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatch(connection, 19, query1, 84, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[4], false);FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[5], false);FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[6], false);FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[7], false);FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[8], false);FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[9], false);FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[10], false);FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[11], false);FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[12], false);FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[13], false);FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[14], false);FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[15], false);FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[16], false);FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[17], false);FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[18], false);FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[19], false);FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[20], false);FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[21], false);FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[22], false);FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[23], false);FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[24], false);FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[25], false);FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[26], false);FlatNpgsqlCirclecircle0M.AssertModel(models[23],_testData[27], false);FlatNpgsqlCirclecircle0M.AssertModel(models[24],_testData[28], false);FlatNpgsqlCirclecircle0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[16], false);FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[17], false);FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[18], false);FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[19], false);FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[20], false);FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[21], false);FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[22], false);FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[23], false);FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[24], false);FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[25], false);FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[26], false);FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[27], false);FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[28], false);FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelBatchAsync(connection, 107, 75))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
NpgsqlCirclecircle0M.AssertModel(models[0],_testData[20], false);NpgsqlCirclecircle0M.AssertModel(models[1],_testData[21], false);NpgsqlCirclecircle0M.AssertModel(models[2],_testData[22], false);NpgsqlCirclecircle0M.AssertModel(models[3],_testData[23], false);NpgsqlCirclecircle0M.AssertModel(models[4],_testData[24], false);NpgsqlCirclecircle0M.AssertModel(models[5],_testData[25], false);NpgsqlCirclecircle0M.AssertModel(models[6],_testData[26], false);NpgsqlCirclecircle0M.AssertModel(models[7],_testData[27], false);NpgsqlCirclecircle0M.AssertModel(models[8],_testData[28], false);NpgsqlCirclecircle0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlCirclecircle0M.AssertModel(models[0],_testData[15], false);NpgsqlCirclecircle0M.AssertModel(models[1],_testData[16], false);NpgsqlCirclecircle0M.AssertModel(models[2],_testData[17], false);NpgsqlCirclecircle0M.AssertModel(models[3],_testData[18], false);NpgsqlCirclecircle0M.AssertModel(models[4],_testData[19], false);NpgsqlCirclecircle0M.AssertModel(models[5],_testData[20], false);NpgsqlCirclecircle0M.AssertModel(models[6],_testData[21], false);NpgsqlCirclecircle0M.AssertModel(models[7],_testData[22], false);NpgsqlCirclecircle0M.AssertModel(models[8],_testData[23], false);NpgsqlCirclecircle0M.AssertModel(models[9],_testData[24], false);NpgsqlCirclecircle0M.AssertModel(models[10],_testData[25], false);NpgsqlCirclecircle0M.AssertModel(models[11],_testData[26], false);NpgsqlCirclecircle0M.AssertModel(models[12],_testData[27], false);NpgsqlCirclecircle0M.AssertModel(models[13],_testData[28], false);NpgsqlCirclecircle0M.AssertModel(models[14],_testData[29], false);
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
                var models =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelBatch(connection, 98, 98))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
NpgsqlCirclecircle0M.AssertModel(models[0],_testData[18], false);NpgsqlCirclecircle0M.AssertModel(models[1],_testData[19], false);NpgsqlCirclecircle0M.AssertModel(models[2],_testData[20], false);NpgsqlCirclecircle0M.AssertModel(models[3],_testData[21], false);NpgsqlCirclecircle0M.AssertModel(models[4],_testData[22], false);NpgsqlCirclecircle0M.AssertModel(models[5],_testData[23], false);NpgsqlCirclecircle0M.AssertModel(models[6],_testData[24], false);NpgsqlCirclecircle0M.AssertModel(models[7],_testData[25], false);NpgsqlCirclecircle0M.AssertModel(models[8],_testData[26], false);NpgsqlCirclecircle0M.AssertModel(models[9],_testData[27], false);NpgsqlCirclecircle0M.AssertModel(models[10],_testData[28], false);NpgsqlCirclecircle0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
NpgsqlCirclecircle0M.AssertModel(models[0],_testData[18], false);NpgsqlCirclecircle0M.AssertModel(models[1],_testData[19], false);NpgsqlCirclecircle0M.AssertModel(models[2],_testData[20], false);NpgsqlCirclecircle0M.AssertModel(models[3],_testData[21], false);NpgsqlCirclecircle0M.AssertModel(models[4],_testData[22], false);NpgsqlCirclecircle0M.AssertModel(models[5],_testData[23], false);NpgsqlCirclecircle0M.AssertModel(models[6],_testData[24], false);NpgsqlCirclecircle0M.AssertModel(models[7],_testData[25], false);NpgsqlCirclecircle0M.AssertModel(models[8],_testData[26], false);NpgsqlCirclecircle0M.AssertModel(models[9],_testData[27], false);NpgsqlCirclecircle0M.AssertModel(models[10],_testData[28], false);NpgsqlCirclecircle0M.AssertModel(models[11],_testData[29], false);
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
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 19);
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
NpgsqlCirclecircle0M.AssertModel(models[0],_testData[4], false);NpgsqlCirclecircle0M.AssertModel(models[1],_testData[5], false);NpgsqlCirclecircle0M.AssertModel(models[2],_testData[6], false);NpgsqlCirclecircle0M.AssertModel(models[3],_testData[7], false);NpgsqlCirclecircle0M.AssertModel(models[4],_testData[8], false);NpgsqlCirclecircle0M.AssertModel(models[5],_testData[9], false);NpgsqlCirclecircle0M.AssertModel(models[6],_testData[10], false);NpgsqlCirclecircle0M.AssertModel(models[7],_testData[11], false);NpgsqlCirclecircle0M.AssertModel(models[8],_testData[12], false);NpgsqlCirclecircle0M.AssertModel(models[9],_testData[13], false);NpgsqlCirclecircle0M.AssertModel(models[10],_testData[14], false);NpgsqlCirclecircle0M.AssertModel(models[11],_testData[15], false);NpgsqlCirclecircle0M.AssertModel(models[12],_testData[16], false);NpgsqlCirclecircle0M.AssertModel(models[13],_testData[17], false);NpgsqlCirclecircle0M.AssertModel(models[14],_testData[18], false);NpgsqlCirclecircle0M.AssertModel(models[15],_testData[19], false);NpgsqlCirclecircle0M.AssertModel(models[16],_testData[20], false);NpgsqlCirclecircle0M.AssertModel(models[17],_testData[21], false);NpgsqlCirclecircle0M.AssertModel(models[18],_testData[22], false);NpgsqlCirclecircle0M.AssertModel(models[19],_testData[23], false);NpgsqlCirclecircle0M.AssertModel(models[20],_testData[24], false);NpgsqlCirclecircle0M.AssertModel(models[21],_testData[25], false);NpgsqlCirclecircle0M.AssertModel(models[22],_testData[26], false);NpgsqlCirclecircle0M.AssertModel(models[23],_testData[27], false);NpgsqlCirclecircle0M.AssertModel(models[24],_testData[28], false);NpgsqlCirclecircle0M.AssertModel(models[25],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 115);
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
NpgsqlCirclecircle0M.AssertModel(models[0],_testData[21], false);NpgsqlCirclecircle0M.AssertModel(models[1],_testData[22], false);NpgsqlCirclecircle0M.AssertModel(models[2],_testData[23], false);NpgsqlCirclecircle0M.AssertModel(models[3],_testData[24], false);NpgsqlCirclecircle0M.AssertModel(models[4],_testData[25], false);NpgsqlCirclecircle0M.AssertModel(models[5],_testData[26], false);NpgsqlCirclecircle0M.AssertModel(models[6],_testData[27], false);NpgsqlCirclecircle0M.AssertModel(models[7],_testData[28], false);NpgsqlCirclecircle0M.AssertModel(models[8],_testData[29], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43189242255459004d, y: 0.6281341595850557d), radius: 0.214482482021653d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43066611881330463d, y: 0.15852399967368702d), radius: 0.3017498558984154d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2136913562535877d, y: 0.023211213036073874d), radius: 0.11668329784709608d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5950866451147121d, y: 0.11382214151535341d), radius: 0.10565968758644595d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3206723796378653d, y: 0.5701428575931639d), radius: 0.5391514830033309d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7402736706782522d, y: 0.43635721612976186d), radius: 0.9834030051252284d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.86419514935638d, y: 0.268414627767088d), radius: 0.2737328018373444d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5653891510472436d, y: 0.600597407554274d), radius: 0.05610071643177361d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5143688240422777d, y: 0.3581511467479902d), radius: 0.5390890314370088d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15356369383647994d, y: 0.4617921918870096d), radius: 0.7470812941596028d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2366100600678942d, y: 0.7778173592587311d), radius: 0.9864351813024512d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3549882755203174d, y: 0.9338495609046518d), radius: 0.7558677790594555d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08435232490583944d, y: 0.8290873561609723d), radius: 0.8396314403274119d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11745217744944647d, y: 0.45020949130582844d), radius: 0.23097663631736365d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36472339727259906d, y: 0.7125776215660586d), radius: 0.3199109797530474d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7934298450340024d, y: 0.9622781803842675d), radius: 0.15105061036156542d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4051547030607382d, y: 0.7341669744921919d), radius: 0.13501613529687118d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10220917182313449d, y: 0.7199839487051429d), radius: 0.21695490921375227d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3818965315944962d, y: 0.9854179353175999d), radius: 0.4241043162793875d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6917900479571663d, y: 0.4642094936384271d), radius: 0.8907853201671136d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5238735998221258d, y: 0.36947296287940656d), radius: 0.3651187088560143d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9461223840524248d, y: 0.44547956445202397d), radius: 0.1479730191493399d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06170777388497106d, y: 0.028113565981159994d), radius: 0.7384313756551109d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.888455140894486d, y: 0.6382658890927744d), radius: 0.06952921243767429d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09062653751792638d, y: 0.27500950293616044d), radius: 0.4432815149710585d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5788241235002597d, y: 0.7276473371912225d), radius: 0.18892830467841937d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3175960501184736d, y: 0.4757924478979594d), radius: 0.6618840691509589d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.779627784316765d, y: 0.21878714368880336d), radius: 0.8879265180907678d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2512604032930513d, y: 0.3723203859591693d), radius: 0.7154376328486002d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7812862667930052d, y: 0.7125068866192538d), radius: 0.3212654433559047d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08705384412326034d, y: 0.17995450047863282d), radius: 0.5064621345970189d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2854996026876737d, y: 0.9088858702863883d), radius: 0.24859971277816773d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8706985667132583d, y: 0.05517100848032053d), radius: 0.7111927768477067d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7663143277984279d, y: 0.6644151837436882d), radius: 0.7028600313800695d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020333853062769358d, y: 0.4672178670398178d), radius: 0.9228632081771551d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03384777750364942d, y: 0.6910906032874659d), radius: 0.9396127519123323d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17051101667701885d, y: 0.663684484227292d), radius: 0.05122217780542759d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06617457543998884d, y: 0.48559405891603d), radius: 0.7945553511322585d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8381180777583388d, y: 0.47417520758778553d), radius: 0.5627665412499266d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19092066452558987d, y: 0.05845453230766162d), radius: 0.012173472446699418d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34157281295923303d, y: 0.6338328620793257d), radius: 0.5663732861589991d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.716181864180684d, y: 0.27769095265680355d), radius: 0.3354777326824381d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.987400429716878d, y: 0.5641466320523828d), radius: 0.945636480023413d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05843665635224948d, y: 0.42611281440752424d), radius: 0.24553188461247089d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8827372474348893d, y: 0.8801159377016956d), radius: 0.22860311256846788d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1520152501573364d, y: 0.13063752016965635d), radius: 0.5777392945354192d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8577177109333519d, y: 0.8204838902138966d), radius: 0.11935506620662717d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9257883443413619d, y: 0.39623020431171363d), radius: 0.7755814155386545d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.511631160330754d, y: 0.15611772837700832d), radius: 0.5670153867879957d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30345555601266405d, y: 0.45190124441453605d), radius: 0.2857563416795973d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.479162914346957d, y: 0.09494026594691019d), radius: 0.9026365011424459d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44341999383619657d, y: 0.08593428063982489d), radius: 0.4054927838815394d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6489175099038844d, y: 0.22587731751365536d), radius: 0.23299866358554966d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46958963794929565d, y: 0.07094524821058912d), radius: 0.27760345600135794d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35862954561951843d, y: 0.9998823792212063d), radius: 0.23958998191074665d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3141020005305325d, y: 0.30108637392174364d), radius: 0.9126330447138274d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38166385375369705d, y: 0.7227417744077622d), radius: 0.44298311099989496d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9744832055412603d, y: 0.8876445711434099d), radius: 0.3432777707168697d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8446174832644104d, y: 0.7575601515996012d), radius: 0.46481291218219556d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11090356282546276d, y: 0.9259164094116851d), radius: 0.29046013363414047d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9958160071699524d, y: 0.1833125625854879d), radius: 0.9067372325098075d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2404162365744028d, y: 0.31122341685490884d), radius: 0.026889403131830525d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02500611874687997d, y: 0.842522419149292d), radius: 0.9573608581313283d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4924004058788377d, y: 0.012035979616373815d), radius: 0.3273306145068212d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11033430227685737d, y: 0.021248702150420518d), radius: 0.9291131734536748d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9155480196901161d, y: 0.08695910112790461d), radius: 0.6928814611760182d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48962680678144244d, y: 0.5324300383227751d), radius: 0.794469149899103d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8921436447193842d, y: 0.5921649874292841d), radius: 0.7326927935424218d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7826745492369169d, y: 0.8240312715855396d), radius: 0.47246123555798125d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8159465947857059d, y: 0.20924204257193713d), radius: 0.49375617515809855d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23056458090343357d, y: 0.3622929703177604d), radius: 0.6940758818566388d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47078921596136947d, y: 0.17232849490232094d), radius: 0.29774366315551803d))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43189242255459004d, y: 0.6281341595850557d), radius: 0.214482482021653d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43066611881330463d, y: 0.15852399967368702d), radius: 0.3017498558984154d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2136913562535877d, y: 0.023211213036073874d), radius: 0.11668329784709608d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5950866451147121d, y: 0.11382214151535341d), radius: 0.10565968758644595d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3206723796378653d, y: 0.5701428575931639d), radius: 0.5391514830033309d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7402736706782522d, y: 0.43635721612976186d), radius: 0.9834030051252284d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.86419514935638d, y: 0.268414627767088d), radius: 0.2737328018373444d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5653891510472436d, y: 0.600597407554274d), radius: 0.05610071643177361d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5143688240422777d, y: 0.3581511467479902d), radius: 0.5390890314370088d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15356369383647994d, y: 0.4617921918870096d), radius: 0.7470812941596028d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2366100600678942d, y: 0.7778173592587311d), radius: 0.9864351813024512d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3549882755203174d, y: 0.9338495609046518d), radius: 0.7558677790594555d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08435232490583944d, y: 0.8290873561609723d), radius: 0.8396314403274119d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11745217744944647d, y: 0.45020949130582844d), radius: 0.23097663631736365d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36472339727259906d, y: 0.7125776215660586d), radius: 0.3199109797530474d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7934298450340024d, y: 0.9622781803842675d), radius: 0.15105061036156542d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4051547030607382d, y: 0.7341669744921919d), radius: 0.13501613529687118d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10220917182313449d, y: 0.7199839487051429d), radius: 0.21695490921375227d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3818965315944962d, y: 0.9854179353175999d), radius: 0.4241043162793875d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6917900479571663d, y: 0.4642094936384271d), radius: 0.8907853201671136d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5238735998221258d, y: 0.36947296287940656d), radius: 0.3651187088560143d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9461223840524248d, y: 0.44547956445202397d), radius: 0.1479730191493399d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06170777388497106d, y: 0.028113565981159994d), radius: 0.7384313756551109d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.888455140894486d, y: 0.6382658890927744d), radius: 0.06952921243767429d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09062653751792638d, y: 0.27500950293616044d), radius: 0.4432815149710585d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5788241235002597d, y: 0.7276473371912225d), radius: 0.18892830467841937d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3175960501184736d, y: 0.4757924478979594d), radius: 0.6618840691509589d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.779627784316765d, y: 0.21878714368880336d), radius: 0.8879265180907678d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2512604032930513d, y: 0.3723203859591693d), radius: 0.7154376328486002d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7812862667930052d, y: 0.7125068866192538d), radius: 0.3212654433559047d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08705384412326034d, y: 0.17995450047863282d), radius: 0.5064621345970189d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2854996026876737d, y: 0.9088858702863883d), radius: 0.24859971277816773d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8706985667132583d, y: 0.05517100848032053d), radius: 0.7111927768477067d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7663143277984279d, y: 0.6644151837436882d), radius: 0.7028600313800695d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020333853062769358d, y: 0.4672178670398178d), radius: 0.9228632081771551d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03384777750364942d, y: 0.6910906032874659d), radius: 0.9396127519123323d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17051101667701885d, y: 0.663684484227292d), radius: 0.05122217780542759d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06617457543998884d, y: 0.48559405891603d), radius: 0.7945553511322585d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8381180777583388d, y: 0.47417520758778553d), radius: 0.5627665412499266d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19092066452558987d, y: 0.05845453230766162d), radius: 0.012173472446699418d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34157281295923303d, y: 0.6338328620793257d), radius: 0.5663732861589991d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.716181864180684d, y: 0.27769095265680355d), radius: 0.3354777326824381d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.987400429716878d, y: 0.5641466320523828d), radius: 0.945636480023413d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05843665635224948d, y: 0.42611281440752424d), radius: 0.24553188461247089d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8827372474348893d, y: 0.8801159377016956d), radius: 0.22860311256846788d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1520152501573364d, y: 0.13063752016965635d), radius: 0.5777392945354192d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8577177109333519d, y: 0.8204838902138966d), radius: 0.11935506620662717d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9257883443413619d, y: 0.39623020431171363d), radius: 0.7755814155386545d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.511631160330754d, y: 0.15611772837700832d), radius: 0.5670153867879957d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30345555601266405d, y: 0.45190124441453605d), radius: 0.2857563416795973d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.479162914346957d, y: 0.09494026594691019d), radius: 0.9026365011424459d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44341999383619657d, y: 0.08593428063982489d), radius: 0.4054927838815394d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6489175099038844d, y: 0.22587731751365536d), radius: 0.23299866358554966d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46958963794929565d, y: 0.07094524821058912d), radius: 0.27760345600135794d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35862954561951843d, y: 0.9998823792212063d), radius: 0.23958998191074665d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3141020005305325d, y: 0.30108637392174364d), radius: 0.9126330447138274d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38166385375369705d, y: 0.7227417744077622d), radius: 0.44298311099989496d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9744832055412603d, y: 0.8876445711434099d), radius: 0.3432777707168697d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8446174832644104d, y: 0.7575601515996012d), radius: 0.46481291218219556d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11090356282546276d, y: 0.9259164094116851d), radius: 0.29046013363414047d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9958160071699524d, y: 0.1833125625854879d), radius: 0.9067372325098075d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2404162365744028d, y: 0.31122341685490884d), radius: 0.026889403131830525d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02500611874687997d, y: 0.842522419149292d), radius: 0.9573608581313283d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4924004058788377d, y: 0.012035979616373815d), radius: 0.3273306145068212d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11033430227685737d, y: 0.021248702150420518d), radius: 0.9291131734536748d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9155480196901161d, y: 0.08695910112790461d), radius: 0.6928814611760182d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48962680678144244d, y: 0.5324300383227751d), radius: 0.794469149899103d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8921436447193842d, y: 0.5921649874292841d), radius: 0.7326927935424218d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7826745492369169d, y: 0.8240312715855396d), radius: 0.47246123555798125d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8159465947857059d, y: 0.20924204257193713d), radius: 0.49375617515809855d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23056458090343357d, y: 0.3622929703177604d), radius: 0.6940758818566388d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47078921596136947d, y: 0.17232849490232094d), radius: 0.29774366315551803d))));

            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI)],
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
FROM public.binary_npgsqlcirclecircle0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircle0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlCircleSingleTypecircle)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlCircleSingleTypecircle)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlCircleSingleTypecircle)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecircle0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
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
FROM public.binary_npgsqlcirclecircle0m m
LEFT JOIN public.binary_npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircle0M>(15);

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
                ((INpgsqlCircleSingleTypecircle)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircle0M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircle0M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircle0M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircle0M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircle0M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircle0M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircle0M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircle0M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircle0M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircle0M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircle0M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircle0M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircle0M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircle0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlCircleSingleTypecircle)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlCircleSingleTypecircle)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircle0M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircle0M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircle0M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircle0M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircle0M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircle0M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircle0M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircle0M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircle0M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircle0M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircle0M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircle0M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircle0M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircle0M.AssertModel(models[14],_testData[14], false);
                NpgsqlCirclecircle0M.AssertModel(models[15],_testData[15], false);
                NpgsqlCirclecircle0M.AssertModel(models[16],_testData[16], false);
                NpgsqlCirclecircle0M.AssertModel(models[17],_testData[17], false);
                NpgsqlCirclecircle0M.AssertModel(models[18],_testData[18], false);
                NpgsqlCirclecircle0M.AssertModel(models[19],_testData[19], false);
                NpgsqlCirclecircle0M.AssertModel(models[20],_testData[20], false);
                NpgsqlCirclecircle0M.AssertModel(models[21],_testData[21], false);
                NpgsqlCirclecircle0M.AssertModel(models[22],_testData[22], false);
                NpgsqlCirclecircle0M.AssertModel(models[23],_testData[23], false);
                NpgsqlCirclecircle0M.AssertModel(models[24],_testData[24], false);
                NpgsqlCirclecircle0M.AssertModel(models[25],_testData[25], false);
                NpgsqlCirclecircle0M.AssertModel(models[26],_testData[26], false);
                NpgsqlCirclecircle0M.AssertModel(models[27],_testData[27], false);
                NpgsqlCirclecircle0M.AssertModel(models[28],_testData[28], false);
                NpgsqlCirclecircle0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecircle0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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
                    NpgsqlCirclecircle0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
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
                    NpgsqlCirclecircle0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecircle0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

