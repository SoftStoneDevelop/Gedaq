

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
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.71493083f,

0.39490646f,

0.00026494265f,

0.119614124f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9846315f,

0.47050232f,

0.23471719f,

0.13750571f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.4682954f,

0.5815507f,

0.53677297f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6622525f,

0.9683265f,

0.809732f,

0.5518657f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.6919847f,

0.015292406f,

0.7257089f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3994928f,

0.36915416f,

0.22901237f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.92889684f,

0.8508604f,

0.9340248f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8341921f,

0.63139427f,

0.59479254f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.19983011f,

0.17955726f,

0.79757166f,

0.5376857f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.53291124f,

0.87430066f,

0.09064138f,

0.14077836f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.078941464f,

0.6160787f,

0.56119525f,

0.2949294f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.07030749f,

0.19391865f,

0.81396973f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.29066086f,

0.90190375f,

0.10383797f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.819606f,

0.6886046f,

0.034643114f,

},
},
            new SinglerealArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.18262833f,

0.8695906f,

0.628075f,

0.31417668f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.14139879f,

0.5596497f,

0.7979706f,

0.51105f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9771396f,

0.5032164f,

0.039624035f,

},
},
            new SinglerealArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2653259f,

0.45486695f,

0.8093577f,

0.04558754f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.007168174f,

0.026628494f,

0.93522835f,

0.70388234f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5551008f,

0.73285306f,

0.38191682f,

0.7030507f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.06824237f,

0.042050302f,

0.6636452f,

0.99468094f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8662185f,

0.42993432f,

0.3892727f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.037154496f,

0.12115663f,

0.4143026f,

},
},
            new SinglerealArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.82270426f,

0.34627962f,

0.09193373f,

0.3565187f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.7096951f,

0.43424737f,

0.9846463f,

0.87164026f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.52698135f,

0.574027f,

0.8220404f,

0.8279639f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.119093895f,

0.08930564f,

0.16840744f,

0.7730701f,

},
},
            new SinglerealArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.23147446f,

0.7536412f,

0.25036424f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.25188142f,

0.65277326f,

0.2247935f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.27861643f,

0.7027694f,

0.3063345f,

0.5859545f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.63718504f,

0.3183865f,

0.50792575f,

},
},
            new SinglerealArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.75959516f,

0.436729f,

0.7082234f,

0.40571094f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.34733528f,

0.9572326f,

0.49883664f,

0.31244862f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.81160295f,

0.85922855f,

0.79947287f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.09603357f,

0.39588034f,

0.6729798f,

},
},
            new SinglerealArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.62370497f,

0.03176713f,

0.31131518f,

0.5189844f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.27050656f,

0.38751918f,

0.31839865f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.15572578f,

0.6998477f,

0.59967446f,

0.37115633f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.027807117f,

0.6634881f,

0.32868195f,

0.73421055f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.30494177f,

0.7741002f,

0.4347177f,

},
},
            new SinglerealArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5116393f,

0.38840705f,

0.9856032f,

0.45721412f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.10024375f,

0.032279372f,

0.88457346f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9896875f,

0.25011212f,

0.8428882f,

0.09488642f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6220759f,

0.3692202f,

0.24027073f,

0.03150916f,

},
},
            new SinglerealArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.1648544f,

0.49652004f,

0.5273468f,

0.5625981f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.18324125f,

0.18169272f,

0.90249693f,

0.6571115f,

},
},
            new SinglerealArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5494929f,

0.73048496f,

0.3710125f,

0.3753336f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.4910254f,

0.73161477f,

0.81138605f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.06871098f,

0.11165613f,

0.1238721f,

0.44638407f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8290035f,

0.7655712f,

0.37468022f,

0.24925762f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.6168141f,

0.1753897f,

0.7165441f,

},
},
            new SinglerealArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.16578847f,

0.8040012f,

0.20325065f,

0.6305011f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.6960169f,

0.04257697f,

0.20219117f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.78947085f,

0.75596327f,

0.5705113f,

0.82405293f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.122383595f,

0.02002287f,

0.265082f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.88663095f,

0.7956526f,

0.03420198f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9760586f,

0.37829828f,

0.14254451f,

0.6853661f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7350377f,

0.38904363f,

0.22433883f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5234668f,

0.49627817f,

0.13923526f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.46792024f,

0.5782542f,

0.072604775f,

0.60817796f,

},
},
            new SinglerealArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.38790905f,

0.6455302f,

0.9753728f,

0.7694143f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.25885022f,

0.8193317f,

0.46235836f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.27803832f,

0.63732475f,

0.83230317f,

0.8695572f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.55217755f,

0.7178863f,

0.60746384f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6662849f,

0.88289404f,

0.9062392f,

0.72805053f,

},
},
            new SinglerealArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7643518f,

0.23695391f,

0.64244825f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.2924937f,

0.20416743f,

0.5028102f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.46976668f,

