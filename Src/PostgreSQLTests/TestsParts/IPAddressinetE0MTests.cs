

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
    internal partial interface IIPAddressSingleTypeinet
    {
    }
    
    internal partial class IPAddressSingleTypeinet : IIPAddressSingleTypeinet
    {


#region TestData

        private readonly IPAddressinetE0M[] _testData = new IPAddressinetE0M[]
        {
            new IPAddressinetE0M
{
    Id = 9,
    Value = System.Net.IPAddress.Parse("191.205.210.126"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("94.123.39.230"),
},
            new IPAddressinetE0M
{
    Id = 17,
    Value = System.Net.IPAddress.Parse("20.223.152.71"),
    ModelInner = new IPAddressinetE0MI
{
    Id = 8,
    Value = System.Net.IPAddress.Parse("23.231.115.138"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetE0M
{
    Id = 26,
    Value = System.Net.IPAddress.Parse("22.213.246.112"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("202.64.244.56"),
},
            new IPAddressinetE0M
{
    Id = 34,
    Value = System.Net.IPAddress.Parse("50.95.46.158"),
    ModelInner = new IPAddressinetE0MI
{
    Id = 15,
    Value = System.Net.IPAddress.Parse("99.237.172.99"),
    NullableValue = System.Net.IPAddress.Parse("198.139.174.134"),
},
    NullableValue = null,
},
            new IPAddressinetE0M
{
    Id = 36,
    Value = System.Net.IPAddress.Parse("19.3.127.203"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("70.119.51.217"),
},
            new IPAddressinetE0M
{
    Id = 39,
    Value = System.Net.IPAddress.Parse("61.77.126.56"),
    ModelInner = new IPAddressinetE0MI
{
    Id = 18,
    Value = System.Net.IPAddress.Parse("93.254.34.14"),
    NullableValue = System.Net.IPAddress.Parse("240.243.180.40"),
},
    NullableValue = System.Net.IPAddress.Parse("51.68.227.170"),
},
            new IPAddressinetE0M
{
    Id = 43,
    Value = System.Net.IPAddress.Parse("97.131.135.38"),
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetE0M
{
    Id = 48,
    Value = System.Net.IPAddress.Parse("171.248.243.105"),
    ModelInner = new IPAddressinetE0MI
{
    Id = 26,
    Value = System.Net.IPAddress.Parse("22.40.103.213"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("188.229.217.171"),
},
            new IPAddressinetE0M
{
    Id = 57,
    Value = System.Net.IPAddress.Parse("134.54.147.205"),
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetE0M
{
    Id = 66,
    Value = System.Net.IPAddress.Parse("150.121.43.137"),
    ModelInner = new IPAddressinetE0MI
{
    Id = 28,
    Value = System.Net.IPAddress.Parse("187.53.52.154"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("35.218.73.66"),
},
            new IPAddressinetE0M
{
    Id = 67,
    Value = System.Net.IPAddress.Parse("165.115.200.132"),
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetE0M
{
    Id = 69,
    Value = System.Net.IPAddress.Parse("111.169.170.116"),
    ModelInner = new IPAddressinetE0MI
{
    Id = 35,
    Value = System.Net.IPAddress.Parse("118.173.93.54"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("37.223.8.199"),
},
            new IPAddressinetE0M
{
    Id = 70,
    Value = System.Net.IPAddress.Parse("148.5.40.98"),
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetE0M
{
    Id = 74,
    Value = System.Net.IPAddress.Parse("109.151.125.55"),
    ModelInner = new IPAddressinetE0MI
{
    Id = 39,
    Value = System.Net.IPAddress.Parse("184.154.17.57"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetE0M
{
    Id = 79,
    Value = System.Net.IPAddress.Parse("94.217.245.24"),
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetE0M
{
    Id = 85,
    Value = System.Net.IPAddress.Parse("152.8.177.195"),
    ModelInner = new IPAddressinetE0MI
{
    Id = 44,
    Value = System.Net.IPAddress.Parse("248.245.208.108"),
    NullableValue = System.Net.IPAddress.Parse("219.168.179.120"),
},
    NullableValue = null,
},
            new IPAddressinetE0M
{
    Id = 86,
    Value = System.Net.IPAddress.Parse("247.89.162.195"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("58.142.232.133"),
},
            new IPAddressinetE0M
{
    Id = 92,
    Value = System.Net.IPAddress.Parse("216.195.97.121"),
    ModelInner = new IPAddressinetE0MI
{
    Id = 47,
    Value = System.Net.IPAddress.Parse("33.242.23.220"),
    NullableValue = System.Net.IPAddress.Parse("227.67.144.244"),
},
    NullableValue = System.Net.IPAddress.Parse("70.7.79.47"),
},
            new IPAddressinetE0M
{
    Id = 100,
    Value = System.Net.IPAddress.Parse("32.154.127.216"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("7.218.111.58"),
},
            new IPAddressinetE0M
{
    Id = 103,
    Value = System.Net.IPAddress.Parse("151.109.86.14"),
    ModelInner = new IPAddressinetE0MI
{
    Id = 54,
    Value = System.Net.IPAddress.Parse("203.27.172.176"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("28.87.154.187"),
},
            new IPAddressinetE0M
{
    Id = 107,
    Value = System.Net.IPAddress.Parse("83.231.11.228"),
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetE0M
{
    Id = 111,
    Value = System.Net.IPAddress.Parse("228.217.89.155"),
    ModelInner = new IPAddressinetE0MI
{
    Id = 55,
    Value = System.Net.IPAddress.Parse("101.160.252.105"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetE0M
{
    Id = 114,
    Value = System.Net.IPAddress.Parse("83.228.161.155"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("228.140.56.73"),
},
            new IPAddressinetE0M
{
    Id = 123,
    Value = System.Net.IPAddress.Parse("98.25.80.120"),
    ModelInner = new IPAddressinetE0MI
{
    Id = 61,
    Value = System.Net.IPAddress.Parse("194.181.26.20"),
    NullableValue = System.Net.IPAddress.Parse("234.211.235.13"),
},
    NullableValue = System.Net.IPAddress.Parse("145.185.125.118"),
},
            new IPAddressinetE0M
{
    Id = 126,
    Value = System.Net.IPAddress.Parse("45.16.72.106"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("131.205.60.153"),
},
            new IPAddressinetE0M
{
    Id = 130,
    Value = System.Net.IPAddress.Parse("151.45.70.116"),
    ModelInner = new IPAddressinetE0MI
{
    Id = 62,
    Value = System.Net.IPAddress.Parse("238.4.156.100"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("64.176.52.33"),
},
            new IPAddressinetE0M
{
    Id = 131,
    Value = System.Net.IPAddress.Parse("210.226.229.143"),
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetE0M
{
    Id = 135,
    Value = System.Net.IPAddress.Parse("229.187.220.111"),
    ModelInner = new IPAddressinetE0MI
{
    Id = 64,
    Value = System.Net.IPAddress.Parse("160.19.109.112"),
    NullableValue = System.Net.IPAddress.Parse("14.106.117.30"),
},
    NullableValue = System.Net.IPAddress.Parse("53.145.140.19"),
},
            new IPAddressinetE0M
{
    Id = 143,
    Value = System.Net.IPAddress.Parse("118.120.224.198"),
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinetE0M
{
    Id = 148,
    Value = System.Net.IPAddress.Parse("11.249.84.117"),
    ModelInner = new IPAddressinetE0MI
{
    Id = 66,
    Value = System.Net.IPAddress.Parse("38.84.38.103"),
    NullableValue = System.Net.IPAddress.Parse("106.175.216.6"),
},
    NullableValue = null,
},
            new IPAddressinetE0M
{
    Id = 153,
    Value = System.Net.IPAddress.Parse("37.25.199.137"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("109.163.87.208"),
},
            new IPAddressinetE0M
{
    Id = 157,
    Value = System.Net.IPAddress.Parse("177.113.24.48"),
    ModelInner = new IPAddressinetE0MI
{
    Id = 70,
    Value = System.Net.IPAddress.Parse("60.72.130.14"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetE0M
{
    Id = 158,
    Value = System.Net.IPAddress.Parse("105.66.4.13"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("180.224.161.42"),
},
            new IPAddressinetE0M
{
    Id = 160,
    Value = System.Net.IPAddress.Parse("110.145.222.201"),
    ModelInner = new IPAddressinetE0MI
{
    Id = 78,
    Value = System.Net.IPAddress.Parse("212.183.208.118"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinetE0M
{
    Id = 165,
    Value = System.Net.IPAddress.Parse("105.73.235.77"),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinete0mi(
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
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(24)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(24))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinete0mi(
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
            queryMapTypes: [typeof(IPAddressinetE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(24)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(24))]
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

                changedRows =  ((IIPAddressSingleTypeinet)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IIPAddressSingleTypeinet)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IIPAddressSingleTypeinet)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IIPAddressSingleTypeinet)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IIPAddressSingleTypeinet)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IIPAddressSingleTypeinet)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IIPAddressSingleTypeinet)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinete0mi(
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
            asPartInterface: typeof(IIPAddressSingleTypeinet)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress), 
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

                changedRows =  ((IIPAddressSingleTypeinet)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinete0m(
	id,
    value,
    nullablevalue,
    ipaddressinete0mi_id
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
            asPartInterface: typeof(IIPAddressSingleTypeinet)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(24)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(24)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "ipaddressinete0mi_id", 
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
                changedRows =  ((IIPAddressSingleTypeinet)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IIPAddressSingleTypeinet)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IIPAddressSingleTypeinet)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IIPAddressSingleTypeinet)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinete0m(
	id,
    value,
    nullablevalue,
    ipaddressinete0mi_id
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
    ipaddressinete0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(IPAddressinetE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
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
                System.Net.IPAddress nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress>();
                    ((NpgsqlParameter<System.Net.IPAddress>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(24);
                    ((NpgsqlParameter<System.Net.IPAddress>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(24);
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

                    nullable =  ((IIPAddressSingleTypeinet)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(System.Net.IPAddress.Parse("70.119.51.217")));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress>();
                    ((NpgsqlParameter<System.Net.IPAddress>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(24);
                    ((NpgsqlParameter<System.Net.IPAddress>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(24);
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

                    nullable =  ((IIPAddressSingleTypeinet)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(System.Net.IPAddress.Parse("51.68.227.170")));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Net.IPAddress nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress>();
                    ((NpgsqlParameter<System.Net.IPAddress>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(24);
                    ((NpgsqlParameter<System.Net.IPAddress>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(24);
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

                    nullable = await ((IIPAddressSingleTypeinet)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Net.IPAddress>();
                    ((NpgsqlParameter<System.Net.IPAddress>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(24);
                    ((NpgsqlParameter<System.Net.IPAddress>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(24);
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

                    nullable = await ((IIPAddressSingleTypeinet)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(System.Net.IPAddress.Parse("188.229.217.171")));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinete0m(
	id,
    value,
    nullablevalue,
    ipaddressinete0mi_id
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
    ipaddressinete0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(IPAddressinetE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(24)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(24)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "ipaddressinete0mi_id", 
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
                System.Net.IPAddress nullable = null;
                nullable =  ((IIPAddressSingleTypeinet)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IIPAddressSingleTypeinet)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(System.Net.IPAddress.Parse("35.218.73.66")));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Net.IPAddress nullable = null;
                nullable = await ((IIPAddressSingleTypeinet)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IIPAddressSingleTypeinet)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(System.Net.IPAddress.Parse("37.223.8.199")));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinetE0M> models = null;

                models =  ((IIPAddressSingleTypeinet)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetE0M.AssertModel(models[0],_testData[12], true);
                models =  ((IIPAddressSingleTypeinet)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetE0M.AssertModel(models[0],_testData[13], true);
                models =  ((IIPAddressSingleTypeinet)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetE0M.AssertModel(models[0],_testData[14], true);
                models =  ((IIPAddressSingleTypeinet)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinetE0M> models = null;

                models = await ((IIPAddressSingleTypeinet)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetE0M.AssertModel(models[0],_testData[16], true);
                models = await ((IIPAddressSingleTypeinet)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetE0M.AssertModel(models[0],_testData[17], true);
                models = await ((IIPAddressSingleTypeinet)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetE0M.AssertModel(models[0],_testData[18], true);
                models = await ((IIPAddressSingleTypeinet)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinetE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinete0m(
	id,
    value,
    nullablevalue,
    ipaddressinete0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @ipaddressinete0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Net.IPAddress), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Net.IPAddress), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "ipaddressinete0mi_id", 
                methodParametrName: "ipaddressinete0mi_id", 
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

                changedRows =  ((IIPAddressSingleTypeinet)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IIPAddressSingleTypeinet)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IIPAddressSingleTypeinet)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetE0M), typeof(FlatIPAddressinetE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
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
FROM public.ipaddressinete0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatIPAddressinetE0M>();
                var models2 = new List<FlatIPAddressinetE0M>();
                await ((IIPAddressSingleTypeinet)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetE0M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinete0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatIPAddressinetE0M>();
                var models2 = new List<FlatIPAddressinetE0M>();
                ((IIPAddressSingleTypeinet)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetE0M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
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
FROM public.ipaddressinete0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IIPAddressSingleTypeinet)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinete0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IIPAddressSingleTypeinet)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinete0m m
LEFT JOIN public.ipaddressinete0mi mi ON mi.id = m.ipaddressinete0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(IPAddressinetE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
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
                var models = await ((IIPAddressSingleTypeinet)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IIPAddressSingleTypeinet)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetE0M), typeof(FlatIPAddressinetE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
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
FROM public.ipaddressinete0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetE0M>();
                var models2 = new List<FlatIPAddressinetE0M>();
                await ((IIPAddressSingleTypeinet)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetE0M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinete0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetE0M>();
                var models2 = new List<FlatIPAddressinetE0M>();
                ((IIPAddressSingleTypeinet)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetE0M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
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
FROM public.ipaddressinete0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IIPAddressSingleTypeinet)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinete0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IIPAddressSingleTypeinet)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinete0m m
LEFT JOIN public.ipaddressinete0mi mi ON mi.id = m.ipaddressinete0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(IPAddressinetE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
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
                var models = await ((IIPAddressSingleTypeinet)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IIPAddressSingleTypeinet)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetE0M), typeof(FlatIPAddressinetE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
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
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
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
FROM public.ipaddressinete0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatIPAddressinetE0M>();
                var models2 = new List<FlatIPAddressinetE0M>();
                await((IIPAddressSingleTypeinet)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetE0M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
FROM public.ipaddressinete0m m
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
FROM public.ipaddressinete0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetE0M>();
                var firstItems2 = new List<FlatIPAddressinetE0M>();
                var secondItems1 = new List<FlatIPAddressinetE0M>();
                var secondItems2 = new List<FlatIPAddressinetE0M>();
                await ((IIPAddressSingleTypeinet)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatIPAddressinetE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatIPAddressinetE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
FROM public.ipaddressinete0m m
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
FROM public.ipaddressinete0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetE0M>();
                var firstItems2 = new List<FlatIPAddressinetE0M>();
                var secondItems1 = new List<FlatIPAddressinetE0M>();
                await ((IIPAddressSingleTypeinet)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatIPAddressinetE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatIPAddressinetE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.ipaddressinete0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatIPAddressinetE0M>();
                var models2 = new List<FlatIPAddressinetE0M>();
                ((IIPAddressSingleTypeinet)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetE0M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
FROM public.ipaddressinete0m m
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
FROM public.ipaddressinete0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetE0M>();
                var firstItems2 = new List<FlatIPAddressinetE0M>();
                var secondItems1 = new List<FlatIPAddressinetE0M>();
                var secondItems2 = new List<FlatIPAddressinetE0M>();
                 ((IIPAddressSingleTypeinet)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatIPAddressinetE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatIPAddressinetE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
FROM public.ipaddressinete0m m
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
FROM public.ipaddressinete0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetE0M>();
                var firstItems2 = new List<FlatIPAddressinetE0M>();
                var secondItems1 = new List<FlatIPAddressinetE0M>();
                 ((IIPAddressSingleTypeinet)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatIPAddressinetE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatIPAddressinetE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinetE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
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
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
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
FROM public.ipaddressinete0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IIPAddressSingleTypeinet)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 158;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinete0m m
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
FROM public.ipaddressinete0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressSingleTypeinet)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatIPAddressinetE0M.AssertModel(models[0],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(models[1],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(models[2],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(models[3],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatIPAddressinetE0M.AssertModel(models[0],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinete0m m
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
FROM public.ipaddressinete0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetE0M>();
                var secondItems1 = new List<FlatIPAddressinetE0M>();
                var secondItems2 = new List<FlatIPAddressinetE0M>();
                await ((IIPAddressSingleTypeinet)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatIPAddressinetE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatIPAddressinetE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.ipaddressinete0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IIPAddressSingleTypeinet)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinete0m m
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
FROM public.ipaddressinete0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressSingleTypeinet)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatIPAddressinetE0M.AssertModel(models[0],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(models[1],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(models[2],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(models[3],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(models[4],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(models[5],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(models[6],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(models[7],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(models[8],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(models[9],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(models[10],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(models[11],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatIPAddressinetE0M.AssertModel(models[0],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(models[1],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(models[2],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(models[3],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(models[4],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(models[5],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(models[6],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(models[7],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(models[8],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(models[9],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(models[10],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(models[11],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(models[12],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(models[13],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(models[14],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinete0m m
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
FROM public.ipaddressinete0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetE0M>();
                var secondItems1 = new List<FlatIPAddressinetE0M>();
                var secondItems2 = new List<FlatIPAddressinetE0M>();
                 ((IIPAddressSingleTypeinet)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatIPAddressinetE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatIPAddressinetE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.ipaddressinete0m m
LEFT JOIN public.ipaddressinete0mi mi ON mi.id = m.ipaddressinete0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(IPAddressinetE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
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
                var models = await((IIPAddressSingleTypeinet)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressSingleTypeinet)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        IPAddressinetE0M.AssertModel(models[0],_testData[33], false);
                        IPAddressinetE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        IPAddressinetE0M.AssertModel(models[0],_testData[6], false);
                        IPAddressinetE0M.AssertModel(models[1],_testData[7], false);
                        IPAddressinetE0M.AssertModel(models[2],_testData[8], false);
                        IPAddressinetE0M.AssertModel(models[3],_testData[9], false);
                        IPAddressinetE0M.AssertModel(models[4],_testData[10], false);
                        IPAddressinetE0M.AssertModel(models[5],_testData[11], false);
                        IPAddressinetE0M.AssertModel(models[6],_testData[12], false);
                        IPAddressinetE0M.AssertModel(models[7],_testData[13], false);
                        IPAddressinetE0M.AssertModel(models[8],_testData[14], false);
                        IPAddressinetE0M.AssertModel(models[9],_testData[15], false);
                        IPAddressinetE0M.AssertModel(models[10],_testData[16], false);
                        IPAddressinetE0M.AssertModel(models[11],_testData[17], false);
                        IPAddressinetE0M.AssertModel(models[12],_testData[18], false);
                        IPAddressinetE0M.AssertModel(models[13],_testData[19], false);
                        IPAddressinetE0M.AssertModel(models[14],_testData[20], false);
                        IPAddressinetE0M.AssertModel(models[15],_testData[21], false);
                        IPAddressinetE0M.AssertModel(models[16],_testData[22], false);
                        IPAddressinetE0M.AssertModel(models[17],_testData[23], false);
                        IPAddressinetE0M.AssertModel(models[18],_testData[24], false);
                        IPAddressinetE0M.AssertModel(models[19],_testData[25], false);
                        IPAddressinetE0M.AssertModel(models[20],_testData[26], false);
                        IPAddressinetE0M.AssertModel(models[21],_testData[27], false);
                        IPAddressinetE0M.AssertModel(models[22],_testData[28], false);
                        IPAddressinetE0M.AssertModel(models[23],_testData[29], false);
                        IPAddressinetE0M.AssertModel(models[24],_testData[30], false);
                        IPAddressinetE0M.AssertModel(models[25],_testData[31], false);
                        IPAddressinetE0M.AssertModel(models[26],_testData[32], false);
                        IPAddressinetE0M.AssertModel(models[27],_testData[33], false);
                        IPAddressinetE0M.AssertModel(models[28],_testData[34], false);
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
                var models = ((IIPAddressSingleTypeinet)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressSingleTypeinet)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        IPAddressinetE0M.AssertModel(models[0],_testData[33], false);
                        IPAddressinetE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        IPAddressinetE0M.AssertModel(models[0],_testData[13], false);
                        IPAddressinetE0M.AssertModel(models[1],_testData[14], false);
                        IPAddressinetE0M.AssertModel(models[2],_testData[15], false);
                        IPAddressinetE0M.AssertModel(models[3],_testData[16], false);
                        IPAddressinetE0M.AssertModel(models[4],_testData[17], false);
                        IPAddressinetE0M.AssertModel(models[5],_testData[18], false);
                        IPAddressinetE0M.AssertModel(models[6],_testData[19], false);
                        IPAddressinetE0M.AssertModel(models[7],_testData[20], false);
                        IPAddressinetE0M.AssertModel(models[8],_testData[21], false);
                        IPAddressinetE0M.AssertModel(models[9],_testData[22], false);
                        IPAddressinetE0M.AssertModel(models[10],_testData[23], false);
                        IPAddressinetE0M.AssertModel(models[11],_testData[24], false);
                        IPAddressinetE0M.AssertModel(models[12],_testData[25], false);
                        IPAddressinetE0M.AssertModel(models[13],_testData[26], false);
                        IPAddressinetE0M.AssertModel(models[14],_testData[27], false);
                        IPAddressinetE0M.AssertModel(models[15],_testData[28], false);
                        IPAddressinetE0M.AssertModel(models[16],_testData[29], false);
                        IPAddressinetE0M.AssertModel(models[17],_testData[30], false);
                        IPAddressinetE0M.AssertModel(models[18],_testData[31], false);
                        IPAddressinetE0M.AssertModel(models[19],_testData[32], false);
                        IPAddressinetE0M.AssertModel(models[20],_testData[33], false);
                        IPAddressinetE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetE0M), typeof(FlatIPAddressinetE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
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
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
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
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
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
FROM public.ipaddressinete0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetE0M>();
                var models2 = new List<FlatIPAddressinetE0M>();
                await((IIPAddressSingleTypeinet)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetE0M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinete0m m
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
FROM public.ipaddressinete0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetE0M>();
                var firstItems2 = new List<FlatIPAddressinetE0M>();
                var secondItems1 = new List<FlatIPAddressinetE0M>();
                var secondItems2 = new List<FlatIPAddressinetE0M>();
                await ((IIPAddressSingleTypeinet)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 114, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatIPAddressinetE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatIPAddressinetE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.ipaddressinete0m m
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
FROM public.ipaddressinete0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetE0M>();
                var firstItems2 = new List<FlatIPAddressinetE0M>();
                var secondItems1 = new List<FlatIPAddressinetE0M>();
                await ((IIPAddressSingleTypeinet)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 158, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinetE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatIPAddressinetE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.ipaddressinete0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinetE0M>();
                var models2 = new List<FlatIPAddressinetE0M>();
                ((IIPAddressSingleTypeinet)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetE0M.AssertModel(models1[i],_testData[i], false);
                    FlatIPAddressinetE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinete0m m
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
FROM public.ipaddressinete0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetE0M>();
                var firstItems2 = new List<FlatIPAddressinetE0M>();
                var secondItems1 = new List<FlatIPAddressinetE0M>();
                var secondItems2 = new List<FlatIPAddressinetE0M>();
                 ((IIPAddressSingleTypeinet)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 86, query1, 148, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatIPAddressinetE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatIPAddressinetE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.ipaddressinete0m m
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
FROM public.ipaddressinete0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetE0M>();
                var firstItems2 = new List<FlatIPAddressinetE0M>();
                var secondItems1 = new List<FlatIPAddressinetE0M>();
                 ((IIPAddressSingleTypeinet)this).DbConnectionMMDynQuerySelectModelBatch(connection, 17, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatIPAddressinetE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatIPAddressinetE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[8],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinetE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
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
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
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
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
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
FROM public.ipaddressinete0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IIPAddressSingleTypeinet)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinete0m m
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
FROM public.ipaddressinete0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressSingleTypeinet)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 34, query1, 36, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatIPAddressinetE0M.AssertModel(models[0],_testData[4], false);
                        FlatIPAddressinetE0M.AssertModel(models[1],_testData[5], false);
                        FlatIPAddressinetE0M.AssertModel(models[2],_testData[6], false);
                        FlatIPAddressinetE0M.AssertModel(models[3],_testData[7], false);
                        FlatIPAddressinetE0M.AssertModel(models[4],_testData[8], false);
                        FlatIPAddressinetE0M.AssertModel(models[5],_testData[9], false);
                        FlatIPAddressinetE0M.AssertModel(models[6],_testData[10], false);
                        FlatIPAddressinetE0M.AssertModel(models[7],_testData[11], false);
                        FlatIPAddressinetE0M.AssertModel(models[8],_testData[12], false);
                        FlatIPAddressinetE0M.AssertModel(models[9],_testData[13], false);
                        FlatIPAddressinetE0M.AssertModel(models[10],_testData[14], false);
                        FlatIPAddressinetE0M.AssertModel(models[11],_testData[15], false);
                        FlatIPAddressinetE0M.AssertModel(models[12],_testData[16], false);
                        FlatIPAddressinetE0M.AssertModel(models[13],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(models[14],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(models[15],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(models[16],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(models[17],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(models[18],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(models[19],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(models[20],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(models[21],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(models[22],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(models[23],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(models[24],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(models[25],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(models[26],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(models[27],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(models[28],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(models[29],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatIPAddressinetE0M.AssertModel(models[0],_testData[5], false);
                        FlatIPAddressinetE0M.AssertModel(models[1],_testData[6], false);
                        FlatIPAddressinetE0M.AssertModel(models[2],_testData[7], false);
                        FlatIPAddressinetE0M.AssertModel(models[3],_testData[8], false);
                        FlatIPAddressinetE0M.AssertModel(models[4],_testData[9], false);
                        FlatIPAddressinetE0M.AssertModel(models[5],_testData[10], false);
                        FlatIPAddressinetE0M.AssertModel(models[6],_testData[11], false);
                        FlatIPAddressinetE0M.AssertModel(models[7],_testData[12], false);
                        FlatIPAddressinetE0M.AssertModel(models[8],_testData[13], false);
                        FlatIPAddressinetE0M.AssertModel(models[9],_testData[14], false);
                        FlatIPAddressinetE0M.AssertModel(models[10],_testData[15], false);
                        FlatIPAddressinetE0M.AssertModel(models[11],_testData[16], false);
                        FlatIPAddressinetE0M.AssertModel(models[12],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(models[13],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(models[14],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(models[15],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(models[16],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(models[17],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(models[18],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(models[19],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(models[20],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(models[21],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(models[22],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(models[23],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(models[24],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(models[25],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(models[26],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(models[27],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(models[28],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(models[29],_testData[34], false);
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
FROM public.ipaddressinete0m m
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
FROM public.ipaddressinete0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetE0M>();
                var secondItems1 = new List<FlatIPAddressinetE0M>();
                var secondItems2 = new List<FlatIPAddressinetE0M>();
                await ((IIPAddressSingleTypeinet)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 9, query1, 86, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatIPAddressinetE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatIPAddressinetE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.ipaddressinete0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IIPAddressSingleTypeinet)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinetE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinete0m m
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
FROM public.ipaddressinete0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressSingleTypeinet)this).DbConnectionSTDynQuerySelectModelBatch(connection, 66, query1, 57, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatIPAddressinetE0M.AssertModel(models[0],_testData[10], false);
                        FlatIPAddressinetE0M.AssertModel(models[1],_testData[11], false);
                        FlatIPAddressinetE0M.AssertModel(models[2],_testData[12], false);
                        FlatIPAddressinetE0M.AssertModel(models[3],_testData[13], false);
                        FlatIPAddressinetE0M.AssertModel(models[4],_testData[14], false);
                        FlatIPAddressinetE0M.AssertModel(models[5],_testData[15], false);
                        FlatIPAddressinetE0M.AssertModel(models[6],_testData[16], false);
                        FlatIPAddressinetE0M.AssertModel(models[7],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(models[8],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(models[9],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(models[10],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(models[11],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(models[12],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(models[13],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(models[14],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(models[15],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(models[16],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(models[17],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(models[18],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(models[19],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(models[20],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(models[21],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(models[22],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(models[23],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatIPAddressinetE0M.AssertModel(models[0],_testData[9], false);
                        FlatIPAddressinetE0M.AssertModel(models[1],_testData[10], false);
                        FlatIPAddressinetE0M.AssertModel(models[2],_testData[11], false);
                        FlatIPAddressinetE0M.AssertModel(models[3],_testData[12], false);
                        FlatIPAddressinetE0M.AssertModel(models[4],_testData[13], false);
                        FlatIPAddressinetE0M.AssertModel(models[5],_testData[14], false);
                        FlatIPAddressinetE0M.AssertModel(models[6],_testData[15], false);
                        FlatIPAddressinetE0M.AssertModel(models[7],_testData[16], false);
                        FlatIPAddressinetE0M.AssertModel(models[8],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(models[9],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(models[10],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(models[11],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(models[12],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(models[13],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(models[14],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(models[15],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(models[16],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(models[17],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(models[18],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(models[19],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(models[20],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(models[21],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(models[22],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(models[23],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(models[24],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(models[25],_testData[34], false);
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
FROM public.ipaddressinete0m m
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
FROM public.ipaddressinete0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinetE0M>();
                var secondItems1 = new List<FlatIPAddressinetE0M>();
                var secondItems2 = new List<FlatIPAddressinetE0M>();
                 ((IIPAddressSingleTypeinet)this).DbConnectionDynQuerySelectModelBatch(connection, 66, query1, 9, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatIPAddressinetE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatIPAddressinetE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatIPAddressinetE0M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.ipaddressinete0m m
LEFT JOIN public.ipaddressinete0mi mi ON mi.id = m.ipaddressinete0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(IPAddressinetE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
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
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
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
                var models = await((IIPAddressSingleTypeinet)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IIPAddressSingleTypeinet)this).DbConnectionSTSelectModelBatchAsync(connection, 100, 43))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        IPAddressinetE0M.AssertModel(models[0],_testData[19], false);
                        IPAddressinetE0M.AssertModel(models[1],_testData[20], false);
                        IPAddressinetE0M.AssertModel(models[2],_testData[21], false);
                        IPAddressinetE0M.AssertModel(models[3],_testData[22], false);
                        IPAddressinetE0M.AssertModel(models[4],_testData[23], false);
                        IPAddressinetE0M.AssertModel(models[5],_testData[24], false);
                        IPAddressinetE0M.AssertModel(models[6],_testData[25], false);
                        IPAddressinetE0M.AssertModel(models[7],_testData[26], false);
                        IPAddressinetE0M.AssertModel(models[8],_testData[27], false);
                        IPAddressinetE0M.AssertModel(models[9],_testData[28], false);
                        IPAddressinetE0M.AssertModel(models[10],_testData[29], false);
                        IPAddressinetE0M.AssertModel(models[11],_testData[30], false);
                        IPAddressinetE0M.AssertModel(models[12],_testData[31], false);
                        IPAddressinetE0M.AssertModel(models[13],_testData[32], false);
                        IPAddressinetE0M.AssertModel(models[14],_testData[33], false);
                        IPAddressinetE0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        IPAddressinetE0M.AssertModel(models[0],_testData[7], false);
                        IPAddressinetE0M.AssertModel(models[1],_testData[8], false);
                        IPAddressinetE0M.AssertModel(models[2],_testData[9], false);
                        IPAddressinetE0M.AssertModel(models[3],_testData[10], false);
                        IPAddressinetE0M.AssertModel(models[4],_testData[11], false);
                        IPAddressinetE0M.AssertModel(models[5],_testData[12], false);
                        IPAddressinetE0M.AssertModel(models[6],_testData[13], false);
                        IPAddressinetE0M.AssertModel(models[7],_testData[14], false);
                        IPAddressinetE0M.AssertModel(models[8],_testData[15], false);
                        IPAddressinetE0M.AssertModel(models[9],_testData[16], false);
                        IPAddressinetE0M.AssertModel(models[10],_testData[17], false);
                        IPAddressinetE0M.AssertModel(models[11],_testData[18], false);
                        IPAddressinetE0M.AssertModel(models[12],_testData[19], false);
                        IPAddressinetE0M.AssertModel(models[13],_testData[20], false);
                        IPAddressinetE0M.AssertModel(models[14],_testData[21], false);
                        IPAddressinetE0M.AssertModel(models[15],_testData[22], false);
                        IPAddressinetE0M.AssertModel(models[16],_testData[23], false);
                        IPAddressinetE0M.AssertModel(models[17],_testData[24], false);
                        IPAddressinetE0M.AssertModel(models[18],_testData[25], false);
                        IPAddressinetE0M.AssertModel(models[19],_testData[26], false);
                        IPAddressinetE0M.AssertModel(models[20],_testData[27], false);
                        IPAddressinetE0M.AssertModel(models[21],_testData[28], false);
                        IPAddressinetE0M.AssertModel(models[22],_testData[29], false);
                        IPAddressinetE0M.AssertModel(models[23],_testData[30], false);
                        IPAddressinetE0M.AssertModel(models[24],_testData[31], false);
                        IPAddressinetE0M.AssertModel(models[25],_testData[32], false);
                        IPAddressinetE0M.AssertModel(models[26],_testData[33], false);
                        IPAddressinetE0M.AssertModel(models[27],_testData[34], false);
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
                var models = ((IIPAddressSingleTypeinet)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    IPAddressinetE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IIPAddressSingleTypeinet)this).DbConnectionSTSelectModelBatch(connection, 153, 39))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        IPAddressinetE0M.AssertModel(models[0],_testData[31], false);
                        IPAddressinetE0M.AssertModel(models[1],_testData[32], false);
                        IPAddressinetE0M.AssertModel(models[2],_testData[33], false);
                        IPAddressinetE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        IPAddressinetE0M.AssertModel(models[0],_testData[6], false);
                        IPAddressinetE0M.AssertModel(models[1],_testData[7], false);
                        IPAddressinetE0M.AssertModel(models[2],_testData[8], false);
                        IPAddressinetE0M.AssertModel(models[3],_testData[9], false);
                        IPAddressinetE0M.AssertModel(models[4],_testData[10], false);
                        IPAddressinetE0M.AssertModel(models[5],_testData[11], false);
                        IPAddressinetE0M.AssertModel(models[6],_testData[12], false);
                        IPAddressinetE0M.AssertModel(models[7],_testData[13], false);
                        IPAddressinetE0M.AssertModel(models[8],_testData[14], false);
                        IPAddressinetE0M.AssertModel(models[9],_testData[15], false);
                        IPAddressinetE0M.AssertModel(models[10],_testData[16], false);
                        IPAddressinetE0M.AssertModel(models[11],_testData[17], false);
                        IPAddressinetE0M.AssertModel(models[12],_testData[18], false);
                        IPAddressinetE0M.AssertModel(models[13],_testData[19], false);
                        IPAddressinetE0M.AssertModel(models[14],_testData[20], false);
                        IPAddressinetE0M.AssertModel(models[15],_testData[21], false);
                        IPAddressinetE0M.AssertModel(models[16],_testData[22], false);
                        IPAddressinetE0M.AssertModel(models[17],_testData[23], false);
                        IPAddressinetE0M.AssertModel(models[18],_testData[24], false);
                        IPAddressinetE0M.AssertModel(models[19],_testData[25], false);
                        IPAddressinetE0M.AssertModel(models[20],_testData[26], false);
                        IPAddressinetE0M.AssertModel(models[21],_testData[27], false);
                        IPAddressinetE0M.AssertModel(models[22],_testData[28], false);
                        IPAddressinetE0M.AssertModel(models[23],_testData[29], false);
                        IPAddressinetE0M.AssertModel(models[24],_testData[30], false);
                        IPAddressinetE0M.AssertModel(models[25],_testData[31], false);
                        IPAddressinetE0M.AssertModel(models[26],_testData[32], false);
                        IPAddressinetE0M.AssertModel(models[27],_testData[33], false);
                        IPAddressinetE0M.AssertModel(models[28],_testData[34], false);
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
                await using var cmd = await ((IIPAddressSingleTypeinet)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IIPAddressSingleTypeinet)this).SetDbConnectionSelectModelParametrs(cmd, 57);
                var models = await ((IIPAddressSingleTypeinet)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                IPAddressinetE0M.AssertModel(models[0],_testData[9], false);
                IPAddressinetE0M.AssertModel(models[1],_testData[10], false);
                IPAddressinetE0M.AssertModel(models[2],_testData[11], false);
                IPAddressinetE0M.AssertModel(models[3],_testData[12], false);
                IPAddressinetE0M.AssertModel(models[4],_testData[13], false);
                IPAddressinetE0M.AssertModel(models[5],_testData[14], false);
                IPAddressinetE0M.AssertModel(models[6],_testData[15], false);
                IPAddressinetE0M.AssertModel(models[7],_testData[16], false);
                IPAddressinetE0M.AssertModel(models[8],_testData[17], false);
                IPAddressinetE0M.AssertModel(models[9],_testData[18], false);
                IPAddressinetE0M.AssertModel(models[10],_testData[19], false);
                IPAddressinetE0M.AssertModel(models[11],_testData[20], false);
                IPAddressinetE0M.AssertModel(models[12],_testData[21], false);
                IPAddressinetE0M.AssertModel(models[13],_testData[22], false);
                IPAddressinetE0M.AssertModel(models[14],_testData[23], false);
                IPAddressinetE0M.AssertModel(models[15],_testData[24], false);
                IPAddressinetE0M.AssertModel(models[16],_testData[25], false);
                IPAddressinetE0M.AssertModel(models[17],_testData[26], false);
                IPAddressinetE0M.AssertModel(models[18],_testData[27], false);
                IPAddressinetE0M.AssertModel(models[19],_testData[28], false);
                IPAddressinetE0M.AssertModel(models[20],_testData[29], false);
                IPAddressinetE0M.AssertModel(models[21],_testData[30], false);
                IPAddressinetE0M.AssertModel(models[22],_testData[31], false);
                IPAddressinetE0M.AssertModel(models[23],_testData[32], false);
                IPAddressinetE0M.AssertModel(models[24],_testData[33], false);
                IPAddressinetE0M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressSingleTypeinet)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressSingleTypeinet)this).SetDbConnectionSelectModelParametrs(cmd, 43);
                var models =  ((IIPAddressSingleTypeinet)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                IPAddressinetE0M.AssertModel(models[0],_testData[7], false);
                IPAddressinetE0M.AssertModel(models[1],_testData[8], false);
                IPAddressinetE0M.AssertModel(models[2],_testData[9], false);
                IPAddressinetE0M.AssertModel(models[3],_testData[10], false);
                IPAddressinetE0M.AssertModel(models[4],_testData[11], false);
                IPAddressinetE0M.AssertModel(models[5],_testData[12], false);
                IPAddressinetE0M.AssertModel(models[6],_testData[13], false);
                IPAddressinetE0M.AssertModel(models[7],_testData[14], false);
                IPAddressinetE0M.AssertModel(models[8],_testData[15], false);
                IPAddressinetE0M.AssertModel(models[9],_testData[16], false);
                IPAddressinetE0M.AssertModel(models[10],_testData[17], false);
                IPAddressinetE0M.AssertModel(models[11],_testData[18], false);
                IPAddressinetE0M.AssertModel(models[12],_testData[19], false);
                IPAddressinetE0M.AssertModel(models[13],_testData[20], false);
                IPAddressinetE0M.AssertModel(models[14],_testData[21], false);
                IPAddressinetE0M.AssertModel(models[15],_testData[22], false);
                IPAddressinetE0M.AssertModel(models[16],_testData[23], false);
                IPAddressinetE0M.AssertModel(models[17],_testData[24], false);
                IPAddressinetE0M.AssertModel(models[18],_testData[25], false);
                IPAddressinetE0M.AssertModel(models[19],_testData[26], false);
                IPAddressinetE0M.AssertModel(models[20],_testData[27], false);
                IPAddressinetE0M.AssertModel(models[21],_testData[28], false);
                IPAddressinetE0M.AssertModel(models[22],_testData[29], false);
                IPAddressinetE0M.AssertModel(models[23],_testData[30], false);
                IPAddressinetE0M.AssertModel(models[24],_testData[31], false);
                IPAddressinetE0M.AssertModel(models[25],_testData[32], false);
                IPAddressinetE0M.AssertModel(models[26],_testData[33], false);
                IPAddressinetE0M.AssertModel(models[27],_testData[34], false);
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
FROM public.ipaddressinete0m m
LEFT JOIN public.ipaddressinete0mi mi ON mi.id = m.ipaddressinete0mi_id
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
            asPartInterface: typeof(IIPAddressSingleTypeinet))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressSingleTypeinet)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("191.205.210.126"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("94.123.39.230"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("20.223.152.71"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("23.231.115.138"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("22.213.246.112"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("202.64.244.56"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("50.95.46.158"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("99.237.172.99"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("198.139.174.134"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("19.3.127.203"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("70.119.51.217"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("61.77.126.56"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("93.254.34.14"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("240.243.180.40"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("51.68.227.170"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("97.131.135.38"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("171.248.243.105"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("22.40.103.213"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("188.229.217.171"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("134.54.147.205"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("150.121.43.137"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("187.53.52.154"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("35.218.73.66"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("165.115.200.132"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("111.169.170.116"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("118.173.93.54"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("37.223.8.199"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("148.5.40.98"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("109.151.125.55"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("184.154.17.57"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("94.217.245.24"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("152.8.177.195"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("248.245.208.108"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("219.168.179.120"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("247.89.162.195"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("58.142.232.133"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("216.195.97.121"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("33.242.23.220"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("227.67.144.244"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("70.7.79.47"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("32.154.127.216"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("7.218.111.58"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("151.109.86.14"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("203.27.172.176"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("28.87.154.187"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("83.231.11.228"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("228.217.89.155"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("101.160.252.105"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("83.228.161.155"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("228.140.56.73"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("98.25.80.120"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("194.181.26.20"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("234.211.235.13"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("145.185.125.118"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("45.16.72.106"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("131.205.60.153"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("151.45.70.116"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("238.4.156.100"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("64.176.52.33"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("210.226.229.143"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("229.187.220.111"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("160.19.109.112"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("14.106.117.30"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("53.145.140.19"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("118.120.224.198"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("11.249.84.117"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("38.84.38.103"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("106.175.216.6"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("37.25.199.137"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("109.163.87.208"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("177.113.24.48"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("60.72.130.14"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("105.66.4.13"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("180.224.161.42"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("110.145.222.201"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("212.183.208.118"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("105.73.235.77"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IIPAddressSingleTypeinet)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("191.205.210.126"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("94.123.39.230"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("20.223.152.71"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("23.231.115.138"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("22.213.246.112"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("202.64.244.56"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("50.95.46.158"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("99.237.172.99"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("198.139.174.134"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("19.3.127.203"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("70.119.51.217"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("61.77.126.56"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("93.254.34.14"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("240.243.180.40"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("51.68.227.170"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("97.131.135.38"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("171.248.243.105"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("22.40.103.213"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("188.229.217.171"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("134.54.147.205"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("150.121.43.137"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("187.53.52.154"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("35.218.73.66"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("165.115.200.132"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("111.169.170.116"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("118.173.93.54"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("37.223.8.199"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("148.5.40.98"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("109.151.125.55"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("184.154.17.57"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("94.217.245.24"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("152.8.177.195"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("248.245.208.108"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("219.168.179.120"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("247.89.162.195"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("58.142.232.133"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("216.195.97.121"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("33.242.23.220"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("227.67.144.244"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("70.7.79.47"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("32.154.127.216"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("7.218.111.58"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("151.109.86.14"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("203.27.172.176"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("28.87.154.187"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("83.231.11.228"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("228.217.89.155"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("101.160.252.105"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("83.228.161.155"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("228.140.56.73"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("98.25.80.120"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("194.181.26.20"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("234.211.235.13"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("145.185.125.118"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("45.16.72.106"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("131.205.60.153"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("151.45.70.116"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("238.4.156.100"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("64.176.52.33"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("210.226.229.143"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("229.187.220.111"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("160.19.109.112"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("14.106.117.30"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("53.145.140.19"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("118.120.224.198"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("11.249.84.117"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("38.84.38.103"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("106.175.216.6"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("37.25.199.137"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("109.163.87.208"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("177.113.24.48"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("60.72.130.14"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("105.66.4.13"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("180.224.161.42"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("110.145.222.201"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("212.183.208.118"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("105.73.235.77"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_ipaddressinete0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(IPAddressinetE0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(24),
                (NpgsqlTypes.NpgsqlDbType)(24)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressSingleTypeinet)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinete0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IIPAddressSingleTypeinet)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressSingleTypeinet)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinete0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IIPAddressSingleTypeinet)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinete0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(IPAddressinetE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressSingleTypeinet)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinete0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IIPAddressSingleTypeinet)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressSingleTypeinet)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinete0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IIPAddressSingleTypeinet)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinete0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinete0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(IPAddressinetE0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(24),
                (NpgsqlTypes.NpgsqlDbType)(24)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IIPAddressSingleTypeinet)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IIPAddressSingleTypeinet)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IIPAddressSingleTypeinet)this).WAImportModelInner(connection, importCollection);
                var models = ((IIPAddressSingleTypeinet)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinete0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinetE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinete0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(IPAddressinetE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressSingleTypeinet)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IIPAddressSingleTypeinet)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinetE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressSingleTypeinet)this).ImportModelInner(connection, importCollection);
                var models = ((IIPAddressSingleTypeinet)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinetE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinete0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
ipaddressinete0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(IPAddressinetE0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(24),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(24)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet))]
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
FROM public.binary_ipaddressinete0m m
LEFT JOIN public.binary_ipaddressinete0mi mi ON mi.id = m.ipaddressinete0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(IPAddressinetE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<IPAddressinetE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IIPAddressSingleTypeinet)this).ImportModelAsync(connection, importCollection);
                var models = await ((IIPAddressSingleTypeinet)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    IPAddressinetE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinetE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IIPAddressSingleTypeinet)this).ImportModel(connection, importCollection);
                var models = ((IIPAddressSingleTypeinet)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    IPAddressinetE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinete0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    ipaddressinete0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(IPAddressinetE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(24),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(24)
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
                var models =  ((IIPAddressSingleTypeinet)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    IPAddressinetE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressSingleTypeinet)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    IPAddressinetE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetE0MIWA), typeof(IPAddressinetE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(24),
                (NpgsqlTypes.NpgsqlDbType)(24)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(24),
                (NpgsqlTypes.NpgsqlDbType)(24)
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
                var models1 = new List<IPAddressinetE0MIWA>();
                var models2 = new List<IPAddressinetE0MIWA>();
                await ((IIPAddressSingleTypeinet)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinete0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetE0MIWA>();
                var models2 = new List<IPAddressinetE0MIWA>();
                ((IIPAddressSingleTypeinet)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinete0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(24),
                (NpgsqlTypes.NpgsqlDbType)(24)
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
                var models = await ((IIPAddressSingleTypeinet)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_ipaddressinete0mi
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
                    IPAddressinetE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressSingleTypeinet)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_ipaddressinete0mi
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
                    IPAddressinetE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinetE0MIWA), typeof(IPAddressinetE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet))]
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
                var models1 = new List<IPAddressinetE0MIWA>();
                var models2 = new List<IPAddressinetE0MIWA>();
                await ((IIPAddressSingleTypeinet)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinete0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetE0MIWA>();
                var models2 = new List<IPAddressinetE0MIWA>();
                ((IIPAddressSingleTypeinet)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_ipaddressinete0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinetE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet))]
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
                var models = await ((IIPAddressSingleTypeinet)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_ipaddressinete0mi
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
                    IPAddressinetE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressSingleTypeinet)this).DynQueryExportModelInner(connection, @"
COPY public.binary_ipaddressinete0mi
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
                    IPAddressinetE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_ipaddressinete0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetE0MI), typeof(IPAddressinetE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(24),
                (NpgsqlTypes.NpgsqlDbType)(24)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(24),
                (NpgsqlTypes.NpgsqlDbType)(24)
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
                var models1 = new List<IPAddressinetE0MI>();
                var models2 = new List<IPAddressinetE0MI>();
                await ((IIPAddressSingleTypeinet)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetE0MI>();
                var models2 = new List<IPAddressinetE0MI>();
                ((IIPAddressSingleTypeinet)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinete0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(IPAddressinetE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(24),
                (NpgsqlTypes.NpgsqlDbType)(24)
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
                var models = await ((IIPAddressSingleTypeinet)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressSingleTypeinet)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_ipaddressinete0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(IPAddressinetE0MIWA), typeof(IPAddressinetE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet))]
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
                var models1 = new List<IPAddressinetE0MIWA>();
                var models2 = new List<IPAddressinetE0MIWA>();
                await ((IIPAddressSingleTypeinet)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinetE0MIWA>();
                var models2 = new List<IPAddressinetE0MIWA>();
                ((IIPAddressSingleTypeinet)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinetE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinetE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinete0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(IPAddressinetE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet))]
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
                var models = await ((IIPAddressSingleTypeinet)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IIPAddressSingleTypeinet)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinetE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

