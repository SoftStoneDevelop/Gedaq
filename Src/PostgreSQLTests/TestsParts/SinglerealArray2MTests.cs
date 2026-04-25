

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
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.82208973f,

0.79118395f,

0.8869514f,

0.049940646f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.39306253f,

0.23672909f,

0.88501626f,

0.026338637f,

},
},
            new SinglerealArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.87646204f,

0.9021766f,

0.36922437f,

0.048816383f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.19083583f,

0.71724665f,

0.66129565f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.0049936175f,

0.8328828f,

0.123925865f,

0.29971206f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3443281f,

0.05838114f,

0.97109914f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.121796966f,

0.5704419f,

0.8676673f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.1411972f,

0.7756637f,

0.9295709f,

0.78092444f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.13843131f,

0.8871874f,

0.6165597f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.44338125f,

0.27926654f,

0.18998784f,

},
},
            new SinglerealArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.91267246f,

0.6867598f,

0.4032185f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9421079f,

0.22956973f,

0.77195406f,

},
},
            new SinglerealArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8719748f,

0.1872378f,

0.45379877f,

0.98699147f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8631788f,

0.99954355f,

0.22846538f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.03798753f,

0.8358706f,

0.0051222444f,

},
},
            new SinglerealArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.75162816f,

0.119680345f,

0.2348274f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.4644196f,

0.3018365f,

0.8151364f,

},
},
            new SinglerealArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.66036993f,

0.4826792f,

0.37001085f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.90724874f,

0.44228423f,

0.5618261f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.23991227f,

0.5944271f,

0.46610445f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.09475416f,

0.44171268f,

0.22946179f,

0.7326456f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.2681995f,

0.8310904f,

0.8957579f,

},
},
            new SinglerealArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5076197f,

0.41465122f,

0.46222383f,

0.5720387f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9845778f,

0.6716818f,

0.8845898f,

0.5329252f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.40684545f,

0.79578733f,

0.73625845f,

0.5561091f,

},
},
            new SinglerealArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8247964f,

0.06172651f,

0.66256773f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3641098f,

0.2673123f,

0.8483156f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9830841f,

0.4921072f,

0.9237104f,

0.9080418f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.61152583f,

0.59574974f,

0.5095874f,

0.31113112f,

},
},
            new SinglerealArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.09426296f,

0.9371568f,

0.5320512f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.82611424f,

0.14874232f,

0.8419644f,

0.46645105f,

},
},
            new SinglerealArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6900894f,

0.25160408f,

0.28257447f,

0.7939515f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2783202f,

0.23291326f,

0.26045817f,

0.21252555f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6127644f,

0.77077675f,

0.2296387f,

0.31958836f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.009655297f,

0.6976124f,

0.24920928f,

0.76217616f,

},
},
            new SinglerealArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.88793594f,

0.6766775f,

0.65447867f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.44505358f,

0.5939662f,

0.87957484f,

0.23256916f,

},
},
            new SinglerealArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.97685534f,

0.38222325f,

0.11802709f,

0.8601588f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7692476f,

0.1361363f,

0.62341046f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.25968647f,

0.7532059f,

0.4371153f,

0.52987665f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6698933f,

0.53822714f,

0.46345335f,

0.16355777f,

},
},
            new SinglerealArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.95261556f,

0.54868734f,

0.21851587f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.83048123f,

0.73898584f,

0.49946398f,

0.45434666f,

},
},
            new SinglerealArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.015460372f,

0.2050373f,

0.05184692f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.44977254f,

0.855791f,

0.66641295f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.64997977f,

0.18954629f,

0.037045896f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9389641f,

0.13720751f,

0.25603878f,

0.69908905f,

},
},
            new SinglerealArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7281143f,

0.3864094f,

0.39557797f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.30208498f,

0.9009927f,

0.32431966f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.7451872f,

0.85087514f,

0.27719027f,

0.8766193f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.015920818f,

0.05722177f,

0.5210522f,

0.89921474f,

},
},
            new SinglerealArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.63804305f,

0.17614692f,

0.20221347f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3220327f,

