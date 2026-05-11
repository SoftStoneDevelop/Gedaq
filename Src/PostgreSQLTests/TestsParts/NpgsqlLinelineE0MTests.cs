

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
    internal partial interface INpgsqlLineSingleTypeline
    {
    }
    
    internal partial class NpgsqlLineSingleTypeline : INpgsqlLineSingleTypeline
    {


#region TestData

        private readonly NpgsqlLinelineE0M[] _testData = new NpgsqlLinelineE0M[]
        {
            new NpgsqlLinelineE0M
{
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.43134683196266355d, b: 0.4248331312954924d, c: 0.8331930189917786d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9419400154436728d, b: 0.7507741128258218d, c: 0.43765648580137884d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1562892649972032d, b: 0.16796528531720456d, c: 0.47327390551682136d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6180932258928592d, b: 0.8066672382965203d, c: 0.11929242724727407d),
},
            new NpgsqlLinelineE0M
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4718816085470836d, b: 0.07835090887089036d, c: 0.23428656740706078d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8683602546355597d, b: 0.048537742703667064d, c: 0.4412606534467691d),
},
            new NpgsqlLinelineE0M
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4875546965678864d, b: 0.002553148378441117d, c: 0.6929118245157293d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.26986216386232886d, b: 0.8487641576310675d, c: 0.9278637854825554d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6919429864855738d, b: 0.18146406308734797d, c: 0.9210519129730973d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.584771503825712d, b: 0.0988672021028224d, c: 0.9288844750387768d),
},
            new NpgsqlLinelineE0M
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.23483635838968853d, b: 0.2650959200825954d, c: 0.6848504832150133d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4819991230437699d, b: 0.4338347751391737d, c: 0.9035962402903999d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.20207039809641092d, b: 0.9453524415466067d, c: 0.5057595900017956d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6050294445719062d, b: 0.5655311623089193d, c: 0.41335477997627923d),
},
            new NpgsqlLinelineE0M
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1606052356084564d, b: 0.9636074840623211d, c: 0.5088867561355647d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.2833974270237739d, b: 0.30852383872766953d, c: 0.029264696710481264d),
},
            new NpgsqlLinelineE0M
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.880114194901329d, b: 0.8840278206651881d, c: 0.08176619781856986d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9516200854742356d, b: 0.8105691225738704d, c: 0.2918818159663835d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6840327292181976d, b: 0.8826367237759454d, c: 0.3031185663433381d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.1798463875864057d, b: 0.8995778952080757d, c: 0.715300113440156d),
},
            new NpgsqlLinelineE0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8313669596223622d, b: 0.5365571103263543d, c: 0.6669757631424165d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6725908854650045d, b: 0.4497383003640615d, c: 0.4491242716227043d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.40338404379985937d, b: 0.031702446528004025d, c: 0.16401398954940571d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.542929045641513d, b: 0.4503482031972784d, c: 0.6702188956510482d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.514541317960834d, b: 0.7128322173429273d, c: 0.12267324359324272d),
},
            new NpgsqlLinelineE0M
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.0821302329175555d, b: 0.2510286731944069d, c: 0.7720404656751799d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.17972742694815247d, b: 0.17189185514342398d, c: 0.4564260682021901d),
},
            new NpgsqlLinelineE0M
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.18445960446652077d, b: 0.02041297349915605d, c: 0.8099386061117386d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4128382548097882d, b: 0.2060615326570303d, c: 0.8169915546492532d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8691108778475002d, b: 0.23172330485304682d, c: 0.9699083063584722d),
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8111934823423307d, b: 0.2520938742802804d, c: 0.19944829289195853d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.19684921422546076d, b: 0.12811646494628248d, c: 0.8440763224930709d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.44521964977899775d, b: 0.7897128468343839d, c: 0.15712061167177027d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5825712099625624d, b: 0.5081918875386865d, c: 0.4590892541086872d),
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1083402232901669d, b: 0.11896040442188027d, c: 0.4307988578900587d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3629027263682276d, b: 0.9630699727914276d, c: 0.7717357847748811d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7447735848461261d, b: 0.005039737536500555d, c: 0.8503052290167207d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7943438173225903d, b: 0.5028787604420228d, c: 0.5185607641397801d),
},
            new NpgsqlLinelineE0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.13281625066419356d, b: 0.4312341251929315d, c: 0.05913655635289006d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9960262753705909d, b: 0.7052307602926423d, c: 0.14915388129377039d),
},
            new NpgsqlLinelineE0M
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5916385418743899d, b: 0.16661124259915583d, c: 0.3007212801852469d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5483392078051252d, b: 0.2349683039535596d, c: 0.7046885217693121d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.46077108983355664d, b: 0.9426261524703305d, c: 0.9983025184270918d),
},
            new NpgsqlLinelineE0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7687812906367962d, b: 0.6929056076161926d, c: 0.4124336484011045d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3054558319194238d, b: 0.513628384808109d, c: 0.7117264000956957d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7033587331399344d, b: 0.23066148340408388d, c: 0.7255591642401757d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5400691126397129d, b: 0.5197362030219304d, c: 0.9183940428984678d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8936659510512797d, b: 0.8734449912940334d, c: 0.2150004504491182d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6063042433636562d, b: 0.9845003711015476d, c: 0.5776809180561076d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8685717834449517d, b: 0.0698586588269321d, c: 0.919060107559802d),
},
            new NpgsqlLinelineE0M
{
    Id = 112,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.12191540045236193d, b: 0.13273126965552762d, c: 0.7177004905261369d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7042245689131317d, b: 0.30973091249185447d, c: 0.6211337487747591d),
},
            new NpgsqlLinelineE0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4187071628434622d, b: 0.8175560708425883d, c: 0.690386419582182d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8148756540445659d, b: 0.976345523402207d, c: 0.10436456193921362d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.43389231460332844d, b: 0.989229067746431d, c: 0.9635362530793941d),
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6562152419642112d, b: 0.9973036310327847d, c: 0.7458796462574996d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.23325578257665736d, b: 0.07440852364271067d, c: 0.07087249042546895d),
},
            new NpgsqlLinelineE0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4752683075294062d, b: 0.9899040051002816d, c: 0.7698382407402734d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9116268791339608d, b: 0.02285831682056849d, c: 0.5300152026897518d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7229978192127738d, b: 0.37042547081713095d, c: 0.9094764493875087d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.1556773063359973d, b: 0.2101678417160351d, c: 0.055360946262861366d),
},
            new NpgsqlLinelineE0M
{
    Id = 127,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.19911968472099828d, b: 0.30306660487268156d, c: 0.33768411457355574d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8397555075062462d, b: 0.46681182507767094d, c: 0.44981419458397454d),
},
            new NpgsqlLinelineE0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.731250085008644d, b: 0.7632028460460129d, c: 0.8597300197656993d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.46243994993103d, b: 0.2075416207730496d, c: 0.3411494999014608d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 145,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8046289236469442d, b: 0.6929270619279582d, c: 0.23805799525057814d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 153,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.21223985934644363d, b: 0.3114541595036959d, c: 0.04798921034747783d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4674870887548205d, b: 0.25718945345733746d, c: 0.8209517992829782d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5653539972241692d, b: 0.886339500498332d, c: 0.5789376016487178d),
},
            new NpgsqlLinelineE0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7698279889569132d, b: 0.726464354816057d, c: 0.2433468464625702d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 159,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7012163078396644d, b: 0.31915159324044917d, c: 0.7048456533062877d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.04020906545779335d, b: 0.039089196449451635d, c: 0.5006839859736644d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6867905022829779d, b: 0.0602220883095419d, c: 0.4670073298166545d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.40758337786212084d, b: 0.9784825347418163d, c: 0.48318087221675d),
},
            new NpgsqlLinelineE0M
{
    Id = 161,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9308027449958416d, b: 0.5577520826381469d, c: 0.6141166040474124d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7292629975660031d, b: 0.8811215988692312d, c: 0.1258290678345919d),
},
            new NpgsqlLinelineE0M
{
    Id = 170,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2618981683520629d, b: 0.16578248208715474d, c: 0.9451704269994253d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.64669462700936d, b: 0.39339138972676035d, c: 0.23354846207843016d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.369158479222674d, b: 0.26737870121934737d, c: 0.2693659472625286d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7974085767461631d, b: 0.7672180622077803d, c: 0.3206216627505817d),
},
            new NpgsqlLinelineE0M
{
    Id = 179,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4661608036392306d, b: 0.6353798794865597d, c: 0.5957153597308121d),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinee0mi(
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinee0mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(10))]
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

                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinee0mi(
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
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

                changedRows =  ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinee0m(
	id,
    value,
    nullablevalue,
    npgsqllinelinee0mi_id
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinee0mi_id", 
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
                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinee0m(
	id,
    value,
    nullablevalue,
    npgsqllinelinee0mi_id
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
    npgsqllinelinee0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                NpgsqlTypes.NpgsqlLine? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
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

                    nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
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

                    nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6050294445719062d, b: 0.5655311623089193d, c: 0.41335477997627923d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
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

                    nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.2833974270237739d, b: 0.30852383872766953d, c: 0.029264696710481264d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
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

                    nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.1798463875864057d, b: 0.8995778952080757d, c: 0.715300113440156d)));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinee0m(
	id,
    value,
    nullablevalue,
    npgsqllinelinee0mi_id
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
    npgsqllinelinee0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinee0mi_id", 
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
                NpgsqlTypes.NpgsqlLine? nullable = null;
                nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.514541317960834d, b: 0.7128322173429273d, c: 0.12267324359324272d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine? nullable = null;
                nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.17972742694815247d, b: 0.17189185514342398d, c: 0.4564260682021901d)));
                nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineE0M> models = null;

                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineE0M> models = null;

                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinee0m(
	id,
    value,
    nullablevalue,
    npgsqllinelinee0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqllinelinee0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlLine), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqllinelinee0mi_id", 
                methodParametrName: "npgsqllinelinee0mi_id", 
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

                changedRows =  ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineE0M), typeof(FlatNpgsqlLinelineE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllinelinee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineE0M>();
                var models2 = new List<FlatNpgsqlLinelineE0M>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineE0M>();
                var models2 = new List<FlatNpgsqlLinelineE0M>();
                ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllinelinee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
LEFT JOIN public.npgsqllinelinee0mi mi ON mi.id = m.npgsqllinelinee0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                var models = await ((INpgsqlLineSingleTypeline)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineSingleTypeline)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineE0M), typeof(FlatNpgsqlLinelineE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllinelinee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineE0M>();
                var models2 = new List<FlatNpgsqlLinelineE0M>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineE0M>();
                var models2 = new List<FlatNpgsqlLinelineE0M>();
                ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllinelinee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineSingleTypeline)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
