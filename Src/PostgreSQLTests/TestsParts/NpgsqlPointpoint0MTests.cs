

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
    internal partial interface INpgsqlPointSingleTypepoint
    {
    }
    
    internal partial class NpgsqlPointSingleTypepoint : INpgsqlPointSingleTypepoint
    {


#region TestData

        private readonly NpgsqlPointpoint0M[] _testData = new NpgsqlPointpoint0M[]
        {
            new NpgsqlPointpoint0M
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4700263376752103d, y: 0.7171859077001148d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8116008827799851d, y: 0.9975314893628299d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4056629218529658d, y: 0.8808327619143317d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7159211354886251d, y: 0.09025751661456916d),
},
            new NpgsqlPointpoint0M
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9454086360966086d, y: 0.3701729316363258d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5040668100572526d, y: 0.9259240412195578d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9019951565856698d, y: 0.8820951604708104d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6349325772309617d, y: 0.1402946636211948d),
},
            new NpgsqlPointpoint0M
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4038939621196065d, y: 0.9086349620152431d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.36194270571068843d, y: 0.25885031484689713d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4112185689482333d, y: 0.5939438674452702d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.33313757382368536d, y: 0.6613754653622549d),
},
            new NpgsqlPointpoint0M
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.39890922316788735d, y: 0.9595332721136636d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.05171030140634747d, y: 0.02821889753198259d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.36242530366843617d, y: 0.6890002659197632d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.25047620500847645d, y: 0.7085470513715012d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8750497584978193d, y: 0.4880329501076164d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9096981733959127d, y: 0.745526808909768d),
},
            new NpgsqlPointpoint0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9694732117388981d, y: 0.3205228810920714d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8464918013266715d, y: 0.44029444630182213d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.11680257576427311d, y: 0.06510912511586742d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7464063142089983d, y: 0.1315171518277206d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8143527876338793d, y: 0.7840494880015603d),
},
            new NpgsqlPointpoint0M
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6661213677380142d, y: 0.056516049391417744d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5111639679448079d, y: 0.6610239754074604d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8204780710934442d, y: 0.1328863583759321d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.628602319366193d, y: 0.9429385316707993d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.0006841341173848825d, y: 0.029424288676351718d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9994154852431288d, y: 0.7051823186713915d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7982026068555661d, y: 0.6208245552352821d),
},
            new NpgsqlPointpoint0M
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.013516516716230331d, y: 0.3458030342183369d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.1299831102891189d, y: 0.21270748130483175d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.23167929350270555d, y: 0.824962269588983d),
},
            new NpgsqlPointpoint0M
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4593129685379004d, y: 0.7230107770092664d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.731030570722399d, y: 0.2397661901946786d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.2071510374260067d, y: 0.12241423177556976d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7770560129354337d, y: 0.26186101176337195d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6015673091833199d, y: 0.24235602560403857d),
},
            new NpgsqlPointpoint0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.08318419517391396d, y: 0.09813738824194873d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.5226617625067108d, y: 0.30287277623007725d),
},
            new NpgsqlPointpoint0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9812617310250372d, y: 0.9584523398595288d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5948269856412871d, y: 0.6569590771781117d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.5207131558357911d, y: 0.8026624675737214d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.4589284974053116d, y: 0.24061450298072984d),
},
            new NpgsqlPointpoint0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.031197213713103356d, y: 0.8667141607128407d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.970747672365301d, y: 0.44224795690668783d),
},
            new NpgsqlPointpoint0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.15658943557663352d, y: 0.02491652673847411d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7004683577612553d, y: 0.22092218374913042d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.5668641415072846d, y: 0.8149751468911014d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 124,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3577764418038273d, y: 0.8156268699182532d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.523540858338024d, y: 0.529732602340226d),
},
            new NpgsqlPointpoint0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8608427090164333d, y: 0.39735908861428837d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.022262965007956215d, y: 0.7549619731349877d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5556239583978411d, y: 0.2341460076862243d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 142,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5406511103258496d, y: 0.778934178323839d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5521350168172765d, y: 0.05838480110395505d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 150,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5240918560068959d, y: 0.6767328834758399d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 151,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5152468416680354d, y: 0.25815807979358585d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.48140357986355686d, y: 0.42045921267266295d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.3055676295142731d, y: 0.4048960179992761d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 160,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7270255362197611d, y: 0.14775839723853257d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.5945458741372857d, y: 0.04455385617943819d),
},
            new NpgsqlPointpoint0M
{
    Id = 165,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.19744259777579265d, y: 0.0380773979318868d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.37994599850609134d, y: 0.3084856518889494d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7780322302789712d, y: 0.426296942787151d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6222060634114799d, y: 0.590792161676909d),
},
            new NpgsqlPointpoint0M
{
    Id = 167,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5507453545176447d, y: 0.7294373688075032d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.3582131469288756d, y: 0.36165222699368593d),
},
            new NpgsqlPointpoint0M
{
    Id = 175,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9815762624655797d, y: 0.25589081660930535d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5058379723738338d, y: 0.8997439856445115d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.285347889686306d, y: 0.6492753079438293d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 183,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.17720133404855298d, y: 0.5696214935204709d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.4679534285443746d, y: 0.6931230447900393d),
},
            new NpgsqlPointpoint0M
{
    Id = 188,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7019991322059491d, y: 0.5199118083336538d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4897720868973908d, y: 0.2033078132613343d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.0013617985865825855d, y: 0.8843462441540947d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.697397086698d, y: 0.5709887268095052d),
},
            new NpgsqlPointpoint0M
{
    Id = 195,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.10127147206081477d, y: 0.34038113537932646d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.17946140812771372d, y: 0.7481802110520291d),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0mi(
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0mi(
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
            queryMapTypes: [typeof(NpgsqlPointpoint0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(15))]
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

                changedRows =  ((INpgsqlPointSingleTypepoint)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointSingleTypepoint)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointSingleTypepoint)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointSingleTypepoint)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointSingleTypepoint)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointSingleTypepoint)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointSingleTypepoint)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0mi(
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
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

                changedRows =  ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0m(
	id,
    value,
    nullablevalue,
    npgsqlpointpoint0mi_id
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpoint0mi_id", 
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
                changedRows =  ((INpgsqlPointSingleTypepoint)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointSingleTypepoint)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointSingleTypepoint)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointSingleTypepoint)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0m(
	id,
    value,
    nullablevalue,
    npgsqlpointpoint0mi_id
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
    npgsqlpointpoint0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
                NpgsqlTypes.NpgsqlPoint? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
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

                    nullable =  ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
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

                    nullable =  ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.33313757382368536d, y: 0.6613754653622549d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
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

                    nullable = await ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
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

                    nullable = await ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0m(
	id,
    value,
    nullablevalue,
    npgsqlpointpoint0mi_id
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
    npgsqlpointpoint0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpoint0mi_id", 
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
                NpgsqlTypes.NpgsqlPoint? nullable = null;
                nullable =  ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9096981733959127d, y: 0.745526808909768d)));
                nullable =  ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint? nullable = null;
                nullable = await ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8143527876338793d, y: 0.7840494880015603d)));
                nullable = await ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpoint0M> models = null;

                models =  ((INpgsqlPointSingleTypepoint)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointSingleTypepoint)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointSingleTypepoint)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointSingleTypepoint)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpoint0M> models = null;

                models = await ((INpgsqlPointSingleTypepoint)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointSingleTypepoint)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointSingleTypepoint)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointSingleTypepoint)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0m(
	id,
    value,
    nullablevalue,
    npgsqlpointpoint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpointpoint0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPoint), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpointpoint0mi_id", 
                methodParametrName: "npgsqlpointpoint0mi_id", 
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

                changedRows =  ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M), typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                ((INpgsqlPointSingleTypepoint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointSingleTypepoint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
                var models = await ((INpgsqlPointSingleTypepoint)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointSingleTypepoint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M), typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                ((INpgsqlPointSingleTypepoint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointSingleTypepoint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
                var models = await ((INpgsqlPointSingleTypepoint)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointSingleTypepoint)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M), typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                await((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 165;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 124;
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
                var models = await((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[27],_testData[34], false);
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
                var models = ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M), typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                await((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 19, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 58, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[26],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 160, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 33, query1, 19, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 64, query1, 120, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 64, query1, 151, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 96, query1, 150, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelBatch(connection, 73, query1, 88, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
                var models = await((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelBatchAsync(connection, 120, 73))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[20],_testData[34], false);
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
                var models = ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelBatch(connection, 64, 88))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointSingleTypepoint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointSingleTypepoint)this).SetDbConnectionSelectModelParametrs(cmd, 23);
                var models = await ((INpgsqlPointSingleTypepoint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
NpgsqlPointpoint0M.AssertModel(models[0],_testData[7], false);NpgsqlPointpoint0M.AssertModel(models[1],_testData[8], false);NpgsqlPointpoint0M.AssertModel(models[2],_testData[9], false);NpgsqlPointpoint0M.AssertModel(models[3],_testData[10], false);NpgsqlPointpoint0M.AssertModel(models[4],_testData[11], false);NpgsqlPointpoint0M.AssertModel(models[5],_testData[12], false);NpgsqlPointpoint0M.AssertModel(models[6],_testData[13], false);NpgsqlPointpoint0M.AssertModel(models[7],_testData[14], false);NpgsqlPointpoint0M.AssertModel(models[8],_testData[15], false);NpgsqlPointpoint0M.AssertModel(models[9],_testData[16], false);NpgsqlPointpoint0M.AssertModel(models[10],_testData[17], false);NpgsqlPointpoint0M.AssertModel(models[11],_testData[18], false);NpgsqlPointpoint0M.AssertModel(models[12],_testData[19], false);NpgsqlPointpoint0M.AssertModel(models[13],_testData[20], false);NpgsqlPointpoint0M.AssertModel(models[14],_testData[21], false);NpgsqlPointpoint0M.AssertModel(models[15],_testData[22], false);NpgsqlPointpoint0M.AssertModel(models[16],_testData[23], false);NpgsqlPointpoint0M.AssertModel(models[17],_testData[24], false);NpgsqlPointpoint0M.AssertModel(models[18],_testData[25], false);NpgsqlPointpoint0M.AssertModel(models[19],_testData[26], false);NpgsqlPointpoint0M.AssertModel(models[20],_testData[27], false);NpgsqlPointpoint0M.AssertModel(models[21],_testData[28], false);NpgsqlPointpoint0M.AssertModel(models[22],_testData[29], false);NpgsqlPointpoint0M.AssertModel(models[23],_testData[30], false);NpgsqlPointpoint0M.AssertModel(models[24],_testData[31], false);NpgsqlPointpoint0M.AssertModel(models[25],_testData[32], false);NpgsqlPointpoint0M.AssertModel(models[26],_testData[33], false);NpgsqlPointpoint0M.AssertModel(models[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointSingleTypepoint)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointSingleTypepoint)this).SetDbConnectionSelectModelParametrs(cmd, 33);
                var models =  ((INpgsqlPointSingleTypepoint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
NpgsqlPointpoint0M.AssertModel(models[0],_testData[9], false);NpgsqlPointpoint0M.AssertModel(models[1],_testData[10], false);NpgsqlPointpoint0M.AssertModel(models[2],_testData[11], false);NpgsqlPointpoint0M.AssertModel(models[3],_testData[12], false);NpgsqlPointpoint0M.AssertModel(models[4],_testData[13], false);NpgsqlPointpoint0M.AssertModel(models[5],_testData[14], false);NpgsqlPointpoint0M.AssertModel(models[6],_testData[15], false);NpgsqlPointpoint0M.AssertModel(models[7],_testData[16], false);NpgsqlPointpoint0M.AssertModel(models[8],_testData[17], false);NpgsqlPointpoint0M.AssertModel(models[9],_testData[18], false);NpgsqlPointpoint0M.AssertModel(models[10],_testData[19], false);NpgsqlPointpoint0M.AssertModel(models[11],_testData[20], false);NpgsqlPointpoint0M.AssertModel(models[12],_testData[21], false);NpgsqlPointpoint0M.AssertModel(models[13],_testData[22], false);NpgsqlPointpoint0M.AssertModel(models[14],_testData[23], false);NpgsqlPointpoint0M.AssertModel(models[15],_testData[24], false);NpgsqlPointpoint0M.AssertModel(models[16],_testData[25], false);NpgsqlPointpoint0M.AssertModel(models[17],_testData[26], false);NpgsqlPointpoint0M.AssertModel(models[18],_testData[27], false);NpgsqlPointpoint0M.AssertModel(models[19],_testData[28], false);NpgsqlPointpoint0M.AssertModel(models[20],_testData[29], false);NpgsqlPointpoint0M.AssertModel(models[21],_testData[30], false);NpgsqlPointpoint0M.AssertModel(models[22],_testData[31], false);NpgsqlPointpoint0M.AssertModel(models[23],_testData[32], false);NpgsqlPointpoint0M.AssertModel(models[24],_testData[33], false);NpgsqlPointpoint0M.AssertModel(models[25],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4700263376752103d, y: 0.7171859077001148d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8116008827799851d, y: 0.9975314893628299d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4056629218529658d, y: 0.8808327619143317d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7159211354886251d, y: 0.09025751661456916d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9454086360966086d, y: 0.3701729316363258d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5040668100572526d, y: 0.9259240412195578d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9019951565856698d, y: 0.8820951604708104d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6349325772309617d, y: 0.1402946636211948d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4038939621196065d, y: 0.9086349620152431d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.36194270571068843d, y: 0.25885031484689713d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4112185689482333d, y: 0.5939438674452702d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.33313757382368536d, y: 0.6613754653622549d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.39890922316788735d, y: 0.9595332721136636d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.05171030140634747d, y: 0.02821889753198259d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.36242530366843617d, y: 0.6890002659197632d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.25047620500847645d, y: 0.7085470513715012d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8750497584978193d, y: 0.4880329501076164d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9096981733959127d, y: 0.745526808909768d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9694732117388981d, y: 0.3205228810920714d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8464918013266715d, y: 0.44029444630182213d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.11680257576427311d, y: 0.06510912511586742d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7464063142089983d, y: 0.1315171518277206d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8143527876338793d, y: 0.7840494880015603d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6661213677380142d, y: 0.056516049391417744d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5111639679448079d, y: 0.6610239754074604d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8204780710934442d, y: 0.1328863583759321d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.628602319366193d, y: 0.9429385316707993d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.0006841341173848825d, y: 0.029424288676351718d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9994154852431288d, y: 0.7051823186713915d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7982026068555661d, y: 0.6208245552352821d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.013516516716230331d, y: 0.3458030342183369d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1299831102891189d, y: 0.21270748130483175d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.23167929350270555d, y: 0.824962269588983d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4593129685379004d, y: 0.7230107770092664d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.731030570722399d, y: 0.2397661901946786d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2071510374260067d, y: 0.12241423177556976d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7770560129354337d, y: 0.26186101176337195d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6015673091833199d, y: 0.24235602560403857d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.08318419517391396d, y: 0.09813738824194873d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5226617625067108d, y: 0.30287277623007725d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9812617310250372d, y: 0.9584523398595288d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5948269856412871d, y: 0.6569590771781117d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5207131558357911d, y: 0.8026624675737214d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4589284974053116d, y: 0.24061450298072984d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.031197213713103356d, y: 0.8667141607128407d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.970747672365301d, y: 0.44224795690668783d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.15658943557663352d, y: 0.02491652673847411d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7004683577612553d, y: 0.22092218374913042d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5668641415072846d, y: 0.8149751468911014d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3577764418038273d, y: 0.8156268699182532d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.523540858338024d, y: 0.529732602340226d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8608427090164333d, y: 0.39735908861428837d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.022262965007956215d, y: 0.7549619731349877d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5556239583978411d, y: 0.2341460076862243d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5406511103258496d, y: 0.778934178323839d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5521350168172765d, y: 0.05838480110395505d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5240918560068959d, y: 0.6767328834758399d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5152468416680354d, y: 0.25815807979358585d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.48140357986355686d, y: 0.42045921267266295d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3055676295142731d, y: 0.4048960179992761d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7270255362197611d, y: 0.14775839723853257d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5945458741372857d, y: 0.04455385617943819d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.19744259777579265d, y: 0.0380773979318868d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.37994599850609134d, y: 0.3084856518889494d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7780322302789712d, y: 0.426296942787151d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6222060634114799d, y: 0.590792161676909d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5507453545176447d, y: 0.7294373688075032d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3582131469288756d, y: 0.36165222699368593d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9815762624655797d, y: 0.25589081660930535d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5058379723738338d, y: 0.8997439856445115d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.285347889686306d, y: 0.6492753079438293d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17720133404855298d, y: 0.5696214935204709d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4679534285443746d, y: 0.6931230447900393d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((188)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7019991322059491d, y: 0.5199118083336538d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4897720868973908d, y: 0.2033078132613343d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.0013617985865825855d, y: 0.8843462441540947d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.697397086698d, y: 0.5709887268095052d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((195)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.10127147206081477d, y: 0.34038113537932646d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17946140812771372d, y: 0.7481802110520291d))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4700263376752103d, y: 0.7171859077001148d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8116008827799851d, y: 0.9975314893628299d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4056629218529658d, y: 0.8808327619143317d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7159211354886251d, y: 0.09025751661456916d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9454086360966086d, y: 0.3701729316363258d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5040668100572526d, y: 0.9259240412195578d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9019951565856698d, y: 0.8820951604708104d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6349325772309617d, y: 0.1402946636211948d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4038939621196065d, y: 0.9086349620152431d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.36194270571068843d, y: 0.25885031484689713d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4112185689482333d, y: 0.5939438674452702d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.33313757382368536d, y: 0.6613754653622549d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.39890922316788735d, y: 0.9595332721136636d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.05171030140634747d, y: 0.02821889753198259d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.36242530366843617d, y: 0.6890002659197632d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.25047620500847645d, y: 0.7085470513715012d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8750497584978193d, y: 0.4880329501076164d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9096981733959127d, y: 0.745526808909768d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9694732117388981d, y: 0.3205228810920714d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8464918013266715d, y: 0.44029444630182213d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.11680257576427311d, y: 0.06510912511586742d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7464063142089983d, y: 0.1315171518277206d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8143527876338793d, y: 0.7840494880015603d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6661213677380142d, y: 0.056516049391417744d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5111639679448079d, y: 0.6610239754074604d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8204780710934442d, y: 0.1328863583759321d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.628602319366193d, y: 0.9429385316707993d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.0006841341173848825d, y: 0.029424288676351718d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9994154852431288d, y: 0.7051823186713915d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7982026068555661d, y: 0.6208245552352821d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.013516516716230331d, y: 0.3458030342183369d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1299831102891189d, y: 0.21270748130483175d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.23167929350270555d, y: 0.824962269588983d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4593129685379004d, y: 0.7230107770092664d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.731030570722399d, y: 0.2397661901946786d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2071510374260067d, y: 0.12241423177556976d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7770560129354337d, y: 0.26186101176337195d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6015673091833199d, y: 0.24235602560403857d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.08318419517391396d, y: 0.09813738824194873d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5226617625067108d, y: 0.30287277623007725d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9812617310250372d, y: 0.9584523398595288d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5948269856412871d, y: 0.6569590771781117d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5207131558357911d, y: 0.8026624675737214d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4589284974053116d, y: 0.24061450298072984d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.031197213713103356d, y: 0.8667141607128407d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.970747672365301d, y: 0.44224795690668783d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.15658943557663352d, y: 0.02491652673847411d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7004683577612553d, y: 0.22092218374913042d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5668641415072846d, y: 0.8149751468911014d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3577764418038273d, y: 0.8156268699182532d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.523540858338024d, y: 0.529732602340226d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8608427090164333d, y: 0.39735908861428837d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.022262965007956215d, y: 0.7549619731349877d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5556239583978411d, y: 0.2341460076862243d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5406511103258496d, y: 0.778934178323839d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5521350168172765d, y: 0.05838480110395505d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5240918560068959d, y: 0.6767328834758399d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5152468416680354d, y: 0.25815807979358585d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.48140357986355686d, y: 0.42045921267266295d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3055676295142731d, y: 0.4048960179992761d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7270255362197611d, y: 0.14775839723853257d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5945458741372857d, y: 0.04455385617943819d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.19744259777579265d, y: 0.0380773979318868d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.37994599850609134d, y: 0.3084856518889494d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7780322302789712d, y: 0.426296942787151d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6222060634114799d, y: 0.590792161676909d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5507453545176447d, y: 0.7294373688075032d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3582131469288756d, y: 0.36165222699368593d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9815762624655797d, y: 0.25589081660930535d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5058379723738338d, y: 0.8997439856445115d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.285347889686306d, y: 0.6492753079438293d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17720133404855298d, y: 0.5696214935204709d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4679534285443746d, y: 0.6931230447900393d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((188)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7019991322059491d, y: 0.5199118083336538d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4897720868973908d, y: 0.2033078132613343d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.0013617985865825855d, y: 0.8843462441540947d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.697397086698d, y: 0.5709887268095052d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((195)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.10127147206081477d, y: 0.34038113537932646d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17946140812771372d, y: 0.7481802110520291d))));

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
FROM public.binary_npgsqlpointpoint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpoint0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpoint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointSingleTypepoint)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpoint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointSingleTypepoint)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointSingleTypepoint)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpoint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpoint0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpoint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointSingleTypepoint)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpoint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointSingleTypepoint)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointSingleTypepoint)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpoint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpoint0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpoint0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointSingleTypepoint)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointSingleTypepoint)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpoint0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointSingleTypepoint)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointSingleTypepoint)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpoint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpoint0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpoint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointSingleTypepoint)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointSingleTypepoint)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpoint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointSingleTypepoint)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointSingleTypepoint)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpoint0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpoint0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpoint0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
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
FROM public.binary_npgsqlpointpoint0m m
LEFT JOIN public.binary_npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpoint0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointSingleTypepoint)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointSingleTypepoint)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpoint0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpoint0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointSingleTypepoint)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointSingleTypepoint)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpoint0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpoint0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpoint0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointSingleTypepoint)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpoint0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointSingleTypepoint)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpoint0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA), typeof(NpgsqlPointpoint0MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
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
                var models1 = new List<NpgsqlPointpoint0MIWA>();
                var models2 = new List<NpgsqlPointpoint0MIWA>();
                await ((INpgsqlPointSingleTypepoint)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpoint0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpoint0MIWA>();
                var models2 = new List<NpgsqlPointpoint0MIWA>();
                ((INpgsqlPointSingleTypepoint)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpoint0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
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
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpoint0mi
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
                    NpgsqlPointpoint0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointSingleTypepoint)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpoint0mi
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
                    NpgsqlPointpoint0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA), typeof(NpgsqlPointpoint0MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
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
                var models1 = new List<NpgsqlPointpoint0MIWA>();
                var models2 = new List<NpgsqlPointpoint0MIWA>();
                await ((INpgsqlPointSingleTypepoint)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpoint0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpoint0MIWA>();
                var models2 = new List<NpgsqlPointpoint0MIWA>();
                ((INpgsqlPointSingleTypepoint)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpoint0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
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
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpoint0mi
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
                    NpgsqlPointpoint0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointSingleTypepoint)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpoint0mi
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
                    NpgsqlPointpoint0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpoint0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MI), typeof(NpgsqlPointpoint0MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
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
                var models1 = new List<NpgsqlPointpoint0MI>();
                var models2 = new List<NpgsqlPointpoint0MI>();
                await ((INpgsqlPointSingleTypepoint)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpoint0MI>();
                var models2 = new List<NpgsqlPointpoint0MI>();
                ((INpgsqlPointSingleTypepoint)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpoint0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
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
                var models = await ((INpgsqlPointSingleTypepoint)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointSingleTypepoint)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpoint0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA), typeof(NpgsqlPointpoint0MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
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
                var models1 = new List<NpgsqlPointpoint0MIWA>();
                var models2 = new List<NpgsqlPointpoint0MIWA>();
                await ((INpgsqlPointSingleTypepoint)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpoint0MIWA>();
                var models2 = new List<NpgsqlPointpoint0MIWA>();
                ((INpgsqlPointSingleTypepoint)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpoint0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
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
                var models = await ((INpgsqlPointSingleTypepoint)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointSingleTypepoint)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

