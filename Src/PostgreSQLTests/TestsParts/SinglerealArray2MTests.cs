

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
    internal partial interface ISingleListrealArray
    {
    }
    
    internal partial class SingleListrealArray : ISingleListrealArray
    {


#region TestData

        private readonly SinglerealArray2M[] _testData = new SinglerealArray2M[]
        {
            new SinglerealArray2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.4041074f,

0.9075014f,

0.74084353f,

0.4392717f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.63849556f,

0.2672373f,

0.99303555f,

0.31649846f,

},
},
            new SinglerealArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8694779f,

0.14982545f,

0.25594336f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.76148266f,

0.16865754f,

0.7351378f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3959012f,

0.36642945f,

0.042770028f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7042909f,

0.20912796f,

0.10155344f,

},
},
            new SinglerealArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.74164116f,

0.0948056f,

0.7043483f,

0.63992935f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.41028327f,

0.8162864f,

0.96455264f,

0.6648293f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.22128427f,

0.7352874f,

0.7191721f,

},
},
            new SinglerealArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.61456347f,

0.3481092f,

0.4812835f,

0.9826242f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.60951465f,

0.33636075f,

0.56126887f,

0.058281302f,

},
},
            new SinglerealArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.6086335f,

0.61254126f,

0.1128912f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.08688301f,

0.63036734f,

0.43967462f,

0.25151306f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9409417f,

0.5956691f,

0.63138634f,

0.42532086f,

},
},
            new SinglerealArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.37979257f,

0.8425128f,

0.8477686f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7884611f,

0.79586387f,

0.66406363f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.67021704f,

0.4194435f,

0.31362754f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8972454f,

0.10663283f,

0.10166031f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.68398845f,

0.6483062f,

0.34147817f,

0.72558206f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8428634f,

0.051139474f,

0.85736924f,

0.6687337f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.35474575f,

0.9068048f,

0.585782f,

},
},
            new SinglerealArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.55151767f,

0.4568249f,

0.4542753f,

0.60789514f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.38802356f,

0.14035916f,

0.45060146f,

},
},
            new SinglerealArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.44540304f,

0.17960924f,

0.89869386f,

0.7607573f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.77106977f,

0.040998638f,

0.33996522f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5730548f,

0.9830368f,

0.095359504f,

0.1288507f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.44589108f,

0.7714811f,

0.27955115f,

0.5218589f,

},
},
            new SinglerealArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3923105f,

0.4685189f,

0.22759783f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.0708617f,

0.40181643f,

0.7007022f,

0.7783965f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.53094923f,

0.22726256f,

0.37422168f,

0.41460526f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5800125f,

0.16879761f,

0.6762261f,

0.30130637f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.74789983f,

0.20555377f,

0.5251348f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.50784457f,

0.23745632f,

0.7981905f,

0.38135797f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.7433422f,

0.25413716f,

0.08517748f,

0.45172924f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.6067455f,

0.8498389f,

0.12417269f,

},
},
            new SinglerealArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.31693238f,

0.22721618f,

0.8895658f,

0.84879124f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.08616638f,

0.91986495f,

0.4944268f,

},
},
            new SinglerealArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9860796f,

0.04651034f,

0.67936665f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.46734828f,

0.5587891f,

0.30564678f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6966114f,

0.5778089f,

0.5658062f,

0.1573366f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.69490016f,

0.15095425f,

0.99006414f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.4767558f,

0.47582346f,

0.062752545f,

0.6141149f,

},
},
            new SinglerealArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.0051051974f,

0.046976984f,

0.1727649f,

0.958978f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.83653593f,

0.2664821f,

0.1851939f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.4412539f,

0.5570351f,

0.86984223f,

},
},
            new SinglerealArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.82513803f,

0.30032712f,

0.019408584f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.73493767f,

0.31197053f,

0.11995703f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.24262911f,

0.91121566f,

0.065900326f,

0.12128466f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6905414f,

0.18099064f,

0.31121314f,

0.035432816f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.02026087f,

0.37878418f,

0.36561787f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.41649777f,

0.13747019f,

0.13439965f,

0.94308865f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.21246767f,

0.4611109f,

0.9066069f,

0.005700469f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.71754926f,

0.37411916f,

0.57727736f,

0.066422164f,

},
},
            new SinglerealArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.15533692f,

0.9665246f,