0.28237253f,

0.89165765f,

0.551154f,

},
},
            new SinglerealArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8204307f,

0.9532791f,

0.32469285f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.42943972f,

0.20894337f,

0.14018065f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.45044047f,

0.029063761f,

0.8493799f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3858921f,

0.075817525f,

0.535693f,

},
},
            new SinglerealArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.11933637f,

0.62165564f,

0.8421528f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.91348624f,

0.8130255f,

0.7711871f,

},
},
            new SinglerealArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9691316f,

0.38264596f,

0.20215309f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.7254498f,

0.18581986f,

0.3465091f,

0.6259261f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.67530966f,

0.9468049f,

0.28061634f,

0.90448713f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5426479f,

0.76044714f,

0.68284136f,

0.2563364f,

},
},
            new SinglerealArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.88970125f,

0.5074705f,

0.4659977f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.7772048f,

0.93723667f,

0.55544156f,

0.80237997f,

},
},
            new SinglerealArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.65776575f,

0.75710356f,

0.82623357f,

0.29977763f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.44155186f,

0.26804852f,

0.43167096f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.2971112f,

0.41922855f,

0.4703312f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9492022f,

0.5062595f,

0.34011215f,

0.25525928f,

},
},
            new SinglerealArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.37337792f,

0.14673275f,

0.675924f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.59238374f,

0.24601114f,

0.10102707f,

0.39085966f,

},
},
            new SinglerealArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.844604f,

0.59478056f,

0.82548845f,

0.118890524f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.4966321f,

0.3586493f,

0.7705904f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.40237588f,

0.3233409f,

0.2784189f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6777797f,

0.8142289f,

0.36730373f,

0.90990645f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.56309044f,

0.25898212f,

0.0023474097f,

0.25052303f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.59379625f,

0.935378f,

0.29917747f,

0.7049093f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9598955f,

0.50684536f,

0.7910092f,

