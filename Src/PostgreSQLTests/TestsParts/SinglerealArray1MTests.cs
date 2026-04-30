

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
    internal partial interface ISingleArrayrealArray
    {
    }
    
    internal partial class SingleArrayrealArray : ISingleArrayrealArray
    {


#region TestData

        private readonly SinglerealArray1M[] _testData = new SinglerealArray1M[]
        {
            new SinglerealArray1M
{
    Id = 9,
    Value = 
new System.Single[4]
{
0.9604455f,
0.39039397f,
0.17720121f,
0.75701964f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 14,
    Value = 
new System.Single[3]
{
0.41850275f,
0.7436438f,
0.8696271f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 1,
    Value = 
new System.Single[3]
{
0.5888827f,
0.25850415f,
0.10402697f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.49957937f,
0.7443664f,
0.46346617f,
0.2603941f,
},
},
            new SinglerealArray1M
{
    Id = 21,
    Value = 
new System.Single[4]
{
0.89719814f,
0.7427994f,
0.32126224f,
0.5223949f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 23,
    Value = 
new System.Single[4]
{
0.49550986f,
0.9959539f,
0.13220644f,
0.23583537f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 9,
    Value = 
new System.Single[4]
{
0.6120511f,
0.27819967f,
0.9014831f,
0.3798012f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.40803748f,
0.2833166f,
0.9567117f,
0.21922922f,
},
},
            new SinglerealArray1M
{
    Id = 31,
    Value = 
new System.Single[4]
{
0.33986336f,
0.45861846f,
0.19036967f,
0.6858752f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.6188839f,
0.3483714f,
0.9489771f,
},
},
            new SinglerealArray1M
{
    Id = 37,
    Value = 
new System.Single[4]
{
0.0060910583f,
0.7501073f,
0.9650169f,
0.46061653f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 13,
    Value = 
new System.Single[3]
{
0.8457332f,
0.24726295f,
0.39756203f,
},
    NullableValue = 
new System.Single[3]
{
0.6192435f,
0.7099823f,
0.24597287f,
},
},
    NullableValue = 
new System.Single[4]
{
0.9291957f,
0.8450528f,
0.47545522f,
0.14953756f,
},
},
            new SinglerealArray1M
{
    Id = 38,
    Value = 
new System.Single[4]
{
0.1795733f,
0.4965645f,
0.5924033f,
0.07996929f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.86431295f,
0.054231763f,
0.9951571f,
},
},
            new SinglerealArray1M
{
    Id = 40,
    Value = 
new System.Single[3]
{
0.17358375f,
0.44958317f,
0.940901f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 14,
    Value = 
new System.Single[4]
{
0.36890018f,
0.01584512f,
0.701004f,
0.5463015f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.03721422f,
0.93396443f,
0.010414124f,
},
},
            new SinglerealArray1M
{
    Id = 43,
    Value = 
new System.Single[3]
{
0.8497943f,
0.25599957f,
0.5662902f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 50,
    Value = 
new System.Single[4]
{
0.59149456f,
0.20920235f,
0.052205086f,
0.06610584f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 15,
    Value = 
new System.Single[4]
{
0.72576267f,
0.5480622f,
0.2860064f,
0.919505f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 53,
    Value = 
new System.Single[3]
{
0.6255897f,
0.97712326f,
0.543949f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.2304427f,
0.093943834f,
0.40862304f,
},
},
            new SinglerealArray1M
{
    Id = 56,
    Value = 
new System.Single[4]
{
0.7272677f,
0.5307436f,
0.9493685f,
0.6351269f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 20,
    Value = 
new System.Single[3]
{
0.6207022f,
0.09023231f,
0.81443226f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.8503741f,
0.097289085f,
0.4239502f,
0.1351232f,
},
},
            new SinglerealArray1M
{
    Id = 61,
    Value = 
new System.Single[3]
{
0.61331624f,
0.56178623f,
0.75630724f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.72475463f,
0.4017554f,
0.057516456f,
0.6069965f,
},
},
            new SinglerealArray1M
{
    Id = 66,
    Value = 
new System.Single[3]
{
0.27340722f,
0.3438366f,
0.83982146f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 26,
    Value = 
new System.Single[3]
{
0.00867337f,
0.42226392f,
0.80290854f,
},
    NullableValue = 
new System.Single[3]
{
0.34663182f,
0.21742827f,
0.44985402f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 68,
    Value = 
new System.Single[3]
{
0.9891471f,
0.034017622f,
0.47570795f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.30107874f,
0.6805166f,
0.0517084f,
0.8737072f,
},
},
            new SinglerealArray1M
{
    Id = 77,
    Value = 
new System.Single[3]
{
0.21911132f,
0.30187643f,
0.87699723f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 27,
    Value = 
new System.Single[3]
{
0.872386f,
0.004414737f,
0.4960106f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.030657947f,
0.8632207f,
0.3693483f,
},
},
            new SinglerealArray1M
{
    Id = 80,
    Value = 
new System.Single[4]
{
0.33540887f,
0.54041517f,
0.5607598f,
0.57366407f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 87,
    Value = 
new System.Single[3]
{
0.033547103f,
0.37718534f,
0.23495543f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 35,
    Value = 
new System.Single[4]
{
0.34736222f,
0.69555867f,
0.41193485f,
0.07662761f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.20379144f,
0.38030672f,
0.83079535f,
},
},
            new SinglerealArray1M
{
    Id = 93,
    Value = 
new System.Single[3]
{
0.24170089f,
0.7634105f,
0.043640316f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 96,
    Value = 
new System.Single[3]
{
0.65906376f,
0.18881619f,
0.2747193f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 41,
    Value = 
new System.Single[4]
{
0.23942256f,
0.64197636f,
0.8111394f,
0.32673788f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 103,
    Value = 
new System.Single[3]
{
0.3761822f,
0.21417677f,
0.105600774f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 112,
    Value = 
new System.Single[4]
{
0.86334f,
0.20777571f,
0.12285811f,
0.63191646f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 48,
    Value = 
new System.Single[3]
{
0.38837415f,
0.61301327f,
0.35419786f,
},
    NullableValue = 
new System.Single[4]
{
0.11177063f,
0.8362465f,
0.10774022f,
0.6035637f,
},
},
    NullableValue = 
new System.Single[4]
{
0.57802355f,
0.8587438f,
0.5817161f,
0.33852416f,
},
},
            new SinglerealArray1M
{
    Id = 120,
    Value = 
new System.Single[4]
{
0.8786707f,
0.4519537f,
0.83167017f,
0.049479127f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 121,
    Value = 
new System.Single[3]
{
0.09045428f,
0.71582943f,
0.29924804f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 57,
    Value = 
new System.Single[3]
{
0.15924692f,
0.16588616f,
0.4333238f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 125,
    Value = 
new System.Single[4]
{
0.5599784f,
0.2593993f,
0.7989919f,
0.38165194f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.82894623f,
0.21422273f,
0.27199805f,
0.30756825f,
},
},
            new SinglerealArray1M
{
    Id = 131,
    Value = 
new System.Single[4]
{
0.20725447f,
0.73416656f,
0.3606984f,
0.8455988f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 61,
    Value = 
new System.Single[4]
{
0.6176988f,
0.74673885f,
0.8948092f,
0.33423322f,
},
    NullableValue = 
new System.Single[3]
{
0.023841083f,
0.7674131f,
0.017864347f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 140,
    Value = 
new System.Single[3]
{
0.507019f,
0.90292126f,
0.17162299f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 141,
    Value = 
new System.Single[3]
{
0.039992213f,
0.20882034f,
0.6365497f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 69,
    Value = 
new System.Single[4]
{
0.7584789f,
0.3282925f,
0.96789694f,
0.9659303f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.98339766f,
0.47082192f,
0.08336043f,
},
},
            new SinglerealArray1M
{
    Id = 142,
    Value = 
new System.Single[4]
{
0.11794561f,
0.7984518f,
0.47860456f,
0.95951366f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.44322395f,
0.52181965f,
0.17513627f,
},
},
            new SinglerealArray1M
{
    Id = 145,
    Value = 
new System.Single[3]
{
0.9863099f,
0.38357323f,
0.71913123f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 74,
    Value = 
new System.Single[4]
{
0.6551073f,
0.5896768f,
0.20962512f,
0.8071537f,
},
    NullableValue = 
new System.Single[3]
{
0.93077844f,
0.25057518f,
0.7595569f,
},
},
    NullableValue = 
new System.Single[3]
{
0.9703583f,
0.86062676f,
0.17657262f,
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray1mi(
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
            asPartInterface: typeof(ISingleArrayrealArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray1mi(
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
            queryMapTypes: [typeof(SinglerealArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[]), 
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

                changedRows =  ((ISingleArrayrealArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleArrayrealArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ISingleArrayrealArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleArrayrealArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ISingleArrayrealArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ISingleArrayrealArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray1m(
	id,
    value,
    nullablevalue,
    singlerealarray1mi_id
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
            asPartInterface: typeof(ISingleArrayrealArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "singlerealarray1mi_id", 
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
                changedRows =  ((ISingleArrayrealArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ISingleArrayrealArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ISingleArrayrealArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ISingleArrayrealArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray1m(
	id,
    value,
    nullablevalue,
    singlerealarray1mi_id
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
    singlerealarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(SinglerealArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
                System.Single[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Single[]>();
                    ((NpgsqlParameter<System.Single[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
                    ((NpgsqlParameter<System.Single[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
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

                    nullable =  ((ISingleArrayrealArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[3]
{
0.6188839f,
0.3483714f,
0.9489771f,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Single[]>();
                    ((NpgsqlParameter<System.Single[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
                    ((NpgsqlParameter<System.Single[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
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

                    nullable =  ((ISingleArrayrealArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[4]
{
0.9291957f,
0.8450528f,
0.47545522f,
0.14953756f,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Single[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Single[]>();
                    ((NpgsqlParameter<System.Single[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
                    ((NpgsqlParameter<System.Single[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
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

                    nullable = await ((ISingleArrayrealArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[3]
{
0.86431295f,
0.054231763f,
0.9951571f,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Single[]>();
                    ((NpgsqlParameter<System.Single[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
                    ((NpgsqlParameter<System.Single[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
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

                    nullable = await ((ISingleArrayrealArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[3]
{
0.03721422f,
0.93396443f,
0.010414124f,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray1m(
	id,
    value,
    nullablevalue,
    singlerealarray1mi_id
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
    singlerealarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(SinglerealArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "singlerealarray1mi_id", 
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
                System.Single[] nullable = null;
                nullable =  ((ISingleArrayrealArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((ISingleArrayrealArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Single[] nullable = null;
                nullable = await ((ISingleArrayrealArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[3]
{
0.2304427f,
0.093943834f,
0.40862304f,
}));
                nullable = await ((ISingleArrayrealArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[4]
{
0.8503741f,
0.097289085f,
0.4239502f,
0.1351232f,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SinglerealArray1M> models = null;

                models =  ((ISingleArrayrealArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((ISingleArrayrealArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((ISingleArrayrealArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((ISingleArrayrealArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SinglerealArray1M> models = null;

                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray1M), typeof(FlatSinglerealArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
FROM public.singlerealarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglerealArray1M>();
                var models2 = new List<FlatSinglerealArray1M>();
                await ((ISingleArrayrealArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglerealArray1M>();
                var models2 = new List<FlatSinglerealArray1M>();
                ((ISingleArrayrealArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
FROM public.singlerealarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ISingleArrayrealArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ISingleArrayrealArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(SinglerealArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
                var models = await ((ISingleArrayrealArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ISingleArrayrealArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray1M), typeof(FlatSinglerealArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
FROM public.singlerealarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealArray1M>();
                var models2 = new List<FlatSinglerealArray1M>();
                await ((ISingleArrayrealArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealArray1M>();
                var models2 = new List<FlatSinglerealArray1M>();
                ((ISingleArrayrealArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
FROM public.singlerealarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ISingleArrayrealArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ISingleArrayrealArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(SinglerealArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
                var models = await ((ISingleArrayrealArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ISingleArrayrealArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray1M), typeof(FlatSinglerealArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
            asPartInterface: typeof(ISingleArrayrealArray)),
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealArray1M>();
                var models2 = new List<FlatSinglerealArray1M>();
                await((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var firstItems2 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                var secondItems2 = new List<FlatSinglerealArray1M>();
                await ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var firstItems2 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                await ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[29], false);
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealArray1M>();
                var models2 = new List<FlatSinglerealArray1M>();
                ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var firstItems2 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                var secondItems2 = new List<FlatSinglerealArray1M>();
                 ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var firstItems2 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                 ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
            asPartInterface: typeof(ISingleArrayrealArray)),
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 77;
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[22],_testData[29], false);
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
                parametr1.Value = 50;
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                var secondItems2 = new List<FlatSinglerealArray1M>();
                await ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[29], false);
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 31;
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[22],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[23],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[1], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[2], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[22],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[23],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[24],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[25],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[26],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[27],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[28],_testData[29], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                var secondItems2 = new List<FlatSinglerealArray1M>();
                 ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[29], false);
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(SinglerealArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
                var models = await((ISingleArrayrealArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        SinglerealArray1M.AssertModel(models[0],_testData[8], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[9], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[10], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[11], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[20],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        SinglerealArray1M.AssertModel(models[0],_testData[5], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[6], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[7], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[8], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[9], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[10], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[11], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[20],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[21],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[22],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[23],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[24],_testData[29], false);
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
                var models = ((ISingleArrayrealArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        SinglerealArray1M.AssertModel(models[0],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        SinglerealArray1M.AssertModel(models[0],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray1M), typeof(FlatSinglerealArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
            asPartInterface: typeof(ISingleArrayrealArray)),
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
            asPartInterface: typeof(ISingleArrayrealArray)),
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealArray1M>();
                var models2 = new List<FlatSinglerealArray1M>();
                await((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var firstItems2 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                var secondItems2 = new List<FlatSinglerealArray1M>();
                await ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 43, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[29], false);
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var firstItems2 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                await ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 87, query1, 131, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[29], false);
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealArray1M>();
                var models2 = new List<FlatSinglerealArray1M>();
                ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var firstItems2 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                var secondItems2 = new List<FlatSinglerealArray1M>();
                 ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 66, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[29], false);
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var firstItems2 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                 ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 141, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[26],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
            asPartInterface: typeof(ISingleArrayrealArray)),
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
            asPartInterface: typeof(ISingleArrayrealArray)),
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 61, query1, 66, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[29], false);
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                var secondItems2 = new List<FlatSinglerealArray1M>();
                await ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 50, query1, 103, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[29], false);
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 96, query1, 50, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[29], false);
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                var secondItems2 = new List<FlatSinglerealArray1M>();
                 ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatch(connection, 93, query1, 121, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[29], false);
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(SinglerealArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
            asPartInterface: typeof(ISingleArrayrealArray)),
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
                var models = await((ISingleArrayrealArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTSelectModelBatchAsync(connection, 43, 14))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        SinglerealArray1M.AssertModel(models[0],_testData[9], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[10], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[11], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        SinglerealArray1M.AssertModel(models[0],_testData[2], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[3], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[4], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[5], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[6], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[7], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[8], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[9], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[10], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[11], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[20],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[21],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[22],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[23],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[24],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[25],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[26],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[27],_testData[29], false);
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
                var models = ((ISingleArrayrealArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTSelectModelBatch(connection, 21, 112))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        SinglerealArray1M.AssertModel(models[0],_testData[3], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[4], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[5], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[6], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[7], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[8], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[9], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[10], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[11], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[20],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[21],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[22],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[23],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[24],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[25],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        SinglerealArray1M.AssertModel(models[0],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[29], false);
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
                await using var cmd = await ((ISingleArrayrealArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 103);
                var models = await ((ISingleArrayrealArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
SinglerealArray1M.AssertModel(models[0],_testData[21], false);SinglerealArray1M.AssertModel(models[1],_testData[22], false);SinglerealArray1M.AssertModel(models[2],_testData[23], false);SinglerealArray1M.AssertModel(models[3],_testData[24], false);SinglerealArray1M.AssertModel(models[4],_testData[25], false);SinglerealArray1M.AssertModel(models[5],_testData[26], false);SinglerealArray1M.AssertModel(models[6],_testData[27], false);SinglerealArray1M.AssertModel(models[7],_testData[28], false);SinglerealArray1M.AssertModel(models[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleArrayrealArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 120);
                var models =  ((ISingleArrayrealArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
SinglerealArray1M.AssertModel(models[0],_testData[23], false);SinglerealArray1M.AssertModel(models[1],_testData[24], false);SinglerealArray1M.AssertModel(models[2],_testData[25], false);SinglerealArray1M.AssertModel(models[3],_testData[26], false);SinglerealArray1M.AssertModel(models[4],_testData[27], false);SinglerealArray1M.AssertModel(models[5],_testData[28], false);SinglerealArray1M.AssertModel(models[6],_testData[29], false);
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
FROM public.binary_singlerealarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(SinglerealArray1MIWA),
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
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleArrayrealArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlerealarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISingleArrayrealArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<SinglerealArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleArrayrealArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_singlerealarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleArrayrealArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_singlerealarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(SinglerealArray1MI),
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
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ISingleArrayrealArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleArrayrealArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<SinglerealArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ISingleArrayrealArray)this).ImportModelInner(connection, importCollection);
                var models = ((ISingleArrayrealArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
singlerealarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(SinglerealArray1M),
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
            asPartInterface: typeof(ISingleArrayrealArray))]
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
FROM public.binary_singlerealarray1m m
LEFT JOIN public.binary_singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(SinglerealArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<SinglerealArray1M>(15);

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
                ((ISingleArrayrealArray)this).ImportModel(connection, importCollection);
                var models = ((ISingleArrayrealArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                SinglerealArray1M.AssertModel(models[0],_testData[0], false);
                SinglerealArray1M.AssertModel(models[1],_testData[1], false);
                SinglerealArray1M.AssertModel(models[2],_testData[2], false);
                SinglerealArray1M.AssertModel(models[3],_testData[3], false);
                SinglerealArray1M.AssertModel(models[4],_testData[4], false);
                SinglerealArray1M.AssertModel(models[5],_testData[5], false);
                SinglerealArray1M.AssertModel(models[6],_testData[6], false);
                SinglerealArray1M.AssertModel(models[7],_testData[7], false);
                SinglerealArray1M.AssertModel(models[8],_testData[8], false);
                SinglerealArray1M.AssertModel(models[9],_testData[9], false);
                SinglerealArray1M.AssertModel(models[10],_testData[10], false);
                SinglerealArray1M.AssertModel(models[11],_testData[11], false);
                SinglerealArray1M.AssertModel(models[12],_testData[12], false);
                SinglerealArray1M.AssertModel(models[13],_testData[13], false);
                SinglerealArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((ISingleArrayrealArray)this).ImportModelAsync(connection, importCollection);
                models = await ((ISingleArrayrealArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                SinglerealArray1M.AssertModel(models[0],_testData[0], false);
                SinglerealArray1M.AssertModel(models[1],_testData[1], false);
                SinglerealArray1M.AssertModel(models[2],_testData[2], false);
                SinglerealArray1M.AssertModel(models[3],_testData[3], false);
                SinglerealArray1M.AssertModel(models[4],_testData[4], false);
                SinglerealArray1M.AssertModel(models[5],_testData[5], false);
                SinglerealArray1M.AssertModel(models[6],_testData[6], false);
                SinglerealArray1M.AssertModel(models[7],_testData[7], false);
                SinglerealArray1M.AssertModel(models[8],_testData[8], false);
                SinglerealArray1M.AssertModel(models[9],_testData[9], false);
                SinglerealArray1M.AssertModel(models[10],_testData[10], false);
                SinglerealArray1M.AssertModel(models[11],_testData[11], false);
                SinglerealArray1M.AssertModel(models[12],_testData[12], false);
                SinglerealArray1M.AssertModel(models[13],_testData[13], false);
                SinglerealArray1M.AssertModel(models[14],_testData[14], false);
                SinglerealArray1M.AssertModel(models[15],_testData[15], false);
                SinglerealArray1M.AssertModel(models[16],_testData[16], false);
                SinglerealArray1M.AssertModel(models[17],_testData[17], false);
                SinglerealArray1M.AssertModel(models[18],_testData[18], false);
                SinglerealArray1M.AssertModel(models[19],_testData[19], false);
                SinglerealArray1M.AssertModel(models[20],_testData[20], false);
                SinglerealArray1M.AssertModel(models[21],_testData[21], false);
                SinglerealArray1M.AssertModel(models[22],_testData[22], false);
                SinglerealArray1M.AssertModel(models[23],_testData[23], false);
                SinglerealArray1M.AssertModel(models[24],_testData[24], false);
                SinglerealArray1M.AssertModel(models[25],_testData[25], false);
                SinglerealArray1M.AssertModel(models[26],_testData[26], false);
                SinglerealArray1M.AssertModel(models[27],_testData[27], false);
                SinglerealArray1M.AssertModel(models[28],_testData[28], false);
                SinglerealArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    singlerealarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(SinglerealArray1M)],
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
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISingleArrayrealArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SinglerealArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleArrayrealArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SinglerealArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA)],
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
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleArrayrealArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_singlerealarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((ISingleArrayrealArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_singlerealarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MI)],
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
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleArrayrealArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((ISingleArrayrealArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

