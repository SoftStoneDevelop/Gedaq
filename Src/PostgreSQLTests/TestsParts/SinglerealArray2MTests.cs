

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
new System.Collections.Generic.List<System.Single>(3)
{
0.1887086f,

0.6918879f,

0.8791729f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6544731f,

0.32559437f,

0.72538036f,

0.26032895f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7105752f,

0.035019398f,

0.2988599f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8997582f,

0.36519265f,

0.6235009f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.7248862f,

0.38143688f,

0.63640535f,

0.60038567f,

},
},
            new SinglerealArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.26668787f,

0.2121805f,

0.47233278f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.79734266f,

0.36532277f,

0.038613677f,

},
},
            new SinglerealArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.4981941f,

0.6889578f,

0.7269277f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.73570484f,

0.3828556f,

0.004306793f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9855809f,

0.8502071f,

0.6912371f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.60272545f,

0.04209912f,

0.24153465f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.470316f,

0.22302413f,

0.623563f,

0.2092725f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.043320537f,

0.65107954f,

0.59674555f,

0.7463344f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.28022707f,

0.92482466f,

0.57046306f,

0.42453045f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.10051131f,

0.9441779f,

0.564822f,

0.19052076f,

},
},
            new SinglerealArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.58751947f,

0.53139514f,

0.94339937f,

0.54545784f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.11431527f,

0.48681498f,

0.022202373f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.17413056f,

0.021940887f,

0.497455f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.768788f,

0.7123727f,

0.295614f,

0.32922083f,

},
},
            new SinglerealArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.7683879f,

0.50862443f,

0.49263132f,

0.8522522f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5569702f,

0.27475077f,

0.518649f,

0.04957819f,

},
},
            new SinglerealArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.17214745f,

0.16739166f,

0.036262333f,

0.15005422f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.50556743f,

0.7878738f,

0.25861245f,

0.0071050525f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.86123943f,

0.2842663f,

0.08942664f,

0.15798378f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2069605f,

0.03283274f,

0.4105615f,

0.85164464f,

},
},
            new SinglerealArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.24024707f,

0.5092316f,

0.19712281f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.85788864f,

0.8608529f,

0.6147754f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.4175012f,

0.7572774f,

0.29060918f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.44351077f,

0.9627612f,

0.01088053f,

0.2242096f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9124557f,

0.8509665f,

0.20974612f,

0.47555107f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.68218195f,

0.82260746f,

0.79014826f,

},
},
            new SinglerealArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.7215625f,

0.14307445f,

0.7830455f,

0.6889413f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.95927787f,

0.13618451f,

0.97730386f,

0.11238289f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.2585727f,

0.20366633f,

0.05951667f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.30876595f,

0.9991466f,

0.012558162f,

0.9271823f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.40754914f,

0.3351875f,

0.8094535f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.6997935f,

0.3056258f,

0.4084506f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.38925463f,

0.7822114f,

0.29961717f,

0.3340096f,

},
},
            new SinglerealArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.43624997f,

0.6604395f,

0.06688106f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.6969558f,

0.07118589f,

0.27702004f,

},
},
            new SinglerealArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.40451407f,

0.44824338f,

0.10334802f,

0.6328223f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.40419167f,

0.20760846f,

0.6214298f,

0.9653408f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.24331671f,

0.6018219f,

0.0014582276f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9722951f,

0.54805946f,

0.64078975f,

0.12775779f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.61814696f,

0.07531059f,

0.6356255f,

0.25408036f,

},
},
            new SinglerealArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5279603f,

0.8180278f,

0.5004551f,

0.05423045f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.054576576f,

0.5794351f,

0.98197377f,

0.37567896f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.6501258f,

0.101807f,

0.5227786f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.96018505f,

0.60475683f,

0.15804762f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.43379807f,

0.35072112f,

0.94334084f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3278488f,

0.6986599f,

0.6728376f,

0.26213413f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5962683f,

0.39250982f,

0.723141f,

},
},
            new SinglerealArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.7372823f,

0.18207645f,

0.52196205f,

0.3469646f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.1072194f,

0.5075856f,

0.88929933f,

},
},
            new SinglerealArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.51647717f,

0.34702665f,

0.93643105f,

0.8424445f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9144958f,

0.7282007f,

0.6444131f,

0.18861145f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3740114f,

0.18165213f,

0.59196067f,

0.7716749f,

},
},
            new SinglerealArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.44784552f,

0.8111389f,

0.92553246f,

0.59179443f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.05493492f,

0.09774834f,

0.1800794f,

0.44242132f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8427986f,

0.12716746f,

0.9923263f,

0.18747824f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.420556f,

0.44547004f,

0.53249633f,

0.7351334f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5292064f,

0.67226726f,

0.56061256f,

0.95098877f,

},
},
            new SinglerealArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.16482824f,

0.5138626f,

0.697694f,

0.4928959f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9564218f,

0.8544262f,

0.2416116f,

0.8231308f,

},
},
            new SinglerealArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.16904724f,

0.8055786f,

0.6859005f,

0.7409858f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3404696f,

0.17518258f,

0.21511924f,

0.543437f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.84430563f,

0.06513715f,

