

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
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2845967950167503d, y: 0.288630423159454d), radius: 0.4256985384458254d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9679964913095456d, y: 0.10336271048536727d), radius: 0.3744924568874123d),
},
            new NpgsqlCirclecircle0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9141111023032594d, y: 0.2812720467724755d), radius: 0.5419788817658852d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 1,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0010012272191839422d, y: 0.15968554032650595d), radius: 0.8668559919323329d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6538803333922982d, y: 0.5428136385524449d), radius: 0.43517205467121345d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8491129518743624d, y: 0.00012987400540032112d), radius: 0.65448895887293d),
},
            new NpgsqlCirclecircle0M
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44551115744437597d, y: 0.9335365235337817d), radius: 0.17732854682325006d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16163394329541902d, y: 0.17403725665161385d), radius: 0.18749448917605394d),
},
            new NpgsqlCirclecircle0M
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4109423504477142d, y: 0.516648728098523d), radius: 0.21931526090104903d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07415968191047562d, y: 0.747266156728749d), radius: 0.6408419988259322d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1963191063953218d, y: 0.5374417427560186d), radius: 0.031138139804740006d),
},
            new NpgsqlCirclecircle0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31686749766274724d, y: 0.6197374792456034d), radius: 0.70544793716888d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7819494852647076d, y: 0.8271627785028693d), radius: 0.7067290886367428d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14781004919445495d, y: 0.9447778619993988d), radius: 0.37601621950957786d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42240076303126717d, y: 0.17276200143292797d), radius: 0.5681058142782637d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9298581711068558d, y: 0.6050837415108786d), radius: 0.1495259913115029d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7094640102281116d, y: 0.11094632116479763d), radius: 0.1062192677345083d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1078875256956513d, y: 0.18047550370926657d), radius: 0.6056725044426813d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23759371169115995d, y: 0.9692144627512982d), radius: 0.12284387216989578d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5856007651863693d, y: 0.34231564146766813d), radius: 0.2700274092138678d),
},
            new NpgsqlCirclecircle0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07508430278168321d, y: 0.39031802402083293d), radius: 0.29050262028515117d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07053217790047261d, y: 0.8724258591985755d), radius: 0.28421554513374414d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.017728528692270484d, y: 0.4084179167231604d), radius: 0.9467750644647104d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30208586114122726d, y: 0.7719062216536732d), radius: 0.03744135501923529d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1186120612431637d, y: 0.9922810975589678d), radius: 0.1383551109370682d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8326858363125169d, y: 0.7822977534042785d), radius: 0.24006697942040467d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4401036947485961d, y: 0.2260561239692226d), radius: 0.8142120761700532d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6726083747468122d, y: 0.1049213387736545d), radius: 0.34633256196956297d),
},
            new NpgsqlCirclecircle0M
{
    Id = 92,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5249550409460401d, y: 0.17688587653909404d), radius: 0.6323876876159722d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15818739797154746d, y: 0.6516703911775393d), radius: 0.9441830967177876d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8511232914706484d, y: 0.14557440181992642d), radius: 0.440331806977838d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18426473912089758d, y: 0.8660573784404184d), radius: 0.36843226497542525d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19548018044817328d, y: 0.4393121632376157d), radius: 0.9553598965563583d),
},
            new NpgsqlCirclecircle0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4517232384923522d, y: 0.728895811848261d), radius: 0.9756440907238936d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5601847013716117d, y: 0.2569755309592774d), radius: 0.025112846133785727d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4965603755458994d, y: 0.31016991155377993d), radius: 0.12479020599341606d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33584396587979615d, y: 0.7413872201395331d), radius: 0.4133331673903392d),
},
            new NpgsqlCirclecircle0M
{
    Id = 109,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13612625227261232d, y: 0.18200202850815406d), radius: 0.18090784429609374d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4371435412526834d, y: 0.5030680459145042d), radius: 0.9848384592102563d),
},
            new NpgsqlCirclecircle0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8608492320807222d, y: 0.2360152720986478d), radius: 0.49032128744558945d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44660742444756474d, y: 0.4426188115853662d), radius: 0.2125788727991299d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7669236791558094d, y: 0.4244296813677263d), radius: 0.15873038819213614d),
},
            new NpgsqlCirclecircle0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16168651085883268d, y: 0.5326779362054667d), radius: 0.764519067237691d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5295236544338534d, y: 0.564286417761227d), radius: 0.8866798860730889d),
},
            new NpgsqlCirclecircle0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05726324605544053d, y: 0.11343265123432522d), radius: 0.2128665933330387d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8000312824267799d, y: 0.7359249734671768d), radius: 0.6717955244142152d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34429434183621344d, y: 0.7471443145057478d), radius: 0.5395986781962284d),
},
            new NpgsqlCirclecircle0M
{
    Id = 134,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.658114735190466d, y: 0.8700407638547449d), radius: 0.8482997660554191d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 143,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.812103263805906d, y: 0.40225877180495306d), radius: 0.4826020656833202d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6104283516864781d, y: 0.8139702801058137d), radius: 0.9621810356701646d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4437419050053334d, y: 0.08678302550250017d), radius: 0.3775431012048316d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8585460518165373d, y: 0.46967401227739036d), radius: 0.9937911112769949d),
},
            new NpgsqlCirclecircle0M
{
    Id = 152,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.405034621035508d, y: 0.45907953623397113d), radius: 0.3729217932766876d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5971397346991444d, y: 0.18261698426283424d), radius: 0.5846889511761761d),
},
            new NpgsqlCirclecircle0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9697667361177282d, y: 0.11548298866084772d), radius: 0.3783683041359216d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15808887965898466d, y: 0.17058291697157646d), radius: 0.8905366923691456d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.537826721318867d, y: 0.9544350206066342d), radius: 0.6209816746239761d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 162,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26267957856367696d, y: 0.050791952176119315d), radius: 0.7660675155186992d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 170,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2481389901639367d, y: 0.8036405706562636d), radius: 0.7603696442436935d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2748851737845516d, y: 0.12540242509981137d), radius: 0.16025087561880513d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49277304017744084d, y: 0.8329072078665947d), radius: 0.7662126706504158d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 179,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5514234050072216d, y: 0.5860077654668084d), radius: 0.818788674135394d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07997482680337553d, y: 0.8656778129568254d), radius: 0.2516586031357735d),
},
            new NpgsqlCirclecircle0M
{
    Id = 182,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44152938080392423d, y: 0.12591796608931216d), radius: 0.11881046294612174d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7390986251190309d, y: 0.4518428226032639d), radius: 0.3877028492910424d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3240248211030259d, y: 0.5464592412373855d), radius: 0.4650913348720781d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 189,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7481614782096259d, y: 0.42284092653683103d), radius: 0.8464950154949477d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 194,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8897678944227532d, y: 0.09480924786822531d), radius: 0.8543120884278702d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7575340644007612d, y: 0.6867329778778071d), radius: 0.7700116066323149d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48564968572078737d, y: 0.9295689743592767d), radius: 0.4944159771809835d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8099215473255862d, y: 0.02593363024968287d), radius: 0.39936953273148745d),
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5856007651863693d, y: 0.34231564146766813d), radius: 0.2700274092138678d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6726083747468122d, y: 0.1049213387736545d), radius: 0.34633256196956297d)));
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 182;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 128;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[23],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 162;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[29], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 182;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[29], false);
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
                parametr1.Value = 7;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[28],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[29], false);
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
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 72, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[29], false);
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
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 162, query1, 60, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[29], false);
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
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 7, query1, 152, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[29], false);
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
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatch(connection, 15, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 15, query1, 37, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[24],_testData[29], false);
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
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 105, query1, 109, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatch(connection, 107, query1, 65, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[29], false);
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
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatch(connection, 110, query1, 110, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatchAsync(connection, 78, 87))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatch(connection, 107, 162))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[29], false);
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
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 92);
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
NpgsqlCirclecircle0M.AssertModel(models[0],_testData[13], false);NpgsqlCirclecircle0M.AssertModel(models[1],_testData[14], false);NpgsqlCirclecircle0M.AssertModel(models[2],_testData[15], false);NpgsqlCirclecircle0M.AssertModel(models[3],_testData[16], false);NpgsqlCirclecircle0M.AssertModel(models[4],_testData[17], false);NpgsqlCirclecircle0M.AssertModel(models[5],_testData[18], false);NpgsqlCirclecircle0M.AssertModel(models[6],_testData[19], false);NpgsqlCirclecircle0M.AssertModel(models[7],_testData[20], false);NpgsqlCirclecircle0M.AssertModel(models[8],_testData[21], false);NpgsqlCirclecircle0M.AssertModel(models[9],_testData[22], false);NpgsqlCirclecircle0M.AssertModel(models[10],_testData[23], false);NpgsqlCirclecircle0M.AssertModel(models[11],_testData[24], false);NpgsqlCirclecircle0M.AssertModel(models[12],_testData[25], false);NpgsqlCirclecircle0M.AssertModel(models[13],_testData[26], false);NpgsqlCirclecircle0M.AssertModel(models[14],_testData[27], false);NpgsqlCirclecircle0M.AssertModel(models[15],_testData[28], false);NpgsqlCirclecircle0M.AssertModel(models[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 65);
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
NpgsqlCirclecircle0M.AssertModel(models[0],_testData[9], false);NpgsqlCirclecircle0M.AssertModel(models[1],_testData[10], false);NpgsqlCirclecircle0M.AssertModel(models[2],_testData[11], false);NpgsqlCirclecircle0M.AssertModel(models[3],_testData[12], false);NpgsqlCirclecircle0M.AssertModel(models[4],_testData[13], false);NpgsqlCirclecircle0M.AssertModel(models[5],_testData[14], false);NpgsqlCirclecircle0M.AssertModel(models[6],_testData[15], false);NpgsqlCirclecircle0M.AssertModel(models[7],_testData[16], false);NpgsqlCirclecircle0M.AssertModel(models[8],_testData[17], false);NpgsqlCirclecircle0M.AssertModel(models[9],_testData[18], false);NpgsqlCirclecircle0M.AssertModel(models[10],_testData[19], false);NpgsqlCirclecircle0M.AssertModel(models[11],_testData[20], false);NpgsqlCirclecircle0M.AssertModel(models[12],_testData[21], false);NpgsqlCirclecircle0M.AssertModel(models[13],_testData[22], false);NpgsqlCirclecircle0M.AssertModel(models[14],_testData[23], false);NpgsqlCirclecircle0M.AssertModel(models[15],_testData[24], false);NpgsqlCirclecircle0M.AssertModel(models[16],_testData[25], false);NpgsqlCirclecircle0M.AssertModel(models[17],_testData[26], false);NpgsqlCirclecircle0M.AssertModel(models[18],_testData[27], false);NpgsqlCirclecircle0M.AssertModel(models[19],_testData[28], false);NpgsqlCirclecircle0M.AssertModel(models[20],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2845967950167503d, y: 0.288630423159454d), radius: 0.4256985384458254d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9679964913095456d, y: 0.10336271048536727d), radius: 0.3744924568874123d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9141111023032594d, y: 0.2812720467724755d), radius: 0.5419788817658852d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0010012272191839422d, y: 0.15968554032650595d), radius: 0.8668559919323329d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6538803333922982d, y: 0.5428136385524449d), radius: 0.43517205467121345d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8491129518743624d, y: 0.00012987400540032112d), radius: 0.65448895887293d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44551115744437597d, y: 0.9335365235337817d), radius: 0.17732854682325006d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16163394329541902d, y: 0.17403725665161385d), radius: 0.18749448917605394d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4109423504477142d, y: 0.516648728098523d), radius: 0.21931526090104903d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07415968191047562d, y: 0.747266156728749d), radius: 0.6408419988259322d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1963191063953218d, y: 0.5374417427560186d), radius: 0.031138139804740006d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31686749766274724d, y: 0.6197374792456034d), radius: 0.70544793716888d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7819494852647076d, y: 0.8271627785028693d), radius: 0.7067290886367428d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14781004919445495d, y: 0.9447778619993988d), radius: 0.37601621950957786d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42240076303126717d, y: 0.17276200143292797d), radius: 0.5681058142782637d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9298581711068558d, y: 0.6050837415108786d), radius: 0.1495259913115029d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7094640102281116d, y: 0.11094632116479763d), radius: 0.1062192677345083d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1078875256956513d, y: 0.18047550370926657d), radius: 0.6056725044426813d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23759371169115995d, y: 0.9692144627512982d), radius: 0.12284387216989578d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5856007651863693d, y: 0.34231564146766813d), radius: 0.2700274092138678d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07508430278168321d, y: 0.39031802402083293d), radius: 0.29050262028515117d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07053217790047261d, y: 0.8724258591985755d), radius: 0.28421554513374414d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.017728528692270484d, y: 0.4084179167231604d), radius: 0.9467750644647104d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30208586114122726d, y: 0.7719062216536732d), radius: 0.03744135501923529d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1186120612431637d, y: 0.9922810975589678d), radius: 0.1383551109370682d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8326858363125169d, y: 0.7822977534042785d), radius: 0.24006697942040467d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4401036947485961d, y: 0.2260561239692226d), radius: 0.8142120761700532d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6726083747468122d, y: 0.1049213387736545d), radius: 0.34633256196956297d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5249550409460401d, y: 0.17688587653909404d), radius: 0.6323876876159722d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15818739797154746d, y: 0.6516703911775393d), radius: 0.9441830967177876d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8511232914706484d, y: 0.14557440181992642d), radius: 0.440331806977838d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18426473912089758d, y: 0.8660573784404184d), radius: 0.36843226497542525d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19548018044817328d, y: 0.4393121632376157d), radius: 0.9553598965563583d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4517232384923522d, y: 0.728895811848261d), radius: 0.9756440907238936d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5601847013716117d, y: 0.2569755309592774d), radius: 0.025112846133785727d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4965603755458994d, y: 0.31016991155377993d), radius: 0.12479020599341606d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33584396587979615d, y: 0.7413872201395331d), radius: 0.4133331673903392d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13612625227261232d, y: 0.18200202850815406d), radius: 0.18090784429609374d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4371435412526834d, y: 0.5030680459145042d), radius: 0.9848384592102563d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8608492320807222d, y: 0.2360152720986478d), radius: 0.49032128744558945d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44660742444756474d, y: 0.4426188115853662d), radius: 0.2125788727991299d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7669236791558094d, y: 0.4244296813677263d), radius: 0.15873038819213614d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16168651085883268d, y: 0.5326779362054667d), radius: 0.764519067237691d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5295236544338534d, y: 0.564286417761227d), radius: 0.8866798860730889d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05726324605544053d, y: 0.11343265123432522d), radius: 0.2128665933330387d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8000312824267799d, y: 0.7359249734671768d), radius: 0.6717955244142152d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34429434183621344d, y: 0.7471443145057478d), radius: 0.5395986781962284d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.658114735190466d, y: 0.8700407638547449d), radius: 0.8482997660554191d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.812103263805906d, y: 0.40225877180495306d), radius: 0.4826020656833202d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6104283516864781d, y: 0.8139702801058137d), radius: 0.9621810356701646d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4437419050053334d, y: 0.08678302550250017d), radius: 0.3775431012048316d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8585460518165373d, y: 0.46967401227739036d), radius: 0.9937911112769949d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.405034621035508d, y: 0.45907953623397113d), radius: 0.3729217932766876d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5971397346991444d, y: 0.18261698426283424d), radius: 0.5846889511761761d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9697667361177282d, y: 0.11548298866084772d), radius: 0.3783683041359216d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15808887965898466d, y: 0.17058291697157646d), radius: 0.8905366923691456d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.537826721318867d, y: 0.9544350206066342d), radius: 0.6209816746239761d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26267957856367696d, y: 0.050791952176119315d), radius: 0.7660675155186992d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2481389901639367d, y: 0.8036405706562636d), radius: 0.7603696442436935d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2748851737845516d, y: 0.12540242509981137d), radius: 0.16025087561880513d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49277304017744084d, y: 0.8329072078665947d), radius: 0.7662126706504158d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5514234050072216d, y: 0.5860077654668084d), radius: 0.818788674135394d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07997482680337553d, y: 0.8656778129568254d), radius: 0.2516586031357735d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((182)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44152938080392423d, y: 0.12591796608931216d), radius: 0.11881046294612174d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7390986251190309d, y: 0.4518428226032639d), radius: 0.3877028492910424d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3240248211030259d, y: 0.5464592412373855d), radius: 0.4650913348720781d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((189)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7481614782096259d, y: 0.42284092653683103d), radius: 0.8464950154949477d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((194)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8897678944227532d, y: 0.09480924786822531d), radius: 0.8543120884278702d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7575340644007612d, y: 0.6867329778778071d), radius: 0.7700116066323149d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48564968572078737d, y: 0.9295689743592767d), radius: 0.4944159771809835d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8099215473255862d, y: 0.02593363024968287d), radius: 0.39936953273148745d))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2845967950167503d, y: 0.288630423159454d), radius: 0.4256985384458254d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9679964913095456d, y: 0.10336271048536727d), radius: 0.3744924568874123d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9141111023032594d, y: 0.2812720467724755d), radius: 0.5419788817658852d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0010012272191839422d, y: 0.15968554032650595d), radius: 0.8668559919323329d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6538803333922982d, y: 0.5428136385524449d), radius: 0.43517205467121345d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8491129518743624d, y: 0.00012987400540032112d), radius: 0.65448895887293d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44551115744437597d, y: 0.9335365235337817d), radius: 0.17732854682325006d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16163394329541902d, y: 0.17403725665161385d), radius: 0.18749448917605394d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4109423504477142d, y: 0.516648728098523d), radius: 0.21931526090104903d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07415968191047562d, y: 0.747266156728749d), radius: 0.6408419988259322d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1963191063953218d, y: 0.5374417427560186d), radius: 0.031138139804740006d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31686749766274724d, y: 0.6197374792456034d), radius: 0.70544793716888d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7819494852647076d, y: 0.8271627785028693d), radius: 0.7067290886367428d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14781004919445495d, y: 0.9447778619993988d), radius: 0.37601621950957786d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42240076303126717d, y: 0.17276200143292797d), radius: 0.5681058142782637d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9298581711068558d, y: 0.6050837415108786d), radius: 0.1495259913115029d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7094640102281116d, y: 0.11094632116479763d), radius: 0.1062192677345083d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1078875256956513d, y: 0.18047550370926657d), radius: 0.6056725044426813d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23759371169115995d, y: 0.9692144627512982d), radius: 0.12284387216989578d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5856007651863693d, y: 0.34231564146766813d), radius: 0.2700274092138678d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07508430278168321d, y: 0.39031802402083293d), radius: 0.29050262028515117d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07053217790047261d, y: 0.8724258591985755d), radius: 0.28421554513374414d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.017728528692270484d, y: 0.4084179167231604d), radius: 0.9467750644647104d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30208586114122726d, y: 0.7719062216536732d), radius: 0.03744135501923529d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1186120612431637d, y: 0.9922810975589678d), radius: 0.1383551109370682d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8326858363125169d, y: 0.7822977534042785d), radius: 0.24006697942040467d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4401036947485961d, y: 0.2260561239692226d), radius: 0.8142120761700532d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6726083747468122d, y: 0.1049213387736545d), radius: 0.34633256196956297d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5249550409460401d, y: 0.17688587653909404d), radius: 0.6323876876159722d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15818739797154746d, y: 0.6516703911775393d), radius: 0.9441830967177876d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8511232914706484d, y: 0.14557440181992642d), radius: 0.440331806977838d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18426473912089758d, y: 0.8660573784404184d), radius: 0.36843226497542525d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19548018044817328d, y: 0.4393121632376157d), radius: 0.9553598965563583d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4517232384923522d, y: 0.728895811848261d), radius: 0.9756440907238936d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5601847013716117d, y: 0.2569755309592774d), radius: 0.025112846133785727d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4965603755458994d, y: 0.31016991155377993d), radius: 0.12479020599341606d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33584396587979615d, y: 0.7413872201395331d), radius: 0.4133331673903392d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13612625227261232d, y: 0.18200202850815406d), radius: 0.18090784429609374d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4371435412526834d, y: 0.5030680459145042d), radius: 0.9848384592102563d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8608492320807222d, y: 0.2360152720986478d), radius: 0.49032128744558945d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44660742444756474d, y: 0.4426188115853662d), radius: 0.2125788727991299d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7669236791558094d, y: 0.4244296813677263d), radius: 0.15873038819213614d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16168651085883268d, y: 0.5326779362054667d), radius: 0.764519067237691d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5295236544338534d, y: 0.564286417761227d), radius: 0.8866798860730889d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05726324605544053d, y: 0.11343265123432522d), radius: 0.2128665933330387d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8000312824267799d, y: 0.7359249734671768d), radius: 0.6717955244142152d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34429434183621344d, y: 0.7471443145057478d), radius: 0.5395986781962284d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.658114735190466d, y: 0.8700407638547449d), radius: 0.8482997660554191d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.812103263805906d, y: 0.40225877180495306d), radius: 0.4826020656833202d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6104283516864781d, y: 0.8139702801058137d), radius: 0.9621810356701646d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4437419050053334d, y: 0.08678302550250017d), radius: 0.3775431012048316d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8585460518165373d, y: 0.46967401227739036d), radius: 0.9937911112769949d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.405034621035508d, y: 0.45907953623397113d), radius: 0.3729217932766876d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5971397346991444d, y: 0.18261698426283424d), radius: 0.5846889511761761d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9697667361177282d, y: 0.11548298866084772d), radius: 0.3783683041359216d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15808887965898466d, y: 0.17058291697157646d), radius: 0.8905366923691456d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.537826721318867d, y: 0.9544350206066342d), radius: 0.6209816746239761d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26267957856367696d, y: 0.050791952176119315d), radius: 0.7660675155186992d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2481389901639367d, y: 0.8036405706562636d), radius: 0.7603696442436935d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2748851737845516d, y: 0.12540242509981137d), radius: 0.16025087561880513d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49277304017744084d, y: 0.8329072078665947d), radius: 0.7662126706504158d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5514234050072216d, y: 0.5860077654668084d), radius: 0.818788674135394d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07997482680337553d, y: 0.8656778129568254d), radius: 0.2516586031357735d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((182)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44152938080392423d, y: 0.12591796608931216d), radius: 0.11881046294612174d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7390986251190309d, y: 0.4518428226032639d), radius: 0.3877028492910424d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3240248211030259d, y: 0.5464592412373855d), radius: 0.4650913348720781d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((189)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7481614782096259d, y: 0.42284092653683103d), radius: 0.8464950154949477d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((194)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8897678944227532d, y: 0.09480924786822531d), radius: 0.8543120884278702d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7575340644007612d, y: 0.6867329778778071d), radius: 0.7700116066323149d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48564968572078737d, y: 0.9295689743592767d), radius: 0.4944159771809835d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8099215473255862d, y: 0.02593363024968287d), radius: 0.39936953273148745d))));

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
            queryMapType: typeof(NpgsqlCirclecircle0MI),
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
            queryMapType: typeof(NpgsqlCirclecircle0M),
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