LEFT JOIN public.npgsqllinelinee0mi mi ON mi.id = m.npgsqllinelinee0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                var models = await ((INpgsqlLineSingleTypeline)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineSingleTypeline)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineE0M), typeof(FlatNpgsqlLinelineE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineE0M>();
                var models2 = new List<FlatNpgsqlLinelineE0M>();
                await((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var firstItems2 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems2 = new List<FlatNpgsqlLinelineE0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var firstItems2 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineE0M>();
                var models2 = new List<FlatNpgsqlLinelineE0M>();
                ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var firstItems2 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems2 = new List<FlatNpgsqlLinelineE0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 29;
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var firstItems2 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 154;
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems2 = new List<FlatNpgsqlLinelineE0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems2 = new List<FlatNpgsqlLinelineE0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
LEFT JOIN public.npgsqllinelinee0mi mi ON mi.id = m.npgsqllinelinee0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[13], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[14], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[15], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[16], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[17], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[18], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[19], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[20], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[21], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[22], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[23], false);
                        NpgsqlLinelineE0M.AssertModel(models[11],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[12],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[13],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[14],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[15],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[16],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[17],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[18],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[19],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[20],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[17],_testData[34], false);
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
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[4], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[5], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[6], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[7], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[8], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[9], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[10], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[11], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[12], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[13], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[14], false);
                        NpgsqlLinelineE0M.AssertModel(models[11],_testData[15], false);
                        NpgsqlLinelineE0M.AssertModel(models[12],_testData[16], false);
                        NpgsqlLinelineE0M.AssertModel(models[13],_testData[17], false);
                        NpgsqlLinelineE0M.AssertModel(models[14],_testData[18], false);
                        NpgsqlLinelineE0M.AssertModel(models[15],_testData[19], false);
                        NpgsqlLinelineE0M.AssertModel(models[16],_testData[20], false);
                        NpgsqlLinelineE0M.AssertModel(models[17],_testData[21], false);
                        NpgsqlLinelineE0M.AssertModel(models[18],_testData[22], false);
                        NpgsqlLinelineE0M.AssertModel(models[19],_testData[23], false);
                        NpgsqlLinelineE0M.AssertModel(models[20],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[21],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[22],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[23],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[24],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[25],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[26],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[27],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[28],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[29],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineE0M), typeof(FlatNpgsqlLinelineE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineE0M>();
                var models2 = new List<FlatNpgsqlLinelineE0M>();
                await((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var firstItems2 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems2 = new List<FlatNpgsqlLinelineE0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 22, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var firstItems2 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 154, query1, 115, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineE0M>();
                var models2 = new List<FlatNpgsqlLinelineE0M>();
                ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var firstItems2 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems2 = new List<FlatNpgsqlLinelineE0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 2, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var firstItems2 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatch(connection, 114, query1, 159, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 120, query1, 85, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems2 = new List<FlatNpgsqlLinelineE0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 120, query1, 93, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatch(connection, 22, query1, 57, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[21],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems2 = new List<FlatNpgsqlLinelineE0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatch(connection, 136, query1, 93, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
LEFT JOIN public.npgsqllinelinee0mi mi ON mi.id = m.npgsqllinelinee0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatchAsync(connection, 145, 8))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlLinelineE0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlLinelineE0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlLinelineE0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlLinelineE0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlLinelineE0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlLinelineE0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlLinelineE0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlLinelineE0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlLinelineE0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlLinelineE0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlLinelineE0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlLinelineE0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[27],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[28],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[29],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[30],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[31],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[32],_testData[34], false);
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
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatch(connection, 153, 22))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[5], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[6], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[7], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[8], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[9], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[10], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[11], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[12], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[13], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[14], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[15], false);
                        NpgsqlLinelineE0M.AssertModel(models[11],_testData[16], false);
                        NpgsqlLinelineE0M.AssertModel(models[12],_testData[17], false);
                        NpgsqlLinelineE0M.AssertModel(models[13],_testData[18], false);
                        NpgsqlLinelineE0M.AssertModel(models[14],_testData[19], false);
                        NpgsqlLinelineE0M.AssertModel(models[15],_testData[20], false);
                        NpgsqlLinelineE0M.AssertModel(models[16],_testData[21], false);
                        NpgsqlLinelineE0M.AssertModel(models[17],_testData[22], false);
                        NpgsqlLinelineE0M.AssertModel(models[18],_testData[23], false);
                        NpgsqlLinelineE0M.AssertModel(models[19],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[20],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[21],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[22],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[23],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[24],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[25],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[26],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[27],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[28],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[29],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 112);
                var models = await ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                NpgsqlLinelineE0M.AssertModel(models[0],_testData[23], false);
                NpgsqlLinelineE0M.AssertModel(models[1],_testData[24], false);
                NpgsqlLinelineE0M.AssertModel(models[2],_testData[25], false);
                NpgsqlLinelineE0M.AssertModel(models[3],_testData[26], false);
                NpgsqlLinelineE0M.AssertModel(models[4],_testData[27], false);
                NpgsqlLinelineE0M.AssertModel(models[5],_testData[28], false);
                NpgsqlLinelineE0M.AssertModel(models[6],_testData[29], false);
                NpgsqlLinelineE0M.AssertModel(models[7],_testData[30], false);
                NpgsqlLinelineE0M.AssertModel(models[8],_testData[31], false);
                NpgsqlLinelineE0M.AssertModel(models[9],_testData[32], false);
                NpgsqlLinelineE0M.AssertModel(models[10],_testData[33], false);
                NpgsqlLinelineE0M.AssertModel(models[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 57);
                var models =  ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

                NpgsqlLinelineE0M.AssertModel(models[0],_testData[13], false);
                NpgsqlLinelineE0M.AssertModel(models[1],_testData[14], false);
                NpgsqlLinelineE0M.AssertModel(models[2],_testData[15], false);
                NpgsqlLinelineE0M.AssertModel(models[3],_testData[16], false);
                NpgsqlLinelineE0M.AssertModel(models[4],_testData[17], false);
                NpgsqlLinelineE0M.AssertModel(models[5],_testData[18], false);
                NpgsqlLinelineE0M.AssertModel(models[6],_testData[19], false);
                NpgsqlLinelineE0M.AssertModel(models[7],_testData[20], false);
                NpgsqlLinelineE0M.AssertModel(models[8],_testData[21], false);
                NpgsqlLinelineE0M.AssertModel(models[9],_testData[22], false);
                NpgsqlLinelineE0M.AssertModel(models[10],_testData[23], false);
                NpgsqlLinelineE0M.AssertModel(models[11],_testData[24], false);
                NpgsqlLinelineE0M.AssertModel(models[12],_testData[25], false);
                NpgsqlLinelineE0M.AssertModel(models[13],_testData[26], false);
                NpgsqlLinelineE0M.AssertModel(models[14],_testData[27], false);
                NpgsqlLinelineE0M.AssertModel(models[15],_testData[28], false);
                NpgsqlLinelineE0M.AssertModel(models[16],_testData[29], false);
                NpgsqlLinelineE0M.AssertModel(models[17],_testData[30], false);
                NpgsqlLinelineE0M.AssertModel(models[18],_testData[31], false);
                NpgsqlLinelineE0M.AssertModel(models[19],_testData[32], false);
                NpgsqlLinelineE0M.AssertModel(models[20],_testData[33], false);
                NpgsqlLinelineE0M.AssertModel(models[21],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
LEFT JOIN public.npgsqllinelinee0mi mi ON mi.id = m.npgsqllinelinee0mi_id
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.43134683196266355d, b: 0.4248331312954924d, c: 0.8331930189917786d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9419400154436728d, b: 0.7507741128258218d, c: 0.43765648580137884d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1562892649972032d, b: 0.16796528531720456d, c: 0.47327390551682136d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6180932258928592d, b: 0.8066672382965203d, c: 0.11929242724727407d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4718816085470836d, b: 0.07835090887089036d, c: 0.23428656740706078d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8683602546355597d, b: 0.048537742703667064d, c: 0.4412606534467691d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4875546965678864d, b: 0.002553148378441117d, c: 0.6929118245157293d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.26986216386232886d, b: 0.8487641576310675d, c: 0.9278637854825554d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6919429864855738d, b: 0.18146406308734797d, c: 0.9210519129730973d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.584771503825712d, b: 0.0988672021028224d, c: 0.9288844750387768d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23483635838968853d, b: 0.2650959200825954d, c: 0.6848504832150133d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4819991230437699d, b: 0.4338347751391737d, c: 0.9035962402903999d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20207039809641092d, b: 0.9453524415466067d, c: 0.5057595900017956d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6050294445719062d, b: 0.5655311623089193d, c: 0.41335477997627923d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1606052356084564d, b: 0.9636074840623211d, c: 0.5088867561355647d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2833974270237739d, b: 0.30852383872766953d, c: 0.029264696710481264d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.880114194901329d, b: 0.8840278206651881d, c: 0.08176619781856986d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9516200854742356d, b: 0.8105691225738704d, c: 0.2918818159663835d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6840327292181976d, b: 0.8826367237759454d, c: 0.3031185663433381d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1798463875864057d, b: 0.8995778952080757d, c: 0.715300113440156d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8313669596223622d, b: 0.5365571103263543d, c: 0.6669757631424165d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6725908854650045d, b: 0.4497383003640615d, c: 0.4491242716227043d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.40338404379985937d, b: 0.031702446528004025d, c: 0.16401398954940571d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.542929045641513d, b: 0.4503482031972784d, c: 0.6702188956510482d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.514541317960834d, b: 0.7128322173429273d, c: 0.12267324359324272d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0821302329175555d, b: 0.2510286731944069d, c: 0.7720404656751799d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.17972742694815247d, b: 0.17189185514342398d, c: 0.4564260682021901d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.18445960446652077d, b: 0.02041297349915605d, c: 0.8099386061117386d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4128382548097882d, b: 0.2060615326570303d, c: 0.8169915546492532d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8691108778475002d, b: 0.23172330485304682d, c: 0.9699083063584722d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8111934823423307d, b: 0.2520938742802804d, c: 0.19944829289195853d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19684921422546076d, b: 0.12811646494628248d, c: 0.8440763224930709d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.44521964977899775d, b: 0.7897128468343839d, c: 0.15712061167177027d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5825712099625624d, b: 0.5081918875386865d, c: 0.4590892541086872d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1083402232901669d, b: 0.11896040442188027d, c: 0.4307988578900587d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3629027263682276d, b: 0.9630699727914276d, c: 0.7717357847748811d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7447735848461261d, b: 0.005039737536500555d, c: 0.8503052290167207d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7943438173225903d, b: 0.5028787604420228d, c: 0.5185607641397801d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13281625066419356d, b: 0.4312341251929315d, c: 0.05913655635289006d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9960262753705909d, b: 0.7052307602926423d, c: 0.14915388129377039d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5916385418743899d, b: 0.16661124259915583d, c: 0.3007212801852469d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5483392078051252d, b: 0.2349683039535596d, c: 0.7046885217693121d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.46077108983355664d, b: 0.9426261524703305d, c: 0.9983025184270918d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7687812906367962d, b: 0.6929056076161926d, c: 0.4124336484011045d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3054558319194238d, b: 0.513628384808109d, c: 0.7117264000956957d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7033587331399344d, b: 0.23066148340408388d, c: 0.7255591642401757d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5400691126397129d, b: 0.5197362030219304d, c: 0.9183940428984678d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8936659510512797d, b: 0.8734449912940334d, c: 0.2150004504491182d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6063042433636562d, b: 0.9845003711015476d, c: 0.5776809180561076d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8685717834449517d, b: 0.0698586588269321d, c: 0.919060107559802d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12191540045236193d, b: 0.13273126965552762d, c: 0.7177004905261369d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7042245689131317d, b: 0.30973091249185447d, c: 0.6211337487747591d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4187071628434622d, b: 0.8175560708425883d, c: 0.690386419582182d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8148756540445659d, b: 0.976345523402207d, c: 0.10436456193921362d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.43389231460332844d, b: 0.989229067746431d, c: 0.9635362530793941d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6562152419642112d, b: 0.9973036310327847d, c: 0.7458796462574996d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23325578257665736d, b: 0.07440852364271067d, c: 0.07087249042546895d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4752683075294062d, b: 0.9899040051002816d, c: 0.7698382407402734d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9116268791339608d, b: 0.02285831682056849d, c: 0.5300152026897518d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7229978192127738d, b: 0.37042547081713095d, c: 0.9094764493875087d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1556773063359973d, b: 0.2101678417160351d, c: 0.055360946262861366d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19911968472099828d, b: 0.30306660487268156d, c: 0.33768411457355574d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8397555075062462d, b: 0.46681182507767094d, c: 0.44981419458397454d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.731250085008644d, b: 0.7632028460460129d, c: 0.8597300197656993d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.46243994993103d, b: 0.2075416207730496d, c: 0.3411494999014608d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8046289236469442d, b: 0.6929270619279582d, c: 0.23805799525057814d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.21223985934644363d, b: 0.3114541595036959d, c: 0.04798921034747783d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4674870887548205d, b: 0.25718945345733746d, c: 0.8209517992829782d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5653539972241692d, b: 0.886339500498332d, c: 0.5789376016487178d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7698279889569132d, b: 0.726464354816057d, c: 0.2433468464625702d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7012163078396644d, b: 0.31915159324044917d, c: 0.7048456533062877d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.04020906545779335d, b: 0.039089196449451635d, c: 0.5006839859736644d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6867905022829779d, b: 0.0602220883095419d, c: 0.4670073298166545d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.40758337786212084d, b: 0.9784825347418163d, c: 0.48318087221675d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9308027449958416d, b: 0.5577520826381469d, c: 0.6141166040474124d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7292629975660031d, b: 0.8811215988692312d, c: 0.1258290678345919d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2618981683520629d, b: 0.16578248208715474d, c: 0.9451704269994253d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.64669462700936d, b: 0.39339138972676035d, c: 0.23354846207843016d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.369158479222674d, b: 0.26737870121934737d, c: 0.2693659472625286d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7974085767461631d, b: 0.7672180622077803d, c: 0.3206216627505817d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4661608036392306d, b: 0.6353798794865597d, c: 0.5957153597308121d))));//Value

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
                var models =  ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.43134683196266355d, b: 0.4248331312954924d, c: 0.8331930189917786d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9419400154436728d, b: 0.7507741128258218d, c: 0.43765648580137884d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1562892649972032d, b: 0.16796528531720456d, c: 0.47327390551682136d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6180932258928592d, b: 0.8066672382965203d, c: 0.11929242724727407d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4718816085470836d, b: 0.07835090887089036d, c: 0.23428656740706078d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8683602546355597d, b: 0.048537742703667064d, c: 0.4412606534467691d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4875546965678864d, b: 0.002553148378441117d, c: 0.6929118245157293d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.26986216386232886d, b: 0.8487641576310675d, c: 0.9278637854825554d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6919429864855738d, b: 0.18146406308734797d, c: 0.9210519129730973d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.584771503825712d, b: 0.0988672021028224d, c: 0.9288844750387768d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23483635838968853d, b: 0.2650959200825954d, c: 0.6848504832150133d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4819991230437699d, b: 0.4338347751391737d, c: 0.9035962402903999d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20207039809641092d, b: 0.9453524415466067d, c: 0.5057595900017956d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6050294445719062d, b: 0.5655311623089193d, c: 0.41335477997627923d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1606052356084564d, b: 0.9636074840623211d, c: 0.5088867561355647d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2833974270237739d, b: 0.30852383872766953d, c: 0.029264696710481264d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.880114194901329d, b: 0.8840278206651881d, c: 0.08176619781856986d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9516200854742356d, b: 0.8105691225738704d, c: 0.2918818159663835d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6840327292181976d, b: 0.8826367237759454d, c: 0.3031185663433381d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1798463875864057d, b: 0.8995778952080757d, c: 0.715300113440156d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8313669596223622d, b: 0.5365571103263543d, c: 0.6669757631424165d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6725908854650045d, b: 0.4497383003640615d, c: 0.4491242716227043d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.40338404379985937d, b: 0.031702446528004025d, c: 0.16401398954940571d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.542929045641513d, b: 0.4503482031972784d, c: 0.6702188956510482d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.514541317960834d, b: 0.7128322173429273d, c: 0.12267324359324272d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0821302329175555d, b: 0.2510286731944069d, c: 0.7720404656751799d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.17972742694815247d, b: 0.17189185514342398d, c: 0.4564260682021901d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.18445960446652077d, b: 0.02041297349915605d, c: 0.8099386061117386d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4128382548097882d, b: 0.2060615326570303d, c: 0.8169915546492532d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8691108778475002d, b: 0.23172330485304682d, c: 0.9699083063584722d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8111934823423307d, b: 0.2520938742802804d, c: 0.19944829289195853d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19684921422546076d, b: 0.12811646494628248d, c: 0.8440763224930709d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.44521964977899775d, b: 0.7897128468343839d, c: 0.15712061167177027d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5825712099625624d, b: 0.5081918875386865d, c: 0.4590892541086872d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1083402232901669d, b: 0.11896040442188027d, c: 0.4307988578900587d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3629027263682276d, b: 0.9630699727914276d, c: 0.7717357847748811d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7447735848461261d, b: 0.005039737536500555d, c: 0.8503052290167207d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7943438173225903d, b: 0.5028787604420228d, c: 0.5185607641397801d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13281625066419356d, b: 0.4312341251929315d, c: 0.05913655635289006d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9960262753705909d, b: 0.7052307602926423d, c: 0.14915388129377039d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5916385418743899d, b: 0.16661124259915583d, c: 0.3007212801852469d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5483392078051252d, b: 0.2349683039535596d, c: 0.7046885217693121d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.46077108983355664d, b: 0.9426261524703305d, c: 0.9983025184270918d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7687812906367962d, b: 0.6929056076161926d, c: 0.4124336484011045d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3054558319194238d, b: 0.513628384808109d, c: 0.7117264000956957d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7033587331399344d, b: 0.23066148340408388d, c: 0.7255591642401757d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5400691126397129d, b: 0.5197362030219304d, c: 0.9183940428984678d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8936659510512797d, b: 0.8734449912940334d, c: 0.2150004504491182d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6063042433636562d, b: 0.9845003711015476d, c: 0.5776809180561076d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8685717834449517d, b: 0.0698586588269321d, c: 0.919060107559802d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12191540045236193d, b: 0.13273126965552762d, c: 0.7177004905261369d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7042245689131317d, b: 0.30973091249185447d, c: 0.6211337487747591d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4187071628434622d, b: 0.8175560708425883d, c: 0.690386419582182d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8148756540445659d, b: 0.976345523402207d, c: 0.10436456193921362d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.43389231460332844d, b: 0.989229067746431d, c: 0.9635362530793941d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6562152419642112d, b: 0.9973036310327847d, c: 0.7458796462574996d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23325578257665736d, b: 0.07440852364271067d, c: 0.07087249042546895d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4752683075294062d, b: 0.9899040051002816d, c: 0.7698382407402734d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9116268791339608d, b: 0.02285831682056849d, c: 0.5300152026897518d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7229978192127738d, b: 0.37042547081713095d, c: 0.9094764493875087d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1556773063359973d, b: 0.2101678417160351d, c: 0.055360946262861366d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19911968472099828d, b: 0.30306660487268156d, c: 0.33768411457355574d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8397555075062462d, b: 0.46681182507767094d, c: 0.44981419458397454d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.731250085008644d, b: 0.7632028460460129d, c: 0.8597300197656993d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.46243994993103d, b: 0.2075416207730496d, c: 0.3411494999014608d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8046289236469442d, b: 0.6929270619279582d, c: 0.23805799525057814d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.21223985934644363d, b: 0.3114541595036959d, c: 0.04798921034747783d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4674870887548205d, b: 0.25718945345733746d, c: 0.8209517992829782d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5653539972241692d, b: 0.886339500498332d, c: 0.5789376016487178d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7698279889569132d, b: 0.726464354816057d, c: 0.2433468464625702d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7012163078396644d, b: 0.31915159324044917d, c: 0.7048456533062877d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.04020906545779335d, b: 0.039089196449451635d, c: 0.5006839859736644d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6867905022829779d, b: 0.0602220883095419d, c: 0.4670073298166545d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.40758337786212084d, b: 0.9784825347418163d, c: 0.48318087221675d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9308027449958416d, b: 0.5577520826381469d, c: 0.6141166040474124d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7292629975660031d, b: 0.8811215988692312d, c: 0.1258290678345919d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2618981683520629d, b: 0.16578248208715474d, c: 0.9451704269994253d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.64669462700936d, b: 0.39339138972676035d, c: 0.23354846207843016d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.369158479222674d, b: 0.26737870121934737d, c: 0.2693659472625286d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7974085767461631d, b: 0.7672180622077803d, c: 0.3206216627505817d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4661608036392306d, b: 0.6353798794865597d, c: 0.5957153597308121d))));//Value

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
FROM public.binary_npgsqllinelinee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineE0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineSingleTypeline)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinee0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineSingleTypeline)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineSingleTypeline)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinee0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineSingleTypeline)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineSingleTypeline)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinee0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineSingleTypeline)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineSingleTypeline)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinee0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineSingleTypeline)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinee0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineE0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineSingleTypeline)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineSingleTypeline)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineSingleTypeline)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineSingleTypeline)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinee0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineSingleTypeline)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineSingleTypeline)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineSingleTypeline)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineSingleTypeline)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinee0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinee0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineE0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
FROM public.binary_npgsqllinelinee0m m
LEFT JOIN public.binary_npgsqllinelinee0mi mi ON mi.id = m.npgsqllinelinee0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineSingleTypeline)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineSingleTypeline)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineSingleTypeline)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineSingleTypeline)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinee0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinee0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
                var models =  ((INpgsqlLineSingleTypeline)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA), typeof(NpgsqlLinelineE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
                var models1 = new List<NpgsqlLinelineE0MIWA>();
                var models2 = new List<NpgsqlLinelineE0MIWA>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineE0MIWA>();
                var models2 = new List<NpgsqlLinelineE0MIWA>();
                ((INpgsqlLineSingleTypeline)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
                var models = await ((INpgsqlLineSingleTypeline)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinee0mi
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
                    NpgsqlLinelineE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineSingleTypeline)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinee0mi
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
                    NpgsqlLinelineE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA), typeof(NpgsqlLinelineE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
                var models1 = new List<NpgsqlLinelineE0MIWA>();
                var models2 = new List<NpgsqlLinelineE0MIWA>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineE0MIWA>();
                var models2 = new List<NpgsqlLinelineE0MIWA>();
                ((INpgsqlLineSingleTypeline)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
                var models = await ((INpgsqlLineSingleTypeline)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinee0mi
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
                    NpgsqlLinelineE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineSingleTypeline)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinee0mi
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
                    NpgsqlLinelineE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinee0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MI), typeof(NpgsqlLinelineE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
                var models1 = new List<NpgsqlLinelineE0MI>();
                var models2 = new List<NpgsqlLinelineE0MI>();
                await ((INpgsqlLineSingleTypeline)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineE0MI>();
                var models2 = new List<NpgsqlLinelineE0MI>();
                ((INpgsqlLineSingleTypeline)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinee0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
                var models = await ((INpgsqlLineSingleTypeline)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineSingleTypeline)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinee0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA), typeof(NpgsqlLinelineE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
                var models1 = new List<NpgsqlLinelineE0MIWA>();
                var models2 = new List<NpgsqlLinelineE0MIWA>();
                await ((INpgsqlLineSingleTypeline)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineE0MIWA>();
                var models2 = new List<NpgsqlLinelineE0MIWA>();
                ((INpgsqlLineSingleTypeline)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinee0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
                var models = await ((INpgsqlLineSingleTypeline)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineSingleTypeline)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