0.75186336f,

},
},
            new SinglerealArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.033929884f,

0.16069353f,

0.6568456f,

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
0.80433106f,

0.10746378f,

0.72710747f,

0.4281317f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13407338f,

0.9466994f,

0.85851f,

0.8782564f,

},
    NullableValue = null,
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[25],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[29], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[29], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[13],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[14],_testData[29], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[29], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[13],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[14],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[15],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[16],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[17],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[18],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[19],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[29], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[29], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        SinglerealArray2M.AssertModel(models[0],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        SinglerealArray2M.AssertModel(models[0],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[29], false);
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
                await ((ISingleListrealArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 131, query1, 2, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[28],_testData[29], false);
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
                await ((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 147, query1, 2, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[29], false);
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
                 ((ISingleListrealArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 38, query1, 83, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[29], false);
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
                 ((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 29, query1, 2, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[24],_testData[29], false);
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
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 107, query1, 141, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[29], false);
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
                await ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 147, query1, 2, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[28],_testData[29], false);
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
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 80, query1, 145, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[13],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[29], false);
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
                 ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelBatch(connection, 91, query1, 52, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[18],_testData[29], false);
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
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSTSelectModelBatchAsync(connection, 20, 2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        SinglerealArray2M.AssertModel(models[0],_testData[4], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[5], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[6], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[7], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[8], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[9], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[10], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[11], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[12], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[13], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[14], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[15], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[16], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[17], false);
                        SinglerealArray2M.AssertModel(models[14],_testData[18], false);
                        SinglerealArray2M.AssertModel(models[15],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[16],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[17],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[18],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[19],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[20],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[21],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[22],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[23],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[24],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSTSelectModelBatch(connection, 68, 106))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        SinglerealArray2M.AssertModel(models[0],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[29], false);
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
                ((ISingleListrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 4);
                var models = await ((ISingleListrealArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
SinglerealArray2M.AssertModel(models[0],_testData[2], false);SinglerealArray2M.AssertModel(models[1],_testData[3], false);SinglerealArray2M.AssertModel(models[2],_testData[4], false);SinglerealArray2M.AssertModel(models[3],_testData[5], false);SinglerealArray2M.AssertModel(models[4],_testData[6], false);SinglerealArray2M.AssertModel(models[5],_testData[7], false);SinglerealArray2M.AssertModel(models[6],_testData[8], false);SinglerealArray2M.AssertModel(models[7],_testData[9], false);SinglerealArray2M.AssertModel(models[8],_testData[10], false);SinglerealArray2M.AssertModel(models[9],_testData[11], false);SinglerealArray2M.AssertModel(models[10],_testData[12], false);SinglerealArray2M.AssertModel(models[11],_testData[13], false);SinglerealArray2M.AssertModel(models[12],_testData[14], false);SinglerealArray2M.AssertModel(models[13],_testData[15], false);SinglerealArray2M.AssertModel(models[14],_testData[16], false);SinglerealArray2M.AssertModel(models[15],_testData[17], false);SinglerealArray2M.AssertModel(models[16],_testData[18], false);SinglerealArray2M.AssertModel(models[17],_testData[19], false);SinglerealArray2M.AssertModel(models[18],_testData[20], false);SinglerealArray2M.AssertModel(models[19],_testData[21], false);SinglerealArray2M.AssertModel(models[20],_testData[22], false);SinglerealArray2M.AssertModel(models[21],_testData[23], false);SinglerealArray2M.AssertModel(models[22],_testData[24], false);SinglerealArray2M.AssertModel(models[23],_testData[25], false);SinglerealArray2M.AssertModel(models[24],_testData[26], false);SinglerealArray2M.AssertModel(models[25],_testData[27], false);SinglerealArray2M.AssertModel(models[26],_testData[28], false);SinglerealArray2M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleListrealArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleListrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 52);
                var models =  ((ISingleListrealArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
SinglerealArray2M.AssertModel(models[0],_testData[11], false);SinglerealArray2M.AssertModel(models[1],_testData[12], false);SinglerealArray2M.AssertModel(models[2],_testData[13], false);SinglerealArray2M.AssertModel(models[3],_testData[14], false);SinglerealArray2M.AssertModel(models[4],_testData[15], false);SinglerealArray2M.AssertModel(models[5],_testData[16], false);SinglerealArray2M.AssertModel(models[6],_testData[17], false);SinglerealArray2M.AssertModel(models[7],_testData[18], false);SinglerealArray2M.AssertModel(models[8],_testData[19], false);SinglerealArray2M.AssertModel(models[9],_testData[20], false);SinglerealArray2M.AssertModel(models[10],_testData[21], false);SinglerealArray2M.AssertModel(models[11],_testData[22], false);SinglerealArray2M.AssertModel(models[12],_testData[23], false);SinglerealArray2M.AssertModel(models[13],_testData[24], false);SinglerealArray2M.AssertModel(models[14],_testData[25], false);SinglerealArray2M.AssertModel(models[15],_testData[26], false);SinglerealArray2M.AssertModel(models[16],_testData[27], false);SinglerealArray2M.AssertModel(models[17],_testData[28], false);SinglerealArray2M.AssertModel(models[18],_testData[29], false);
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