0.069955826f,

},
},
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
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray2M)],
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
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
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
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((ISingleListrealArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((ISingleListrealArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray2M)],
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
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
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
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((ISingleListrealArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((ISingleListrealArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray2m m
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
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
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatSinglerealArray2M.AssertModel(models[0],_testData[1], false);FlatSinglerealArray2M.AssertModel(models[1],_testData[2], false);FlatSinglerealArray2M.AssertModel(models[2],_testData[3], false);FlatSinglerealArray2M.AssertModel(models[3],_testData[4], false);FlatSinglerealArray2M.AssertModel(models[4],_testData[5], false);FlatSinglerealArray2M.AssertModel(models[5],_testData[6], false);FlatSinglerealArray2M.AssertModel(models[6],_testData[7], false);FlatSinglerealArray2M.AssertModel(models[7],_testData[8], false);FlatSinglerealArray2M.AssertModel(models[8],_testData[9], false);FlatSinglerealArray2M.AssertModel(models[9],_testData[10], false);FlatSinglerealArray2M.AssertModel(models[10],_testData[11], false);FlatSinglerealArray2M.AssertModel(models[11],_testData[12], false);FlatSinglerealArray2M.AssertModel(models[12],_testData[13], false);FlatSinglerealArray2M.AssertModel(models[13],_testData[14], false);FlatSinglerealArray2M.AssertModel(models[14],_testData[15], false);FlatSinglerealArray2M.AssertModel(models[15],_testData[16], false);FlatSinglerealArray2M.AssertModel(models[16],_testData[17], false);FlatSinglerealArray2M.AssertModel(models[17],_testData[18], false);FlatSinglerealArray2M.AssertModel(models[18],_testData[19], false);FlatSinglerealArray2M.AssertModel(models[19],_testData[20], false);FlatSinglerealArray2M.AssertModel(models[20],_testData[21], false);FlatSinglerealArray2M.AssertModel(models[21],_testData[22], false);FlatSinglerealArray2M.AssertModel(models[22],_testData[23], false);FlatSinglerealArray2M.AssertModel(models[23],_testData[24], false);FlatSinglerealArray2M.AssertModel(models[24],_testData[25], false);FlatSinglerealArray2M.AssertModel(models[25],_testData[26], false);FlatSinglerealArray2M.AssertModel(models[26],_testData[27], false);FlatSinglerealArray2M.AssertModel(models[27],_testData[28], false);FlatSinglerealArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatSinglerealArray2M.AssertModel(models[0],_testData[3], false);FlatSinglerealArray2M.AssertModel(models[1],_testData[4], false);FlatSinglerealArray2M.AssertModel(models[2],_testData[5], false);FlatSinglerealArray2M.AssertModel(models[3],_testData[6], false);FlatSinglerealArray2M.AssertModel(models[4],_testData[7], false);FlatSinglerealArray2M.AssertModel(models[5],_testData[8], false);FlatSinglerealArray2M.AssertModel(models[6],_testData[9], false);FlatSinglerealArray2M.AssertModel(models[7],_testData[10], false);FlatSinglerealArray2M.AssertModel(models[8],_testData[11], false);FlatSinglerealArray2M.AssertModel(models[9],_testData[12], false);FlatSinglerealArray2M.AssertModel(models[10],_testData[13], false);FlatSinglerealArray2M.AssertModel(models[11],_testData[14], false);FlatSinglerealArray2M.AssertModel(models[12],_testData[15], false);FlatSinglerealArray2M.AssertModel(models[13],_testData[16], false);FlatSinglerealArray2M.AssertModel(models[14],_testData[17], false);FlatSinglerealArray2M.AssertModel(models[15],_testData[18], false);FlatSinglerealArray2M.AssertModel(models[16],_testData[19], false);FlatSinglerealArray2M.AssertModel(models[17],_testData[20], false);FlatSinglerealArray2M.AssertModel(models[18],_testData[21], false);FlatSinglerealArray2M.AssertModel(models[19],_testData[22], false);FlatSinglerealArray2M.AssertModel(models[20],_testData[23], false);FlatSinglerealArray2M.AssertModel(models[21],_testData[24], false);FlatSinglerealArray2M.AssertModel(models[22],_testData[25], false);FlatSinglerealArray2M.AssertModel(models[23],_testData[26], false);FlatSinglerealArray2M.AssertModel(models[24],_testData[27], false);FlatSinglerealArray2M.AssertModel(models[25],_testData[28], false);FlatSinglerealArray2M.AssertModel(models[26],_testData[29], false);
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
FROM public.singlerealarray2m m
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray2m m
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
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
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatSinglerealArray2M.AssertModel(models[0],_testData[21], false);FlatSinglerealArray2M.AssertModel(models[1],_testData[22], false);FlatSinglerealArray2M.AssertModel(models[2],_testData[23], false);FlatSinglerealArray2M.AssertModel(models[3],_testData[24], false);FlatSinglerealArray2M.AssertModel(models[4],_testData[25], false);FlatSinglerealArray2M.AssertModel(models[5],_testData[26], false);FlatSinglerealArray2M.AssertModel(models[6],_testData[27], false);FlatSinglerealArray2M.AssertModel(models[7],_testData[28], false);FlatSinglerealArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatSinglerealArray2M.AssertModel(models[0],_testData[20], false);FlatSinglerealArray2M.AssertModel(models[1],_testData[21], false);FlatSinglerealArray2M.AssertModel(models[2],_testData[22], false);FlatSinglerealArray2M.AssertModel(models[3],_testData[23], false);FlatSinglerealArray2M.AssertModel(models[4],_testData[24], false);FlatSinglerealArray2M.AssertModel(models[5],_testData[25], false);FlatSinglerealArray2M.AssertModel(models[6],_testData[26], false);FlatSinglerealArray2M.AssertModel(models[7],_testData[27], false);FlatSinglerealArray2M.AssertModel(models[8],_testData[28], false);FlatSinglerealArray2M.AssertModel(models[9],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((ISingleListrealArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
SinglerealArray2M.AssertModel(models[0],_testData[16], false);SinglerealArray2M.AssertModel(models[1],_testData[17], false);SinglerealArray2M.AssertModel(models[2],_testData[18], false);SinglerealArray2M.AssertModel(models[3],_testData[19], false);SinglerealArray2M.AssertModel(models[4],_testData[20], false);SinglerealArray2M.AssertModel(models[5],_testData[21], false);SinglerealArray2M.AssertModel(models[6],_testData[22], false);SinglerealArray2M.AssertModel(models[7],_testData[23], false);SinglerealArray2M.AssertModel(models[8],_testData[24], false);SinglerealArray2M.AssertModel(models[9],_testData[25], false);SinglerealArray2M.AssertModel(models[10],_testData[26], false);SinglerealArray2M.AssertModel(models[11],_testData[27], false);SinglerealArray2M.AssertModel(models[12],_testData[28], false);SinglerealArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
SinglerealArray2M.AssertModel(models[0],_testData[8], false);SinglerealArray2M.AssertModel(models[1],_testData[9], false);SinglerealArray2M.AssertModel(models[2],_testData[10], false);SinglerealArray2M.AssertModel(models[3],_testData[11], false);SinglerealArray2M.AssertModel(models[4],_testData[12], false);SinglerealArray2M.AssertModel(models[5],_testData[13], false);SinglerealArray2M.AssertModel(models[6],_testData[14], false);SinglerealArray2M.AssertModel(models[7],_testData[15], false);SinglerealArray2M.AssertModel(models[8],_testData[16], false);SinglerealArray2M.AssertModel(models[9],_testData[17], false);SinglerealArray2M.AssertModel(models[10],_testData[18], false);SinglerealArray2M.AssertModel(models[11],_testData[19], false);SinglerealArray2M.AssertModel(models[12],_testData[20], false);SinglerealArray2M.AssertModel(models[13],_testData[21], false);SinglerealArray2M.AssertModel(models[14],_testData[22], false);SinglerealArray2M.AssertModel(models[15],_testData[23], false);SinglerealArray2M.AssertModel(models[16],_testData[24], false);SinglerealArray2M.AssertModel(models[17],_testData[25], false);SinglerealArray2M.AssertModel(models[18],_testData[26], false);SinglerealArray2M.AssertModel(models[19],_testData[27], false);SinglerealArray2M.AssertModel(models[20],_testData[28], false);SinglerealArray2M.AssertModel(models[21],_testData[29], false);
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

                var models =  ((ISingleListrealArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
SinglerealArray2M.AssertModel(models[0],_testData[16], false);SinglerealArray2M.AssertModel(models[1],_testData[17], false);SinglerealArray2M.AssertModel(models[2],_testData[18], false);SinglerealArray2M.AssertModel(models[3],_testData[19], false);SinglerealArray2M.AssertModel(models[4],_testData[20], false);SinglerealArray2M.AssertModel(models[5],_testData[21], false);SinglerealArray2M.AssertModel(models[6],_testData[22], false);SinglerealArray2M.AssertModel(models[7],_testData[23], false);SinglerealArray2M.AssertModel(models[8],_testData[24], false);SinglerealArray2M.AssertModel(models[9],_testData[25], false);SinglerealArray2M.AssertModel(models[10],_testData[26], false);SinglerealArray2M.AssertModel(models[11],_testData[27], false);SinglerealArray2M.AssertModel(models[12],_testData[28], false);SinglerealArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
SinglerealArray2M.AssertModel(models[0],_testData[12], false);SinglerealArray2M.AssertModel(models[1],_testData[13], false);SinglerealArray2M.AssertModel(models[2],_testData[14], false);SinglerealArray2M.AssertModel(models[3],_testData[15], false);SinglerealArray2M.AssertModel(models[4],_testData[16], false);SinglerealArray2M.AssertModel(models[5],_testData[17], false);SinglerealArray2M.AssertModel(models[6],_testData[18], false);SinglerealArray2M.AssertModel(models[7],_testData[19], false);SinglerealArray2M.AssertModel(models[8],_testData[20], false);SinglerealArray2M.AssertModel(models[9],_testData[21], false);SinglerealArray2M.AssertModel(models[10],_testData[22], false);SinglerealArray2M.AssertModel(models[11],_testData[23], false);SinglerealArray2M.AssertModel(models[12],_testData[24], false);SinglerealArray2M.AssertModel(models[13],_testData[25], false);SinglerealArray2M.AssertModel(models[14],_testData[26], false);SinglerealArray2M.AssertModel(models[15],_testData[27], false);SinglerealArray2M.AssertModel(models[16],_testData[28], false);SinglerealArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray2m m
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
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
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 50, query1, 19, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatSinglerealArray2M.AssertModel(models[0],_testData[13], false);FlatSinglerealArray2M.AssertModel(models[1],_testData[14], false);FlatSinglerealArray2M.AssertModel(models[2],_testData[15], false);FlatSinglerealArray2M.AssertModel(models[3],_testData[16], false);FlatSinglerealArray2M.AssertModel(models[4],_testData[17], false);FlatSinglerealArray2M.AssertModel(models[5],_testData[18], false);FlatSinglerealArray2M.AssertModel(models[6],_testData[19], false);FlatSinglerealArray2M.AssertModel(models[7],_testData[20], false);FlatSinglerealArray2M.AssertModel(models[8],_testData[21], false);FlatSinglerealArray2M.AssertModel(models[9],_testData[22], false);FlatSinglerealArray2M.AssertModel(models[10],_testData[23], false);FlatSinglerealArray2M.AssertModel(models[11],_testData[24], false);FlatSinglerealArray2M.AssertModel(models[12],_testData[25], false);FlatSinglerealArray2M.AssertModel(models[13],_testData[26], false);FlatSinglerealArray2M.AssertModel(models[14],_testData[27], false);FlatSinglerealArray2M.AssertModel(models[15],_testData[28], false);FlatSinglerealArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatSinglerealArray2M.AssertModel(models[0],_testData[7], false);FlatSinglerealArray2M.AssertModel(models[1],_testData[8], false);FlatSinglerealArray2M.AssertModel(models[2],_testData[9], false);FlatSinglerealArray2M.AssertModel(models[3],_testData[10], false);FlatSinglerealArray2M.AssertModel(models[4],_testData[11], false);FlatSinglerealArray2M.AssertModel(models[5],_testData[12], false);FlatSinglerealArray2M.AssertModel(models[6],_testData[13], false);FlatSinglerealArray2M.AssertModel(models[7],_testData[14], false);FlatSinglerealArray2M.AssertModel(models[8],_testData[15], false);FlatSinglerealArray2M.AssertModel(models[9],_testData[16], false);FlatSinglerealArray2M.AssertModel(models[10],_testData[17], false);FlatSinglerealArray2M.AssertModel(models[11],_testData[18], false);FlatSinglerealArray2M.AssertModel(models[12],_testData[19], false);FlatSinglerealArray2M.AssertModel(models[13],_testData[20], false);FlatSinglerealArray2M.AssertModel(models[14],_testData[21], false);FlatSinglerealArray2M.AssertModel(models[15],_testData[22], false);FlatSinglerealArray2M.AssertModel(models[16],_testData[23], false);FlatSinglerealArray2M.AssertModel(models[17],_testData[24], false);FlatSinglerealArray2M.AssertModel(models[18],_testData[25], false);FlatSinglerealArray2M.AssertModel(models[19],_testData[26], false);FlatSinglerealArray2M.AssertModel(models[20],_testData[27], false);FlatSinglerealArray2M.AssertModel(models[21],_testData[28], false);FlatSinglerealArray2M.AssertModel(models[22],_testData[29], false);
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
FROM public.singlerealarray2m m
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((ISingleListrealArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray2m m
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
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
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelBatch(connection, 16, query1, 70, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatSinglerealArray2M.AssertModel(models[0],_testData[6], false);FlatSinglerealArray2M.AssertModel(models[1],_testData[7], false);FlatSinglerealArray2M.AssertModel(models[2],_testData[8], false);FlatSinglerealArray2M.AssertModel(models[3],_testData[9], false);FlatSinglerealArray2M.AssertModel(models[4],_testData[10], false);FlatSinglerealArray2M.AssertModel(models[5],_testData[11], false);FlatSinglerealArray2M.AssertModel(models[6],_testData[12], false);FlatSinglerealArray2M.AssertModel(models[7],_testData[13], false);FlatSinglerealArray2M.AssertModel(models[8],_testData[14], false);FlatSinglerealArray2M.AssertModel(models[9],_testData[15], false);FlatSinglerealArray2M.AssertModel(models[10],_testData[16], false);FlatSinglerealArray2M.AssertModel(models[11],_testData[17], false);FlatSinglerealArray2M.AssertModel(models[12],_testData[18], false);FlatSinglerealArray2M.AssertModel(models[13],_testData[19], false);FlatSinglerealArray2M.AssertModel(models[14],_testData[20], false);FlatSinglerealArray2M.AssertModel(models[15],_testData[21], false);FlatSinglerealArray2M.AssertModel(models[16],_testData[22], false);FlatSinglerealArray2M.AssertModel(models[17],_testData[23], false);FlatSinglerealArray2M.AssertModel(models[18],_testData[24], false);FlatSinglerealArray2M.AssertModel(models[19],_testData[25], false);FlatSinglerealArray2M.AssertModel(models[20],_testData[26], false);FlatSinglerealArray2M.AssertModel(models[21],_testData[27], false);FlatSinglerealArray2M.AssertModel(models[22],_testData[28], false);FlatSinglerealArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatSinglerealArray2M.AssertModel(models[0],_testData[16], false);FlatSinglerealArray2M.AssertModel(models[1],_testData[17], false);FlatSinglerealArray2M.AssertModel(models[2],_testData[18], false);FlatSinglerealArray2M.AssertModel(models[3],_testData[19], false);FlatSinglerealArray2M.AssertModel(models[4],_testData[20], false);FlatSinglerealArray2M.AssertModel(models[5],_testData[21], false);FlatSinglerealArray2M.AssertModel(models[6],_testData[22], false);FlatSinglerealArray2M.AssertModel(models[7],_testData[23], false);FlatSinglerealArray2M.AssertModel(models[8],_testData[24], false);FlatSinglerealArray2M.AssertModel(models[9],_testData[25], false);FlatSinglerealArray2M.AssertModel(models[10],_testData[26], false);FlatSinglerealArray2M.AssertModel(models[11],_testData[27], false);FlatSinglerealArray2M.AssertModel(models[12],_testData[28], false);FlatSinglerealArray2M.AssertModel(models[13],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleListrealArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSelectModelBatchAsync(connection, 97, 54))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
SinglerealArray2M.AssertModel(models[0],_testData[22], false);SinglerealArray2M.AssertModel(models[1],_testData[23], false);SinglerealArray2M.AssertModel(models[2],_testData[24], false);SinglerealArray2M.AssertModel(models[3],_testData[25], false);SinglerealArray2M.AssertModel(models[4],_testData[26], false);SinglerealArray2M.AssertModel(models[5],_testData[27], false);SinglerealArray2M.AssertModel(models[6],_testData[28], false);SinglerealArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
SinglerealArray2M.AssertModel(models[0],_testData[14], false);SinglerealArray2M.AssertModel(models[1],_testData[15], false);SinglerealArray2M.AssertModel(models[2],_testData[16], false);SinglerealArray2M.AssertModel(models[3],_testData[17], false);SinglerealArray2M.AssertModel(models[4],_testData[18], false);SinglerealArray2M.AssertModel(models[5],_testData[19], false);SinglerealArray2M.AssertModel(models[6],_testData[20], false);SinglerealArray2M.AssertModel(models[7],_testData[21], false);SinglerealArray2M.AssertModel(models[8],_testData[22], false);SinglerealArray2M.AssertModel(models[9],_testData[23], false);SinglerealArray2M.AssertModel(models[10],_testData[24], false);SinglerealArray2M.AssertModel(models[11],_testData[25], false);SinglerealArray2M.AssertModel(models[12],_testData[26], false);SinglerealArray2M.AssertModel(models[13],_testData[27], false);SinglerealArray2M.AssertModel(models[14],_testData[28], false);SinglerealArray2M.AssertModel(models[15],_testData[29], false);
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
                var models =  ((ISingleListrealArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSelectModelBatch(connection, 97, 123))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
SinglerealArray2M.AssertModel(models[0],_testData[22], false);SinglerealArray2M.AssertModel(models[1],_testData[23], false);SinglerealArray2M.AssertModel(models[2],_testData[24], false);SinglerealArray2M.AssertModel(models[3],_testData[25], false);SinglerealArray2M.AssertModel(models[4],_testData[26], false);SinglerealArray2M.AssertModel(models[5],_testData[27], false);SinglerealArray2M.AssertModel(models[6],_testData[28], false);SinglerealArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
SinglerealArray2M.AssertModel(models[0],_testData[28], false);SinglerealArray2M.AssertModel(models[1],_testData[29], false);
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
                ((ISingleListrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 32);
                var models = await ((ISingleListrealArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
SinglerealArray2M.AssertModel(models[0],_testData[10], false);SinglerealArray2M.AssertModel(models[1],_testData[11], false);SinglerealArray2M.AssertModel(models[2],_testData[12], false);SinglerealArray2M.AssertModel(models[3],_testData[13], false);SinglerealArray2M.AssertModel(models[4],_testData[14], false);SinglerealArray2M.AssertModel(models[5],_testData[15], false);SinglerealArray2M.AssertModel(models[6],_testData[16], false);SinglerealArray2M.AssertModel(models[7],_testData[17], false);SinglerealArray2M.AssertModel(models[8],_testData[18], false);SinglerealArray2M.AssertModel(models[9],_testData[19], false);SinglerealArray2M.AssertModel(models[10],_testData[20], false);SinglerealArray2M.AssertModel(models[11],_testData[21], false);SinglerealArray2M.AssertModel(models[12],_testData[22], false);SinglerealArray2M.AssertModel(models[13],_testData[23], false);SinglerealArray2M.AssertModel(models[14],_testData[24], false);SinglerealArray2M.AssertModel(models[15],_testData[25], false);SinglerealArray2M.AssertModel(models[16],_testData[26], false);SinglerealArray2M.AssertModel(models[17],_testData[27], false);SinglerealArray2M.AssertModel(models[18],_testData[28], false);SinglerealArray2M.AssertModel(models[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleListrealArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleListrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 15);
                var models =  ((ISingleListrealArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
SinglerealArray2M.AssertModel(models[0],_testData[5], false);SinglerealArray2M.AssertModel(models[1],_testData[6], false);SinglerealArray2M.AssertModel(models[2],_testData[7], false);SinglerealArray2M.AssertModel(models[3],_testData[8], false);SinglerealArray2M.AssertModel(models[4],_testData[9], false);SinglerealArray2M.AssertModel(models[5],_testData[10], false);SinglerealArray2M.AssertModel(models[6],_testData[11], false);SinglerealArray2M.AssertModel(models[7],_testData[12], false);SinglerealArray2M.AssertModel(models[8],_testData[13], false);SinglerealArray2M.AssertModel(models[9],_testData[14], false);SinglerealArray2M.AssertModel(models[10],_testData[15], false);SinglerealArray2M.AssertModel(models[11],_testData[16], false);SinglerealArray2M.AssertModel(models[12],_testData[17], false);SinglerealArray2M.AssertModel(models[13],_testData[18], false);SinglerealArray2M.AssertModel(models[14],_testData[19], false);SinglerealArray2M.AssertModel(models[15],_testData[20], false);SinglerealArray2M.AssertModel(models[16],_testData[21], false);SinglerealArray2M.AssertModel(models[17],_testData[22], false);SinglerealArray2M.AssertModel(models[18],_testData[23], false);SinglerealArray2M.AssertModel(models[19],_testData[24], false);SinglerealArray2M.AssertModel(models[20],_testData[25], false);SinglerealArray2M.AssertModel(models[21],_testData[26], false);SinglerealArray2M.AssertModel(models[22],_testData[27], false);SinglerealArray2M.AssertModel(models[23],_testData[28], false);SinglerealArray2M.AssertModel(models[24],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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