0.46011513f,

0.15654117f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.76286024f,

0.64016974f,

0.19151312f,

},
},
            new SinglerealArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6591267f,

0.32042134f,

0.0979504f,

0.69271785f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9726482f,

0.85031664f,

0.9337529f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.6402985f,

0.9274826f,

0.656781f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6390984f,

0.7371037f,

0.43509448f,

0.9190199f,

},
},
            new SinglerealArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.66015226f,

0.18016183f,

0.39843726f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.54878336f,

0.9364092f,

0.47046173f,

0.14854759f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.07580978f,

0.50834113f,

0.0843693f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9914717f,

0.94268847f,

0.91188014f,

0.42233682f,

},
},
            new SinglerealArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.75726247f,

0.1774708f,

0.29617143f,

0.9649171f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5905222f,

0.36561728f,

0.8624812f,

0.59178513f,

},
},
            new SinglerealArray2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8348997f,

0.79615265f,

0.6569673f,

0.6665889f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.7330703f,

0.37644953f,

0.29193562f,

0.6714473f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.79819435f,

0.37893993f,

0.42789853f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8712761f,

0.3413298f,

0.9075893f,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray2mi(
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
            asPartInterface: typeof(ISingleListrealArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Single>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Single>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray2mi(
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
            queryMapTypes: [typeof(SinglerealArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Single>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Single>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631))]
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

                changedRows =  ((ISingleListrealArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleListrealArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ISingleListrealArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleListrealArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ISingleListrealArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ISingleListrealArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray2m(
	id,
    value,
    nullablevalue,
    singlerealarray2mi_id
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
            asPartInterface: typeof(ISingleListrealArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Single>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Single>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "singlerealarray2mi_id", 
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
                changedRows =  ((ISingleListrealArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ISingleListrealArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ISingleListrealArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ISingleListrealArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray2m(
	id,
    value,
    nullablevalue,
    singlerealarray2mi_id
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
    singlerealarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(SinglerealArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray2m(
	id,
    value,
    nullablevalue,
    singlerealarray2mi_id
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
    singlerealarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(SinglerealArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Single>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Single>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "singlerealarray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SinglerealArray2M> models = null;

                models =  ((ISingleListrealArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((ISingleListrealArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((ISingleListrealArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((ISingleListrealArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SinglerealArray2M> models = null;

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray2M), typeof(FlatSinglerealArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
FROM public.singlerealarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglerealArray2M>();
                var models2 = new List<FlatSinglerealArray2M>();
                await ((ISingleListrealArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglerealArray2M>();
                var models2 = new List<FlatSinglerealArray2M>();
                ((ISingleListrealArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
FROM public.singlerealarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ISingleListrealArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ISingleListrealArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray2m m
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(SinglerealArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
                var models = await ((ISingleListrealArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ISingleListrealArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray2M), typeof(FlatSinglerealArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
FROM public.singlerealarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealArray2M>();
                var models2 = new List<FlatSinglerealArray2M>();
                await ((ISingleListrealArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealArray2M>();
                var models2 = new List<FlatSinglerealArray2M>();
                ((ISingleListrealArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
FROM public.singlerealarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ISingleListrealArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ISingleListrealArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray2m m
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(SinglerealArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
                var models = await ((ISingleListrealArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ISingleListrealArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray2M), typeof(FlatSinglerealArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
            asPartInterface: typeof(ISingleListrealArray)),
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealArray2M>();
                var models2 = new List<FlatSinglerealArray2M>();
                await((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 122;
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var firstItems2 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                var secondItems2 = new List<FlatSinglerealArray2M>();
                await ((ISingleListrealArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 122;
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var firstItems2 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                await ((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[29], false);
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealArray2M>();
                var models2 = new List<FlatSinglerealArray2M>();
                ((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 89;
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var firstItems2 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                var secondItems2 = new List<FlatSinglerealArray2M>();
                 ((ISingleListrealArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 108;
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var firstItems2 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                 ((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
            asPartInterface: typeof(ISingleListrealArray)),
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ISingleListrealArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 143;
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[13],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[14],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[15],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[16],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[17],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[18],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[19],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[20],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[21],_testData[29], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                var secondItems2 = new List<FlatSinglerealArray2M>();
                await ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[29], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                var secondItems2 = new List<FlatSinglerealArray2M>();
                 ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[29], false);
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
FROM public.singlerealarray2m m
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(SinglerealArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
                var models = await((ISingleListrealArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        SinglerealArray2M.AssertModel(models[0],_testData[10], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[11], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[12], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[13], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[14], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[15], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[16], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[17], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[18], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[14],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[15],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[16],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[17],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[18],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        SinglerealArray2M.AssertModel(models[0],_testData[15], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[16], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[17], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[18], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[14],_testData[29], false);
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
                var models = ((ISingleListrealArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        SinglerealArray2M.AssertModel(models[0],_testData[12], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[13], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[14], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[15], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[16], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[17], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[18], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[14],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[15],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[16],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        SinglerealArray2M.AssertModel(models[0],_testData[2], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[3], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[4], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[5], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[6], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[7], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[8], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[9], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[10], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[11], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[12], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[13], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[14], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[15], false);
                        SinglerealArray2M.AssertModel(models[14],_testData[16], false);
                        SinglerealArray2M.AssertModel(models[15],_testData[17], false);
                        SinglerealArray2M.AssertModel(models[16],_testData[18], false);
                        SinglerealArray2M.AssertModel(models[17],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[18],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[19],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[20],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[21],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[22],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[23],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[24],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[25],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[26],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray2M), typeof(FlatSinglerealArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
            asPartInterface: typeof(ISingleListrealArray)),
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
            asPartInterface: typeof(ISingleListrealArray)),
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealArray2M>();
                var models2 = new List<FlatSinglerealArray2M>();
                await((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var firstItems2 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                var secondItems2 = new List<FlatSinglerealArray2M>();
                await ((ISingleListrealArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 123, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[29], false);
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var firstItems2 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                await ((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 122, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[28],_testData[29], false);
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealArray2M>();
                var models2 = new List<FlatSinglerealArray2M>();
                ((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var firstItems2 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                var secondItems2 = new List<FlatSinglerealArray2M>();
                 ((ISingleListrealArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 7, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[26],_testData[29], false);
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var firstItems2 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                 ((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 91, query1, 89, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
            asPartInterface: typeof(ISingleListrealArray)),
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
            asPartInterface: typeof(ISingleListrealArray)),
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISingleListrealArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 16, query1, 105, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(models[13],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(models[14],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(models[15],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(models[16],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(models[17],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[18],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[19],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[20],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[21],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[22],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[23],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[24],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[25],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[29], false);
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                var secondItems2 = new List<FlatSinglerealArray2M>();
                await ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 143, query1, 108, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[29], false);
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISingleListrealArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 64, query1, 114, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[13],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[14],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[15],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[16],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[29], false);
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                var secondItems2 = new List<FlatSinglerealArray2M>();
                 ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelBatch(connection, 3, query1, 123, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[29], false);
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
FROM public.singlerealarray2m m
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(SinglerealArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
            asPartInterface: typeof(ISingleListrealArray)),
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
                var models = await((ISingleListrealArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSTSelectModelBatchAsync(connection, 3, 39))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        SinglerealArray2M.AssertModel(models[0],_testData[1], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[2], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[3], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[4], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[5], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[6], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[7], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[8], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[9], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[10], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[11], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[12], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[13], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[14], false);
                        SinglerealArray2M.AssertModel(models[14],_testData[15], false);
                        SinglerealArray2M.AssertModel(models[15],_testData[16], false);
                        SinglerealArray2M.AssertModel(models[16],_testData[17], false);
                        SinglerealArray2M.AssertModel(models[17],_testData[18], false);
                        SinglerealArray2M.AssertModel(models[18],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[19],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[20],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[21],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[22],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[23],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[24],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[25],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[26],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[27],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        SinglerealArray2M.AssertModel(models[0],_testData[8], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[9], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[10], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[11], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[12], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[13], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[14], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[15], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[16], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[17], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[18], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[14],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[15],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[16],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[17],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[18],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[19],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[20],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[21],_testData[29], false);
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
                var models = ((ISingleListrealArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSTSelectModelBatch(connection, 16, 16))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        SinglerealArray2M.AssertModel(models[0],_testData[3], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[4], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[5], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[6], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[7], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[8], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[9], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[10], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[11], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[12], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[13], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[14], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[15], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[16], false);
                        SinglerealArray2M.AssertModel(models[14],_testData[17], false);
                        SinglerealArray2M.AssertModel(models[15],_testData[18], false);
                        SinglerealArray2M.AssertModel(models[16],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[17],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[18],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[19],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[20],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[21],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[22],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[23],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[24],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[25],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        SinglerealArray2M.AssertModel(models[0],_testData[3], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[4], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[5], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[6], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[7], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[8], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[9], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[10], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[11], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[12], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[13], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[14], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[15], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[16], false);
                        SinglerealArray2M.AssertModel(models[14],_testData[17], false);
                        SinglerealArray2M.AssertModel(models[15],_testData[18], false);
                        SinglerealArray2M.AssertModel(models[16],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[17],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[18],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[19],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[20],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[21],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[22],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[23],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[24],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[25],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[26],_testData[29], false);
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
                await using var cmd = await ((ISingleListrealArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISingleListrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 33);
                var models = await ((ISingleListrealArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
SinglerealArray2M.AssertModel(models[0],_testData[7], false);SinglerealArray2M.AssertModel(models[1],_testData[8], false);SinglerealArray2M.AssertModel(models[2],_testData[9], false);SinglerealArray2M.AssertModel(models[3],_testData[10], false);SinglerealArray2M.AssertModel(models[4],_testData[11], false);SinglerealArray2M.AssertModel(models[5],_testData[12], false);SinglerealArray2M.AssertModel(models[6],_testData[13], false);SinglerealArray2M.AssertModel(models[7],_testData[14], false);SinglerealArray2M.AssertModel(models[8],_testData[15], false);SinglerealArray2M.AssertModel(models[9],_testData[16], false);SinglerealArray2M.AssertModel(models[10],_testData[17], false);SinglerealArray2M.AssertModel(models[11],_testData[18], false);SinglerealArray2M.AssertModel(models[12],_testData[19], false);SinglerealArray2M.AssertModel(models[13],_testData[20], false);SinglerealArray2M.AssertModel(models[14],_testData[21], false);SinglerealArray2M.AssertModel(models[15],_testData[22], false);SinglerealArray2M.AssertModel(models[16],_testData[23], false);SinglerealArray2M.AssertModel(models[17],_testData[24], false);SinglerealArray2M.AssertModel(models[18],_testData[25], false);SinglerealArray2M.AssertModel(models[19],_testData[26], false);SinglerealArray2M.AssertModel(models[20],_testData[27], false);SinglerealArray2M.AssertModel(models[21],_testData[28], false);SinglerealArray2M.AssertModel(models[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleListrealArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleListrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 24);
                var models =  ((ISingleListrealArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
SinglerealArray2M.AssertModel(models[0],_testData[6], false);SinglerealArray2M.AssertModel(models[1],_testData[7], false);SinglerealArray2M.AssertModel(models[2],_testData[8], false);SinglerealArray2M.AssertModel(models[3],_testData[9], false);SinglerealArray2M.AssertModel(models[4],_testData[10], false);SinglerealArray2M.AssertModel(models[5],_testData[11], false);SinglerealArray2M.AssertModel(models[6],_testData[12], false);SinglerealArray2M.AssertModel(models[7],_testData[13], false);SinglerealArray2M.AssertModel(models[8],_testData[14], false);SinglerealArray2M.AssertModel(models[9],_testData[15], false);SinglerealArray2M.AssertModel(models[10],_testData[16], false);SinglerealArray2M.AssertModel(models[11],_testData[17], false);SinglerealArray2M.AssertModel(models[12],_testData[18], false);SinglerealArray2M.AssertModel(models[13],_testData[19], false);SinglerealArray2M.AssertModel(models[14],_testData[20], false);SinglerealArray2M.AssertModel(models[15],_testData[21], false);SinglerealArray2M.AssertModel(models[16],_testData[22], false);SinglerealArray2M.AssertModel(models[17],_testData[23], false);SinglerealArray2M.AssertModel(models[18],_testData[24], false);SinglerealArray2M.AssertModel(models[19],_testData[25], false);SinglerealArray2M.AssertModel(models[20],_testData[26], false);SinglerealArray2M.AssertModel(models[21],_testData[27], false);SinglerealArray2M.AssertModel(models[22],_testData[28], false);SinglerealArray2M.AssertModel(models[23],_testData[29], false);
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
FROM public.binary_singlerealarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(SinglerealArray2MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<SinglerealArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((ISingleListrealArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_singlerealarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleListrealArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(actual, expect, false);
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
                await ((ISingleListrealArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlerealarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((ISingleListrealArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(SinglerealArray2MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<SinglerealArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((ISingleListrealArray)this).ImportModelInner(connection, importCollection);
                var models = ((ISingleListrealArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(actual, expect, false);
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
                await ((ISingleListrealArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((ISingleListrealArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
singlerealarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(SinglerealArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
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
FROM public.binary_singlerealarray2m m
LEFT JOIN public.binary_singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(SinglerealArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<SinglerealArray2M>(15);

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
                ((ISingleListrealArray)this).ImportModel(connection, importCollection);
                var models = ((ISingleListrealArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                SinglerealArray2M.AssertModel(models[0],_testData[0], false);
                SinglerealArray2M.AssertModel(models[1],_testData[1], false);
                SinglerealArray2M.AssertModel(models[2],_testData[2], false);
                SinglerealArray2M.AssertModel(models[3],_testData[3], false);
                SinglerealArray2M.AssertModel(models[4],_testData[4], false);
                SinglerealArray2M.AssertModel(models[5],_testData[5], false);
                SinglerealArray2M.AssertModel(models[6],_testData[6], false);
                SinglerealArray2M.AssertModel(models[7],_testData[7], false);
                SinglerealArray2M.AssertModel(models[8],_testData[8], false);
                SinglerealArray2M.AssertModel(models[9],_testData[9], false);
                SinglerealArray2M.AssertModel(models[10],_testData[10], false);
                SinglerealArray2M.AssertModel(models[11],_testData[11], false);
                SinglerealArray2M.AssertModel(models[12],_testData[12], false);
                SinglerealArray2M.AssertModel(models[13],_testData[13], false);
                SinglerealArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((ISingleListrealArray)this).ImportModelAsync(connection, importCollection);
                models = await ((ISingleListrealArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                SinglerealArray2M.AssertModel(models[0],_testData[0], false);
                SinglerealArray2M.AssertModel(models[1],_testData[1], false);
                SinglerealArray2M.AssertModel(models[2],_testData[2], false);
                SinglerealArray2M.AssertModel(models[3],_testData[3], false);
                SinglerealArray2M.AssertModel(models[4],_testData[4], false);
                SinglerealArray2M.AssertModel(models[5],_testData[5], false);
                SinglerealArray2M.AssertModel(models[6],_testData[6], false);
                SinglerealArray2M.AssertModel(models[7],_testData[7], false);
                SinglerealArray2M.AssertModel(models[8],_testData[8], false);
                SinglerealArray2M.AssertModel(models[9],_testData[9], false);
                SinglerealArray2M.AssertModel(models[10],_testData[10], false);
                SinglerealArray2M.AssertModel(models[11],_testData[11], false);
                SinglerealArray2M.AssertModel(models[12],_testData[12], false);
                SinglerealArray2M.AssertModel(models[13],_testData[13], false);
                SinglerealArray2M.AssertModel(models[14],_testData[14], false);
                SinglerealArray2M.AssertModel(models[15],_testData[15], false);
                SinglerealArray2M.AssertModel(models[16],_testData[16], false);
                SinglerealArray2M.AssertModel(models[17],_testData[17], false);
                SinglerealArray2M.AssertModel(models[18],_testData[18], false);
                SinglerealArray2M.AssertModel(models[19],_testData[19], false);
                SinglerealArray2M.AssertModel(models[20],_testData[20], false);
                SinglerealArray2M.AssertModel(models[21],_testData[21], false);
                SinglerealArray2M.AssertModel(models[22],_testData[22], false);
                SinglerealArray2M.AssertModel(models[23],_testData[23], false);
                SinglerealArray2M.AssertModel(models[24],_testData[24], false);
                SinglerealArray2M.AssertModel(models[25],_testData[25], false);
                SinglerealArray2M.AssertModel(models[26],_testData[26], false);
                SinglerealArray2M.AssertModel(models[27],_testData[27], false);
                SinglerealArray2M.AssertModel(models[28],_testData[28], false);
                SinglerealArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    singlerealarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(SinglerealArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISingleListrealArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SinglerealArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleListrealArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SinglerealArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISingleListrealArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleListrealArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

