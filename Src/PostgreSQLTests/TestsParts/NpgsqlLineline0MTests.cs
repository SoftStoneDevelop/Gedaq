

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

        private readonly NpgsqlLineline0M[] _testData = new NpgsqlLineline0M[]
        {
            new NpgsqlLineline0M
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2105403204109142d, b: 0.10235108109552038d, c: 0.3805146610459679d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.12251410485588377d, b: 0.10683549453874419d, c: 0.7840770274266485d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.14006253567406712d, b: 0.7017123659310112d, c: 0.7086463762968844d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.971415101503014d, b: 0.3154309759938282d, c: 0.9289761782054815d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9693896566766621d, b: 0.13254679499911415d, c: 0.08111456649921478d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.10957457779745972d, b: 0.25610123166854504d, c: 0.8315842588338915d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9344391286295275d, b: 0.2842191158445072d, c: 0.851130363746432d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8884990295526134d, b: 0.1653030956208449d, c: 0.583380596741671d),
},
            new NpgsqlLineline0M
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6844812793960109d, b: 0.20755298059309302d, c: 0.020791779532820187d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.13764952839162614d, b: 0.5111304429203495d, c: 0.043012442661464756d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9892593438323467d, b: 0.9127262954845834d, c: 0.7897485069585395d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5019536669916445d, b: 0.9125413851937579d, c: 0.3633699736203637d),
},
            new NpgsqlLineline0M
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.06525671467170802d, b: 0.7399758677283576d, c: 0.2119939390173795d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4678802975354468d, b: 0.0977015946284816d, c: 0.38051974628893703d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6501549610845371d, b: 0.563981320057529d, c: 0.5926804788080987d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9522964549741183d, b: 0.5767972643864008d, c: 0.3924790666815561d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.12281944753165641d, b: 0.2745689493150091d, c: 0.04802050244302947d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.14940167901981583d, b: 0.4590346656919272d, c: 0.6863099759495994d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7947690910742995d, b: 0.5900272189039776d, c: 0.8231593902581129d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6135350256926182d, b: 0.07138123581469635d, c: 0.15995367809722227d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.03260028124495018d, b: 0.34429186535786294d, c: 0.12163759619718562d),
},
            new NpgsqlLineline0M
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9947912227326524d, b: 0.0728596071824219d, c: 0.28326688894794916d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9731971511201855d, b: 0.13989104383614603d, c: 0.1258165529919123d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.42569242513164385d, b: 0.6006567409875234d, c: 0.2964328784279252d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.12206913592009994d, b: 0.783906327475086d, c: 0.9134935663784772d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.792697212809565d, b: 0.05550017645466776d, c: 0.4030048189471618d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5069289659226123d, b: 0.964420370283384d, c: 0.17021717334303965d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.25771309426537103d, b: 0.9786867821622974d, c: 0.22262190029806694d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.0563365984605525d, b: 0.4327977364250767d, c: 0.7782577937286999d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.27780619235827375d, b: 0.42396412778475956d, c: 0.39484770183877305d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.34331941400349253d, b: 0.9799080781728731d, c: 0.0600043564286884d),
},
            new NpgsqlLineline0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7197799943358113d, b: 0.499904240007338d, c: 0.3056556319449365d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3751083558402152d, b: 0.5392350056301003d, c: 0.013070755411726087d),
},
            new NpgsqlLineline0M
{
    Id = 92,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8730089696986281d, b: 0.9895239049450082d, c: 0.10008330525839604d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7438160756407702d, b: 0.6513274391786977d, c: 0.5222166884012538d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.36215396300573377d, b: 0.7501284448036534d, c: 0.8602539258081793d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9401389265597951d, b: 0.9359942981156235d, c: 0.8075671902125673d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.20452087226761073d, b: 0.9539271445555065d, c: 0.6485807722587486d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.247778441028646d, b: 0.47353895246772637d, c: 0.8648983954302437d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8616903134314662d, b: 0.5269725610052223d, c: 0.34334816878022156d),
},
            new NpgsqlLineline0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2515586179359043d, b: 0.39495737055079017d, c: 0.0669234843883183d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.865418993815323d, b: 0.31199983135500997d, c: 0.5221032258025285d),
},
            new NpgsqlLineline0M
{
    Id = 111,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3521967267853112d, b: 0.10336816111740776d, c: 0.44483560196837113d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6648541149597661d, b: 0.1181298727013338d, c: 0.21040301121390648d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.255082288108083d, b: 0.7740545704077333d, c: 0.2320440640769591d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.42347542095923485d, b: 0.0543470065576348d, c: 0.43582572177042167d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 126,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9805226303261367d, b: 0.9308341454829592d, c: 0.9190036299696527d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2757160535487523d, b: 0.711027040537783d, c: 0.48570726249661567d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9486081847188258d, b: 0.3181435747607012d, c: 0.09852072481934337d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9051229261664949d, b: 0.4632531927092074d, c: 0.4018509118322322d),
},
            new NpgsqlLineline0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.22992805493805524d, b: 0.7447220989717132d, c: 0.555150526398638d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.05557156077768555d, b: 0.12568066074558193d, c: 0.1675293375409561d),
},
            new NpgsqlLineline0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9798664298956704d, b: 0.5856820659883928d, c: 0.9029380177617252d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1918363535774541d, b: 0.5037273920935348d, c: 0.8874876624948291d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.613943852842952d, b: 0.45917610830371136d, c: 0.7945141787701177d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6351638194860518d, b: 0.2849564007041996d, c: 0.40619302053762696d),
},
            new NpgsqlLineline0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9256062319893547d, b: 0.6691854493803875d, c: 0.46204319327387156d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.873377299435242d, b: 0.29522280571995885d, c: 0.6801236303257692d),
},
            new NpgsqlLineline0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.44189045003548066d, b: 0.0664528109985324d, c: 0.32705091857270485d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.004273705967918873d, b: 0.9311815842138287d, c: 0.7361488511636056d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6222787515139048d, b: 0.8767473032076356d, c: 0.24767311655113722d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.12501160670839895d, b: 0.15878359620382032d, c: 0.23054447990950888d),
},
            new NpgsqlLineline0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.854454885167227d, b: 0.1539945143696514d, c: 0.9583222336558085d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2336383783088145d, b: 0.32737540109144936d, c: 0.3955850867032126d),
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0mi(
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
INSERT INTO public.npgsqllineline0mi(
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
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
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
INSERT INTO public.npgsqllineline0mi(
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

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
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
                methodParametrName: "npgsqllineline0mi_id", 
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
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
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
    npgsqllineline0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5019536669916445d, b: 0.9125413851937579d, c: 0.3633699736203637d)));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
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
    npgsqllineline0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
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
                methodParametrName: "npgsqllineline0mi_id", 
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.03260028124495018d, b: 0.34429186535786294d, c: 0.12163759619718562d)));
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
                List<NpgsqlLineline0M> models = null;

                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLineline0M> models = null;

                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqllineline0mi_id
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
                parametrName: "npgsqllineline0mi_id", 
                methodParametrName: "npgsqllineline0mi_id", 
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

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineSingleTypeline)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 136;
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[29], false);
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 111;
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
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
FROM public.npgsqllineline0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[27],_testData[29], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM public.npgsqllineline0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
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
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[29], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[22],_testData[29], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[7], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[8], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[9], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 111, query1, 136, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[29], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 136, query1, 70, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[29], false);
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 136, query1, 70, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[29], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatch(connection, 83, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 87, query1, 62, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[29], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 107, query1, 135, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[29], false);
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatch(connection, 5, query1, 52, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[29], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatch(connection, 62, query1, 83, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[29], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatchAsync(connection, 117, 43))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[8], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[9], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatch(connection, 29, 74))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[5], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[6], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[7], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[8], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[9], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[23],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[29], false);
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
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 52);
                var models = await ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
