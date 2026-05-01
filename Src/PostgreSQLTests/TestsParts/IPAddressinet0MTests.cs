

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

        private readonly IPAddressinet0M[] _testData = new IPAddressinet0M[]
        {
            new IPAddressinet0M
{
    Id = 6,
    Value = System.Net.IPAddress.Parse("115.241.173.169"),
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 11,
    Value = System.Net.IPAddress.Parse("119.92.154.79"),
    ModelInner = new IPAddressinet0MI
{
    Id = 1,
    Value = System.Net.IPAddress.Parse("63.230.253.35"),
    NullableValue = System.Net.IPAddress.Parse("30.157.109.77"),
},
    NullableValue = System.Net.IPAddress.Parse("244.26.208.71"),
},
            new IPAddressinet0M
{
    Id = 14,
    Value = System.Net.IPAddress.Parse("245.155.6.158"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("154.218.88.251"),
},
            new IPAddressinet0M
{
    Id = 20,
    Value = System.Net.IPAddress.Parse("130.217.203.155"),
    ModelInner = new IPAddressinet0MI
{
    Id = 10,
    Value = System.Net.IPAddress.Parse("38.33.234.200"),
    NullableValue = System.Net.IPAddress.Parse("222.48.73.136"),
},
    NullableValue = System.Net.IPAddress.Parse("88.19.132.235"),
},
            new IPAddressinet0M
{
    Id = 26,
    Value = System.Net.IPAddress.Parse("64.252.51.250"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("5.83.14.140"),
},
            new IPAddressinet0M
{
    Id = 30,
    Value = System.Net.IPAddress.Parse("102.175.17.167"),
    ModelInner = new IPAddressinet0MI
{
    Id = 18,
    Value = System.Net.IPAddress.Parse("176.155.163.28"),
    NullableValue = System.Net.IPAddress.Parse("64.240.79.101"),
},
    NullableValue = System.Net.IPAddress.Parse("236.115.161.199"),
},
            new IPAddressinet0M
{
    Id = 38,
    Value = System.Net.IPAddress.Parse("135.223.1.207"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("69.113.237.103"),
},
            new IPAddressinet0M
{
    Id = 42,
    Value = System.Net.IPAddress.Parse("62.222.21.174"),
    ModelInner = new IPAddressinet0MI
{
    Id = 27,
    Value = System.Net.IPAddress.Parse("254.146.115.97"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 49,
    Value = System.Net.IPAddress.Parse("243.37.14.195"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("231.62.205.63"),
},
            new IPAddressinet0M
{
    Id = 57,
    Value = System.Net.IPAddress.Parse("99.186.52.244"),
    ModelInner = new IPAddressinet0MI
{
    Id = 29,
    Value = System.Net.IPAddress.Parse("173.124.10.6"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 59,
    Value = System.Net.IPAddress.Parse("140.204.63.164"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("7.247.226.210"),
},
            new IPAddressinet0M
{
    Id = 68,
    Value = System.Net.IPAddress.Parse("174.67.111.59"),
    ModelInner = new IPAddressinet0MI
{
    Id = 31,
    Value = System.Net.IPAddress.Parse("162.121.40.114"),
    NullableValue = System.Net.IPAddress.Parse("251.24.51.111"),
},
    NullableValue = System.Net.IPAddress.Parse("164.149.134.78"),
},
            new IPAddressinet0M
{
    Id = 72,
    Value = System.Net.IPAddress.Parse("182.187.186.174"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("97.174.253.126"),
},
            new IPAddressinet0M
{
    Id = 78,
    Value = System.Net.IPAddress.Parse("204.170.82.252"),
    ModelInner = new IPAddressinet0MI
{
    Id = 40,
    Value = System.Net.IPAddress.Parse("130.176.212.215"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 80,
    Value = System.Net.IPAddress.Parse("129.20.207.48"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("48.127.68.2"),
},
            new IPAddressinet0M
{
    Id = 84,
    Value = System.Net.IPAddress.Parse("37.57.49.220"),
    ModelInner = new IPAddressinet0MI
{
    Id = 42,
    Value = System.Net.IPAddress.Parse("235.44.131.169"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 90,
    Value = System.Net.IPAddress.Parse("9.95.238.118"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("93.26.230.66"),
},
            new IPAddressinet0M
{
    Id = 99,
    Value = System.Net.IPAddress.Parse("231.1.234.42"),
    ModelInner = new IPAddressinet0MI
{
    Id = 43,
    Value = System.Net.IPAddress.Parse("253.161.2.136"),
    NullableValue = System.Net.IPAddress.Parse("119.1.172.153"),
},
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 104,
    Value = System.Net.IPAddress.Parse("31.109.147.157"),
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 105,
    Value = System.Net.IPAddress.Parse("143.45.153.247"),
    ModelInner = new IPAddressinet0MI
{
    Id = 44,
    Value = System.Net.IPAddress.Parse("102.111.112.122"),
    NullableValue = System.Net.IPAddress.Parse("195.77.185.205"),
},
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 113,
    Value = System.Net.IPAddress.Parse("14.49.125.139"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("194.175.72.214"),
},
            new IPAddressinet0M
{
    Id = 120,
    Value = System.Net.IPAddress.Parse("223.228.237.197"),
    ModelInner = new IPAddressinet0MI
{
    Id = 52,
    Value = System.Net.IPAddress.Parse("17.189.142.254"),
    NullableValue = System.Net.IPAddress.Parse("236.81.11.179"),
},
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 125,
    Value = System.Net.IPAddress.Parse("125.182.78.84"),
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 133,
    Value = System.Net.IPAddress.Parse("244.46.194.130"),
    ModelInner = new IPAddressinet0MI
{
    Id = 61,
    Value = System.Net.IPAddress.Parse("1.242.38.158"),
    NullableValue = System.Net.IPAddress.Parse("101.192.174.2"),
},
    NullableValue = System.Net.IPAddress.Parse("52.187.124.218"),
},
            new IPAddressinet0M
{
    Id = 141,
    Value = System.Net.IPAddress.Parse("200.40.8.197"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("144.84.48.104"),
},
            new IPAddressinet0M
{
    Id = 142,
    Value = System.Net.IPAddress.Parse("198.254.229.59"),
    ModelInner = new IPAddressinet0MI
{
    Id = 66,
    Value = System.Net.IPAddress.Parse("101.56.111.37"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 147,
    Value = System.Net.IPAddress.Parse("26.226.15.140"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("248.14.201.94"),
},
            new IPAddressinet0M
{
    Id = 154,
    Value = System.Net.IPAddress.Parse("67.33.93.250"),
    ModelInner = new IPAddressinet0MI
{
    Id = 72,
    Value = System.Net.IPAddress.Parse("139.66.87.147"),
    NullableValue = System.Net.IPAddress.Parse("75.83.197.142"),
},
    NullableValue = System.Net.IPAddress.Parse("168.204.34.64"),
},
            new IPAddressinet0M
{
    Id = 161,
    Value = System.Net.IPAddress.Parse("183.197.94.41"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("144.233.73.25"),
},
            new IPAddressinet0M
{
    Id = 170,
    Value = System.Net.IPAddress.Parse("66.194.213.144"),
    ModelInner = new IPAddressinet0MI
{
    Id = 77,
    Value = System.Net.IPAddress.Parse("254.29.234.159"),
    NullableValue = System.Net.IPAddress.Parse("64.189.165.199"),
},
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 174,
    Value = System.Net.IPAddress.Parse("102.165.114.124"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("111.185.99.175"),
},
            new IPAddressinet0M
{
    Id = 180,
    Value = System.Net.IPAddress.Parse("90.110.131.136"),
    ModelInner = new IPAddressinet0MI
{
    Id = 83,
    Value = System.Net.IPAddress.Parse("43.13.28.10"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("25.197.224.11"),
},
            new IPAddressinet0M
{
    Id = 184,
    Value = System.Net.IPAddress.Parse("79.139.136.133"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("122.239.8.168"),
},
            new IPAddressinet0M
{
    Id = 193,
    Value = System.Net.IPAddress.Parse("91.29.137.11"),
    ModelInner = new IPAddressinet0MI
{
    Id = 88,
    Value = System.Net.IPAddress.Parse("3.117.223.188"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("76.152.239.205"),
},
            new IPAddressinet0M
{
    Id = 198,
    Value = System.Net.IPAddress.Parse("66.113.66.56"),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinet0mi(
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
INSERT INTO public.ipaddressinet0mi(
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
            queryMapTypes: [typeof(IPAddressinet0MI)],
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
INSERT INTO public.ipaddressinet0mi(
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
INSERT INTO public.ipaddressinet0m(
	id,
    value,
    nullablevalue,
    ipaddressinet0mi_id
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
                methodParametrName: "ipaddressinet0mi_id", 
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
INSERT INTO public.ipaddressinet0m(
	id,
    value,
    nullablevalue,
    ipaddressinet0mi_id
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
    ipaddressinet0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(IPAddressinet0M)],
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
                Assert.That(nullable, Is.EqualTo(System.Net.IPAddress.Parse("5.83.14.140")));
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
                Assert.That(nullable, Is.EqualTo(System.Net.IPAddress.Parse("236.115.161.199")));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(System.Net.IPAddress.Parse("69.113.237.103")));
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
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinet0m(
	id,
    value,
    nullablevalue,
    ipaddressinet0mi_id
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
    ipaddressinet0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(IPAddressinet0M)],
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
                methodParametrName: "ipaddressinet0mi_id", 
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(System.Net.IPAddress.Parse("231.62.205.63")));
                nullable =  ((IIPAddressSingleTypeinet)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(System.Net.IPAddress.Parse("7.247.226.210")));
                nullable = await ((IIPAddressSingleTypeinet)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(System.Net.IPAddress.Parse("164.149.134.78")));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinet0M> models = null;

                models =  ((IIPAddressSingleTypeinet)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinet0M.AssertModel(models[0],_testData[12], true);
                models =  ((IIPAddressSingleTypeinet)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinet0M.AssertModel(models[0],_testData[13], true);
                models =  ((IIPAddressSingleTypeinet)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinet0M.AssertModel(models[0],_testData[14], true);
                models =  ((IIPAddressSingleTypeinet)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinet0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<IPAddressinet0M> models = null;

                models = await ((IIPAddressSingleTypeinet)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinet0M.AssertModel(models[0],_testData[16], true);
                models = await ((IIPAddressSingleTypeinet)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinet0M.AssertModel(models[0],_testData[17], true);
                models = await ((IIPAddressSingleTypeinet)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinet0M.AssertModel(models[0],_testData[18], true);
                models = await ((IIPAddressSingleTypeinet)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                IPAddressinet0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.ipaddressinet0m(
	id,
    value,
    nullablevalue,
    ipaddressinet0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @ipaddressinet0mi_id
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
                parametrName: "ipaddressinet0mi_id", 
                methodParametrName: "ipaddressinet0mi_id", 
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
            queryMapTypes: [typeof(FlatIPAddressinet0M), typeof(FlatIPAddressinet0M)],
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
FROM public.ipaddressinet0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatIPAddressinet0M>();
                var models2 = new List<FlatIPAddressinet0M>();
                await ((IIPAddressSingleTypeinet)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinet0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatIPAddressinet0M>();
                var models2 = new List<FlatIPAddressinet0M>();
                ((IIPAddressSingleTypeinet)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinet0M)],
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
FROM public.ipaddressinet0m m
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
                    FlatIPAddressinet0M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinet0m m
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
                    FlatIPAddressinet0M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinet0m m
LEFT JOIN public.ipaddressinet0mi mi ON mi.id = m.ipaddressinet0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(IPAddressinet0M)],
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
                    IPAddressinet0M.AssertModel(models[i],_testData[i], false);
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
                    IPAddressinet0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinet0M), typeof(FlatIPAddressinet0M)],
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
FROM public.ipaddressinet0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinet0M>();
                var models2 = new List<FlatIPAddressinet0M>();
                await ((IIPAddressSingleTypeinet)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinet0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinet0M>();
                var models2 = new List<FlatIPAddressinet0M>();
                ((IIPAddressSingleTypeinet)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinet0M)],
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
FROM public.ipaddressinet0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IIPAddressSingleTypeinet)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinet0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IIPAddressSingleTypeinet)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinet0m m
LEFT JOIN public.ipaddressinet0mi mi ON mi.id = m.ipaddressinet0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(IPAddressinet0M)],
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
                    IPAddressinet0M.AssertModel(models[i],_testData[i], false);
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
                    IPAddressinet0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinet0M), typeof(FlatIPAddressinet0M)],
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
FROM public.ipaddressinet0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatIPAddressinet0M>();
                var models2 = new List<FlatIPAddressinet0M>();
                await((IIPAddressSingleTypeinet)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
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
FROM public.ipaddressinet0m m
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
FROM public.ipaddressinet0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinet0M>();
                var firstItems2 = new List<FlatIPAddressinet0M>();
                var secondItems1 = new List<FlatIPAddressinet0M>();
                var secondItems2 = new List<FlatIPAddressinet0M>();
                await ((IIPAddressSingleTypeinet)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatIPAddressinet0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatIPAddressinet0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
FROM public.ipaddressinet0m m
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
FROM public.ipaddressinet0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinet0M>();
                var firstItems2 = new List<FlatIPAddressinet0M>();
                var secondItems1 = new List<FlatIPAddressinet0M>();
                await ((IIPAddressSingleTypeinet)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatIPAddressinet0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatIPAddressinet0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.ipaddressinet0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatIPAddressinet0M>();
                var models2 = new List<FlatIPAddressinet0M>();
                ((IIPAddressSingleTypeinet)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
FROM public.ipaddressinet0m m
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
FROM public.ipaddressinet0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinet0M>();
                var firstItems2 = new List<FlatIPAddressinet0M>();
                var secondItems1 = new List<FlatIPAddressinet0M>();
                var secondItems2 = new List<FlatIPAddressinet0M>();
                 ((IIPAddressSingleTypeinet)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatIPAddressinet0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatIPAddressinet0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 180;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
FROM public.ipaddressinet0m m
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
FROM public.ipaddressinet0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinet0M>();
                var firstItems2 = new List<FlatIPAddressinet0M>();
                var secondItems1 = new List<FlatIPAddressinet0M>();
                 ((IIPAddressSingleTypeinet)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatIPAddressinet0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatIPAddressinet0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatIPAddressinet0M)],
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
FROM public.ipaddressinet0m m
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
                    FlatIPAddressinet0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 20;
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
FROM public.ipaddressinet0m m
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
FROM public.ipaddressinet0m m
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
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatIPAddressinet0M.AssertModel(models[0],_testData[4], false);
                        FlatIPAddressinet0M.AssertModel(models[1],_testData[5], false);
                        FlatIPAddressinet0M.AssertModel(models[2],_testData[6], false);
                        FlatIPAddressinet0M.AssertModel(models[3],_testData[7], false);
                        FlatIPAddressinet0M.AssertModel(models[4],_testData[8], false);
                        FlatIPAddressinet0M.AssertModel(models[5],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(models[6],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(models[7],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(models[8],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(models[9],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(models[10],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(models[11],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(models[12],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(models[13],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(models[14],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(models[15],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(models[16],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(models[17],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(models[18],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(models[19],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(models[20],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(models[21],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(models[22],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(models[23],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(models[24],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(models[25],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(models[26],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(models[27],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(models[28],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(models[29],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatIPAddressinet0M.AssertModel(models[0],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(models[1],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(models[2],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(models[3],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(models[4],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(models[5],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(models[6],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(models[7],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 184;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinet0m m
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
FROM public.ipaddressinet0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinet0M>();
                var secondItems1 = new List<FlatIPAddressinet0M>();
                var secondItems2 = new List<FlatIPAddressinet0M>();
                await ((IIPAddressSingleTypeinet)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatIPAddressinet0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatIPAddressinet0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.ipaddressinet0m m
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
                    FlatIPAddressinet0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 90;
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
FROM public.ipaddressinet0m m
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
FROM public.ipaddressinet0m m
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatIPAddressinet0M.AssertModel(models[0],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(models[1],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(models[2],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(models[3],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(models[4],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(models[5],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(models[6],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(models[7],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(models[8],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(models[9],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(models[10],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(models[11],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(models[12],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(models[13],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(models[14],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(models[15],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(models[16],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatIPAddressinet0M.AssertModel(models[0],_testData[8], false);
                        FlatIPAddressinet0M.AssertModel(models[1],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(models[2],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(models[3],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(models[4],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(models[5],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(models[6],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(models[7],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(models[8],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(models[9],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(models[10],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(models[11],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(models[12],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(models[13],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(models[14],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(models[15],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(models[16],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(models[17],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(models[18],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(models[19],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(models[20],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(models[21],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(models[22],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(models[23],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(models[24],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(models[25],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 184;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.ipaddressinet0m m
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
FROM public.ipaddressinet0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinet0M>();
                var secondItems1 = new List<FlatIPAddressinet0M>();
                var secondItems2 = new List<FlatIPAddressinet0M>();
                 ((IIPAddressSingleTypeinet)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatIPAddressinet0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatIPAddressinet0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.ipaddressinet0m m
LEFT JOIN public.ipaddressinet0mi mi ON mi.id = m.ipaddressinet0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(IPAddressinet0M)],
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
                    IPAddressinet0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressSingleTypeinet)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        IPAddressinet0M.AssertModel(models[0],_testData[18], false);
                        IPAddressinet0M.AssertModel(models[1],_testData[19], false);
                        IPAddressinet0M.AssertModel(models[2],_testData[20], false);
                        IPAddressinet0M.AssertModel(models[3],_testData[21], false);
                        IPAddressinet0M.AssertModel(models[4],_testData[22], false);
                        IPAddressinet0M.AssertModel(models[5],_testData[23], false);
                        IPAddressinet0M.AssertModel(models[6],_testData[24], false);
                        IPAddressinet0M.AssertModel(models[7],_testData[25], false);
                        IPAddressinet0M.AssertModel(models[8],_testData[26], false);
                        IPAddressinet0M.AssertModel(models[9],_testData[27], false);
                        IPAddressinet0M.AssertModel(models[10],_testData[28], false);
                        IPAddressinet0M.AssertModel(models[11],_testData[29], false);
                        IPAddressinet0M.AssertModel(models[12],_testData[30], false);
                        IPAddressinet0M.AssertModel(models[13],_testData[31], false);
                        IPAddressinet0M.AssertModel(models[14],_testData[32], false);
                        IPAddressinet0M.AssertModel(models[15],_testData[33], false);
                        IPAddressinet0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        IPAddressinet0M.AssertModel(models[0],_testData[29], false);
                        IPAddressinet0M.AssertModel(models[1],_testData[30], false);
                        IPAddressinet0M.AssertModel(models[2],_testData[31], false);
                        IPAddressinet0M.AssertModel(models[3],_testData[32], false);
                        IPAddressinet0M.AssertModel(models[4],_testData[33], false);
                        IPAddressinet0M.AssertModel(models[5],_testData[34], false);
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
                    IPAddressinet0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 184;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressSingleTypeinet)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        IPAddressinet0M.AssertModel(models[0],_testData[33], false);
                        IPAddressinet0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        IPAddressinet0M.AssertModel(models[0],_testData[16], false);
                        IPAddressinet0M.AssertModel(models[1],_testData[17], false);
                        IPAddressinet0M.AssertModel(models[2],_testData[18], false);
                        IPAddressinet0M.AssertModel(models[3],_testData[19], false);
                        IPAddressinet0M.AssertModel(models[4],_testData[20], false);
                        IPAddressinet0M.AssertModel(models[5],_testData[21], false);
                        IPAddressinet0M.AssertModel(models[6],_testData[22], false);
                        IPAddressinet0M.AssertModel(models[7],_testData[23], false);
                        IPAddressinet0M.AssertModel(models[8],_testData[24], false);
                        IPAddressinet0M.AssertModel(models[9],_testData[25], false);
                        IPAddressinet0M.AssertModel(models[10],_testData[26], false);
                        IPAddressinet0M.AssertModel(models[11],_testData[27], false);
                        IPAddressinet0M.AssertModel(models[12],_testData[28], false);
                        IPAddressinet0M.AssertModel(models[13],_testData[29], false);
                        IPAddressinet0M.AssertModel(models[14],_testData[30], false);
                        IPAddressinet0M.AssertModel(models[15],_testData[31], false);
                        IPAddressinet0M.AssertModel(models[16],_testData[32], false);
                        IPAddressinet0M.AssertModel(models[17],_testData[33], false);
                        IPAddressinet0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinet0M), typeof(FlatIPAddressinet0M)],
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
FROM public.ipaddressinet0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinet0M>();
                var models2 = new List<FlatIPAddressinet0M>();
                await((IIPAddressSingleTypeinet)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinet0m m
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
FROM public.ipaddressinet0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinet0M>();
                var firstItems2 = new List<FlatIPAddressinet0M>();
                var secondItems1 = new List<FlatIPAddressinet0M>();
                var secondItems2 = new List<FlatIPAddressinet0M>();
                await ((IIPAddressSingleTypeinet)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 170, query1, 59, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatIPAddressinet0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatIPAddressinet0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.ipaddressinet0m m
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
FROM public.ipaddressinet0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinet0M>();
                var firstItems2 = new List<FlatIPAddressinet0M>();
                var secondItems1 = new List<FlatIPAddressinet0M>();
                await ((IIPAddressSingleTypeinet)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 78, query1, 84, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatIPAddressinet0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatIPAddressinet0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.ipaddressinet0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatIPAddressinet0M>();
                var models2 = new List<FlatIPAddressinet0M>();
                ((IIPAddressSingleTypeinet)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.ipaddressinet0m m
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
FROM public.ipaddressinet0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinet0M>();
                var firstItems2 = new List<FlatIPAddressinet0M>();
                var secondItems1 = new List<FlatIPAddressinet0M>();
                var secondItems2 = new List<FlatIPAddressinet0M>();
                 ((IIPAddressSingleTypeinet)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 99, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatIPAddressinet0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatIPAddressinet0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.ipaddressinet0m m
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
FROM public.ipaddressinet0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinet0M>();
                var firstItems2 = new List<FlatIPAddressinet0M>();
                var secondItems1 = new List<FlatIPAddressinet0M>();
                 ((IIPAddressSingleTypeinet)this).DbConnectionMMDynQuerySelectModelBatch(connection, 90, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatIPAddressinet0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatIPAddressinet0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatIPAddressinet0M)],
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
FROM public.ipaddressinet0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IIPAddressSingleTypeinet)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinet0m m
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
FROM public.ipaddressinet0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressSingleTypeinet)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 6, query1, 14, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatIPAddressinet0M.AssertModel(models[0],_testData[1], false);
                        FlatIPAddressinet0M.AssertModel(models[1],_testData[2], false);
                        FlatIPAddressinet0M.AssertModel(models[2],_testData[3], false);
                        FlatIPAddressinet0M.AssertModel(models[3],_testData[4], false);
                        FlatIPAddressinet0M.AssertModel(models[4],_testData[5], false);
                        FlatIPAddressinet0M.AssertModel(models[5],_testData[6], false);
                        FlatIPAddressinet0M.AssertModel(models[6],_testData[7], false);
                        FlatIPAddressinet0M.AssertModel(models[7],_testData[8], false);
                        FlatIPAddressinet0M.AssertModel(models[8],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(models[9],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(models[10],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(models[11],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(models[12],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(models[13],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(models[14],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(models[15],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(models[16],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(models[17],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(models[18],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(models[19],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(models[20],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(models[21],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(models[22],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(models[23],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(models[24],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(models[25],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(models[26],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(models[27],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(models[28],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(models[29],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(models[30],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(models[31],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(models[32],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatIPAddressinet0M.AssertModel(models[0],_testData[3], false);
                        FlatIPAddressinet0M.AssertModel(models[1],_testData[4], false);
                        FlatIPAddressinet0M.AssertModel(models[2],_testData[5], false);
                        FlatIPAddressinet0M.AssertModel(models[3],_testData[6], false);
                        FlatIPAddressinet0M.AssertModel(models[4],_testData[7], false);
                        FlatIPAddressinet0M.AssertModel(models[5],_testData[8], false);
                        FlatIPAddressinet0M.AssertModel(models[6],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(models[7],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(models[8],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(models[9],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(models[10],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(models[11],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(models[12],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(models[13],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(models[14],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(models[15],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(models[16],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(models[17],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(models[18],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(models[19],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(models[20],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(models[21],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(models[22],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(models[23],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(models[24],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(models[25],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(models[26],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(models[27],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(models[28],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(models[29],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(models[30],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(models[31],_testData[34], false);
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
FROM public.ipaddressinet0m m
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
FROM public.ipaddressinet0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinet0M>();
                var secondItems1 = new List<FlatIPAddressinet0M>();
                var secondItems2 = new List<FlatIPAddressinet0M>();
                await ((IIPAddressSingleTypeinet)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 26, query1, 78, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatIPAddressinet0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatIPAddressinet0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.ipaddressinet0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IIPAddressSingleTypeinet)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models[i],_testData[i], false);
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
FROM public.ipaddressinet0m m
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
FROM public.ipaddressinet0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressSingleTypeinet)this).DbConnectionSTDynQuerySelectModelBatch(connection, 184, query1, 49, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatIPAddressinet0M.AssertModel(models[0],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatIPAddressinet0M.AssertModel(models[0],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(models[1],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(models[2],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(models[3],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(models[4],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(models[5],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(models[6],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(models[7],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(models[8],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(models[9],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(models[10],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(models[11],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(models[12],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(models[13],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(models[14],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(models[15],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(models[16],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(models[17],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(models[18],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(models[19],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(models[20],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(models[21],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(models[22],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(models[23],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(models[24],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(models[25],_testData[34], false);
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
FROM public.ipaddressinet0m m
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
FROM public.ipaddressinet0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatIPAddressinet0M>();
                var secondItems1 = new List<FlatIPAddressinet0M>();
                var secondItems2 = new List<FlatIPAddressinet0M>();
                 ((IIPAddressSingleTypeinet)this).DbConnectionDynQuerySelectModelBatch(connection, 161, query1, 80, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatIPAddressinet0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatIPAddressinet0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.ipaddressinet0m m
LEFT JOIN public.ipaddressinet0mi mi ON mi.id = m.ipaddressinet0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(IPAddressinet0M)],
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
                    IPAddressinet0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IIPAddressSingleTypeinet)this).DbConnectionSTSelectModelBatchAsync(connection, 14, 147))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        IPAddressinet0M.AssertModel(models[0],_testData[3], false);
                        IPAddressinet0M.AssertModel(models[1],_testData[4], false);
                        IPAddressinet0M.AssertModel(models[2],_testData[5], false);
                        IPAddressinet0M.AssertModel(models[3],_testData[6], false);
                        IPAddressinet0M.AssertModel(models[4],_testData[7], false);
                        IPAddressinet0M.AssertModel(models[5],_testData[8], false);
                        IPAddressinet0M.AssertModel(models[6],_testData[9], false);
                        IPAddressinet0M.AssertModel(models[7],_testData[10], false);
                        IPAddressinet0M.AssertModel(models[8],_testData[11], false);
                        IPAddressinet0M.AssertModel(models[9],_testData[12], false);
                        IPAddressinet0M.AssertModel(models[10],_testData[13], false);
                        IPAddressinet0M.AssertModel(models[11],_testData[14], false);
                        IPAddressinet0M.AssertModel(models[12],_testData[15], false);
                        IPAddressinet0M.AssertModel(models[13],_testData[16], false);
                        IPAddressinet0M.AssertModel(models[14],_testData[17], false);
                        IPAddressinet0M.AssertModel(models[15],_testData[18], false);
                        IPAddressinet0M.AssertModel(models[16],_testData[19], false);
                        IPAddressinet0M.AssertModel(models[17],_testData[20], false);
                        IPAddressinet0M.AssertModel(models[18],_testData[21], false);
                        IPAddressinet0M.AssertModel(models[19],_testData[22], false);
                        IPAddressinet0M.AssertModel(models[20],_testData[23], false);
                        IPAddressinet0M.AssertModel(models[21],_testData[24], false);
                        IPAddressinet0M.AssertModel(models[22],_testData[25], false);
                        IPAddressinet0M.AssertModel(models[23],_testData[26], false);
                        IPAddressinet0M.AssertModel(models[24],_testData[27], false);
                        IPAddressinet0M.AssertModel(models[25],_testData[28], false);
                        IPAddressinet0M.AssertModel(models[26],_testData[29], false);
                        IPAddressinet0M.AssertModel(models[27],_testData[30], false);
                        IPAddressinet0M.AssertModel(models[28],_testData[31], false);
                        IPAddressinet0M.AssertModel(models[29],_testData[32], false);
                        IPAddressinet0M.AssertModel(models[30],_testData[33], false);
                        IPAddressinet0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        IPAddressinet0M.AssertModel(models[0],_testData[27], false);
                        IPAddressinet0M.AssertModel(models[1],_testData[28], false);
                        IPAddressinet0M.AssertModel(models[2],_testData[29], false);
                        IPAddressinet0M.AssertModel(models[3],_testData[30], false);
                        IPAddressinet0M.AssertModel(models[4],_testData[31], false);
                        IPAddressinet0M.AssertModel(models[5],_testData[32], false);
                        IPAddressinet0M.AssertModel(models[6],_testData[33], false);
                        IPAddressinet0M.AssertModel(models[7],_testData[34], false);
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
                    IPAddressinet0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IIPAddressSingleTypeinet)this).DbConnectionSTSelectModelBatch(connection, 14, 26))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        IPAddressinet0M.AssertModel(models[0],_testData[3], false);
                        IPAddressinet0M.AssertModel(models[1],_testData[4], false);
                        IPAddressinet0M.AssertModel(models[2],_testData[5], false);
                        IPAddressinet0M.AssertModel(models[3],_testData[6], false);
                        IPAddressinet0M.AssertModel(models[4],_testData[7], false);
                        IPAddressinet0M.AssertModel(models[5],_testData[8], false);
                        IPAddressinet0M.AssertModel(models[6],_testData[9], false);
                        IPAddressinet0M.AssertModel(models[7],_testData[10], false);
                        IPAddressinet0M.AssertModel(models[8],_testData[11], false);
                        IPAddressinet0M.AssertModel(models[9],_testData[12], false);
                        IPAddressinet0M.AssertModel(models[10],_testData[13], false);
                        IPAddressinet0M.AssertModel(models[11],_testData[14], false);
                        IPAddressinet0M.AssertModel(models[12],_testData[15], false);
                        IPAddressinet0M.AssertModel(models[13],_testData[16], false);
                        IPAddressinet0M.AssertModel(models[14],_testData[17], false);
                        IPAddressinet0M.AssertModel(models[15],_testData[18], false);
                        IPAddressinet0M.AssertModel(models[16],_testData[19], false);
                        IPAddressinet0M.AssertModel(models[17],_testData[20], false);
                        IPAddressinet0M.AssertModel(models[18],_testData[21], false);
                        IPAddressinet0M.AssertModel(models[19],_testData[22], false);
                        IPAddressinet0M.AssertModel(models[20],_testData[23], false);
                        IPAddressinet0M.AssertModel(models[21],_testData[24], false);
                        IPAddressinet0M.AssertModel(models[22],_testData[25], false);
                        IPAddressinet0M.AssertModel(models[23],_testData[26], false);
                        IPAddressinet0M.AssertModel(models[24],_testData[27], false);
                        IPAddressinet0M.AssertModel(models[25],_testData[28], false);
                        IPAddressinet0M.AssertModel(models[26],_testData[29], false);
                        IPAddressinet0M.AssertModel(models[27],_testData[30], false);
                        IPAddressinet0M.AssertModel(models[28],_testData[31], false);
                        IPAddressinet0M.AssertModel(models[29],_testData[32], false);
                        IPAddressinet0M.AssertModel(models[30],_testData[33], false);
                        IPAddressinet0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        IPAddressinet0M.AssertModel(models[0],_testData[5], false);
                        IPAddressinet0M.AssertModel(models[1],_testData[6], false);
                        IPAddressinet0M.AssertModel(models[2],_testData[7], false);
                        IPAddressinet0M.AssertModel(models[3],_testData[8], false);
                        IPAddressinet0M.AssertModel(models[4],_testData[9], false);
                        IPAddressinet0M.AssertModel(models[5],_testData[10], false);
                        IPAddressinet0M.AssertModel(models[6],_testData[11], false);
                        IPAddressinet0M.AssertModel(models[7],_testData[12], false);
                        IPAddressinet0M.AssertModel(models[8],_testData[13], false);
                        IPAddressinet0M.AssertModel(models[9],_testData[14], false);
                        IPAddressinet0M.AssertModel(models[10],_testData[15], false);
                        IPAddressinet0M.AssertModel(models[11],_testData[16], false);
                        IPAddressinet0M.AssertModel(models[12],_testData[17], false);
                        IPAddressinet0M.AssertModel(models[13],_testData[18], false);
                        IPAddressinet0M.AssertModel(models[14],_testData[19], false);
                        IPAddressinet0M.AssertModel(models[15],_testData[20], false);
                        IPAddressinet0M.AssertModel(models[16],_testData[21], false);
                        IPAddressinet0M.AssertModel(models[17],_testData[22], false);
                        IPAddressinet0M.AssertModel(models[18],_testData[23], false);
                        IPAddressinet0M.AssertModel(models[19],_testData[24], false);
                        IPAddressinet0M.AssertModel(models[20],_testData[25], false);
                        IPAddressinet0M.AssertModel(models[21],_testData[26], false);
                        IPAddressinet0M.AssertModel(models[22],_testData[27], false);
                        IPAddressinet0M.AssertModel(models[23],_testData[28], false);
                        IPAddressinet0M.AssertModel(models[24],_testData[29], false);
                        IPAddressinet0M.AssertModel(models[25],_testData[30], false);
                        IPAddressinet0M.AssertModel(models[26],_testData[31], false);
                        IPAddressinet0M.AssertModel(models[27],_testData[32], false);
                        IPAddressinet0M.AssertModel(models[28],_testData[33], false);
                        IPAddressinet0M.AssertModel(models[29],_testData[34], false);
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
                ((IIPAddressSingleTypeinet)this).SetDbConnectionSelectModelParametrs(cmd, 26);
                var models = await ((IIPAddressSingleTypeinet)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(30));
IPAddressinet0M.AssertModel(models[0],_testData[5], false);IPAddressinet0M.AssertModel(models[1],_testData[6], false);IPAddressinet0M.AssertModel(models[2],_testData[7], false);IPAddressinet0M.AssertModel(models[3],_testData[8], false);IPAddressinet0M.AssertModel(models[4],_testData[9], false);IPAddressinet0M.AssertModel(models[5],_testData[10], false);IPAddressinet0M.AssertModel(models[6],_testData[11], false);IPAddressinet0M.AssertModel(models[7],_testData[12], false);IPAddressinet0M.AssertModel(models[8],_testData[13], false);IPAddressinet0M.AssertModel(models[9],_testData[14], false);IPAddressinet0M.AssertModel(models[10],_testData[15], false);IPAddressinet0M.AssertModel(models[11],_testData[16], false);IPAddressinet0M.AssertModel(models[12],_testData[17], false);IPAddressinet0M.AssertModel(models[13],_testData[18], false);IPAddressinet0M.AssertModel(models[14],_testData[19], false);IPAddressinet0M.AssertModel(models[15],_testData[20], false);IPAddressinet0M.AssertModel(models[16],_testData[21], false);IPAddressinet0M.AssertModel(models[17],_testData[22], false);IPAddressinet0M.AssertModel(models[18],_testData[23], false);IPAddressinet0M.AssertModel(models[19],_testData[24], false);IPAddressinet0M.AssertModel(models[20],_testData[25], false);IPAddressinet0M.AssertModel(models[21],_testData[26], false);IPAddressinet0M.AssertModel(models[22],_testData[27], false);IPAddressinet0M.AssertModel(models[23],_testData[28], false);IPAddressinet0M.AssertModel(models[24],_testData[29], false);IPAddressinet0M.AssertModel(models[25],_testData[30], false);IPAddressinet0M.AssertModel(models[26],_testData[31], false);IPAddressinet0M.AssertModel(models[27],_testData[32], false);IPAddressinet0M.AssertModel(models[28],_testData[33], false);IPAddressinet0M.AssertModel(models[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressSingleTypeinet)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressSingleTypeinet)this).SetDbConnectionSelectModelParametrs(cmd, 147);
                var models =  ((IIPAddressSingleTypeinet)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
IPAddressinet0M.AssertModel(models[0],_testData[27], false);IPAddressinet0M.AssertModel(models[1],_testData[28], false);IPAddressinet0M.AssertModel(models[2],_testData[29], false);IPAddressinet0M.AssertModel(models[3],_testData[30], false);IPAddressinet0M.AssertModel(models[4],_testData[31], false);IPAddressinet0M.AssertModel(models[5],_testData[32], false);IPAddressinet0M.AssertModel(models[6],_testData[33], false);IPAddressinet0M.AssertModel(models[7],_testData[34], false);
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
FROM public.ipaddressinet0m m
LEFT JOIN public.ipaddressinet0mi mi ON mi.id = m.ipaddressinet0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("115.241.173.169"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("119.92.154.79"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("63.230.253.35"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("30.157.109.77"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("244.26.208.71"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("245.155.6.158"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("154.218.88.251"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("130.217.203.155"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("38.33.234.200"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("222.48.73.136"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("88.19.132.235"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("64.252.51.250"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("5.83.14.140"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("102.175.17.167"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("176.155.163.28"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("64.240.79.101"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("236.115.161.199"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("135.223.1.207"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("69.113.237.103"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("62.222.21.174"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("254.146.115.97"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("243.37.14.195"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("231.62.205.63"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("99.186.52.244"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("173.124.10.6"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("140.204.63.164"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("7.247.226.210"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("174.67.111.59"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("162.121.40.114"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("251.24.51.111"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("164.149.134.78"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("182.187.186.174"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("97.174.253.126"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("204.170.82.252"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("130.176.212.215"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("129.20.207.48"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("48.127.68.2"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("37.57.49.220"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("235.44.131.169"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("9.95.238.118"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("93.26.230.66"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("231.1.234.42"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("253.161.2.136"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("119.1.172.153"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("31.109.147.157"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("143.45.153.247"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("102.111.112.122"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("195.77.185.205"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("14.49.125.139"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("194.175.72.214"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("223.228.237.197"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("17.189.142.254"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("236.81.11.179"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("125.182.78.84"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("244.46.194.130"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("1.242.38.158"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("101.192.174.2"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("52.187.124.218"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("200.40.8.197"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("144.84.48.104"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("198.254.229.59"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("101.56.111.37"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("26.226.15.140"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("248.14.201.94"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("67.33.93.250"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("139.66.87.147"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("75.83.197.142"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("168.204.34.64"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("183.197.94.41"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("144.233.73.25"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("66.194.213.144"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("254.29.234.159"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("64.189.165.199"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("102.165.114.124"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("111.185.99.175"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("90.110.131.136"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("43.13.28.10"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("25.197.224.11"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((184)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("79.139.136.133"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("122.239.8.168"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((193)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("91.29.137.11"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("3.117.223.188"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("76.152.239.205"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((198)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("66.113.66.56"))));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("115.241.173.169"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("119.92.154.79"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("63.230.253.35"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("30.157.109.77"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("244.26.208.71"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("245.155.6.158"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("154.218.88.251"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("130.217.203.155"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("38.33.234.200"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("222.48.73.136"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("88.19.132.235"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("64.252.51.250"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("5.83.14.140"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("102.175.17.167"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("176.155.163.28"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("64.240.79.101"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("236.115.161.199"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("135.223.1.207"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("69.113.237.103"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("62.222.21.174"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("254.146.115.97"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("243.37.14.195"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("231.62.205.63"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("99.186.52.244"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("173.124.10.6"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("140.204.63.164"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("7.247.226.210"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("174.67.111.59"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("162.121.40.114"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("251.24.51.111"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("164.149.134.78"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("182.187.186.174"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("97.174.253.126"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("204.170.82.252"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("130.176.212.215"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("129.20.207.48"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("48.127.68.2"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("37.57.49.220"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("235.44.131.169"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("9.95.238.118"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("93.26.230.66"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("231.1.234.42"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("253.161.2.136"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("119.1.172.153"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("31.109.147.157"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("143.45.153.247"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("102.111.112.122"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("195.77.185.205"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("14.49.125.139"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("194.175.72.214"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("223.228.237.197"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("17.189.142.254"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("236.81.11.179"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("125.182.78.84"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("244.46.194.130"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("1.242.38.158"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("101.192.174.2"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("52.187.124.218"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("200.40.8.197"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("144.84.48.104"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("198.254.229.59"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("101.56.111.37"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("26.226.15.140"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("248.14.201.94"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("67.33.93.250"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("139.66.87.147"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("75.83.197.142"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("168.204.34.64"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("183.197.94.41"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("144.233.73.25"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("66.194.213.144"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("254.29.234.159"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("64.189.165.199"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("102.165.114.124"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("111.185.99.175"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("90.110.131.136"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("43.13.28.10"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("25.197.224.11"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((184)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("79.139.136.133"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("122.239.8.168"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((193)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("91.29.137.11"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("3.117.223.188"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("76.152.239.205"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((198)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("66.113.66.56"))));//Value

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
FROM public.binary_ipaddressinet0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinet0MIWA)],
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
            queryMapType: typeof(IPAddressinet0MIWA),
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
                var importCollection = new List<IPAddressinet0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinet0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressSingleTypeinet)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinet0mi
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
                    IPAddressinet0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinet0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinet0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressSingleTypeinet)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinet0mi
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
                    IPAddressinet0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinet0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinet0MIWA)],
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
            queryMapType: typeof(IPAddressinet0MIWA),
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
                var importCollection = new List<IPAddressinet0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinet0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IIPAddressSingleTypeinet)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinet0mi
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
                    IPAddressinet0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinet0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinet0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IIPAddressSingleTypeinet)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinet0mi
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
                    IPAddressinet0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinet0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinet0MI)],
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
COPY public.binary_ipaddressinet0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(IPAddressinet0MI),
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
                var importCollection = new List<IPAddressinet0MI>(2);
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
                    IPAddressinet0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinet0MI>(2);
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
                    IPAddressinet0MI.AssertModel(actual, expect, false);
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
FROM public.binary_ipaddressinet0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinet0MIWA)],
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
COPY public.binary_ipaddressinet0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(IPAddressinet0MIWA),
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
                var importCollection = new List<IPAddressinet0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinet0MIWA
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
                    IPAddressinet0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinet0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new IPAddressinet0MIWA
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
                    IPAddressinet0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_ipaddressinet0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
ipaddressinet0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(IPAddressinet0M),
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
FROM public.binary_ipaddressinet0m m
LEFT JOIN public.binary_ipaddressinet0mi mi ON mi.id = m.ipaddressinet0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(IPAddressinet0M)],
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
                var importCollection = new List<IPAddressinet0M>();
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
                    IPAddressinet0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<IPAddressinet0M>();
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
                    IPAddressinet0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinet0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    ipaddressinet0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(IPAddressinet0M)],
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
                    IPAddressinet0M.AssertModel(model, expectedModel, true);
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
                    IPAddressinet0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinet0MIWA), typeof(IPAddressinet0MIWA)],
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
                var models1 = new List<IPAddressinet0MIWA>();
                var models2 = new List<IPAddressinet0MIWA>();
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
    FROM public.binary_ipaddressinet0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinet0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinet0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinet0MIWA>();
                var models2 = new List<IPAddressinet0MIWA>();
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
    FROM public.binary_ipaddressinet0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinet0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinet0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinet0MIWA)],
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
COPY public.binary_ipaddressinet0mi
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
                    IPAddressinet0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_ipaddressinet0mi
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
                    IPAddressinet0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinet0MIWA), typeof(IPAddressinet0MIWA)],
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
                var models1 = new List<IPAddressinet0MIWA>();
                var models2 = new List<IPAddressinet0MIWA>();
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
    FROM public.binary_ipaddressinet0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinet0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinet0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinet0MIWA>();
                var models2 = new List<IPAddressinet0MIWA>();
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
    FROM public.binary_ipaddressinet0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinet0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinet0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(IPAddressinet0MIWA)],
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
COPY public.binary_ipaddressinet0mi
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
                    IPAddressinet0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_ipaddressinet0mi
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
                    IPAddressinet0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_ipaddressinet0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(IPAddressinet0MI), typeof(IPAddressinet0MI)],
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
                var models1 = new List<IPAddressinet0MI>();
                var models2 = new List<IPAddressinet0MI>();
                await ((IIPAddressSingleTypeinet)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinet0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinet0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinet0MI>();
                var models2 = new List<IPAddressinet0MI>();
                ((IIPAddressSingleTypeinet)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinet0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinet0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinet0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(IPAddressinet0MI)],
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
                    IPAddressinet0MI.AssertModel(model, expectedModel, false);
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
                    IPAddressinet0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_ipaddressinet0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(IPAddressinet0MIWA), typeof(IPAddressinet0MIWA)],
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
                var models1 = new List<IPAddressinet0MIWA>();
                var models2 = new List<IPAddressinet0MIWA>();
                await ((IIPAddressSingleTypeinet)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinet0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinet0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<IPAddressinet0MIWA>();
                var models2 = new List<IPAddressinet0MIWA>();
                ((IIPAddressSingleTypeinet)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    IPAddressinet0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    IPAddressinet0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_ipaddressinet0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(IPAddressinet0MIWA)],
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
                    IPAddressinet0MIWA.AssertModel(model, expectedModel, false);
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
                    IPAddressinet0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

