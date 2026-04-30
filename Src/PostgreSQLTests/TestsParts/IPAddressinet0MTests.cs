

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
    Id = 3,
    Value = System.Net.IPAddress.Parse("114.193.144.241"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("166.44.131.0"),
},
            new IPAddressinet0M
{
    Id = 12,
    Value = System.Net.IPAddress.Parse("149.159.86.202"),
    ModelInner = new IPAddressinet0MI
{
    Id = 8,
    Value = System.Net.IPAddress.Parse("203.71.75.0"),
    NullableValue = System.Net.IPAddress.Parse("116.244.250.19"),
},
    NullableValue = System.Net.IPAddress.Parse("66.175.205.94"),
},
            new IPAddressinet0M
{
    Id = 17,
    Value = System.Net.IPAddress.Parse("196.230.223.13"),
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 21,
    Value = System.Net.IPAddress.Parse("84.248.61.42"),
    ModelInner = new IPAddressinet0MI
{
    Id = 10,
    Value = System.Net.IPAddress.Parse("32.14.61.248"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("154.164.161.221"),
},
            new IPAddressinet0M
{
    Id = 24,
    Value = System.Net.IPAddress.Parse("177.172.33.82"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("8.89.206.27"),
},
            new IPAddressinet0M
{
    Id = 26,
    Value = System.Net.IPAddress.Parse("216.84.180.69"),
    ModelInner = new IPAddressinet0MI
{
    Id = 16,
    Value = System.Net.IPAddress.Parse("218.245.42.83"),
    NullableValue = System.Net.IPAddress.Parse("112.168.142.118"),
},
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 30,
    Value = System.Net.IPAddress.Parse("83.121.225.199"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("226.45.71.12"),
},
            new IPAddressinet0M
{
    Id = 39,
    Value = System.Net.IPAddress.Parse("95.12.87.170"),
    ModelInner = new IPAddressinet0MI
{
    Id = 19,
    Value = System.Net.IPAddress.Parse("235.19.195.13"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("176.62.201.181"),
},
            new IPAddressinet0M
{
    Id = 43,
    Value = System.Net.IPAddress.Parse("115.206.100.105"),
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 50,
    Value = System.Net.IPAddress.Parse("184.71.101.42"),
    ModelInner = new IPAddressinet0MI
{
    Id = 28,
    Value = System.Net.IPAddress.Parse("110.18.238.252"),
    NullableValue = System.Net.IPAddress.Parse("74.156.54.36"),
},
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 58,
    Value = System.Net.IPAddress.Parse("39.113.25.118"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("231.79.40.236"),
},
            new IPAddressinet0M
{
    Id = 67,
    Value = System.Net.IPAddress.Parse("42.118.28.241"),
    ModelInner = new IPAddressinet0MI
{
    Id = 34,
    Value = System.Net.IPAddress.Parse("196.77.3.63"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 76,
    Value = System.Net.IPAddress.Parse("144.130.71.74"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("61.33.132.19"),
},
            new IPAddressinet0M
{
    Id = 82,
    Value = System.Net.IPAddress.Parse("51.98.102.93"),
    ModelInner = new IPAddressinet0MI
{
    Id = 41,
    Value = System.Net.IPAddress.Parse("161.63.230.53"),
    NullableValue = System.Net.IPAddress.Parse("193.226.230.101"),
},
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 85,
    Value = System.Net.IPAddress.Parse("254.79.50.87"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("178.45.98.116"),
},
            new IPAddressinet0M
{
    Id = 86,
    Value = System.Net.IPAddress.Parse("94.228.173.211"),
    ModelInner = new IPAddressinet0MI
{
    Id = 48,
    Value = System.Net.IPAddress.Parse("14.229.223.251"),
    NullableValue = System.Net.IPAddress.Parse("24.59.228.134"),
},
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 90,
    Value = System.Net.IPAddress.Parse("150.1.50.128"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("148.56.110.76"),
},
            new IPAddressinet0M
{
    Id = 94,
    Value = System.Net.IPAddress.Parse("27.224.106.34"),
    ModelInner = new IPAddressinet0MI
{
    Id = 50,
    Value = System.Net.IPAddress.Parse("223.213.191.204"),
    NullableValue = System.Net.IPAddress.Parse("7.71.221.187"),
},
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 98,
    Value = System.Net.IPAddress.Parse("5.248.197.151"),
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 104,
    Value = System.Net.IPAddress.Parse("188.16.78.112"),
    ModelInner = new IPAddressinet0MI
{
    Id = 58,
    Value = System.Net.IPAddress.Parse("163.3.234.229"),
    NullableValue = System.Net.IPAddress.Parse("166.114.148.197"),
},
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 113,
    Value = System.Net.IPAddress.Parse("201.104.77.247"),
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 122,
    Value = System.Net.IPAddress.Parse("161.120.165.166"),
    ModelInner = new IPAddressinet0MI
{
    Id = 66,
    Value = System.Net.IPAddress.Parse("215.214.179.132"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 129,
    Value = System.Net.IPAddress.Parse("170.60.164.233"),
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 138,
    Value = System.Net.IPAddress.Parse("183.82.60.243"),
    ModelInner = new IPAddressinet0MI
{
    Id = 73,
    Value = System.Net.IPAddress.Parse("64.251.240.195"),
    NullableValue = null,
},
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 141,
    Value = System.Net.IPAddress.Parse("114.254.23.151"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("141.69.126.74"),
},
            new IPAddressinet0M
{
    Id = 146,
    Value = System.Net.IPAddress.Parse("229.207.207.158"),
    ModelInner = new IPAddressinet0MI
{
    Id = 81,
    Value = System.Net.IPAddress.Parse("250.19.0.107"),
    NullableValue = null,
},
    NullableValue = System.Net.IPAddress.Parse("88.124.60.137"),
},
            new IPAddressinet0M
{
    Id = 153,
    Value = System.Net.IPAddress.Parse("205.29.194.42"),
    ModelInner = null,
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 156,
    Value = System.Net.IPAddress.Parse("115.82.30.130"),
    ModelInner = new IPAddressinet0MI
{
    Id = 83,
    Value = System.Net.IPAddress.Parse("53.107.16.160"),
    NullableValue = System.Net.IPAddress.Parse("100.162.167.239"),
},
    NullableValue = null,
},
            new IPAddressinet0M
{
    Id = 161,
    Value = System.Net.IPAddress.Parse("62.227.171.243"),
    ModelInner = null,
    NullableValue = System.Net.IPAddress.Parse("177.173.57.29"),
},
            new IPAddressinet0M
{
    Id = 166,
    Value = System.Net.IPAddress.Parse("194.178.74.103"),
    ModelInner = new IPAddressinet0MI
{
    Id = 92,
    Value = System.Net.IPAddress.Parse("205.163.124.20"),
    NullableValue = System.Net.IPAddress.Parse("7.137.221.207"),
},
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
                Assert.That(nullable, Is.EqualTo(System.Net.IPAddress.Parse("8.89.206.27")));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(System.Net.IPAddress.Parse("226.45.71.12")));
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
                Assert.That(nullable, Is.EqualTo(System.Net.IPAddress.Parse("176.62.201.181")));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(System.Net.IPAddress.Parse("231.79.40.236")));
                nullable = await ((IIPAddressSingleTypeinet)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 17;
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
                await ((IIPAddressSingleTypeinet)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatIPAddressinet0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatIPAddressinet0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatIPAddressinet0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[24],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatIPAddressinet0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
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
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatIPAddressinet0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[24],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatIPAddressinet0M.AssertModel(models[0],_testData[7], false);
                        FlatIPAddressinet0M.AssertModel(models[1],_testData[8], false);
                        FlatIPAddressinet0M.AssertModel(models[2],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(models[3],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(models[4],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(models[5],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(models[6],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(models[7],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(models[8],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(models[9],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(models[10],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(models[11],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(models[12],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(models[13],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(models[14],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(models[15],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(models[16],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(models[17],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(models[18],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(models[19],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(models[20],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(models[21],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatIPAddressinet0M.AssertModel(models[0],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(models[1],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(models[2],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(models[3],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(models[4],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(models[5],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(models[6],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(models[7],_testData[29], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatIPAddressinet0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
                        Assert.That(models, Has.Count.EqualTo(26));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatIPAddressinet0M.AssertModel(models[0],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(models[1],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(models[2],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(models[3],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(models[4],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(models[5],_testData[29], false);
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
                parametr1.Value = 82;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatIPAddressinet0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatIPAddressinet0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[19],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IIPAddressSingleTypeinet)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        IPAddressinet0M.AssertModel(models[0],_testData[7], false);
                        IPAddressinet0M.AssertModel(models[1],_testData[8], false);
                        IPAddressinet0M.AssertModel(models[2],_testData[9], false);
                        IPAddressinet0M.AssertModel(models[3],_testData[10], false);
                        IPAddressinet0M.AssertModel(models[4],_testData[11], false);
                        IPAddressinet0M.AssertModel(models[5],_testData[12], false);
                        IPAddressinet0M.AssertModel(models[6],_testData[13], false);
                        IPAddressinet0M.AssertModel(models[7],_testData[14], false);
                        IPAddressinet0M.AssertModel(models[8],_testData[15], false);
                        IPAddressinet0M.AssertModel(models[9],_testData[16], false);
                        IPAddressinet0M.AssertModel(models[10],_testData[17], false);
                        IPAddressinet0M.AssertModel(models[11],_testData[18], false);
                        IPAddressinet0M.AssertModel(models[12],_testData[19], false);
                        IPAddressinet0M.AssertModel(models[13],_testData[20], false);
                        IPAddressinet0M.AssertModel(models[14],_testData[21], false);
                        IPAddressinet0M.AssertModel(models[15],_testData[22], false);
                        IPAddressinet0M.AssertModel(models[16],_testData[23], false);
                        IPAddressinet0M.AssertModel(models[17],_testData[24], false);
                        IPAddressinet0M.AssertModel(models[18],_testData[25], false);
                        IPAddressinet0M.AssertModel(models[19],_testData[26], false);
                        IPAddressinet0M.AssertModel(models[20],_testData[27], false);
                        IPAddressinet0M.AssertModel(models[21],_testData[28], false);
                        IPAddressinet0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        IPAddressinet0M.AssertModel(models[0],_testData[22], false);
                        IPAddressinet0M.AssertModel(models[1],_testData[23], false);
                        IPAddressinet0M.AssertModel(models[2],_testData[24], false);
                        IPAddressinet0M.AssertModel(models[3],_testData[25], false);
                        IPAddressinet0M.AssertModel(models[4],_testData[26], false);
                        IPAddressinet0M.AssertModel(models[5],_testData[27], false);
                        IPAddressinet0M.AssertModel(models[6],_testData[28], false);
                        IPAddressinet0M.AssertModel(models[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IIPAddressSingleTypeinet)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        IPAddressinet0M.AssertModel(models[0],_testData[12], false);
                        IPAddressinet0M.AssertModel(models[1],_testData[13], false);
                        IPAddressinet0M.AssertModel(models[2],_testData[14], false);
                        IPAddressinet0M.AssertModel(models[3],_testData[15], false);
                        IPAddressinet0M.AssertModel(models[4],_testData[16], false);
                        IPAddressinet0M.AssertModel(models[5],_testData[17], false);
                        IPAddressinet0M.AssertModel(models[6],_testData[18], false);
                        IPAddressinet0M.AssertModel(models[7],_testData[19], false);
                        IPAddressinet0M.AssertModel(models[8],_testData[20], false);
                        IPAddressinet0M.AssertModel(models[9],_testData[21], false);
                        IPAddressinet0M.AssertModel(models[10],_testData[22], false);
                        IPAddressinet0M.AssertModel(models[11],_testData[23], false);
                        IPAddressinet0M.AssertModel(models[12],_testData[24], false);
                        IPAddressinet0M.AssertModel(models[13],_testData[25], false);
                        IPAddressinet0M.AssertModel(models[14],_testData[26], false);
                        IPAddressinet0M.AssertModel(models[15],_testData[27], false);
                        IPAddressinet0M.AssertModel(models[16],_testData[28], false);
                        IPAddressinet0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        IPAddressinet0M.AssertModel(models[0],_testData[24], false);
                        IPAddressinet0M.AssertModel(models[1],_testData[25], false);
                        IPAddressinet0M.AssertModel(models[2],_testData[26], false);
                        IPAddressinet0M.AssertModel(models[3],_testData[27], false);
                        IPAddressinet0M.AssertModel(models[4],_testData[28], false);
                        IPAddressinet0M.AssertModel(models[5],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                await ((IIPAddressSingleTypeinet)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 3, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatIPAddressinet0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatIPAddressinet0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[20],_testData[29], false);
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
                await ((IIPAddressSingleTypeinet)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 94, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatIPAddressinet0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[18],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatIPAddressinet0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                 ((IIPAddressSingleTypeinet)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 67, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatIPAddressinet0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatIPAddressinet0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[5],_testData[29], false);
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
                 ((IIPAddressSingleTypeinet)this).DbConnectionMMDynQuerySelectModelBatch(connection, 21, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatIPAddressinet0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatIPAddressinet0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[28],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IIPAddressSingleTypeinet)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 98, query1, 76, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatIPAddressinet0M.AssertModel(models[0],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(models[1],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(models[2],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(models[3],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(models[4],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(models[5],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(models[6],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(models[7],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(models[8],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(models[9],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatIPAddressinet0M.AssertModel(models[0],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(models[1],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(models[2],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(models[3],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(models[4],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(models[5],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(models[6],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(models[7],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(models[8],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(models[9],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(models[10],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(models[11],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(models[12],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(models[13],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(models[14],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(models[15],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(models[16],_testData[29], false);
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
                await ((IIPAddressSingleTypeinet)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 50, query1, 67, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatIPAddressinet0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatIPAddressinet0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[17],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IIPAddressSingleTypeinet)this).DbConnectionSTDynQuerySelectModelBatch(connection, 24, query1, 26, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatIPAddressinet0M.AssertModel(models[0],_testData[5], false);
                        FlatIPAddressinet0M.AssertModel(models[1],_testData[6], false);
                        FlatIPAddressinet0M.AssertModel(models[2],_testData[7], false);
                        FlatIPAddressinet0M.AssertModel(models[3],_testData[8], false);
                        FlatIPAddressinet0M.AssertModel(models[4],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(models[5],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(models[6],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(models[7],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(models[8],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(models[9],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(models[10],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(models[11],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(models[12],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(models[13],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(models[14],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(models[15],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(models[16],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(models[17],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(models[18],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(models[19],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(models[20],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(models[21],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(models[22],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(models[23],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatIPAddressinet0M.AssertModel(models[0],_testData[6], false);
                        FlatIPAddressinet0M.AssertModel(models[1],_testData[7], false);
                        FlatIPAddressinet0M.AssertModel(models[2],_testData[8], false);
                        FlatIPAddressinet0M.AssertModel(models[3],_testData[9], false);
                        FlatIPAddressinet0M.AssertModel(models[4],_testData[10], false);
                        FlatIPAddressinet0M.AssertModel(models[5],_testData[11], false);
                        FlatIPAddressinet0M.AssertModel(models[6],_testData[12], false);
                        FlatIPAddressinet0M.AssertModel(models[7],_testData[13], false);
                        FlatIPAddressinet0M.AssertModel(models[8],_testData[14], false);
                        FlatIPAddressinet0M.AssertModel(models[9],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(models[10],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(models[11],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(models[12],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(models[13],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(models[14],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(models[15],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(models[16],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(models[17],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(models[18],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(models[19],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(models[20],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(models[21],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(models[22],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(models[23],_testData[29], false);
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
                 ((IIPAddressSingleTypeinet)this).DbConnectionDynQuerySelectModelBatch(connection, 85, query1, 94, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatIPAddressinet0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatIPAddressinet0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatIPAddressinet0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatIPAddressinet0M.AssertModel(secondItems2[11],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IIPAddressSingleTypeinet)this).DbConnectionSTSelectModelBatchAsync(connection, 86, 58))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        IPAddressinet0M.AssertModel(models[0],_testData[11], false);
                        IPAddressinet0M.AssertModel(models[1],_testData[12], false);
                        IPAddressinet0M.AssertModel(models[2],_testData[13], false);
                        IPAddressinet0M.AssertModel(models[3],_testData[14], false);
                        IPAddressinet0M.AssertModel(models[4],_testData[15], false);
                        IPAddressinet0M.AssertModel(models[5],_testData[16], false);
                        IPAddressinet0M.AssertModel(models[6],_testData[17], false);
                        IPAddressinet0M.AssertModel(models[7],_testData[18], false);
                        IPAddressinet0M.AssertModel(models[8],_testData[19], false);
                        IPAddressinet0M.AssertModel(models[9],_testData[20], false);
                        IPAddressinet0M.AssertModel(models[10],_testData[21], false);
                        IPAddressinet0M.AssertModel(models[11],_testData[22], false);
                        IPAddressinet0M.AssertModel(models[12],_testData[23], false);
                        IPAddressinet0M.AssertModel(models[13],_testData[24], false);
                        IPAddressinet0M.AssertModel(models[14],_testData[25], false);
                        IPAddressinet0M.AssertModel(models[15],_testData[26], false);
                        IPAddressinet0M.AssertModel(models[16],_testData[27], false);
                        IPAddressinet0M.AssertModel(models[17],_testData[28], false);
                        IPAddressinet0M.AssertModel(models[18],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IIPAddressSingleTypeinet)this).DbConnectionSTSelectModelBatch(connection, 21, 76))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        IPAddressinet0M.AssertModel(models[0],_testData[4], false);
                        IPAddressinet0M.AssertModel(models[1],_testData[5], false);
                        IPAddressinet0M.AssertModel(models[2],_testData[6], false);
                        IPAddressinet0M.AssertModel(models[3],_testData[7], false);
                        IPAddressinet0M.AssertModel(models[4],_testData[8], false);
                        IPAddressinet0M.AssertModel(models[5],_testData[9], false);
                        IPAddressinet0M.AssertModel(models[6],_testData[10], false);
                        IPAddressinet0M.AssertModel(models[7],_testData[11], false);
                        IPAddressinet0M.AssertModel(models[8],_testData[12], false);
                        IPAddressinet0M.AssertModel(models[9],_testData[13], false);
                        IPAddressinet0M.AssertModel(models[10],_testData[14], false);
                        IPAddressinet0M.AssertModel(models[11],_testData[15], false);
                        IPAddressinet0M.AssertModel(models[12],_testData[16], false);
                        IPAddressinet0M.AssertModel(models[13],_testData[17], false);
                        IPAddressinet0M.AssertModel(models[14],_testData[18], false);
                        IPAddressinet0M.AssertModel(models[15],_testData[19], false);
                        IPAddressinet0M.AssertModel(models[16],_testData[20], false);
                        IPAddressinet0M.AssertModel(models[17],_testData[21], false);
                        IPAddressinet0M.AssertModel(models[18],_testData[22], false);
                        IPAddressinet0M.AssertModel(models[19],_testData[23], false);
                        IPAddressinet0M.AssertModel(models[20],_testData[24], false);
                        IPAddressinet0M.AssertModel(models[21],_testData[25], false);
                        IPAddressinet0M.AssertModel(models[22],_testData[26], false);
                        IPAddressinet0M.AssertModel(models[23],_testData[27], false);
                        IPAddressinet0M.AssertModel(models[24],_testData[28], false);
                        IPAddressinet0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        IPAddressinet0M.AssertModel(models[0],_testData[13], false);
                        IPAddressinet0M.AssertModel(models[1],_testData[14], false);
                        IPAddressinet0M.AssertModel(models[2],_testData[15], false);
                        IPAddressinet0M.AssertModel(models[3],_testData[16], false);
                        IPAddressinet0M.AssertModel(models[4],_testData[17], false);
                        IPAddressinet0M.AssertModel(models[5],_testData[18], false);
                        IPAddressinet0M.AssertModel(models[6],_testData[19], false);
                        IPAddressinet0M.AssertModel(models[7],_testData[20], false);
                        IPAddressinet0M.AssertModel(models[8],_testData[21], false);
                        IPAddressinet0M.AssertModel(models[9],_testData[22], false);
                        IPAddressinet0M.AssertModel(models[10],_testData[23], false);
                        IPAddressinet0M.AssertModel(models[11],_testData[24], false);
                        IPAddressinet0M.AssertModel(models[12],_testData[25], false);
                        IPAddressinet0M.AssertModel(models[13],_testData[26], false);
                        IPAddressinet0M.AssertModel(models[14],_testData[27], false);
                        IPAddressinet0M.AssertModel(models[15],_testData[28], false);
                        IPAddressinet0M.AssertModel(models[16],_testData[29], false);
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
                ((IIPAddressSingleTypeinet)this).SetDbConnectionSelectModelParametrs(cmd, 153);
                var models = await ((IIPAddressSingleTypeinet)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
IPAddressinet0M.AssertModel(models[0],_testData[27], false);IPAddressinet0M.AssertModel(models[1],_testData[28], false);IPAddressinet0M.AssertModel(models[2],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IIPAddressSingleTypeinet)this).CreateDbConnectionSelectModelCommand(connection);
                ((IIPAddressSingleTypeinet)this).SetDbConnectionSelectModelParametrs(cmd, 30);
                var models =  ((IIPAddressSingleTypeinet)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
IPAddressinet0M.AssertModel(models[0],_testData[7], false);IPAddressinet0M.AssertModel(models[1],_testData[8], false);IPAddressinet0M.AssertModel(models[2],_testData[9], false);IPAddressinet0M.AssertModel(models[3],_testData[10], false);IPAddressinet0M.AssertModel(models[4],_testData[11], false);IPAddressinet0M.AssertModel(models[5],_testData[12], false);IPAddressinet0M.AssertModel(models[6],_testData[13], false);IPAddressinet0M.AssertModel(models[7],_testData[14], false);IPAddressinet0M.AssertModel(models[8],_testData[15], false);IPAddressinet0M.AssertModel(models[9],_testData[16], false);IPAddressinet0M.AssertModel(models[10],_testData[17], false);IPAddressinet0M.AssertModel(models[11],_testData[18], false);IPAddressinet0M.AssertModel(models[12],_testData[19], false);IPAddressinet0M.AssertModel(models[13],_testData[20], false);IPAddressinet0M.AssertModel(models[14],_testData[21], false);IPAddressinet0M.AssertModel(models[15],_testData[22], false);IPAddressinet0M.AssertModel(models[16],_testData[23], false);IPAddressinet0M.AssertModel(models[17],_testData[24], false);IPAddressinet0M.AssertModel(models[18],_testData[25], false);IPAddressinet0M.AssertModel(models[19],_testData[26], false);IPAddressinet0M.AssertModel(models[20],_testData[27], false);IPAddressinet0M.AssertModel(models[21],_testData[28], false);IPAddressinet0M.AssertModel(models[22],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("114.193.144.241"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("166.44.131.0"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("149.159.86.202"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("203.71.75.0"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("116.244.250.19"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("66.175.205.94"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("196.230.223.13"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("84.248.61.42"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("32.14.61.248"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("154.164.161.221"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("177.172.33.82"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("8.89.206.27"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("216.84.180.69"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("218.245.42.83"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("112.168.142.118"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("83.121.225.199"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("226.45.71.12"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("95.12.87.170"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("235.19.195.13"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("176.62.201.181"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("115.206.100.105"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("184.71.101.42"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("110.18.238.252"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("74.156.54.36"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("39.113.25.118"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("231.79.40.236"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("42.118.28.241"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("196.77.3.63"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("144.130.71.74"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("61.33.132.19"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("51.98.102.93"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("161.63.230.53"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("193.226.230.101"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("254.79.50.87"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("178.45.98.116"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("94.228.173.211"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("14.229.223.251"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("24.59.228.134"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("150.1.50.128"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("148.56.110.76"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("27.224.106.34"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("223.213.191.204"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("7.71.221.187"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("5.248.197.151"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("188.16.78.112"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("163.3.234.229"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("166.114.148.197"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("201.104.77.247"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("161.120.165.166"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("215.214.179.132"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("170.60.164.233"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("183.82.60.243"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("64.251.240.195"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("114.254.23.151"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("141.69.126.74"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("229.207.207.158"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("250.19.0.107"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("88.124.60.137"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("205.29.194.42"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("115.82.30.130"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("53.107.16.160"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("100.162.167.239"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("62.227.171.243"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("177.173.57.29"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("194.178.74.103"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("205.163.124.20"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("7.137.221.207"))));//InnerModel.NullableValue

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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("114.193.144.241"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("166.44.131.0"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("149.159.86.202"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("203.71.75.0"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("116.244.250.19"))));//InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("66.175.205.94"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("196.230.223.13"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("84.248.61.42"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("32.14.61.248"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("154.164.161.221"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("177.172.33.82"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("8.89.206.27"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("216.84.180.69"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("218.245.42.83"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("112.168.142.118"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("83.121.225.199"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("226.45.71.12"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("95.12.87.170"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("235.19.195.13"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("176.62.201.181"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("115.206.100.105"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("184.71.101.42"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("110.18.238.252"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("74.156.54.36"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("39.113.25.118"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("231.79.40.236"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("42.118.28.241"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("196.77.3.63"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("144.130.71.74"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("61.33.132.19"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("51.98.102.93"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("161.63.230.53"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("193.226.230.101"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("254.79.50.87"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("178.45.98.116"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("94.228.173.211"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("14.229.223.251"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("24.59.228.134"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("150.1.50.128"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("148.56.110.76"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("27.224.106.34"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("223.213.191.204"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("7.71.221.187"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("5.248.197.151"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("188.16.78.112"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("163.3.234.229"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("166.114.148.197"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("201.104.77.247"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("161.120.165.166"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("215.214.179.132"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("170.60.164.233"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("183.82.60.243"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("64.251.240.195"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("114.254.23.151"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("141.69.126.74"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("229.207.207.158"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("250.19.0.107"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("88.124.60.137"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("205.29.194.42"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("115.82.30.130"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("53.107.16.160"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("100.162.167.239"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("62.227.171.243"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Net.IPAddress)model[5], Is.EqualTo((System.Net.IPAddress.Parse("177.173.57.29"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Net.IPAddress)model[1], Is.EqualTo((System.Net.IPAddress.Parse("194.178.74.103"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92)));//InnerModel.Id
                Assert.That((System.Net.IPAddress)model[3], Is.EqualTo((System.Net.IPAddress.Parse("205.163.124.20"))));//InnerModel.Value

                Assert.That((System.Net.IPAddress)model[4], Is.EqualTo((System.Net.IPAddress.Parse("7.137.221.207"))));//InnerModel.NullableValue

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
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(IPAddressinet0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IIPAddressSingleTypeinet))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<IPAddressinet0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IIPAddressSingleTypeinet)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_ipaddressinet0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IIPAddressSingleTypeinet)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinet0MI.AssertModel(actual, expect, false);
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
                await ((IIPAddressSingleTypeinet)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_ipaddressinet0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((IIPAddressSingleTypeinet)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinet0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
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
            methodName:"ImportModelInner",
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<IPAddressinet0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IIPAddressSingleTypeinet)this).ImportModelInner(connection, importCollection);
                var models = ((IIPAddressSingleTypeinet)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinet0MI.AssertModel(actual, expect, false);
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
                await ((IIPAddressSingleTypeinet)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IIPAddressSingleTypeinet)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    IPAddressinet0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<IPAddressinet0M>(15);

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
                ((IIPAddressSingleTypeinet)this).ImportModel(connection, importCollection);
                var models = ((IIPAddressSingleTypeinet)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                IPAddressinet0M.AssertModel(models[0],_testData[0], false);
                IPAddressinet0M.AssertModel(models[1],_testData[1], false);
                IPAddressinet0M.AssertModel(models[2],_testData[2], false);
                IPAddressinet0M.AssertModel(models[3],_testData[3], false);
                IPAddressinet0M.AssertModel(models[4],_testData[4], false);
                IPAddressinet0M.AssertModel(models[5],_testData[5], false);
                IPAddressinet0M.AssertModel(models[6],_testData[6], false);
                IPAddressinet0M.AssertModel(models[7],_testData[7], false);
                IPAddressinet0M.AssertModel(models[8],_testData[8], false);
                IPAddressinet0M.AssertModel(models[9],_testData[9], false);
                IPAddressinet0M.AssertModel(models[10],_testData[10], false);
                IPAddressinet0M.AssertModel(models[11],_testData[11], false);
                IPAddressinet0M.AssertModel(models[12],_testData[12], false);
                IPAddressinet0M.AssertModel(models[13],_testData[13], false);
                IPAddressinet0M.AssertModel(models[14],_testData[14], false);
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
                await ((IIPAddressSingleTypeinet)this).ImportModelAsync(connection, importCollection);
                models = await ((IIPAddressSingleTypeinet)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                IPAddressinet0M.AssertModel(models[0],_testData[0], false);
                IPAddressinet0M.AssertModel(models[1],_testData[1], false);
                IPAddressinet0M.AssertModel(models[2],_testData[2], false);
                IPAddressinet0M.AssertModel(models[3],_testData[3], false);
                IPAddressinet0M.AssertModel(models[4],_testData[4], false);
                IPAddressinet0M.AssertModel(models[5],_testData[5], false);
                IPAddressinet0M.AssertModel(models[6],_testData[6], false);
                IPAddressinet0M.AssertModel(models[7],_testData[7], false);
                IPAddressinet0M.AssertModel(models[8],_testData[8], false);
                IPAddressinet0M.AssertModel(models[9],_testData[9], false);
                IPAddressinet0M.AssertModel(models[10],_testData[10], false);
                IPAddressinet0M.AssertModel(models[11],_testData[11], false);
                IPAddressinet0M.AssertModel(models[12],_testData[12], false);
                IPAddressinet0M.AssertModel(models[13],_testData[13], false);
                IPAddressinet0M.AssertModel(models[14],_testData[14], false);
                IPAddressinet0M.AssertModel(models[15],_testData[15], false);
                IPAddressinet0M.AssertModel(models[16],_testData[16], false);
                IPAddressinet0M.AssertModel(models[17],_testData[17], false);
                IPAddressinet0M.AssertModel(models[18],_testData[18], false);
                IPAddressinet0M.AssertModel(models[19],_testData[19], false);
                IPAddressinet0M.AssertModel(models[20],_testData[20], false);
                IPAddressinet0M.AssertModel(models[21],_testData[21], false);
                IPAddressinet0M.AssertModel(models[22],_testData[22], false);
                IPAddressinet0M.AssertModel(models[23],_testData[23], false);
                IPAddressinet0M.AssertModel(models[24],_testData[24], false);
                IPAddressinet0M.AssertModel(models[25],_testData[25], false);
                IPAddressinet0M.AssertModel(models[26],_testData[26], false);
                IPAddressinet0M.AssertModel(models[27],_testData[27], false);
                IPAddressinet0M.AssertModel(models[28],_testData[28], false);
                IPAddressinet0M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_ipaddressinet0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(IPAddressinet0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IIPAddressSingleTypeinet)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinet0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IIPAddressSingleTypeinet)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    IPAddressinet0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