NpgsqlLineline0M.AssertModel(models[0],_testData[9], false);NpgsqlLineline0M.AssertModel(models[1],_testData[10], false);NpgsqlLineline0M.AssertModel(models[2],_testData[11], false);NpgsqlLineline0M.AssertModel(models[3],_testData[12], false);NpgsqlLineline0M.AssertModel(models[4],_testData[13], false);NpgsqlLineline0M.AssertModel(models[5],_testData[14], false);NpgsqlLineline0M.AssertModel(models[6],_testData[15], false);NpgsqlLineline0M.AssertModel(models[7],_testData[16], false);NpgsqlLineline0M.AssertModel(models[8],_testData[17], false);NpgsqlLineline0M.AssertModel(models[9],_testData[18], false);NpgsqlLineline0M.AssertModel(models[10],_testData[19], false);NpgsqlLineline0M.AssertModel(models[11],_testData[20], false);NpgsqlLineline0M.AssertModel(models[12],_testData[21], false);NpgsqlLineline0M.AssertModel(models[13],_testData[22], false);NpgsqlLineline0M.AssertModel(models[14],_testData[23], false);NpgsqlLineline0M.AssertModel(models[15],_testData[24], false);NpgsqlLineline0M.AssertModel(models[16],_testData[25], false);NpgsqlLineline0M.AssertModel(models[17],_testData[26], false);NpgsqlLineline0M.AssertModel(models[18],_testData[27], false);NpgsqlLineline0M.AssertModel(models[19],_testData[28], false);NpgsqlLineline0M.AssertModel(models[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 87);
                var models =  ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
NpgsqlLineline0M.AssertModel(models[0],_testData[17], false);NpgsqlLineline0M.AssertModel(models[1],_testData[18], false);NpgsqlLineline0M.AssertModel(models[2],_testData[19], false);NpgsqlLineline0M.AssertModel(models[3],_testData[20], false);NpgsqlLineline0M.AssertModel(models[4],_testData[21], false);NpgsqlLineline0M.AssertModel(models[5],_testData[22], false);NpgsqlLineline0M.AssertModel(models[6],_testData[23], false);NpgsqlLineline0M.AssertModel(models[7],_testData[24], false);NpgsqlLineline0M.AssertModel(models[8],_testData[25], false);NpgsqlLineline0M.AssertModel(models[9],_testData[26], false);NpgsqlLineline0M.AssertModel(models[10],_testData[27], false);NpgsqlLineline0M.AssertModel(models[11],_testData[28], false);NpgsqlLineline0M.AssertModel(models[12],_testData[29], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2105403204109142d, b: 0.10235108109552038d, c: 0.3805146610459679d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12251410485588377d, b: 0.10683549453874419d, c: 0.7840770274266485d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.14006253567406712d, b: 0.7017123659310112d, c: 0.7086463762968844d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.971415101503014d, b: 0.3154309759938282d, c: 0.9289761782054815d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9693896566766621d, b: 0.13254679499911415d, c: 0.08111456649921478d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10957457779745972d, b: 0.25610123166854504d, c: 0.8315842588338915d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9344391286295275d, b: 0.2842191158445072d, c: 0.851130363746432d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8884990295526134d, b: 0.1653030956208449d, c: 0.583380596741671d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6844812793960109d, b: 0.20755298059309302d, c: 0.020791779532820187d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13764952839162614d, b: 0.5111304429203495d, c: 0.043012442661464756d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9892593438323467d, b: 0.9127262954845834d, c: 0.7897485069585395d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5019536669916445d, b: 0.9125413851937579d, c: 0.3633699736203637d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.06525671467170802d, b: 0.7399758677283576d, c: 0.2119939390173795d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4678802975354468d, b: 0.0977015946284816d, c: 0.38051974628893703d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6501549610845371d, b: 0.563981320057529d, c: 0.5926804788080987d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9522964549741183d, b: 0.5767972643864008d, c: 0.3924790666815561d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12281944753165641d, b: 0.2745689493150091d, c: 0.04802050244302947d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.14940167901981583d, b: 0.4590346656919272d, c: 0.6863099759495994d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7947690910742995d, b: 0.5900272189039776d, c: 0.8231593902581129d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6135350256926182d, b: 0.07138123581469635d, c: 0.15995367809722227d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.03260028124495018d, b: 0.34429186535786294d, c: 0.12163759619718562d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9947912227326524d, b: 0.0728596071824219d, c: 0.28326688894794916d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9731971511201855d, b: 0.13989104383614603d, c: 0.1258165529919123d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.42569242513164385d, b: 0.6006567409875234d, c: 0.2964328784279252d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12206913592009994d, b: 0.783906327475086d, c: 0.9134935663784772d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.792697212809565d, b: 0.05550017645466776d, c: 0.4030048189471618d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5069289659226123d, b: 0.964420370283384d, c: 0.17021717334303965d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.25771309426537103d, b: 0.9786867821622974d, c: 0.22262190029806694d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0563365984605525d, b: 0.4327977364250767d, c: 0.7782577937286999d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.27780619235827375d, b: 0.42396412778475956d, c: 0.39484770183877305d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.34331941400349253d, b: 0.9799080781728731d, c: 0.0600043564286884d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7197799943358113d, b: 0.499904240007338d, c: 0.3056556319449365d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3751083558402152d, b: 0.5392350056301003d, c: 0.013070755411726087d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8730089696986281d, b: 0.9895239049450082d, c: 0.10008330525839604d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7438160756407702d, b: 0.6513274391786977d, c: 0.5222166884012538d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.36215396300573377d, b: 0.7501284448036534d, c: 0.8602539258081793d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9401389265597951d, b: 0.9359942981156235d, c: 0.8075671902125673d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20452087226761073d, b: 0.9539271445555065d, c: 0.6485807722587486d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.247778441028646d, b: 0.47353895246772637d, c: 0.8648983954302437d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8616903134314662d, b: 0.5269725610052223d, c: 0.34334816878022156d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2515586179359043d, b: 0.39495737055079017d, c: 0.0669234843883183d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.865418993815323d, b: 0.31199983135500997d, c: 0.5221032258025285d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3521967267853112d, b: 0.10336816111740776d, c: 0.44483560196837113d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6648541149597661d, b: 0.1181298727013338d, c: 0.21040301121390648d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.255082288108083d, b: 0.7740545704077333d, c: 0.2320440640769591d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.42347542095923485d, b: 0.0543470065576348d, c: 0.43582572177042167d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9805226303261367d, b: 0.9308341454829592d, c: 0.9190036299696527d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2757160535487523d, b: 0.711027040537783d, c: 0.48570726249661567d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9486081847188258d, b: 0.3181435747607012d, c: 0.09852072481934337d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9051229261664949d, b: 0.4632531927092074d, c: 0.4018509118322322d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.22992805493805524d, b: 0.7447220989717132d, c: 0.555150526398638d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.05557156077768555d, b: 0.12568066074558193d, c: 0.1675293375409561d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9798664298956704d, b: 0.5856820659883928d, c: 0.9029380177617252d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1918363535774541d, b: 0.5037273920935348d, c: 0.8874876624948291d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.613943852842952d, b: 0.45917610830371136d, c: 0.7945141787701177d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6351638194860518d, b: 0.2849564007041996d, c: 0.40619302053762696d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9256062319893547d, b: 0.6691854493803875d, c: 0.46204319327387156d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.873377299435242d, b: 0.29522280571995885d, c: 0.6801236303257692d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.44189045003548066d, b: 0.0664528109985324d, c: 0.32705091857270485d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.004273705967918873d, b: 0.9311815842138287d, c: 0.7361488511636056d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6222787515139048d, b: 0.8767473032076356d, c: 0.24767311655113722d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12501160670839895d, b: 0.15878359620382032d, c: 0.23054447990950888d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.854454885167227d, b: 0.1539945143696514d, c: 0.9583222336558085d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2336383783088145d, b: 0.32737540109144936d, c: 0.3955850867032126d))));//InnerModel.Value

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
                var models =  ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2105403204109142d, b: 0.10235108109552038d, c: 0.3805146610459679d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12251410485588377d, b: 0.10683549453874419d, c: 0.7840770274266485d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.14006253567406712d, b: 0.7017123659310112d, c: 0.7086463762968844d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.971415101503014d, b: 0.3154309759938282d, c: 0.9289761782054815d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9693896566766621d, b: 0.13254679499911415d, c: 0.08111456649921478d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10957457779745972d, b: 0.25610123166854504d, c: 0.8315842588338915d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9344391286295275d, b: 0.2842191158445072d, c: 0.851130363746432d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8884990295526134d, b: 0.1653030956208449d, c: 0.583380596741671d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6844812793960109d, b: 0.20755298059309302d, c: 0.020791779532820187d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13764952839162614d, b: 0.5111304429203495d, c: 0.043012442661464756d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9892593438323467d, b: 0.9127262954845834d, c: 0.7897485069585395d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5019536669916445d, b: 0.9125413851937579d, c: 0.3633699736203637d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.06525671467170802d, b: 0.7399758677283576d, c: 0.2119939390173795d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4678802975354468d, b: 0.0977015946284816d, c: 0.38051974628893703d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6501549610845371d, b: 0.563981320057529d, c: 0.5926804788080987d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9522964549741183d, b: 0.5767972643864008d, c: 0.3924790666815561d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12281944753165641d, b: 0.2745689493150091d, c: 0.04802050244302947d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.14940167901981583d, b: 0.4590346656919272d, c: 0.6863099759495994d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7947690910742995d, b: 0.5900272189039776d, c: 0.8231593902581129d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6135350256926182d, b: 0.07138123581469635d, c: 0.15995367809722227d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.03260028124495018d, b: 0.34429186535786294d, c: 0.12163759619718562d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9947912227326524d, b: 0.0728596071824219d, c: 0.28326688894794916d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9731971511201855d, b: 0.13989104383614603d, c: 0.1258165529919123d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.42569242513164385d, b: 0.6006567409875234d, c: 0.2964328784279252d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12206913592009994d, b: 0.783906327475086d, c: 0.9134935663784772d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.792697212809565d, b: 0.05550017645466776d, c: 0.4030048189471618d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5069289659226123d, b: 0.964420370283384d, c: 0.17021717334303965d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.25771309426537103d, b: 0.9786867821622974d, c: 0.22262190029806694d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0563365984605525d, b: 0.4327977364250767d, c: 0.7782577937286999d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.27780619235827375d, b: 0.42396412778475956d, c: 0.39484770183877305d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.34331941400349253d, b: 0.9799080781728731d, c: 0.0600043564286884d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7197799943358113d, b: 0.499904240007338d, c: 0.3056556319449365d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3751083558402152d, b: 0.5392350056301003d, c: 0.013070755411726087d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8730089696986281d, b: 0.9895239049450082d, c: 0.10008330525839604d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7438160756407702d, b: 0.6513274391786977d, c: 0.5222166884012538d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.36215396300573377d, b: 0.7501284448036534d, c: 0.8602539258081793d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9401389265597951d, b: 0.9359942981156235d, c: 0.8075671902125673d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20452087226761073d, b: 0.9539271445555065d, c: 0.6485807722587486d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.247778441028646d, b: 0.47353895246772637d, c: 0.8648983954302437d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8616903134314662d, b: 0.5269725610052223d, c: 0.34334816878022156d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2515586179359043d, b: 0.39495737055079017d, c: 0.0669234843883183d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.865418993815323d, b: 0.31199983135500997d, c: 0.5221032258025285d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3521967267853112d, b: 0.10336816111740776d, c: 0.44483560196837113d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6648541149597661d, b: 0.1181298727013338d, c: 0.21040301121390648d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.255082288108083d, b: 0.7740545704077333d, c: 0.2320440640769591d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.42347542095923485d, b: 0.0543470065576348d, c: 0.43582572177042167d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9805226303261367d, b: 0.9308341454829592d, c: 0.9190036299696527d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2757160535487523d, b: 0.711027040537783d, c: 0.48570726249661567d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9486081847188258d, b: 0.3181435747607012d, c: 0.09852072481934337d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9051229261664949d, b: 0.4632531927092074d, c: 0.4018509118322322d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.22992805493805524d, b: 0.7447220989717132d, c: 0.555150526398638d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.05557156077768555d, b: 0.12568066074558193d, c: 0.1675293375409561d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9798664298956704d, b: 0.5856820659883928d, c: 0.9029380177617252d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1918363535774541d, b: 0.5037273920935348d, c: 0.8874876624948291d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.613943852842952d, b: 0.45917610830371136d, c: 0.7945141787701177d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6351638194860518d, b: 0.2849564007041996d, c: 0.40619302053762696d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9256062319893547d, b: 0.6691854493803875d, c: 0.46204319327387156d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.873377299435242d, b: 0.29522280571995885d, c: 0.6801236303257692d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.44189045003548066d, b: 0.0664528109985324d, c: 0.32705091857270485d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.004273705967918873d, b: 0.9311815842138287d, c: 0.7361488511636056d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6222787515139048d, b: 0.8767473032076356d, c: 0.24767311655113722d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12501160670839895d, b: 0.15878359620382032d, c: 0.23054447990950888d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.854454885167227d, b: 0.1539945143696514d, c: 0.9583222336558085d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2336383783088145d, b: 0.32737540109144936d, c: 0.3955850867032126d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

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
FROM public.binary_npgsqllineline0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLineline0MI),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLineline0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlLineSingleTypeline)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllineline0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineSingleTypeline)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlLineSingleTypeline)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllineline0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((INpgsqlLineSingleTypeline)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllineline0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLineline0MI),
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLineline0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlLineSingleTypeline)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineSingleTypeline)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlLineSingleTypeline)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlLineSingleTypeline)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllineline0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllineline0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLineline0M),
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
FROM public.binary_npgsqllineline0m m
LEFT JOIN public.binary_npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLineline0M>(15);

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
                ((INpgsqlLineSingleTypeline)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineSingleTypeline)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlLineline0M.AssertModel(models[0],_testData[0], false);
                NpgsqlLineline0M.AssertModel(models[1],_testData[1], false);
                NpgsqlLineline0M.AssertModel(models[2],_testData[2], false);
                NpgsqlLineline0M.AssertModel(models[3],_testData[3], false);
                NpgsqlLineline0M.AssertModel(models[4],_testData[4], false);
                NpgsqlLineline0M.AssertModel(models[5],_testData[5], false);
                NpgsqlLineline0M.AssertModel(models[6],_testData[6], false);
                NpgsqlLineline0M.AssertModel(models[7],_testData[7], false);
                NpgsqlLineline0M.AssertModel(models[8],_testData[8], false);
                NpgsqlLineline0M.AssertModel(models[9],_testData[9], false);
                NpgsqlLineline0M.AssertModel(models[10],_testData[10], false);
                NpgsqlLineline0M.AssertModel(models[11],_testData[11], false);
                NpgsqlLineline0M.AssertModel(models[12],_testData[12], false);
                NpgsqlLineline0M.AssertModel(models[13],_testData[13], false);
                NpgsqlLineline0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlLineSingleTypeline)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlLineSingleTypeline)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlLineline0M.AssertModel(models[0],_testData[0], false);
                NpgsqlLineline0M.AssertModel(models[1],_testData[1], false);
                NpgsqlLineline0M.AssertModel(models[2],_testData[2], false);
                NpgsqlLineline0M.AssertModel(models[3],_testData[3], false);
                NpgsqlLineline0M.AssertModel(models[4],_testData[4], false);
                NpgsqlLineline0M.AssertModel(models[5],_testData[5], false);
                NpgsqlLineline0M.AssertModel(models[6],_testData[6], false);
                NpgsqlLineline0M.AssertModel(models[7],_testData[7], false);
                NpgsqlLineline0M.AssertModel(models[8],_testData[8], false);
                NpgsqlLineline0M.AssertModel(models[9],_testData[9], false);
                NpgsqlLineline0M.AssertModel(models[10],_testData[10], false);
                NpgsqlLineline0M.AssertModel(models[11],_testData[11], false);
                NpgsqlLineline0M.AssertModel(models[12],_testData[12], false);
                NpgsqlLineline0M.AssertModel(models[13],_testData[13], false);
                NpgsqlLineline0M.AssertModel(models[14],_testData[14], false);
                NpgsqlLineline0M.AssertModel(models[15],_testData[15], false);
                NpgsqlLineline0M.AssertModel(models[16],_testData[16], false);
                NpgsqlLineline0M.AssertModel(models[17],_testData[17], false);
                NpgsqlLineline0M.AssertModel(models[18],_testData[18], false);
                NpgsqlLineline0M.AssertModel(models[19],_testData[19], false);
                NpgsqlLineline0M.AssertModel(models[20],_testData[20], false);
                NpgsqlLineline0M.AssertModel(models[21],_testData[21], false);
                NpgsqlLineline0M.AssertModel(models[22],_testData[22], false);
                NpgsqlLineline0M.AssertModel(models[23],_testData[23], false);
                NpgsqlLineline0M.AssertModel(models[24],_testData[24], false);
                NpgsqlLineline0M.AssertModel(models[25],_testData[25], false);
                NpgsqlLineline0M.AssertModel(models[26],_testData[26], false);
                NpgsqlLineline0M.AssertModel(models[27],_testData[27], false);
                NpgsqlLineline0M.AssertModel(models[28],_testData[28], false);
                NpgsqlLineline0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllineline0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllineline0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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
                    NpgsqlLineline0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
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
                    NpgsqlLineline0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllineline0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineSingleTypeline)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

