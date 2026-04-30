

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
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3527984307166664d, y: 0.9353214706009361d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8931215288491525d, y: 0.7133410705541274d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 1,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8583408441684288d, y: 0.868620582227909d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.3982870702744703d, y: 0.7683670972676935d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3273804864315578d, y: 0.6990930430434326d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9961378387130548d, y: 0.5067520225030707d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9294890525627999d, y: 0.029584172229670025d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.35537223409806673d, y: 0.48775052390763474d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.1866150662220687d, y: 0.3975023141877442d),
},
            new NpgsqlPointpoint0M
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3444197562758138d, y: 0.7807276645690442d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.10109396861101194d, y: 0.6820375017956168d),
},
            new NpgsqlPointpoint0M
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5652139630599716d, y: 0.500440921839134d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.45838140218664447d, y: 0.6840981416559717d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8148811786753631d, y: 0.0748461577202153d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8455999431740687d, y: 0.010128732995551504d),
},
            new NpgsqlPointpoint0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.12890658481960493d, y: 0.17198557457023478d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.24830624410640068d, y: 0.1910336483318925d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.12346968261884539d, y: 0.17031532347640044d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4198062825201292d, y: 0.47097400958355773d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5319755929506329d, y: 0.6032312246831336d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.3119354073848809d, y: 0.9720094715606353d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5092760901708441d, y: 0.26799246969101276d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9784140213429623d, y: 0.14503007889218655d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.13140747558009092d, y: 0.9456433290150282d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.40606375182133125d, y: 0.8656596332211912d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9205997320704764d, y: 0.8929223737605738d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.959695740702412d, y: 0.9072420412489394d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.3831456174280824d, y: 0.35536776807641457d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.36563204520972503d, y: 0.6241660192313725d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.5818809465803512d, y: 0.3483215373983144d),
},
            new NpgsqlPointpoint0M
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9084180665169591d, y: 0.311394881097075d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4125199254133034d, y: 0.342221619426064d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.49408045894226604d, y: 0.5280351329299838d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3189002107559692d, y: 0.33449647768573676d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4080210564918787d, y: 0.45422691351789446d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 92,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5157013962254647d, y: 0.5579201977099946d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 98,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8150901462947404d, y: 0.35633943337825147d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.27025993463615416d, y: 0.581122542532188d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.43623661498367006d, y: 0.840564695118054d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6401734672632964d, y: 0.20491443201305581d),
},
            new NpgsqlPointpoint0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.934606162814826d, y: 0.27622681231842494d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.20448446493658334d, y: 0.8622970328710352d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7389337158500429d, y: 0.6061788944228766d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3204751788131087d, y: 0.7625856627022817d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.07545289354362328d, y: 0.7981338828656579d),
},
            new NpgsqlPointpoint0M
{
    Id = 111,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7872787106036979d, y: 0.44936412412160376d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.29490564710332845d, y: 0.5354933285222301d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.17960012388034108d, y: 0.5563139630867593d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.5768671347699101d, y: 0.12595318322837412d),
},
            new NpgsqlPointpoint0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.737999939205562d, y: 0.31430248736947486d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6986073995872064d, y: 0.2182451325225374d),
},
            new NpgsqlPointpoint0M
{
    Id = 126,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8529724331927605d, y: 0.8983550673014807d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.23292065016783758d, y: 0.7130023898313792d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.4525883218443517d, y: 0.5527929785821852d),
},
            new NpgsqlPointpoint0M
{
    Id = 134,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6814789323152329d, y: 0.1626494487222757d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.34077612081200404d, y: 0.6683317338706221d),
},
            new NpgsqlPointpoint0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4382034304424227d, y: 0.09943892785521191d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.41907428645381306d, y: 0.4584314643891998d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.39290282549961864d, y: 0.19145453054915218d),
},
            new NpgsqlPointpoint0M
{
    Id = 142,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.28862785289588555d, y: 0.19270572099239403d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 151,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.0596275610693725d, y: 0.7763586720125716d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.019153321816690383d, y: 0.2974869063436809d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.11336082614340914d, y: 0.26501855230300164d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.10109396861101194d, y: 0.6820375017956168d)));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8455999431740687d, y: 0.010128732995551504d)));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 20;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[26],_testData[29], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[29], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 28, query1, 98, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
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
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[29], false);
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
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 134, query1, 35, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 38, query1, 59, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[29], false);
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
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 92, query1, 134, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 140, query1, 102, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[29], false);
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
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 119, query1, 14, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 34, query1, 28, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

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
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelBatch(connection, 35, query1, 68, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelBatchAsync(connection, 119, 34))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[23],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelBatch(connection, 84, 68))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

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
                ((INpgsqlPointSingleTypepoint)this).SetDbConnectionSelectModelParametrs(cmd, 28);
                var models = await ((INpgsqlPointSingleTypepoint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
NpgsqlPointpoint0M.AssertModel(models[0],_testData[5], false);NpgsqlPointpoint0M.AssertModel(models[1],_testData[6], false);NpgsqlPointpoint0M.AssertModel(models[2],_testData[7], false);NpgsqlPointpoint0M.AssertModel(models[3],_testData[8], false);NpgsqlPointpoint0M.AssertModel(models[4],_testData[9], false);NpgsqlPointpoint0M.AssertModel(models[5],_testData[10], false);NpgsqlPointpoint0M.AssertModel(models[6],_testData[11], false);NpgsqlPointpoint0M.AssertModel(models[7],_testData[12], false);NpgsqlPointpoint0M.AssertModel(models[8],_testData[13], false);NpgsqlPointpoint0M.AssertModel(models[9],_testData[14], false);NpgsqlPointpoint0M.AssertModel(models[10],_testData[15], false);NpgsqlPointpoint0M.AssertModel(models[11],_testData[16], false);NpgsqlPointpoint0M.AssertModel(models[12],_testData[17], false);NpgsqlPointpoint0M.AssertModel(models[13],_testData[18], false);NpgsqlPointpoint0M.AssertModel(models[14],_testData[19], false);NpgsqlPointpoint0M.AssertModel(models[15],_testData[20], false);NpgsqlPointpoint0M.AssertModel(models[16],_testData[21], false);NpgsqlPointpoint0M.AssertModel(models[17],_testData[22], false);NpgsqlPointpoint0M.AssertModel(models[18],_testData[23], false);NpgsqlPointpoint0M.AssertModel(models[19],_testData[24], false);NpgsqlPointpoint0M.AssertModel(models[20],_testData[25], false);NpgsqlPointpoint0M.AssertModel(models[21],_testData[26], false);NpgsqlPointpoint0M.AssertModel(models[22],_testData[27], false);NpgsqlPointpoint0M.AssertModel(models[23],_testData[28], false);NpgsqlPointpoint0M.AssertModel(models[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointSingleTypepoint)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointSingleTypepoint)this).SetDbConnectionSelectModelParametrs(cmd, 42);
                var models =  ((INpgsqlPointSingleTypepoint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
NpgsqlPointpoint0M.AssertModel(models[0],_testData[10], false);NpgsqlPointpoint0M.AssertModel(models[1],_testData[11], false);NpgsqlPointpoint0M.AssertModel(models[2],_testData[12], false);NpgsqlPointpoint0M.AssertModel(models[3],_testData[13], false);NpgsqlPointpoint0M.AssertModel(models[4],_testData[14], false);NpgsqlPointpoint0M.AssertModel(models[5],_testData[15], false);NpgsqlPointpoint0M.AssertModel(models[6],_testData[16], false);NpgsqlPointpoint0M.AssertModel(models[7],_testData[17], false);NpgsqlPointpoint0M.AssertModel(models[8],_testData[18], false);NpgsqlPointpoint0M.AssertModel(models[9],_testData[19], false);NpgsqlPointpoint0M.AssertModel(models[10],_testData[20], false);NpgsqlPointpoint0M.AssertModel(models[11],_testData[21], false);NpgsqlPointpoint0M.AssertModel(models[12],_testData[22], false);NpgsqlPointpoint0M.AssertModel(models[13],_testData[23], false);NpgsqlPointpoint0M.AssertModel(models[14],_testData[24], false);NpgsqlPointpoint0M.AssertModel(models[15],_testData[25], false);NpgsqlPointpoint0M.AssertModel(models[16],_testData[26], false);NpgsqlPointpoint0M.AssertModel(models[17],_testData[27], false);NpgsqlPointpoint0M.AssertModel(models[18],_testData[28], false);NpgsqlPointpoint0M.AssertModel(models[19],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3527984307166664d, y: 0.9353214706009361d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8931215288491525d, y: 0.7133410705541274d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8583408441684288d, y: 0.868620582227909d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3982870702744703d, y: 0.7683670972676935d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3273804864315578d, y: 0.6990930430434326d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9961378387130548d, y: 0.5067520225030707d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9294890525627999d, y: 0.029584172229670025d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.35537223409806673d, y: 0.48775052390763474d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1866150662220687d, y: 0.3975023141877442d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3444197562758138d, y: 0.7807276645690442d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.10109396861101194d, y: 0.6820375017956168d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5652139630599716d, y: 0.500440921839134d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.45838140218664447d, y: 0.6840981416559717d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8148811786753631d, y: 0.0748461577202153d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8455999431740687d, y: 0.010128732995551504d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.12890658481960493d, y: 0.17198557457023478d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.24830624410640068d, y: 0.1910336483318925d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.12346968261884539d, y: 0.17031532347640044d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4198062825201292d, y: 0.47097400958355773d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5319755929506329d, y: 0.6032312246831336d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3119354073848809d, y: 0.9720094715606353d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5092760901708441d, y: 0.26799246969101276d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9784140213429623d, y: 0.14503007889218655d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.13140747558009092d, y: 0.9456433290150282d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.40606375182133125d, y: 0.8656596332211912d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9205997320704764d, y: 0.8929223737605738d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.959695740702412d, y: 0.9072420412489394d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3831456174280824d, y: 0.35536776807641457d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.36563204520972503d, y: 0.6241660192313725d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5818809465803512d, y: 0.3483215373983144d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9084180665169591d, y: 0.311394881097075d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4125199254133034d, y: 0.342221619426064d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.49408045894226604d, y: 0.5280351329299838d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3189002107559692d, y: 0.33449647768573676d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4080210564918787d, y: 0.45422691351789446d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5157013962254647d, y: 0.5579201977099946d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8150901462947404d, y: 0.35633943337825147d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.27025993463615416d, y: 0.581122542532188d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.43623661498367006d, y: 0.840564695118054d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6401734672632964d, y: 0.20491443201305581d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.934606162814826d, y: 0.27622681231842494d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.20448446493658334d, y: 0.8622970328710352d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7389337158500429d, y: 0.6061788944228766d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3204751788131087d, y: 0.7625856627022817d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.07545289354362328d, y: 0.7981338828656579d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7872787106036979d, y: 0.44936412412160376d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.29490564710332845d, y: 0.5354933285222301d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17960012388034108d, y: 0.5563139630867593d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5768671347699101d, y: 0.12595318322837412d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.737999939205562d, y: 0.31430248736947486d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6986073995872064d, y: 0.2182451325225374d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8529724331927605d, y: 0.8983550673014807d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.23292065016783758d, y: 0.7130023898313792d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4525883218443517d, y: 0.5527929785821852d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6814789323152329d, y: 0.1626494487222757d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.34077612081200404d, y: 0.6683317338706221d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4382034304424227d, y: 0.09943892785521191d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.41907428645381306d, y: 0.4584314643891998d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.39290282549961864d, y: 0.19145453054915218d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.28862785289588555d, y: 0.19270572099239403d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.0596275610693725d, y: 0.7763586720125716d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.019153321816690383d, y: 0.2974869063436809d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.11336082614340914d, y: 0.26501855230300164d))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3527984307166664d, y: 0.9353214706009361d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8931215288491525d, y: 0.7133410705541274d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8583408441684288d, y: 0.868620582227909d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3982870702744703d, y: 0.7683670972676935d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3273804864315578d, y: 0.6990930430434326d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9961378387130548d, y: 0.5067520225030707d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9294890525627999d, y: 0.029584172229670025d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.35537223409806673d, y: 0.48775052390763474d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1866150662220687d, y: 0.3975023141877442d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3444197562758138d, y: 0.7807276645690442d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.10109396861101194d, y: 0.6820375017956168d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5652139630599716d, y: 0.500440921839134d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.45838140218664447d, y: 0.6840981416559717d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8148811786753631d, y: 0.0748461577202153d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8455999431740687d, y: 0.010128732995551504d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.12890658481960493d, y: 0.17198557457023478d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.24830624410640068d, y: 0.1910336483318925d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.12346968261884539d, y: 0.17031532347640044d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4198062825201292d, y: 0.47097400958355773d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5319755929506329d, y: 0.6032312246831336d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3119354073848809d, y: 0.9720094715606353d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5092760901708441d, y: 0.26799246969101276d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9784140213429623d, y: 0.14503007889218655d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.13140747558009092d, y: 0.9456433290150282d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.40606375182133125d, y: 0.8656596332211912d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9205997320704764d, y: 0.8929223737605738d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.959695740702412d, y: 0.9072420412489394d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3831456174280824d, y: 0.35536776807641457d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.36563204520972503d, y: 0.6241660192313725d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5818809465803512d, y: 0.3483215373983144d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9084180665169591d, y: 0.311394881097075d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4125199254133034d, y: 0.342221619426064d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.49408045894226604d, y: 0.5280351329299838d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3189002107559692d, y: 0.33449647768573676d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4080210564918787d, y: 0.45422691351789446d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5157013962254647d, y: 0.5579201977099946d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8150901462947404d, y: 0.35633943337825147d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.27025993463615416d, y: 0.581122542532188d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.43623661498367006d, y: 0.840564695118054d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6401734672632964d, y: 0.20491443201305581d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.934606162814826d, y: 0.27622681231842494d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.20448446493658334d, y: 0.8622970328710352d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7389337158500429d, y: 0.6061788944228766d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3204751788131087d, y: 0.7625856627022817d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.07545289354362328d, y: 0.7981338828656579d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7872787106036979d, y: 0.44936412412160376d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.29490564710332845d, y: 0.5354933285222301d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17960012388034108d, y: 0.5563139630867593d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5768671347699101d, y: 0.12595318322837412d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.737999939205562d, y: 0.31430248736947486d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6986073995872064d, y: 0.2182451325225374d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8529724331927605d, y: 0.8983550673014807d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.23292065016783758d, y: 0.7130023898313792d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4525883218443517d, y: 0.5527929785821852d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6814789323152329d, y: 0.1626494487222757d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.34077612081200404d, y: 0.6683317338706221d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4382034304424227d, y: 0.09943892785521191d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.41907428645381306d, y: 0.4584314643891998d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.39290282549961864d, y: 0.19145453054915218d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.28862785289588555d, y: 0.19270572099239403d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.0596275610693725d, y: 0.7763586720125716d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.019153321816690383d, y: 0.2974869063436809d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.11336082614340914d, y: 0.26501855230300164d))));

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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 0; i < 6; i++)
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQuerySelectImportModelInnerAsync(connection);
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

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 4; i < 10; i++)
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointSingleTypepoint)this).DynQuerySelectImportModelInner(connection);
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
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MI)],
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpoint0MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointSingleTypepoint)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointSingleTypepoint)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPointpoint0MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointSingleTypepoint)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointSingleTypepoint)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpoint0M>(15);

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
                ((INpgsqlPointSingleTypepoint)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointSingleTypepoint)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPointpoint0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpoint0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpoint0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpoint0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpoint0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpoint0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpoint0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpoint0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpoint0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpoint0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpoint0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpoint0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpoint0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpoint0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpoint0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPointSingleTypepoint)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPointSingleTypepoint)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPointpoint0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpoint0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpoint0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpoint0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpoint0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpoint0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpoint0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpoint0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpoint0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpoint0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpoint0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpoint0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpoint0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpoint0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpoint0M.AssertModel(models[14],_testData[14], false);
                NpgsqlPointpoint0M.AssertModel(models[15],_testData[15], false);
                NpgsqlPointpoint0M.AssertModel(models[16],_testData[16], false);
                NpgsqlPointpoint0M.AssertModel(models[17],_testData[17], false);
                NpgsqlPointpoint0M.AssertModel(models[18],_testData[18], false);
                NpgsqlPointpoint0M.AssertModel(models[19],_testData[19], false);
                NpgsqlPointpoint0M.AssertModel(models[20],_testData[20], false);
                NpgsqlPointpoint0M.AssertModel(models[21],_testData[21], false);
                NpgsqlPointpoint0M.AssertModel(models[22],_testData[22], false);
                NpgsqlPointpoint0M.AssertModel(models[23],_testData[23], false);
                NpgsqlPointpoint0M.AssertModel(models[24],_testData[24], false);
                NpgsqlPointpoint0M.AssertModel(models[25],_testData[25], false);
                NpgsqlPointpoint0M.AssertModel(models[26],_testData[26], false);
                NpgsqlPointpoint0M.AssertModel(models[27],_testData[27], false);
                NpgsqlPointpoint0M.AssertModel(models[28],_testData[28], false);
                NpgsqlPointpoint0M.AssertModel(models[29],_testData[29], false);
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqlpointpoint0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointSingleTypepoint)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointSingleTypepoint)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

