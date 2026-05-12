

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
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4794587317114122d, b: 0.2855452784008553d, c: 0.6038113713140499d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4350851055541025d, b: 0.032777138340820855d, c: 0.7962510888952666d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3410421449204596d, b: 0.6995761948431498d, c: 0.6258100407838602d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6840042081703395d, b: 0.31680122904854746d, c: 0.04984617100375455d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7657919733494477d, b: 0.0721876604813716d, c: 0.5891706364349814d),
},
            new NpgsqlLinelineE0M
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8180605512591563d, b: 0.6472369922583098d, c: 0.8726618172620606d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.24898402533174702d, b: 0.18649260109626054d, c: 0.9773727618124115d),
},
            new NpgsqlLinelineE0M
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9660065775485794d, b: 0.7087620268939786d, c: 0.3072738038334788d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9437527092514434d, b: 0.6594915500567267d, c: 0.240968680782642d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8805944958136811d, b: 0.4906058472110212d, c: 0.503326281880705d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5222189942139618d, b: 0.7416916164105792d, c: 0.1363858946897093d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9153310344918439d, b: 0.38521307448789455d, c: 0.0007616693674060704d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.023115692792845532d, b: 0.09150242326777203d, c: 0.40200844340314645d),
},
            new NpgsqlLinelineE0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.29889411119626275d, b: 0.8502549145161551d, c: 0.1859484209189225d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.22970865985102107d, b: 0.2795456392332841d, c: 0.40654964547002426d),
},
            new NpgsqlLinelineE0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.720357798343451d, b: 0.9726000262023636d, c: 0.3932603160266639d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.29905919898805133d, b: 0.7050716939533498d, c: 0.7230837443643826d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9750381225039487d, b: 0.6273066336016195d, c: 0.4133998804309381d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4973645768909124d, b: 0.3862236360124166d, c: 0.383455510753654d),
},
            new NpgsqlLinelineE0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3214358652717213d, b: 0.28555312702396995d, c: 0.0057989692109855495d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.14497622036794955d, b: 0.4004054740728009d, c: 0.07784966175335883d),
},
            new NpgsqlLinelineE0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6238156593119701d, b: 0.5718291977577212d, c: 0.9275582544592551d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7412457948588655d, b: 0.7256193808086067d, c: 0.8110133143677468d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6850454535531433d, b: 0.06236664298348549d, c: 0.7116481743251128d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5497621599433703d, b: 0.8617133503451874d, c: 0.3900343449444499d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1880630775464086d, b: 0.9913113405574383d, c: 0.47286797300102557d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.0901323271651101d, b: 0.10943973677842d, c: 0.035774403756272055d),
},
            new NpgsqlLinelineE0M
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4304863011086921d, b: 0.6345588650965687d, c: 0.738736621637226d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7155998526181078d, b: 0.8491646773085746d, c: 0.2972140617446011d),
},
            new NpgsqlLinelineE0M
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.13960267130240078d, b: 0.1311987953765118d, c: 0.36701039268134816d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8467596386735172d, b: 0.9928675354370301d, c: 0.032779165165498614d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8013334536136476d, b: 0.8617675569198354d, c: 0.6662530729009069d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5252119730803809d, b: 0.6698251723505225d, c: 0.7338797850043719d),
},
            new NpgsqlLinelineE0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.45922551489424346d, b: 0.45083878112345943d, c: 0.6132029011558329d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2017302039038159d, b: 0.36272113829283315d, c: 0.8811282247167539d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.1633542780329469d, b: 0.3037100160254598d, c: 0.9605761153339707d),
},
            new NpgsqlLinelineE0M
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4525828978462324d, b: 0.17907136155576808d, c: 0.4358910991656648d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.580288657144783d, b: 0.37280615330169653d, c: 0.03494701363878572d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3377044656488273d, b: 0.558948076204221d, c: 0.47757608241919614d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5072037541963075d, b: 0.10672905119423237d, c: 0.3164104930890608d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.02707591555558231d, b: 0.0061451725836702d, c: 0.9719239046267201d),
},
            new NpgsqlLinelineE0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.944735365491783d, b: 0.5769516720459552d, c: 0.6956030063736341d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.12165732403569796d, b: 0.5622201575179255d, c: 0.18782968875207473d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.12135474774968913d, b: 0.07096489013623608d, c: 0.36517454427367024d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.24739435508233132d, b: 0.6371685904087251d, c: 0.3996010339388809d),
},
            new NpgsqlLinelineE0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.10692535432598704d, b: 0.21464344096954835d, c: 0.6130500115353376d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8208558239399424d, b: 0.32293705445213305d, c: 0.44730356723529885d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.12553364204515194d, b: 0.25638728011324086d, c: 0.8472963148468801d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 130,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7788957846121394d, b: 0.5560082576126825d, c: 0.9016954539450147d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9773051428833242d, b: 0.16585054802432053d, c: 0.7648464102774055d),
},
            new NpgsqlLinelineE0M
{
    Id = 134,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.37111487466455084d, b: 0.47813264439489467d, c: 0.6708720815861027d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5158582723187609d, b: 0.5390244100116779d, c: 0.06884643608124319d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7422561312400794d, b: 0.5559746406032485d, c: 0.4887146410913168d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.04123896266667004d, b: 0.5255566454188625d, c: 0.5119510226399988d),
},
            new NpgsqlLinelineE0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4198875237497708d, b: 0.3114107193669401d, c: 0.41569651951795894d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.20127931540349353d, b: 0.8759984440572424d, c: 0.7685213991537976d),
},
            new NpgsqlLinelineE0M
{
    Id = 138,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.735580585328531d, b: 0.573996037614542d, c: 0.6889456199119831d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8532058858187035d, b: 0.24508797839476149d, c: 0.15274731992454926d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 143,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6598681979355133d, b: 0.9486011218607284d, c: 0.8469497525706119d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9541492253449324d, b: 0.35986966552842314d, c: 0.08613617388181993d),
},
            new NpgsqlLinelineE0M
{
    Id = 144,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9343071896931257d, b: 0.3384476523329152d, c: 0.5989351989589794d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8082578077342888d, b: 0.04195423247628005d, c: 0.34608701784304663d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8634188586384149d, b: 0.06844162701327605d, c: 0.5258000922758884d),
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 150,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.24222420616555185d, b: 0.37842235219109377d, c: 0.9749824243601214d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 157,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.37221604004573006d, b: 0.009290726232334512d, c: 0.6891970553113201d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6659527906145399d, b: 0.29243710412261437d, c: 0.05440923582334145d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.44940289258289456d, b: 0.08423312662753679d, c: 0.18385605602383648d),
},
            new NpgsqlLinelineE0M
{
    Id = 161,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.47823006840912385d, b: 0.06439042150587326d, c: 0.7254677047066683d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6420050192194959d, b: 0.8705791884260146d, c: 0.5386281890196374d),
},
            new NpgsqlLinelineE0M
{
    Id = 167,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5547846231045385d, b: 0.3606826355328111d, c: 0.537628475324061d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9230435990492502d, b: 0.0032195044235744374d, c: 0.9539639326077983d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7291287674102622d, b: 0.49599427968912635d, c: 0.5327810423333985d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5136614905696131d, b: 0.23486233588892458d, c: 0.24147676272699437d),
},
            new NpgsqlLinelineE0M
{
    Id = 169,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.12795261354339083d, b: 0.8202195625561628d, c: 0.8413923227020906d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 178,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.797526111718622d, b: 0.0644327322408873d, c: 0.19301034518811544d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.06209740988739865d, b: 0.37564331599862266d, c: 0.7875697900035624d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6510905582810111d, b: 0.18844675613259776d, c: 0.9468605445736175d),
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 187,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7667907517907219d, b: 0.7427319499402442d, c: 0.6690136934582304d),
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.023115692792845532d, b: 0.09150242326777203d, c: 0.40200844340314645d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.22970865985102107d, b: 0.2795456392332841d, c: 0.40654964547002426d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4973645768909124d, b: 0.3862236360124166d, c: 0.383455510753654d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.14497622036794955d, b: 0.4004054740728009d, c: 0.07784966175335883d)));
                nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.0901323271651101d, b: 0.10943973677842d, c: 0.035774403756272055d)));
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[34], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 81;
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[34], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[34], false);
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
                parametr2.Value = 99;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[15],_testData[34], false);
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
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 169;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[16],_testData[34], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlLinelineE0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlLinelineE0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlLinelineE0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlLinelineE0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[19],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[20],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[21],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[22],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[23],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[13],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[14],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[15],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[16],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[17],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[7], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[8], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[9], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[10], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[11], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[12], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[13], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[14], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[15], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[16], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[17], false);
                        NpgsqlLinelineE0M.AssertModel(models[11],_testData[18], false);
                        NpgsqlLinelineE0M.AssertModel(models[12],_testData[19], false);
                        NpgsqlLinelineE0M.AssertModel(models[13],_testData[20], false);
                        NpgsqlLinelineE0M.AssertModel(models[14],_testData[21], false);
                        NpgsqlLinelineE0M.AssertModel(models[15],_testData[22], false);
                        NpgsqlLinelineE0M.AssertModel(models[16],_testData[23], false);
                        NpgsqlLinelineE0M.AssertModel(models[17],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[18],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[19],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[20],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[21],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[22],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[23],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[24],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[25],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[26],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[14],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[15],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[16],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[17],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[18],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[19],_testData[34], false);
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
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 136, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[34], false);
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
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 150, query1, 161, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[34], false);
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
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 80, query1, 2, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[33],_testData[34], false);
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
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatch(connection, 59, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[27],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 136, query1, 9, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[32],_testData[34], false);
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
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 2, query1, 144, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatch(connection, 144, query1, 33, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[28],_testData[34], false);
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
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatch(connection, 94, query1, 134, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatchAsync(connection, 33, 143))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[6], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[7], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[8], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[9], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[10], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[11], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[12], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[13], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[14], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[15], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[16], false);
                        NpgsqlLinelineE0M.AssertModel(models[11],_testData[17], false);
                        NpgsqlLinelineE0M.AssertModel(models[12],_testData[18], false);
                        NpgsqlLinelineE0M.AssertModel(models[13],_testData[19], false);
                        NpgsqlLinelineE0M.AssertModel(models[14],_testData[20], false);
                        NpgsqlLinelineE0M.AssertModel(models[15],_testData[21], false);
                        NpgsqlLinelineE0M.AssertModel(models[16],_testData[22], false);
                        NpgsqlLinelineE0M.AssertModel(models[17],_testData[23], false);
                        NpgsqlLinelineE0M.AssertModel(models[18],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[19],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[20],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[21],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[22],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[23],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[24],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[25],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[26],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[27],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatch(connection, 80, 43))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[14],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[15],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[16],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[17],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[18],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[9], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[10], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[11], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[12], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[13], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[14], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[15], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[16], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[17], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[18], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[19], false);
                        NpgsqlLinelineE0M.AssertModel(models[11],_testData[20], false);
                        NpgsqlLinelineE0M.AssertModel(models[12],_testData[21], false);
                        NpgsqlLinelineE0M.AssertModel(models[13],_testData[22], false);
                        NpgsqlLinelineE0M.AssertModel(models[14],_testData[23], false);
                        NpgsqlLinelineE0M.AssertModel(models[15],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[16],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[17],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[18],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[19],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[20],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[21],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[22],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[23],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[24],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[25],_testData[34], false);
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
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 74);
                var models = await ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                NpgsqlLinelineE0M.AssertModel(models[0],_testData[14], false);
                NpgsqlLinelineE0M.AssertModel(models[1],_testData[15], false);
                NpgsqlLinelineE0M.AssertModel(models[2],_testData[16], false);
                NpgsqlLinelineE0M.AssertModel(models[3],_testData[17], false);
                NpgsqlLinelineE0M.AssertModel(models[4],_testData[18], false);
                NpgsqlLinelineE0M.AssertModel(models[5],_testData[19], false);
                NpgsqlLinelineE0M.AssertModel(models[6],_testData[20], false);
                NpgsqlLinelineE0M.AssertModel(models[7],_testData[21], false);
                NpgsqlLinelineE0M.AssertModel(models[8],_testData[22], false);
                NpgsqlLinelineE0M.AssertModel(models[9],_testData[23], false);
                NpgsqlLinelineE0M.AssertModel(models[10],_testData[24], false);
                NpgsqlLinelineE0M.AssertModel(models[11],_testData[25], false);
                NpgsqlLinelineE0M.AssertModel(models[12],_testData[26], false);
                NpgsqlLinelineE0M.AssertModel(models[13],_testData[27], false);
                NpgsqlLinelineE0M.AssertModel(models[14],_testData[28], false);
                NpgsqlLinelineE0M.AssertModel(models[15],_testData[29], false);
                NpgsqlLinelineE0M.AssertModel(models[16],_testData[30], false);
                NpgsqlLinelineE0M.AssertModel(models[17],_testData[31], false);
                NpgsqlLinelineE0M.AssertModel(models[18],_testData[32], false);
                NpgsqlLinelineE0M.AssertModel(models[19],_testData[33], false);
                NpgsqlLinelineE0M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 169);
                var models =  ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                NpgsqlLinelineE0M.AssertModel(models[0],_testData[33], false);
                NpgsqlLinelineE0M.AssertModel(models[1],_testData[34], false);
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
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4794587317114122d, b: 0.2855452784008553d, c: 0.6038113713140499d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4350851055541025d, b: 0.032777138340820855d, c: 0.7962510888952666d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3410421449204596d, b: 0.6995761948431498d, c: 0.6258100407838602d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6840042081703395d, b: 0.31680122904854746d, c: 0.04984617100375455d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7657919733494477d, b: 0.0721876604813716d, c: 0.5891706364349814d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8180605512591563d, b: 0.6472369922583098d, c: 0.8726618172620606d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24898402533174702d, b: 0.18649260109626054d, c: 0.9773727618124115d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9660065775485794d, b: 0.7087620268939786d, c: 0.3072738038334788d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9437527092514434d, b: 0.6594915500567267d, c: 0.240968680782642d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8805944958136811d, b: 0.4906058472110212d, c: 0.503326281880705d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5222189942139618d, b: 0.7416916164105792d, c: 0.1363858946897093d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9153310344918439d, b: 0.38521307448789455d, c: 0.0007616693674060704d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.023115692792845532d, b: 0.09150242326777203d, c: 0.40200844340314645d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.29889411119626275d, b: 0.8502549145161551d, c: 0.1859484209189225d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.22970865985102107d, b: 0.2795456392332841d, c: 0.40654964547002426d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.720357798343451d, b: 0.9726000262023636d, c: 0.3932603160266639d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.29905919898805133d, b: 0.7050716939533498d, c: 0.7230837443643826d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9750381225039487d, b: 0.6273066336016195d, c: 0.4133998804309381d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4973645768909124d, b: 0.3862236360124166d, c: 0.383455510753654d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3214358652717213d, b: 0.28555312702396995d, c: 0.0057989692109855495d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.14497622036794955d, b: 0.4004054740728009d, c: 0.07784966175335883d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6238156593119701d, b: 0.5718291977577212d, c: 0.9275582544592551d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7412457948588655d, b: 0.7256193808086067d, c: 0.8110133143677468d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6850454535531433d, b: 0.06236664298348549d, c: 0.7116481743251128d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5497621599433703d, b: 0.8617133503451874d, c: 0.3900343449444499d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1880630775464086d, b: 0.9913113405574383d, c: 0.47286797300102557d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0901323271651101d, b: 0.10943973677842d, c: 0.035774403756272055d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4304863011086921d, b: 0.6345588650965687d, c: 0.738736621637226d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7155998526181078d, b: 0.8491646773085746d, c: 0.2972140617446011d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13960267130240078d, b: 0.1311987953765118d, c: 0.36701039268134816d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8467596386735172d, b: 0.9928675354370301d, c: 0.032779165165498614d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8013334536136476d, b: 0.8617675569198354d, c: 0.6662530729009069d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5252119730803809d, b: 0.6698251723505225d, c: 0.7338797850043719d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.45922551489424346d, b: 0.45083878112345943d, c: 0.6132029011558329d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2017302039038159d, b: 0.36272113829283315d, c: 0.8811282247167539d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1633542780329469d, b: 0.3037100160254598d, c: 0.9605761153339707d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4525828978462324d, b: 0.17907136155576808d, c: 0.4358910991656648d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.580288657144783d, b: 0.37280615330169653d, c: 0.03494701363878572d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3377044656488273d, b: 0.558948076204221d, c: 0.47757608241919614d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5072037541963075d, b: 0.10672905119423237d, c: 0.3164104930890608d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.02707591555558231d, b: 0.0061451725836702d, c: 0.9719239046267201d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.944735365491783d, b: 0.5769516720459552d, c: 0.6956030063736341d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12165732403569796d, b: 0.5622201575179255d, c: 0.18782968875207473d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12135474774968913d, b: 0.07096489013623608d, c: 0.36517454427367024d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24739435508233132d, b: 0.6371685904087251d, c: 0.3996010339388809d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10692535432598704d, b: 0.21464344096954835d, c: 0.6130500115353376d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8208558239399424d, b: 0.32293705445213305d, c: 0.44730356723529885d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12553364204515194d, b: 0.25638728011324086d, c: 0.8472963148468801d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7788957846121394d, b: 0.5560082576126825d, c: 0.9016954539450147d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9773051428833242d, b: 0.16585054802432053d, c: 0.7648464102774055d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.37111487466455084d, b: 0.47813264439489467d, c: 0.6708720815861027d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5158582723187609d, b: 0.5390244100116779d, c: 0.06884643608124319d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7422561312400794d, b: 0.5559746406032485d, c: 0.4887146410913168d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.04123896266667004d, b: 0.5255566454188625d, c: 0.5119510226399988d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4198875237497708d, b: 0.3114107193669401d, c: 0.41569651951795894d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20127931540349353d, b: 0.8759984440572424d, c: 0.7685213991537976d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.735580585328531d, b: 0.573996037614542d, c: 0.6889456199119831d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8532058858187035d, b: 0.24508797839476149d, c: 0.15274731992454926d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6598681979355133d, b: 0.9486011218607284d, c: 0.8469497525706119d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9541492253449324d, b: 0.35986966552842314d, c: 0.08613617388181993d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9343071896931257d, b: 0.3384476523329152d, c: 0.5989351989589794d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8082578077342888d, b: 0.04195423247628005d, c: 0.34608701784304663d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8634188586384149d, b: 0.06844162701327605d, c: 0.5258000922758884d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24222420616555185d, b: 0.37842235219109377d, c: 0.9749824243601214d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.37221604004573006d, b: 0.009290726232334512d, c: 0.6891970553113201d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6659527906145399d, b: 0.29243710412261437d, c: 0.05440923582334145d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.44940289258289456d, b: 0.08423312662753679d, c: 0.18385605602383648d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.47823006840912385d, b: 0.06439042150587326d, c: 0.7254677047066683d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6420050192194959d, b: 0.8705791884260146d, c: 0.5386281890196374d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5547846231045385d, b: 0.3606826355328111d, c: 0.537628475324061d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9230435990492502d, b: 0.0032195044235744374d, c: 0.9539639326077983d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7291287674102622d, b: 0.49599427968912635d, c: 0.5327810423333985d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5136614905696131d, b: 0.23486233588892458d, c: 0.24147676272699437d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12795261354339083d, b: 0.8202195625561628d, c: 0.8413923227020906d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.797526111718622d, b: 0.0644327322408873d, c: 0.19301034518811544d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.06209740988739865d, b: 0.37564331599862266d, c: 0.7875697900035624d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6510905582810111d, b: 0.18844675613259776d, c: 0.9468605445736175d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7667907517907219d, b: 0.7427319499402442d, c: 0.6690136934582304d))));//Value

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
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4794587317114122d, b: 0.2855452784008553d, c: 0.6038113713140499d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4350851055541025d, b: 0.032777138340820855d, c: 0.7962510888952666d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3410421449204596d, b: 0.6995761948431498d, c: 0.6258100407838602d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6840042081703395d, b: 0.31680122904854746d, c: 0.04984617100375455d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7657919733494477d, b: 0.0721876604813716d, c: 0.5891706364349814d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8180605512591563d, b: 0.6472369922583098d, c: 0.8726618172620606d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24898402533174702d, b: 0.18649260109626054d, c: 0.9773727618124115d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9660065775485794d, b: 0.7087620268939786d, c: 0.3072738038334788d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9437527092514434d, b: 0.6594915500567267d, c: 0.240968680782642d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8805944958136811d, b: 0.4906058472110212d, c: 0.503326281880705d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5222189942139618d, b: 0.7416916164105792d, c: 0.1363858946897093d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9153310344918439d, b: 0.38521307448789455d, c: 0.0007616693674060704d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.023115692792845532d, b: 0.09150242326777203d, c: 0.40200844340314645d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.29889411119626275d, b: 0.8502549145161551d, c: 0.1859484209189225d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.22970865985102107d, b: 0.2795456392332841d, c: 0.40654964547002426d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.720357798343451d, b: 0.9726000262023636d, c: 0.3932603160266639d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.29905919898805133d, b: 0.7050716939533498d, c: 0.7230837443643826d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9750381225039487d, b: 0.6273066336016195d, c: 0.4133998804309381d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4973645768909124d, b: 0.3862236360124166d, c: 0.383455510753654d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3214358652717213d, b: 0.28555312702396995d, c: 0.0057989692109855495d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.14497622036794955d, b: 0.4004054740728009d, c: 0.07784966175335883d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6238156593119701d, b: 0.5718291977577212d, c: 0.9275582544592551d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7412457948588655d, b: 0.7256193808086067d, c: 0.8110133143677468d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6850454535531433d, b: 0.06236664298348549d, c: 0.7116481743251128d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5497621599433703d, b: 0.8617133503451874d, c: 0.3900343449444499d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1880630775464086d, b: 0.9913113405574383d, c: 0.47286797300102557d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0901323271651101d, b: 0.10943973677842d, c: 0.035774403756272055d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4304863011086921d, b: 0.6345588650965687d, c: 0.738736621637226d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7155998526181078d, b: 0.8491646773085746d, c: 0.2972140617446011d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13960267130240078d, b: 0.1311987953765118d, c: 0.36701039268134816d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8467596386735172d, b: 0.9928675354370301d, c: 0.032779165165498614d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8013334536136476d, b: 0.8617675569198354d, c: 0.6662530729009069d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5252119730803809d, b: 0.6698251723505225d, c: 0.7338797850043719d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.45922551489424346d, b: 0.45083878112345943d, c: 0.6132029011558329d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2017302039038159d, b: 0.36272113829283315d, c: 0.8811282247167539d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1633542780329469d, b: 0.3037100160254598d, c: 0.9605761153339707d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4525828978462324d, b: 0.17907136155576808d, c: 0.4358910991656648d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.580288657144783d, b: 0.37280615330169653d, c: 0.03494701363878572d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3377044656488273d, b: 0.558948076204221d, c: 0.47757608241919614d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5072037541963075d, b: 0.10672905119423237d, c: 0.3164104930890608d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.02707591555558231d, b: 0.0061451725836702d, c: 0.9719239046267201d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.944735365491783d, b: 0.5769516720459552d, c: 0.6956030063736341d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12165732403569796d, b: 0.5622201575179255d, c: 0.18782968875207473d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12135474774968913d, b: 0.07096489013623608d, c: 0.36517454427367024d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24739435508233132d, b: 0.6371685904087251d, c: 0.3996010339388809d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10692535432598704d, b: 0.21464344096954835d, c: 0.6130500115353376d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8208558239399424d, b: 0.32293705445213305d, c: 0.44730356723529885d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12553364204515194d, b: 0.25638728011324086d, c: 0.8472963148468801d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7788957846121394d, b: 0.5560082576126825d, c: 0.9016954539450147d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9773051428833242d, b: 0.16585054802432053d, c: 0.7648464102774055d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.37111487466455084d, b: 0.47813264439489467d, c: 0.6708720815861027d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5158582723187609d, b: 0.5390244100116779d, c: 0.06884643608124319d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7422561312400794d, b: 0.5559746406032485d, c: 0.4887146410913168d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.04123896266667004d, b: 0.5255566454188625d, c: 0.5119510226399988d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4198875237497708d, b: 0.3114107193669401d, c: 0.41569651951795894d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20127931540349353d, b: 0.8759984440572424d, c: 0.7685213991537976d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.735580585328531d, b: 0.573996037614542d, c: 0.6889456199119831d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8532058858187035d, b: 0.24508797839476149d, c: 0.15274731992454926d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6598681979355133d, b: 0.9486011218607284d, c: 0.8469497525706119d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9541492253449324d, b: 0.35986966552842314d, c: 0.08613617388181993d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9343071896931257d, b: 0.3384476523329152d, c: 0.5989351989589794d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8082578077342888d, b: 0.04195423247628005d, c: 0.34608701784304663d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8634188586384149d, b: 0.06844162701327605d, c: 0.5258000922758884d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24222420616555185d, b: 0.37842235219109377d, c: 0.9749824243601214d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.37221604004573006d, b: 0.009290726232334512d, c: 0.6891970553113201d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6659527906145399d, b: 0.29243710412261437d, c: 0.05440923582334145d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.44940289258289456d, b: 0.08423312662753679d, c: 0.18385605602383648d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.47823006840912385d, b: 0.06439042150587326d, c: 0.7254677047066683d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6420050192194959d, b: 0.8705791884260146d, c: 0.5386281890196374d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5547846231045385d, b: 0.3606826355328111d, c: 0.537628475324061d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9230435990492502d, b: 0.0032195044235744374d, c: 0.9539639326077983d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7291287674102622d, b: 0.49599427968912635d, c: 0.5327810423333985d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5136614905696131d, b: 0.23486233588892458d, c: 0.24147676272699437d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12795261354339083d, b: 0.8202195625561628d, c: 0.8413923227020906d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.797526111718622d, b: 0.0644327322408873d, c: 0.19301034518811544d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.06209740988739865d, b: 0.37564331599862266d, c: 0.7875697900035624d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6510905582810111d, b: 0.18844675613259776d, c: 0.9468605445736175d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7667907517907219d, b: 0.7427319499402442d, c: 0.6690136934582304d))));//Value

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