0.8608072f,

0.09784126f,

0.93585384f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.79645795f,

0.25655383f,

0.5423102f,

},
},
            new SinglerealArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.39304566f,

0.15616953f,

0.85854965f,

0.60378724f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9257962f,

0.46069813f,

0.66733533f,

0.08639234f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.801932f,

0.047474205f,

0.938975f,

0.8904866f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.16973054f,

0.5313758f,

0.21068358f,

0.8071377f,

},
    ModelInner = null,
    NullableValue = null,
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

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
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
                        FlatSinglerealArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
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
                        FlatSinglerealArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
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
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr2.Value = 11;
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[2], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(models[13],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(models[14],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(models[15],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(models[16],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(models[17],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(models[18],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[19],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[20],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[21],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[22],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[23],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[24],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[25],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[26],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[27],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(models[28],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(models[29],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(models[30],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(models[31],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[20],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 99;
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
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        SinglerealArray2M.AssertModel(models[18],_testData[30], false);
                        SinglerealArray2M.AssertModel(models[19],_testData[31], false);
                        SinglerealArray2M.AssertModel(models[20],_testData[32], false);
                        SinglerealArray2M.AssertModel(models[21],_testData[33], false);
                        SinglerealArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        SinglerealArray2M.AssertModel(models[0],_testData[9], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[10], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[11], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[12], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[13], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[14], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[15], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[16], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[17], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[18], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[14],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[15],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[16],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[17],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[18],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[19],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[20],_testData[29], false);
                        SinglerealArray2M.AssertModel(models[21],_testData[30], false);
                        SinglerealArray2M.AssertModel(models[22],_testData[31], false);
                        SinglerealArray2M.AssertModel(models[23],_testData[32], false);
                        SinglerealArray2M.AssertModel(models[24],_testData[33], false);
                        SinglerealArray2M.AssertModel(models[25],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        SinglerealArray2M.AssertModel(models[0],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[29], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[30], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[31], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[32], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[33], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        SinglerealArray2M.AssertModel(models[0],_testData[16], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[17], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[18], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[29], false);
                        SinglerealArray2M.AssertModel(models[14],_testData[30], false);
                        SinglerealArray2M.AssertModel(models[15],_testData[31], false);
                        SinglerealArray2M.AssertModel(models[16],_testData[32], false);
                        SinglerealArray2M.AssertModel(models[17],_testData[33], false);
                        SinglerealArray2M.AssertModel(models[18],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
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
                await ((ISingleListrealArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 133, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
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
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[34], false);
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
                await ((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 112, query1, 97, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
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
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
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
                 ((ISingleListrealArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 107, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
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
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[34], false);
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
                 ((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 124, query1, 31, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[27],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 66, query1, 133, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[13],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[14],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[15],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[16],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(models[17],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(models[18],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(models[19],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(models[20],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[34], false);
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
                await ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 82, query1, 11, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[32],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 31, query1, 121, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(models[13],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[14],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[15],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[16],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[17],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[18],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[19],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[20],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[21],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[22],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(models[23],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(models[24],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(models[25],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(models[26],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[34], false);
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
                 ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelBatch(connection, 121, query1, 37, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSTSelectModelBatchAsync(connection, 77, 19))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

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
                        SinglerealArray2M.AssertModel(models[15],_testData[30], false);
                        SinglerealArray2M.AssertModel(models[16],_testData[31], false);
                        SinglerealArray2M.AssertModel(models[17],_testData[32], false);
                        SinglerealArray2M.AssertModel(models[18],_testData[33], false);
                        SinglerealArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        SinglerealArray2M.AssertModel(models[0],_testData[5], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[6], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[7], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[8], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[9], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[10], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[11], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[12], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[13], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[14], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[15], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[16], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[17], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[18], false);
                        SinglerealArray2M.AssertModel(models[14],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[15],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[16],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[17],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[18],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[19],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[20],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[21],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[22],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[23],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[24],_testData[29], false);
                        SinglerealArray2M.AssertModel(models[25],_testData[30], false);
                        SinglerealArray2M.AssertModel(models[26],_testData[31], false);
                        SinglerealArray2M.AssertModel(models[27],_testData[32], false);
                        SinglerealArray2M.AssertModel(models[28],_testData[33], false);
                        SinglerealArray2M.AssertModel(models[29],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSTSelectModelBatch(connection, 107, 80))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        SinglerealArray2M.AssertModel(models[0],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[29], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[30], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[31], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[32], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[33], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        SinglerealArray2M.AssertModel(models[0],_testData[16], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[17], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[18], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[29], false);
                        SinglerealArray2M.AssertModel(models[14],_testData[30], false);
                        SinglerealArray2M.AssertModel(models[15],_testData[31], false);
                        SinglerealArray2M.AssertModel(models[16],_testData[32], false);
                        SinglerealArray2M.AssertModel(models[17],_testData[33], false);
                        SinglerealArray2M.AssertModel(models[18],_testData[34], false);
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
                ((ISingleListrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 77);
                var models = await ((ISingleListrealArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

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
                SinglerealArray2M.AssertModel(models[15],_testData[30], false);
                SinglerealArray2M.AssertModel(models[16],_testData[31], false);
                SinglerealArray2M.AssertModel(models[17],_testData[32], false);
                SinglerealArray2M.AssertModel(models[18],_testData[33], false);
                SinglerealArray2M.AssertModel(models[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleListrealArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleListrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 66);
                var models =  ((ISingleListrealArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

                SinglerealArray2M.AssertModel(models[0],_testData[13], false);
                SinglerealArray2M.AssertModel(models[1],_testData[14], false);
                SinglerealArray2M.AssertModel(models[2],_testData[15], false);
                SinglerealArray2M.AssertModel(models[3],_testData[16], false);
                SinglerealArray2M.AssertModel(models[4],_testData[17], false);
                SinglerealArray2M.AssertModel(models[5],_testData[18], false);
                SinglerealArray2M.AssertModel(models[6],_testData[19], false);
                SinglerealArray2M.AssertModel(models[7],_testData[20], false);
                SinglerealArray2M.AssertModel(models[8],_testData[21], false);
                SinglerealArray2M.AssertModel(models[9],_testData[22], false);
                SinglerealArray2M.AssertModel(models[10],_testData[23], false);
                SinglerealArray2M.AssertModel(models[11],_testData[24], false);
                SinglerealArray2M.AssertModel(models[12],_testData[25], false);
                SinglerealArray2M.AssertModel(models[13],_testData[26], false);
                SinglerealArray2M.AssertModel(models[14],_testData[27], false);
                SinglerealArray2M.AssertModel(models[15],_testData[28], false);
                SinglerealArray2M.AssertModel(models[16],_testData[29], false);
                SinglerealArray2M.AssertModel(models[17],_testData[30], false);
                SinglerealArray2M.AssertModel(models[18],_testData[31], false);
                SinglerealArray2M.AssertModel(models[19],_testData[32], false);
                SinglerealArray2M.AssertModel(models[20],_testData[33], false);
                SinglerealArray2M.AssertModel(models[21],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(SinglerealArray2MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleListrealArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlerealarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISingleListrealArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleListrealArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_singlerealarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleListrealArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_singlerealarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(SinglerealArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleListrealArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlerealarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISingleListrealArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleListrealArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_singlerealarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleListrealArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_singlerealarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
        private void WASelectImportModelInnerConfig()
        {
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ISingleListrealArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleListrealArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ISingleListrealArray)this).WAImportModelInner(connection, importCollection);
                var models = ((ISingleListrealArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_singlerealarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(SinglerealArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleListrealArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleListrealArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleListrealArray)this).ImportModelInner(connection, importCollection);
                var models = ((ISingleListrealArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ISingleListrealArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((ISingleListrealArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SinglerealArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ISingleListrealArray)this).ImportModel(connection, importCollection);
                var models = ((ISingleListrealArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SinglerealArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MIWA), typeof(SinglerealArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
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
                var models1 = new List<SinglerealArray2MIWA>();
                var models2 = new List<SinglerealArray2MIWA>();
                await ((ISingleListrealArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealArray2MIWA>();
                var models2 = new List<SinglerealArray2MIWA>();
                ((ISingleListrealArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
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
                var models = await ((ISingleListrealArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_singlerealarray2mi
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
                    SinglerealArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleListrealArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_singlerealarray2mi
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
                    SinglerealArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MIWA), typeof(SinglerealArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
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
                var models1 = new List<SinglerealArray2MIWA>();
                var models2 = new List<SinglerealArray2MIWA>();
                await ((ISingleListrealArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealArray2MIWA>();
                var models2 = new List<SinglerealArray2MIWA>();
                ((ISingleListrealArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
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
                var models = await ((ISingleListrealArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_singlerealarray2mi
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
                    SinglerealArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleListrealArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_singlerealarray2mi
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
                    SinglerealArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_singlerealarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MI), typeof(SinglerealArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
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
                var models1 = new List<SinglerealArray2MI>();
                var models2 = new List<SinglerealArray2MI>();
                await ((ISingleListrealArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealArray2MI>();
                var models2 = new List<SinglerealArray2MI>();
                ((ISingleListrealArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
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
                var models = await ((ISingleListrealArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleListrealArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_singlerealarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MIWA), typeof(SinglerealArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
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
                var models1 = new List<SinglerealArray2MIWA>();
                var models2 = new List<SinglerealArray2MIWA>();
                await ((ISingleListrealArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealArray2MIWA>();
                var models2 = new List<SinglerealArray2MIWA>();
                ((ISingleListrealArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
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
                var models = await ((ISingleListrealArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleListrealArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

