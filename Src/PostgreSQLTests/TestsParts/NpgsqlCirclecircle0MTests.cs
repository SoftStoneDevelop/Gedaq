

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
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9963085644690229d, y: 0.47985683780847566d), radius: 0.6909202568396844d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6251494246659817d, y: 0.037354558376086144d), radius: 0.7106578017523569d),
},
            new NpgsqlCirclecircle0M
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9673501122959267d, y: 0.5845013934843662d), radius: 0.9512086052259334d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 1,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7422508387528285d, y: 0.3797482664661984d), radius: 0.013193370600182441d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7491711716634184d, y: 0.5111765745881717d), radius: 0.9556926960544325d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28899620636088574d, y: 0.7648019562706435d), radius: 0.027005304271093933d),
},
            new NpgsqlCirclecircle0M
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23987468739641737d, y: 0.8714979100012296d), radius: 0.28045363609261253d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5714461765093486d, y: 0.24243749109986756d), radius: 0.7972287493492128d),
},
            new NpgsqlCirclecircle0M
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47261096861495966d, y: 0.0305568638589776d), radius: 0.08315024469274823d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9979630193007124d, y: 0.2704471948964269d), radius: 0.2758054161988097d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.032797600962339524d, y: 0.3313843848691791d), radius: 0.8999130621932402d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.53204603121523d, y: 0.44569594027765025d), radius: 0.13657670005362343d),
},
            new NpgsqlCirclecircle0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10575118142566853d, y: 0.313423842654444d), radius: 0.11525544388906228d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8307407952174699d, y: 0.3722421459037326d), radius: 0.3697113407860484d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04491502805903724d, y: 0.4107400757670602d), radius: 0.3765263911531106d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16240018959407498d, y: 0.7332188895211772d), radius: 0.1122497821471431d),
},
            new NpgsqlCirclecircle0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.036903750208797104d, y: 0.3664347671038122d), radius: 0.12159331037796539d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03794513149689471d, y: 0.6670081870180495d), radius: 0.9805542585176537d),
},
            new NpgsqlCirclecircle0M
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14171032029490616d, y: 0.794631518359908d), radius: 0.8563626183930363d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9940086189718621d, y: 0.5282657130254623d), radius: 0.5251736951459657d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.041462789168516534d, y: 0.2390939628498694d), radius: 0.08901822484520228d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4260398400725042d, y: 0.23127134157850504d), radius: 0.5845010622799346d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8447128794400145d, y: 0.5812854632057306d), radius: 0.30502326622623066d),
},
            new NpgsqlCirclecircle0M
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8988286144809888d, y: 0.35192078555610473d), radius: 0.2222421328677826d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8058688621756788d, y: 0.6577096287150265d), radius: 0.5902325190726148d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4575115849372815d, y: 0.15452138932461512d), radius: 0.037909105277599386d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6455252682747163d, y: 0.7729110342139185d), radius: 0.39632416685711613d),
},
            new NpgsqlCirclecircle0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.030557475547015045d, y: 0.25037679441091254d), radius: 0.5043944953557808d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09180073146649514d, y: 0.32748919386593034d), radius: 0.26152899496171655d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7043952776647863d, y: 0.020478898312873084d), radius: 0.07363803171564554d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04422548514566993d, y: 0.6764590614721777d), radius: 0.15757169450245023d),
},
            new NpgsqlCirclecircle0M
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6520128226821482d, y: 0.1420193480576497d), radius: 0.6626195041584331d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.010470689562852797d, y: 0.5564605337191625d), radius: 0.044228482201197905d),
},
            new NpgsqlCirclecircle0M
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46851743332013773d, y: 0.6563775150242865d), radius: 0.968516229284569d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6972749416011078d, y: 0.46067091030014073d), radius: 0.18086043536479224d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5392489835274293d, y: 0.8382459902483862d), radius: 0.3118589234089859d),
},
            new NpgsqlCirclecircle0M
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6661124646472999d, y: 0.7266829345411251d), radius: 0.26000109504208857d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1471833284824713d, y: 0.8843938078309592d), radius: 0.2018116424448828d),
},
            new NpgsqlCirclecircle0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7473979337239733d, y: 0.1690649987935402d), radius: 0.49365300176978755d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38232234203380977d, y: 0.9366560786420333d), radius: 0.1449530390195597d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40691012528568493d, y: 0.3973461306465397d), radius: 0.46626501131726605d),
},
            new NpgsqlCirclecircle0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6277331326981855d, y: 0.10827015964170594d), radius: 0.2132351751888737d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1499317252195611d, y: 0.39756529209618896d), radius: 0.30897201460124946d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5167178232393315d, y: 0.5051420305961349d), radius: 0.044416175573085415d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5427426768139857d, y: 0.7956320562929904d), radius: 0.2719161003892727d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9723997038795272d, y: 0.31485417044269726d), radius: 0.714032896970363d),
},
            new NpgsqlCirclecircle0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47933485635819373d, y: 0.8036882545933905d), radius: 0.5485221115940747d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6786399224632989d, y: 0.19240319673801565d), radius: 0.9457993472383266d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32883286362370245d, y: 0.2063655316492956d), radius: 0.7994518710744394d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9840847485208447d, y: 0.9276246844832066d), radius: 0.8629521136324854d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7505875428913221d, y: 0.14729889521865536d), radius: 0.4423941579050288d),
},
            new NpgsqlCirclecircle0M
{
    Id = 111,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8989767175581271d, y: 0.5945708155946572d), radius: 0.9835165913017342d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5731250974287687d, y: 0.0908481997827928d), radius: 0.6319910694145686d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39526526533901907d, y: 0.32861446268511374d), radius: 0.10684308639941731d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9930371997477981d, y: 0.40655871662880316d), radius: 0.1591190453878143d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 126,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23678865306711339d, y: 0.8646624779670838d), radius: 0.6282491891388114d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0232692948183153d, y: 0.29977237971183457d), radius: 0.8604182585193209d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 127,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28806885233571955d, y: 0.07098864584969122d), radius: 0.6830458830418767d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19778655592651717d, y: 0.6422783226030835d), radius: 0.7777452325099768d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35979746926663925d, y: 0.30421264925099556d), radius: 0.8145548597833973d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5691511321879633d, y: 0.6310140479944494d), radius: 0.6761301658366319d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8603699094481609d, y: 0.5011298925447486d), radius: 0.8075917898420074d),
},
            new NpgsqlCirclecircle0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.794266690710792d, y: 0.7724563415580777d), radius: 0.885334786082512d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9866317156193392d, y: 0.9560066838579987d), radius: 0.48678710540965475d),
},
            new NpgsqlCirclecircle0M
{
    Id = 145,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2527749345085393d, y: 0.20547119603556696d), radius: 0.3421156041806064d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08712418939971511d, y: 0.32796557233315093d), radius: 0.49321342928224066d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 152,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45472907563308207d, y: 0.5563650867449582d), radius: 0.6188029117451838d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 155,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4177134753718713d, y: 0.5629972390772131d), radius: 0.4729068745991779d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9662523424824074d, y: 0.6418176027493964d), radius: 0.24088527898136558d),
    NullableValue = null,
},
    NullableValue = null,
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16240018959407498d, y: 0.7332188895211772d), radius: 0.1122497821471431d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03794513149689471d, y: 0.6670081870180495d), radius: 0.9805542585176537d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8447128794400145d, y: 0.5812854632057306d), radius: 0.30502326622623066d)));
                nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6455252682747163d, y: 0.7729110342139185d), radius: 0.39632416685711613d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04422548514566993d, y: 0.6764590614721777d), radius: 0.15757169450245023d)));
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
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
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
FROM public.npgsqlcirclecircle0m m
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
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
FROM public.npgsqlcirclecircle0m m
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModel(connection,  query, 0);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
FROM public.npgsqlcirclecircle0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[29], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
FROM public.npgsqlcirclecircle0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
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
FROM public.npgsqlcirclecircle0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 108;
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
FROM public.npgsqlcirclecircle0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[20],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[6], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[7], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[4], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[5], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[6], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[7], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[24],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 133, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 7, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[29], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 126, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatch(connection, 19, query1, 25, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[24],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 35, query1, 67, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 103, query1, 50, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[20],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatch(connection, 111, query1, 102, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatch(connection, 67, query1, 103, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatchAsync(connection, 145, 102))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatch(connection, 126, 145))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[29], false);
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
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 133);
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
NpgsqlCirclecircle0M.AssertModel(models[0],_testData[26], false);NpgsqlCirclecircle0M.AssertModel(models[1],_testData[27], false);NpgsqlCirclecircle0M.AssertModel(models[2],_testData[28], false);NpgsqlCirclecircle0M.AssertModel(models[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 117);
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
NpgsqlCirclecircle0M.AssertModel(models[0],_testData[23], false);NpgsqlCirclecircle0M.AssertModel(models[1],_testData[24], false);NpgsqlCirclecircle0M.AssertModel(models[2],_testData[25], false);NpgsqlCirclecircle0M.AssertModel(models[3],_testData[26], false);NpgsqlCirclecircle0M.AssertModel(models[4],_testData[27], false);NpgsqlCirclecircle0M.AssertModel(models[5],_testData[28], false);NpgsqlCirclecircle0M.AssertModel(models[6],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9963085644690229d, y: 0.47985683780847566d), radius: 0.6909202568396844d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6251494246659817d, y: 0.037354558376086144d), radius: 0.7106578017523569d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9673501122959267d, y: 0.5845013934843662d), radius: 0.9512086052259334d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7422508387528285d, y: 0.3797482664661984d), radius: 0.013193370600182441d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7491711716634184d, y: 0.5111765745881717d), radius: 0.9556926960544325d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28899620636088574d, y: 0.7648019562706435d), radius: 0.027005304271093933d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23987468739641737d, y: 0.8714979100012296d), radius: 0.28045363609261253d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5714461765093486d, y: 0.24243749109986756d), radius: 0.7972287493492128d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47261096861495966d, y: 0.0305568638589776d), radius: 0.08315024469274823d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9979630193007124d, y: 0.2704471948964269d), radius: 0.2758054161988097d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.032797600962339524d, y: 0.3313843848691791d), radius: 0.8999130621932402d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.53204603121523d, y: 0.44569594027765025d), radius: 0.13657670005362343d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10575118142566853d, y: 0.313423842654444d), radius: 0.11525544388906228d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8307407952174699d, y: 0.3722421459037326d), radius: 0.3697113407860484d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04491502805903724d, y: 0.4107400757670602d), radius: 0.3765263911531106d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16240018959407498d, y: 0.7332188895211772d), radius: 0.1122497821471431d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.036903750208797104d, y: 0.3664347671038122d), radius: 0.12159331037796539d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03794513149689471d, y: 0.6670081870180495d), radius: 0.9805542585176537d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14171032029490616d, y: 0.794631518359908d), radius: 0.8563626183930363d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9940086189718621d, y: 0.5282657130254623d), radius: 0.5251736951459657d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.041462789168516534d, y: 0.2390939628498694d), radius: 0.08901822484520228d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4260398400725042d, y: 0.23127134157850504d), radius: 0.5845010622799346d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8447128794400145d, y: 0.5812854632057306d), radius: 0.30502326622623066d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8988286144809888d, y: 0.35192078555610473d), radius: 0.2222421328677826d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8058688621756788d, y: 0.6577096287150265d), radius: 0.5902325190726148d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4575115849372815d, y: 0.15452138932461512d), radius: 0.037909105277599386d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6455252682747163d, y: 0.7729110342139185d), radius: 0.39632416685711613d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.030557475547015045d, y: 0.25037679441091254d), radius: 0.5043944953557808d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09180073146649514d, y: 0.32748919386593034d), radius: 0.26152899496171655d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7043952776647863d, y: 0.020478898312873084d), radius: 0.07363803171564554d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04422548514566993d, y: 0.6764590614721777d), radius: 0.15757169450245023d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6520128226821482d, y: 0.1420193480576497d), radius: 0.6626195041584331d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.010470689562852797d, y: 0.5564605337191625d), radius: 0.044228482201197905d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46851743332013773d, y: 0.6563775150242865d), radius: 0.968516229284569d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6972749416011078d, y: 0.46067091030014073d), radius: 0.18086043536479224d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5392489835274293d, y: 0.8382459902483862d), radius: 0.3118589234089859d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6661124646472999d, y: 0.7266829345411251d), radius: 0.26000109504208857d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1471833284824713d, y: 0.8843938078309592d), radius: 0.2018116424448828d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7473979337239733d, y: 0.1690649987935402d), radius: 0.49365300176978755d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38232234203380977d, y: 0.9366560786420333d), radius: 0.1449530390195597d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40691012528568493d, y: 0.3973461306465397d), radius: 0.46626501131726605d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6277331326981855d, y: 0.10827015964170594d), radius: 0.2132351751888737d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1499317252195611d, y: 0.39756529209618896d), radius: 0.30897201460124946d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5167178232393315d, y: 0.5051420305961349d), radius: 0.044416175573085415d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5427426768139857d, y: 0.7956320562929904d), radius: 0.2719161003892727d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9723997038795272d, y: 0.31485417044269726d), radius: 0.714032896970363d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47933485635819373d, y: 0.8036882545933905d), radius: 0.5485221115940747d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6786399224632989d, y: 0.19240319673801565d), radius: 0.9457993472383266d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32883286362370245d, y: 0.2063655316492956d), radius: 0.7994518710744394d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9840847485208447d, y: 0.9276246844832066d), radius: 0.8629521136324854d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7505875428913221d, y: 0.14729889521865536d), radius: 0.4423941579050288d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8989767175581271d, y: 0.5945708155946572d), radius: 0.9835165913017342d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5731250974287687d, y: 0.0908481997827928d), radius: 0.6319910694145686d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39526526533901907d, y: 0.32861446268511374d), radius: 0.10684308639941731d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9930371997477981d, y: 0.40655871662880316d), radius: 0.1591190453878143d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23678865306711339d, y: 0.8646624779670838d), radius: 0.6282491891388114d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0232692948183153d, y: 0.29977237971183457d), radius: 0.8604182585193209d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28806885233571955d, y: 0.07098864584969122d), radius: 0.6830458830418767d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19778655592651717d, y: 0.6422783226030835d), radius: 0.7777452325099768d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35979746926663925d, y: 0.30421264925099556d), radius: 0.8145548597833973d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5691511321879633d, y: 0.6310140479944494d), radius: 0.6761301658366319d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8603699094481609d, y: 0.5011298925447486d), radius: 0.8075917898420074d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.794266690710792d, y: 0.7724563415580777d), radius: 0.885334786082512d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9866317156193392d, y: 0.9560066838579987d), radius: 0.48678710540965475d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2527749345085393d, y: 0.20547119603556696d), radius: 0.3421156041806064d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08712418939971511d, y: 0.32796557233315093d), radius: 0.49321342928224066d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45472907563308207d, y: 0.5563650867449582d), radius: 0.6188029117451838d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4177134753718713d, y: 0.5629972390772131d), radius: 0.4729068745991779d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9662523424824074d, y: 0.6418176027493964d), radius: 0.24088527898136558d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9963085644690229d, y: 0.47985683780847566d), radius: 0.6909202568396844d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6251494246659817d, y: 0.037354558376086144d), radius: 0.7106578017523569d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9673501122959267d, y: 0.5845013934843662d), radius: 0.9512086052259334d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7422508387528285d, y: 0.3797482664661984d), radius: 0.013193370600182441d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7491711716634184d, y: 0.5111765745881717d), radius: 0.9556926960544325d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28899620636088574d, y: 0.7648019562706435d), radius: 0.027005304271093933d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23987468739641737d, y: 0.8714979100012296d), radius: 0.28045363609261253d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5714461765093486d, y: 0.24243749109986756d), radius: 0.7972287493492128d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47261096861495966d, y: 0.0305568638589776d), radius: 0.08315024469274823d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9979630193007124d, y: 0.2704471948964269d), radius: 0.2758054161988097d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.032797600962339524d, y: 0.3313843848691791d), radius: 0.8999130621932402d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.53204603121523d, y: 0.44569594027765025d), radius: 0.13657670005362343d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10575118142566853d, y: 0.313423842654444d), radius: 0.11525544388906228d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8307407952174699d, y: 0.3722421459037326d), radius: 0.3697113407860484d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04491502805903724d, y: 0.4107400757670602d), radius: 0.3765263911531106d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16240018959407498d, y: 0.7332188895211772d), radius: 0.1122497821471431d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.036903750208797104d, y: 0.3664347671038122d), radius: 0.12159331037796539d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03794513149689471d, y: 0.6670081870180495d), radius: 0.9805542585176537d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14171032029490616d, y: 0.794631518359908d), radius: 0.8563626183930363d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9940086189718621d, y: 0.5282657130254623d), radius: 0.5251736951459657d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.041462789168516534d, y: 0.2390939628498694d), radius: 0.08901822484520228d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4260398400725042d, y: 0.23127134157850504d), radius: 0.5845010622799346d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8447128794400145d, y: 0.5812854632057306d), radius: 0.30502326622623066d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8988286144809888d, y: 0.35192078555610473d), radius: 0.2222421328677826d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8058688621756788d, y: 0.6577096287150265d), radius: 0.5902325190726148d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4575115849372815d, y: 0.15452138932461512d), radius: 0.037909105277599386d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6455252682747163d, y: 0.7729110342139185d), radius: 0.39632416685711613d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.030557475547015045d, y: 0.25037679441091254d), radius: 0.5043944953557808d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09180073146649514d, y: 0.32748919386593034d), radius: 0.26152899496171655d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7043952776647863d, y: 0.020478898312873084d), radius: 0.07363803171564554d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04422548514566993d, y: 0.6764590614721777d), radius: 0.15757169450245023d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6520128226821482d, y: 0.1420193480576497d), radius: 0.6626195041584331d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.010470689562852797d, y: 0.5564605337191625d), radius: 0.044228482201197905d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46851743332013773d, y: 0.6563775150242865d), radius: 0.968516229284569d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6972749416011078d, y: 0.46067091030014073d), radius: 0.18086043536479224d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5392489835274293d, y: 0.8382459902483862d), radius: 0.3118589234089859d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6661124646472999d, y: 0.7266829345411251d), radius: 0.26000109504208857d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1471833284824713d, y: 0.8843938078309592d), radius: 0.2018116424448828d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7473979337239733d, y: 0.1690649987935402d), radius: 0.49365300176978755d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38232234203380977d, y: 0.9366560786420333d), radius: 0.1449530390195597d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40691012528568493d, y: 0.3973461306465397d), radius: 0.46626501131726605d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6277331326981855d, y: 0.10827015964170594d), radius: 0.2132351751888737d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1499317252195611d, y: 0.39756529209618896d), radius: 0.30897201460124946d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5167178232393315d, y: 0.5051420305961349d), radius: 0.044416175573085415d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5427426768139857d, y: 0.7956320562929904d), radius: 0.2719161003892727d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9723997038795272d, y: 0.31485417044269726d), radius: 0.714032896970363d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47933485635819373d, y: 0.8036882545933905d), radius: 0.5485221115940747d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6786399224632989d, y: 0.19240319673801565d), radius: 0.9457993472383266d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32883286362370245d, y: 0.2063655316492956d), radius: 0.7994518710744394d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9840847485208447d, y: 0.9276246844832066d), radius: 0.8629521136324854d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7505875428913221d, y: 0.14729889521865536d), radius: 0.4423941579050288d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8989767175581271d, y: 0.5945708155946572d), radius: 0.9835165913017342d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5731250974287687d, y: 0.0908481997827928d), radius: 0.6319910694145686d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39526526533901907d, y: 0.32861446268511374d), radius: 0.10684308639941731d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9930371997477981d, y: 0.40655871662880316d), radius: 0.1591190453878143d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23678865306711339d, y: 0.8646624779670838d), radius: 0.6282491891388114d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0232692948183153d, y: 0.29977237971183457d), radius: 0.8604182585193209d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28806885233571955d, y: 0.07098864584969122d), radius: 0.6830458830418767d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19778655592651717d, y: 0.6422783226030835d), radius: 0.7777452325099768d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35979746926663925d, y: 0.30421264925099556d), radius: 0.8145548597833973d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5691511321879633d, y: 0.6310140479944494d), radius: 0.6761301658366319d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8603699094481609d, y: 0.5011298925447486d), radius: 0.8075917898420074d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.794266690710792d, y: 0.7724563415580777d), radius: 0.885334786082512d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9866317156193392d, y: 0.9560066838579987d), radius: 0.48678710540965475d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2527749345085393d, y: 0.20547119603556696d), radius: 0.3421156041806064d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08712418939971511d, y: 0.32796557233315093d), radius: 0.49321342928224066d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45472907563308207d, y: 0.5563650867449582d), radius: 0.6188029117451838d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4177134753718713d, y: 0.5629972390772131d), radius: 0.4729068745991779d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9662523424824074d, y: 0.6418176027493964d), radius: 0.24088527898136558d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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

