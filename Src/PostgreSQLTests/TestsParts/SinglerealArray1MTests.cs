

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
    Id = 3,
    Value = 
new System.Single[3]
{
0.5323499f,
0.64226663f,
0.4778188f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.31739444f,
0.43422186f,
0.94316435f,
0.07187688f,
},
},
            new SinglerealArray1M
{
    Id = 4,
    Value = 
new System.Single[4]
{
0.82434076f,
0.4433093f,
0.24116534f,
0.57367903f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 6,
    Value = 
new System.Single[3]
{
0.41061258f,
0.8337111f,
0.11036247f,
},
    NullableValue = 
new System.Single[3]
{
0.061221004f,
0.87350464f,
0.44568378f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 7,
    Value = 
new System.Single[4]
{
0.7751799f,
0.85744077f,
0.27383542f,
0.5576429f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.57338905f,
0.30980474f,
0.9488115f,
0.2882502f,
},
},
            new SinglerealArray1M
{
    Id = 16,
    Value = 
new System.Single[3]
{
0.86242855f,
0.26470035f,
0.14186984f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 10,
    Value = 
new System.Single[4]
{
0.95718646f,
0.75865585f,
0.99789333f,
0.23694795f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.87822896f,
0.6741551f,
0.93375885f,
},
},
            new SinglerealArray1M
{
    Id = 17,
    Value = 
new System.Single[4]
{
0.21509653f,
0.22771442f,
0.6021449f,
0.3259821f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.6176283f,
0.81555045f,
0.61124164f,
0.37947613f,
},
},
            new SinglerealArray1M
{
    Id = 20,
    Value = 
new System.Single[3]
{
0.25897044f,
0.57172376f,
0.78723776f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 14,
    Value = 
new System.Single[4]
{
0.41134518f,
0.23216736f,
0.6188165f,
0.18927073f,
},
    NullableValue = 
new System.Single[3]
{
0.5780336f,
0.61423886f,
0.4436192f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 25,
    Value = 
new System.Single[3]
{
0.25785065f,
0.81994784f,
0.7122542f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 26,
    Value = 
new System.Single[4]
{
0.7969326f,
0.9473914f,
0.68957645f,
0.6020853f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 23,
    Value = 
new System.Single[3]
{
0.19415373f,
0.3257658f,
0.2795611f,
},
    NullableValue = 
new System.Single[3]
{
0.19996876f,
0.44427127f,
0.991542f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 35,
    Value = 
new System.Single[3]
{
0.37166947f,
0.65241474f,
0.9207034f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 40,
    Value = 
new System.Single[4]
{
0.5998148f,
0.14476109f,
0.9773918f,
0.14566183f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 25,
    Value = 
new System.Single[3]
{
0.7300061f,
0.5998323f,
0.6320127f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.41980517f,
0.9988901f,
0.89577323f,
},
},
            new SinglerealArray1M
{
    Id = 46,
    Value = 
new System.Single[4]
{
0.15673363f,
0.9171171f,
0.82994896f,
0.95976466f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 50,
    Value = 
new System.Single[3]
{
0.630781f,
0.003102541f,
0.47669053f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 26,
    Value = 
new System.Single[4]
{
0.7858154f,
0.07308376f,
0.35204607f,
0.25390917f,
},
    NullableValue = 
new System.Single[4]
{
0.88029414f,
0.34172404f,
0.6625776f,
0.4122553f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 55,
    Value = 
new System.Single[3]
{
0.4960314f,
0.22939795f,
0.42517835f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.85899466f,
0.23553848f,
0.043695092f,
},
},
            new SinglerealArray1M
{
    Id = 63,
    Value = 
new System.Single[4]
{
0.16186279f,
0.0015929341f,
0.83598566f,
0.9277672f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 33,
    Value = 
new System.Single[3]
{
0.529461f,
0.46966773f,
0.124433756f,
},
    NullableValue = 
new System.Single[3]
{
0.45290506f,
0.24195457f,
0.42693597f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 65,
    Value = 
new System.Single[4]
{
0.71044064f,
0.42924583f,
0.19042027f,
0.35574436f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.09629917f,
0.24915856f,
0.46787298f,
0.6624291f,
},
},
            new SinglerealArray1M
{
    Id = 74,
    Value = 
new System.Single[3]
{
0.62470526f,
0.70254487f,
0.6992481f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 40,
    Value = 
new System.Single[3]
{
0.5826855f,
0.056952298f,
0.739834f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 78,
    Value = 
new System.Single[3]
{
0.3702739f,
0.94429237f,
0.9850738f,
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
0.53646535f,
0.39858633f,
0.101121485f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 42,
    Value = 
new System.Single[4]
{
0.82951903f,
0.7329633f,
0.47222388f,
0.2202456f,
},
    NullableValue = 
new System.Single[3]
{
0.6572051f,
0.56916887f,
0.5253689f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 95,
    Value = 
new System.Single[4]
{
0.30543035f,
0.831085f,
0.6889744f,
0.47589302f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 97,
    Value = 
new System.Single[3]
{
0.9928789f,
0.8594999f,
0.80024016f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 49,
    Value = 
new System.Single[3]
{
0.93034476f,
0.59622806f,
0.56453425f,
},
    NullableValue = 
new System.Single[4]
{
0.7441174f,
0.038947165f,
0.810414f,
0.81999296f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 101,
    Value = 
new System.Single[3]
{
0.29482418f,
0.23954982f,
0.9344653f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.60716045f,
0.011459053f,
0.91131085f,
},
},
            new SinglerealArray1M
{
    Id = 103,
    Value = 
new System.Single[3]
{
0.88578314f,
0.42374635f,
0.78389984f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 57,
    Value = 
new System.Single[3]
{
0.19069827f,
0.39231473f,
0.6900791f,
},
    NullableValue = 
new System.Single[3]
{
0.070966065f,
0.79537714f,
0.31135887f,
},
},
    NullableValue = 
new System.Single[4]
{
0.95199f,
0.45948333f,
0.020357966f,
0.7813051f,
},
},
            new SinglerealArray1M
{
    Id = 110,
    Value = 
new System.Single[3]
{
0.21462995f,
0.4871456f,
0.6155374f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.42083108f,
0.196248f,
0.5757678f,
},
},
            new SinglerealArray1M
{
    Id = 113,
    Value = 
new System.Single[4]
{
0.72672784f,
0.71051633f,
0.61339766f,
0.43726176f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 62,
    Value = 
new System.Single[4]
{
0.080929756f,
0.85458595f,
0.7466208f,
0.9292486f,
},
    NullableValue = 
new System.Single[3]
{
0.8513186f,
0.9847256f,
0.055691898f,
},
},
    NullableValue = 
new System.Single[4]
{
0.14351767f,
0.30054963f,
0.4731444f,
0.37725365f,
},
},
            new SinglerealArray1M
{
    Id = 121,
    Value = 
new System.Single[4]
{
0.87652713f,
0.84799993f,
0.1219669f,
0.34814364f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.03726822f,
0.55408543f,
0.85899174f,
},
},
            new SinglerealArray1M
{
    Id = 123,
    Value = 
new System.Single[3]
{
0.43884498f,
0.49853957f,
0.13118309f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 66,
    Value = 
new System.Single[4]
{
0.060857534f,
0.50630057f,
0.42404467f,
0.74152046f,
},
    NullableValue = 
new System.Single[4]
{
0.38016057f,
0.65192914f,
0.5103361f,
0.1824553f,
},
},
    NullableValue = 
new System.Single[4]
{
0.7767767f,
0.16285795f,
0.9737095f,
0.42068738f,
},
},
            new SinglerealArray1M
{
    Id = 124,
    Value = 
new System.Single[4]
{
0.31534904f,
0.40549564f,
0.5396467f,
0.9481214f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 127,
    Value = 
new System.Single[3]
{
0.3058222f,
0.5499005f,
0.58840847f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 72,
    Value = 
new System.Single[3]
{
0.8467996f,
0.52206814f,
0.14548916f,
},
    NullableValue = 
new System.Single[3]
{
0.80313855f,
0.45576298f,
0.1103307f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 133,
    Value = 
new System.Single[4]
{
0.44030255f,
0.31379914f,
0.93978786f,
0.7746133f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.35525233f,
0.5501247f,
0.8458006f,
0.5866481f,
},
},
            new SinglerealArray1M
{
    Id = 140,
    Value = 
new System.Single[3]
{
0.40571237f,
0.26482284f,
0.9640954f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 78,
    Value = 
new System.Single[4]
{
0.34670436f,
0.6429987f,
0.06646496f,
0.5726509f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.4579205f,
0.4614181f,
0.5216188f,
0.6474524f,
},
},
            new SinglerealArray1M
{
    Id = 146,
    Value = 
new System.Single[3]
{
0.68386245f,
0.30491942f,
0.56647265f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.9704438f,
0.23620689f,
0.8286775f,
0.46530515f,
},
},
            new SinglerealArray1M
{
    Id = 148,
    Value = 
new System.Single[4]
{
0.9570628f,
0.19145793f,
0.35543716f,
0.4745853f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 82,
    Value = 
new System.Single[4]
{
0.52761966f,
0.13790232f,
0.70283854f,
0.35229468f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 154,
    Value = 
new System.Single[3]
{
0.26499826f,
0.5152844f,
0.6886414f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 163,
    Value = 
new System.Single[4]
{
0.016175508f,
0.93362534f,
0.5943106f,
0.45802402f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 85,
    Value = 
new System.Single[4]
{
0.28036946f,
0.36303067f,
0.60003453f,
0.116448045f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 166,
    Value = 
new System.Single[4]
{
0.5546801f,
0.51318103f,
0.21106213f,
0.59619623f,
},
    ModelInner = null,
    NullableValue = null,
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

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
new System.Single[4]
{
0.6176283f,
0.81555045f,
0.61124164f,
0.37947613f,
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[3]
{
0.41980517f,
0.9988901f,
0.89577323f,
}));
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
                Assert.That(nullable, Is.Null);
                nullable = await ((ISingleArrayrealArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 63;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
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
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
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
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 123;
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
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
                        FlatSinglerealArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(models[22],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[23],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[24],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[25],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
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
                        FlatSinglerealArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
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
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        SinglerealArray1M.AssertModel(models[0],_testData[4], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[5], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[6], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[7], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[8], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[9], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[10], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[11], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[20],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[21],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[22],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[23],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[24],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[25],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[26],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[27],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[28],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[29],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        SinglerealArray1M.AssertModel(models[0],_testData[4], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[5], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[6], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[7], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[8], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[9], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[10], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[11], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[20],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[21],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[22],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[23],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[24],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[25],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[26],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[27],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[28],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[29],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[30],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        SinglerealArray1M.AssertModel(models[0],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        SinglerealArray1M.AssertModel(models[0],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 78, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[34], false);
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
                await ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 17, query1, 113, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 103, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
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
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
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
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[34], false);
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
                 ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 74, query1, 124, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 127, query1, 154, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[34], false);
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
                await ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 87, query1, 74, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 124, query1, 17, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

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
                        FlatSinglerealArray1M.AssertModel(models[25],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[26],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[27],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[28],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[29],_testData[34], false);
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
                 ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatch(connection, 97, query1, 63, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
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
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTSelectModelBatchAsync(connection, 133, 87))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        SinglerealArray1M.AssertModel(models[0],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        SinglerealArray1M.AssertModel(models[0],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTSelectModelBatch(connection, 140, 140))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        SinglerealArray1M.AssertModel(models[0],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        SinglerealArray1M.AssertModel(models[0],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[34], false);
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
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 127);
                var models = await ((ISingleArrayrealArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                SinglerealArray1M.AssertModel(models[0],_testData[28], false);
                SinglerealArray1M.AssertModel(models[1],_testData[29], false);
                SinglerealArray1M.AssertModel(models[2],_testData[30], false);
                SinglerealArray1M.AssertModel(models[3],_testData[31], false);
                SinglerealArray1M.AssertModel(models[4],_testData[32], false);
                SinglerealArray1M.AssertModel(models[5],_testData[33], false);
                SinglerealArray1M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleArrayrealArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 121);
                var models =  ((ISingleArrayrealArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                SinglerealArray1M.AssertModel(models[0],_testData[25], false);
                SinglerealArray1M.AssertModel(models[1],_testData[26], false);
                SinglerealArray1M.AssertModel(models[2],_testData[27], false);
                SinglerealArray1M.AssertModel(models[3],_testData[28], false);
                SinglerealArray1M.AssertModel(models[4],_testData[29], false);
                SinglerealArray1M.AssertModel(models[5],_testData[30], false);
                SinglerealArray1M.AssertModel(models[6],_testData[31], false);
                SinglerealArray1M.AssertModel(models[7],_testData[32], false);
                SinglerealArray1M.AssertModel(models[8],_testData[33], false);
                SinglerealArray1M.AssertModel(models[9],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
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

                await ((ISingleArrayrealArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlerealarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISingleArrayrealArray)this).DynQueryWASelectImportModelInnerAsync(connection);
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
        public  void DynQueryWAImportModelInnerTest()
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

                ((ISingleArrayrealArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_singlerealarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleArrayrealArray)this).DynQueryWASelectImportModelInner(connection);
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
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
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
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<SinglerealArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
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
                Assert.That(models, Has.Count.EqualTo(8));
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void WASelectImportModelInnerConfig()
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ISingleArrayrealArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleArrayrealArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
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

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<SinglerealArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ISingleArrayrealArray)this).WAImportModelInner(connection, importCollection);
                var models = ((ISingleArrayrealArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
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
            queryMapTypes: [typeof(SinglerealArray1MIWA)],
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(SinglerealArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
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

                await ((ISingleArrayrealArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleArrayrealArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
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

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<SinglerealArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
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

                ((ISingleArrayrealArray)this).ImportModelInner(connection, importCollection);
                var models = ((ISingleArrayrealArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ISingleArrayrealArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((ISingleArrayrealArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SinglerealArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ISingleArrayrealArray)this).ImportModel(connection, importCollection);
                var models = ((ISingleArrayrealArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SinglerealArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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

        [Test, Order(13)]
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
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA), typeof(SinglerealArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
                var models1 = new List<SinglerealArray1MIWA>();
                var models2 = new List<SinglerealArray1MIWA>();
                await ((ISingleArrayrealArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealArray1MIWA>();
                var models2 = new List<SinglerealArray1MIWA>();
                ((ISingleArrayrealArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
                var models = await ((ISingleArrayrealArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_singlerealarray1mi
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
                    SinglerealArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleArrayrealArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_singlerealarray1mi
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
                    SinglerealArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA), typeof(SinglerealArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
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
                var models1 = new List<SinglerealArray1MIWA>();
                var models2 = new List<SinglerealArray1MIWA>();
                await ((ISingleArrayrealArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealArray1MIWA>();
                var models2 = new List<SinglerealArray1MIWA>();
                ((ISingleArrayrealArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
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
                var models = await ((ISingleArrayrealArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_singlerealarray1mi
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
                    SinglerealArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleArrayrealArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_singlerealarray1mi
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
                    SinglerealArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_singlerealarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MI), typeof(SinglerealArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
                var models1 = new List<SinglerealArray1MI>();
                var models2 = new List<SinglerealArray1MI>();
                await ((ISingleArrayrealArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealArray1MI>();
                var models2 = new List<SinglerealArray1MI>();
                ((ISingleArrayrealArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(model2, expectedModel, false);
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
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
                var models = await ((ISingleArrayrealArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleArrayrealArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_singlerealarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA), typeof(SinglerealArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
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
                var models1 = new List<SinglerealArray1MIWA>();
                var models2 = new List<SinglerealArray1MIWA>();
                await ((ISingleArrayrealArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealArray1MIWA>();
                var models2 = new List<SinglerealArray1MIWA>();
                ((ISingleArrayrealArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
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
                var models = await ((ISingleArrayrealArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleArrayrealArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

