

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
    Id = 6,
    Value = 
new System.Int16[,] { { 10694, 21391, }, { 1276, 28407, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,] { { 12033, 24860, }, { 30603, 22290, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 10,
    Value = 
new System.Int16[,] { { 32384, 29795, }, { 10207, 22202, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 8,
    Value = 
new System.Int16[,] { { 5251, 24176, }, { 19238, 25268, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 21221, 24159, }, { 15900, 27779, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 19,
    Value = 
new System.Int16[,] { { 20928, 27240, }, { 10995, 15183, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,] { { 29532, 14889, }, { 7025, 5825, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 28,
    Value = 
new System.Int16[,] { { 65, 13462, }, { 24207, 9495, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 12,
    Value = 
new System.Int16[,] { { 22071, 2351, }, { 11046, 24985, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 20671, 17737, }, { 7693, 3694, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 33,
    Value = 
new System.Int16[,] { { 14299, 4559, }, { 17123, 20662, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,] { { 6622, 6768, }, { 13978, 3583, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 35,
    Value = 
new System.Int16[,] { { 5514, 22200, }, { 4848, 21642, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 21,
    Value = 
new System.Int16[,] { { 22914, 8822, }, { 18072, 32435, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 21193, 20432, }, { 29533, 26090, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 42,
    Value = 
new System.Int16[,] { { 14664, 26459, }, { 6599, 16490, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,] { { 3628, 24874, }, { 2127, 208, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 43,
    Value = 
new System.Int16[,] { { 16820, 27812, }, { 10909, 22482, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 28,
    Value = 
new System.Int16[,] { { 3011, 7695, }, { 14824, 6214, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 29107, 10686, }, { 19011, 26674, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 47,
    Value = 
new System.Int16[,] { { 2459, 27795, }, { 15267, 18983, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 54,
    Value = 
new System.Int16[,] { { 14225, 28414, }, { 25322, 27499, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 31,
    Value = 
new System.Int16[,] { { 17853, 15816, }, { 7543, 4584, }, },
    NullableValue = 
new System.Int16[,] { { 9322, 24750, }, { 7758, 5834, }, },
},
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 61,
    Value = 
new System.Int16[,] { { 30160, 29012, }, { 21590, 3861, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 67,
    Value = 
new System.Int16[,] { { 21852, 22491, }, { 15469, 5119, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 39,
    Value = 
new System.Int16[,] { { 14813, 2704, }, { 4682, 1334, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 76,
    Value = 
new System.Int16[,] { { 17227, 12454, }, { 22451, 24537, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,] { { 5587, 5434, }, { 5315, 18307, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 79,
    Value = 
new System.Int16[,] { { 7993, 13463, }, { 17985, 1114, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 40,
    Value = 
new System.Int16[,] { { 13402, 19865, }, { 8996, 2317, }, },
    NullableValue = 
new System.Int16[,] { { 31035, 19506, }, { 22929, 12185, }, },
},
    NullableValue = 
new System.Int16[,] { { 3817, 26131, }, { 24938, 28207, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 87,
    Value = 
new System.Int16[,] { { 16993, 13753, }, { 2190, 30930, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,] { { 30449, 15833, }, { 16496, 18459, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 90,
    Value = 
new System.Int16[,] { { 17826, 19693, }, { 16907, 9696, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 47,
    Value = 
new System.Int16[,] { { 22911, 19716, }, { 4475, 21419, }, },
    NullableValue = 
new System.Int16[,] { { 23393, 31153, }, { 517, 12042, }, },
},
    NullableValue = 
new System.Int16[,] { { 6113, 6056, }, { 31229, 2542, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 95,
    Value = 
new System.Int16[,] { { 11517, 4876, }, { 3262, 8169, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 103,
    Value = 
new System.Int16[,] { { 15632, 2467, }, { 27664, 22056, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 48,
    Value = 
new System.Int16[,] { { 10579, 21446, }, { 1448, 8262, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 9680, 3201, }, { 23065, 18226, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 112,
    Value = 
new System.Int16[,] { { 4252, 18901, }, { 8396, 3364, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,] { { 14993, 31919, }, { 3313, 13846, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 119,
    Value = 
new System.Int16[,] { { 30904, 31477, }, { 15119, 25450, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Int16[,] { { 10219, 23498, }, { 17676, 20001, }, },
    NullableValue = 
new System.Int16[,] { { 20163, 32688, }, { 27305, 20081, }, },
},
    NullableValue = 
new System.Int16[,] { { 23715, 21682, }, { 26146, 8821, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 124,
    Value = 
new System.Int16[,] { { 14011, 10960, }, { 21840, 12560, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,] { { 24880, 2051, }, { 27564, 30249, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 125,
    Value = 
new System.Int16[,] { { 19883, 5995, }, { 20852, 2448, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 52,
    Value = 
new System.Int16[,] { { 15453, 11193, }, { 2456, 13382, }, },
    NullableValue = 
new System.Int16[,] { { 15943, 3552, }, { 10125, 13462, }, },
},
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 129,
    Value = 
new System.Int16[,] { { 31428, 31567, }, { 32266, 29425, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,] { { 23496, 19935, }, { 29597, 550, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 133,
    Value = 
new System.Int16[,] { { 26696, 17979, }, { 26639, 1088, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 58,
    Value = 
new System.Int16[,] { { 22765, 25388, }, { 18505, 4361, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 142,
    Value = 
new System.Int16[,] { { 2427, 16996, }, { 1512, 32621, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 150,
    Value = 
new System.Int16[,] { { 25409, 29815, }, { 29031, 27322, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 65,
    Value = 
new System.Int16[,] { { 18936, 6691, }, { 18596, 30577, }, },
    NullableValue = 
new System.Int16[,] { { 22721, 2873, }, { 1598, 5633, }, },
},
    NullableValue = 
new System.Int16[,] { { 29441, 13050, }, { 13225, 20972, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 152,
    Value = 
new System.Int16[,] { { 31124, 28584, }, { 26279, 22424, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 157,
    Value = 
new System.Int16[,] { { 7959, 5764, }, { 19886, 27547, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 68,
    Value = 
new System.Int16[,] { { 20181, 21671, }, { 5035, 9095, }, },
    NullableValue = 
new System.Int16[,] { { 24199, 19956, }, { 26861, 6519, }, },
},
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 164,
    Value = 
new System.Int16[,] { { 5187, 29255, }, { 2017, 25534, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,] { { 20206, 15684, }, { 23395, 30828, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 170,
    Value = 
new System.Int16[,] { { 27202, 20136, }, { 31037, 29771, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 69,
    Value = 
new System.Int16[,] { { 23162, 30179, }, { 17861, 29575, }, },
    NullableValue = 
new System.Int16[,] { { 13704, 13555, }, { 8520, 26893, }, },
},
    NullableValue = 
new System.Int16[,] { { 29641, 31226, }, { 29640, 18732, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 179,
    Value = 
new System.Int16[,] { { 15086, 31645, }, { 31138, 7760, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintMMArrayD2E1M
{
    Id = 188,
    Value = 
new System.Int16[,] { { 2041, 27684, }, { 8677, 17540, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 75,
    Value = 
new System.Int16[,] { { 9599, 31121, }, { 12237, 30416, }, },
    NullableValue = 
new System.Int16[,] { { 28741, 18835, }, { 5837, 17072, }, },
},
    NullableValue = 
new System.Int16[,] { { 16419, 8247, }, { 24077, 31268, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 190,
    Value = 
new System.Int16[,] { { 14311, 18828, }, { 27218, 30016, }, },
    ModelInner = null,
    NullableValue = 
new System.Int16[,] { { 29998, 23028, }, { 28627, 1884, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 196,
    Value = 
new System.Int16[,] { { 12033, 24849, }, { 24419, 22818, }, },
    ModelInner = new Int16smallintMMArrayD2E1MI
{
    Id = 81,
    Value = 
new System.Int16[,] { { 28018, 16879, }, { 25208, 1619, }, },
    NullableValue = 
new System.Int16[,] { { 16750, 23589, }, { 16437, 17772, }, },
},
    NullableValue = 
new System.Int16[,] { { 6070, 20729, }, { 12578, 28605, }, },
},
            new Int16smallintMMArrayD2E1M
{
    Id = 197,
    Value = 
new System.Int16[,] { { 6860, 5371, }, { 21215, 3557, }, },
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
new System.Int16[,] { { 6622, 6768, }, { 13978, 3583, }, }));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int16[,] { { 21193, 20432, }, { 29533, 26090, }, }));
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
new System.Int16[,] { { 3628, 24874, }, { 2127, 208, }, }));
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
new System.Int16[,] { { 29107, 10686, }, { 19011, 26674, }, }));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
                nullable = await ((IInt16MArraysmallintMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 179;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[33],_testData[34], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
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
                parametr1.Value = 170;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 79;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[34], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[27],_testData[34], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16MArraysmallintMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 170;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16MArraysmallintMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
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
                await ((IInt16MArraysmallintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 33, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[29],_testData[34], false);
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
                await ((IInt16MArraysmallintMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 157, query1, 190, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
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
                 ((IInt16MArraysmallintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 87, query1, 19, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[31],_testData[34], false);
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
                 ((IInt16MArraysmallintMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 79, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
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
                foreach(var batchResult in await ((IInt16MArraysmallintMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 43, query1, 142, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IInt16MArraysmallintMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 33, query1, 61, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[34], false);
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
                foreach(var batchResult in  ((IInt16MArraysmallintMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 54, query1, 90, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
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
                 ((IInt16MArraysmallintMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 19, query1, 95, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt16smallintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[34], false);
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
                foreach(var batchResult in await ((IInt16MArraysmallintMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 164, 103))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
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
                foreach(var batchResult in  ((IInt16MArraysmallintMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 54, 164))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        Int16smallintMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
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
                ((IInt16MArraysmallintMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 133);
                var models = await ((IInt16MArraysmallintMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16MArraysmallintMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16MArraysmallintMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 188);
                var models =  ((IInt16MArraysmallintMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                Int16smallintMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                Int16smallintMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
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

