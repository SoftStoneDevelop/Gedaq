

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
    internal partial interface IInt16MArraysmallintMMArrayD2
    {
    }
    
    internal partial class Int16MArraysmallintMMArrayD2 : IInt16MArraysmallintMMArrayD2
    {


#region TestData

        private readonly Int16smallintMMArrayD2E1M[] _testData = new Int16smallintMMArrayD2E1M[]
        {
            new Int16smallintMMArrayD2E1M
{
    Id = 5,
    Value = 
new System.Int16[,] { { 27081, 16157, }, { 18005, 29413, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,] { { 16719, 6960, }, { 2509, 10128, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 9,
    Value = 
new System.Int16[,] { { 26711, 12055, }, { 1574, 4323, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 1,
    Value = 
new System.Int16[,] { { 28170, 14120, }, { 27711, 7388, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 1035, 3520, }, { 13944, 17132, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 18,
    Value = 
new System.Int16[,] { { 4909, 31584, }, { 17031, 20480, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 21,
    Value = 
new System.Int16[,] { { 14966, 9166, }, { 22124, 24442, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 2,
    Value = 
new System.Int16[,] { { 22751, 15305, }, { 914, 20619, }, },
    NullableValue = 
new System.Int16[,] { { 8420, 13585, }, { 9923, 25249, }, },
},
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 25,
    Value = 
new System.Int16[,] { { 4463, 27366, }, { 18999, 23333, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,] { { 18093, 7198, }, { 25979, 11954, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 30,
    Value = 
new System.Int16[,] { { 27104, 2730, }, { 30851, 24835, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 11,
    Value = 
new System.Int16[,] { { 12954, 28431, }, { 18835, 7855, }, },
    NullableValue = 
new System.Int16[,] { { 10438, 10285, }, { 32724, 25146, }, },
},
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 31,
    Value = 
new System.Int16[,] { { 23230, 6386, }, { 5017, 16325, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,] { { 18287, 27247, }, { 29735, 23013, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 40,
    Value = 
new System.Int16[,] { { 6395, 30628, }, { 28027, 7318, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 17,
    Value = 
new System.Int16[,] { { 32155, 4503, }, { 28795, 29142, }, },
    NullableValue = 
new System.Int16[,] { { 29077, 32729, }, { 18866, 1298, }, },
},
    NullableValue = 
new System.Int16[,] { { 7029, 1858, }, { 10656, 18875, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 47,
    Value = 
new System.Int16[,] { { 15846, 29784, }, { 17443, 7313, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 55,
    Value = 
new System.Int16[,] { { 4642, 7505, }, { 2487, 20371, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 19,
    Value = 
new System.Int16[,] { { 28957, 1876, }, { 11160, 13538, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 8253, 7636, }, { 28006, 1452, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 60,
    Value = 
new System.Int16[,] { { 11154, 28173, }, { 5261, 18234, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,] { { 13869, 28832, }, { 30072, 7072, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 69,
    Value = 
new System.Int16[,] { { 5654, 1405, }, { 21635, 13894, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 28,
    Value = 
new System.Int16[,] { { 31815, 11345, }, { 8128, 6799, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 30656, 10324, }, { 31768, 25601, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 72,
    Value = 
new System.Int16[,] { { 13244, 27798, }, { 22420, 31242, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,] { { 28756, 3420, }, { 17449, 20154, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 81,
    Value = 
new System.Int16[,] { { 2175, 6100, }, { 1046, 12384, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 33,
    Value = 
new System.Int16[,] { { 643, 31491, }, { 13833, 6775, }, },
    NullableValue = 
new System.Int16[,] { { 17135, 5013, }, { 26796, 15722, }, },
},
    NullableValue = 
new System.Int16[,] { { 15747, 2822, }, { 25630, 22560, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 83,
    Value = 
new System.Int16[,] { { 8464, 11621, }, { 21293, 27839, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 88,
    Value = 
new System.Int16[,] { { 23883, 21871, }, { 4353, 12926, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 38,
    Value = 
new System.Int16[,] { { 31930, 18445, }, { 17883, 23431, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 96,
    Value = 
new System.Int16[,] { { 16674, 32398, }, { 2983, 22036, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,] { { 20361, 11357, }, { 14112, 32702, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 101,
    Value = 
new System.Int16[,] { { 2206, 19764, }, { 6807, 23257, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 40,
    Value = 
new System.Int16[,] { { 7298, 11178, }, { 3683, 13767, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 102,
    Value = 
new System.Int16[,] { { 13507, 10856, }, { 26634, 24666, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 104,
    Value = 
new System.Int16[,] { { 11684, 18919, }, { 4460, 21597, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 47,
    Value = 
new System.Int16[,] { { 16782, 20556, }, { 21072, 4694, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 106,
    Value = 
new System.Int16[,] { { 25151, 2340, }, { 12494, 30360, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 112,
    Value = 
new System.Int16[,] { { 10645, 30331, }, { 26294, 14293, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 54,
    Value = 
new System.Int16[,] { { 5593, 4466, }, { 24388, 11417, }, },
    NullableValue = 
new System.Int16[,] { { 4909, 18575, }, { 21829, 12044, }, },
},
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 118,
    Value = 
new System.Int16[,] { { 32737, 7543, }, { 21088, 11009, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,] { { 31615, 15356, }, { 15060, 6429, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 121,
    Value = 
new System.Int16[,] { { 15344, 28323, }, { 19199, 11818, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 57,
    Value = 
new System.Int16[,] { { 220, 14319, }, { 12141, 31334, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 122,
    Value = 
new System.Int16[,] { { 32297, 9880, }, { 1500, 1999, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 131,
    Value = 
new System.Int16[,] { { 21804, 13747, }, { 25140, 28623, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 62,
    Value = 
new System.Int16[,] { { 31607, 23957, }, { 15997, 18299, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 17720, 3440, }, { 29393, 31562, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 137,
    Value = 
new System.Int16[,] { { 21666, 23654, }, { 16166, 6707, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,] { { 22453, 16659, }, { 15731, 4211, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 144,
    Value = 
new System.Int16[,] { { 428, 5455, }, { 13707, 17693, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 70,
    Value = 
new System.Int16[,] { { 9789, 6760, }, { 23496, 27775, }, },
    NullableValue = 
new System.Int16[,] { { 31596, 9310, }, { 6496, 23641, }, },
},
    NullableValue = 
new System.Int16[,] { { 30170, 16896, }, { 13881, 29682, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 146,
    Value = 
new System.Int16[,] { { 13532, 19136, }, { 2109, 19194, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,] { { 9244, 7230, }, { 7949, 12899, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 151,
    Value = 
new System.Int16[,] { { 26990, 1342, }, { 23913, 20581, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 78,
    Value = 
new System.Int16[,] { { 7626, 12877, }, { 14599, 8242, }, },
    NullableValue = 
new System.Int16[,] { { 5312, 13088, }, { 26916, 12457, }, },
},
    NullableValue = 
new System.Int16[,] { { 14178, 4620, }, { 21673, 11174, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 152,
    Value = 
new System.Int16[,] { { 2629, 16692, }, { 27425, 31300, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 160,
    Value = 
new System.Int16[,] { { 23755, 30087, }, { 6579, 3732, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 87,
    Value = 
new System.Int16[,] { { 13391, 21724, }, { 23801, 2794, }, },
    NullableValue = 
new System.Int16[,] { { 4716, 21747, }, { 1323, 6230, }, },
},
    NullableValue = 
new System.Int16[,] { { 21319, 16212, }, { 11492, 25632, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 163,
    Value = 
new System.Int16[,] { { 16586, 26942, }, { 12669, 3599, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,] { { 1617, 31749, }, { 11465, 6532, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 168,
    Value = 
new System.Int16[,] { { 23621, 31675, }, { 13673, 9709, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 91,
    Value = 
new System.Int16[,] { { 22024, 28921, }, { 1703, 26145, }, },
    NullableValue = 
new System.Int16[,] { { 13823, 20793, }, { 1883, 9431, }, },
},
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 170,
    Value = 
new System.Int16[,] { { 1565, 3432, }, { 1285, 16921, }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallintmmarrayd2e1mi(
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
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallintmmarrayd2e1mi(
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
            queryMapTypes: [typeof(Int16smallintMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630))]
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

                changedRows =  ((IInt16MArraysmallintMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt16MArraysmallintMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt16MArraysmallintMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt16MArraysmallintMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallintmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    int16smallintmmarrayd2e1mi_id
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
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int16smallintmmarrayd2e1mi_id", 
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
                changedRows =  ((IInt16MArraysmallintMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt16MArraysmallintMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallintmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    int16smallintmmarrayd2e1mi_id
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
    int16smallintmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int16smallintMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
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
                System.Int16[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int16[,]>();
                    ((NpgsqlParameter<System.Int16[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483630);
                    ((NpgsqlParameter<System.Int16[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483630);
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

                    nullable =  ((IInt16MArraysmallintMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int16[,] { { 18093, 7198, }, { 25979, 11954, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int16[,]>();
                    ((NpgsqlParameter<System.Int16[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483630);
                    ((NpgsqlParameter<System.Int16[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483630);
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

                    nullable =  ((IInt16MArraysmallintMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Int16[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int16[,]>();
                    ((NpgsqlParameter<System.Int16[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483630);
                    ((NpgsqlParameter<System.Int16[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483630);
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

                    nullable = await ((IInt16MArraysmallintMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int16[,] { { 18287, 27247, }, { 29735, 23013, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int16[,]>();
                    ((NpgsqlParameter<System.Int16[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483630);
                    ((NpgsqlParameter<System.Int16[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483630);
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

                    nullable = await ((IInt16MArraysmallintMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int16[,] { { 7029, 1858, }, { 10656, 18875, }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallintmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    int16smallintmmarrayd2e1mi_id
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
    int16smallintmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int16smallintMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int16smallintmmarrayd2e1mi_id", 
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
                System.Int16[,] nullable = null;
                nullable =  ((IInt16MArraysmallintMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IInt16MArraysmallintMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int16[,] { { 8253, 7636, }, { 28006, 1452, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int16[,] nullable = null;
                nullable = await ((IInt16MArraysmallintMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int16[,] { { 13869, 28832, }, { 30072, 7072, }, }));
                nullable = await ((IInt16MArraysmallintMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int16[,] { { 30656, 10324, }, { 31768, 25601, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int16smallintMMArrayD2E1M> models = null;

                models =  ((IInt16MArraysmallintMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt16MArraysmallintMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt16MArraysmallintMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt16MArraysmallintMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int16smallintMMArrayD2E1M> models = null;

                models = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt16MArraysmallintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintMMArrayD2E1M), typeof(FlatInt16smallintMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
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
FROM public.int16smallintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var models2 = new List<FlatInt16smallintMMArrayD2E1M>();
                await ((IInt16MArraysmallintMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var models2 = new List<FlatInt16smallintMMArrayD2E1M>();
                ((IInt16MArraysmallintMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
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
FROM public.int16smallintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt16MArraysmallintMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt16MArraysmallintMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintmmarrayd2e1m m
LEFT JOIN public.int16smallintmmarrayd2e1mi mi ON mi.id = m.int16smallintmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int16smallintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
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
                var models = await ((IInt16MArraysmallintMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt16MArraysmallintMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintMMArrayD2E1M), typeof(FlatInt16smallintMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
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
FROM public.int16smallintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var models2 = new List<FlatInt16smallintMMArrayD2E1M>();
                await ((IInt16MArraysmallintMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var models2 = new List<FlatInt16smallintMMArrayD2E1M>();
                ((IInt16MArraysmallintMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
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
FROM public.int16smallintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt16MArraysmallintMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt16MArraysmallintMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintmmarrayd2e1m m
LEFT JOIN public.int16smallintmmarrayd2e1mi mi ON mi.id = m.int16smallintmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int16smallintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
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
                var models = await ((IInt16MArraysmallintMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt16MArraysmallintMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintMMArrayD2E1M), typeof(FlatInt16smallintMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
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
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
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
FROM public.int16smallintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var models2 = new List<FlatInt16smallintMMArrayD2E1M>();
                await((IInt16MArraysmallintMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
FROM public.int16smallintmmarrayd2e1m m
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
FROM public.int16smallintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt16smallintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt16smallintMMArrayD2E1M>();
                await ((IInt16MArraysmallintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
FROM public.int16smallintmmarrayd2e1m m
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
FROM public.int16smallintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt16smallintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt16smallintMMArrayD2E1M>();
                await ((IInt16MArraysmallintMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
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
FROM public.int16smallintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var models2 = new List<FlatInt16smallintMMArrayD2E1M>();
                ((IInt16MArraysmallintMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
FROM public.int16smallintmmarrayd2e1m m
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
FROM public.int16smallintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt16smallintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt16smallintMMArrayD2E1M>();
                 ((IInt16MArraysmallintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
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
FROM public.int16smallintmmarrayd2e1m m
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
FROM public.int16smallintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt16smallintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt16smallintMMArrayD2E1M>();
                 ((IInt16MArraysmallintMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
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
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
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
FROM public.int16smallintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt16MArraysmallintMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallintmmarrayd2e1m m
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
FROM public.int16smallintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16MArraysmallintMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallintmmarrayd2e1m m
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
FROM public.int16smallintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt16smallintMMArrayD2E1M>();
                await ((IInt16MArraysmallintMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.int16smallintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt16MArraysmallintMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallintmmarrayd2e1m m
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
FROM public.int16smallintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16MArraysmallintMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallintmmarrayd2e1m m
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
FROM public.int16smallintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt16smallintMMArrayD2E1M>();
                 ((IInt16MArraysmallintMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.int16smallintmmarrayd2e1m m
LEFT JOIN public.int16smallintmmarrayd2e1mi mi ON mi.id = m.int16smallintmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int16smallintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
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
                var models = await((IInt16MArraysmallintMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16MArraysmallintMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
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
                var models = ((IInt16MArraysmallintMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16MArraysmallintMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintMMArrayD2E1M), typeof(FlatInt16smallintMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
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
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
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
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
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
FROM public.int16smallintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var models2 = new List<FlatInt16smallintMMArrayD2E1M>();
                await((IInt16MArraysmallintMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallintmmarrayd2e1m m
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
FROM public.int16smallintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt16smallintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt16smallintMMArrayD2E1M>();
                await ((IInt16MArraysmallintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 146, query1, 151, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.int16smallintmmarrayd2e1m m
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
FROM public.int16smallintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt16smallintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt16smallintMMArrayD2E1M>();
                await ((IInt16MArraysmallintMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 60, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM public.int16smallintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var models2 = new List<FlatInt16smallintMMArrayD2E1M>();
                ((IInt16MArraysmallintMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallintmmarrayd2e1m m
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
FROM public.int16smallintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt16smallintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt16smallintMMArrayD2E1M>();
                 ((IInt16MArraysmallintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 18, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.int16smallintmmarrayd2e1m m
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
FROM public.int16smallintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt16smallintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt16smallintMMArrayD2E1M>();
                 ((IInt16MArraysmallintMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 40, query1, 5, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
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
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
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
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
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
FROM public.int16smallintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt16MArraysmallintMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintmmarrayd2e1m m
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
FROM public.int16smallintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16MArraysmallintMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 122, query1, 60, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
FROM public.int16smallintmmarrayd2e1m m
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
FROM public.int16smallintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt16smallintMMArrayD2E1M>();
                await ((IInt16MArraysmallintMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 55, query1, 151, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.int16smallintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt16MArraysmallintMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintmmarrayd2e1m m
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
FROM public.int16smallintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16MArraysmallintMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 31, query1, 55, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
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
FROM public.int16smallintmmarrayd2e1m m
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
FROM public.int16smallintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt16smallintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt16smallintMMArrayD2E1M>();
                 ((IInt16MArraysmallintMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 47, query1, 21, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.int16smallintmmarrayd2e1m m
LEFT JOIN public.int16smallintmmarrayd2e1mi mi ON mi.id = m.int16smallintmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int16smallintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
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
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
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
                var models = await((IInt16MArraysmallintMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt16MArraysmallintMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 96, 60))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
                var models = ((IInt16MArraysmallintMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt16MArraysmallintMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 9, 152))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
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
                await using var cmd = await ((IInt16MArraysmallintMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt16MArraysmallintMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 81);
                var models = await ((IInt16MArraysmallintMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16MArraysmallintMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16MArraysmallintMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 104);
                var models =  ((IInt16MArraysmallintMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
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
FROM public.binary_int16smallintmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int16smallintMMArrayD2E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt16MArraysmallintMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int16smallintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt16MArraysmallintMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt16MArraysmallintMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int16smallintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt16MArraysmallintMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int16smallintmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int16smallintMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt16MArraysmallintMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int16smallintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt16MArraysmallintMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt16MArraysmallintMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int16smallintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt16MArraysmallintMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int16smallintmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int16smallintmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int16smallintMMArrayD2E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt16MArraysmallintMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt16MArraysmallintMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt16MArraysmallintMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt16MArraysmallintMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_int16smallintmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int16smallintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int16smallintMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt16MArraysmallintMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt16MArraysmallintMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt16MArraysmallintMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IInt16MArraysmallintMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int16smallintmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int16smallintmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int16smallintMMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2))]
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
FROM public.binary_int16smallintmmarrayd2e1m m
LEFT JOIN public.binary_int16smallintmmarrayd2e1mi mi ON mi.id = m.int16smallintmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int16smallintMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt16MArraysmallintMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt16MArraysmallintMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int16smallintMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt16MArraysmallintMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IInt16MArraysmallintMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int16smallintMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int16smallintmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int16smallintmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int16smallintMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
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
                var models =  ((IInt16MArraysmallintMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int16smallintMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt16MArraysmallintMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int16smallintMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int16smallintMMArrayD2E1MIWA), typeof(Int16smallintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
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
                var models1 = new List<Int16smallintMMArrayD2E1MIWA>();
                var models2 = new List<Int16smallintMMArrayD2E1MIWA>();
                await ((IInt16MArraysmallintMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int16smallintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int16smallintMMArrayD2E1MIWA>();
                var models2 = new List<Int16smallintMMArrayD2E1MIWA>();
                ((IInt16MArraysmallintMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int16smallintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int16smallintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
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
                var models = await ((IInt16MArraysmallintMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int16smallintmmarrayd2e1mi
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
                    Int16smallintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt16MArraysmallintMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int16smallintmmarrayd2e1mi
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
                    Int16smallintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int16smallintMMArrayD2E1MIWA), typeof(Int16smallintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2))]
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
                var models1 = new List<Int16smallintMMArrayD2E1MIWA>();
                var models2 = new List<Int16smallintMMArrayD2E1MIWA>();
                await ((IInt16MArraysmallintMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int16smallintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int16smallintMMArrayD2E1MIWA>();
                var models2 = new List<Int16smallintMMArrayD2E1MIWA>();
                ((IInt16MArraysmallintMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int16smallintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int16smallintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2))]
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
                var models = await ((IInt16MArraysmallintMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int16smallintmmarrayd2e1mi
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
                    Int16smallintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt16MArraysmallintMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int16smallintmmarrayd2e1mi
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
                    Int16smallintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int16smallintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int16smallintMMArrayD2E1MI), typeof(Int16smallintMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
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
                var models1 = new List<Int16smallintMMArrayD2E1MI>();
                var models2 = new List<Int16smallintMMArrayD2E1MI>();
                await ((IInt16MArraysmallintMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int16smallintMMArrayD2E1MI>();
                var models2 = new List<Int16smallintMMArrayD2E1MI>();
                ((IInt16MArraysmallintMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int16smallintmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int16smallintMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
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
                var models = await ((IInt16MArraysmallintMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt16MArraysmallintMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int16smallintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int16smallintMMArrayD2E1MIWA), typeof(Int16smallintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2))]
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
                var models1 = new List<Int16smallintMMArrayD2E1MIWA>();
                var models2 = new List<Int16smallintMMArrayD2E1MIWA>();
                await ((IInt16MArraysmallintMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int16smallintMMArrayD2E1MIWA>();
                var models2 = new List<Int16smallintMMArrayD2E1MIWA>();
                ((IInt16MArraysmallintMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int16smallintmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int16smallintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArraysmallintMMArrayD2))]
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
                var models = await ((IInt16MArraysmallintMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt16MArraysmallintMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

